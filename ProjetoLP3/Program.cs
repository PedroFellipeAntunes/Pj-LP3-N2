using ProjetoLP3.Banco.Serviço;
using ProjetoLP3.Dados;
using ProjetoLP3.Janelas;

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

            // Cria a janela de login
            using (Jn_Login loginForm = new Jn_Login())
            {
                // Exibe a janela de login e espera seu resultado
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Após o login ser bem-sucedido, cria e exibe a janela de menu
                    Usuario usuario = loginForm.UsuarioAutenticado;
                    Application.Run(new Jn_Menu(usuario));
                }
            }
        }
    }
}