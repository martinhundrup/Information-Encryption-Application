using System.Security.Cryptography;
using System.Text;

namespace Authentication
{
    public static class Hashing
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

        public static byte[] StringToHash(string hex)
        {
            if (hex.Length % 2 != 0)
                throw new ArgumentException("hex string must have an even length.");

            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < hex.Length; i += 2)
            {
                // Convert each pair of hex digits back to a byte
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return bytes;
        }

        // combine two hashes using a bitwise and
        public static byte[] Combine(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) throw new ArgumentException("hashes are of unequal length");
  
            byte[] result = new byte[a.Length];
            for (int i = 0; i < b.Length; i++)
            {
                result[i] = (byte)(a[i] & b[i]);
            }

            return result;
        }
    }
}
