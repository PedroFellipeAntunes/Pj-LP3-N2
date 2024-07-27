using ProjetoLP3.Dados;

namespace ProjetoLP3
{
    public partial class Jn_Menu : Form
    {
        private Usuario usuario;

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
    }
}
