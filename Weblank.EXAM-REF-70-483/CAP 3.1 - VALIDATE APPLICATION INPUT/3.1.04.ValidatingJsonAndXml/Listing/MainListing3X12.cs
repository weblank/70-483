using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _3._1._04.ValidatingJsonAndXml
{
    // Seeing whether a string contains potential JSON data 
    public class MainListing3X12
    {
        public MainListing3X12()
        {
            var collection = new List<string>();
            collection.Add("{}");
            collection.Add("[]");
            collection.Add("12345");

            foreach (var item in collection)
            {
                Console.WriteLine("O objeto: "+ item + " é " + ValidateJson(item) + " para json");
            }
            Console.ReadKey();
        }

        static bool ValidateJson(string input)
        {
            input = input.Trim();
            return input.StartsWith("{") && input.EndsWith("}")
            || input.StartsWith("[") && input.EndsWith("]");
        }

    }

}