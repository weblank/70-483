using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _1._5._03.ImplementExceptionHandling
{
    //  Catching different exception types
    public class MainListing1X90
    {
        public MainListing1X90()
        {
            while (true)
            {
                string s = Console.ReadLine();

                try
                {
                    int i = int.Parse(s);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You need to enter a value");
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again", s);
                }
            }
        }



    }
}


