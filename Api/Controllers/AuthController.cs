using Microsoft.AspNetCore.Mvc;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Tokens;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services;
using TeamFive.Services.Users;
using TeamFive.Services.Tokens;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace TeamFive.Controllers;
[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly ITokenService _tokenService;
    private readonly DBContext _context;

    public AuthController(IUserService uServ, ITokenService tServ, DBContext context)
    {
        _userService = uServ;
        _tokenService = tServ;
        _context = context;
    }


    [HttpGet("hello")]
    public async Task<ActionResult<string>> HelloWorld()
    {


        Instrument? instrument = _context.Instruments.FirstOrDefault(i => i.Id == 1);
        string instrumentString = instrument.InstrumentName + " : " + instrument.Category;

        User? firstUser = _context.Users.FirstOrDefault(u => u.Id == 1);
        string userName = firstUser.FirstName + " " + firstUser.LastName;
        
        Lesson? firstLesson = _context.Lessons.FirstOrDefault(l => l.Id == 1);
        string lessonName = firstLesson.LessonName;

        
        string firstLessonJson = JsonSerializer.Serialize(firstLesson);
        Console.WriteLine("------------------" + firstLessonJson + "------------------" );

        
        await Task.Delay(1);//This is here until we do something "awaitable"

        // return "Hello world, From the C# API!" ;
        return "Welcome to Instrumental";
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
}
