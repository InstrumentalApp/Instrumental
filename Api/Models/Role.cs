using System.ComponentModel.DataAnnotations;
using TeamFive.Enums;

namespace TeamFive.Models;
public class Role : BaseEntity
{
    [Key]
    public int RoleId { get; set; }
    public RoleType RoleType { get; set; } = RoleType.STUDENT;

    public string? Bio { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
}
