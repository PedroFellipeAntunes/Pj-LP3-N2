using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ProjetoLP3.Dados.Enum;
using System.Collections.Generic;
using System.Drawing; // Para o tipo Image

namespace ProjetoLP3.Dados
{
    public class Filme
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("descricao")]
        public string Descricao { get; set; }

        [BsonElement("duracao")]
        public int Duracao { get; set; } // Considerar como segundos

        [BsonElement("faixa_etaria")]
        public int FaixaEtaria { get; set; }

        [BsonElement("status")]
        public bool Status { get; set; }

        [BsonIgnore] // Ignorar o campo ao salvar no MongoDB
        public Image Imagem { get; set; }

        [BsonElement("locais_liberados")]
        public List<Pais> ListaLocaisLiberados { get; set; }

        [BsonElement("generos")]
        public List<Genero> ListaGenero { get; set; }

        public Filme() { }

        public Filme(string nome, string descricao, int duracao, int faixaEtaria, bool status, List<Pais> listaLocaisLiberados, List<Genero> listaGenero)
        {
            Nome = nome;
            Descricao = descricao;
            Duracao = duracao;
            FaixaEtaria = faixaEtaria;
            Status = status;
            ListaLocaisLiberados = listaLocaisLiberados;
            ListaGenero = listaGenero;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Faixa Etária: {FaixaEtaria}, Duração: {Duracao}";
        }
    }
}