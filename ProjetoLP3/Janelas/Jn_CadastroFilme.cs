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

        private Filme filme;
        private List<Filme> todosFilmes;

        public bool filmeEditado = false;
        public bool filmeDeleteado = false;

        //Construtor complexo que já define um valor para filme
        //Se filme não for nulo então esta sendo editado
        public Jn_CadastroFilme(List<Filme> listaFilmes, Filme filme = null)
        {
            this.todosFilmes = listaFilmes;
            this.filme = filme;

            if (this.todosFilmes == null)
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

            //LOAD BOTÕES
            loadDataFilme();
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
                    cadastrarOuEditar(duracaoInt, faixaEtariaInt);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dados invalidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Dados faltando.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //LOGICA
        private void cadastrarOuEditar(int duracao, int faixa)
        {
            //Está sendo editado
            if (filme != null)
            {
                ct_CadastroFilme.editarDadosFilme(filme,
                    Tb_Nome.Text,
                    Tb_Descrição.Text,
                    duracao,
                    faixa,
                    Pb_Foto.Image,
                    Clb_Pais.CheckedItems,
                    Clb_Genero.CheckedItems);

                MessageBox.Show("Filme Editado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filmeEditado = true;
                return;
            }

            //Retorna false == erro ao adicionar filme
            if (ct_CadastroFilme.adicionarFilmeAoCatalogo(todosFilmes,
                Tb_Nome.Text,
                Tb_Descrição.Text,
                duracao,
                faixa,
                Pb_Foto.Image,
                Clb_Pais.CheckedItems,
                Clb_Genero.CheckedItems))
            {
                MessageBox.Show("Filme Cadastrado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aconteceu um erro ao cadastrar o filme novo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void loadDataFilme()
        {
            //Se está editando ou não
            if (filme != null)
            {
                Bt_Cadastrar.Text = "Editar filme";
                Bt_Video.Text = "Editar Arquivo de Video";

                ct_CadastroFilme.marcarItensExistentes<Pais>(Clb_Pais, filme.ListaLocaisLiberados);
                ct_CadastroFilme.marcarItensExistentes<Genero>(Clb_Genero, filme.ListaGenero);

                if (filme.Imagem != null)
                {
                    Pb_Foto.Image = filme.Imagem;
                }

                Tb_Nome.Text = filme.Nome;
                Tb_Descrição.Text = filme.Descrição;

                Mtb_FaixaEtaria.Text = "" + filme.FaixaEtaria;
                Mtb_Duração.Text = "" + filme.Duração;

                Bt_Apagar.Visible = true;

                this.Text = "Editar Filme";
            }
        }

        private void Bt_Apagar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja apagar este filme?", "Apagar Filme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado.Equals(DialogResult.Yes))
            {
                todosFilmes.Remove(filme);
                this.filmeDeleteado = true;
                this.Close();
            }
        }
    }
}
