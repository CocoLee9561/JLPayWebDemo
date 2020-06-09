
namespace JlpayWebApi.Models
{
    public class NotifyData
    {
        /// <summary>
        /// 状态 0-初始状态1-待确认2-成功3-失败4-已撤销5-已退款
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 商户号
        /// </summary>
        public string mch_id { get; set; }
        /// <summary>
        /// 机构号
        /// </summary>
        public string org_code { get; set; }
        /// <summary>
        /// 平台订单号 返回的嘉联订单号
        /// </summary>
        public string transaction_id { get; set; }
        /// <summary>
        /// 外部订单号 商家系统内部订单号
        /// </summary>
        public string out_trade_no { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        public string total_fee { get; set; }
        /// <summary>
        /// 订单时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string order_time { get; set; }
        /// <summary>
        /// 返回码 00表示成功
        /// </summary>
        public string ret_code { get; set; }
        /// <summary>
        /// 描述信息 错误原因
        /// </summary>
        public string ret_msg { get; set; }
        /// <summary>
        /// 签名
        /// </summary>
        public string sign { get; set; }
        /// <summary>
        /// 终端号
        /// </summary>
        public string term_no { get; set; }
        /// <summary>
        /// 终端设备号
        /// </summary>
        public string device_info { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 操作员 商家收银员编号
        /// </summary>
        public string op_user_id { get; set; }
        /// <summary>
        /// 门店号 商家分店号
        /// </summary>
        public string op_shop_id { get; set; }
        /// <summary>
        /// 实际付款金额 交易金额-优惠总金额
        /// </summary>
        public string finnal_amount { get; set; }
        /// <summary>
        /// 优惠总金额
        /// </summary>
        public string discount_amount { get; set; }
        /// <summary>
        /// 优惠活动名称
        /// </summary>
        public string discount_name { get; set; }
        /// <summary>
        /// 优惠信息
        /// </summary>
        public string coupon_Info { get; set; }
    }
}