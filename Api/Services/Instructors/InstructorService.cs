using TeamFive.DataStorage;
using TeamFive.Models;
using Microsoft.EntityFrameworkCore;
using TeamFive.Enums;

namespace TeamFive.Services.Instructors;
public class InstructorService : IInstructorService
{
    private readonly DBContext _context;

    public InstructorService(DBContext context)
    {
        _context = context;
    }

    public async Task<List<User>> TeachersPerInstrument(int instrumentId)
    {
        List<User> teacherInstrumentList = await _context.Users
            .Where(u => u.UserInstruments.Any(i => i.InstrumentId == instrumentId))  // Filter by the instrument
            .Where(u => u.UserRoles.Any(r => r.Role.RoleType == RoleType.TEACHER))  // Filter by the role
            .ToListAsync();
            // .ThenInclude

        if(teacherInstrumentList != null) {
            return teacherInstrumentList;
        }
        else
        {
            throw new Exception("Could not find teachers for instrument");
        }
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
