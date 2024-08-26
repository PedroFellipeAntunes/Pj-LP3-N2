using MongoDB.Bson;
using MongoDB.Driver;
using ProjetoLP3.Controle;
using ProjetoLP3.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLP3.Janelas
{
    public partial class Jn_Login : Form
    {
        private Ct_Login ct_Login = new Ct_Login();
        private Ct_JanelaStatus ct_Status = new Ct_JanelaStatus();

        public Usuario UsuarioAutenticado { get; private set; }

        public Jn_Login()
        {
            InitializeComponent();
        }

        private async void Bt_Login_Click(object sender, EventArgs e)
        {
            try
            {
                // Desativa os botões de login e cadastro
                Bt_Login.Enabled = false;
                Bt_Cadastrar.Enabled = false;

                // Validar se o input do usuario é correto
                ResultadoValidacao validacao = ct_Login.verificarValidez(Tb_Email.Text, Tb_Senha.Text);

                if (validacao.Sucesso)
                {
                    // Validar se o BD reconhece o usuario
                    UsuarioAutenticado = await ct_Login.interfaceParaBDAsync(Tb_Email.Text, Tb_Senha.Text);

                    if (UsuarioAutenticado != null)
                    {
                        // Usuário autenticado com sucesso
                        MessageBox.Show("Usuário autenticado com sucesso!");

                        // Fechar a janela de login
                        this.DialogResult = DialogResult.OK;
                        this.Close(); // Fecha a janela de login
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    string erros = string.Join("\n", validacao.MensagensErro);
                    MessageBox.Show("Erros na validação:\n" + erros, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                // Exibe a mensagem de erro ao usuário
                MessageBox.Show($"Erro ao processar a solicitação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reativa os botões de login e cadastro
                Bt_Login.Enabled = true;
                Bt_Cadastrar.Enabled = true;
            }
        }

        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            //Verificar se a janela já está aberta
            if (ct_Status.janelaAberta<Jn_CadastroUsuario>())
            {
                return;
            }

            using (Jn_CadastroUsuario jn_CadastroUsuario = new Jn_CadastroUsuario())
            {
                jn_CadastroUsuario.ShowDialog();
            }
        }
    }
}
