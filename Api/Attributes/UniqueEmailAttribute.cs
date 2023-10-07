#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeamFive.DataStorage;
using MyApp.Models;
using TeamFive.DataTransfer.Tokens;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services;
using TeamFive.Services.Users;

namespace TeamFive.Attributes;

// Below is a check in our database (_context) for any objects holding the entered email in their email field

public class UniqueEmailAttribute : ValidationAttribute
{
  protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
  {

    if(value == null)
    {
      return new ValidationResult("Email is required");
    }

    DBContext _context = (DBContext)validationContext.GetService(typeof(DBContext))!;

    if(_context.Users.Any(e => e.Email == value.ToString()))
    {
      return new ValidationResult("Email already in use");
    }
    else
    {
      return ValidationResult.Success;
    }
  }
}
