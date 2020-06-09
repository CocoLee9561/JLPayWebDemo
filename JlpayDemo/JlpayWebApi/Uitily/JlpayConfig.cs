
namespace JlpayWebApi.Uitily
{
    public class JlpayConfig
    {
        //嘉联支付公钥pkcs#8 2048
        public static string jlpay_public_key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAp80Cyw5T4fRD0mkZAM0uOnxv6G84v8UElpoxlPdt2q0Q3oLJ8SAcLVOXoCA7Yd/gHgdDwP7aAfbb1U5/srzwqpd/rkdf3d2pPbljy2GW46n53VUK6f1wrghJi/jUsuZvr/lfgjaeKQEoyajzS/PbXQaKEtQSmG/9S7cmctktjMGU2uNH8j36H9dQPLucgcVZLSjkxH2UsMg0LabLC+l5zJDmnHcHqBlEPPl/mUDUNYj4S2bWdCQJ5IrBVJoNGQikRy01jE6NCrMFNxfAnphBJ/RGzBqH5J3icQ7ICUOVYNftJu0A6OSj6g3We+SWkytzWGixjqo67faP/+YddicjmwIDAQAB";
        
        //开发者私钥pkcs#8 2048
        public static string merchant_private_key = @"MIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCYsG6ZD5grOaiEnKjPzx6Zyjlz333axXEownxXSyificBai+OadgXr74ZHQFIjA/uBwDh9UB3sZ/HA5O2EYbmc1poBjcWu0KHnS7gWYUUb5LyrQp8E8yTJjb2gtz1/5NP+3I9ha+hlx59I3M0izEwkUGGo0fGe69Bk+sBLbovRZ7mfM16u6t4zDh5BHKFNsxzRdMoKvqz55uFuSVqCfGOsX/1skBhtSTPAy6d2dJcQFJJMsroLtdJsJgOdgApYH7BXnvZxaArLrxb1JRI71ll4v/HD3gk19T/be9edfIySXm3HZ00VegQEBYBiaf32Zk8HiQInjdjmZEL0kLrr4VLDAgMBAAECggEAHSQvN48+X6GVhBnSLjc9g+SQqojRIFvmiPz1dkOl8Sz9RUrFmclEwA7q9dZU1tH/wnfJUEFmNKRyA3qtykJMhp5+riU8wWyYOei9rafK5NP3HkiMyQkO0Fj5BB904V/vBglaZCGQLTy4LdPWYvnS3mto+Ct5jfc7wsoIwVzL2p9B2jyN4sXqKJvoRrRHNIWoEY+BlRUa63c4OvdrLdq6uY4EXJ9iMM3f6sGQ97bHhHH6uWEWG3G7FCvVkOtC8mHHsVJMgU8/N/dna9ZhskamcMCqPaOMwPIZ9PubwkkGSs65JEyomwIhR5P4M/E01d+p83hQOfS/iNfk1Xp5OgOCwQKBgQDGWcj8Xme1/oEmVd1LOhKL/8TX4L0JgY/GqiQCqHDlGrG528MpUmPVdM4UPoZT2zycnGHyTjKQjodYFDnPBKweAZiRhUd9vQgS0SbQl1V6saYCXYgYOIHD5WbPydavg2E2pW1I5kAga3md9mjZ1D1I+ObPRz7KTbh1jFjDmxuTKwKBgQDFETd1uxuoRsPNNmP5TeY5ErLpJYfRy6M/ZexmucAAKOAADX13AF6ZeWWNdie/0yUYk9RaG9PYYZzVWuubZ6hqZy0pfpfnNaZKudsalAp5mgK0klgFXWxiWv4soN+7ahZElDoZo/7GVY2bsKmb17t9B00QCTkBDj6jdnpOKsVSyQKBgQCdh1dBX3S8rKlDmfQLt85dE7/wt5NKxnQ6kovQ9JfczMuT0X55Be816vN0Tof+d2L2+pgriYFNH3VMNZwH1y0fE6NpB1HVAdk0oJlUFqyTqh0vSbs5iT8+JqX1ptZzRENj1BQsTnllhhXrp3R0c8RMfSlKO8oZf4pdCR7CEyDeSwKBgEKvdcX4H/7Mm3t42VHGo45Snoo4sgIzV7WfZuTIHImxS0OZTQiU7m4e31eEUSUfbSEo/SXU3tYNCgZEsw+ufxYqfeTZust5oyEMTXFsATNvA1VZZEHEgGW0BujRM4R2/LwOMK72iMNStg2mNW7QDNjdPJ2dkVWjHV0xPWfwHz/JAoGBAI9KS3IH5yie3o3GQnYkSs/BzTl/c4SyyETc/GEfL7jKIaZUVIbMwIuqrbZlURtFkCWUSBq+XwrKYPsw392HnjDRr3J593Bua3houfCmExlfXu7YG6Cq39D3Kinpzx0U0sI1AXUMMyvEpuJr8BDX3pPlknN9Yu4ZbUZSEXaKAwc7";
       
        //开发者公钥
        public static string merchant_public_key = @"此处填写开发者公钥";

        //应用ID
        public static string appId = "此处填写应用APPID";

        //合作伙伴ID：partnerID
        public static string pid = "此处填写账号PID（partner id）";


        //嘉联支付网关
        //测试服
        public static string serverUrl = "https://app-dev.jlpay.com/ext/qrcode/trans/gateway/";
        //生产服
        // public static string serverUrl = "https://app.jlpay.com:1980/ext/qrcode/trans/gateway/";


        //编码，无需修改
        public static string charset = "utf-8";
        //签名类型，支持RSA256（推荐！）、RSA
        public static string sign_type = "RSA256";
        //版本号，无需修改
        public static string version = "1.0.1";
    }
}