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
    public partial class Jn_Conta : Form
    {
        private Ct_Conta ct_Conta = new Ct_Conta();
        private Ct_FormatarDados fd = new Ct_FormatarDados();

        private Usuario usuario;
        private bool editando = false;

        public Jn_Conta(Form MDIpai, Usuario usuario)
        {
            this.MdiParent = MDIpai;
            this.usuario = usuario;

            if (this.MdiParent == null || this.usuario == null)
            {
                MessageBox.Show("Valor nulo em construtor de classe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            InitializeComponent();
        }

        private void Jn_Conta_Load(object sender, EventArgs e)
        {
            //CARREGAR DADOS AO TEXT BOX
            loadDadosUsuario();
        }

        //LOAD
        private void loadDadosUsuario()
        {
            Tb_Email.Text = usuario.Email;
            Tb_Nome.Text = usuario.Nome;
            Lb_idadeTxt.Text = "" + fd.ConverterDataParaIdade(usuario.Idade);

            Dtp_Data.Format = DateTimePickerFormat.Custom;
            Dtp_Data.CustomFormat = "dd/MM/yyyy";

            Dtp_Data.Value = DateTime.Parse(usuario.Idade);

            Tb_Email.ReadOnly = true;
            Tb_Nome.ReadOnly = true;
            Dtp_Data.Enabled = false;
        }

        //LOGICA
        private async void Bt_SalvarEditar_Click(object sender, EventArgs e)
        {
            mudarEstado();

            //Verificar se os dados são validos antes de salvar
            if (editando == false)
            {
                ResultadoValidacao validacao = await ct_Conta.verificarValidez(usuario, Tb_Nome.Text, Tb_Email.Text, Lb_idadeTxt.Text);

                //Tudo valido
                if (validacao.Sucesso)
                {
                    ct_Conta.atualizarConta(usuario, Tb_Nome.Text, Tb_Email.Text, fd.ConverterIdadeParaData(ct_Conta.stringParaInt(Lb_idadeTxt.Text)));

                    MessageBox.Show("Dados atualizados corretamente.", "Sucesso", MessageBoxButtons.OK);
                }
                else
                {
                    string erros = "";

                    foreach (var erro in validacao.MensagensErro)
                    {
                        erros += "\n" + erro;
                    }

                    MessageBox.Show("Erros na validação:\n" + erros, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    loadDadosUsuario(); //não é valido então reseta
                }
            }
        }

        private void Bt_Cancelar_Click(object sender, EventArgs e)
        {
            mudarEstado();
            loadDadosUsuario(); //reseta os dados nos text box
        }

        private void mudarEstado()
        {
            if (editando == false)
            {
                Bt_SalvarEditar.Text = "Salvar";

                //Permitir edição
                Tb_Email.ReadOnly = false;
                Tb_Nome.ReadOnly = false;
                Dtp_Data.Enabled = true;

                Bt_Cancelar.Visible = true;

                editando = true; //Mudar estado
            }
            else
            {
                Bt_SalvarEditar.Text = "Editar";

                //Negar edição
                Tb_Email.ReadOnly = true;
                Tb_Nome.ReadOnly = true;
                Dtp_Data.Enabled = false;

                Bt_Cancelar.Visible = false;

                editando = false; //Mudar estado
            }
        }

        private void Cb_Adm_CheckedChanged(object sender, EventArgs e)
        {
            Jn_Menu form = (Jn_Menu)this.MdiParent;
            form.mudarVisibilidade();
        }

        private void Lb_idadeTxt_Click(object sender, EventArgs e)
        {
            
        }

        private void Dtp_Data_ValueChanged(object sender, EventArgs e)
        {
            string dataFormatada = Dtp_Data.Value.ToString("yyyy/MM/dd");

            Lb_idadeTxt.Text = "" + fd.ConverterDataParaIdade(dataFormatada);
        }
    }
}