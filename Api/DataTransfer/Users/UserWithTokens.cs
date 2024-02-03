using Instrumental.DataTransfer.Tokens;

namespace Instrumental.DataTransfer.Users;
public class UserWithTokens
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string RefreshToken { get; set; }
    public string AccessToken { get; set; }
    public string Role { get; set; }

    public UserWithTokens(UserWithRoleDto user, TokensDto tokens)
    {
        UserId = user.UserId;
        FirstName = user.FirstName;
        LastName = user.LastName;
        Email = user.Email;
        RefreshToken = tokens.RefreshToken;
        AccessToken = tokens.AccessToken;
        Role = user.Role.RoleType.ToString();
    }


}
