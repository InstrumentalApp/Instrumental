#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;

namespace TeamFive.Models;
public class Instructor : BaseEntity
{
    // Years experience as a teacher, any instrument
    [Required]
    public int YearsExperience { get; set; }

    // Location of the current instrutor offering lessons, to match with students
    [Required]
    public string Location { get; set;  }

    // Bool for whether instructor will travel to students home, or only accepts drop-ins
    [Required]
    public bool WillingToTravel { get; set; }

    // A description of the instructor for their profile. An "About Me" section.
    [Required]
    public string InstructorAboutMe { get; set; }
    // A bool for having your teaching profile show on the page if you are accepting students
    
    [Required]
    public bool AcceptingNewStudents { get; set; } = true;

    // A list of instruments you are offering lessons in
    [Required]
    public List<Lesson> LessonCatalogue { get; set; }
}
