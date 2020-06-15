using JLPayWebApp.Attris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLPayWebApp.Models
{
    public class UnionPayRequest
    {
        [ParamInfo("org_code", "text", "机构号", Required = true)]
        public string org_code { get; set; }

        [ParamInfo("mch_id", "text", "商户号", Required = true)]
        public string mch_id { get; set; }

        [ParamInfo("nonce_str", "text", "随机字符串", Required = true)]
        public string nonce_str { get; set; }

        [ParamInfo("sign", "text", "签名", Required = true)]
        public string sign { get; set; }

        [ParamInfo("pay_type", "text", "交易类型", Required = true)]
        public string pay_type { get; set; }

        [ParamInfo("app_up_identifier", "text", "银联支付标识", Required = true)]
        public string app_up_identifier { get; set; }

        [ParamInfo("user_auth_code", "text", "用户授权码", Required = true)]
        public string user_auth_code { get; set; }

        [ParamInfo("out_trade_no", "text", "商户订单号", Required = true)]
        public string out_trade_no { get; set; }

        [ParamInfo("body ", "text", "商品标题", Required = true)]
        public string body { get; set; }

        [ParamInfo("attach", "text", "商品描述", Required = true)]
        public string attach { get; set; }

        [ParamInfo("total_fee", "text", "交易金额", Required = true)]
        public string total_fee { get; set; }

        [ParamInfo("mch_create_ip", "text", "终端IP", Required = true)]
        public string mch_create_ip { get; set; }

        [ParamInfo("notify_url", "text", "回调地址", Required = true)]
        public string notify_url { get; set; }



        [ParamInfo("term_no", "text", "终端号")]
        public string term_no { get; set; }

        [ParamInfo("sign_type", "text", "签名方式")]
        public string sign_type { get; set; }

        [ParamInfo("payment_valid_time", "text", "订单有效期")]
        public string payment_valid_time { get; set; }

        [ParamInfo("limit_pay", "text", "指定支付方式")]
        public string limit_pay { get; set; }

        [ParamInfo("profit_sharing", "text", "是否分账")]
        public string profit_sharing { get; set; }

        [ParamInfo("is_hire_purchase", "text", "分期标识")]
        public string is_hire_purchase { get; set; }

        [ParamInfo("hire_purchase_num", "text", "分期数")]
        public string hire_purchase_num { get; set; }

        [ParamInfo("hire_purchase_seller_percent", "text", "卖家承担的手续费比例")]
        public string hire_purchase_seller_percent { get; set; }

        [ParamInfo("remark", "text", "备注")]
        public string remark { get; set; }

        [ParamInfo("op_user_id", "text", "操作员")]
        public string op_user_id { get; set; }

        [ParamInfo("op_shop_id", "text", "门店号")]
        public string op_shop_id { get; set; }

        [ParamInfo("device_info", "text", "终端设备号")]
        public string device_info { get; set; }

        [ParamInfo("longitude", "text", "经度")]
        public string longitude { get; set; }

        [ParamInfo("latitude", "text", "纬度")]
        public string latitude { get; set; }
    }
}
