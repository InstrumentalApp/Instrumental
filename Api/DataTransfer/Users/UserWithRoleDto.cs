using TeamFive.Models;

namespace TeamFive.DataTransfer.Users;
public class UserWithRoleDto
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Role Role { get; set; }

    public UserWithRoleDto(User user)
    {
        UserId = user.UserId;
        FirstName = user.FirstName;
        LastName = user.LastName;
        Email = user.Email;
        Role = user.Role!;
    }


}
