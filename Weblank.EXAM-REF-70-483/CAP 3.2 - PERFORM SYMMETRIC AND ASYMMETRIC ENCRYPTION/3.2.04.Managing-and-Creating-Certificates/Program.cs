namespace _3._2._4.Managing_and_Creating_Certificates
{
    class Program
    {
        // PIK - Public Key Infrastructure - é um sistema de certificados digitais, autoridades de certificados 
        // e outros autoridades de autenticação e verifica~ção de cada parte envolvida.
        // CA - Certificate Authority - é um terceiro emissor de certificados considerados confiáveis por todas as partes.
        // Em ambiente de teste podemos usar a ferramenta Markecert.exe
        // ### Essa ferramenta gera certificados X.509 para testes. ###
        // commando em terminal -> makecert testCert.cer
        // ### O comando abaixo cria e instala um certificado com o nome "testCertStore" ###
        // makecert -n “CN=WouterDeKort” -sr currentuser -ss testCertStore
        static void Main(string[] args)
        {
            // Listing 3.24 - Using SHA256Managed to calculate a hash code
            #region Listing 3.24
            var result = new MainListing3X24();
            #endregion
        }
    }
}
