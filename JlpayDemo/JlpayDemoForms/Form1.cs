using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JlpayDemoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string baseurl = "http://10.150.142.122:8089";
        private void Micropay_Btn_Click(object sender, EventArgs e)
        {
            string result = "";
            //请修改成自己网站的地址
            string url = baseurl+"/api/MicroPay/MicroPayRequest";
            //首先创建一个HttpWebRequest,申明传输方式POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            string authcodestr = this.textBox1.Text;
            //订单号
            string contentformat = "\"authcodestr\":\"{0}\"";
            string content = "{" + String.Format(contentformat, authcodestr) + "}";
            //添加POST参数
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
            }
            catch (WebException ex)
            { 
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK);
            }


            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }
            Stream stream = resp.GetResponseStream();
            //获取响应内容  
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            this.richTextBox1.Text = result;
        }

        private void Micropayasyn_Btn_Click(object sender, EventArgs e)
        {
            string result = "";
            //请修改成自己网站的地址
            string url = baseurl + "/api/MicroPayAsyn/MicroPayAsynRequest";
            //首先创建一个HttpWebRequest,申明传输方式POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            string authcodestr = this.textBox1.Text;
            //订单号
            string contentformat = "\"authcodestr\":\"{0}\"";
            string content = "{" + String.Format(contentformat, authcodestr) + "}";
            //添加POST参数
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK);
            }


            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }
            Stream stream = resp.GetResponseStream();
            //获取响应内容  
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            this.richTextBox1.Text = result;
        }

        private void Qrcodepay_Btn_Click(object sender, EventArgs e)
        {
            string result = "";
            //请修改成自己网站的地址
            string url = baseurl + "/api/QrcodePay/QrcodePayRequest";
            //首先创建一个HttpWebRequest,申明传输方式POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            string authcodestr = this.textBox1.Text;
            //订单号
            string contentformat = "\"authcodestr\":\"{0}\"";
            string content = "{" + String.Format(contentformat, authcodestr) + "}";
            //添加POST参数
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK);
            }


            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }
            Stream stream = resp.GetResponseStream();
            //获取响应内容  
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            this.richTextBox1.Text = result;
        }

        private void QueryOrder_Btn_Click(object sender, EventArgs e)
        {
            string result = "";
            //请修改成自己网站的地址
            string url = baseurl + "/api/QueryOrder/QueryOrderRequest";
            //首先创建一个HttpWebRequest,申明传输方式POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            string authcodestr = this.textBox1.Text;
            //订单号
            string contentformat = "\"authcodestr\":\"{0}\"";
            string content = "{" + String.Format(contentformat, authcodestr) + "}";
            //添加POST参数
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK);
            }


            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }
            Stream stream = resp.GetResponseStream();
            //获取响应内容  
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            this.richTextBox1.Text = result;
        }

        private void RefundOrder_Btn_Click(object sender, EventArgs e)
        {
            string result = "";
            //请修改成自己网站的地址
            string url = baseurl + "/api/RefundOrder/RefundOrderRequest";
            //首先创建一个HttpWebRequest,申明传输方式POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            string authcodestr = this.textBox1.Text;
            //订单号
            string contentformat = "\"authcodestr\":\"{0}\"";
            string content = "{" + String.Format(contentformat, authcodestr) + "}";
            //添加POST参数
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK);
            }


            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }
            Stream stream = resp.GetResponseStream();
            //获取响应内容  
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            this.richTextBox1.Text = result;
        }

        private void CancelOrder_Btn_Click(object sender, EventArgs e)
        {
            string result = "";
            //请修改成自己网站的地址
            string url = baseurl + "/api/CancelOrder/CancelOrderRequest";
            //首先创建一个HttpWebRequest,申明传输方式POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            string authcodestr = this.textBox1.Text;
            //订单号
            string contentformat = "\"authcodestr\":\"{0}\"";
            string content = "{" + String.Format(contentformat, authcodestr) + "}";
            //添加POST参数
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK);
            }


            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }
            Stream stream = resp.GetResponseStream();
            //获取响应内容  
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            this.richTextBox1.Text = result;
        }

        private void AppPay_Btn_Click(object sender, EventArgs e)
        {
            string result = "";
            //请修改成自己网站的地址
            string url = baseurl + "/api/AppPay/AppPayRequest";
            //首先创建一个HttpWebRequest,申明传输方式POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            string authcodestr = this.textBox1.Text;
            //订单号
            string contentformat = "\"authcodestr\":\"{0}\"";
            string content = "{" + String.Format(contentformat, authcodestr) + "}";
            //添加POST参数
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK);
            }


            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }
            Stream stream = resp.GetResponseStream();
            //获取响应内容  
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            this.richTextBox1.Text = result;
        }

        private void OfficialPay_Btn_Click(object sender, EventArgs e)
        {
            string result = "";
            //请修改成自己网站的地址
            string url = baseurl + "/api/OfficialPay/OfficialPayRequest";
            //首先创建一个HttpWebRequest,申明传输方式POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            string authcodestr = this.textBox1.Text;
            //订单号
            string contentformat = "\"authcodestr\":\"{0}\"";
            string content = "{" + String.Format(contentformat, authcodestr) + "}";
            //添加POST参数
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK);
            }


            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }
            Stream stream = resp.GetResponseStream();
            //获取响应内容  
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            this.richTextBox1.Text = result;
        }

        private void WapH5Pay_Btn_Click(object sender, EventArgs e)
        {
            string result = "";
            //请修改成自己网站的地址
            string url = baseurl + "/api/WebH5Pay/WebH5PayRequest";
            //首先创建一个HttpWebRequest,申明传输方式POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            string authcodestr = this.textBox1.Text;
            //订单号
            string contentformat = "\"authcodestr\":\"{0}\"";
            string content = "{" + String.Format(contentformat, authcodestr) + "}";
            //添加POST参数
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK);
            }


            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }
            Stream stream = resp.GetResponseStream();
            //获取响应内容  
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            this.richTextBox1.Text = result;
        }

        private void ChnQuery_Btn_Click(object sender, EventArgs e)
        {
            string result = "";
            //请修改成自己网站的地址
            string url = baseurl + "/api/ChnQueryOrder/ChnQueryOrderRequest";
            //首先创建一个HttpWebRequest,申明传输方式POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            string authcodestr = this.textBox1.Text;
            //订单号
            string contentformat = "\"authcodestr\":\"{0}\"";
            string content = "{" + String.Format(contentformat, authcodestr) + "}";
            //添加POST参数
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            try
            {
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK);
            }


            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException ex)
            {
                resp = (HttpWebResponse)ex.Response;
            }
            Stream stream = resp.GetResponseStream();
            //获取响应内容  
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            this.richTextBox1.Text = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
