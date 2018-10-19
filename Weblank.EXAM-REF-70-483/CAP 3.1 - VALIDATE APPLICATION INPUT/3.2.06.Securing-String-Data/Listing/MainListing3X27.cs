using System;
using System.Security;

namespace _3._2._6.Securing_String_Data
{
    public class MainListing3X27
    {
        public MainListing3X27()
        {
            SecuringStringData();
        }

        private static void SecuringStringData()
        {
            using (SecureString ss = new SecureString())
            {
                Console.WriteLine("Please enter password: ");
                while (true)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter) break;

                    ss.AppendChar(cki.KeyChar);
                    Console.Write("*");
                }
                ss.MakeReadOnly();
            }
        }

    }

}