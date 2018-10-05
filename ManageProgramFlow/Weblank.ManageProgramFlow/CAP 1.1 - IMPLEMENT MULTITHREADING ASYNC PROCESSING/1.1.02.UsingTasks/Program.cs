using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTasks
{
    //     CHAPTER 1: MANAGE PROGRAM FLOW
    // OBJECTIVE 1.1: IMPLEMENT MULTITHREADING AND ASYNCHRONOUS PROCESSING CHAPTER 1

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
            //MainListing1X9();
            #endregion

            //Listing 1.10 - Adding a continuation Task
            #region Listing 1.10
            //MainListing1X10();
            #endregion

            //Listing 1.11 - Scheduling different continuation Tasks
            #region Listing 1.11
            //MainListing1X11();
            #endregion

            //Listing 1.12 - Attaching child tasks to a parent task
            #region Listing 1.12
            //MainListing1X12();
            #endregion

            //Listing 1.13 - Using a TaskFactory
            #region Listing 1.13
            //MainListing1X13();
            #endregion

            //Listing 1.14 - Using Task.WaitAll
            #region Listing 1.14
            //MainListing1X14();
            #endregion

            //Listing 1.15 - Using Task.WaitAll
            #region Listing 1.15
            MainListing1X15();
            #endregion

            //Listing 1.16 - Using Task.WaitAll
            #region Listing 1.15
            MainListing1X15();
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

            //Veja que para recebermos o resultado da Task é necessário o uso do ".Result" => isto é necessário pois assim temos uma segunda Task(Result) aguardando o resultado da primeira;
            Console.WriteLine(t.Result); //A informação que deve aparecer no console é: 42     

            //Se quiser verificar o conteúdo impresso no console, basta descomentar a linha abaixo
            //Console.ReadLine();

        }

        //Listing 1.10 - Adding a continuation Task
        static void MainListing1X10()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
                //ContinueWith tem diversos overloads, sendo assim podemos criar diferentes "ContinueWith"s conforme o retorno da primeira Task, veremos isso no exercício seguinte
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine(t.Result); //A informação que deve aparecer no console é: 84     

            //Se quiser verificar o conteúdo impresso no console, basta descomentar a linha abaixo
            Console.ReadLine();

        }

        //Listing 1.11 - Scheduling different continuation Tasks
        static void MainListing1X11()
        {

            //CREATING A TASK
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            //CANCELED
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnFaulted);

            //FALTED
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Falted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            //COMPLETED
            var completedTask = t.ContinueWith((i) =>
                {
                    Console.WriteLine("Completed");
                }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();


            Console.WriteLine(t.Result); //A informação que deve aparecer no console é: 84     

            //Se quiser verificar o conteúdo impresso no console, basta descomentar a linha abaixo
            //Console.ReadLine();

        }

        //Listing 1.12 - Attaching child tasks to a parent task
        static void MainListing1X12()
        {

            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1,
                                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2,
                                    TaskCreationOptions.AttachedToParent).Start();
                return results;
            });

            var finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (var item in parentTask.Result)
                        Console.WriteLine(item);
                });

            finalTask.Wait();

            //Se quiser verificar o conteúdo impresso no console, basta descomentar a linha abaixo
            //Console.ReadLine();

        }

        //Listing 1.13 - Using a TaskFactory
        static void MainListing1X13()
        {

            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];

                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
                    TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);

                return results;
            });

            var finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (var item in parentTask.Result)
                        Console.WriteLine(item);
                });

            finalTask.Wait();

            //Se quiser verificar o conteúdo impresso no console, basta descomentar a linha abaixo
            //Console.ReadLine();

        }

        //Listing 1.14 - Using Task.WaitAll
        static void MainListing1X14()
        {
            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });
            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 2;
            });
            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            });

            Task.WaitAll(tasks);

            //Se quiser verificar o conteúdo impresso no console, basta descomentar a linha abaixo
            //Console.ReadLine();

        }

        //Listing 1.15 - Using Task.WaitAll
        static void MainListing1X15()
        {

            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];
                Console.WriteLine(completedTask.Result);
                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();

                //Se quiser verificar o conteúdo impresso no console, basta descomentar a linha abaixo
                //Console.ReadLine();
            }



        }

    }
}

