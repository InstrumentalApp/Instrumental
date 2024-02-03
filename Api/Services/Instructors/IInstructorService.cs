using Instrumental.DataTransfer.Users;
using Instrumental.Models;

namespace Instrumental.Services.Instructors;
public interface IInstructorService
{
    Task<List<UserDto>> TeachersPerInstrument(int instrumentId);
}
