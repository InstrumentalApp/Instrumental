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
            .Where(u => u.UserInstruments.Any(i => i.InstrumentId == instrumentId))
            .Where(u => u.Role!.RoleType == RoleType.TEACHER)
            .ToListAsync();

        if(teacherInstrumentList != null) {
            return teacherInstrumentList;
        }
        else
        {
            throw new Exception("Could not find teachers for instrument");
        }
    }
}
