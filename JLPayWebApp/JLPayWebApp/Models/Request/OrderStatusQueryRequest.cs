using JLPayWebApp.Attris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLPayWebApp.Models
{
    public class OrderStatusQueryRequest
    {
        [ParamInfo("org_code", "text", "机构号", Required = true)]
        public string org_code { get; set; }

        [ParamInfo("mch_id", "text", "商户号", Required = true)]
        public string mch_id { get; set; }

        [ParamInfo("nonce_str", "text", "随机字符串", Required = true)]
        public string nonce_str { get; set; }

        [ParamInfo("out_trade_no", "text", "商户订单号", Required = true)]
        public string out_trade_no { get; set; }

        //[ParamInfo("sign", "text", "签名", Required = true)]
        //public string sign { get; set; }
             
        [ParamInfo("sign_type", "text", "签名方式")]
        public string sign_type { get; set; }

        [ParamInfo("transaction_id", "text", "平台订单号")]
        public string transaction_id { get; set; }
    }
}
