using ProjetoLP3.Dados.Enum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoLP3.Dados
{
    public class Filme
    {
        private int idFilme;
        private string nome; //teste git
        private string descrição;
        private int duração; //Modificado de float para int, considerar isto como segundos
        private int faixaEtaria;
        private bool status;

        private Image imagem;

        private List<Pais> listaLocaisLiberados;
        private List<Genero> listaGenero;

        //Aqui tbm teria o filme em MP4 ou WAV

        public Filme(string nome, string descrição, int duração, int faixaEtaria, bool status, List<Pais> listaLocaisLiberados, List<Genero> listaGenero)
        {
            this.nome = nome;
            this.descrição = descrição;
            this.duração = duração;
            this.faixaEtaria = faixaEtaria;
            this.status = status;
            this.listaLocaisLiberados = listaLocaisLiberados;
            this.listaGenero = listaGenero;
        }

        //Get e Set
        public Image Imagem { get { return imagem; } set { imagem = value; } }
        public int IdFilme { get { return idFilme; } set { idFilme = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Descrição { get { return descrição; } set { descrição = value; } }
        public int Duração { get { return duração; } set { duração = value; } }
        public int FaixaEtaria { get { return faixaEtaria; } set { faixaEtaria = value; } }
        public bool Status { get { return status; } set { status = value; } }
        public List<Pais> ListaLocaisLiberados { get { return listaLocaisLiberados; } set { listaLocaisLiberados = value; } }
        public List<Genero> ListaGenero { get { return listaGenero; } set { listaGenero = value; } }

        //To String
        public override string ToString()
        {
            return $"Nome: {nome}, Faixa Etaria: {faixaEtaria}, Duração: {duração}";
        }
    }
}