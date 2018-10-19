using System;

namespace _1._5._03.ImplementExceptionHandling
{
    //   Inspecting an exception 
    public class MainListing1X95
    {
        public MainListing1X95()
        {
            while (true)
            {

                try
                {
                    SomeOperation();
                }
                catch (Exception logEx)
                {
                    Log(logEx);
                    throw; // rethrow the original exception

                }
            }
        }

        private void Log(Exception e)
        {
            Console.WriteLine("Message: {0}", e.Message);
            Console.WriteLine("StackTrace: {0}", e.StackTrace);
            Console.WriteLine("HelpLink: {0}", e.HelpLink);
            Console.WriteLine("InnerException: {0}", e.InnerException);
            Console.WriteLine("TargetSite: {0}", e.TargetSite);
            Console.WriteLine("Source: {0}", e.Source);
            Console.ReadKey();
        }
        private void SomeOperation()
        {
            throw new NotImplementedException();
        }

    }
}


