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
    public async Task<IActionResult> GetUserAsync([FromRoute] string username)
    {
        return default;
    }

    [HttpPost]
    [Route("")]
    public async Task PostUserAsync([FromBody] User user)
    {
        await _userService.PostUserAsync(user);
    }
}