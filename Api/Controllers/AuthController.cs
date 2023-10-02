using Microsoft.AspNetCore.Mvc;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;

namespace TeamFive.Controllers;
[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    [HttpGet("hello")]
    public async Task<ActionResult<string>> HelloWorld()
    {
        await Task.Delay(1);//This is here until we do something "awaitable"
        return "Hello world, From the C# API!";
    }

    [HttpPost("register")]
    public async Task<ActionResult<UserDto>> RegisterAsync(User user)
    {
        await Task.Delay(1);//This is here until we do something "awaitable"
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        //TODO: Create an IUserService and a UserService to handle saving user, hashing password, etc.
        UserDto? newUser = new(user);

        return newUser;
    }
}
