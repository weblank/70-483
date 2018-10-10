using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _12.UsingLambdaExpressions
{
    //  Creating a lambda expression  with multiple statements
    public class MainListing1X80
    {
        public delegate int Calculate(int x, int y);

        public MainListing1X80()
        {
            Calculate calc = (x,y) => 
            { 
                Console.WriteLine("Adding numbers {0} + {1}",x,y);

                return x + y;
            };

            Console.WriteLine(calc(5,3));

            Console.ReadLine();

        }
    }
}
