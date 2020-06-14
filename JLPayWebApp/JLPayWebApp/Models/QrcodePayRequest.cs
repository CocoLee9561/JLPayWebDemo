using JLPayWebApp.Attris;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JLPayWebApp.Models
{
    /// <summary>
    /// 扫码支付入参实体
    /// </summary>
    public class QrcodePayRequest
    {
        /// <summary>
        /// 机构号
        /// </summary>
        [ParamInfo("org_code", "text", "机构号", Required = true, stringLength =10)]
        public string org_code { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [ParamInfo("mch_id", "text", "商户号", Required = true)]
        public string mch_id { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [ParamInfo("nonce_str", "text", "随机字符串", Required = true)]
        public string nonce_str { get; set; }

        ///// <summary>
        ///// 签名
        ///// </summary>
        //[ParamInfo("sign", "text", "签名", Required = true)]
        //public string sign { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [ParamInfo("out_trade_no", "text", "外部订单号", Required = true)]
        public string out_trade_no { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [ParamInfo("body", "text", "商品标题", Required = true)]
        public string body { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [ParamInfo("attach", "text", "商品描述", Required = true)]
        public string attach { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [ParamInfo("total_fee", "text", "交易金额", Required = true)]
        public string total_fee { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [ParamInfo("pay_type", "text", "交易类型", Required = true)]
        public string pay_type { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        [ParamInfo("mch_create_ip", "text", "终端IP", Required = true)]
        public string mch_create_ip { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [ParamInfo("notify_url", "text", "回调地址", Required = true)]
        public string notify_url { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [ParamInfo("term_no", "text", "终端号")]
        public string term_no { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [ParamInfo("sign_type", "text", "签名方式")]
        public string sign_type { get; set; }

        /// <summary>
        /// 订单有效期
        /// </summary>
        [ParamInfo("payment_valid_time", "text", "订单有效期")]
        public string payment_valid_time { get; set; }

        /// <summary>
        /// 指定支付方式
        /// </summary>
        [ParamInfo("limit_pay", "text", "指定支付方式")]
        public string limit_pay { get; set; }

        /// <summary>
        /// 是否分账
        /// </summary>
        [ParamInfo("profit_sharing", "text", "是否分账")]
        public string profit_sharing { get; set; }

        /// <summary>
        /// 分期标识
        /// </summary>
        [ParamInfo("is_hire_purchase", "text", "分期标识")]
        public string is_hire_purchase { get; set; }

        /// <summary>
        /// 分期数
        /// </summary>
        [ParamInfo("hire_purchase_num", "text", "分期数")]
        public string hire_purchase_num { get; set; }

        /// <summary>
        /// 卖家承担的手续费比例
        /// </summary>
        [ParamInfo("hire_purchase_seller_percent", "text", "卖家承担的手续费比例")]
        public string hire_purchase_seller_percent { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [ParamInfo("remark", "text", "备注")]
        public string remark { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [ParamInfo("op_user_id", "text", "操作员")]
        public string op_user_id { get; set; }

        /// <summary>
        /// 门店号
        /// </summary>
        [ParamInfo("op_shop_id", "text", "门店号")]
        public string op_shop_id { get; set; }

        /// <summary>
        /// 终端设备号
        /// </summary>
        [ParamInfo("device_info", "text", "终端设备号")]
        public string device_info { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [ParamInfo("longitude", "text", "经度")]
        public string longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [ParamInfo("latitude", "text", "纬度")]
        public string latitude { get; set; }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        [ParamInfo("sub_appid", "text", "公众账号ID")]
        public string sub_appid { get; set; }
    }
}
