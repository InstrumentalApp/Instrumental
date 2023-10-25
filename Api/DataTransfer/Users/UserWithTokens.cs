using TeamFive.DataTransfer.Tokens;
using TeamFive.Models;

namespace TeamFive.DataTransfer.Users;
public class UserWithTokens
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string RefreshToken { get; set; }
    public string AccessToken { get; set; }

    public UserWithTokens(UserDto user, TokensDto tokens)
    {
        UserId = user.UserId;
        FirstName = user.FirstName;
        LastName = user.LastName;
        Email = user.Email;
        RefreshToken = tokens.RefreshToken;
        AccessToken = tokens.AccessToken;
    }


}
