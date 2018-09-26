using System;
using System.Threading;
using System.Threading.Tasks;

namespace _9.MakingDecisions.Listing
{
    // Code blocks and scoping
    public class MainListing1X54
    {
        public MainListing1X54()
        {
            bool b = true;

            if (b)
            {
                int r = 42; // só existe dentro deste bloco (scope)
                b = false; // variável criada fora do escopo e sendo acessada dentro do escopo
            }

            // r is not accessible
            // b is now false

        }
    }
}
