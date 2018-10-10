using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _3._1._03.UsingRegularExpressions
{
    // Validate a ZIP Code with a regular expression
    public class MainListing3X10
    {
        public MainListing3X10()
        {
            var collection = new List<string>();
            collection.Add("1234AB");
            collection.Add("1234 AB");
            collection.Add("ABCD");

            foreach (var item in collection)
            {
                Console.WriteLine(item + " é um Zip Code " + ValidateZipCode(item)); 
            }

            Console.ReadKey();
        }

        static bool ValidateZipCode(string zipCode)
        {
            // Valid zipcodes : 1234AB | 1234 AB | 1001 AB

            Match match= Regex.Match(zipCode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$",RegexOptions.IgnoreCase);
            return match.Success;
        }

    }

}