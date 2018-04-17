using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingConcurrentCollections.Listing
{
    public class MainListing1X33
    {
        public MainListing1X33()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);
            int result;
            if (queue.TryDequeue(out result))
                Console.WriteLine("Dequeued: {0}", result);

            Console.ReadLine();

        }
    }
}
