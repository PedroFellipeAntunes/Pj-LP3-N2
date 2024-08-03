using ProjetoLP3.Controle;
using ProjetoLP3.Dados;
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
            // Verificar se a janela já está aberta (USEM ESTE CÓDIGO, MUDAR APENAS O TIPO)
            if (ct_Status.janelaAberta<Jn_Aluguel>())
            {
                return;
            }

            Jn_Aluguel jn_Aluguel = new Jn_Aluguel(this.MdiParent, this.usuario, filmesSelecionados);
            //ct_Visual.janelaGrande(jn_Aluguel);

            // Evitar mostrar janela se ela foi fechada por erro
            if (!jn_Aluguel.IsDisposed)
            {
                jn_Aluguel.Show();
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
                    adicionarButtons();
                    mudarTextoLabel(Filme.Nome, Filme.Descrição);
                };
            }
        }

        private void adicionarButtons()
        {
            //Altera as propriedades do botões adicionar e ver detalhes
            btnVerdetalhes.Visible = true;
            lbdescricao.AutoSize = true;
            lbdescricao.MaximumSize = new Size(600, 0); // Limite de largura
            btnAdicionarCarrinho.Visible = true;
            lbdescricao.Visible = true;
            btnAdicionarCarrinho.Click += new EventHandler(btnAdicionarCarrinho_Click);

        }

        private void removerButtons()
        {
            //Altera as propriedades do botões adicionar e ver detalhes
            btnVerdetalhes.Visible = false;
            btnAdicionarCarrinho.Visible = false;
            lbdescricao.Visible = false;
            btnAdicionarCarrinho.Click -= new EventHandler(btnAdicionarCarrinho_Click);
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            if (filmeEscolhido != null)
            {
                // Adicionar o filme à lista de filmes selecionados
                filmesSelecionados.Add(filmeEscolhido);

                // Exibir uma mensagem de confirmação
                MessageBox.Show(filmeEscolhido.Nome + " foi adicionado ao carrinho.", "Filme Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Flp_Catalogo_MouseClick(object sender, MouseEventArgs e)
        {
            // Verificar se o clique do cursor foi fora dos botões
            if (!btnVerdetalhes.Bounds.Contains(e.Location) && !btnAdicionarCarrinho.Bounds.Contains(e.Location))
            {
                removerButtons();
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
            string mensagem = $"Nome: {filmeEscolhido.Nome}\n\n" +
                              $"Descrição: {filmeEscolhido.Descrição}\n\n" +
                              $"Duração: {filmeEscolhido.Duração} minutos\n" +
                              $"Faixa Etária: {filmeEscolhido.FaixaEtaria}\n";

            MessageBox.Show(mensagem, "Detalhes do Filme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
