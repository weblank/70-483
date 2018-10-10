using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace _3._1._02.UsingParse_TryParse_And_Convert
{
    // Using Convert to convert from double to int
    public class MainListing3X8
    {
        public MainListing3X8()
        {
            double d = 23.15;
            int i = Convert.ToInt32(d);
            Console.WriteLine(i); 
            Console.ReadKey();
        }

    }

}