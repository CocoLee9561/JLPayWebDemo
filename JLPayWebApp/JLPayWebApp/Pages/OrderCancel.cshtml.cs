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
    public class OrderCancelModel : PageModel
    {
        public static List<ParamInfoAttribute> paraRequiredList = new List<ParamInfoAttribute>();
        public static List<ParamInfoAttribute> paraNotRequiredList = new List<ParamInfoAttribute>();
        public static string url = JlpayConfig.serverUrl + "cancel";
        public static bool isSignResValid = false;
        public void OnGet()
        {
            paraRequiredList = new List<ParamInfoAttribute>();
            paraNotRequiredList = new List<ParamInfoAttribute>();
            OrderCancelRequest reqParams = new OrderCancelRequest();
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

        public void OnPost(OrderCancelRequest request)
        {
            request = getRequestTestData();
            var requestData = JsonConvert.SerializeObject(request);
            string requestParamStr = buildRequestParams(requestData);

            // http请求
            string responseData = HttpHelper.SendWebRequest(requestParamStr, url);
            ViewData["responseParams"] = responseData;

            // 解析返回结果
            OrderCancelResponse orderCancelResponse = JsonConvert.DeserializeObject<OrderCancelResponse>(responseData);
            if (string.IsNullOrEmpty(orderCancelResponse.ret_code) || orderCancelResponse.ret_code != "00" || string.IsNullOrEmpty(orderCancelResponse.sign))
            {
                Console.WriteLine("交易失败");
                return;
            }
            // 验证签名
            isSignResValid = HttpHelper.VerifySignature(responseData);
        }

        public OrderCancelRequest getRequestTestData()
        {
            return new OrderCancelRequest()
            {
                latitude = "22.144889",
                longitude = "113.571558",
                mch_create_ip = OrderHelper.localIpAddress,
                mch_id = "84944035812A01P",
                nonce_str = "123456789abcdefg",
                org_code = "50265462",
                out_trade_no = "cancel_1592219469", // "cancel_" + OrderHelper.outTradeNo,
                ori_out_trade_no = "1592219469", //OrderHelper.outTradeNo,
                ori_transaction_id = "651012089233738756915223", //OrderHelper.transactionId
                remark = "主扫备注",
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
