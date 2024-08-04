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
            Mtb_Idade.Text = "" + usuario.Idade;

            Tb_Email.ReadOnly = true;
            Tb_Nome.ReadOnly = true;
            Mtb_Idade.ReadOnly = true;

            Cb_Adm.Checked = usuario.TipoConta;
        }

        //LOGICA
        private void Bt_SalvarEditar_Click(object sender, EventArgs e)
        {
            mudarEstado();

            //Verificar se os dados são validos antes de salvar
            if (editando == false)
            {
                ResultadoValidacao validacao = ct_Conta.verificarValidez(Tb_Nome.Text, Tb_Email.Text, Mtb_Idade.Text);

                //Tudo valido
                if (validacao.Sucesso)
                {
                    ct_Conta.atualizarConta(usuario, Tb_Nome.Text, Tb_Email.Text, Mtb_Idade.Text);

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
                Mtb_Idade.ReadOnly = false;

                Bt_Cancelar.Visible = true;

                editando = true; //Mudar estado
            }
            else
            {
                Bt_SalvarEditar.Text = "Editar";

                //Negar edição
                Tb_Email.ReadOnly = true;
                Tb_Nome.ReadOnly = true;
                Mtb_Idade.ReadOnly = true;

                Bt_Cancelar.Visible = false;

                editando = false; //Mudar estado
            }
        }

        private void Cb_Adm_CheckedChanged(object sender, EventArgs e)
        {
            usuario.TipoConta = Cb_Adm.Checked;
            Jn_Menu form = (Jn_Menu) this.MdiParent;
            form.mudarVisibilidade();
        }
    }
}

