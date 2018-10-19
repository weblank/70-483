namespace _3._2._5.Using_Code_Access_Permissions
{
    class Program
    {
        // CAS - Code Access Security
        // Funciona da segunte forma: Ao invés de dar acesso a tudo para todas as aplicações,
        // as aplicações poderão ter restrições por tipo de recursos e as operações que podem executar.

        // Cada permissão de acesso ao código representa um dos seguintes direitos:
        // O direito de acessar um recurso protegido, como um arquivo;
        // O direito de executar uma operação protegida, como acessar código não gerenciado;

        // O CAS executa as seguintes funções no .NET Framework:
        // ■■ Define permissões para acessar recursos do sistema.
        // ■■ Permite que o código exija que seus chamadores tenham permissões específicas. Por exemplo, um
        // biblioteca que expõe métodos que criam arquivos devem impor que seus chamadores tenham o
        // direito para entrada / saída de arquivo.
        // Objetivo 3.2 Realizar criptografia simétrica e assimétrica CAPÍTULO 3 205
        // ■■ Permite que o código exija que seus chamadores possuam uma assinatura digital. Desta forma, o código pode
        // Certifique-se de que ele seja chamado apenas pelos chamadores de uma organização ou local específico.
        // ■■ Aplica todas essas restrições em tempo de execução.

        // A classe base para todas as coisas relacionadas ao CAS é System.Security.CodeAccessPermission.

        // Você pode especificar o CAS de duas maneiras: declarativa ou imperativa

        static void Main(string[] args)
        {
            // Listing 3.25 - Declarative CAS
            #region Listing 3.25
            //var result = new MainListing3X25();
            #endregion

            // Listing 3.26 - Imperative CAS
            #region Listing 3.26
            //var result = new MainListing3X26();
            #endregion
        }
    }
}
