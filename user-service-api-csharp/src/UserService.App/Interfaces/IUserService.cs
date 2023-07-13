using UserService.Domain.Entities.User;

namespace UserService.App.Interfaces;

public interface IUserService
{
    Task<List<User>> GetAllUserAsync();
    Task PostUserAsync(User user);
    Task<User> GetUserByUsername(string username);
}