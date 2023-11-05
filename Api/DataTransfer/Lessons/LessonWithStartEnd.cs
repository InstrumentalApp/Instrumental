using TeamFive.DataTransfer.Users;
using TeamFive.Models;

namespace TeamFive.DataTransfer.Lessons;

public class LessonWithStartEnd
{
    public int LessonId { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public UserDto Teacher {get; set;}
    public UserDto Student {get; set;}
    public InstrumentDto Instrument {get; set;}

    public LessonWithStartEnd(Lesson lesson, UserDto teacher, UserDto student, InstrumentDto instrument)
    {
        LessonId = lesson.LessonId;
        Start = lesson.BookingDate;
        End = lesson.BookingDate.AddMinutes(lesson.DurationMinutes);
        Teacher = teacher;
        Student = student;
        Instrument = instrument;
    }
}
