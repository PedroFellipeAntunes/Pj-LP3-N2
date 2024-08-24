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
    public partial class Jn_CalendarioPopUp : Form
    {
        public DateTime DataSelecionada { get; private set; }
        public bool DataFoiSelecionada { get; private set; } = false;

        public Jn_CalendarioPopUp(DateTime dataInicial)
        {
            InitializeComponent();

            // Configurações do formulário
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;

            // Inicializa o MonthCalendar com a data inicial
            Mc_Calendario.SetDate(dataInicial);
            Mc_Calendario.DateChanged += Mc_Calendario_DateChanged;
        }

        private void Jn_CalendarioPopUp_Load(object sender, EventArgs e)
        {

        }

        private void Mc_Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DataSelecionada = e.Start;
            DataFoiSelecionada = true;
            this.DialogResult = DialogResult.OK;
            this.Close(); // Fecha o popup quando a data é alterada
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);

            if (!DataFoiSelecionada)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close(); // Fecha o popup se ele perder o foco
        }
    }

}
