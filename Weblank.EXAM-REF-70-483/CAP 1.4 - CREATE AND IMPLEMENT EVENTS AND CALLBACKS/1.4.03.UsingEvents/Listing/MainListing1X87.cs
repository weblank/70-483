using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.UsingEvents
{
    //  Exception when raising an event
    public class MainListing1X87
    {

        public class Pub
        {
            // Especificamos qual o tipo de argumento aceito para este tipo de evento
            public event EventHandler onChange = delegate {};
            
            // Ações que serão lidas na ação "OnChange"
            public void Raise()
            {
                IList<Exception> exceptions= new List<Exception>();

                foreach (Delegate handler in onChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }

                // Observação - Any method vem da biblioteca LINQ
                // Seria igual escrever exceptions.Count() != 0
                if (exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }


            }
        }

        // Quando rodarmos este código teremos um erro na segunda atribuição
        public void CreateAndRaise()
        {
            Pub p = new Pub();
            p.onChange += (sender,e) =>Console.WriteLine("Subscriber 1 called");
            p.onChange += (sender,e) =>{ throw new Exception(); };
            p.onChange += (sender,e) =>{ throw new Exception(); };
            p.onChange += (sender,e) =>Console.WriteLine("Subscriber 3 called");

            try
            {
                p.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.Count);
            }
            
            Console.ReadKey();
        }


    }
}


