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

    public async Task<LessonDto?> OneLessonAsync(int lessonId, int userId)
    {
        // Fetch the lesson and its related entities in one query
        Lesson? oneLesson = await _context.Lessons
            .Include(l => l.Teacher)
            .Include(l => l.Student)
            .Include(l => l.Instrument)
            .Where(l => l.TeacherId == userId || l.StudentId == userId)
            .FirstOrDefaultAsync(l => l.LessonId == lessonId);

        if (oneLesson == null)
        {
            return null;
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
        User? teacher = await _context.Users.FirstOrDefaultAsync(u => u.UserId == lesson.TeacherId);
        User? student = await _context.Users.FirstOrDefaultAsync(u => u.UserId == lesson.StudentId);
        Instrument? instrument = await _context.Instruments.FirstOrDefaultAsync(i => i.InstrumentId == lesson.InstrumentId);
        if (teacher == null || student == null || instrument == null)
        {
            return null;
        }
        _context.Lessons.Add(lesson);
        int creationResult = await _context.SaveChangesAsync();

        UserDto lessonTeacherDto = new(teacher);
        UserDto lessonStudentDto = new(student);
        InstrumentDto lessonInstrumentDto = new(instrument);
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

    public async Task<List<LessonWithStartEnd>> AllLessonsForUserIdAsync(int userId)
    {
      try
      {
            List<LessonWithStartEnd> lessonsForUser = await _context.Lessons
                .Include(l => l.Instrument)
                .Include(l => l.Teacher)
                .Include(l => l.Student)
                .Where(l => l.TeacherId == userId)
                .Select(lesson => new LessonWithStartEnd(lesson, new UserDto(lesson.Student!), new UserDto(lesson.Teacher!), new InstrumentDto(lesson.Instrument!)))
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
