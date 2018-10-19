using System;

namespace _3._1._02.UsingParse_TryParse_And_Convert
{
    // Using Convert with a null value
    public class MainListing3X7
    {
        public MainListing3X7()
        {
            int i = Convert.ToInt32(null);
            Console.WriteLine(i); 
            Console.ReadKey();
        }

    }

}