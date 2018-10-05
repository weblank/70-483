using System;
using System.Threading;
using System.Threading.Tasks;

namespace _9.MakingDecisions.Listing
{
    public class MainListing1X58
    {
        // The null-coalescing operator
        public MainListing1X58()
        {

            int? x = null;
            int  y = x ?? -1;

            Console.WriteLine(y);
            Console.ReadLine();

            // Neste caso, o valor de "y" é -1 pq x é null
        }
    }
}
