using Microsoft.AspNetCore.Mvc;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Tokens;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services;
using TeamFive.Services.Users;
using Microsoft.EntityFrameworkCore;

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
        return "Hello world, From the C# API!" ;
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

    [HttpPost("login")]
    public async Task<ActionResult<LoginUser>> LoginAsync(LoginUser loginUser)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        UserDto? validUser = await _userService.ValidateUserPasswordAsync(loginUser);

        if (validUser == null)
        {
            return BadRequest("Invalid email or password");
        }

        bool refreshTokensCleared = await _tokenService.DeactivateTokensForUserAsync(validUser.Id);

        if (refreshTokensCleared == false)
        {
            return StatusCode(500, "Error updating user tokens, try again.");
        }

        TokensDto? tokens = await _tokenService.CreateTokensDtoAsync(validUser.Id);

        if (tokens == null)
        {
            return StatusCode(500, "Error saving new refreshtoken to database, try again.");
        }
        return Ok(tokens);
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
            return BadRequest("Something went wrong, try again.");
        }
        return tokens;
    }
}
