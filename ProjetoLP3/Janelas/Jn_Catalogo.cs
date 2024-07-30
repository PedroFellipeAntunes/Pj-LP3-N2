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
    public partial class Jn_Catalogo : Form
    {
        //Objetos de classe
        Ct_JanelaStatus ct_Status = new Ct_JanelaStatus();
        Ct_VisualJanela ct_Visual = new Ct_VisualJanela();

        //Variaveis locais
        private Usuario usuario;
        private List<Filme> todosFilmes; //Todos os filmes que existem no catalogo
        private List<Filme> filmesSelecionados = new List<Filme>(); //Filmes que seram escolhidos

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
            //Aqui tu vai fazer o codigo que carrega os elementos na janela
            //USE uma outra classe de controle! não coloque tudo dentro de apenas esta classe
            //Veja como eu fiz o meu codigo de ALUGUEL! eu uso uma classe Ct_Aluguel separada
        }

        //BOTÃO DE ALUGUEL
        //Saindo da janela de catalogo pra janela de aluguel
        //Usuario pode querer voltar pra janela de catalogo e continuar adicionando filmes!
        private void Bt_Carrinho_Click(object sender, EventArgs e)
        {
            //Verificar se a janela já está aberta (USEM ESTE CODIGO, MUDAR APENAS O TIPO)
            if (ct_Status.janelaAberta<Jn_Aluguel>())
            {
                return;
            }

            Jn_Aluguel jn_Aluguel = new Jn_Aluguel(this.MdiParent, this.usuario, filmesSelecionados);
            ct_Visual.janelaGrande(jn_Aluguel);

            //Evitar mostrar janela se ela foi fechada por erro
            if (!jn_Aluguel.IsDisposed)
            {
                jn_Aluguel.Show();
            }
        }
    }
}
