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
        // ############################################################
        // ##################### Collections Type #####################
        // BlockingCollection <T>
        // ConcurrentBag <T>
        // ConcurrentDictionary <TKey, T>
        // ConcurrentQueue <T>
        // ConcurrentStack <T>
        // ############################################################
        // ############################################################

        static void Main(string[] args)
        {

            // Listing 1.28 - Using BlockingCollection<T> 
            #region Listing 1.28
            //var main = new MainListing1X28();
            #endregion

            // Listing 1.29 - Using GetConsumingEnumerable on a 
            // BlokingCollection
            #region Listing 1.29
            //var main = new MainListing1X29();
            #endregion

            // Listing 1.30 - Using ConcurrentBag 
            #region Listing 1.30
            //var main = new MainListing1X30();
            #endregion

            // Listing 1.31 - Enumerating a ConcurrentBag 
            #region Listing 1.31
            //var main = new MainListing1X31();
            #endregion

            // Listing 1.32 - Using ConcurrentStack 
            #region Listing 1.32
            var main = new MainListing1X32();
            #endregion
        }
    }
}
