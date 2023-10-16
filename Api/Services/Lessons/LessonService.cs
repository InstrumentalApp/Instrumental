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
using System.Data;
using System.Diagnostics;

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
        List<Lesson> allLessons = await _context.Lessons.ToListAsync();
        
        return allLessons;
    }


    // Get One Lesson
    public async Task<Lesson?> OneLesson()
    {
      Lesson? oneLesson = await _context.Lessons.FirstOrDefaultAsync(l => l.LessonId == 1);

      if(oneLesson == null)
      {
        return null;
      }

      return oneLesson;
    }


    public async Task<int> CreateLessonAsync(Lesson lesson)
    {
      _context.Lessons.Add(lesson);

      int creationResult = await _context.SaveChangesAsync();
      
      if(creationResult > 0)
      {
        return lesson.LessonId;
      }
      else
      {
        throw new Exception("CreateLessonAsync - Failed to Persist lesson object to DB");
      }
    }

    // Return Lessons searched by Teacher Route
    public async Task<List<Lesson>> GetTeacherLessons(int teacherId)
    {
      List<Lesson> lessonsOffered = await _context.Lessons.Where(t => t.TeacherId == teacherId).ToListAsync();

      if(lessonsOffered != null)
      {
        return lessonsOffered;
      }
      else
      {
        throw new Exception("Lesson's not found in DB");
      }

    }


    

    // When a User signs up to be a teacher and wants to display availability
      // Times of the week available?
      // Should times be available in a block, or should lessons be preloaded on creation
        // Most sense to have available times blocks

      // Availability is displayed on Calendar
        // Student create/request a lesson within an available block

      

}
