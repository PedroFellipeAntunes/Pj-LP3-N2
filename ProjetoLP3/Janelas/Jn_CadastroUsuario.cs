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
    public partial class Jn_CadastroUsuario : Form
    {
        Ct_FormatarDados fd = new Ct_FormatarDados();

        public Jn_CadastroUsuario()
        {
            InitializeComponent();
        }

        private void Jn_CadastroUsuario_Load(object sender, EventArgs e)
        {
            Dtp_Data.Format = DateTimePickerFormat.Custom;
            Dtp_Data.CustomFormat = "dd/MM/yyyy";
        }

        private async void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            // Desativa o botão
            Bt_Cadastrar.Enabled = false;

            Ct_CadastroUsuario ct_CadastroUsuario = new Ct_CadastroUsuario();

            string dataFormatada = Dtp_Data.Value.ToString("yyyy/MM/dd");

            string idade = "" + fd.ConverterDataParaIdade(dataFormatada);

            ResultadoValidacao validacao = ct_CadastroUsuario.verificarValidez(Tb_Nome.Text, Tb_Email.Text, Tb_Senha.Text, idade);

            //Tudo valido
            if (validacao.Sucesso)
            {
                // Validar se o BD reconhece o usuario
                bool retorno = await ct_CadastroUsuario.interfaceParaBDAsync(Tb_Email.Text, Tb_Senha.Text, Tb_Nome.Text, dataFormatada);

                if (!retorno)
                {
                    // Usuário cadastrado com sucesso
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("E-Mail já existente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

            // Reativa o botão
            Bt_Cadastrar.Enabled = true;
        }
    }
}
