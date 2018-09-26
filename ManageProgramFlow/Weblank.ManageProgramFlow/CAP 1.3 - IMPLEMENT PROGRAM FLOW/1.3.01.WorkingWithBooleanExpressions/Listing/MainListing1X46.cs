using System;
using System.Threading.Tasks;

namespace WorkingWithBooleanExpressions.Listing
{
    public class MainListing1X46
    {
        public MainListing1X46()
        {
            int x = 42;
            int y = 1;
            int z = 42;


            Console.WriteLine(x == y); // Resultado Esperado == false
            Console.WriteLine(x == z); // Resultado Esperado == true
            Console.ReadLine();


            // ---------------  Operadores Relacionais e de igualdade  -------------------//
            // ---------------------------------------------------------------------------//
            // |        Operator    |       Description           |   Example
            //          <                Less Than                      x < 42;
            //          >               Greater Than                    x > 42;
            //          <=              Less Than or equal to           x <= 42;
            //          >=              Greater Than or equal to        x >= 42;
            //          ==                Equal to                      x == 42;
            //          !=              Not equal to                    x != 42;
            // ---------------------------------------------------------------------------//

            // Também podemos combinar os operadores acima usando outros operadores OR (||), AND (&&) e Exclusive OR (^) 
        }
    }
}
