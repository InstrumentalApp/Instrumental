using Instrumental.DataTransfer.Tokens;
using Instrumental.Models;

namespace Instrumental.Services.Tokens;
public interface ITokenService
{
    Task<bool> DeactivateTokensForUserAsync(int userId);
    Task<TokensDto?> CreateTokensDtoAsync(int userId);
    string GenerateAccessToken(User user);
    Task<TokensDto?> DoRefreshActionAsync(RefreshRequestDto refreshRequest);
    int GetIdClaimFromHeaderValue(HttpRequest request);
}
