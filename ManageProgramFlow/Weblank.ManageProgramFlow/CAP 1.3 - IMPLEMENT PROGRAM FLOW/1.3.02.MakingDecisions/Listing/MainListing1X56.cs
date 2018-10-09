using System;

namespace _9.MakingDecisions.Listing
{
    public class MainListing1X56
    {
        // Using multiple if/else statements
        public MainListing1X56()
        {
            Boolean b = false;
            Boolean c = true;

            if(b)
            {
                Console.WriteLine("b is true");
                Console.ReadLine();
            }
            else if(c)
            {
                Console.WriteLine("c is true");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("b and c are false");
                Console.ReadLine();
            }

            // Também podemos utilizar
            // if(b) Console.WriteLine("b is true"); if(c) Console.WriteLine("c is true"); else Console.WriteLine("b and c are false");

        }

    }
}
