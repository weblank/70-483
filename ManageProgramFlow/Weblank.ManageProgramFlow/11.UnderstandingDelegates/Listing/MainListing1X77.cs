using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace _11.UnderstandingDelegates
{
    //  Quando inclui um método em um delegate a assinatura do método
    //  não precisa ser exatamente igual ao do Delegate.
    //  quando isso acontece chamamos de "covariance" e "contravariance"
    //  abaixo um exemplo de "covariance"
    public class MainListing1X77
    {
        public delegate TextWriter CovarianceDel();

        public StreamWriter MethodStream() { return null;}
        public StringWriter MethodString() { return null;}

        //  Covariance with delegatees
        public MainListing1X77()
        {
            CovarianceDel del;
            del = MethodStream;
            del = MethodString;
        }

        //  Como StreamWriter e StringWriter ambos herdam de TextWriter, podemos usar
        //  o CovarianceDel com os dois métodos.
    }
}
