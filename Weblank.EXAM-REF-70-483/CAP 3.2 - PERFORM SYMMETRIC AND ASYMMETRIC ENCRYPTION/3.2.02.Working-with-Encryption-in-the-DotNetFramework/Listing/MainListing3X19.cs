using System;
using System.Security.Cryptography;
using System.Text;

namespace _3._2._2.Working_with_Encryption_in_the_DotNetFramework
{
    // Using a public and private key to encrypt and decrypt data
    public class MainListing3X19
    {
        public MainListing3X19()
        {
            var keys = MainListing3X18.CreateKeys();

            UnicodeEncoding ByteConverter= new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My Secret Data!");

            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(keys["publicKeyXML"]);
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }

            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(keys["privateKeyXML"]);
                decryptedData = RSA.Decrypt(encryptedData, false);
            }

            string decryptedString = ByteConverter.GetString(decryptedData);
            Console.WriteLine(decryptedString);
            Console.ReadKey();
        }

        
    }

}