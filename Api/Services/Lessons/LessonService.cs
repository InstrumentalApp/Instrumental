using Microsoft.AspNetCore.Mvc;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Tokens;
using TeamFive.DataTransfer.Users;
using TeamFive.DataTransfer.Lessons;
using TeamFive.Models;
using TeamFive.Services;
using TeamFive.Services.Users;
using TeamFive.Services.Tokens;
using TeamFive.Services.Lessons;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics;
using TeamFive.Migrations;

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

    public async Task<LessonDto?> OneLessonAsync(int lessonId)
    {
        // Fetch the lesson and its related entities in one query
        Lesson? oneLesson = await _context.Lessons
            .Include(l => l.Teacher)
            .Include(l => l.Student)
            .Include(l => l.Instrument)
            .FirstOrDefaultAsync(l => l.LessonId == lessonId);

        if (oneLesson == null)
        {
            throw new Exception("Lesson not found in DB");
        }

        //TODO: handle null warnings.
        UserDto lessonTeacherDto = new(oneLesson.Teacher!);
        UserDto lessonStudentDto = new(oneLesson.Student!);
        InstrumentDto lessonInstrumentDto = new(oneLesson.Instrument!);

        LessonDto oneLessonDto = new(oneLesson, lessonTeacherDto, lessonStudentDto, lessonInstrumentDto);
        return oneLessonDto;
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

}
