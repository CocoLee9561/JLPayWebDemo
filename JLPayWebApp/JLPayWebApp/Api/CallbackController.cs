using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLPayWebApp.Models;
using JLPayWebApp.Pages;
using JLPayWebApp.Utils;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JLPayWebApp.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallbackController : ControllerBase
    {
        // GET: api/<CallbackController>
        [HttpGet]
        public string Get([FromQuery] OrderStatusQueryResponse queryParams)
        {
            var paramData = JsonConvert.SerializeObject(queryParams);
            QrcodePayModel.notifyContent = paramData;
            if (queryParams.ret_code == "00" && !string.IsNullOrEmpty(queryParams.sign)) {
                var isSignResValid = HttpHelper.VerifySignature(paramData);
                QrcodePayModel.checkNotifySign = isSignResValid ? "验签通过": "验签不通过"; 
            }
            return "{\"retCode\": \"success\"}";
        }

        // POST api/<CallbackController>
        [HttpPost]
        public string Post([FromBody] OrderStatusQueryResponse queryParams)
        {
            QrcodePayModel.notifyContent = JsonConvert.SerializeObject(queryParams);

            if (queryParams.ret_code == "00" && !string.IsNullOrEmpty(queryParams.sign))
            {
                var isSignResValid = HttpHelper.VerifySignature(QrcodePayModel.notifyContent);
                QrcodePayModel.checkNotifySign = isSignResValid ? "验签通过" : "验签不通过";
            }
            return "{\"retCode\": \"success\"}";
        }

    }
}
