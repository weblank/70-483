using SynchronizingResources.Listing;

namespace SynchronizingResources
{
    //     CHAPTER 1: MANAGE PROGRAM FLOW
    // OBJECTIVE 1.2: MANAGE MULTITHREADING
    class Program
    {
        
        static void Main(string[] args)
        {

            // Listing 1.35 - Accessing shared data in a multithreaded application 
            #region Listing 1.35
            //var main = new MainListing1X35();
            #endregion

            // Listing 1.36 - Using the lock keyword 
            // Comentários importantes na definição do objeto (na classe)
            #region Listing 1.36
            //var main = new MainListing1X36();
            #endregion

            // Listing 1.37 - Creating a deadlock
            #region Listing 1.37
            //var main = new MainListing1X37();
            #endregion

            // Listing 1.38 - Generated code from a lock statement 
            #region Listing 1.38
            //var main = new MainListing1X38();
            #endregion

            // Listing 1.39 - A potential problem with multithreaded code
            #region Listing 1.39
            //var main = new MainListing1X39();
            #endregion

            // Listing 1.40 - Using the Interlocked Class 
            #region Listing 1.40
            //var main = new MainListing1X40();
            #endregion

            // Listing 1.41 - Compare and Exchange as a Nonatomic Operation
            #region Listing 1.41
            //var main = new MainListing1X41();
            #endregion

            // Listing 1.42 - Using a CancellationToken
            #region Listing 1.42
            //var main = new MainListing1X42();
            #endregion

            // Listing 1.43 - Throwing OperationCanceledException
            #region Listing 1.43
            //var main = new MainListing1X43();
            #endregion

            // Listing 1.44 - Adding a Continuation for Canceled Tasks
            #region Listing 1.44
            //var main = new MainListing1X44();
            #endregion

            // Listing 1.45 - Setting a Timeout on a Task
            #region Listing 1.45
            var main = new MainListing1X45();
            #endregion
        }
    }
}
