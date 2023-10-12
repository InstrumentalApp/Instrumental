using TeamFive.Models;

namespace TeamFive.DataTransfer.Lessons;

public class LessonDto
{
    public int LessonId { get; set; }
    public DateTime BookingDate { get; set; }
    public int DurationMinutes { get; set; }
    public int TeacherId { get; set; }
    public int StudentId { get; set; }
    public int InstrumentId { get; set; }

    public LessonDto(Lesson lesson)
    {
        LessonId = lesson.LessonId;
        BookingDate = lesson.BookingDate;
        DurationMinutes = lesson.DurationMinutes;
        TeacherId = lesson.TeacherId;
        StudentId = lesson.StudentId;
        InstrumentId = lesson.InstrumentId;
    }
}