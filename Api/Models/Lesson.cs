#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TeamFive.Models;
public class Lesson : BaseEntity
{
    [Key]
    public int LessonId { get; set; }
    public DateTime BookingDate { get; set; }
    public int DurationMinutes { get; set; } = 30;

    // Associations
    public int TeacherId { get; set; }
    public User? Teacher { get; set; }

    //Student is nullable
    public int StudentId { get; set; }
    public User? Student { get; set; }

    public int InstrumentId { get; set; }
    public Instrument? Instrument { get; set; }
}
