using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Tokens;
using TeamFive.Models;

namespace TeamFive.Services.Tokens;
public class TokenService : ITokenService
{
    private readonly DBContext _context;
    private readonly IConfiguration _config;

    public TokenService(DBContext context, IConfiguration config)
    {
        _context = context;
        _config = config;
    }

    static string GenerateRefreshToken()
    {
        using var rng = RandomNumberGenerator.Create();
        byte[] byteToken = new byte[32]; //128 bit
        rng.GetBytes(byteToken);
        return Convert.ToBase64String(byteToken);
    }

    public string GenerateAccessToken(int id)
    {
        string? encKey = _config["Jwt:SecretKey"];
        if (string.IsNullOrEmpty(encKey) || encKey.Length < 32)
        {
            throw new InvalidOperationException("Jwt Secret is Invalid or Missing.");
        }

        byte[] key = Encoding.ASCII.GetBytes(encKey);

        JwtSecurityTokenHandler handler = new();
        SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new(ClaimTypes.Name, Convert.ToString(id))
            }),
            Audience = _config["Jwt:Audience"],
            Issuer = _config["Jwt:Issuer"],
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
            SecurityAlgorithms.HmacSha256Signature)
        };
        SecurityToken token = handler.CreateToken(tokenDescriptor);
        return handler.WriteToken(token);
    }

    public async Task<TokensDto?> CreateTokensDtoAsync(int userId)
    {
        RefreshToken rft = new()
        {
            Value = GenerateRefreshToken(),
            UserId = userId
        };
        try
        {
            string jwt = GenerateAccessToken(userId);
            await DeactivateTokensForUserAsync(userId);
            await _context.RefreshTokens.AddAsync(rft);
            await _context.SaveChangesAsync();
            return new TokensDto(rft, jwt);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
        catch (DbUpdateException ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
        catch
        {
            Console.WriteLine("Unknown error in CreateTokensDtoAsync");
            return null;
        }
    }

    public async Task<bool> DeactivateTokensForUserAsync(int id)
    {
        var tokens = await _context.RefreshTokens
                            .Where(t => t.UserId == id)
                            .ToListAsync();
        try
        {
            foreach (var t in tokens)
            {
                t.IsActive = false;
                t.UpdatedAt = DateTime.UtcNow;
            }
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<TokensDto?> DoRefreshActionAsync(RefreshRequestDto refreshRequest)
    {
        RefreshToken? check = await _context.RefreshTokens
            .Include(t=>t.User)
            .Where(t => t.Value == refreshRequest.Token)
            .FirstOrDefaultAsync();
        if (check == null || check.User == null)
        {
            return null;
        }
        TokensDto? tokensDto = await CreateTokensDtoAsync(check.User.UserId);
        if (tokensDto == null)
        {
            return null;
        }
        return tokensDto;
    }
}
