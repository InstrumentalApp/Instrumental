using Instrumental.DataTransfer;
using Instrumental.DataTransfer.Users;
using Instrumental.Models;

namespace Instrumental.Services.Users;
public interface IUserService
{
    Task<UserDto?> CreateStudentAsync(User user);
    Task<UserWithRoleDto?> CreateTeacherAsync(CreateTeacher user);
    Task<UserWithRoleDto?> ValidateUserPasswordAsync(LoginUser loginUser);
}
