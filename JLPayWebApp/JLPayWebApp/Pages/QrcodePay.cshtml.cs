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
                { "org_code", "������" },
                { "mch_id", "�̻���" },
                { "nonce_str", "����ַ���" },
                { "sign", "ǩ��" },
                { "out_trade_no", "�ⲿ������" },
                { "body", "��Ʒ����" },
                { "attach", "��Ʒ����" },
                { "total_fee", "���׽��" },
                { "pay_type", "��������" },
                { "mch_create_ip", "�ն�IP" },
                { "notify_url", "�ص���ַ" }
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
                { "term_no", "�ն˺�" },
                { "sign_type", "ǩ����ʽ" },
                { "payment_valid_time", "������Ч��" },
                { "limit_pay", "ָ��֧����ʽ" },
                { "profit_sharing", "�Ƿ����" },
                { "is_hire_purchase", "���ڱ�ʶ" },
                { "hire_purchase_num", "������" },
                { "hire_purchase_seller_percent", "���ҳе��������ѱ���" },
                { "remark", "��ע" },
                { "op_user_id", "����Ա" },
                { "op_shop_id", "�ŵ��" },
                { "device_info", "�ն��豸��" },
                { "longitude", "����" },
                { "latitude", "γ��" },
                { "sub_appid", "�����˺�ID" }
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
            // ���������
        }
    }
}
