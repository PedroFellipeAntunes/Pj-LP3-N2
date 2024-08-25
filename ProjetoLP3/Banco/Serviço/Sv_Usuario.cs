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

        // Método para verificar se o email já existe no banco de dados
        public async Task<bool> VerificarEmailExistenteAsync(string email)
        {
            try
            {
                var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
                var usuarioExistente = await _repositorio.FindOneAsync(filtro);

                return usuarioExistente != null;
            }
            catch (Bd_Conexao_Erro ex)
            {
                // Propaga a exceção específica de conexão para ser tratada pela interface
                throw new Exception("Erro de conexão ao verificar email: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Propaga qualquer outro erro genérico
                throw new Exception("Erro ao verificar email: " + ex.Message);
            }
        }

        // Método para cadastrar novo usuário no banco
        public async Task CadastrarNovoUsuarioAsync(Usuario usuario)
        {
            try
            {
                // Insere o novo usuário na coleção
                await _repositorio.InsertAsync(usuario);
            }
            catch (Bd_Conexao_Erro ex)
            {
                // Propaga a exceção específica de conexão para ser tratada pela interface
                throw new Exception("Erro de conexão ao cadastrar usuário: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Propaga qualquer outro erro genérico
                throw new Exception("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

        // Filtrar o usuario por email e senha, usado para login
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

        // Método para buscar todos os usuários, usado para admin ver os clientes
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