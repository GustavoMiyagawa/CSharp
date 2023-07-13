using Microsoft.AspNetCore.Mvc;
using UserService.App.Interfaces;
using UserService.Domain.Entities.User;

namespace UserService.API.Controllers;

[Route("users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    [Route("")]
    public async Task<List<User>> GetAllUserAsync()
    {
        return await _userService.GetAllUserAsync();
    }

    [HttpPost]
    [Route("")]
    public async Task PostUserAsync([FromBody] User user)
    {
        await _userService.PostUserAsync(user);
    }

    [HttpGet]
    [Route("{username}")]
    public async Task<User> GetUserAsync([FromRoute] string username)
    {
        return await _userService.GetUserByUsername(username);
    }

    [HttpPatch]
    [Route("{username}")]
    public async Task<User> UpdateAsync([FromRoute] string username, [FromBody] )
    {
    }
}