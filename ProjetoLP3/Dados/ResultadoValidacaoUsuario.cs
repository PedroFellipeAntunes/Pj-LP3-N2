using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP3.Dados
{
    internal class ResultadoValidacaoUsuario
    {
        public bool Sucesso { get; set; } = true;
        public List<string> MensagensErro { get; set; } = new List<string>();

        public void AdicionarErro(string mensagem)
        {
            Sucesso = false;
            MensagensErro.Add(mensagem);
        }
    }
}
