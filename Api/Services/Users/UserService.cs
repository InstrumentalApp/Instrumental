using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamFive.DataStorage;
using TeamFive.DataTransfer;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services.Roles;

namespace TeamFive.Services.Users;
public class UserService : IUserService
{
    private readonly DBContext _context;
    private readonly IRoleService _roleService;

    public UserService(DBContext context, IRoleService roleService)
    {
        _context = context;
        _roleService = roleService;
    }


    public async Task<UserDto?> CreateStudentAsync(CreateUser user)
    {
        User newUser = new()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                Confirm = user.Confirm
            };
        try
        {
            PasswordHasher<User> hasher = new();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);

            await _context.Users.AddAsync(newUser);

            // Define new role from Role Service, saves to DB
            Role studentRole = await _roleService.CreateStudentRoleAsync();

            // Creates association, saves to DB
            await _roleService.CreateUserRoleAsync(newUser, studentRole);

            await _context.SaveChangesAsync();
            return new UserDto(newUser);
        }
        catch(DbUpdateException ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
        catch
        {
            Console.WriteLine("Unkown error in UserService.CreateAsync");
            return null;
        }
    }

    // Create Teacher Method
    // Creates and associates Teacher and Student Roles to UserRoles

    public async Task<UserDto?> CreateTeacherAsync(CreateUser user)
    {
        try
        {
            User newUser = new()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                Confirm = user.Confirm
            };
            PasswordHasher<User> hasher = new();
            user.Password = hasher.HashPassword(newUser, newUser.Password);

            await _context.Users.AddAsync(newUser);

            // Define student/teacher roles from Role Service, saves to DB
            Role studentRole = await _roleService.CreateStudentRoleAsync();
            Role teacherRole = await _roleService.CreateTeacherRoleAsync();

            // Creates association, saves to DB
            await _roleService.CreateUserRoleAsync(newUser, studentRole);
            await _roleService.CreateUserRoleAsync(newUser, teacherRole);

            await _context.SaveChangesAsync();
            return new UserDto(newUser);
        }
        catch(DbUpdateException ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
        catch
        {
            Console.WriteLine("Unkown error in UserService.CreateAsync");
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
