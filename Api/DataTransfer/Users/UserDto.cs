using TeamFive.Models;

namespace TeamFive.DataTransfer.Users;
public class UserDto
{
    public int Id;
    public string FirstName;
    public string LastName;
    public string Email;

    public UserDto(User user)
    {
        Id = user.Id;
        FirstName = user.FirstName;
        LastName = user.LastName;
        Email = user.Email;
    }
}
