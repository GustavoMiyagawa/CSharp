using MongoDB.Driver;
using UserService.Domain.Entities.User;
using UserService.Domain.Interfaces.Repositories;

namespace UserService.Repository.MongoDb.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMongoCollection<User> _mongoCollection;

    public UserRepository(IMongoCollection<User> mongoCollection)
    {
        _mongoCollection = mongoCollection;
    }

    public async Task PostUserAsync(User user)
    {
        await _mongoCollection.InsertOneAsync(user);
    }
}