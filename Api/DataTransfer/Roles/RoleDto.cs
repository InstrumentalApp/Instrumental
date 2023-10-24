using TeamFive.Enums;
using TeamFive.Models;

namespace TeamFive.DataTransfer.Roles;

public class RoleDto
{

  public RoleType RoleType {get;set;}
  public string? Bio {get; set;}

  public RoleDto(Role role)
  {
    RoleType = role.RoleType;
    Bio = role.Bio;
  }
}
