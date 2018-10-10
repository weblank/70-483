using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _13.UsingEvents
{
    //  Using a Event keyword
    public class MainListing1X83
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


    public class Pubs
    {
        //não é mais um prop (propriedade) pública e sim um campo público
        public event Action OnChange = delegate { };
        //public delegate void EventHandler(object sender, EventArgs e);


        public void Raise() => OnChange();
    }

}


