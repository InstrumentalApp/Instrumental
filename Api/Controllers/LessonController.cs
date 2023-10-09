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

namespace TeamFive.Controllers;
[ApiController]
[Route("api/lesson")]
public class LessonController : ControllerBase
{
    private readonly ILessonService _lessonService;

    public LessonController(ILessonService LessonServ)
    {
        _lessonService = LessonServ;
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

}
