using System;
using System.IO;
using System.Security.Cryptography;

namespace _3._2._2.Working_with_Encryption_in_the_DotNetFramework
{
    // Use a symmetric encryption algorithm
    public class MainListing3X17
    {
        public MainListing3X17()
        {
            var original = "My secretdata!";

            using (SymmetricAlgorithm symmetricAlgorithm = new AesManaged())
            {
                byte[]encrypted = Encrypt(symmetricAlgorithm, original);
                string roundtrip = Decrypt(symmetricAlgorithm,encrypted);

                Console.WriteLine("Original: {0}", original);
                Console.WriteLine("Round Trip: {0}", roundtrip);
                Console.ReadKey();
            }


        }

        static byte[] Encrypt(SymmetricAlgorithm aesAlg, string plainText)
        {
            ICryptoTransform encryptor  = aesAlg.CreateEncryptor(aesAlg.Key,aesAlg.IV);

            using (var msEncrypt= new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt,encryptor,CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return msEncrypt.ToArray();
                }
            }
        }

        static string Decrypt(SymmetricAlgorithm aesAlg, byte[] cipherText)
        {
            ICryptoTransform decryptor  = aesAlg.CreateDecryptor(aesAlg.Key,aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt,decryptor,CryptoStreamMode.Read))
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