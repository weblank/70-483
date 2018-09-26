using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _13.UsingEvents
{
    //  Custom event arguments
    public class MainListing1X84
    {

        public class MyArgs : EventArgs
        {
            public int Value { get; set; }

            public MyArgs(int value)
            {
                Value = value;
            }
        }

        public class Pub
        {
            // Aqui especificamos qual o tipo de argumento aceito para este tipo de evento
            public event EventHandler<MyArgs> OnChange = delegate {};

            // Ações que serão lidas na ação "OnChange"
            public void Raise()
            {
                OnChange(this, new MyArgs(42));
                OnChange(this, new MyArgs(52));
            }
        }

        public void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender,e) =>Console.WriteLine("Event raised: {0}", e.Value);
            p.Raise();
            Console.ReadKey();
        }


    }
}


