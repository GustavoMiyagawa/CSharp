using MongoDB.Driver;
using UserService.Domain.Entities.User;
using UserService.Domain.Interfaces.Repositories;
using UserService.Repository.MongoDb.Wrappers;

namespace UserService.Repository.MongoDb.Repositories;

public class UserRepository : IUserRepository
{
    private MongoDbClientWrapper _databaseClient;
    private readonly IMongoCollection<User> _userCollection;

    public UserRepository(MongoDbClientWrapper databaseClient)
    {
        _databaseClient = databaseClient;

        _userCollection = _databaseClient.GetUserCollection();
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
        return await _userCollection.AsQueryable().ToListAsync();
    }

    public async Task PostUserAsync(User user)
    {
        await _userCollection.InsertOneAsync(user);
    }

    public async Task<User> GetUserByUsername(string username)
    {
        return await _userCollection.Find(c => c.Username.Equals(username)).FirstOrDefaultAsync();
    }
}