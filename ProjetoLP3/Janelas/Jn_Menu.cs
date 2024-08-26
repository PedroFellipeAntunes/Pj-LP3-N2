using ProjetoLP3.Banco.Serviço;
using ProjetoLP3.Controle;
using ProjetoLP3.Dados;
using ProjetoLP3.Dados.Enum;
using ProjetoLP3.Janelas;
using System.Windows.Forms;

namespace ProjetoLP3
{
    public partial class Jn_Menu : Form
    {
        private List<Filme> catalogoTodosFilmes = new List<Filme>();

        private Usuario usuario;

        private Ct_VisualJanela ct_Visual = new Ct_VisualJanela();
        private Ct_JanelaStatus ct_Status = new Ct_JanelaStatus();

        public Jn_Menu(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void Jn_Menu_Load(object sender, EventArgs e)
        {
            //Se usuario não é ADM
            if (usuario.TipoConta == false)
            {
                Bt_CadastrarFilme.Visible = false;
            }
        }

        private async void Bt_Catalogo_Click(object sender, EventArgs e)
        {
            //Verificar se a janela já está aberta (USEM ESTE CODIGO, MUDAR APENAS O TIPO)
            if (ct_Status.janelaAberta<Jn_Catalogo>())
            {
                return;
            }

            Jn_Catalogo jn_Catalogo = new Jn_Catalogo(this, this.usuario, catalogoTodosFilmes);
            //ct_Visual.janelaGrande(jn_Catalogo);

            //Evitar mostrar janela se ela foi fechada por erro
            if (!jn_Catalogo.IsDisposed)
            {
                jn_Catalogo.Show();
            }
        }

        private void Bt_Conta_Click(object sender, EventArgs e)
        {
            //Verificar se a janela já está aberta (USEM ESTE CODIGO, MUDAR APENAS O TIPO)
            if (ct_Status.janelaAberta<Jn_Conta>())
            {
                return;
            }

            Jn_Conta jn_Conta = new Jn_Conta(this, usuario);

            //Evitar mostrar janela se ela foi fechada por erro
            if (!jn_Conta.IsDisposed)
            {
                jn_Conta.Show();
            }
        }

        public void mudarVisibilidade()
        {
            Bt_CadastrarFilme.Visible = usuario.TipoConta;
        }

        private void Bt_MeusFilmes_Click(object sender, EventArgs e)
        {
            //Verificar se a janela já está aberta (USEM ESTE CODIGO, MUDAR APENAS O TIPO)
            if (ct_Status.janelaAberta<Jn_MeusFilmes>())
            {
                return;
            }

            Jn_MeusFilmes jn_MeusFilmes = new Jn_MeusFilmes(this, usuario);

            //Evitar mostrar janela se ela foi fechada por erro
            if (!jn_MeusFilmes.IsDisposed)
            {
                jn_MeusFilmes.Show();
            }
        }

        private void Bt_CadastrarFilmes_Click(object sender, EventArgs e)
        {
            //Verificar se a janela já está aberta (USEM ESTE CODIGO, MUDAR APENAS O TIPO)
            if (ct_Status.janelaAberta<Jn_CadastroFilme>())
            {
                return;
            }

            using (Jn_CadastroFilme jn_CadastroFilme = new Jn_CadastroFilme(catalogoTodosFilmes))
            {
                jn_CadastroFilme.ShowDialog();
            }
        }

        private void Bt_Fechar_Click(object sender, EventArgs e)
        {
            //Botão que fecha todas as janelas atuais exceto o Menu
            ct_Status.fecharTudo();
        }

        //CODIGO QUE GERA FILMES PRA TESTE
        private List<Filme> gerarListaTeste()
        {
            //lista de generos genericos
            List<Genero> lg = new List<Genero>();
            lg.Add(Genero.Drama);
            lg.Add(Genero.Romance);
            lg.Add(Genero.Suspense);

            //lista de paises genericos
            List<Pais> lp = new List<Pais>();
            lp.Add(Pais.Brasil);
            lp.Add(Pais.EstadosUnidos);

            //filmes genericos
            Filme f1 = new Filme("Titanic",
                "Barco afunda",
                10_000,
                16,
                true,
                lp,
                lg);

            Filme f2 = new Filme("Vingadores",
                "Herois",
                15_000,
                12,
                true,
                lp,
                lg);

            Filme f3 = new Filme("O Grito",
                "Sustos",
                5_000,
                18,
                true,
                lp,
                lg);

            //Lista de filmes
            List<Filme> lf = new List<Filme>();
            lf.Add(f1);
            lf.Add(f2);
            lf.Add(f3);

            return lf;
        }

        private void Bt_LogOff_Click(object sender, EventArgs e)
        {
            // Pergunta ao usuário se ele realmente deseja sair
            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmar Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o usuário confirmar
            if (result == DialogResult.Yes)
            {
                // Define o DialogResult como Continue e fecha a janela de menu
                this.DialogResult = DialogResult.Continue;
                this.Close();
            }
        }
    }
}
