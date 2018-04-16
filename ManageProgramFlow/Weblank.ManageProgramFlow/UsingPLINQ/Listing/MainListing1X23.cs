using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPLINQ.Listing
{
    public class MainListing1X23
    {
        public MainListing1X23()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel()
                                            .Where(i => i % 2 == 0).ToArray();
            foreach (int i in parallelResult)
                Console.WriteLine(i);

            Console.ReadLine();
        }

    }
}
