using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace _3._2._2.Working_with_Encryption_in_the_DotNetFramework
{
    // Exporting a public key
    public class MainListing3X18
    {
        
        
        public MainListing3X18()
        {
            var keys = CreateKeys();

            Console.WriteLine(keys["publicKeyXML"]);
            Console.WriteLine(keys["privateKeyXML"]);
            Console.ReadKey();
        }


        public static Dictionary<string, string> CreateKeys()
        {
            string publicKeyXML;
            string privateKeyXML;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            publicKeyXML= rsa.ToXmlString(false);
            privateKeyXML = rsa.ToXmlString(true);

            var keys = new Dictionary<string, string>();

            keys.Add("publicKeyXML",publicKeyXML);
            keys.Add("privateKeyXML",privateKeyXML);

            return keys;
        }
        
    }

}