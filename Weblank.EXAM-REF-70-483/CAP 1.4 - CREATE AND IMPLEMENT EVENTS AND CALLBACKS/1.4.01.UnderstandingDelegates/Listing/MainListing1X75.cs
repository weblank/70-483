using System;

namespace _11.UnderstandingDelegates
{

    public class MainListing1X75
    {
        public delegate int Calculate(int x, int y);

        public int Add(int x, int y) => x + y;
        public int Multiply(int x, int y) => x * y;
        
        // Using Delegate
        public MainListing1X75()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3,4)); // Displays  7

                      calc = Multiply;
            Console.WriteLine(calc(3,4)); // Displays 12
            Console.ReadLine();

        }
    }
}
