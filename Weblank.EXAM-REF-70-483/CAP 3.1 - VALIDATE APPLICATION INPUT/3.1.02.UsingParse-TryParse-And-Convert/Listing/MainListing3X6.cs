using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace _3._1._02.UsingParse_TryParse_And_Convert
{
    // Using configuration options when parsing a number
    public class MainListing3X6
    {
        public MainListing3X6()
        {
            CultureInfo english = new CultureInfo("En");
            CultureInfo dutch = new CultureInfo("Nl");

            string value = "€19,95";
            decimal d = decimal.Parse(value, NumberStyles.Currency,dutch);
            Console.WriteLine(d.ToString(english));
            Console.ReadKey();
        }

    }

}