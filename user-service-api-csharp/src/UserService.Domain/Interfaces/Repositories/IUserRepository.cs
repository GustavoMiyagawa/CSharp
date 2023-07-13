using UserService.Domain.Entities.User;

namespace UserService.Domain.Interfaces.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetAllUsersAsync();
    Task PostUserAsync(User user);
    Task<User> GetUserByUsername(string username);
}