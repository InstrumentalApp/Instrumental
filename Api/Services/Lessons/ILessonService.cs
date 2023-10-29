using System.Net.Http.Headers;
using TeamFive.DataTransfer.Lessons;
using TeamFive.DataTransfer.Tokens;
using TeamFive.Models;

namespace TeamFive.Services.Lessons;
public interface ILessonService
{
    Task<List<Lesson>> AllLessons();
    Task<LessonDto?> OneLessonAsync(int lessonId);
    Task<LessonDto?> CreateLessonAsync(Lesson lesson);
    Task<List<Lesson>> AllLessonsForUserIdAsync(int userId);
    List<LessonDto> LessonsToLessonDtos(List<Lesson> lessons);
}
