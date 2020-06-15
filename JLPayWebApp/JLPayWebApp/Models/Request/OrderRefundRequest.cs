using JLPayWebApp.Attris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLPayWebApp.Models
{
    public class OrderRefundRequest
    {
        [ParamInfo("org_code", "text", "机构号", Required = true)]
        public string org_code { get; set; }

        [ParamInfo("mch_id", "text", "商户号", Required = true)]
        public string mch_id { get; set; }

        [ParamInfo("nonce_str", "text", "随机字符串", Required = true)]
        public string nonce_str { get; set; }

        //[ParamInfo("sign", "text", "签名", Required = true)]
        //public string sign { get; set; }

        [ParamInfo("sign_type", "text", "签名方式")]
        public string sign_type { get; set; }

        [ParamInfo("out_trade_no", "text", "外部订单号", Required = true)]
        public string out_trade_no { get; set; }

        [ParamInfo("ori_out_trade_no", "text", "原外部订单号")]
        public string ori_out_trade_no { get; set; }

        [ParamInfo("ori_transaction_id", "text", "原平台订单号", Required = true)]
        public string ori_transaction_id { get; set; }

        [ParamInfo("total_fee", "text", "交易金额", Required = true)]
        public string total_fee { get; set; }

        [ParamInfo("remark", "text", "备注")]
        public string remark { get; set; }

        [ParamInfo("mch_create_ip", "text", "终端IP")]
        public string mch_create_ip { get; set; }

        [ParamInfo("longitude", "text", "经度")]
        public string longitude { get; set; }

        [ParamInfo("latitude", "text", "纬度")]
        public string latitude { get; set; }
    }
}
