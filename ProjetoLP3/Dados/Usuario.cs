using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoLP3.Dados
{
    public class Usuario
    {
        private int idUsuario;
        private string nome;
        private string senha;
        private string email;
        private int idade;
        private bool tipoConta;

        private List<Aluguel> listaAlugueis;

        public Usuario()
        {

        }
        public Usuario(string nome, string senha, string email, int idade, bool tipoConta)
        {
            this.nome = nome;
            this.senha = senha;
            this.email = email;
            this.idade = idade;
            this.tipoConta = tipoConta;
            this.listaAlugueis = null;
        }

        //Get e Set
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Senha { get { return senha; } set { senha = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int Idade { get { return idade; } set { idade = value; } }
        public bool TipoConta { get { return tipoConta; } set { tipoConta = value; } }
        public List<Aluguel> ListaAlugueis { get { return listaAlugueis; } set { listaAlugueis = value; } }

        //To String
        public override string ToString()
        {
            return $"Nome: {nome}, Email: {email}, Idade: {idade}";
        }
    }
}
