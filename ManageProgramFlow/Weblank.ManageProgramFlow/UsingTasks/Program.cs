using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listing 1.8 - Starting a new Task
            #region Listing 1.8
            //MainListing1X8();
            #endregion

            //Listing 1.9 - Using a Task that returns a value
            #region Listing 1.9
            MainListing1X9();
            #endregion
        }

        //Listing 1.8 - Starting a new Task
        static void MainListing1X8()
        {
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write('*');
                }
            });

            //Chamar o método "Wait" na Task é equivalente a chamar o método "Join" numa Thread
            t.Wait();

            //Se quiser verificar o conteúdo impresso no console, basta descomentar a linha abaixo
            //Console.ReadLine();
        }

        //Listing 1.9 - Using a Task that returns a value
        static void MainListing1X9()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });
            
            Console.WriteLine(t.Result); //A informação que deve aparecer no console é: 42     
            //Se quiser verificar o conteúdo impresso no console, basta descomentar a linha abaixo
            //Console.ReadLine();

        }

    }
}
