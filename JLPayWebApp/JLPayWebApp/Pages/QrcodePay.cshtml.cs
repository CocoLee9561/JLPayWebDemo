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
            
            // 排序: 除sign字段以外,所有字段名按ASCII码从小到大排序为JSON格式待签名串
            SortedDictionary<string, object> requestInfo = new SortedDictionary<string, object>(requestDic);

            // 生成签名：用SHA256WithRSA算法私钥签名，得到sign值


            // http请求接口并得到返回结果

            // 解析返回结果，得到sign

            // 排序: 除sign字段以外,所有返回字段名按ASCII码从小到大排序为JSON格式待签名串

            // 生成签名：用SHA256WithRSA算法私钥签名，得到新的sign值

            // 验证签名：对比新的sign值和返回的sign是否相同

        }

        public string createSign()
        {
            return "";
        }


        public void handleSubmit(QrcodePayRequest request)
        {
            // 处理表单请求
            Console.WriteLine("");
        }
    }
}
