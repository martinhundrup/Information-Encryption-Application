using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    internal static class Hashing
    {

        public static byte[] Hash(string s)
        {
            using (HashAlgorithm sha = SHA256.Create())
            {
                return sha.ComputeHash(Encoding.ASCII.GetBytes(s));
            }
        }

        public static string HashToString(byte[] arr)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in arr)
            {
                sb.Append(b.ToString("x2")); // Convert each byte to a hexadecimal string
            }

            return sb.ToString();
        }

        // combine two hashes using a bitwise and
        public static byte[] Combine(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) throw new Exception("hashes are of unequal length");
  
            byte[] result = new byte[a.Length];
            for (int i = 0; i < b.Length; i++)
            {
                result[i] = (byte)(a[i] & b[i]);
            }

            return result;
        }
    }
}
