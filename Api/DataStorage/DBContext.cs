#pragma warning disable CS8618
using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;
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
        modelBuilder.Seed();
    }

}


