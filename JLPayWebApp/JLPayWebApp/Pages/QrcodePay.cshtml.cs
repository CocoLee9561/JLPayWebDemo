using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLPayWebApp.Models;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JLPayWebApp.Pages
{
    public class QrcodePayModel : PageModel
    {
        
        public void OnGet()
        {
            //QrcodePayRequest reqParams = new QrcodePayRequest();
            //JArray r = JsonConvert.DeserializeObject<JArray>(JsonConvert.SerializeObject(reqParams));
            //foreach(var item in r) { }
        }

        public void OnPost(QrcodePayRequest request)
        {
            var req = HttpContext.Request.Form;
            request.sign = "";
            var requestDic = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonConvert.SerializeObject(request));
            
            // ����: ��sign�ֶ�����,�����ֶ�����ASCII���С��������ΪJSON��ʽ��ǩ����
            SortedDictionary<string, object> requestInfo = new SortedDictionary<string, object>(requestDic);

            // ����ǩ������SHA256WithRSA�㷨˽Կǩ�����õ�signֵ


            // http����ӿڲ��õ����ؽ��

            // �������ؽ�����õ�sign

            // ����: ��sign�ֶ�����,���з����ֶ�����ASCII���С��������ΪJSON��ʽ��ǩ����

            // ����ǩ������SHA256WithRSA�㷨˽Կǩ�����õ��µ�signֵ

            // ��֤ǩ�����Ա��µ�signֵ�ͷ��ص�sign�Ƿ���ͬ

        }

        public string createSign()
        {
            return "";
        }


        public void handleSubmit(QrcodePayRequest request)
        {
            // ���������
            Console.WriteLine("");
        }
    }
}
