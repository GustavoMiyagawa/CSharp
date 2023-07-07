using UserService.Domain.Entities.User;

namespace UserService.App.Interfaces;

public interface IUserService
{
    Task<List<User>> GetUserAsync(string username);
    Task PostUserAsync(User user);
}