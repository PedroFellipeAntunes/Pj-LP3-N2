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
    public partial class Jn_Aluguel : Form
    {
        private List<Filme> listaFilmes;
        public Jn_Aluguel(Form MDIpai, List<Filme> listaFilmes)
        {
            this.MdiParent = MDIpai;
            this.listaFilmes = listaFilmes;

            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
