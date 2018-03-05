using System;
using System.Threading;

namespace IMAP
{
    //     CHAPTER 1: MANAGE PROGRAM FLOW
    // OBJECTIVE 1.1: IMPLEMENT MULTITHREADING AND ASYNCHRONOUS PROCESSING CHAPTER 1

    public class Program
    {

        //Understanding Threads
        static void Main(string[] args)
        {

            //Listing 1.1 - Creatring a thread with the Thread class
            #region Listing 1.1
            //MainListing1X1(); 
            #endregion

            //Listing 1.2 - Using a background Thread
            #region Listing 1.2
            //MainListing1X2(); 
            #endregion

            //Listing 1.3 - Using the Parameterized Thread Start
            #region Listing 1.3
            //MainListing1X3();
            #endregion

            //Listing 1.4 - Stopping a Thread
            #region Listing 1.4
            //MainListing1X4();
            #endregion

            //Listing 1.5 - Using The Thread Static Attribute
            #region Listing 1.5 
            #endregion

            //Listing 1.6 - Using ThreadLocal<T>
            #region Listing 1.6 
            //MainListing1X6();
            #endregion

            //Listing 1.7 - Queuing some work to the thread pool
            #region Listing 1.7 
            MainListing1X7();
            #endregion

        }


        #region Main Listings

        //Listing 1.1 - Creatring a thread with the Thread class
        static void MainListing1X1()
        {
            Thread t = new Thread(new ThreadStart(ThreadClass.ThreadMethodLiting1X1));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Mainthread: Dosomework.");
                Thread.Sleep(0);
            }

            t.Join();

            Console.ReadLine();

        }

        //Listing 1.2 - Using a background Thread
        static void MainListing1X2()
        {
            Thread t = new Thread(new ThreadStart(ThreadClass.ThreadMethodLiting1X2));
            t.IsBackground = false;
            t.Start();
        }

        //Listing 1.3 - Using the Parameterized Thread Start
        static void MainListing1X3()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadClass.ThreadMethodLiting1X3));
            t.Start(5);
            t.Join();

            Console.ReadLine();
        }

        //Listing 1.4 - Stopping a Thread
        static void MainListing1X4()
        {
            bool stopped = false;


            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Pressanykeytoexit");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }

        //Listing 1.5 - Using The Thread Static Attribute
        [ThreadStatic]
        public static int _field;
        static void MainListing1X5()
        {

            new Thread(() =>
            { 
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();


            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey();

        }

        //Listing 1.6 - Using ThreadLocal<T>
        public static ThreadLocal<int> _campo =
                new ThreadLocal<int>(() =>
                {
                    return Thread.CurrentThread.ManagedThreadId;
                });
        static void MainListing1X6()
        {
            

            new Thread(() =>
            {
                for (int i = 0; i < _campo.Value; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();


            new Thread(() =>
            {
                for (int i = 0; i < _campo.Value; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey();

        }

        //Listing 1.7 - Queuing some work to the thread pool
        static void MainListing1X7()
        {            

            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a Thread from threadpool");
            });


            Console.ReadLine();

        }


        #endregion
    }
}
