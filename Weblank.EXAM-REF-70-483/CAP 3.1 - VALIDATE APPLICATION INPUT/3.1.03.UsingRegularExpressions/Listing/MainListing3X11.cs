using System;
using System.Text.RegularExpressions;

namespace _3._1._03.UsingRegularExpressions
{
    // Validate a ZIP Code with a regular expression
    public class MainListing3X11
    {
        public MainListing3X11()
        {
            Console.WriteLine(Validate("1 2 3 4   5    6     7      8"));
            Console.ReadKey();
        }

        static string Validate(string input)
        {
            // Valid zipcodes : 1234AB | 1234 AB | 1001 AB

            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options);

            string result = regex.Replace(input," ");

            return result;

        }

    }

}