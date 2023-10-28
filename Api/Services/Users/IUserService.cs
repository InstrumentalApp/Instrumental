using TeamFive.DataTransfer;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;

namespace TeamFive.Services.Users;
public interface IUserService
{
    Task<UserDto?> CreateStudentAsync(User user);
    Task<UserDto?> CreateTeacherAsync(User user);
    Task<UserDto?> ValidateUserPasswordAsync(LoginUser loginUser);
}
