using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace ProjetoLP3.Dados
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("senha")]
        public string Senha { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("idade")]
        public string Idade { get; set; }

        [BsonElement("tipo_conta")]
        public bool TipoConta { get; set; }

        public List<Aluguel> ListaAlugueis { get; set; }

        public Usuario() { }

        public Usuario(string nome, string senha, string email, string idade, bool tipoConta)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
            Idade = idade;
            TipoConta = tipoConta;
            ListaAlugueis = new List<Aluguel>();
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Email}, Idade: {Idade}";
        }
    }
}
