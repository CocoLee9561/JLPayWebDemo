using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JLPayWebApp.Utils
{
    public class HttpHelper
    {
        #region 页面正在用的方法

        /// <summary>
        /// 发送http请求
        /// </summary>
        /// <param name="reqJson">请求参数</param>
        /// <param name="url">路径</param>
        /// <param name="requestType">请求方式（POST、GET，默认POST）</param>
        /// <returns></returns>
        public static string SendWebRequest(string reqJson, string url, string requestType = "POST")
        {
            HttpWebRequest req = FormRequestData(reqJson, requestType, url);

            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }

            Stream respstream = resp.GetResponseStream();
            //获取响应内容  
            StreamReader reader = new StreamReader(respstream, Encoding.UTF8);
            string result = reader.ReadToEnd();

            return result;
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="requestData">请求参数</param>
        /// <returns></returns>
        public static Dictionary<string, string> sortRequestParams(string requestData)
        {
            var requestDic = JsonConvert.DeserializeObject<SortedDictionary<string, string>>(requestData);

            // 排序: 所有字段名按ASCII码从小到大排序为JSON格式待签名串
            SortedDictionary<string, string> requestInfo = new SortedDictionary<string, string>(requestDic);
            Dictionary<string, string> paramForSignDic = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> pair in requestInfo)
            {
                if (pair.Value != null && pair.Value != "")
                {
                    paramForSignDic.Add(pair.Key, pair.Value);
                }
            }

            return paramForSignDic;
        }

        /// <summary>
        /// 验证签名
        /// </summary>
        /// <param name="responseData">返回参数</param>
        /// <returns></returns>
        public static bool VerifySignature(string responseData)
        {
            // 排序
            SortedDictionary<string, string> sortedResponseDataDic = JsonConvert.DeserializeObject<SortedDictionary<string, string>>(responseData);// new SortedDictionary<string, string>(getProperties<QrcodePayResponse>(qrcodePayResponse));
            var signRes = sortedResponseDataDic["sign"];
            // 得到去掉sign后的参数
            if (!string.IsNullOrEmpty(signRes))
            {
                sortedResponseDataDic.Remove("sign");
            }
            string signContent = JsonConvert.SerializeObject(sortedResponseDataDic);

            // 验证签名
            bool isSignValid = Verify(signContent, signRes);

            return isSignValid;
        }
        #endregion


        #region 请求封装参考
        /// <summary>
        /// 发送http请求
        /// </summary>
        /// <param name="requestParams">请求参数</param>
        /// <param name="requestType">请求方式（POST、GET，默认POST）</param>
        /// <param name="url">路径</param>
        /// <returns>HttpResponseMessage</returns>
        public static HttpResponseMessage SendWebRequest(Dictionary<string, string> requestParams,string url, string requestType = "POST")
        {
            string reqJson = ParseRequestParams(requestParams);

            HttpWebRequest req = FormRequestData(reqJson, requestType, url);

            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }

            Stream respstream = resp.GetResponseStream();
            //获取响应内容  
            StreamReader reader = new StreamReader(respstream, Encoding.UTF8);
            string result = reader.ReadToEnd();

            return HandleParseResponseMsg(result);
        }

        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        private static string Signature(string param)
        {
            return RSATool.Sign(param, JlpayConfig.merchant_private_key, "UTF-8");
        }

        /// <summary>
        /// 验签
        /// </summary>
        /// <param name="content">待验证的数据</param>
        /// <param name="signData">签名</param>
        /// <returns></returns>
        private static bool Verify(string content, string signData)
        {
            return RSATool.Verify(content, signData,JlpayConfig.jlpay_public_key , "UTF-8"); ;
        }

        /// <summary>
        /// 转换请求参数，加上签名
        /// </summary>
        /// <param name="requestParams">初始请求参数</param>
        /// <returns></returns>
        private static string ParseRequestParams(Dictionary<string, string> requestParams)
        {
            string requestParamsJson = JsonHelper.SerializeDictionaryToJsonString<string, string>(requestParams);
            string signData = Signature(requestParamsJson);
            requestParams.Add("sign", signData);

            string reqJson = JsonHelper.SerializeDictionaryToJsonString(requestParams);
            return reqJson;
        }


        /// <summary>
        /// 组装请求参数
        /// </summary>
        /// <param name="paramData">请求参数</param>
        /// <param name="requestType">请求方式</param>
        /// <param name="url">路径</param>
        /// <returns></returns>
        public static HttpWebRequest FormRequestData(string paramData, string requestType, string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = requestType;
            req.ContentType = "application/json";
            byte[] data = Encoding.UTF8.GetBytes(paramData);
            req.ContentLength = data.Length;
            try
            {
                Stream reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            catch (WebException ex)
            {
                Console.Write("MicroPayRequest error：" + ex);
            }
            return req;
        }

        /// <summary>
        /// 处理http返回数据
        /// </summary>
        /// <param name="responseData">http返回数据</param>
        /// <returns>HttpResponseMessage</returns>
        private static HttpResponseMessage HandleParseResponseMsg(string responseData)
        {
            Dictionary<string, string> responseDataDic = JsonHelper.DeserializeStringToDictionary<string, string>(responseData);

            Dictionary<string, string> sortedResponseDataDic = (Dictionary<string, string>)responseDataDic.OrderBy(s => s.Key);

            if (sortedResponseDataDic.ContainsKey("sign"))
                sortedResponseDataDic.Remove("sign");

            string signContent = JsonHelper.SerializeDictionaryToJsonString<string, string>(sortedResponseDataDic);

            string responseContent = Verify(signContent, responseDataDic["sign"]) ? responseData : "{\"ret_code\":\"V1\",\"ret_msg\":\"返回结果验证失败\"}";

            return new HttpResponseMessage { Content = new StringContent(responseContent, Encoding.UTF8, "application/json") };
        }
        #endregion


    }
}
