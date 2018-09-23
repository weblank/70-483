using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _13.UsingEvents
{
    //  Using a Action to expose an event
    public class MainListing1X82
    {
        public void CreateAndRaise()
        {
            Pub P = new Pub();
            P.OnChange += () => Console.WriteLine("Event raised to method 1");
            P.OnChange += () => Console.WriteLine("Event raised to method 2");
            P.Raise();

            Console.ReadKey();
        }
    }


    public class Pub
    {

        public Action OnChange { get; set; }

        public void Raise()
        {

            if (OnChange != null)
            {
                OnChange();
            }
        }
    }

}


