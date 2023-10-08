#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;

namespace TeamFive.Models;
public class Student : BaseEntity
{
    // A First name field. Student's may not want to display full name on public profile.
    [Required]
    public string FirstName { get; set; }

    // This will be auto-populated by UserInfo
    [Required]
    public string LastName { get; set; }

    // Location is address or hometown. Can be private but is used to find local teachers.
    [Required]
    public string Location { get; set; }

    // Willing to Travel in regards to attending lessons outside of their home
    [Required]
    public bool WillingToTravel { get; set; }

    // Description is personal summary or description of the student. An "About Me" for their profile.
    [Required]
    public string Description { get; set; }

    public List<StudentLessonBooking> BookedLessons { get; set; } = new List<StudentLessonBooking>();

}
