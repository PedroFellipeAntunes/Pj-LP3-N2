using MongoDB.Bson;
using MongoDB.Driver;
using ProjetoLP3.Dados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP3.Banco.Serviço
{
    internal class Sv_Catalogo
    {
        private readonly RepositorioGenerico<Filme> _filmeRepository;
        private readonly RepositorioGenerico<AluguelFilme> _aluguelFilmeRepository;
        private readonly RepositorioGenerico<Aluguel> _aluguelRepository;

        public Sv_Catalogo()
        {
            _filmeRepository = new RepositorioGenerico<Filme>("filmes");
            _aluguelRepository = new RepositorioGenerico<Aluguel>("alugueis");
            _aluguelFilmeRepository = new RepositorioGenerico<AluguelFilme>("aluguel_filmes");
        }

        public async Task<List<Filme>> FilmesAlugadosAsync(bool janela, Usuario usuario, string filtro)
        {
            // A query começa pela coleção de usuario
            _filmeRepository.ChangeCollection("usuarios");

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

            var filmesAlugados = await _filmeRepository.AggregateAsync(pipeline);

            // Retorno antes de fazer a segunda pesquisa
            // Apenas usado no meus filmes
            if (janela)
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

        // Metodo vai usar a pesquisa anterior para filtrar a nova pesquisa
        private async Task<List<Filme>> OutrosFilmes(List<ObjectId> listaId, Usuario usuario, string filtro)
        {
            // Mudar coleção para filmes
            _filmeRepository.ChangeCollection("filmes");

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

            return await _filmeRepository.AggregateAsync(pipeline);
        }
    }
}
