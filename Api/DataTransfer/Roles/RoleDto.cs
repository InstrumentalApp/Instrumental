using Instrumental.Enums;
using Instrumental.Models;

namespace Instrumental.DataTransfer.Roles;

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
