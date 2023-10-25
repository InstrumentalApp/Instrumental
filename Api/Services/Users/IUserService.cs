using TeamFive.DataTransfer;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;

namespace TeamFive.Services.Users;
public interface IUserService
{
    Task<UserDto?> CreateStudentAsync(CreateUser user);
    Task<UserDto?> CreateTeacherAsync(CreateUser user);
    Task<UserDto?> ValidateUserPasswordAsync(LoginUser loginUser);
}
