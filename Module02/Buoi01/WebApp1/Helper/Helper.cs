using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace WebApp1.Helper
{
    public static class Helper
    {
        public static string RandomString(int len)
        {
            string patter = "123456789qwertyuiopasdfghjlzxcvbnm";
            char[] arr = new char[len];
            Random random = new Random();
            for (int i = 0; i < len; i++)
            {
                int idx = random.Next(patter.Length);
                arr[i] = patter[idx];
            }
            return string.Join("", arr);
        }
        public static byte[] Hash(string plaintext)
        {
            HashAlgorithm algorithm = HashAlgorithm.Create("SHA-512");
            return algorithm.ComputeHash(System.Text.Encoding.ASCII.GetBytes(plaintext));
        }
    }
}
