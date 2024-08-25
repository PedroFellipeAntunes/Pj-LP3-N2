using ProjetoLP3.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP3.Controle
{
    internal class Ct_Catalogo
    {
        public bool verificarUsuarioTemFilme(Usuario usuario, Filme filmeCatalogo)
        {
            //Usuario não tem aluguel
            if (usuario.ListaAlugueis == null)
            {
                return false;
            }

            foreach (var aluguel in usuario.ListaAlugueis)
            {
                foreach (var filme in aluguel.ListaFilmes)
                {
                    //Se o usuario possui um filme com o mesmo ID
                    if (filme.Id.Equals(filmeCatalogo.Id))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool contemNomeFilme(Filme filme, string nome)
        {
            if (!string.IsNullOrWhiteSpace(nome))
            {
                if (!filme.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
