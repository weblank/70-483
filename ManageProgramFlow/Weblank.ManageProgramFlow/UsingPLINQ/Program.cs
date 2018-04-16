using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingPLINQ.Listing;

namespace UsingPLINQ
{
    //     CHAPTER 1: MANAGE PROGRAM FLOW
    // OBJECTIVE 1.1: IMPLEMENT MULTITHREADING AND ASYNCHRONOUS PROCESSING CHAPTER 1
    class Program
    {
        static void Main(string[] args)
        {
            //Listing 1.22 - Using AsParallel
            #region Listing 1.22
            //var main = new MainListing1X22();
            #endregion

            //Listing 1.23 - Unordered parallel query
            #region Listing 1.23
            //var main = new MainListing1X23();
            #endregion

            //Listing 1.24 - Ordered parallel query
            #region Listing 1.24
            //var main = new MainListing1X24();
            #endregion

            //Listing 1.25 - Making a parallel query sequential
            #region Listing 1.25
            //var main = new MainListing1X25();
            #endregion

            //Listing 1.26 - Using ForAll
            #region Listing 1.26
            //var main = new MainListing1X26();
            #endregion

            //Listing 1.27 - Catching AggregateException
            #region Listing 1.27
            var main = new MainListing1X27();
            #endregion
        }
    }
}
