using UserService.Domain.Entities.User;

namespace UserService.Domain.Interfaces.Repositories;

public interface IUserRepository
{
    Task PostUserAsync(User user);
}