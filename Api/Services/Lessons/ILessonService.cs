using System.Net.Http.Headers;
using TeamFive.DataTransfer.Lessons;
using TeamFive.DataTransfer.Tokens;
using TeamFive.Models;

namespace TeamFive.Services.Lessons;
public interface ILessonService
{
    Task<List<Lesson>> AllLessons();
    Task<LessonDto?> OneLessonAsync(int lessonId);
    Task<int> CreateLessonAsync(Lesson lesson);
}
