using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using ProjetoLP3.Dados;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoLP3.Banco.Serviço
{
    //Classe existe para fazer a relação entre aluguel e filme no BD
    public class AluguelFilme
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("id_aluguel")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdAluguel { get; set; }

        [BsonElement("id_filme")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdFilme { get; set; }

        public AluguelFilme() { }

        public AluguelFilme(string idAluguel, string idFilme)
        {
            IdAluguel = idAluguel;
            IdFilme = idFilme;
        }
    }

    public class Sv_Aluguel
    {
        private readonly RepositorioGenerico<Aluguel> _repositorioAluguel;
        private readonly RepositorioGenerico<AluguelFilme> _repositorioAluguelFilme;

        public Sv_Aluguel()
        {
            _repositorioAluguel = new RepositorioGenerico<Aluguel>("alugueis"); // Nome da coleção para aluguéis
            _repositorioAluguelFilme = new RepositorioGenerico<AluguelFilme>("aluguel_filmes"); // Nome da coleção para a relação entre aluguéis e filmes
        }

        // Método para cadastrar um novo aluguel no banco
        public async Task CadastrarNovoAluguelAsync(Aluguel aluguel, List<Filme> listaFilmes)
        {
            try
            {
                // Insere o novo aluguel na coleção
                await _repositorioAluguel.InsertAsync(aluguel);

                // Cria uma lista de objetos AluguelFilme
                var aluguelFilmes = new List<AluguelFilme>();

                foreach (var filme in listaFilmes)
                {
                    var aluguelFilme = new AluguelFilme
                    {
                        IdAluguel = aluguel.Id, // Certifique-se de que este campo corresponde ao ID do aluguel inserido
                        IdFilme = filme.Id
                    };

                    aluguelFilmes.Add(aluguelFilme);
                }

                // Insere todos os documentos de uma vez
                await _repositorioAluguelFilme.InsertManyAsync(aluguelFilmes);
            }
            catch (Exception ex)
            {
                // Lança uma exceção personalizada para erros de conexão
                throw new Bd_Conexao_Erro("Erro ao cadastrar aluguel: " + ex.Message);
            }
        }
    }
}