#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Instrumental.Attributes;

namespace Instrumental.Models;
public class Lesson : BaseEntity
{
    [Key]
    public int LessonId { get; set; }
    [FutureDate(DaysInAdvance = 2)]
    public DateTime BookingDate { get; set; }
    [Range(15, 90, ErrorMessage = "Select a duration between 15 and 90 minutes")]
    public int DurationMinutes { get; set; }

    // Associations
    [Required]
    public int TeacherId { get; set; }
    public User? Teacher { get; set; }

    //Student is nullable
    [Required]
    public int StudentId { get; set; }
    public User? Student { get; set; }

    [Required]
    public int InstrumentId { get; set; }
    public Instrument? Instrument { get; set; }
}
