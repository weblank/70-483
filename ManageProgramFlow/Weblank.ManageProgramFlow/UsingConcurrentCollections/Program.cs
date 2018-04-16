using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingConcurrentCollections.Listing;

namespace UsingConcurrentCollections
{
    //     CHAPTER 1: MANAGE PROGRAM FLOW
    // OBJECTIVE 1.1: IMPLEMENT MULTITHREADING AND ASYNCHRONOUS PROCESSING CHAPTER 1
    class Program
    {
        // ##################### Collections Type #####################
        // BlockingCollection <T>
        // ConcurrentBag <T>
        // ConcurrentDictionary <TKey, T>
        // ConcurrentQueue <T>
        // ConcurrentStack <T>

        static void Main(string[] args)
        {
            //Listing 1.28 - Using AsParallel
            #region Listing 1.28
            var main = new MainListing1X28();
            #endregion
        }
    }
}
