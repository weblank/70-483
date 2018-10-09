using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace _3._1._02.UsingParse_TryParse_And_Convert
{
    // Using TryParse
    public class MainListing3X5
    {
        public MainListing3X5()
        {
            string value = "1";
            int result;
            bool success = int.TryParse(value, out result);
            
            Console.WriteLine(success);
            
            if (success)
            {
                Console.WriteLine("Value is a valid integer, result contains the value");
            }
            else
            {
                Console.WriteLine("Value is not a valid integer");
            }
            Console.ReadKey();
        }

    }

}