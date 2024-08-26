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
        //Controlador de dados de catalogo
        Ct_Catalogo ct_Catalogo = new Ct_Catalogo();

        private int larguraBorda = 3;
        private Color corBorda = Color.Teal;

        //Objetos de classe
        Ct_JanelaStatus ct_Status = new Ct_JanelaStatus();
        Ct_VisualJanela ct_Visual = new Ct_VisualJanela();
        Ct_FormatarDados ct_Formatar = new Ct_FormatarDados();

        //Variaveis locais
        private Usuario usuario;
        //Todos os filmes que existem no catalogo
        private List<Filme> todosFilmes;
        //Filmes que serão escolhidos
        private List<Filme> filmesSelecionados = new List<Filme>();


        //Filme atualmente escolhido da lista
        private Filme filmeEscolhido;

        //Botão do filme atual
        private Button botaoEscolhido;

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
            //if (todosFilmes.Count == 0)
           // {
            //    MessageBox.Show("Não há filmes cadastrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // }
           // else
           // {
                //Inicializa os filmes que estão cadastrados
                inicializarFilmes();

                // Adicionar evento de clique ao painel principal
                Flp_Catalogo.MouseClick += new MouseEventHandler(Flp_Catalogo_MouseClick);
            //}
        }

        private async void Bt_Carrinho_Click(object sender, EventArgs e)
        {
            // Verifica se há filmes selecionados no carrinho
            if (filmesSelecionados.Count == 0)
            {
                // Exibe uma mensagem informando que o carrinho está vazio
                MessageBox.Show("O carrinho está vazio. Adicione filmes ao carrinho antes de prosseguir.", "Carrinho Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Verifica se o usuario é cliente
            if (usuario.TipoConta)
            {
                MessageBox.Show("Apenas CLIENTES podem alugar.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                //Se foi alugado reseta o flow e a lista de filmes alugados
                if (jn_Aluguel.foiAlugado)
                {
                    filmeEscolhido = null;
                    esconderBotões();
                    filmesSelecionados.Clear();
                    pboxFilme.Image = Resources.iconFilme;
                    mudarTextoLabel(null);
                    AtualizarQuantidadeFilmes();
                    await inicializarFilmes();
                }
            }
        }

        private async Task inicializarFilmes()
        {
            //Ao iniciar vamos limpar a lista de filmes
            Flp_Catalogo.Controls.Clear();

            //Pedir ao BD os filmes
            todosFilmes = await ct_Catalogo.interfaceParaBDAsync(usuario, Tb_pesquisar.Text);

            //Agora adicionar os botoes
            foreach (var Filme in todosFilmes)
            {
                //TODO: REMOVER
                //Se o usuario ja tem o filme, pular este filme
                //if (ct_Catalogo.verificarUsuarioTemFilme(usuario, Filme))
                //{
                    //continue; //Isto vai pular esta etapa do loop
                //}

                //Se o filme não possui o nome correto
                //if (!ct_Catalogo.contemNomeFilme(Filme, Tb_pesquisar.Text))
                //{
                    //continue;
                //}

                //Configuração de design do Button
                Button btnFilme = new Button
                {
                    Text = Filme.Nome,
                    Width = 100,
                    Height = 150,
                    TextAlign = ContentAlignment.BottomCenter, // Alinhando o texto na parte inferior do botão
                    ImageAlign = ContentAlignment.MiddleCenter // Alinhando a imagem no centro do botão
                };

                //Se o botao ta na lista pro carrinho faz ele ter um visual diferente
                if (filmesSelecionados.Any(f => f.Id == Filme.Id))
                {
                    btnFilme.FlatStyle = FlatStyle.Flat;
                    btnFilme.FlatAppearance.BorderSize = larguraBorda;
                    btnFilme.FlatAppearance.BorderColor = corBorda;
                }

                //Se o filme não tiver imagem usar generica
                if (Filme.Imagem != null)
                {
                    btnFilme.Image = new Bitmap(Filme.Imagem, new Size(100, 150)); // Ajustando o tamanho da imagem
                }
                else
                {
                    btnFilme.Image = new Bitmap(Properties.Resources.iconFilme, new Size(100, 150)); // Ajustando o tamanho da imagem
                }

                btnFilme.Click += (s, e) =>
                {
                    filmeEscolhido = Filme;
                    botaoEscolhido = btnFilme; //Pra saber qual o botao atual
                    mostrarBotões();
                    mudarTextoLabel(Filme);

                    if (Filme.Imagem != null)
                    {
                        pboxFilme.Image = filmeEscolhido.Imagem;
                    }
                    else
                    {
                        pboxFilme.Image = Resources.iconFilme;
                    }
                };

                //Aqui vai adicionar os botoes ao catalgo
                Flp_Catalogo.Controls.Add(btnFilme);
            }
        }

        //Renomeio de metodos
        private void mostrarBotões()
        {
            //Altera as propriedades do botões adicionar e ver detalhes
            btnAdicionarCarrinho.Visible = true;

            if (filmeEscolhido != null)
            {
                if (filmesSelecionados.Any(f => f.Id == filmeEscolhido.Id))
                {
                    btnAdicionarCarrinho.Text = "Remover do Carrinho";
                }
                else
                {
                    btnAdicionarCarrinho.Text = "Adicionar ao Carrinho";
                }
            }

            lbdescricao.Visible = true;
            Lb_duracao.Visible = true;
            Lb_etaria.Visible = true;

            if (usuario.TipoConta)
            {
                Bt_Editar.Visible = true;
            }
        }

        private void esconderBotões()
        {
            //Altera as propriedades do botões adicionar e ver detalhes
            btnAdicionarCarrinho.Visible = false;
            lbdescricao.Visible = false;
            Lb_duracao.Visible = false;
            Lb_etaria.Visible = false;

            if (usuario.TipoConta)
            {
                Bt_Editar.Visible = false;
            }
        }

        private void AtualizarQuantidadeFilmes()
        {
            int quantidadeFilmesSelecionados = filmesSelecionados.Count;
            lbContadorCarrinho.Text = Convert.ToString(quantidadeFilmesSelecionados);
        }


        private void Flp_Catalogo_MouseClick(object sender, MouseEventArgs e)
        {
            // Verificar se o clique do cursor foi fora dos botões
            if (!btnAdicionarCarrinho.Bounds.Contains(e.Location))
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
                lbdescricao.Text = filme.Descricao;
                Lb_etaria.Text = "" + filme.FaixaEtaria;
                Lb_duracao.Text = ct_Formatar.formatarHoraMinuto(filme.Duracao);
            }
            else
            {
                lbSelecaoFilme.Text = "Selecione um filme para aluguel";
                lbdescricao.Text = "";
                Lb_etaria.Text = "";
                Lb_duracao.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            if (filmeEscolhido != null)
            {
                if (!filmesSelecionados.Any(f => f.Id == filmeEscolhido.Id))
                {
                    // Adicionar o filme à lista de filmes selecionados
                    filmesSelecionados.Add(filmeEscolhido);

                    // Atualizar a contagem de filmes selecionados
                    AtualizarQuantidadeFilmes();
                    
                    botaoEscolhido.FlatStyle = FlatStyle.Flat;
                    botaoEscolhido.FlatAppearance.BorderSize = larguraBorda;
                    botaoEscolhido.FlatAppearance.BorderColor = corBorda;

                    // Exibir uma mensagem de confirmação
                    //MessageBox.Show(filmeEscolhido.Nome + " foi adicionado ao carrinho.", "Filme Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    botaoEscolhido.FlatStyle = FlatStyle.Standard;

                    // Remover o filme da lista de filmes selecionados com base no ID
                    filmesSelecionados.RemoveAll(f => f.Id == filmeEscolhido.Id);

                    AtualizarQuantidadeFilmes();

                    //MessageBox.Show(filmeEscolhido.Nome + " foi removido do carrinho.", "Filme Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Exibir uma mensagem informando que o filme já está no carrinho
                    //MessageBox.Show(filmeEscolhido.Nome + " já está no carrinho.", "Filme Já Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                mostrarBotões(); //Ao chamar isso de novo ele vai mudar o texto do botao
            }
        }

        //Verifica toda vez que o texto mudar
        private async void Tb_pesquisar_TextChanged(object sender, EventArgs e)
        {
            await inicializarFilmes();
        }

        private async void Bt_Editar_Click(object sender, EventArgs e)
        {
            if (filmeEscolhido == null)
            {
                MessageBox.Show("Selecione 1 (um) filme para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Verificar se a janela já está aberta (USEM ESTE CODIGO, MUDAR APENAS O TIPO)
            if (ct_Status.janelaAberta<Jn_CadastroFilme>())
            {
                return;
            }

            using (Jn_CadastroFilme jn_Editar = new Jn_CadastroFilme(todosFilmes, filmeEscolhido))
            {
                jn_Editar.ShowDialog();

                //Pode ser que o filme deletado era parte dos filmes no carrinho
                if (jn_Editar.filmeEditado)
                {
                    await inicializarFilmes();

                    if (filmeEscolhido.Imagem != null)
                    {
                        pboxFilme.Image = filmeEscolhido.Imagem;
                    }

                    mudarTextoLabel(filmeEscolhido);
                }
                else if (jn_Editar.filmeDeleteado)
                {
                    await inicializarFilmes();

                    pboxFilme.Image = Resources.iconFilme;
                    esconderBotões();
                    // Remover o filme da lista de filmes selecionados com base no ID
                    filmesSelecionados.RemoveAll(f => f.Id == filmeEscolhido.Id);
                    filmeEscolhido = null;
                    mudarTextoLabel(null);
                    AtualizarQuantidadeFilmes();
                }
            }
        }
    }
}