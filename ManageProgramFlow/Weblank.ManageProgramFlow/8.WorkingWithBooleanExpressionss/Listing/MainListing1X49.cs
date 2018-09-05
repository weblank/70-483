using System;
using System.Threading;

namespace WorkingWithBooleanExpressions.Listing
{
    public class MainListing1X49
    {
        // Neste caso não precisariamos colocar os parênteses nas condicionais
        // porém, para facilitar a leitura, colocamos os parênteses.
        public MainListing1X49()
        {
            int value = 42;
            bool result = (0 < value) && (value < 100);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
