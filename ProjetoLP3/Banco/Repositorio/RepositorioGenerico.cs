using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ProjetoLP3.Dados;
using System.Security.Cryptography.Xml;

public class RepositorioGenerico<T> where T : class
{
    private IMongoDatabase database;
    private IMongoCollection<T> _collection;

    public RepositorioGenerico(string collectionName)
    {
        var mongoConnection = new Bd_Conexao(); // Conexão fixa
        database = mongoConnection.GetDatabase();
        _collection = database.GetCollection<T>(collectionName);
    }

    // Necessario para query complexas
    public void ChangeCollection(string collectionName)
    {
        _collection = database.GetCollection<T>(collectionName);
    }

    // Criar (InsertOne)
    public async Task InsertAsync(T document)
    {
        await _collection.InsertOneAsync(document);
    }

    // Criar (InsertMany)
    public async Task InsertManyAsync(IEnumerable<T> documents)
    {
        await _collection.InsertManyAsync(documents);
    }

    // Retorna todos os elementos do tipo T (Find)
    public async Task<List<T>> GetAllAsync()
    {
        return await _collection.Find(Builders<T>.Filter.Empty).ToListAsync();
    }

    // Encontrar um único documento com filtro
    public async Task<T> FindOneAsync(FilterDefinition<T> filter)
    {
        return await _collection.Find(filter).FirstOrDefaultAsync();
    }

    // Retorna todos elementos do tipo T com filtro
    public async Task<List<T>> GetByFilterAsync(FilterDefinition<T> filter)
    {
        return await _collection.Find(filter).ToListAsync();
    }

    // Atualizar um parametro
    public async Task UpdateAsync(FilterDefinition<T> filter, UpdateDefinition<T> update)
    {
        await _collection.UpdateOneAsync(filter, update);
    }

    // Atualizar o elemento por inteiro
    public async Task UpdateAsync(FilterDefinition<T> filter, T updatedDocument)
    {
        await _collection.ReplaceOneAsync(filter, updatedDocument);
    }

    // Excluir
    public async Task DeleteAsync(FilterDefinition<T> filter)
    {
        await _collection.DeleteManyAsync(filter);
    }

    // Requer tipo definitivo
    public async Task<List<T>> AggregateAsync(PipelineDefinition<T, T> pipeline)
    {
        var cursor = await _collection.AggregateAsync(pipeline);

        return await cursor.ToListAsync();
    }
}