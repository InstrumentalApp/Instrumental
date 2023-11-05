using TeamFive.DataTransfer.Users;
using TeamFive.Models;

namespace TeamFive.Services.Instructors;
public interface IInstructorService
{
    Task<List<UserDto>> TeachersPerInstrument(int instrumentId);
}
