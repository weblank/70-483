using System;

namespace _3._1._02.UsingParse_TryParse_And_Convert
{
    // Using Parse
    // Alterando uma string para um bool
    public class MainListing3X4
    {
        public MainListing3X4()
        {
            string value = "true";
            bool b = bool.Parse(value);
            
            Console.Write(b);
            Console.ReadKey();
        }

    }

}