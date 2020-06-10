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
        [Required]
        public string org_code { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [Required]
        public string mch_id { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [Required]
        public string nonce_str { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [Required]
        public string sign { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [Required]
        public string out_trade_no { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [Required]
        public string body { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [Required]
        public string attach { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [Required]
        public decimal total_fee { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [Required]
        public string pay_type { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        [Required]
        public string mch_create_ip { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [Required]
        public string notify_url { get; set; }

        //以下是非必传参数

        /// <summary>
        /// 终端号
        /// </summary>
        public string term_no { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        public string sign_type { get; set; }

        /// <summary>
        /// 订单有效期
        /// </summary>
        public string payment_valid_time { get; set; }

        /// <summary>
        /// 指定支付方式
        /// </summary>
        public string limit_pay { get; set; }

        /// <summary>
        /// 是否分账
        /// </summary>
        public string profit_sharing { get; set; }

        /// <summary>
        /// 分期标识
        /// </summary>
        public string is_hire_purchase { get; set; }

        /// <summary>
        /// 分期数
        /// </summary>
        public string hire_purchase_num { get; set; }

        /// <summary>
        /// 卖家承担的手续费比例
        /// </summary>
        public string hire_purchase_seller_percent { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string op_user_id { get; set; }

        /// <summary>
        /// 门店号
        /// </summary>
        public string op_shop_id { get; set; }

        /// <summary>
        /// 终端设备号
        /// </summary>
        public string device_info { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public string longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public string latitude { get; set; }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        public string sub_appid { get; set; }
    }
}
