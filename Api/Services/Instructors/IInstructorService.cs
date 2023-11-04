using TeamFive.Models;

namespace TeamFive.Services.Instructors;
public interface IInstructorService
{
    Task<List<User>> TeachersPerInstrument(int instrumentId);
}
