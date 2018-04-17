using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingConcurrentCollections.Listing
{
    public class MainListing1X30
    {
        // Important methods are Add, TryTake, and TryPeek.
        // One thing to keep in mind is that the TryPeek method is not very useful in a multithreaded
        // environment. It could be that another thread removes the item before you can access it.
        public MainListing1X30()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(42);
            bag.Add(21);
            int result;
            if (bag.TryTake(out result))
                Console.WriteLine(result);

            if (bag.TryPeek(out result))
                Console.WriteLine("There is a next item: {0}", result);

            Console.ReadLine();
    
        }
    }
}
