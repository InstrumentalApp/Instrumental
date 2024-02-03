using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Instrumental.DataStorage;
using Instrumental.DataTransfer.Tokens;
using Instrumental.DataTransfer.Users;
using Instrumental.Models;
using Instrumental.Services;
using Instrumental.Services.Tokens;
using Instrumental.Services.Instructors;
using Microsoft.AspNetCore.Authorization;
using Instrumental.DataTransfer;
using Instrumental.Services.Users;

namespace Instrumental.Controllers;
[ApiController]
[Route("api/instructor")]
public class InstructorController : ControllerBase
{
    private readonly IInstructorService _instructorService;
    private readonly IUserService _userService;
    private readonly ILogger<InstructorController> _logger;

    public InstructorController(IInstructorService InstService, IUserService userServ, ILogger<InstructorController> logger)
    {
        _instructorService = InstService;
        _userService = userServ;
        _logger = logger;
    }
    [HttpGet("{instrumentId}/instructors")]
    public async Task<ActionResult<List<UserDto>>> GetTeachersWithInstrumentAsync(int instrumentId)
    {
        List<UserDto> teachersPerInstrument = await _instructorService.TeachersPerInstrument(instrumentId);

        return teachersPerInstrument;
    }

    [Authorize(Policy = "SUPERUSER")]
    [HttpPost("create")]
    public async Task<ActionResult<UserWithRoleDto?>> CreateAsync(CreateTeacher user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        //TODO: deal with creating a user and emailing them a temp password or token.
        UserWithRoleDto? newUser = await _userService.CreateTeacherAsync(user);
        if (newUser == null)
        {
            return BadRequest();
        }
        return newUser;
    }
}
