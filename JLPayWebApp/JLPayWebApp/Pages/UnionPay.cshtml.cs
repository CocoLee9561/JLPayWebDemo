using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLPayWebApp.Attris;
using JLPayWebApp.Models;
using JLPayWebApp.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace JLPayWebApp.Pages
{
    public class UnionPayModel : PageModel
    {
        public static List<ParamInfoAttribute> paraRequiredList = new List<ParamInfoAttribute>();
        public static List<ParamInfoAttribute> paraNotRequiredList = new List<ParamInfoAttribute>();
        public static string url = JlpayConfig.serverUrl + "unionjspay";
        public static bool isSignResValid = false;
        public void OnGet()
        {
            paraRequiredList = new List<ParamInfoAttribute>();
            paraNotRequiredList = new List<ParamInfoAttribute>();
            UnionPayRequest reqParams = new UnionPayRequest();
            Type type = reqParams.GetType();
            var props = type.GetProperties();

            foreach (var prop in props)
            {
                foreach (object attribute in prop.GetCustomAttributes(true))
                {
                    ParamInfoAttribute pri = (ParamInfoAttribute)attribute;
                    if (pri != null && pri.Required)
                    {
                        paraRequiredList.Add(pri);
                    }
                    if (pri != null && !pri.Required)
                    {
                        paraNotRequiredList.Add(pri);
                    }
                }
            }

        }

        public void OnPost(UnionPayRequest request)
        {
            request = getRequestTestData();
            var requestData = JsonConvert.SerializeObject(request);
            string requestParamStr = buildRequestParams(requestData);

            // http请求
            string responseData = HttpHelper.SendWebRequest(requestParamStr, url);
            ViewData["responseParams"] = responseData;

            // 解析返回结果
            UnionPayResponse unionPayResponse = JsonConvert.DeserializeObject<UnionPayResponse>(responseData);
            if (string.IsNullOrEmpty(unionPayResponse.ret_code) || unionPayResponse.ret_code != "00" || string.IsNullOrEmpty(unionPayResponse.sign))
            {
                Console.WriteLine("交易失败");
                return;
            }
            // 验证签名
            isSignResValid = HttpHelper.VerifySignature(responseData);
        }

        public UnionPayRequest getRequestTestData()
        {
            return new UnionPayRequest()
            {
                attach = "主扫商品描述",
                body = "主扫测试",
                device_info = "80005611",
                latitude = "22.144889",
                longitude = "113.571558",
                mch_create_ip = OrderHelper.localIpAddress,
                mch_id = "84944035812A01P",
                nonce_str = "123456789abcdefg",
                notify_url = "http://127.0.0.1/api/callback",
                op_shop_id = "100001",
                op_user_id = "1001",
                org_code = "50265462",
                out_trade_no = OrderHelper.outTradeNo,
                pay_type = "alipay",
                payment_valid_time = "20",
                remark = "主扫备注",
                term_no = "12345678",
                total_fee = "1",
                sign_type = JlpayConfig.sign_type
            };
        }

        public string buildRequestParams(string requestData)
        {
            // 排序
            Dictionary<string, string> paramForSignDic = HttpHelper.sortRequestParams(requestData);
            string paramForSignJson = JsonConvert.SerializeObject(paramForSignDic);

            // 生成签名
            var requestSign = RSATool.Sign(paramForSignJson, JlpayConfig.merchant_private_key, "UTF-8");
            // 参数中增加sign
            paramForSignDic.Add("sign", requestSign);
            // 生成入参
            string requestParamStr = JsonConvert.SerializeObject(paramForSignDic);

            ViewData["originSignStr"] = requestSign;
            ViewData["requestParams"] = requestParamStr;

            return requestParamStr;
        }

    }
}
