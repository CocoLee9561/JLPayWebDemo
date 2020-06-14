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
    public class OfficialPayModel : PageModel
    {
        public static string TestModel;

        public static List<ParamInfoAttribute> paraRequiredList = new List<ParamInfoAttribute>();
        public static List<ParamInfoAttribute> paraNotRequiredList = new List<ParamInfoAttribute>();
        public static string url = JlpayConfig.serverUrl + "officialPay";
        public static string imgBase64 = "";
        public static bool isSignResValid = false;
        public void OnGet()
        {
            paraRequiredList = new List<ParamInfoAttribute>();
            paraNotRequiredList = new List<ParamInfoAttribute>();
            OfficialPayRequest reqParams = new OfficialPayRequest();
            Type type = reqParams.GetType();// 等价于 typeof(OfficialPayRequest);
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

        public void OnPost(OfficialPayRequest request)
        {
            request = getRequestTestData();
            var requestData = JsonConvert.SerializeObject(request);
            string requestParamStr = buildRequestParams(requestData);

            // http请求
            string responseData = HttpHelper.SendWebRequest(requestParamStr, url);
            ViewData["responseParams"] = responseData;

            // 解析返回结果
            OfficialPayResponse officialPayResponse = JsonConvert.DeserializeObject<OfficialPayResponse>(responseData);
            if (string.IsNullOrEmpty(officialPayResponse.ret_code) || officialPayResponse.ret_code != "00" || string.IsNullOrEmpty(officialPayResponse.sign))
            {
                Console.WriteLine("交易失败");
                return;
            }
            // 验证签名
            isSignResValid = HttpHelper.VerifySignature(responseData);

        }

        public OfficialPayRequest getRequestTestData()
        {
            return new OfficialPayRequest()
            {
                attach = "主扫商品描述",
                body = "主扫测试",
                device_info = "80005611",
                latitude = "22.144889",
                longitude = "113.571558",
                mch_create_ip = "172.20.6.21",
                mch_id = "84944035812A01P",
                nonce_str = "123456789abcdefg",
                notify_url = "http://127.0.0.1/qrcode/notify/",
                op_shop_id = "100001",
                op_user_id = "1001",
                org_code = "50265462",
                out_trade_no = CommonHelper.GetTimeStampTen(),
                pay_type = "alipay",
                payment_valid_time = "20",
                remark = "主扫备注",
                term_no = "12345678",
                total_fee = "1",
                sign_type = "RSA256"
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

        public static void createQrcode(string content)
        {
            string imgurl = JlpayConfig.baseUrl + Guid.NewGuid().ToString().Replace("-", "") + ".png";
            imgBase64 = CommonHelper.CreateQrcodeImage(content, imgurl);
        }

    }
}
