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

namespace TeamFive.Services.Lessons;
public class LessonService : ILessonService
{
    private readonly DBContext _context;

    public LessonService(DBContext context)
    {
        _context = context;
    }

    // Get All Lessons
    public async Task<List<Lesson>> AllLessons()
    {
        List<Lesson> allLessons = _context.Lessons.ToList();

        await Task.Delay(1);//This is here until we do something "awaitable"

        return allLessons;
    }


    // Get One Lesson
    public async Task<Lesson?> OneLesson()
    {
      Lesson? oneLesson = await _context.Lessons.FirstOrDefaultAsync(l => l.Id == 1);

      if(oneLesson == null)
      {
        return null;
      }

      return oneLesson;
    }

}
