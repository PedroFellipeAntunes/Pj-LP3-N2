using MongoDB.Driver;
using ProjetoLP3.Dados;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoLP3.Banco.Serviço
{
    public class Sv_Filme
    {
        private readonly RepositorioGenerico<Filme> _repositorio;

        public Sv_Filme()
        {
            _repositorio = new RepositorioGenerico<Filme>("filmes"); // Nome da coleção
        }

        // Apagar 1 filme do BD
        public async Task DeletarFilmeAsync(Filme filme)
        {
            try
            {
                // Cria o filtro para encontrar o filme pelo Id
                var filtro = Builders<Filme>.Filter.Eq(f => f.Id, filme.Id);

                // Chama o método de deletar do repositório
                await _repositorio.DeleteAsync(filtro);
            }
            catch (Exception ex)
            {
                // Lança uma exceção personalizada para erros de conexão
                throw new Bd_Conexao_Erro("Erro ao deletar filme: " + ex.Message);
            }
        }

        // Atualizar um filme no banco
        public async Task AtualizarFilmeAsync(Filme filmeAtualizado)
        {
            try
            {
                // Cria o filtro para encontrar o filme pelo Id
                var filtro = Builders<Filme>.Filter.Eq(f => f.Id, filmeAtualizado.Id);

                // Atualiza o filme existente com o novo documento
                await _repositorio.UpdateAsync(filtro, filmeAtualizado);
            }
            catch (Exception ex)
            {
                // Lança uma exceção personalizada para erros de conexão
                throw new Bd_Conexao_Erro("Erro ao atualizar filme: " + ex.Message);
            }
        }

        // Método para cadastrar um novo filme no banco
        public async Task CadastrarNovoFilmeAsync(Filme filme)
        {
            try
            {
                // Insere o novo filme na coleção
                await _repositorio.InsertAsync(filme);
            }
            catch (Exception ex)
            {
                // Lança uma exceção personalizada para erros de conexão
                throw new Bd_Conexao_Erro("Erro ao cadastrar filme: " + ex.Message);
            }
        }

        // Método para buscar um filme pelo nome
        public async Task<Filme> BuscarFilmePorNomeAsync(string nome)
        {
            try
            {
                // Cria o filtro para encontrar o filme com o nome fornecido
                var filtro = Builders<Filme>.Filter.Eq(f => f.Nome, nome);
                var filme = await _repositorio.FindOneAsync(filtro);

                return filme;
            }
            catch (Exception ex)
            {
                // Lança uma exceção personalizada para erros de conexão
                throw new Bd_Conexao_Erro("Erro ao buscar filme: " + ex.Message);
            }
        }

        // Método para buscar todos os filmes
        public async Task<List<Filme>> BuscarTodosFilmesAsync()
        {
            try
            {
                // Utiliza o método GetAllAsync do repositório genérico
                return await _repositorio.GetAllAsync();
            }
            catch (Exception ex)
            {
                // Lança uma exceção personalizada para erros de conexão
                throw new Bd_Conexao_Erro("Erro ao buscar todos os filmes: " + ex.Message);
            }
        }
    }
}
