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

namespace TeamFive.Controllers;
[ApiController]
[Route("api/lesson")]
public class LessonController : ControllerBase
{
    private readonly ILessonService _lessonService;
    private readonly ILogger<LessonController> _logger;

    public LessonController(ILessonService LessonServ, ILogger<LessonController> logger)
    {
        _lessonService = LessonServ;
        _logger = logger;
    }


    // Get All Lessons
    [HttpGet("all")]
    public async Task<ActionResult<List<Lesson>>> AllLessons()
    {
        List<Lesson> allLessons = await _lessonService.AllLessons();

        await Task.Delay(1);//This is here until we do something "awaitable"

        return allLessons;
    }


    // Get One Lesson
    [HttpGet("one")]
    public async Task<ActionResult<Lesson?>> OneLesson()
    {
        Lesson? oneLesson = await _lessonService.OneLesson();

        return oneLesson;
    }

    [HttpPost("create-lesson")]
    public async Task<ActionResult<Lesson>> CreateLessonAsync([FromForm] Lesson lesson)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            lesson.LessonId = await _lessonService.CreateLessonAsync(lesson);
            return CreatedAtAction(nameof(OneLesson), new LessonDto(lesson));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }

    }
        // Get Lesson by TeacherId
    [HttpGet("{teacherId}/lessons")]
    public async Task<List<Lesson>> GetAllTeacherLessons(int teacherId)
    {
        List<Lesson> teacherLessonsList = await _lessonService.GetTeacherLessons(teacherId);
        
        if(teacherLessonsList != null)
        {
            return teacherLessonsList;
        }
        else
        {
            throw new Exception("Lesson's not found in DB");

        }
    }
    // Book a Lesson Get Route

    // Book a Lesson Post Route
}
