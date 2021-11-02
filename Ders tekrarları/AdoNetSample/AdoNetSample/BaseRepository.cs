using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSample
{
    public class BaseRepository
    {
        protected string Connection
        {
            get
            {
                var cnn = ConfigurationManager.ConnectionStrings["DapperConnection"].ConnectionString;
                return Decrypt(cnn);
            }
        }
        protected string TestConnection
        {
            get
            {
                var cnn = ConfigurationManager.ConnectionStrings["DapperConnection"].ConnectionString;
                return Decrypt(cnn);
            }
        }
        private string Decrypt(string textToDecrypt)
        {
            try
            {
                string result = "";
                string publickey = "630715c7";
                string secretkey = "12b09792";
                byte[] privatekeyByte = { };
                privatekeyByte = Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeyByte = { };
                privatekeyByte = Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(publickeyByte, privatekeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    result = encoding.GetString(ms.ToArray());
                }
                return result;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }
        private string Encrypt(string textToEncrypt)
        {
            try
            {
                string result = "";
                string publickey = "630715c7";
                string secretkey = "12b09792";
                byte[] secretkeyByte = { };
                secretkeyByte = Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    result = Convert.ToBase64String(ms.ToArray());
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
