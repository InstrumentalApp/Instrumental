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

namespace TeamFive.Services.Roles;
public interface IRoleService
{
  Task<Role> CreateStudentRoleAsync();
  Task<Role> CreateTeacherRoleAsync();
  Task<Role> CreateSuperUserRoleAsync();
  Task<UserRole> CreateUserRoleAsync(User user, Role role);
}