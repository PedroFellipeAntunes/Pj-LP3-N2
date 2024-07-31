using ProjetoLP3.Controle;
using ProjetoLP3.Dados;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoLP3.Janelas
{
    //teste
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
            inicializarFilmes();
            // Adicionar evento de clique ao painel principal
            Flp_Catalogo.MouseClick += new MouseEventHandler(Flp_Catalogo_MouseClick);
        }

        // BOTÃO DE ALUGUEL
        // Saindo da janela de catalogo pra janela de aluguel
        // Usuario pode querer voltar pra janela de catalogo e continuar adicionando filmes!
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
                Button btnFilme = new Button
                {
                    Text = Filme.Nome,
                    Width = 100,
                    Height = 100
                };
                
                //Se o filme não tiver imagem usar generica
                if (Filme.Imagem != null)
                {
                    btnFilme.Image = Filme.Imagem;
                }
                else
                {
                    //Mudar este codigo aqui pra usar outra imagem
                    //É preciso "cadastrar" a imagem anteriormente como parte dos recursos
                    btnFilme.Image = Properties.Resources.iconFilme;
                }

                Flp_Catalogo.Controls.Add(btnFilme);
                btnFilme.Click += (s, e) =>
                {
                    adicionarButtons();
                };
            }
        }

        private void adicionarButtons()
        {
            btnVerdetalhes.Visible = true;
            btnAdicionarCarrinho.Visible = true;
            btnAdicionarCarrinho.Click += new EventHandler(btnAdicionarCarrinho_Click);
        }

        private void removerButtons()
        {
            btnVerdetalhes.Visible = false;
            btnAdicionarCarrinho.Visible = false;
            btnAdicionarCarrinho.Click -= new EventHandler(btnAdicionarCarrinho_Click);
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            //Aqui tu vai ter um metodo que pega o filme atual e adiciona a lista de selecionados
            MessageBox.Show("Filme adicionado ao carrinho.");
        }

        private void Flp_Catalogo_MouseClick(object sender, MouseEventArgs e)
        {
            // Verificar se o clique foi fora dos botões
            if (!btnVerdetalhes.Bounds.Contains(e.Location) && !btnAdicionarCarrinho.Bounds.Contains(e.Location))
            {
                removerButtons();
            }
        }

        private void Flp_Catalogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
