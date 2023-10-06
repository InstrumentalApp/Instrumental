#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
using MyApp.Models;
using TeamFive.Models;

namespace TeamFive.DataStorage;
public class DBContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Instrument> Instruments { get; set; }

    public DBContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Global query filter will only return tokens that are active.
        modelBuilder.Entity<RefreshToken>().HasQueryFilter(u => u.IsActive);
    }
}
