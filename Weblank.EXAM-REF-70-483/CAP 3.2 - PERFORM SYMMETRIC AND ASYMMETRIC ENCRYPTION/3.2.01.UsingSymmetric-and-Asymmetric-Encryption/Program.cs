namespace _3._2._1.UsingSymmetric_and_Asymmetric_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Using Sysmmetric and Asymmetric Encryption
            // Este Tópico será mais teórico com foco em explicar os princícipios e conceitos básicos
            // da criptografia simétrica e assimétrica. Nos próximos tópicos veremos este mesmo assunto mas
            // com uma abordagem mais prática.

            // Criptografia é sobre o processo complete de encriptar e decriptar.

            // ciphertext -> é o nome que damos ao resultado da criptografia realizada em texto simples (plaintext) 
            // usando um algoritmo que chamados de cifra (cipher).

            // Na criptografia existem basicamente duas formas de trabalhar. Mantendo o algoritmo em segredo ou usando um algoritmo público
            // porém mantendo a "chave" em segredo. Podemos antecipar que manter o algoritmo em segredo não é uma boa prática, já que,
            // em caso de falha de segurança teriamos que alterar o algoritmo em todos os pontos do código fonte. Além disso, um algoritmo público
            // tem um processo de validação e teste de segurança do mesmo o que garante ainda mais sua segurança.

            // Agora que entendemos que a melhor opção é termos um algoritmo público e mantermos a chave em segredo, podemos falar das opções
            // de como manter a chave em segredo. Temos duas opções, assimétrica e simétrica.

            // Simétrica - usa apenas uma chave pública e com esta única chave é possível encriptar e decriptar o dado, ou seja, quem irá encriptar
            // o dado e quem irá decriptar o dado precisarão ter a mesma chave.

            // Assimétrica - Neste caso usamos duas chaves que são relacionadas entre elas através de uma função matemática. Uma chave será pública e usada
            // por qualquer um para encriptar o dado, já a chave privada apenas é usada pelo seu proprietário para decriptar o dado.

            // Além da diferença de segurança entre elas existe uma diferença de performance entre os dois métodos sendo o simétrico mais performático (+ rápido
            // e mais leve) que o método assimétrico.


            // Siglas importantes !
            // DES = Data Encryption Standard
            // NIST = National Institute of Standards and Techonology

            // ### Tipos mais comuns de criptografias no .NET Framework ###
            // System.Security.Cryptography
            // AES = Advanced Encryption Standard (AES) - AesManaged Class;
            // 

            // mais detalhes na documentação completa da Microsoft https://docs.microsoft.com/en-us/dotnet/standard/security/cryptography-model
            #endregion
        }
    }
}
