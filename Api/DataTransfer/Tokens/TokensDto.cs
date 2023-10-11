#pragma warning disable 8618
using TeamFive.Models;

namespace TeamFive.DataTransfer.Tokens;
public class TokensDto
{
    public string RefreshToken { get; set; }
    public string AccessToken { get; set; }

    public TokensDto(RefreshToken rft, string jwt)
    {
        RefreshToken = rft.Value;
        AccessToken = jwt;
    }
}