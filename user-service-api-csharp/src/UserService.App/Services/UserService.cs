using UserService.App.Interfaces;
using UserService.Domain.Entities.User;
using UserService.Domain.Interfaces.Repositories;

namespace UserService.App.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<List<User>> GetAllUserAsync()
    {
        return _userRepository.GetAllUsersAsync();
    }

    public async Task PostUserAsync(User user)
    {
        await _userRepository.PostUserAsync(user);
    }

    public async Task<User> GetUserByUsername(string username)
    {
        return await _userRepository.GetUserByUsername(username);
    }
}