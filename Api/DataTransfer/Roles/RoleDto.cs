using TeamFive.Enums;
using TeamFive.Models;

namespace TeamFive.DataTransfer.Roles;

public class RoleDto
{

  public int RoleId;
  public RoleType RoleType {get;set;} = RoleType.STUDENT;
  public string? Bio {get; set;}
  public virtual ICollection<UserRole> UserRoles {get; set;} = new List<UserRole>();

  public RoleDto(Role role)
  {
    RoleId = role.RoleId;
    RoleType = role.RoleType;
    Bio = role.Bio;
    UserRoles = role.UserRoles;
  }
}