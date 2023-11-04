using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TeamFive.DataStorage;
using TeamFive.DataTransfer;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;

namespace TeamFive.Services.Users;
public class UserService : IUserService
{
    private readonly DBContext _context;

    public UserService(DBContext context)
    {
        _context = context;
    }

    public async Task<UserDto?> CreateStudentAsync(User user)
    {
        try
        {
            PasswordHasher<User> hasher = new();
            user.Password = hasher.HashPassword(user, user.Password);

            user.Role = new();

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return new UserDto(user);
        }
        catch(DbUpdateException ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
        catch
        {
            Console.WriteLine("Unkown error in UserService.CreateStudentAsync");
            return null;
        }
    }

    public async Task<UserWithRoleDto?> CreateTeacherAsync(CreateTeacher input)
    {
        User user = new()
        {
            FirstName = input.FirstName,
            LastName = input.LastName,
            Email = input.Email,
            Password = input.Password,
            Confirm = input.Confirm,
        };
        try
        {
            PasswordHasher<User> hasher = new();
            user.Password = hasher.HashPassword(user, user.Password);

            user.Role = new() { RoleType = Enums.RoleType.TEACHER };

            user.UserInstruments.Add(new() { UserId = user.UserId, InstrumentId = input.InstrumentId });

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return new UserWithRoleDto(user);
        }
        catch(DbUpdateException ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
        catch
        {
            Console.WriteLine("Unkown error in UserService.CreateTeacherAsync");
            return null;
        }
    }


    public async Task<UserWithRoleDto?> ValidateUserPasswordAsync(LoginUser loginUser)
    {
        User? check = await _context.Users
            .Include(u=>u.Role)
            .Where(u => u.Email == loginUser.Email)
            .FirstOrDefaultAsync();

        if (check == null) return null;

        PasswordHasher<LoginUser> hasher = new();

        if (hasher.VerifyHashedPassword(loginUser, check.Password, loginUser.Password) == 0) return null;

        return new UserWithRoleDto(check);
    }
}
