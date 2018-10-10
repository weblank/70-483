using System;
using System.Threading;
using System.Threading.Tasks;

namespace _10.InteratingAcrossCollections
{
    // A for loop with a break statement
    public class MainListing1X67
    {
        public MainListing1X67()
        {
            int[] values = {1,2,3,4,5,6};

            for (int index = 0; index < values.Length; index ++)
            {
                if (values[index] == 4) break;
                Console.WriteLine(values[index]);

            }


            Console.ReadLine();

        }
    }
}
