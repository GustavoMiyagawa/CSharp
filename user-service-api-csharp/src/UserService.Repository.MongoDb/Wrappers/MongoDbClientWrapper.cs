using MongoDB.Driver;
using UserService.Domain.Entities.User;
using UserService.Repository.MongoDb.Resources;

namespace UserService.Repository.MongoDb.Wrappers;

public class MongoDbClientWrapper
{
    public readonly NoSQLDatabaseResources Resources;
    public readonly IMongoDatabase UserDataContext;

    public MongoDbClientWrapper(NoSQLDatabaseResources resources)
    {
        Resources = resources;
        
        var settings = MongoClientSettings.FromConnectionString(resources.ConnectionString);

        settings.DirectConnection = true;
        settings.RetryWrites = true;
        settings.RetryReads = true;


        var mongoDbClient = new MongoClient(settings);

        UserDataContext = mongoDbClient.GetDatabase(resources.DatabaseName);
    }
    
    public IMongoCollection<User> GetUserCollection()
    {
        return UserDataContext
            .GetCollection<User>(Resources.UsersCollectionName);
    }
}