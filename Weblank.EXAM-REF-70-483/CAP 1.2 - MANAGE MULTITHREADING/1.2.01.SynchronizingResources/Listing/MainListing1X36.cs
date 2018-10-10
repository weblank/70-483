using System;
using System.Threading.Tasks;

namespace SynchronizingResources.Listing
{
    // O operador "lock" é um syntactic sugar para System.Thread.Monitor (papel do compilador)
    // O uso do operador "lock", não é um boa prática já que pode acontecer de diminuir o desempenho e
    // em alguns casos gerar um **deadlock**, nomenclatura usado para determinar quando as duas (ou mais)
    // operações ficam uma esperando as outras sem nenhuma usar o recurso, 
    // forçaremos um caso no próximo exemplo MainListing1X37
    public class MainListing1X36
    {
        public MainListing1X36()
        {

            int n = 0;

            object _lock = new object();

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    lock (_lock)
                    n++;
            });

            for (int i = 0; i < 1000000; i++)
                lock (_lock)
                n--;

            up.Wait();
            Console.WriteLine(n);
            Console.ReadLine();





        }
    }
}
