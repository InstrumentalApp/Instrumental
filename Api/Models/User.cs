#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using MyApp.Models;

namespace TeamFive.Models;
public class User : BaseEntity
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(8)]
    [StrongPassword]
    public string Password { get; set; }

    [NotMapped]
    [Compare("Password")]
    public string Confirm { get; set; }

    //Associations
    public ICollection<RefreshToken> RefreshTokens = new List<RefreshToken>();

    public List<UserLessonBooking> BookedLessons { get; set; } = new List<UserLessonBooking>();


    // Custom validation
    public class StrongPasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).+$";

            if (Regex.IsMatch(value.ToString(), pattern))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Your password must include at least 1 of each of the following: Uppercase letter, lowercase letter, number, and special character");
            }
        }
    }
}