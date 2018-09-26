using System;
using System.Threading.Tasks;

namespace _11.UnderstandingDelegates
{
    
    public class MainListing1X76
    {
        public delegate void Del();

        // A multicast delegate
        public MainListing1X76()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();

            // Também é possível remover métodos de uma lista de métodos
            // usando o decrementador - ou -=

            // Para saber quantos métodos existem em um delegate
            int invocationCount = d.GetInvocationList().GetLength(0);
            Console.WriteLine(invocationCount);
        }

        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
            Console.ReadLine();
        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
            Console.ReadLine();
        }
    }
}
