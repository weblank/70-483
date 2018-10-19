using System;

namespace _10.InteratingAcrossCollections
{
    // A for loop with a continue statement
    public class MainListing1X68
    {
        public MainListing1X68()
        {
            int[] values = {1,2,3,4,5,6};

            for (int index = 0; index < values.Length; index ++)
            {
                if (values[index] == 4) continue;
                Console.WriteLine(values[index]);
            }

            Console.ReadLine();

        }
    }
}
