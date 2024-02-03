using Instrumental.DataTransfer.Users;
using Instrumental.Models;

namespace Instrumental.DataTransfer.Lessons;

public class LessonDto
{
    public int LessonId { get; set; }
    public DateTime BookingDate { get; set; }
    public int DurationMinutes { get; set; }
    public UserDto? Teacher {get; set;}
    public UserDto? Student {get; set;}
    public InstrumentDto? Instrument {get; set;}

    public LessonDto(Lesson lesson, UserDto teacher, UserDto student, InstrumentDto instrument)
    {
        LessonId = lesson.LessonId;
        BookingDate = lesson.BookingDate;
        DurationMinutes = lesson.DurationMinutes;
        Teacher = teacher;
        Student = student;
        Instrument = instrument;
    }
}
