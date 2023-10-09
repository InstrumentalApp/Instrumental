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
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<UserLessonBooking> UserLessonBookings { get; set; }


    public DBContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();

        modelBuilder.Entity<UserLessonBooking>()
        .HasKey(sl => new { sl.UserId, sl.LessonId });

        modelBuilder.Entity<UserLessonBooking>()
        .HasOne(sl => sl.BookingUser)
        .WithMany(s => s.BookedLessons)
        .HasForeignKey(sl => sl.UserId);

        modelBuilder.Entity<UserLessonBooking>()
        .HasOne(sl => sl.BookingLesson)
        .WithMany(l => l.BookedUser)
        .HasForeignKey(sl => sl.LessonId);

        modelBuilder.Entity<RefreshToken>().HasQueryFilter(u => u.IsActive);
    }
}


