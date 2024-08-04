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
    public partial class Jn_MeusFilmes : Form
    {
        //Classe de controle
        private Ct_MeusFilmes ct_MeusFilmes = new Ct_MeusFilmes();

        private Usuario usuario;
        private List<Filme> filmesAlugados;

        public Jn_MeusFilmes(Form MDIpai, Usuario usuario)
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

        private void Jn_MeusFilmes_Load(object sender, EventArgs e)
        {
            //Carregar os filmes alugados primeiro
            filmesAlugados = ct_MeusFilmes.obterFilmesAlugados(usuario);

            //Adicionar ao flowlayout
            if (filmesAlugados == null)
            {
                MessageBox.Show("Você não possui filmes alugados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ExibirFilmesAlugados();
            }
        }

        private void ExibirFilmesAlugados()
        {
            foreach (var filme in filmesAlugados)
            {
                // Configuração de design do Button
                Button btnFilme = new Button
                {
                    Text = filme.Nome,
                    Width = 100,
                    Height = 150,
                    TextAlign = ContentAlignment.BottomCenter, // Alinhando o texto na parte inferior do botão
                    ImageAlign = ContentAlignment.MiddleCenter // Alinhando a imagem no centro do botão
                };

                // Se o filme não tiver imagem, usar genérica
                if (filme.Imagem != null)
                {
                    btnFilme.Image = new Bitmap(filme.Imagem, new Size(100, 150)); // Ajustando o tamanho da imagem
                }
                else
                {
                    btnFilme.Image = new Bitmap(Properties.Resources.iconFilme, new Size(100, 150)); // Ajustando o tamanho da imagem
                }

                flp_meusFilmes.Controls.Add(btnFilme);
            }
        }
    }
}
