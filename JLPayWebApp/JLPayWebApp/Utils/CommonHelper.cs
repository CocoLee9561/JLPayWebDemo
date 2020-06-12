using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ThoughtWorks.QRCode.Codec;

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
        /// 生成二维码
        /// </summary>
        public static void qrcodeShow()
        {

        }
        /// <summary>
        /// 生成二维码图片
        /// </summary>
        /// <param name="content">二维码内容</param>
        /// <param name="filePath">图片保存地址，需要绝对路径</param>
        public static void CreateQrcodeImage(string content, string filePath)
        {
            int size = 10;  //二维码中每个小点的大小
            Bitmap image = CreateImgCode(content, size); //生成二维码图片

            //保存图片，需要图片的绝对地址，这是web项目
            image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
        }


        /// &lt;summary>  
        /// 生成二维码图片  
        /// &lt;/summary>  
        /// &lt;param name="codeNumber">要生成二维码的字符串&lt;/param>       
        /// &lt;param name="size">二维码每个颗粒大小尺寸&lt;/param>  
        /// &lt;returns>二维码图片&lt;/returns>  
        private static Bitmap CreateImgCode(string codeNumber, int size)
        {
            //创建二维码生成类  
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            //设置编码模式  
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            //设置编码测量度  
            qrCodeEncoder.QRCodeScale = size;
            //设置编码版本  
            qrCodeEncoder.QRCodeVersion = 0;
            //设置编码错误纠正  
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            //生成二维码图片  
            Bitmap image = qrCodeEncoder.Encode(codeNumber);

            return image;
        }
    }
}
