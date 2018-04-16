using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPLINQ.Listing
{
    public class MainListing1X27
    {
        public MainListing1X27()
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {

                var parallelResult = numbers.AsParallel().Where(i => IsEven(i));

                parallelResult.ForAll(e => Console.WriteLine(e));

            }
            catch (AggregateException e)
            {
                Console.WriteLine("There where {0} exceptions", e.InnerExceptions.Count);
                Console.ReadLine();
            }

        }

        public static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");

            return i % 2 == 0;
        }
    }
}
