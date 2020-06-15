using JLPayWebApp.Attris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLPayWebApp.Models
{
    public class OrderRefundResponse
    {
        [ParamInfo("ret_code", "text", "返回码")]
        public string ret_code { get; set; }

        [ParamInfo("ret_msg", "text", "描述信息")]
        public string ret_msg { get; set; }

        [ParamInfo("sign", "text", "签名")]
        public string sign { get; set; }

        [ParamInfo("status", "text", "状态")]
        public string status { get; set; }

        [ParamInfo("mch_id", "text", "商户号")]
        public string mch_id { get; set; }

        [ParamInfo("org_code", "text", "机构号")]
        public string org_code { get; set; }

        [ParamInfo("transaction_id ", "text", "平台订单号")]
        public string transaction_id { get; set; }

        [ParamInfo("out_trade_no", "text", "外部订单号")]
        public string out_trade_no { get; set; }

        [ParamInfo("chn_transaction_id", "text", "渠道订单号")]
        public string chn_transaction_id { get; set; }

        [ParamInfo("ori_out_trade_no", "text", "原外部订单号")]
        public string ori_out_trade_no { get; set; }

        [ParamInfo("order_time", "text", "订单时间")]
        public string order_time { get; set; }

        [ParamInfo("trans_time", "text", "交易时间")]
        public string trans_time { get; set; }

        [ParamInfo("pay_type", "text", "交易类型")]
        public string pay_type { get; set; }
    }
}
