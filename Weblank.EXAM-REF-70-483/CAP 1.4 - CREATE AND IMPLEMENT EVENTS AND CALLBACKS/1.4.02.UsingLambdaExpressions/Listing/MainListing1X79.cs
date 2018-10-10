using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _12.UsingLambdaExpressions
{
    //  Lambda expression to create a delegate
    public class MainListing1X79
    {
        public delegate int Calculate(int x, int y);

        public MainListing1X79()
        {
            Calculate calc = (x,y) => x + y;
            Console.WriteLine(calc(3,4));  // Displays 7
            calc = (x,y) => x * y;
            Console.WriteLine(calc(3,4));  // Displays 12

            Console.ReadLine();

        }
    }
}
