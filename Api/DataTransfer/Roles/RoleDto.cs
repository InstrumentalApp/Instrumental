using TeamFive.Enums;
using TeamFive.Models;

namespace TeamFive.DataTransfer.Roles;

public class UserRoleDto
{

  public int RoleId;
  public RoleType RoleType {get;set;}
  public string? Bio {get; set;}
  public virtual ICollection<UserRole> UserRoles {get; set;} = new List<UserRole>();

  public UserRoleDto(Role role)
  {
    if(role.RoleType == 0)
    {
      RoleId = role.RoleId;
      RoleType = role.RoleType;
      Bio = role.Bio;
      UserRoles = role.UserRoles;
    }
  }
}