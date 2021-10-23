//////////////////////////////////////////////////
/// 文件：Crypt.cs
/// 说明：DES加密、解密
/// 作者：李光强
/// 时间：2016.4.12.
/// 版本：v1.0
/// 修改：尹健
/// 修改时间：2020/10/15/
////////////////////////////////////////////////

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace Crypt_Csharp
{

    /// <summary>
    /// 加解密类
    /// </summary>
    public class Crypt
    {

        //随机选8个字节既为密钥也为初始向量
        private byte[] _KEY_64 = {36, 73, 77, 98, 78, 24, 77, 38};
        private byte[] _IV_64 = { 55, 49, 128, 138, 136, 99, 17, 38 };

        public byte[] Key1
        {
            get { return this._KEY_64; }
            set { this._KEY_64 = value; }
        }

        public byte[] Key2
        {
            get { return this._IV_64; }
            set { this._IV_64 = value; }
        }

        /// <summary>
        /// 标准的DES加密
        /// </summary>
        /// <param name="value">待加密的字串</param>
        /// <returns>加密后的字串</returns>
        public string EnDES(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                    MemoryStream ms = new MemoryStream();
                    CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateEncryptor(_KEY_64, _IV_64), CryptoStreamMode.Write);
                    StreamWriter sw = new StreamWriter(cs);
                    sw.Write(value);
                    sw.Flush();
                    cs.FlushFinalBlock();
                    ms.Flush();
                    //再转换为一个字符串
                    return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
                }
                else
                {
                    throw new Exception("参数值不能为空");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
                
        /// <summary>
        /// 标准的DES加密
        /// </summary>
        /// <param name="value">待加密的字串</param>
        /// <param name="key">密钥</param>
        /// <returns>加密后的字串</returns>
        public string EnDES(string value, byte[] key)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                    MemoryStream ms = new MemoryStream();
                    CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateEncryptor(key, _IV_64), CryptoStreamMode.Write);
                    StreamWriter sw = new StreamWriter(cs);
                    sw.Write(value);
                    sw.Flush();
                    cs.FlushFinalBlock();
                    ms.Flush();
                    //再转换为一个字符串
                    return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
                }
                else
                {
                    throw new Exception("参数值不能为空");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 标准的DES解密
        /// </summary>
        /// <param name="value">密文</param>
        /// <returns>明文</returns>
        public string DeDES(string value)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                    //从字符串转换为字节组
                    byte[] buffer = Convert.FromBase64String(value);
                    MemoryStream ms = new MemoryStream(buffer);
                    CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateDecryptor(_KEY_64, _IV_64), CryptoStreamMode.Read);
                    StreamReader sr = new StreamReader(cs);
                    return sr.ReadToEnd();
                }
                else
                {
                    throw new Exception("参数值不为能空");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        /// <summary>
        /// 标准的DES解密
        /// </summary>
        /// <param name="value">密文</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public string DeDES(string value, byte[] key)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                    //从字符串转换为字节组
                    byte[] buffer = Convert.FromBase64String(value);
                    MemoryStream ms = new MemoryStream(buffer);
                    CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateDecryptor(key, _IV_64), CryptoStreamMode.Read);
                    StreamReader sr = new StreamReader(cs);
                    return sr.ReadToEnd();
                }
                else
                {
                    throw new Exception("参数值不为能空");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="sSourceData">要加密的信息</param>
        /// <returns></returns>
        public string MD5(string sSourceData)
        {
            try
            {
                byte[] tmpSource = null;
                byte[] tmpHash = null;
                tmpSource = System.Text.ASCIIEncoding.ASCII.GetBytes(sSourceData);
                tmpHash = new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(tmpSource);
                int i = 0;
                System.Text.StringBuilder sOutput = new System.Text.StringBuilder(tmpHash.Length);
                for (i = 0; i <= tmpHash.Length - 1; i++)
                {
                    sOutput.Append(tmpHash[i].ToString("X2"));
                }
                return sOutput.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
