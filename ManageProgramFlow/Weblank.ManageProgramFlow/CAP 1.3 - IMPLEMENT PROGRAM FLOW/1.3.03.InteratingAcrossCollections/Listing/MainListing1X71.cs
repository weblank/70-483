using System;
using System.Threading;
using System.Threading.Tasks;

namespace _10.InteratingAcrossCollections
{
    // Foreach
    public class MainListing1X71
    {
        public MainListing1X71()
        {
            int[] values = {1,2,3,4,5,6};

            foreach (var i in values)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
