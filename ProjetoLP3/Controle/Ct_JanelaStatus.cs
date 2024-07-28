using ProjetoLP3.Janelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP3.Controle
{
    internal class Ct_JanelaStatus
    {
        public bool janelaAberta<T>() where T : Form
        {
            foreach (Form janela in Application.OpenForms)
            {
                if (janela is T)
                {
                    janela.BringToFront();
                    return true; //Janela já está aberta
                }
            }
            return false; //Janela não está aberta
        }
    }
}
