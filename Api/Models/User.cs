#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    public string Password { get; set;  }
    [NotMapped]
    [Compare("Password")]
    public string Confirm { get; set; }

    //Associations
    public ICollection<RefreshToken> RefreshTokens = new List<RefreshToken>();
}
