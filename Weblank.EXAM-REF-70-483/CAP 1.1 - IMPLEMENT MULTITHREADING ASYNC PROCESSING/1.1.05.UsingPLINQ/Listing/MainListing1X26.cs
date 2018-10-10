using System;
using System.Linq;

namespace UsingPLINQ.Listing
{
    public class MainListing1X26
    {
        public MainListing1X26()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel()
                                            .Where(i => i % 2 == 0);

            parallelResult.ForAll(e => Console.WriteLine(e));

            Console.ReadLine();
        }

        // Diferente do foreach, ForAll não precisa de todos os resultados antes de começar a executar.
        // sendo assim, não podemos usar qualquer tipo de ordenação.

    }
}
