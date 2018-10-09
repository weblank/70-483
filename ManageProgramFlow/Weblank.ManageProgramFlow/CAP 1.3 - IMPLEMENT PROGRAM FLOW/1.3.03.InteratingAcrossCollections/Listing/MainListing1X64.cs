using System;
using System.Threading.Tasks;

namespace _10.InteratingAcrossCollections
{
    public class MainListing1X64
    {
        // A basic for loop
        public MainListing1X64()
        {
            
            int[] values = {1,2,3,4,5,6};

            for (int index = 0; index < values.Length; index++)
            {
                Console.WriteLine(values[index]);
            }

            Console.ReadLine();

        }
    }
}
