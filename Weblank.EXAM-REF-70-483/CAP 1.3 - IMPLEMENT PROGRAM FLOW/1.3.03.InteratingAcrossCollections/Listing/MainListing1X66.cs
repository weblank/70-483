using System;

namespace _10.InteratingAcrossCollections
{
    // A for loop with custom increment
    public class MainListing1X66
    {
        public MainListing1X66()
        {
            int[] values = {1,2,3,4,5,6};

            for (int index = 0; index < values.Length; index += 2)
            {
                Console.WriteLine(values[index]);
            }

            Console.ReadLine();

        }
    }
}
