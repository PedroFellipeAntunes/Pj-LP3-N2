using MongoDB.Bson;
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

        public async Task<List<Filme>> ObterFilmesAsync(bool janela, Usuario usuario, string filtro)
        {
            try
            {
                // A query começa pela coleção de usuario
                _repositorio.ChangeCollection("usuarios");

                // Criar a lista de status com base na variável booleana
                // Permite query diferente baseado na tela que vai usar este metodo
                // Se for true então é catalogo
                // Se for false é meus filmes
                var statusValues = janela ? new BsonArray { 0, 2 } : new BsonArray { 2 };

                // Criar o filtro de status
                var matchStatusFilter = new BsonDocument("$match",
                    new BsonDocument("status",
                        new BsonDocument("$in", statusValues)));

                // Isto é um query aggreator do MongoDB
                // isto são etapas separadas de uma pesquisa
                PipelineDefinition<Filme, Filme> pipeline = new[]
                {
                new BsonDocument("$match",
                new BsonDocument("_id",
                ObjectId.Parse(usuario.Id))),
                new BsonDocument("$lookup",
                new BsonDocument
                    {
                        { "from", "alugueis" },
                        { "localField", "_id" },
                        { "foreignField", "id_usuario" },
                        { "as", "alugueis_usuario" }
                    }),
                new BsonDocument("$unwind", "$alugueis_usuario"),
                new BsonDocument("$project",
                new BsonDocument
                    {
                        { "_id", 0 },
                        { "alugueis_usuario", 1 }
                    }),
                new BsonDocument("$replaceRoot",
                new BsonDocument("newRoot", "$alugueis_usuario")),
                new BsonDocument("$lookup",
                new BsonDocument
                    {
                        { "from", "aluguel_filmes" },
                        { "localField", "_id" },
                        { "foreignField", "id_aluguel" },
                        { "as", "aluguel_filmes" }
                    }),
                new BsonDocument("$unwind", "$aluguel_filmes"),
                matchStatusFilter, // Filtro de status complexo
                new BsonDocument("$project",
                new BsonDocument
                    {
                        { "_id", 0 },
                        { "aluguel_filmes", 1 }
                    }),
                new BsonDocument("$replaceRoot",
                new BsonDocument("newRoot", "$aluguel_filmes")),
                new BsonDocument("$lookup",
                new BsonDocument
                    {
                        { "from", "filmes" },
                        { "localField", "id_filme" },
                        { "foreignField", "_id" },
                        { "as", "filme" }
                    }),
                new BsonDocument("$unwind", "$filme"),
                new BsonDocument("$project",
                new BsonDocument
                    {
                        { "_id", 0 },
                        { "filme", 1 }
                    }),
                new BsonDocument("$replaceRoot",
                new BsonDocument("newRoot", "$filme"))
            };

                var filmesAlugados = await _repositorio.AggregateAsync(pipeline);

                // Retorno antes de fazer a segunda pesquisa
                // Apenas usado no meus filmes
                if (!janela)
                {
                    return filmesAlugados;
                }

                // Obter uma lista dos IDs como ObjectId
                List<ObjectId> listaId = new List<ObjectId>();

                foreach (var filme in filmesAlugados)
                {
                    listaId.Add(ObjectId.Parse(filme.Id));
                }

                return await OutrosFilmes(listaId, usuario, filtro);
            }
            catch (Exception ex)
            {
                // Lança uma exceção personalizada para erros de conexão
                throw new Bd_Conexao_Erro("Erro ao buscar os filmes: " + ex.Message);
            }
        }

        // Metodo vai usar a pesquisa anterior para filtrar a nova pesquisa
        private async Task<List<Filme>> OutrosFilmes(List<ObjectId> listaId, Usuario usuario, string filtro)
        {
            // Mudar coleção para filmes
            _repositorio.ChangeCollection("filmes");

            // Construir o filtro para o pipeline
            var matchFilter = new BsonDocument
            {
                { "_id", new BsonDocument("$nin", new BsonArray(listaId)) },
                { "nome", new BsonDocument
                    {
                        { "$regex", filtro },
                        { "$options", "i" }
                    }
                }
            };

            // Adicionar a condição de status somente se tipoConta for false
            if (!usuario.TipoConta)
            {
                matchFilter.Add("status", true);
            }

            // Criar o pipeline
            PipelineDefinition<Filme, Filme> pipeline = new[]
            {
                new BsonDocument("$match", matchFilter)
            };

            return await _repositorio.AggregateAsync(pipeline);
        }
    }
}
