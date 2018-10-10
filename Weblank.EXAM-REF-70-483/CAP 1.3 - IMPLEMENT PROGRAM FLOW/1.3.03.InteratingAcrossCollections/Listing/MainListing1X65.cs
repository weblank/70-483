using System;
using System.Threading.Tasks;

namespace _10.InteratingAcrossCollections
{
    
    public class MainListing1X65
    {
        // A for loop with multiple loop variables
        public MainListing1X65()
        {

            int[] values= {1,2,3,4,5,6};

            for (int x = 0, y = values.Length -1;((x < values.Length) && (y >= 0)); x++, y--)
            {
                Console.WriteLine(values[x]);
                Console.WriteLine(values[y]);
            }

            Console.ReadLine();
        }
    }
}
