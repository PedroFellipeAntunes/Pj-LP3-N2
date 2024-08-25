using MongoDB.Driver;
using System;

public class Bd_Conexao
{
    private const string ConnectionString = "mongodb+srv://GenericUser:dSpIganAOdFYoxLu@clusterlp3project.cohrq.mongodb.net/";
    private const string DatabaseName = "loja_filmes";

    private IMongoDatabase _database;

    public Bd_Conexao()
    {
        Connect();
    }

    private void Connect()
    {
        try
        {
            var client = new MongoClient(ConnectionString);
            _database = client.GetDatabase(DatabaseName);
        }
        catch (Exception ex)
        {
            throw new Bd_Conexao_Erro($"Erro ao conectar ao MongoDB: {ex.Message}");
        }
    }

    public IMongoDatabase GetDatabase()
    {
        return _database;
    }
}