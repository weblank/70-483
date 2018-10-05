using System;
using System.Threading;
using System.Threading.Tasks;

namespace _9.MakingDecisions.Listing
{
    public class MainListing1X60
    {
        // The conditional operator
        public int GetValue(bool p)
        {

            if(p)
                return 1;
            else
                return 0;

            // Outra forma de escrever + clean
            // return p ? 1 : 0;

        }
    }
}
