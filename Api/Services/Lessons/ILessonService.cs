using System.Net.Http.Headers;
using TeamFive.DataTransfer.Tokens;
using TeamFive.Models;

namespace TeamFive.Services.Lessons;
public interface ILessonService
{
    Task<List<Lesson>> AllLessons();
    Task<Lesson?> OneLesson();
    
}