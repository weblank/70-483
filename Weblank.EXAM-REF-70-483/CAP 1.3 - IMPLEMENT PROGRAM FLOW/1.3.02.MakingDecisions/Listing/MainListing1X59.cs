using System;

namespace _9.MakingDecisions.Listing
{
    public class MainListing1X59
    {
        // The null-coalescing operator
        public MainListing1X59()
        {

            int? x = null;
            int? z = null;
            int  y = x ??
                     z ??
                     -1;

            Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}
