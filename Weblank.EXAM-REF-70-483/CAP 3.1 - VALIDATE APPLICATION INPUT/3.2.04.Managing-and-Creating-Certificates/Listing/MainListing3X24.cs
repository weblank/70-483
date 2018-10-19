using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _3._2._4.Managing_and_Creating_Certificates
{
    // Using Signing and Verifying data with a certificate
    // Antes de rodar este exercício, verifique se já tem as chaves geradas (pública e privada)
    public class MainListing3X24
    {
        // SignAndVerify
        public MainListing3X24()
        {
            var verify = new bool();
            try
            {
                string textToSign = "Test paragraph";
                byte[] signature = Sign(textToSign, "cn=WouterDeKort");
                // Descomente essa linha para fazer a verificação falahar
                // signature[0]= 0;
                verify = Verify(textToSign, signature);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Não encontramos o certificado no storage local");
                Console.ReadKey();
                return;
            }

            Console.WriteLine(verify);
            Console.ReadKey();
        }   

        static byte[] Sign(string text, string certSubject)
        {
            X509Certificate2 cert = GetCertificate();
            var csp = (RSACryptoServiceProvider)cert.PrivateKey;
            byte[] hash = HashData(text);
            return csp.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
        }

        static bool Verify(string text, byte[] signature)
        {
            X509Certificate2 cert = GetCertificate();
            var csp = (RSACryptoServiceProvider)cert.PublicKey.Key;
            byte[] hash = HashData(text);
            return csp.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
        }

        private static byte[] HashData(string text)
        {
            HashAlgorithm hashAlgorithm = new SHA1Managed();
            UnicodeEncoding enconding = new UnicodeEncoding();
            byte[] data = enconding.GetBytes(text);
            byte[] hash = hashAlgorithm.ComputeHash(data);
            return hash;
        }

        private static X509Certificate2 GetCertificate()
        {
            X509Store my = new X509Store("testCertStore", StoreLocation.CurrentUser);
            my.Open(OpenFlags.ReadOnly);

            var certificate= my.Certificates[0];
            return certificate;
        }
        
    }

}