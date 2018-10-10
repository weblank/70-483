using System;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizingResources.Listing
{
    public class MainListing1X40
    {
        // Interlocked é um recurso da System.Threading
        // O interlocked é pouco utilizado já que basicamente
        // serve para incremento e decremento de número, assim, 
        // reduzindo sua aplicação apenas para tipos de "números"
        public MainListing1X40()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    Interlocked.Increment(ref n);
            });
            for (int i = 0; i < 1000000; i++)
                Interlocked.Decrement(ref n);
            up.Wait();
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
