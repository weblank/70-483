using System;

namespace _9.MakingDecisions.Listing
{
    public class MainListing1X63
    {
        // A goto in a switch statement
        public MainListing1X63()
        {
            int i = 1;

            switch(i)
            {
                case 1:
                    {
                        Console.WriteLine("Case 1");
                        goto case 2;
                    }
                case 2:
                    {
                        Console.WriteLine("Case 2");
                        Console.ReadLine();
                        break;
                    }
            }

        }
    }
}
