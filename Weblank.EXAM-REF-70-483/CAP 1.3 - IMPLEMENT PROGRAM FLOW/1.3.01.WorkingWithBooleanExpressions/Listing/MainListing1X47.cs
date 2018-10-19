using System;

namespace WorkingWithBooleanExpressions.Listing
{
    // O uso do operador "OR" tem um detalhe importante !
    // quando o compilador faz a leitura desta condicional com o operador "OR"
    // e a condicional do lado esquerdo for "verdadeira" (true) já podemos deduzir
    // que o resultado será verdadeiro, independente do resultado da condicional a esquerda
    // do operador "OR" (true or false). Lembrando que pela tabela da verdade, se tivermos
    // O operador "OR" e qualquer uma das condições (direita ou esquerda) for verdadeira
    // o resultado será sempre verdadeiro. Quando podemos prever o resultado das condições através
    // da avaliação de apenas uma delas, chamamos de short-circuiting.
    // No próximo Listining teremos um exemplo mais claro.
    public class MainListing1X47
    {
        public MainListing1X47()
        {

            bool x = true;
            bool y = false;

            bool result = x || y;

            Console.WriteLine(result); // Resultado esperado = true
            Console.ReadLine();


        }
    }
}
