using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;

namespace JLPayWebApp.Pages
{
    public class QrcodePayModel : PageModel
    {
        
        public void OnGet()
        {
            Dictionary<string, string> mustSendParamsText = new Dictionary<string, string> {
                { "org_code", "机构号" },
                { "mch_id", "商户号" },
                { "nonce_str", "随机字符串" },
                { "sign", "签名" },
                { "out_trade_no", "外部订单号" },
                { "body", "商品标题" },
                { "attach", "商品描述" },
                { "total_fee", "交易金额" },
                { "pay_type", "交易类型" },
                { "mch_create_ip", "终端IP" },
                { "notify_url", "回调地址" }
            };
            Dictionary<string, string> mustSendParamsValue = new Dictionary<string, string> {
                { "org_code", "" },
                { "mch_id", "" },
                { "nonce_str", "" },
                { "sign", "" },
                { "out_trade_no", "" },
                { "body", "" },
                { "attach", "" },
                { "total_fee", "" },
                { "pay_type", "" },
                { "mch_create_ip", "" },
                { "notify_url", "" }
            };
            Dictionary<string, string> optionalSendParamsText = new Dictionary<string, string> {
                { "term_no", "终端号" },
                { "sign_type", "签名方式" },
                { "payment_valid_time", "订单有效期" },
                { "limit_pay", "指定支付方式" },
                { "profit_sharing", "是否分账" },
                { "is_hire_purchase", "分期标识" },
                { "hire_purchase_num", "分期数" },
                { "hire_purchase_seller_percent", "卖家承担的手续费比例" },
                { "remark", "备注" },
                { "op_user_id", "操作员" },
                { "op_shop_id", "门店号" },
                { "device_info", "终端设备号" },
                { "longitude", "经度" },
                { "latitude", "纬度" },
                { "sub_appid", "公众账号ID" }
            };
            Dictionary<string, string> optionalSendParamsValue = new Dictionary<string, string> {
                { "term_no", "" },
                { "sign_type", "" },
                { "payment_valid_time", "" },
                { "limit_pay", "" },
                { "profit_sharing", "" },
                { "is_hire_purchase", "" },
                { "hire_purchase_num", "" },
                { "hire_purchase_seller_percent", "" },
                { "remark", "" },
                { "op_user_id", "" },
                { "op_shop_id", "" },
                { "device_info", "" },
                { "longitude", "" },
                { "latitude", "" },
                { "sub_appid", "" }
            };
            ViewData["mustSendParamsKeys"] = mustSendParamsText.Keys;
            ViewData["mustSendParamsText"] = mustSendParamsText;
            ViewData["mustSendParamsValue"] = mustSendParamsValue;
            ViewData["optionalSendParamsText"] = optionalSendParamsText;
            ViewData["optionalSendParamsValue"] = optionalSendParamsValue;
        }


        public void handleClick()
        {
            // 处理表单请求
        }
    }
}
