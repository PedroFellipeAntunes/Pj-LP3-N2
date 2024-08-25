using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RepositorioGenerico<T> where T : class
{
    private readonly IMongoCollection<T> _collection;

    public RepositorioGenerico(string collectionName)
    {
        var mongoConnection = new Bd_Conexao(); // Conexão fixa
        var database = mongoConnection.GetDatabase();
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

    // Ler (Find)
    public async Task<List<T>> GetAllAsync()
    {
        return await _collection.Find(Builders<T>.Filter.Empty).ToListAsync();
    }

    // Encontrar um único documento com filtro
    public async Task<T> FindOneAsync(FilterDefinition<T> filter)
    {
        return await _collection.Find(filter).FirstOrDefaultAsync();
    }

    // Ler com Filtro
    public async Task<List<T>> GetByFilterAsync(FilterDefinition<T> filter)
    {
        return await _collection.Find(filter).ToListAsync();
    }

    // Atualizar
    public async Task UpdateAsync(FilterDefinition<T> filter, UpdateDefinition<T> update)
    {
        await _collection.UpdateManyAsync(filter, update);
    }

    // Excluir
    public async Task DeleteAsync(FilterDefinition<T> filter)
    {
        await _collection.DeleteManyAsync(filter);
    }
}