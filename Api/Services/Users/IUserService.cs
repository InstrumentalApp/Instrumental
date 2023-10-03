using TeamFive.DataTransfer.Users;
using TeamFive.Models;

namespace TeamFive.Services.Users;
public interface IUserService
{
    Task<UserDto?> CreateAsync(User user);
    Task<UserDto?> ValidateUserPasswordAsync(LoginUser loginUser);
}
