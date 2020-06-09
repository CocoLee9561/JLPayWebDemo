﻿using JlpayWebApi.Models;
using JlpayWebApi.Uitily;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace JlpayWebApi.Controllers
{
    public class GetOpenIdController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage GetOpenIdRequest([FromBody] RequestData obj)
        {
            SortedDictionary<string, string> requestInfo = new SortedDictionary<string, string> {
                { "service", "pay.qrcode.getopenid" },
                { "mch_id", "84933015945A000" },
                { "org_code", "50264239" },
                { "nonce_str", "123456789" },
                { "pay_type", "wxpay" },
                { "auth_code", "134836798199127886" },
                { "sub_appid", "wx77ce81b42d454ae2" },
                ///<summary>
                ///非必传字段
                ///</summary>
                { "channel_agent", "" },
                { "app_up_identifier", "" },
                { "version", "V1.0.1" },
                { "charset", "utf-8" },
                { "sign_type", "RSA256" }

            };
            //待签名字段
            Dictionary<string, string> signDic = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> item in requestInfo)
            {
                if (item.Value.Length != 0)
                {
                    signDic.Add(item.Key, item.Value);
                }
            }
            string requestparam = JsonUility.SerializeDictionaryToJsonString<string, string>(signDic);
            string signData = RSATool.Sign(requestparam, JlpayConfig.merchant_private_key, "UTF-8");
            requestInfo.Add("sign", signData);
            Dictionary<string, string> paramDic = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> item in requestInfo)
            {
                if (item.Value.Length != 0)
                {
                    paramDic.Add(item.Key, item.Value);
                }
            }
            string reqJson = JsonUility.SerializeDictionaryToJsonString(paramDic);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(JlpayConfig.serverUrl);
            req.Method = "POST";
            req.ContentType = "application/json";
            byte[] data = Encoding.UTF8.GetBytes(reqJson);
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
            paramDic.Clear();
            paramDic = JsonUility.DeserializeStringToDictionary<string, string>(result);
            signDic.Clear();
            var list = paramDic.OrderBy(s => s.Key);
            foreach (var s in list)
            {
                if (s.Key != "sign" && s.Value != "")
                {
                    signDic.Add(s.Key, s.Value);
                }
            }
            string sigcontent = JsonUility.SerializeDictionaryToJsonString<string, string>(signDic);
            //验证返回结果
            bool ret = RSATool.Verify(sigcontent, paramDic["sign"], JlpayConfig.jlpay_public_key, "UTF-8");
            if (ret)
                return new HttpResponseMessage { Content = new StringContent(result, Encoding.UTF8, "application/json") };
            else
            {
                string json = "{\"ret_code\":\"V1\",\"ret_msg\":\"返回结果验证失败\"}";
                return new HttpResponseMessage { Content = new StringContent(json, Encoding.UTF8, "application/json") };
            }
        }
    }
}