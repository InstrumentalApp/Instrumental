#pragma warning disable 8618
using TeamFive.Models;

namespace MyApp.Models;
public class RefreshToken : BaseEntity
{
    public string Value { get; set; }
    public DateTime Expiry { get; set; } = DateTime.UtcNow.AddDays(30);
    public bool IsActive {get;set;} = true;

    //Associations
    public int UserId { get; set; }
    public User? User { get; set; }
}
