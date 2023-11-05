using TeamFive.DataTransfer.Users;
using TeamFive.Models;

namespace TeamFive.DataTransfer.Lessons;

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
