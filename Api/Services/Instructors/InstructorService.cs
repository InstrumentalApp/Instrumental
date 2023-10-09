using Microsoft.AspNetCore.Mvc;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Tokens;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services;
using TeamFive.Services.Users;
using TeamFive.Services.Tokens;
using TeamFive.Services.Lessons;
using TeamFive.Services.Instructors;
using Microsoft.EntityFrameworkCore;

namespace TeamFive.Services.Instructors;
public class InstructorService : IInstructorService
{
    private readonly DBContext _context;

    public InstructorService(DBContext context)
    {
        _context = context;
    }

    // Get All Lessons
    public async Task<List<Instructor>> AllInstructors()
    {
        List<Instructor> allInstructors = _context.Instructors.ToList();

        await Task.Delay(1);//This is here until we do something "awaitable"

        return allInstructors;
    }


    // Get One Instructor
    public async Task<Instructor?> OneInstructor()
    {
      Instructor? oneInstructor = _context.Instructors.FirstOrDefault();

      await Task.Delay(1);
      
      if(oneInstructor == null)
      {
        return null;
      }

      return oneInstructor;
    }

}
