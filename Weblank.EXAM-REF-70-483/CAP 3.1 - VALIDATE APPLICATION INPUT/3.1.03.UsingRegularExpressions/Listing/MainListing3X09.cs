using System;
using System.Collections.Generic;

namespace _3._1._03.UsingRegularExpressions
{
    // Manually validating a ZIP Code
    public class MainListing3X9
    {
        public MainListing3X9()
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

            if (zipCode.Length < 6) return false;
            
            string numberPart = zipCode.Substring(0,1);
            int number;
            if (!int.TryParse(numberPart, out number)) return false;

            string characterPart = zipCode.Substring(4);

            if (numberPart.StartsWith("O")) return false;
            if (characterPart.Trim().Length < 2) return false;
            if (characterPart.Length == 3 && characterPart.Trim().Length != 2) return false;

            return true;

        }

    }

}