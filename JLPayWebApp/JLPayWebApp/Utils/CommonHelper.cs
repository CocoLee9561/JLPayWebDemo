using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace JLPayWebApp.Utils
{
    public class CommonHelper
    {
        /// <summary>
        /// 获取类属性及属性值
        /// </summary>
        public Dictionary<string, string> getProperties<T>(T t)
        {
            string tStr = string.Empty;
            Dictionary<string, string> responseDataDic = new Dictionary<string, string>();
            if (t == null)
            {
                return responseDataDic;
            }
            PropertyInfo[] properties = t.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            if (properties.Length <= 0)
            {
                return responseDataDic;
            }
            foreach (System.Reflection.PropertyInfo item in properties)
            {
                string name = item.Name;
                object value = item.GetValue(t, null);
                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    responseDataDic.Add(name, value.ToString());
                }
                else
                {
                    getProperties(value);
                }
            }
            return responseDataDic;
        }


        /// <summary> 
        /// 获取时间戳 10位
        /// </summary> 
        /// <returns></returns> 
        public static string GetTimeStampTen()
        {
            var time = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            return time.ToString();
        }

        /// <summary>
        /// 生成二维码图片
        /// </summary>
        /// <param name="content">二维码内容</param>
        public static string CreateQrcodeImage(string content)
        {
            int size = 10;  //二维码中每个小点的大小
            Bitmap image = CreateImgCode(content, size); //生成二维码图片

            //保存图片，需要图片的绝对地址，这是web项目
            //image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            var strBase64 = "data:image/jpeg;base64," + ImgToBase64String(image);
            return strBase64;
        }


        /// &lt;summary>  
        /// 生成二维码图片  
        /// &lt;/summary>  
        /// &lt;param name="content">要生成二维码的字符串&lt;/param>       
        /// &lt;param name="size">二维码每个颗粒大小尺寸&lt;/param>  
        /// &lt;returns>二维码图片&lt;/returns>  
        public static Bitmap CreateImgCode(string content, int size)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(20); 
        }


        //图片转为base64编码的字符串
        public static string ImgToBase64String(Bitmap bmp)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        //base64编码的字符串转为图片
        public static Bitmap Base64StringToImage(string strbase64)
        {
            try
            {
                byte[] arr = Convert.FromBase64String(strbase64);
                MemoryStream ms = new MemoryStream(arr);
                Bitmap bmp = new Bitmap(ms);
                ms.Close();
                return bmp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
