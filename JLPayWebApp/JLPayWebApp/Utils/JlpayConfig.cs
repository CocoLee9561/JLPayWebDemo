using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLPayWebApp.Utils
{
    public class JlpayConfig
    {
        //嘉联支付公钥pkcs#8 2048
        public static string jlpay_public_key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAhGeA0KhZMD+GeQ8yTr1+OAtEx4psRCeZYbeLNOnWXCdxLhfayECwFaJFE+trxLh3J469ZeXcQnrGVrZx4h7MNkoxuVFa5ZCzbqpawkif3qdN7bI+g8ALTquJFUpsOJzjpKL2UYzdZnUHVErEZv8pDGLiamKkAXjunz8u9vbbaH0i+Nz4CEoFtOfIBetFkl1lVNGkvh7sNvFIgO5njxzSeucJfp2hpcn5tfB+FYkAKN/7I6uOhZGTw8OZlAyMjKOC2NitfofqMT493V/6z9jY0JfUt0oDsAQhGhkV1DqaldnBi+wHAR7oZuKusRwB5FxY4PoSDSgMJXK7lvh1nHjWewIDAQAB";

        //机构私钥pkcs#8 2048  
        public static string merchant_private_key = @"MIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDK1BR6q6MxVPASSqgFrVKCDVoReME7sE60WGEZGJnL3L94ZUPHqdMsLSXgWrnHskXBrJ9M8VEf0fAEpDU/31p790ixT9Zqsdr9JW8WVqC5ctPXU8UCmhBUT5K0lzruGBvezgR8egisNfdTGUyrBAJTvy1eCk2e2RE/cGddNAdKquhYFhR0MjgkbIGdvmnGfpEvlUcG7Ax3Nf6cZ2nm4/PbZBSplTGiWd32V2yrciA6sK78g1lIZJ6t0ZNjge/3LY6m+s5z+WhlFByBGaZZpPxSzhJ9/jRwvKFqFv3lApp4NPDdwNTbRUJAE5vSATsAr/Gvb0eGXy9ncOsNvTNqsI93AgMBAAECggEALEGyZkHlTfJWn+ciWnrDMhVvvbg3kaqawcc3CJ7RkCYOsVqHO53WsiD3zsh9GRHRHr1n1QYiyWqpkJmz9MfrmnkOp4HgK0+7lNkCMEGeuFhR2P4yUqsDPSJPxI/rD+C61Bbn67FFCy6LVNqEXBx31YY1g/uDjFGY7dq88x1TKftVLUnNiPkZ73i8Fl4riHpL37xv6cABAbKJgqKAQLB8XXlcGyEZuYw2w8yx600BZjO1p4iA516G2GMwG79w2rwFh1Lye6Bkqy+pzHlNJ97BfuenB0IfBsvoFvhTsFjFz/AOENN/zJtX89zLRpou9aMn8mOeXC5nAaeeJ16iGxi9YQKBgQDyaz4BBq37bMBT3SVm1ihVYiXoTIfIwk6ZokO5Seg9JjVZm+ba29MBDIlSX3YW4r7p1VoV6yUVgrolLJ3RoBxPwVEqTyq5gGR/hwhIk1SAJRqQpAIYmrPK6ZkoNQH3rY41z5HQNzYHasj/2JDHfMRDRYzRsOErQ57DcNxrkEOy5QKBgQDWMQiTafXmNEuD6c3Auaq5p1V0PjlksArtJ8D2OycpPv9w27+U0AQZtWW9EBFKqiGJFktpmvwc2CHytYC3HQyDy82zEFj0JWn+APVWl8VBABDr7EvEmcJlKnt+4tYP1qXoOXqNxN8ZVawDGexgnSkXyyL3TjXZddZPu0wqtqRHKwKBgQCWey/QHz9c9ZMl+/89qO78oaJ6Yxde7g8wm2OC33gEjXVMnNRfQ1nmKswLkCqT5kkwijoTpRYuFipK7TlCaStp7szdgKs635KC/2WK97nami21X7nVYCL/cKacKNuBzgCbMrCHGd62F/mRp/OngbGrOL9DY5NC8gTZuXN6aeE8aQKBgEgLnjLXhVq1ZGEul4Kn8QEZg+jhtTRk8ofqw0EPjJCXHBy+DabkgTyUg3Ago3BV4YnW8e7Hrt2U5XZaDr2JC9iZCMueSA13ODuz3tINos/GUerJRIMQpQ6aR4fajN4u+QcvrkVZXyGKa51vbs7gjh3uuggtSnem5ztSaMBFRuSZAoGBAMk3swwhjXlsEGsMBv3j0P95tzZa0djNE8II14xjLXmYZSkK/WWTLet71XzeOIvutZMP84wmTLyheMDGAZlK/nj729a1YDwxpFJBMl2mycpwTegcEqnkZn+zykm0ZCR9IssLhl7geajMUIwRAnnWxDS9EwZCnbhz30zbIvUMFAMO";
        //public static string merchant_private_key = @"MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCnzQLLDlPh9EPSaRkAzS46fG/obzi/xQSWmjGU923arRDegsnxIBwtU5egIDth3+AeB0PA/toB9tvVTn+yvPCql3+uR1/d3ak9uWPLYZbjqfndVQrp/XCuCEmL+NSy5m+v+V+CNp4pASjJqPNL89tdBooS1BKYb/1LtyZy2S2MwZTa40fyPfof11A8u5yBxVktKOTEfZSwyDQtpssL6XnMkOacdweoGUQ8+X+ZQNQ1iPhLZtZ0JAnkisFUmg0ZCKRHLTWMTo0KswU3F8CemEEn9EbMGofkneJxDsgJQ5Vg1+0m7QDo5KPqDdZ75JaTK3NYaLGOqjrt9o//5h12JyObAgMBAAECggEAU/KhqhqR5qIAaDzCEH+V2Ba3Gc7C0lXrlLixg3hB0jvxC5DdHK/WyOpgGfDmJHIPOpah0+TsBj2M/2sVQcN6l63RZ8w3btTdPY8JGQ/KoD1CTvOj0SpE/BwTR16GcrYMPDqDCK7wc00sLa9DgMUQArspyn+kifTFAOMw7hYuzpKeXzGvWnwp6dF3o8JqzuPC3LVsb8FTlQoHiBejDaBHCJH0MiaHFqkdEVzDBBLFp9iGGgR69gT26ITDZs6xFYt3YbHv1bGcezXmVdTJsxaDLN6xrVkwSH6oVZFmHA7oDUorUk9PbwGqWigN1OOwBTjlRQpEoDQQ7TM8Tn4JcaOosQKBgQDdrsomJGcmJYFgnuecK7UU+QPC4nGMQ+51lK+b1iRk/mUsM3ay5A5wtMOl6vdUOAx6IEcOLFpUYAzo7MYISGOrxLWsv1faDZWaVNeol3CDVZQq8/TFOLD0HgkqvDTm6rBuuDLt4fuOHQD+On04ZEUrgO5xh/UGaTosEz0dFZJiSQKBgQDBxuYKSv03e5n8mXKJqxCCqe8Tnc6i3THYYOUrl8ffEnOeNPqbIzhLU3oEzjcvQDw50DAd5hRclLoXn02Y/C1oZ4jlKf3/jhsiIZZyJga8MdoyoK5DJX0BR8HSAlG+SWmxYjSrV6rmUHSG45hBG2VX/zVG7r1hC5gMTjXVmZQWwwKBgBr+KYczb4vpjTNipfkSKV6AY8DbKdBWhTa0AB4NmSjjARa8vXtS4Z8/o4MUdUFAAeTtATnslKMpfujty78+cUR9E1IRinT2qny8T/YrWnvjc8M3KVrKaGGRNrSJbjef5BPXQfxNRAAt7+0E2jJ/oxyE+oPAdkltjrPHM+3SrpxhAoGAKgV79Vd1ugZvyjtsfzY9ilhXpCVgnijhmk7I478ydMmHkRNkFSh6GLuthkVB6lk/tjnTdWhjmgAWqvC83yQwpKdvJGMK1dR3RduKyI4+f6k/7CK0J5OFnDV3bpdaKq244eKuEUodoXxpCKdqaRQL0h1h7FPxdY4SFvkO65c2agkCgYEAzCsyz+y9wOexsKY9mRyXPJEquUtifYBQNKmwUOqnaQTdwpGtU+cJ/7xRcIjTh2SIn2XXjsHmIPsy756Yy7gZRQoBmoU85niEDVB9oy1v+uXjxqD+G16tcYtSBF2y8sjNvH7UZmD5YgU+spQSZ2Pd9mU0pR1kVEnRaXi7NPS3kQ8=";


        //机构公钥
        public static string merchant_public_key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAytQUequjMVTwEkqoBa1Sgg1aEXjBO7BOtFhhGRiZy9y/eGVDx6nTLC0l4Fq5x7JFwayfTPFRH9HwBKQ1P99ae/dIsU/WarHa/SVvFlaguXLT11PFApoQVE+StJc67hgb3s4EfHoIrDX3UxlMqwQCU78tXgpNntkRP3BnXTQHSqroWBYUdDI4JGyBnb5pxn6RL5VHBuwMdzX+nGdp5uPz22QUqZUxolnd9ldsq3IgOrCu/INZSGSerdGTY4Hv9y2OpvrOc/loZRQcgRmmWaT8Us4Sff40cLyhahb95QKaeDTw3cDU20VCQBOb0gE7AK/xr29Hhl8vZ3DrDb0zarCPdwIDAQAB";

        //应用ID
        public static string appId = "此处填写应用APPID";

        //合作伙伴ID：partnerID
        public static string pid = "此处填写账号PID（partner id）";


        //嘉联支付网关
        //测试服
        public static string serverUrl = "https://qrcode-dev.jlpay.com/api/pay/";
        //生产服
        // public static string serverUrl = "https://qrcode.jlpay.com/api/pay/";


        //编码，无需修改
        public static string charset = "utf-8";
        //签名类型，支持RSA256（推荐！）、RSA
        public static string sign_type = "RSA256";
        //版本号，无需修改
        public static string version = "1.0.1";

    }
}
