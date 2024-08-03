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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoLP3.Janelas
{
    public partial class Jn_Aluguel : Form
    {
        private Ct_Aluguel ct_Aluguel = new Ct_Aluguel();

        private Usuario usuario;

        private List<Filme> listaFilmesOriginal; //Backup para reset
        private List<Filme> listaFilmesNova;

        public Jn_Aluguel(Usuario usuario, List<Filme> listaFilmes)
        {
            this.usuario = usuario;
            this.listaFilmesOriginal = listaFilmes;
            this.listaFilmesNova = new List<Filme>(listaFilmesOriginal);

            if (this.usuario == null || listaFilmesOriginal == null)
            {
                MessageBox.Show("Valor nulo em construtor de classe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            InitializeComponent();
        }

        private void Jn_Aluguel_Load(object sender, EventArgs e)
        {
            //LOAD LIST VIEW
            loadListView();

            //LOAD DATA ATUAL
            loadDataAtual();

            //LOAD DATA FINAL
            loadDataFinal();

            //LOAD PAGAMENTO LIST
            loadPagamento();

            //LOAD PREÇO
            loadPreço();

            //START TEMPORIZADOR
            Temporizador.Start();
        }

        //OPERAÇÕES LOGICAS
        private void Bt_Remover_Click(object sender, EventArgs e)
        {
            //Verifica se algum item está selecionado
            if (Vw_Filmes.SelectedItems.Count > 0)
            {
                //Remover filmes selecionados
                ct_Aluguel.removerFilmesDoListView(Vw_Filmes, listaFilmesNova);

                //Alterar preço
                Tb_Preço.Text = string.Format("R$ {0:N2}", ct_Aluguel.gerarPreço(listaFilmesNova));
            }
        }

        private void Bt_Reset_Click(object sender, EventArgs e)
        {
            //Reset tudo
            listaFilmesNova = new List<Filme>(listaFilmesOriginal);
            Vw_Filmes.Items.Clear();
            ct_Aluguel.adicionarFilmesAoListView(Vw_Filmes, listaFilmesNova);

            //Alterar preço
            Tb_Preço.Text = string.Format("R$ {0:N2}", ct_Aluguel.gerarPreço(listaFilmesNova));
        }

        private void Bt_Alugar_Click(object sender, EventArgs e)
        {
            if (this.usuario != null && listaFilmesNova.Count != 0)
            {
                if (ct_Aluguel.verificarIdade(usuario, listaFilmesNova))
                {
                    ct_Aluguel.gerarAluguel(listaFilmesNova, this.usuario, DateTime.Now);

                    //Confirmação para o usuario
                    MessageBox.Show("Aluguel gerado, aguardando pagamento", "Sucesso", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Conta não pode alugar por restrição de idade.", "Restrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Requer pelo menos 1 (um) filme para efetuar aluguel.", "Lista vazia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //LOAD JANELA
        private void loadListView()
        {
            //Exibir detalhes
            Vw_Filmes.View = View.Details;
            //Selecionar por linha
            Vw_Filmes.FullRowSelect = true;
            //Exibe linhas
            Vw_Filmes.GridLines = true;

            //Adicionar o cabeçario da tabela
            Vw_Filmes.Columns.Add("Nome", 150);
            Vw_Filmes.Columns.Add("Duração");
            Vw_Filmes.Columns.Add("Faixa Etária", 100, HorizontalAlignment.Center);

            //Adicionar os filmes a tabela
            ct_Aluguel.adicionarFilmesAoListView(Vw_Filmes, listaFilmesOriginal);
        }

        private void loadDataAtual()
        {
            Tb_DataAtual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Tb_HoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void loadDataFinal()
        {
            Mc_DataFinal.Enabled = false;
            Mc_DataFinal.SetDate(ct_Aluguel.data7Dias(DateTime.Today));
            Tb_DataFinal.Text = Mc_DataFinal.SelectionStart.ToString("dd/MM/yyyy");
            Tb_HoraFinal.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void loadPagamento()
        {
            ct_Aluguel.adicionarElementosDropDownList(Cb_Pagamento);
            Cb_Pagamento.SelectedIndex = 0;
        }

        private void loadPreço()
        {
            Tb_Preço.Text = string.Format("R$ {0:N2}", ct_Aluguel.gerarPreço(listaFilmesOriginal));
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Tb_HoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
            Tb_HoraFinal.Text = DateTime.Now.ToString("HH:mm:ss");

            //Verifiquar se é meia-noite
            if (DateTime.Now.TimeOfDay.Hours == 0 && DateTime.Now.TimeOfDay.Minutes == 0 && DateTime.Now.TimeOfDay.Seconds == 0)
            {
                loadDataAtual();
                loadDataFinal();
            }
        }

        //IGNORAR
        private void Vw_Filmes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
