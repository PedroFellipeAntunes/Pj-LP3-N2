using ProjetoLP3.Janelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP3.Controle
{
    internal class Ct_VisualJanela
    {
        //Codigo que força a janela inteira no MDI pai
        public void janelaGrande(Form janela)
        {
            janela.WindowState = FormWindowState.Maximized;
            janela.ControlBox = false;
        }
    }
}
