using System;
using System.Threading.Tasks;

namespace SynchronizingResources.Listing
{
    public class MainListing1X35
    {
        public MainListing1X35()
        {
            int n = 0;

            var up = Task.Run(() => 
            {
                for (int i = 0; i < 1000000; i++)
                    n++;
            });

            for (int i = 0; i < 1000000; i++)
                n--;

            up.Wait();
            Console.WriteLine(n);
            Console.ReadLine();

        }
    }
}
