using ProjetoLP3.Dados;

namespace ProjetoLP3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new Jn_Menu(CriarUsuarioGenerico()));
        }

        private static Dados.Usuario CriarUsuarioGenerico()
        {
            return new Usuario(
                "Daniela",
                "123456",
                "daniela@email.com",
                "2000-12-25",
                true);
        }
    }
}