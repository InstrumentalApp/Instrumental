using Instrumental.DataStorage;
using Instrumental.Models;
using Microsoft.EntityFrameworkCore;
using Instrumental.Enums;
using Instrumental.DataTransfer.Users;

namespace Instrumental.Services.Instructors;
public class InstructorService : IInstructorService
{
    private readonly DBContext _context;

    public InstructorService(DBContext context)
    {
        _context = context;
    }

    public async Task<List<UserDto>> TeachersPerInstrument(int instrumentId)
    {
        List<UserDto> teacherInstrumentList = await _context.Users
            .Where(u => u.UserInstruments.Any(i => i.InstrumentId == instrumentId))
            .Where(u => u.Role!.RoleType == RoleType.TEACHER)
            .Select(t=>new UserDto(t))
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
