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

namespace TeamFive.Controllers;
[ApiController]
[Route("api/instructor")]
public class InstructorController : ControllerBase
{
  // Calls on IInstructorService
  private readonly IInstructorService _InstructorService;

  // Imports Context and _isntrumentService
  public InstructorController(IInstructorService InstService)
  {
    _InstructorService = InstService;
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


}