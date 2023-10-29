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
  // Calls on IInstructorService
    private readonly IInstructorService _instructorService;
    private readonly IUserService _userService;

  // Imports Context and _isntrumentService
  public InstructorController(IInstructorService InstService, IUserService userServ)
  {
        _instructorService = InstService;
        _userService = userServ;
  }

  // First Call to Database to return full Instructor list stored in DB.
  // Call could be used to populate full list of Instructors to choose lesson from or offer lesson for teachers.

  // [HttpGet("all")]
  // public async Task<ActionResult<List<Instructor>>> AllInstructors()
  // {

  //   // Return full list of all Instructors, unsorted
  //   // Needs await because it is calling an API

  //   List<Instructor> InstructorList = await _InstructorService.AllInstructors();

  //   return InstructorList;
  // }


  // [HttpGet("one")]
  // public async Task<ActionResult<Instructor>> OneInstructor()
  // {
  //   Instructor? oneInstructor = await _InstructorService.OneInstructor();

  //   return oneInstructor;
  // }

    [HttpGet("{instrumentId}/instructors")]
    public async Task<ActionResult<List<User>>> GetTeachersWithInstrument(int instrumentId)
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
