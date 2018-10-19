using System.IO;

namespace _11.UnderstandingDelegates
{
    //  Quando inclui um método em um delegate a assinatura do método
    //  não precisa ser exatamente igual ao do Delegate.
    //  quando isso acontece chamamos de "covariance" e "contravariance"
    //  abaixo um exemplo de "covariance"
    public class MainListing1X78
    {
        void DoSomething(TextWriter tw) {}
        public delegate TextWriter CovarianceDel();

        //  Contravariance with delegatees
        public MainListing1X78()
        {
            CovarianceDel DoSomething;
        }

        //  Como o Método DoSomething pode trabalhar com um TextWriter então por dedução
        //  também pode trabalhar com StreamWriter. Pela existência da contravariância,
        //  você pode chamar o delegate  passar uma instância de StreamWriter para o método DoSomething
    }
}
