using ProjetoLP3.Banco.Serviço;
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
        // Conecta a interface com o controlador de serviço
        public async Task<List<Filme>> interfaceParaBDAsync(Usuario usuario, string filtro)
        {
            try
            {
                // Chama o serviço de aluguel para cadastrar
                var servico = new Sv_Filme();

                // Faz pesquisa
                return await servico.ObterFilmesAsync(true, usuario, filtro);
            }
            catch (Exception ex)
            {
                // Repropaga a exceção para ser tratada pela interface
                throw new Exception("Erro ao encontrar filmes: " + ex.Message);
            }
        }

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
