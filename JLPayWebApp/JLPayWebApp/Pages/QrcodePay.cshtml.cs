using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using JLPayWebApp.Attris;
using JLPayWebApp.Models;
using JLPayWebApp.Utils;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JLPayWebApp.Pages
{
    public class QrcodePayModel : PageModel
    {
        public static string notifyContent;
        public static string checkNotifySign;
        public List<ParamInfoAttribute> paraRequiredList = new List<ParamInfoAttribute>();
        public List<ParamInfoAttribute> paraNotRequiredList = new List<ParamInfoAttribute>();
        public static string url = JlpayConfig.serverUrl + "qrcodepay";
        public string imgBase64 = "";
        public static bool isSignResValid = false;

        Timer timer = null;
        public void OnGet()
        {
            paraRequiredList = new List<ParamInfoAttribute>();
            paraNotRequiredList = new List<ParamInfoAttribute>();
            QrcodePayRequest reqParams = new QrcodePayRequest();
            Type type = reqParams.GetType();
            var props = type.GetProperties();

            foreach(var prop in props)
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

            //timer = new Timer();
            //timer.Enabled = true;
            //timer.Interval = 1000; //ִ�м��ʱ��,��λΪ���� 
            //timer.Start();
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(checkNotify);
        }

        public void OnPost(QrcodePayRequest request)
        {
            request = getRequestTestData();
            var requestData = JsonConvert.SerializeObject(request);
            string requestParamStr = buildRequestParams(requestData);

            // http����
            string responseData = HttpHelper.SendWebRequest(requestParamStr, url);
            ViewData["responseParams"] = responseData;

            // �������ؽ��
            QrcodePayResponse qrcodePayResponse = JsonConvert.DeserializeObject<QrcodePayResponse>(responseData);
            if (string.IsNullOrEmpty(qrcodePayResponse.ret_code) || qrcodePayResponse.ret_code != "00" || string.IsNullOrEmpty(qrcodePayResponse.sign))
            {
                Console.WriteLine("����ʧ��");
                return;
            }
            // ��֤ǩ��
            isSignResValid = HttpHelper.VerifySignature(responseData);
            if(isSignResValid) {
                OrderHelper.transactionId = qrcodePayResponse.transaction_id;
            }
            // ���ɶ�ά��
            if (isSignResValid && !string.IsNullOrEmpty(qrcodePayResponse.code_url)) createQrcode(qrcodePayResponse.code_url);
            ViewData["checkRspSign"] = isSignResValid ? "���ؽ����֤�ɹ�" : "���ؽ����֤ʧ��";

        }

        public QrcodePayRequest getRequestTestData()
        {
            return new QrcodePayRequest()
            {
                attach = "��ɨ��Ʒ����",
                body = "��ɨ����",
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
                remark = "��ɨ��ע",
                term_no = "12345678",
                total_fee = "1",
                sign_type = JlpayConfig.sign_type
            };
        }

        public string buildRequestParams(string requestData)
        {
            // ����
            Dictionary<string, string> paramForSignDic = HttpHelper.sortRequestParams(requestData);
            string paramForSignJson = JsonConvert.SerializeObject(paramForSignDic);

            // ����ǩ��
            var requestSign = RSATool.Sign(paramForSignJson, JlpayConfig.merchant_private_key, "UTF-8");
            // ����������sign
            paramForSignDic.Add("sign", requestSign);
            // �������
            string requestParamStr = JsonConvert.SerializeObject(paramForSignDic);

            ViewData["originSignStr"] = requestSign;
            ViewData["requestParams"] = requestParamStr;

            return requestParamStr;
        }

        public void createQrcode(string content)
        {
            imgBase64 = CommonHelper.CreateQrcodeImage(content);
        }

        public void checkNotify(object source, ElapsedEventArgs e)
        {
            if(!string.IsNullOrEmpty(notifyContent))
            {
                timer.Stop();
                //updateViewData();
            }
        }

        public void updateViewData()
        {
            ViewData["notifyContent"] = notifyContent;
            ViewData["checkNotifySign"] = checkNotifySign;
        }

    }
}
