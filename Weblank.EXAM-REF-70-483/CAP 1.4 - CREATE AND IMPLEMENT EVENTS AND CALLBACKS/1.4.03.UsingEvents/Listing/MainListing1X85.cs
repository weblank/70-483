using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _13.UsingEvents
{
    //  Custom event accessor
    public class MainListing1X85
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
            // Especificamos qual o tipo de argumento aceito para este tipo de evento
            private event EventHandler<MyArgs> onChange = delegate {};
            // 
            public event EventHandler<MyArgs> OnChange
            {
                add
                {
                    lock (onChange)
                    {
                        onChange += value;
                    }
                }
                remove
                {
                    lock (onChange)
                    {
                        onChange -= value;
                    }
                }
            }

            // Ações que serão lidas na ação "OnChange"
            public void Raise()
            {
                onChange(this, new MyArgs(42));
                onChange(this, new MyArgs(52));
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


