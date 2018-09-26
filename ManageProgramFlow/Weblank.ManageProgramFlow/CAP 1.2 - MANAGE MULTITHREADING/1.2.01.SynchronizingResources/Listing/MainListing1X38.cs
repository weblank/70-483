using System.Threading;

namespace SynchronizingResources.Listing
{
    public class MainListing1X38
    {
        // Este é apenas um exemplo da "tradução" 
        // de um lock pelo compilador
        public MainListing1X38()
        {
            object gate = new object();
            bool __lockTaken = false;
            try
            {
                Monitor.Enter(gate, ref __lockTaken);
            }
            finally
            {
                if (__lockTaken)
                    Monitor.Exit(gate);
            }

            //Console.ReadLine();

        }
    }
}
