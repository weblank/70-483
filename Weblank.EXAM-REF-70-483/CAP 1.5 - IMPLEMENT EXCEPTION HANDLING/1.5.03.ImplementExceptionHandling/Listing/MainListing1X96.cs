using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _1._5._03.ImplementExceptionHandling
{
    //   Inspecting an exception 
    public class MainListing1X96
    {
        public MainListing1X96()
        {
            while (true)
            {

                try
                {
                    SomeOperation();
                }
                catch (Exception ex)
                //catch (MessageQueueException ex)
                {
                    Log(ex);
                    //throw new OrderProcessingException("Error while processing order",ex); // rethrow the original exception

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


