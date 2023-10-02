#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
using TeamFive.Models;

namespace TeamFive.DataStorage;
public class DBContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DBContext(DbContextOptions options) : base(options) { }
}
