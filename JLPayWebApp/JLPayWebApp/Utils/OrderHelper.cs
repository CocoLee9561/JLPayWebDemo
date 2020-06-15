using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace JLPayWebApp.Utils
{
    public class OrderHelper
    {
        private static string _outTradeNo = null;
        /// <summary>
        /// 外部订单号/商户订单号
        /// </summary>
        public static string outTradeNo
        {
            get
            {
                if (string.IsNullOrEmpty(_outTradeNo))
                {
                    return CommonHelper.GetTimeStampTen();
                }
                return _outTradeNo;
            }
            set
            {
                 _outTradeNo = value;
            }
        }


        private static string _transactionId = "";
        /// <summary>
        /// 平台订单号
        /// </summary>
        public static string transactionId
        {
            get
            {
                return _transactionId;
            }
            set
            {
                _transactionId = value;
            }

        }

        /// <summary>
        /// 获取IP
        /// </summary>
        /// <returns></returns>
        private static string getLocalIp() 
        {
            // 手机用户 用搜狐提供的接口获取 http://pv.sohu.com/cityjson?ie=utf-8

            // PC获取IP：
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP = _IPAddress.ToString();
                }
            }
            return AddressIP;
        }

        public static string localIpAddress
        {
            get
            {
                return getLocalIp();
            }
        }
    }
}
