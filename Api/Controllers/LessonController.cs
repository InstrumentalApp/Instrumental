using Microsoft.AspNetCore.Mvc;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Tokens;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services;
using TeamFive.Services.Users;
using TeamFive.Services.Tokens;
using TeamFive.Services.Lessons;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using TeamFive.DataTransfer.Lessons;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace TeamFive.Controllers;
[Authorize]
[ApiController]
[Route("api/lesson")]
public class LessonController : ControllerBase
{
    private readonly ILessonService _lessonService;
    private readonly ILogger<LessonController> _logger;
    private readonly ITokenService _tokenService;

    public LessonController(ILessonService LessonServ, ILogger<LessonController> logger, ITokenService tokenService)
    {
        _lessonService = LessonServ;
        _logger = logger;
        _tokenService = tokenService;
    }

    [Authorize(Policy = "SUPERUSER")]
    [HttpGet("all")]
    public async Task<ActionResult<List<Lesson>>> AllLessons()
    {
        List<Lesson> allLessons = await _lessonService.AllLessons();

        return allLessons;
    }

    [HttpGet("{id}")]
    [ActionName(nameof(OneLesson))]
    public async Task<ActionResult<LessonDto?>> OneLesson(int id)
    {
        int claim = _tokenService.GetIdClaimFromHeaderValue(Request);
        if (claim < 0)
        {
            return BadRequest("Resource not found.");
        }
        LessonDto? oneLesson = await _lessonService.OneLessonAsync(id, claim);
        if (oneLesson == null)
        {
            return BadRequest("Something went wrong.");
        }
        return oneLesson;
    }


    // Update Lesson Service to Include Updated UserDto so Lessons can be created and return lesson info on React to be Displayed
    [HttpPost]
    public async Task<ActionResult<Lesson>> CreateLessonAsync(Lesson lesson)
    {
        if (!ModelState.IsValid)
        {
            Console.WriteLine("Modelstate invalid");
            return BadRequest(ModelState);
        }

        LessonDto? createdLesson = await _lessonService.CreateLessonAsync(lesson);

        if (createdLesson == null)
        {
            return BadRequest("Something went wrong when booking the lesson");
        }
        try
        {
            return CreatedAtAction(nameof(OneLesson),new {id= createdLesson.LessonId}, createdLesson);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }

    }

    [HttpGet("user")]
    public async Task<ActionResult<List<LessonWithStartEnd>>> LessonsForUser()
    {
        int claim = _tokenService.GetIdClaimFromHeaderValue(Request);

        if (claim < 0)
        {
            return BadRequest();
        }
        List<LessonWithStartEnd> allLessonsForUserId = await _lessonService.AllLessonsForUserIdAsync(claim);
        return allLessonsForUserId;
    }
}
