using System;
using System.Threading;

namespace UnderstandingThreads
{
    public class ThreadClass
    {
        public static void ThreadMethodLiting1X1()
        {
            for (int i = 0; i< 10; i++)
			{
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
			}
        }

        public static void ThreadMethodLiting1X2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void ThreadMethodLiting1X3(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void ThreadMethodLiting1X4(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

    }
}
