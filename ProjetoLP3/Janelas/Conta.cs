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
    public partial class Conta : Form
    {


        public Conta(string nome, string email, int idade, string senha, bool tipoConta)
        {
            InitializeComponent();
            txtEmail.Text = email;
            txtIdade.Text = Convert.ToString(idade);
            txtNome.Text = nome;
            //lblIdade.Text = idade.ToString();

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade ainda não implementada");
        }

        private void Conta_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Usuario novoUsuario = new Usuario();
            string erros = string.Empty;

            
            Ct_Conta ct_Conta = new Ct_Conta();

           
            ResultadoValidacaoUsuario validacaoNome = ct_Conta.ValidarNome(txtNome.Text.Trim());
            ResultadoValidacaoUsuario validacaoEmail = ct_Conta.ValidarEmail(txtEmail.Text.Trim());
            ResultadoValidacaoUsuario validacaoIdade = ct_Conta.ValidarIdade(txtIdade.Text.Trim());

            
            if (!validacaoNome.Sucesso)
            {
                erros += string.Join("\n", validacaoNome.MensagensErro) + "\n";
            }

            if (!validacaoEmail.Sucesso)
            {
                erros += string.Join("\n", validacaoEmail.MensagensErro) + "\n";
            }

            if (!validacaoIdade.Sucesso)
            {
                erros += string.Join("\n", validacaoIdade.MensagensErro) + "\n";
            }

            if (!string.IsNullOrEmpty(erros))
            {
                MessageBox.Show("Erros na validação:\n" + erros);
            }
            else
            {
               

                MessageBox.Show("Alterações salvas com sucesso.");
            }
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Se a tecla digitada não for número
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

        }
    }
}


