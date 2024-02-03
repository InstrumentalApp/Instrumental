#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
using Instrumental.Models;

namespace Instrumental.DataStorage;
public class DBContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Instrument> Instruments { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserInstrument> UserInstruments { get; set; }

    public DBContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
        modelBuilder.Entity<RefreshToken>().HasQueryFilter(u => u.IsActive);

        modelBuilder.Entity<Lesson>()
            .HasOne(l => l.Teacher)
            .WithMany(t => t.TaughtLessons)
            .HasForeignKey(l => l.TeacherId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Lesson>()
            .HasOne(l => l.Student)
            .WithMany(s => s.AttendedLessons)
            .HasForeignKey(l => l.StudentId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Lesson>()
            .HasOne(l => l.Instrument)
            .WithMany(i => i.Lessons)
            .HasForeignKey(l => l.InstrumentId);

        modelBuilder.Entity<UserInstrument>()
            .HasKey(ui => new { ui.UserId, ui.InstrumentId });
    }
}


