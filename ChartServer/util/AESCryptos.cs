using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using ChartServer.server;

namespace ChartServer.util
{
    public class AESCryptos
    {
        public static int AES_KEY_SIZE = 128;

        public static string Decrypt(String value,String key)
        {

            byte[] keyBytes = Convert.FromBase64String(key);
            byte[] valueBytes = Convert.FromBase64String(value);

            //Server.log("WMS:" + System.Text.Encoding.Default.GetString(keyBytes), Constant.info, Constant.infoColor);

            System.Security.Cryptography.RijndaelManaged rm = new System.Security.Cryptography.RijndaelManaged
            {
                Key = keyBytes,
                Mode = System.Security.Cryptography.CipherMode.ECB,
                Padding = System.Security.Cryptography.PaddingMode.PKCS7
            };

            System.Security.Cryptography.ICryptoTransform cTransform = rm.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(valueBytes, 0, valueBytes.Length);

            return Encoding.UTF8.GetString(resultArray);
        }

        public static String AESEncrypt(String value,String key)
        {
            Byte[] toEncryptArray = Encoding.UTF8.GetBytes(value);
            byte[] keyBytes = Convert.FromBase64String(key);

            System.Security.Cryptography.RijndaelManaged rm = new System.Security.Cryptography.RijndaelManaged
            {
                Key = keyBytes,
                Mode = System.Security.Cryptography.CipherMode.ECB,
                Padding = System.Security.Cryptography.PaddingMode.PKCS7
            };

            System.Security.Cryptography.ICryptoTransform cTransform = rm.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static String generateKey()
        {
            System.Security.Cryptography.RijndaelManaged rm = new System.Security.Cryptography.RijndaelManaged
            {
                KeySize = 128,
                Mode = System.Security.Cryptography.CipherMode.ECB,
                Padding = System.Security.Cryptography.PaddingMode.PKCS7
            };
            rm.GenerateKey();
            return Convert.ToBase64String(rm.Key);
        }
    }
}
