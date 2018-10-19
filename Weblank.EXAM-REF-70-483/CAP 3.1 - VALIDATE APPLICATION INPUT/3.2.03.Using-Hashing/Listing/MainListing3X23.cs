using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace _3._2._3.Using_Hashing
{
    // Using SHA256Managed to calculate a hash code
    public class MainListing3X23
    {
        
        public MainListing3X23()
        {
            var lista = new List<string>();

            lista.Add("A paragraph of text");
            lista.Add("A paragraph of changed text");
            lista.Add("A paragraph of text");

            var result = SHA256Manager(lista);
            
            Console.WriteLine(result[0].SequenceEqual(result[1]));
            Console.WriteLine(result[0].SequenceEqual(result[2]));
            Console.ReadKey();

        }

        public static byte[][] SHA256Manager(List<string> lista)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            SHA256 sha256 = SHA256.Create();

            byte[][] result = new byte[3][];

            byte[] hashA = sha256.ComputeHash(byteConverter.GetBytes(lista[0]));
            byte[] hashB = sha256.ComputeHash(byteConverter.GetBytes(lista[1]));
            byte[] hashC = sha256.ComputeHash(byteConverter.GetBytes(lista[2]));

            result[0] = hashA;
            result[1] = hashB;
            result[2] = hashC;

            return result;

        }

        
    }

}