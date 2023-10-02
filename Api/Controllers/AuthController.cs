using Microsoft.AspNetCore.Mvc;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services.Users;

namespace TeamFive.Controllers;
[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService uServ)
    {
        _userService = uServ;
    }

    [HttpGet("hello")]
    public async Task<ActionResult<string>> HelloWorld()
    {
        await Task.Delay(1);//This is here until we do something "awaitable"
        return "Hello world, From the C# API!";
    }

    [HttpPost("register")]
    public async Task<ActionResult<UserDto>> RegisterAsync(User user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        UserDto? newUser = await _userService.CreateAsync(user);

        if (newUser == null)
        {
            return StatusCode(500, "Unknown error occured. Please try again.");
        }

        return newUser;
    }
}
