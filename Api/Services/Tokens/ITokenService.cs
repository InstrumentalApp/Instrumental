using System.Net.Http.Headers;
using TeamFive.DataTransfer.Tokens;
using TeamFive.Models;

namespace TeamFive.Services;
public interface ITokenService
{
    Task<bool> DeactivateTokensForUserAsync(int userId);
    Task<TokensDto?> CreateTokensDtoAsync(int userId);
    string GenerateAccessToken(int id);
    //TODO: Task<int> ValidateRefreshTokenAsync(string rft);
    Task<TokensDto?> DoRefreshActionAsync(RefreshRequestDto refreshRequest);
    //TODO: int GetClaimFromHeaderValue(HttpRequest request);
}
