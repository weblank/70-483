using System.Linq;

namespace UsingPLINQ.Listing
{
    public class MainListing1X22
    {
        // Desta forma deixamos para o Runtime a responsabilidade de definir
        // quando usar ou não usar PLINQ. Existe uma outra forma que "força" o uso de PLINQ
        // veremos no próximo exercício.
        public MainListing1X22()
        {
            var numbers = Enumerable.Range(0, 100000000);
            var parallelResult = numbers.AsParallel()
                                            .Where(i => i % 2 == 0).ToArray();

        }

    }
}
