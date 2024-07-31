using ProjetoLP3.Controle;
using ProjetoLP3.Dados;
using ProjetoLP3.Dados.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjetoLP3.Janelas
{
    public partial class Jn_CadastroFilme : Form
    {
        private Ct_CadastroFilme ct_CadastroFilme = new Ct_CadastroFilme();

        private List<Filme> todosFilmes;

        public Jn_CadastroFilme(Form MDIpai, List<Filme> listaFilmes)
        {
            this.MdiParent = MDIpai;
            this.todosFilmes = listaFilmes;

            if (this.MdiParent == null || this.todosFilmes == null)
            {
                MessageBox.Show("Valor nulo em construtor de classe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            InitializeComponent();
        }

        private void Jn_CadastroFilme_Load(object sender, EventArgs e)
        {
            //LOAD GENERO CHECKBOX
            loadGeneroCheckBox();

            //LOAD PAIS CHECKBOX
            loadPaisCheckBox();
        }

        private void Bt_Video_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Upload de video não suportado no momento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Bt_Cadastrar_Click(object sender, EventArgs e)
        {
            //Verifica se está vazio
            if (!string.IsNullOrEmpty(Tb_Nome.Text) &&
                !string.IsNullOrEmpty(Tb_Descrição.Text) &&
                !string.IsNullOrEmpty(Mtb_Duração.Text) &&
                !string.IsNullOrEmpty(Mtb_FaixaEtaria.Text))
            {
                //Tenta converter de string pra int
                if (int.TryParse(Mtb_Duração.Text, out int duracaoInt) &&
                    int.TryParse(Mtb_FaixaEtaria.Text, out int faixaEtariaInt))
                {
                    ct_CadastroFilme.adicionarFilmeAoCatalogo(todosFilmes,
                        Tb_Nome.Text,
                        Tb_Descrição.Text,
                        duracaoInt,
                        faixaEtariaInt,
                        Pb_Foto.Image,
                        Clb_Pais.CheckedItems,
                        Clb_Genero.CheckedItems);

                    MessageBox.Show("Filme cadastrado.", "Sucesso", MessageBoxButtons.OK);
                    this.Close();
                } else
                {
                    MessageBox.Show("Dados invalidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else
            {
                MessageBox.Show("Dados faltando.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //LOGICA
        private void Bt_Imagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //Define as propriedades do OpenFileDialog
                openFileDialog.Title = "Selecione um arquivo";
                openFileDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png|Todos os arquivos (*.*)|*.*";

                //Exibe a caixa de diálogo e verifica se o usuário selecionou um arquivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Carrega a imagem selecionada no PictureBox
                    Pb_Foto.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        //LOAD
        private void loadGeneroCheckBox()
        {
            ct_CadastroFilme.adicionarElementosCheckList<Genero>(Clb_Genero);
        }

        private void loadPaisCheckBox()
        {
            ct_CadastroFilme.adicionarElementosCheckList<Pais>(Clb_Pais);
        }
    }
}
