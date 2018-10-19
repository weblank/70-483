using System.Security.Cryptography;
using System.Text;

namespace _3._2._2.Working_with_Encryption_in_the_DotNetFramework
{
    // Using a public and private key to encrypt and decrypt data
    public class MainListing3X20
    {
        public MainListing3X20()
        {
            UnicodeEncoding ByteConverter= new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My Secret Data!");

            string containerName= "SecretContainer";
            CspParameters csp = new CspParameters() { KeyContainerName = containerName  };
            byte[] encryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }
        }

        
    }

}