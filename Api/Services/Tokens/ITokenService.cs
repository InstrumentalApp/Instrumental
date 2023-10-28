using System.Net.Http.Headers;
using TeamFive.DataTransfer.Tokens;
using TeamFive.Enums;
using TeamFive.Models;

namespace TeamFive.Services.Tokens;
public interface ITokenService
{
    Task<bool> DeactivateTokensForUserAsync(int userId);
    Task<TokensDto?> CreateTokensDtoAsync(int userId);
    string GenerateAccessToken(User user);
    Task<TokensDto?> DoRefreshActionAsync(RefreshRequestDto refreshRequest);
    int GetIdClaimFromHeaderValue(HttpRequest request);
}
