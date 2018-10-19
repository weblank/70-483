using System;

namespace _12.UsingLambdaExpressions
{
    //  Using the Action and Func Delegate
    public class MainListing1X81
    {
        // Action é o uso de delegate sem retorno (void)
        // Func é o uso de delegate com retorno
        public MainListing1X81()
        {
            Func<int,int,int> calc = (x,y) => 
            { 
                Console.WriteLine("Adding numbers {0} + {1}",x,y);

                return x + y;
            };

            Console.WriteLine(calc(5,3));

            Console.ReadLine();

        }

        // As coisas ficam mais complicadas quando a expressão lambda ou sou método precisa
        // referenciar variáveis declaradas fora da expressão ou método ou da referência do "this" e retornar a origem.
        // Neste caso o delegate teria uma "vida" + longa que a variável.
        // Para resolver este problema o compilador gera um código que permite que o variável dure até o final do ciclo de vida
        // do delegate, chamamos isso de "closure".
    }
}
