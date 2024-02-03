#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Instrumental.Attributes;

namespace Instrumental.DataTransfer;
public class CreateUser
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
}
