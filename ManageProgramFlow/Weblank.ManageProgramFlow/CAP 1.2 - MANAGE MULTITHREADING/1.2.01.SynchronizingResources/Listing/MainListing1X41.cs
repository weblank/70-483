using System;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizingResources.Listing
{
    public class MainListing1X41
    {
        static int value = 1;
        // Neste exemplo, nem sempre o resultado será o mesmo
        // o resultado depende dos recursos de processamento do seu hardware
        public MainListing1X41()
        {
            Task t1 = Task.Run(() =>
            {
                if (value == 1)
                {
                    // Removing the following line will change the output
                    Thread.Sleep(1000);
                    value = 2;
                }
            });
            Task t2 = Task.Run(() =>
            {
                value = 3;
            });
            Task.WaitAll(t1, t2);
            Console.WriteLine(value); // Displays 2 ou 3
            Console.ReadLine();

        }
    }
}
