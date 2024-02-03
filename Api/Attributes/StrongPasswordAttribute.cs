// Custom validation
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Instrumental.Attributes;
public class StrongPasswordAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {

        if (value == null)
        {
            return new ValidationResult("Password is required.");
        }
        string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).+$";

        if (Regex.IsMatch((string)value, pattern))
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult("Your password must include at least 1 of each of the following: Uppercase letter, lowercase letter, number, and special character");
        }
    }
}
