using MongoDB.Driver;
using ProjetoLP3.Dados;
using System;
using System.Threading.Tasks;

namespace ProjetoLP3.Banco.Serviço
{
    public class Sv_Usuario
    {
        private readonly RepositorioGenerico<Usuario> _repositorio;

        public Sv_Usuario()
        {
            _repositorio = new RepositorioGenerico<Usuario>("usuarios"); // Nome da coleção
        }

        public async Task<Usuario> BuscarUsuarioPorEmailESenhaAsync(string email, string senha)
        {
            try
            {
                // Cria o filtro para encontrar o usuário com o email e senha fornecidos
                var filtro = Builders<Usuario>.Filter.And(
                    Builders<Usuario>.Filter.Eq(u => u.Email, email),
                    Builders<Usuario>.Filter.Eq(u => u.Senha, senha) // Em produção, use hashing para senhas
                );

                // Utiliza o método FindOneAsync do repositório genérico
                var usuario = await _repositorio.FindOneAsync(filtro);

                return usuario;
            }
            catch (Bd_Conexao_Erro ex)
            {
                // Propaga a exceção para ser tratada pela interface
                throw new Exception("Erro ao buscar usuário: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Propaga qualquer outro erro genérico
                throw new Exception("Erro inesperado: " + ex.Message);
            }
        }

        // Método para buscar todos os usuários
        public async Task<List<Usuario>> BuscarTodosUsuariosAsync()
        {
            try
            {
                // Utiliza o método GetAllAsync do repositório genérico
                return await _repositorio.GetAllAsync();
            }
            catch (Exception ex)
            {
                // Repropaga a exceção para ser tratada pelo chamador
                throw new Exception("Erro ao buscar todos os usuários: " + ex.Message);
            }
        }
    }
}