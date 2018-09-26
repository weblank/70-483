using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _1._6._01.Test
{
    //   Using Environment.FailFast
    public class MainListing1X92
    {
        public MainListing1X92()
        {
            while (true)
            {
                string s = Console.ReadLine();

                try
                {
                    int i = int.Parse(s);
                    if(i == 42) Environment.FailFast("Special number entered");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You need to enter a value");
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again", s);
                }
                finally
                {
                    Console.WriteLine("Program complete.");
                }
            }
        }



    }
}


