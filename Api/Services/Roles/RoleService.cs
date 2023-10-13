using Microsoft.AspNetCore.Mvc;
using TeamFive.DataStorage;
using TeamFive.DataTransfer.Tokens;
using TeamFive.DataTransfer.Users;
using TeamFive.Models;
using TeamFive.Services;
using TeamFive.Services.Users;
using TeamFive.Services.Tokens;
using TeamFive.Services.Lessons;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics;
using TeamFive.Enums;

namespace TeamFive.Services.Roles;
public class RoleService : IRoleService
{
    private readonly DBContext _context;

    public RoleService(DBContext context)
    {
        _context = context;
    }


    // Student Role Creation Service
    public async Task<Role> CreateStudentRoleAsync()
    {
      
      // Create a new Role role for the DB
      Role studentRole = new Role()
      {
        // Assign attribue RoleType as Student
        RoleType = RoleType.STUDENT
      };

      // Add to DB
      _context.Roles.Add(studentRole);

      // Saves changes to the DB
      // returns an int for each state entity written to DB
      int creationResult = await _context.SaveChangesAsync();
      
      if(creationResult > 0)
      {
        return studentRole;
      }
      else
      {
        throw new Exception("CreateStudentRoleAsync - Failed to Persist StudentRole object to DB");
      }

    }


    // Teacher Role Creation Service

    public async Task<Role> CreateTeacherRoleAsync()
    {
      // Create a new Role role for the DB
      Role teacherRole = new Role()
      {
        // Assign attribue RoleType as Student
        RoleType = RoleType.TEACHER
      };

      // Add to DB
      _context.Roles.Add(teacherRole);

      // Saves changes to the DB
      // returns an int for each state entity written to DB
      int creationResult = await _context.SaveChangesAsync();
      
      if(creationResult > 0)
      {
        return teacherRole;
      }
      else
      {
        throw new Exception("CreateTeacherRoleAsync - Failed to Persist TeacherRole object to DB");
      }
    }


    // SuperUser Role Creation Service

    public async Task<Role> CreateSuperUserRoleAsync()
    {
      // Create a new Role role for the DB
      Role superUserRole = new Role()
      {
        // Assign attribue RoleType as Student
        RoleType = RoleType.SUPERUSER
      };

      // Add to DB
      _context.Roles.Add(superUserRole);

      // Saves changes to the DB
      // returns an int for each state entity written to DB
      int creationResult = await _context.SaveChangesAsync();
      
      if(creationResult > 0)
      {
        return superUserRole;
      }
      else
      {
        throw new Exception("CreateSuperUserRoleAsync - Failed to Persist SuperUser object to DB");
      }
    }


    public async Task<UserRole> CreateUserRoleAsync(User user, Role role)
    {

      UserRole userRole = new UserRole()
      {
        User = user,
        Role = role
      };

      _context.UserRoles.Add(userRole);

      int creationResult = await _context.SaveChangesAsync();
      
      if(creationResult > 0)
      {
        return userRole;
      }
      else
      {
        throw new Exception("CreateUserRoleAsync - Failed to Persist UserRole object to DB");
      }
    }


}
