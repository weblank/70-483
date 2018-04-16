using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPLINQ.Listing
{
    public class MainListing1X25
    {
        public MainListing1X25()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered()
                                            .Where(i => i % 2 == 0).AsSequential();
            foreach (int i in parallelResult.Take(5))
                Console.WriteLine(i);

            Console.ReadLine();
        }

    }
}
