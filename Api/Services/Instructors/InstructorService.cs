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

    // // Get All Lessons
    // public async Task<List<Instructor>> AllInstructors()
    // {
    //     List<Instructor> allInstructors = await _context.Instructors.ToListAsync();

    //     return allInstructors;
    // }


    // // Get One Instructor
    // public async Task<Instructor?> OneInstructor()
    // {
    //   Instructor? oneInstructor = await _context.Instructors.FirstOrDefaultAsync();
      
    //   if(oneInstructor == null)
    //   {
    //     return null;
    //   }

    //   return oneInstructor;
    // }

}
