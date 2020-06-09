using JlpayWebApi.Models;
using JlpayWebApi.Uitily;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace JlpayWebApi.Controllers
{
    public class NotifyController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage PayNotifyInfo([FromBody]NotifyData Json)
        {
            //结果集
            SortedDictionary<string, string> respinfo = new SortedDictionary<string, string> {
                { "status", Json.status },
                { "mch_id", Json.mch_id },
                { "org_code", Json.org_code },
                { "transaction_id", Json.transaction_id },
                { "out_trade_no", Json.out_trade_no },
                { "total_fee", Json.total_fee },
                { "order_time", Json.order_time },
                { "ret_code", Json.ret_code },
                { "ret_msg", Json.ret_msg },
                { "term_no", Json.term_no },
                { "device_info", Json.device_info },
                { "remark", Json.remark },
                { "op_user_id", Json.op_user_id },
                { "op_shop_id", Json.op_shop_id },
                { "finnal_amount", Json.finnal_amount },
                { "discount_amount", Json.discount_amount },
                { "discount_name", Json.discount_name },
                { "coupon_Info", Json.coupon_Info }

            };
           
            //验签字段
            Dictionary<string, string> signDic = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> item in respinfo)
            {
                if (item.Value.Length != 0)
                {
                    signDic.Add(item.Key, item.Value);
                }
            }
            string requestparam = JsonUility.SerializeDictionaryToJsonString<string, string>(signDic);
            bool signverify = RSATool.Verify(requestparam, Json.sign, JlpayConfig.jlpay_public_key, "utf-8");
            string json = "{\"retCode\":\"fail\"}";
            if (signverify)
            {
                json = "{\"retCode\":\"success\"}";
            }
            return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
        }
    }
}
