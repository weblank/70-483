using System;

namespace _13.UsingEvents
{
    //  Exception when raising an event
    public class MainListing1X86
    {

        public class Pub
        {
            // Especificamos qual o tipo de argumento aceito para este tipo de evento
            public event EventHandler onChange = delegate {};
            
            // Ações que serão lidas na ação "OnChange"
            public void Raise()
            {
                onChange(this,EventArgs.Empty);
            }
        }

        // Quando rodarmos este código teremos um erro na segunda atribuição
        public void CreateAndRaise()
        {
            Pub p = new Pub();
            p.onChange += (sender,e) =>Console.WriteLine("Subscriber 1 called");
            p.onChange += (sender,e) =>{ throw new Exception(); };
            p.onChange += (sender,e) =>Console.WriteLine("Subscriber 3 called");

            p.Raise();
            
            Console.ReadKey();
        }


    }
}


