using ProjetoLP3.Controle;
using ProjetoLP3.Dados;
using ProjetoLP3.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ProjetoLP3.Janelas
{

    public partial class Jn_Catalogo : Form
    {
        //Objetos de classe
        Ct_JanelaStatus ct_Status = new Ct_JanelaStatus();
        Ct_VisualJanela ct_Visual = new Ct_VisualJanela();

        //Variaveis locais
        private Usuario usuario;
        //Todos os filmes que existem no catalogo
        private List<Filme> todosFilmes;
        //Filmes que serão escolhidos
        private List<Filme> filmesSelecionados = new List<Filme>();


        //Filme atualmente escolhido da lista
        private Filme filmeEscolhido;

        public Jn_Catalogo(Form MDIpai, Usuario usuario, List<Filme> listaFilmes)
        {
            this.MdiParent = MDIpai;
            this.usuario = usuario;
            this.todosFilmes = listaFilmes;

            if (this.MdiParent == null || this.usuario == null || todosFilmes == null)
            {
                MessageBox.Show("Valor nulo em construtor de classe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            InitializeComponent();
        }

        private void Jn_Catalogo_Load(object sender, EventArgs e)
        {
            if (todosFilmes.Count == 0)
            {
                MessageBox.Show("Não há filmes cadastrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Inicializa os filmes que estão cadastrados
                inicializarFilmes();

                // Adicionar evento de clique ao painel principal
                Flp_Catalogo.MouseClick += new MouseEventHandler(Flp_Catalogo_MouseClick);
            }
        }


        private void Bt_Carrinho_Click(object sender, EventArgs e)
        {
            // Verifica se há filmes selecionados no carrinho
            if (filmesSelecionados.Count == 0)
            {
                // Exibe uma mensagem informando que o carrinho está vazio
                MessageBox.Show("O carrinho está vazio. Adicione filmes ao carrinho antes de prosseguir.", "Carrinho Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Verificar se a janela já está aberta (USEM ESTE CÓDIGO, MUDAR APENAS O TIPO)
            if (ct_Status.janelaAberta<Jn_Aluguel>())
            {
                return;
            }

            using (Jn_Aluguel jn_Aluguel = new Jn_Aluguel(this.usuario, filmesSelecionados))
            {
                jn_Aluguel.ShowDialog();
            }
        }

        private void inicializarFilmes()
        {
            foreach (var Filme in todosFilmes)
            {
                //Configuração de design do Button
                Button btnFilme = new Button
                {
                    Text = Filme.Nome,
                    Width = 100,
                    Height = 150,
                    TextAlign = ContentAlignment.BottomCenter, // Alinhando o texto na parte inferior do botão
                    ImageAlign = ContentAlignment.MiddleCenter // Alinhando a imagem no centro do botão

                };

                //Se o filme não tiver imagem usar generica
                if (Filme.Imagem != null)
                {
                    //btnFilme.Image = Filme.Imagem;
                    btnFilme.Image = new Bitmap(Filme.Imagem, new Size(100, 150)); // Ajustando o tamanho da imagem
                }
                else
                {
                    btnFilme.Image = new Bitmap(Properties.Resources.iconFilme, new Size(100, 150)); // Ajustando o tamanho da imagem

                }

                Flp_Catalogo.Controls.Add(btnFilme);
                btnFilme.Click += (s, e) =>
                {
                    filmeEscolhido = Filme;
                    mostrarBotões();
                    mudarTextoLabel(Filme.Nome, Filme.Descrição);
                    if (Filme.Imagem != null)
                    {
                        pboxFilme.Image = filmeEscolhido.Imagem;
                    }
                    else
                    {
                        pboxFilme.Image = Resources.iconFilme;
                    }
                };
            }
        }

        //Renomeio de metodos
        private void mostrarBotões()
        {
            //Altera as propriedades do botões adicionar e ver detalhes
            btnVerdetalhes.Visible = true;
            lbdescricao.AutoSize = true;
            lbdescricao.MaximumSize = new Size(600, 0); // Limite de largura
            btnAdicionarCarrinho.Visible = true;
            lbdescricao.Visible = true;
        }

        private void esconderBotões()
        {
            //Altera as propriedades do botões adicionar e ver detalhes
            btnVerdetalhes.Visible = false;
            btnAdicionarCarrinho.Visible = false;
            lbdescricao.Visible = false;
        }

        private void AtualizarQuantidadeFilmes()
        {
            int quantidadeFilmesSelecionados = filmesSelecionados.Count;
            lbContadorCarrinho.Text = Convert.ToString(quantidadeFilmesSelecionados);
        }


        private void Flp_Catalogo_MouseClick(object sender, MouseEventArgs e)
        {
            // Verificar se o clique do cursor foi fora dos botões
            if (!btnVerdetalhes.Bounds.Contains(e.Location) && !btnAdicionarCarrinho.Bounds.Contains(e.Location))
            {
                pboxFilme.Image = Resources.iconFilme;
                esconderBotões();
                mudarTextoLabel("Selecione um filme", "");
            }
        }

        private void mudarTextoLabel(String texto, String descricao)
        {
            if (filmeEscolhido != null && filmeEscolhido != null)
            {
                lbSelecaoFilme.Text = texto;
                lbdescricao.Text = descricao;

            }
        }

        private void Flp_Catalogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerdetalhes_Click(object sender, EventArgs e)
        {
            string mensagem = $"ID: {filmeEscolhido.IdFilme}\n\n" +
                              $"Nome: {filmeEscolhido.Nome}\n\n" +
                              $"Descrição: {filmeEscolhido.Descrição}\n\n" +
                              $"Duração: {filmeEscolhido.Duração} segundos\n" +
                              $"Faixa Etária: {filmeEscolhido.FaixaEtaria}\n";

            MessageBox.Show(mensagem, "Detalhes do Filme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            if (filmeEscolhido != null)
            {
                if (!filmesSelecionados.Contains(filmeEscolhido))
                {
                    // Adicionar o filme à lista de filmes selecionados
                    filmesSelecionados.Add(filmeEscolhido);

                    // Atualizar a contagem de filmes selecionados
                    AtualizarQuantidadeFilmes();

                    // Exibir uma mensagem de confirmação
                    MessageBox.Show(filmeEscolhido.Nome + " foi adicionado ao carrinho.", "Filme Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Exibir uma mensagem informando que o filme já está no carrinho
                    MessageBox.Show(filmeEscolhido.Nome + " já está no carrinho.", "Filme Já Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
