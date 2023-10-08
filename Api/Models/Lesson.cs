#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TeamFive.Models;
public class Lesson : BaseEntity
{
    // Lesson Name - "Intermediate Guitar"
    [Required]
    public string LessonName { get; set; }
    // Instrument Id
    [Required]
    public int LessonTypeId { get; set; }
    // Instrument Reference
    [Required]
    public Instrument LessonType { get; set; }
    // Price Per Individual Lesson
    [Required]
    public int PricePerLesson { get; set; }
    // Description of Lesson - Jazz/Personal/Fundamentals/etc.
    [Required]
    public string Description { get; set; }
    // Lessons available online
    [Required]
    public bool OnlineAvailable { get; set; }

    // Navigation Properties
    public int InstructorId { get; set; }
    public Instructor? LessonInstructor { get; set; }

    public List<StudentLessonBooking> BookedStudents { get;set; } = new List<StudentLessonBooking>();
}


// NOTES

// Lessons contain
  // Instrument Type - Selectable on Creation from DBContext
  // Price Per Lesson - Price Range (Cannot be null/negative)
  // Description - Custom Notes
  // OnlineAvailable - Online Option

// Lessons are created by teachers
// Lessons are general
// Lessons are selected by students, with specific request dates
  // Individual Dates are set in Bookings