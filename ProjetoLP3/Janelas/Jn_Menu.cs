using ProjetoLP3.Controle;
using ProjetoLP3.Dados;
using ProjetoLP3.Dados.Enum;
using ProjetoLP3.Janelas;
using System.Windows.Forms;

namespace ProjetoLP3
{
    public partial class Jn_Menu : Form
    {
        private Usuario usuario;

        private Ct_VisualJanela visual = new Ct_VisualJanela();
        private Ct_JanelaStatus status = new Ct_JanelaStatus();

        public Jn_Menu(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirJanelaCatalogoFilmes(object sender, EventArgs e)
        {

        }

        private void abrirJanelaConta(object sender, EventArgs e)
        {
            MessageBox.Show(usuario.ToString()); //Teste excluir dps
        }

        private void abrirJanelaFilmesUsuario(object sender, EventArgs e)
        {

        }

        private void abrirJanelaCadastrarFilme(object sender, EventArgs e)
        {

        }
        //codigo de teste, apagar este botao dps
        private void tstAluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verificar se a janela já está aberta
            if (status.janelaAberta<Jn_Aluguel>())
            {
                return;
            }

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

            Jn_Aluguel jn_Aluguel = new Jn_Aluguel(this, lf);
            visual.janelaGrande(jn_Aluguel);

            jn_Aluguel.Show();
        }
    }
}
