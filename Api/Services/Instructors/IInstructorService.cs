using System.Net.Http.Headers;
using TeamFive.DataTransfer.Tokens;
using TeamFive.Models;

namespace TeamFive.Services.Instructors;
public interface IInstructorService
{
    Task<List<Instructor>> AllInstructors();
    Task<Instructor> OneInstructor();
    
}