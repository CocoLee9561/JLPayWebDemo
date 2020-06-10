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
        /// <summary>
        /// 发送http请求
        /// </summary>
        /// <param name="requestParams">请求参数</param>
        /// <param name="requestType">请求方式（POST、GET，默认POST）</param>
        /// <returns>HttpResponseMessage</returns>
        public static HttpResponseMessage SendWebRequest(Dictionary<string, string> requestParams, string requestType = "POST")
        {
            string reqJson = ParseRequestParams(requestParams);

            HttpWebRequest req = FormRequestData(reqJson, requestType);

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

            return HandleResponseMsg(result);
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
            return RSATool.Verify(content, signData, JlpayConfig.jlpay_public_key, "UTF-8"); ;
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
        /// <returns></returns>
        private static HttpWebRequest FormRequestData(string paramData, string requestType)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(JlpayConfig.serverUrl);
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
        private static HttpResponseMessage HandleResponseMsg(string responseData)
        {
            Dictionary<string, string> responseDataDic = JsonHelper.DeserializeStringToDictionary<string, string>(responseData);

            Dictionary<string, string> sortedResponseDataDic = (Dictionary<string, string>)responseDataDic.OrderBy(s => s.Key);

            if (sortedResponseDataDic.ContainsKey("sign"))
                sortedResponseDataDic.Remove("sign");

            string signContent = JsonHelper.SerializeDictionaryToJsonString<string, string>(sortedResponseDataDic);

            string responseContent = Verify(signContent, responseDataDic["sign"]) ? responseData : "{\"ret_code\":\"V1\",\"ret_msg\":\"返回结果验证失败\"}";

            return new HttpResponseMessage { Content = new StringContent(responseContent, Encoding.UTF8, "application/json") };
        }

    }
}
