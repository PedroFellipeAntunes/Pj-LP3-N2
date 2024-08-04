using ProjetoLP3.Controle;
using ProjetoLP3.Dados;
using ProjetoLP3.Properties;
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
        Ct_FormatarDados ct_Formatar = new Ct_FormatarDados();
        //Filme atualmente escolhido da lista
        private Filme filmeEscolhido;
        //Botão do filme atual
        private Button botaoEscolhido;
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

                // Adicionar evento de clique ao painel principal
                flp_meusFilmes.MouseClick += new MouseEventHandler(flp_meusFilmes_MouseClick);
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

                btnFilme.Click += (s, e) =>
                {
                    filmeEscolhido = filme;
                    botaoEscolhido = btnFilme; //Pra saber qual o botao atual
                    mostrarBotões();
                    mudarTextoLabel(filme);

                    if (filme.Imagem != null)
                    {
                        pboxFilme.Image = filmeEscolhido.Imagem;
                    }
                    else
                    {
                        pboxFilme.Image = Resources.iconFilme;
                    }
                };

                flp_meusFilmes.Controls.Add(btnFilme);
            }
        }

        private void mostrarBotões()
        {
            //Altera as propriedades do botões adicionar e ver detalhes
            btnAssistir.Visible = true;
            btnAssistir.Text = "Assistir ao Filme";
            lbdescricao.Visible = true;
            Lb_duracao.Visible = true;
            Lb_etaria.Visible = true;

        }

        private void esconderBotões()
        {
            //Altera as propriedades do botões adicionar e ver detalhes
            btnAssistir.Visible = false;
            lbdescricao.Visible = false;
            Lb_duracao.Visible = false;
            Lb_etaria.Visible = false;
        }

        private void flp_meusFilmes_MouseClick(object sender, MouseEventArgs e)
        {
            // Verificar se o clique do cursor foi fora dos botões
            if (!btnAssistir.Bounds.Contains(e.Location))
            {
                pboxFilme.Image = Resources.iconFilme;
                filmeEscolhido = null;
                esconderBotões();
                mudarTextoLabel(null);
            }
        }


        private void mudarTextoLabel(Filme filme)
        {
            if (filme != null)
            {
                lbSelecaoFilme.Text = filme.Nome;
                lbdescricao.Text = filme.Descrição;
                Lb_etaria.Text = "" + filme.FaixaEtaria;
                Lb_duracao.Text = ct_Formatar.formatarHoraMinuto(filme.Duração);
            }
            else
            {

                lbSelecaoFilme.Text = "Selecione um filme para assistir agora";
                lbdescricao.Text = "";
                Lb_etaria.Text = "";
                Lb_duracao.Text = "";
            }
        }

        private void flp_meusFilmes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"Deseja assistir ao filme '{filmeEscolhido.Nome}'?",
               "Assistir Filme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                exibirConfirmaçãoAssistir(filmeEscolhido);
            }
        }

        private void exibirConfirmaçãoAssistir(Filme filme)
        {
            MessageBox.Show($"Você está assistindo ao filme '{filme.Nome}'.", "Assistir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
