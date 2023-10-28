using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

    public async Task<UserDto?> CreateTeacherAsync(User user)
    {
        try
        {
            PasswordHasher<User> hasher = new();
            user.Password = hasher.HashPassword(user, user.Password);

            user.Role = new() { RoleType = Enums.RoleType.TEACHER };

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
            Console.WriteLine("Unkown error in UserService.CreateTeacherAsync");
            return null;
        }
    }


    public async Task<UserDto?> ValidateUserPasswordAsync(LoginUser loginUser)
    {
        User? check = await _context.Users.Where(u => u.Email == loginUser.Email).FirstOrDefaultAsync();

        if (check == null) return null;

        PasswordHasher<LoginUser> hasher = new();

        if (hasher.VerifyHashedPassword(loginUser, check.Password, loginUser.Password) == 0) return null;

        return new UserDto(check);
    }

}
