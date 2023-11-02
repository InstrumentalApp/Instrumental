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
using System.Text.Json;

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


  // TODO: Build out Lesson Dto in the CreateLessonAsync, so it can be return and create a DTO in the Lesson Creation Post Route

    public async Task<LessonDto?> CreateLessonAsync(Lesson lesson)
    {
      _context.Lessons.Add(lesson);

      int creationResult = await _context.SaveChangesAsync();
      User? teacher = await _context.Users.FirstOrDefaultAsync(u=>u.UserId == lesson.TeacherId);
      User? student = await _context.Users.FirstOrDefaultAsync(u=>u.UserId==lesson.StudentId);
      Instrument? instrument = await _context.Instruments.FirstOrDefaultAsync(i=>i.InstrumentId ==lesson.InstrumentId);

      UserDto? lessonTeacherDto = new(teacher);
      UserDto? lessonStudentDto = new(student);
      InstrumentDto? lessonInstrumentDto = new(instrument);
      LessonDto createdLessonDto = new LessonDto(lesson, lessonTeacherDto, lessonStudentDto, lessonInstrumentDto);

      if(creationResult > 0)
      {
        return createdLessonDto;
      }
      else
      {
        return null;
        throw new Exception("CreateLessonAsync - Failed to Persist lesson object to DB");
      }
    }

    public async Task<List<LessonDto>> AllLessonsForUserIdAsync(int userId)
    {

        Console.WriteLine(userId);
      try
      {
            List<LessonDto> lessonsForUser = await _context.Lessons
                .Include(l => l.Instrument)
                .Include(l => l.Teacher)
                .Include(l => l.Student)
                .Where(l => l.TeacherId == userId)
                .Select(lesson => new LessonDto(lesson, new UserDto(lesson.Student!), new UserDto(lesson.Teacher!), new InstrumentDto(lesson.Instrument!)))
                .ToListAsync();

        return lessonsForUser;
      }
      catch (Exception e)
      {
            Console.WriteLine(e.Message);
            return new();
      }

    }
}
