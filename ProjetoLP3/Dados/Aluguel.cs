using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ProjetoLP3.Dados.Enum;
using System.Collections.Generic;

namespace ProjetoLP3.Dados
{
    public class Aluguel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("data_inicial")]
        public string DataInicial { get; set; }

        [BsonElement("data_final")]
        public string DataFinal { get; set; }

        [BsonElement("status")]
        public Status Status { get; set; }

        [BsonIgnore] // Ignorar o campo ao salvar no MongoDB
        public List<Filme> ListaFilmes { get; set; }

        [BsonElement("lista_filmes_id")]
        public List<string> ListaFilmesID { get; set; }

        public Aluguel() { }

        public Aluguel(string dataInicial, string dataFinal, Status status, List<Filme> listaFilmes)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;
            Status = status;
            ListaFilmes = listaFilmes;

            //Criar lista
            ListaFilmesID = new List<string>();
            foreach (var filme in listaFilmes)
            {
                ListaFilmesID.Add(filme.Id);
            }
        }

        public override string ToString()
        {
            return $"Data Inicial: {DataInicial}, Data Final: {DataFinal}, Status: {Status}, Quantidade de Filmes: {ListaFilmes.Count}";
        }
    }
}