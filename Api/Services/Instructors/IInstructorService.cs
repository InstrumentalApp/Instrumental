using System.Net.Http.Headers;
using TeamFive.DataTransfer.Tokens;
using TeamFive.Models;

namespace TeamFive.Services.Instructors;
public interface IInstructorService
{
    // getting list of instructors


//     Task<List<Instructor>> AllInstructors();
//     Task<Instructor> OneInstructor();
    Task<List<User>> TeachersPerInstrument(int instrumentId);
}