using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UsingParallelClass
{
    //     CHAPTER 1: MANAGE PROGRAM FLOW
    // OBJECTIVE 1.1: IMPLEMENT MULTITHREADING AND ASYNCHRONOUS PROCESSING CHAPTER 1

    class Program
    {
        static void Main(string[] args)
        {
            //Listing 1.16 - Using Parallel.For and Parallel.Foreach
            #region Listing 1.16
            //MainListing1X16();
            #endregion

            //Listing 1.17 - Using Parallel.Break
            #region Listing 1.17
            MainListing1X17();
            #endregion
        }

        //Listing 1.16 - Using Parallel.For and Parallel.Foreach
        static void MainListing1X16()
        {
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            { });

            //Se quiser verificar o conteúdo impresso no console, basta descomentar a linha abaixo
            Console.ReadLine();

        }

        //Listing 1.17 - Using Parallel.Break
        static void MainListing1X17()
        {
            ParallelLoopResult result = Parallel.
                For(0, 1000, (Int32 i, ParallelLoopState loopState) =>
                {
                    if (true)
                    {
                        Console.WriteLine("Breaking loop");
                        loopState.Break();
                    }
                    //Se quiser verificar o conteúdo impresso no console, basta descomentar a linha abaixo
                    //Console.ReadLine();
                    return;
                });
        }
    }
}
