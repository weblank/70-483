using System;
using System.Threading;

namespace IMAP
{
    //Objective 1.1: Implement multithreading and asynchronous processing Chapter 1

    public class Program
    {
        static void Main(string[] args)
        {
            #region Listing 1.1
            //MainListing1X1(); 
            #endregion

            #region Listing 1.2
            //MainListing1X2(); 
            #endregion

            #region Listing 1.3
            //MainListing1X3();
            #endregion

            #region Listing 1.4
            MainListing1X4();
            #endregion

        }


        #region Main Listings

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

        static void MainListing1X2()
        {
            Thread t = new Thread(new ThreadStart(ThreadClass.ThreadMethodLiting1X2));
            t.IsBackground = false;
            t.Start();
        }

        static void MainListing1X3()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadClass.ThreadMethodLiting1X3));
            t.Start(5);
            t.Join();

            Console.ReadLine();
        }

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

        #endregion
    }
}
