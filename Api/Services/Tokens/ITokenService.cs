using System.Net.Http.Headers;
using TeamFive.DataTransfer.Tokens;
using TeamFive.Models;

namespace TeamFive.Services.Tokens;
public interface ITokenService
{
    Task<bool> DeactivateTokensForUserAsync(int userId);
    Task<TokensDto?> CreateTokensDtoAsync(int userId);
    string GenerateAccessToken(int id);
    //TODO: Task<int> ValidateRefreshTokenAsync(string rft);
    //TODO: Task<TokensDto?> DoRefreshActionAsync(string rft);
    //TODO: int GetClaimFromHeaderValue(HttpRequest request);
}