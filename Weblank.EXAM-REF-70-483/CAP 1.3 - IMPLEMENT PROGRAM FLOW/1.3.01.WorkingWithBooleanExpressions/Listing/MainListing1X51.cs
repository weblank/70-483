using System;

namespace WorkingWithBooleanExpressions.Listing
{
    public class MainListing1X51
    {
        // Interlocked é um recurso da System.Threading
        // O interlocked é pouco utilizado já que basicamente
        // serve para incremento e decremento de número, assim, 
        // reduzindo sua aplicação apenas para tipos de "números"
        public MainListing1X51()
        {
            
            bool a = true;
            bool b = false;


            Console.WriteLine(a ^ a); // False
            Console.WriteLine(a ^ b); // True
            Console.WriteLine(b ^ b); // False
            Console.ReadLine();


            // ---------------  Tabela de resultado Lógico do operador XOR  ---------------//
            // ---------------------------------------------------------------------------//
            // |   Left Operator   |     Right Operator          |   Result 
            //        True                  True                        False  
            //        True                  False                       True   
            //        False                 True                        True   
            //        False                 False                       False   
            // ---------------------------------------------------------------------------//


        }
    }
}
