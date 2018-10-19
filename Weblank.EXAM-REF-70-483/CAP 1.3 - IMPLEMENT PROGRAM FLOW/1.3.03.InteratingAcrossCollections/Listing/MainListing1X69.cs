using System;

namespace _10.InteratingAcrossCollections
{
    // While Loop
    public class MainListing1X69
    {
        int[] values = {1,2,3,4,5,6};
        public MainListing1X69()
        {
            int index = 0;
            while (index < values.Length)
            {
                Console.WriteLine(values[index]);
                index++;
            }

            Console.ReadLine();

        }
    }
}
