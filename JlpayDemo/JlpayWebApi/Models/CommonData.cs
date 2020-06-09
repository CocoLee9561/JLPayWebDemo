/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
*/
namespace JlpayWebApi.Models
{
    public class CommonData
    {
        /// <summary>
        /// 接口类型
        /// </summary>
        public string service { get; set; }
        /// <summary>
        /// 商户号
        /// </summary>
        public string mch_id { get; set; }
        /// <summary>
        /// 机构号
        /// </summary>
        public string org_code { get; set; }
        /// <summary>
        /// 签名
        /// </summary>
        public string sign { get; set; }
        /// <summary>
        /// 随机串
        /// </summary>
        public string nonce_str { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string version { get; set; }
        /// <summary>
        /// 字符集 utf-8
        /// </summary>
        public string charset { get; set; }
        /// <summary>
        /// 签名方式 RSA
        /// </summary>
        public string sign_type { get; set; }
    }
}