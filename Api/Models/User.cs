#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;

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
    public string Password { get; set;  }
    [Compare("Password")]
    public string Confirm { get; set; }
}
