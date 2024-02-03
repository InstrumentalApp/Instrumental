using Instrumental.DataTransfer.Users;
using Instrumental.Models;

namespace Instrumental.DataTransfer.Lessons;

public class LessonNoUsers
{
    public int LessonId { get; set; }
    public DateTime BookingDate { get; set; }
    public int DurationMinutes { get; set; }

    public LessonNoUsers(Lesson lesson)
    {
        LessonId = lesson.LessonId;
        BookingDate = lesson.BookingDate;
        DurationMinutes = lesson.DurationMinutes;
    }
}
