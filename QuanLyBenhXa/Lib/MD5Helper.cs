using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhXa.Lib
{
    public static class MD5Helper
    {
        private static MD5 md5 = MD5.Create();
        public static String GetMD5HashValue(String input)
        {
            String ans = "";
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            ans = sb.ToString();
            return ans;
        }
    }
}
