using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Tokens;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services;
using TeamFive.Services.Tokens;
using TeamFive.Services.Instructors;
using Microsoft.AspNetCore.Authorization;
using TeamFive.DataTransfer;
using TeamFive.Services.Users;

namespace TeamFive.Controllers;
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
    public async Task<ActionResult<List<User>>> GetTeachersWithInstrumentAsync(int instrumentId)
    {
        List<User> teachersPerInstrument = await _instructorService.TeachersPerInstrument(instrumentId);

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
