#pragma warning disable 8618
using System.ComponentModel.DataAnnotations;

namespace TeamFive.Models;
public class RefreshToken : BaseEntity
{
    [Key]
    public int RefreshTokenId { get; set; }
    public string Value { get; set; }
    public DateTime Expiry { get; set; } = DateTime.UtcNow.AddDays(30);
    public bool IsActive {get;set;} = true;

    //Associations
    public int UserId { get; set; }
    public User? User { get; set; }
}
