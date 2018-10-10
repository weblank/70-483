using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _1._5._03.ImplementExceptionHandling
{
    //   Inspecting an exception 
    public class MainListing1X94
    {
        public MainListing1X94()
        {
            while (true)
            {
                string s = Console.ReadLine();

                try
                {
                    string i = OpenAndParse();
                    // irá matar a aplicação sem cair em nenhum catch
                    Console.WriteLine("Parsed: {0}", i);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Message: {0}", e.Message);
                    Console.WriteLine("StackTrace: {0}", e.StackTrace);
                    Console.WriteLine("HelpLink: {0}", e.HelpLink);
                    Console.WriteLine("InnerException: {0}", e.InnerException);
                    Console.WriteLine("TargetSite: {0}", e.TargetSite);
                    Console.WriteLine("Source: {0}", e.Source);

                }
            }
        }

        public static string OpenAndParse()
        {
            string s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s))
                throw new ArgumentNullException("fileName", "Filename is required");
            return File.ReadAllText(s);
        }



    }
}


