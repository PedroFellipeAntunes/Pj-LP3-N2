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

            bool sair = false;

            while (!sair)
            {
                // Cria a janela de login
                using (Jn_Login loginForm = new Jn_Login())
                {
                    // Exibe a janela de login e espera seu resultado
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        // Após o login ser bem-sucedido, cria e exibe a janela de menu
                        Usuario usuario = loginForm.UsuarioAutenticado;

                        using (Jn_Menu menuForm = new Jn_Menu(usuario))
                        {
                            menuForm.ShowDialog();

                            // Verifica se o usuário clicou em sair no menu
                            if (menuForm.DialogResult == DialogResult.Cancel)
                            {
                                sair = true;
                            }
                        }
                    }
                    else
                    {
                        sair = true; // Sai do loop se o login falhar ou o usuário fechar a janela
                    }
                }
            }
        }
    }
}