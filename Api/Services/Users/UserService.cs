using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamFive.DataStorage;
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

    public async Task<UserDto?> CreateAsync(User user)
    {
        //TODO: Add password hashing.
        try
        {
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
            Console.WriteLine("Unkown error in UserService.CreateAsync");
            return null;
        }
    }
}
