using Microsoft.AspNetCore.Mvc;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Tokens;
using TeamFive.DataTransfer.Users;
using TeamFive.Services.Users;
using TeamFive.Services.Tokens;
using TeamFive.DataTransfer;
using Microsoft.AspNetCore.Authorization;
using TeamFive.Models;

namespace TeamFive.Controllers;
[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly ITokenService _tokenService;

    public AuthController(IUserService uServ, ITokenService tServ, DBContext context)
    {
        _userService = uServ;
        _tokenService = tServ;
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

        UserDto? returnUser = await _userService.CreateStudentAsync(user);

        if (returnUser == null)
        {
            return StatusCode(500, "Unknown error occured. Please try again.");
        }

        return returnUser;
    }

    [HttpPost("login")]
    public async Task<ActionResult<UserWithTokens>> LoginAsync(LoginUser loginUser)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        UserWithRoleDto? validUser = await _userService.ValidateUserPasswordAsync(loginUser);
        Console.WriteLine(validUser.Role);
        if (validUser == null)
        {
            ModelState.AddModelError("email", "Invalid email or password");
            return BadRequest(ModelState);
        }

        bool refreshTokensCleared = await _tokenService.DeactivateTokensForUserAsync(validUser.UserId);

        if (refreshTokensCleared == false)
        {
            return StatusCode(500, "Error updating user tokens, try again.");
        }

        TokensDto? tokens = await _tokenService.CreateTokensDtoAsync(validUser.UserId);

        if (tokens == null)
        {
            return StatusCode(500, "Error saving new refreshtoken to database, try again.");
        }

        UserWithTokens userWithTokens = new (validUser, tokens);

        return Ok(userWithTokens);
    }

    [HttpPost("refresh")]
    public async Task<ActionResult<TokensDto>> DoRefreshAsync(RefreshRequestDto refreshRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        TokensDto? tokens = await _tokenService.DoRefreshActionAsync(refreshRequest);
        if (tokens == null)
        {
            return StatusCode(500, "Something went wrong, try again.");
        }
        return tokens;
    }

    [HttpGet("claims")]
    [Authorize]
    public IActionResult GetClaims()
    {
        return Ok(User.Claims.Select(c => new { c.Type, c.Value }).ToList());
    }
}
