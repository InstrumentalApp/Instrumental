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
    public DbSet<Student> Students { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<StudentLessonBooking> StudentLessonBookings { get; set; }


    public DBContext(DbContextOptions options) : base(options) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();

        modelBuilder.Entity<StudentLessonBooking>()
        .HasKey(sl => new { sl.StudentId, sl.LessonId });

        modelBuilder.Entity<StudentLessonBooking>()
        .HasOne(sl => sl.BookingStudent)
        .WithMany(s => s.BookedLessons)
        .HasForeignKey(sl => sl.StudentId);

        modelBuilder.Entity<StudentLessonBooking>()
        .HasOne(sl => sl.BookingLesson)
        .WithMany(l => l.BookedStudents)
        .HasForeignKey(sl => sl.LessonId);

    }

}


