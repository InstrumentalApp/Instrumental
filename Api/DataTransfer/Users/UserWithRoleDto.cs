using Instrumental.DataTransfer.Roles;
using Instrumental.Models;

namespace Instrumental.DataTransfer.Users;
public class UserWithRoleDto
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public RoleDto Role { get; set; }

    public UserWithRoleDto(User user)
    {
        UserId = user.UserId;
        FirstName = user.FirstName;
        LastName = user.LastName;
        Email = user.Email;
        Role = new(user.Role!);
    }
}
