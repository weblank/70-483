using System;

namespace WorkingWithBooleanExpressions.Listing
{
    // No exemplo abaixo o método GetY nunca será chamado, ja que a
    // primeira condicão da expressão que antecede a chamada, tem como resultado
    // o valor "true", sendo assim, resultado na saída da validação pelo compilador
    // aqui temos um exemplo clássico 
    public class MainListing1X48
    {
        public MainListing1X48()
        {
            bool x = true;

            bool result = x || GetY();

        }

        private bool GetY()
        {
            Console.WriteLine("This method doesn’t get called");
            Console.ReadLine();
            return true;
        }
    }
}
