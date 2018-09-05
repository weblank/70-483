using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _10.InteratingAcrossCollections
{
    // The compiler-generated code for a foreach loop
    public class MainListing1X74
    {
        public MainListing1X74()
        {
            int x = 3;
            if( x == 3) goto customLabel;
            x++;

            customLabel:
            Console.WriteLine(x);
            Console.ReadLine();
            // Displays 3

            // You cannot make a jump to a label that’s not in scope. This means you cannot transfer
            // control to another block of code that’s outside of your current block. The compiler also makes
            // sure that any finally blocks that intervene are executed. 
        }
    }
}
