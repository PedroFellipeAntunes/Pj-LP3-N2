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

        public Jn_Login()
        {
            InitializeComponent();
        }

        private void Bt_Login_Click(object sender, EventArgs e)
        {
            //Reusando o codigo para verificar validez apenas do email
            ResultadoValidacao validacao = ct_Login.verificarValidez(Tb_Email.Text, Tb_Senha.Text);

            if (validacao.Sucesso)
            {
                //Pedir pro banco de dados o usuario
                MessageBox.Show("Dados CORRETOS.", "Sucesso", MessageBoxButtons.OK);
            }
            else
            {
                string erros = "";

                foreach (var erro in validacao.MensagensErro)
                {
                    erros += "\n" + erro;
                }

                MessageBox.Show("Erros na validação:\n" + erros, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            //Verificar se a janela já está aberta (USEM ESTE CODIGO, MUDAR APENAS O TIPO)
            if (ct_Status.janelaAberta<Jn_CadastroUsuario>())
            {
                return;
            }

            Jn_CadastroUsuario jn_CadastroUsuario = new Jn_CadastroUsuario();

            //Evitar mostrar janela se ela foi fechada por erro
            if (!jn_CadastroUsuario.IsDisposed)
            {
                jn_CadastroUsuario.Show();
            }
        }
    }
}
