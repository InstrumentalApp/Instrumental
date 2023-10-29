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

    public async Task<LessonDto> CreateLessonAsync(Lesson lesson)
    {
      _context.Lessons.Add(lesson);

      int creationResult = await _context.SaveChangesAsync();

      UserDto? lessonTeacherDto = new UserDto(lesson.Teacher)
      {
        UserId = lesson.Teacher.UserId,
        FirstName = lesson.Teacher.FirstName, 
        LastName = lesson.Teacher.LastName, 
        Email = lesson.Teacher.Email 
      };

      UserDto? lessonStudentDto = new UserDto(lesson.Student)
      {
        UserId = lesson.Student.UserId,
        FirstName = lesson.Student.FirstName, 
        LastName = lesson.Student.LastName, 
        Email = lesson.Student.Email 
      };

      InstrumentDto? lessonInstrumentDto = new InstrumentDto(lesson.Instrument)
      {
        InstrumentId = lesson.InstrumentId,
        Name = lesson.Instrument.Name,
        Family = lesson.Instrument.Family
      };

      LessonDto createdLessonDto = new LessonDto(lesson, lessonTeacherDto, lessonStudentDto, lessonInstrumentDto)
      {
        LessonId = lesson.LessonId,
        BookingDate = lesson.BookingDate,
        DurationMinutes = lesson.DurationMinutes,
        Teacher = lessonTeacherDto,
        Student = lessonStudentDto,
        Instrument = lessonInstrumentDto
      };

      if(creationResult > 0)
      {
        return createdLessonDto;
      }
      else
      {
        throw new Exception("CreateLessonAsync - Failed to Persist lesson object to DB");
      }
    }

    public async Task<List<Lesson>> AllLessonsForUserIdAsync(int userId) 
    {
      List<Lesson> lessonsForUser = await _context.Lessons
        .Where(l => l.TeacherId == userId || l.StudentId == userId)
        .ToListAsync();

      return lessonsForUser;
    }

    public List<LessonDto> LessonsToLessonDtos(List<Lesson> lessons)
    {
        // Making a list of LessonDto objects by mapping each Lesson using .Select()
        List<LessonDto> lessonDtos = lessons
          .Select(lesson => new LessonDto(lesson, new UserDto(lesson.Teacher), new UserDto(lesson.Student), new InstrumentDto(lesson.Instrument)))
          .ToList();

        return lessonDtos;
    }
}
