using System.Security.Cryptography;

namespace Authentication
{
    public static class Encryption
    {
        // the key will be stored in my system
        // the randomness [IV] will be the username hash

        // uses AES encryption. encrypts string to bytes
        public static byte[] Encrypt(string plainText, byte[] IV)
        {
            // get the key
            var key = Hashing.Hash(Environment.GetEnvironmentVariable("ENCRYPTION_APP_IV")).Take(16).ToArray();
            IV = IV.Take(16).ToArray();

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }

        // assumes AES descryption. decryptes bytes into string
        public static string Decrypt(byte[] cipherText, byte[] IV)
        {
            // get the key
            var key = Hashing.Hash(Environment.GetEnvironmentVariable("ENCRYPTION_APP_IV")).Take(16).ToArray();
            IV = IV.Take(16).ToArray();

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

    }
}
