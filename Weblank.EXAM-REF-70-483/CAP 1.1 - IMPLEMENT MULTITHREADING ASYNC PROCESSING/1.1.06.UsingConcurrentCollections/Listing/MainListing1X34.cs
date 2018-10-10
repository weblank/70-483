using System;
using System.Collections.Concurrent;

namespace UsingConcurrentCollections.Listing
{
    public class MainListing1X34
    {
        // An atomic operation means that it will be started and finished as a single step without other threads interfering
        public MainListing1X34()
        {
            var dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }
            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }
            dict["k1"] = 42; // Overwrite unconditionally
            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k2", 3);

            Console.ReadLine();

        }
    }
}
