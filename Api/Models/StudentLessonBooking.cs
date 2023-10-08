#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TeamFive.Models;
public class StudentLessonBooking : BaseEntity
{
    // Date of Booking for Lesson
    [Required]
    public DateTime BookingDate { get; set; }

    // Notes for this individual Booking
    [Required]
    public string BookingNotes { get; set; }
    
    // Navigation Properties
    public int LessonId { get; set; }
    public Lesson? BookingLesson { get; set; }
    
    public int StudentId { get; set; }
    public Student? BookingStudent { get; set; }


}


// Notes
  // Students Book Lessons
    // One Lesson can have many students
    // One Student can have many lessons

  // Instructor Information is linked through Lesson Navigation Properties