using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoLP3.Dados
{
    public class Aluguel
    {
        private int idAluguel;
        private string dataInicial;
        private string dataFinal;
        private bool status;

        private List<Filme> listaFilmes;

        public Aluguel(string dataInicial, string dataFinal, bool status, List<Filme> listaFilmes)
        {
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
            this.status = status;
            this.listaFilmes = listaFilmes;
        }

        public int IdAluguel { get { return idAluguel; } set { idAluguel = value; } }
        public string DataInicial { get { return dataInicial; } set { dataInicial = value; } }
        public string DataFinal { get { return dataFinal; } set {dataFinal = value; } }
        public bool Status { get { return status; } set { status = value; } }
        public List<Filme> ListaFilmes { get { return listaFilmes; } set { listaFilmes = value; } }

        //To String
        public override string ToString()
        {
            return $"DataInicial: {dataInicial}, DataFinal: {dataFinal}, Status: {status}";
        }
    }
}