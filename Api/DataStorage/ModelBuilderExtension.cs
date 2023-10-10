using Microsoft.EntityFrameworkCore;
using TeamFive.Models;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;
using Bogus;

namespace TeamFive.DataStorage;

public static class ModelBuilderExtensions
{
  public static void Seed(this ModelBuilder modelBuilder)
  {

    // InstrumentJson data is formatted to Instrument Model
    string InstrumentJson =
                @"[
                    {""InstrumentId"": 1, ""Name"": ""Cello"", ""Family"": ""Strings""},
                    {""InstrumentId"": 2, ""Name"": ""Electric Guitar"", ""Family"": ""Strings""},
                    {""InstrumentId"": 3, ""Name"": ""Violin"", ""Family"": ""String""},
                    {""InstrumentId"": 4, ""Name"": ""Flute"", ""Family"": ""Woodwinds""},
                    {""InstrumentId"": 5, ""Name"": ""Clarinet"", ""Family"": ""Woodwinds""},
                    {""InstrumentId"": 6, ""Name"": ""Saxophone"", ""Family"": ""Woodwinds""}
                  ]";


    // JSON data is Deserialized and stored in instrument
    List<Instrument> instrumentList = JsonSerializer.Deserialize<List<Instrument>>(InstrumentJson)!;

    // // modelBuilder.Entity for Instrument is stored for Seed
    // // Seed is called in OnModelCreating in DBContext when builder is initiated in Program
    // modelBuilder.Entity<Instrument>().HasData(instrumentList);

    // Create Users

    PasswordHasher<User> hasher = new();

    List<User> teachers = new()
    {
        new() { FirstName = "Teacher", LastName = "One", Email = "teacher1@email.com", Password = "99999999"},
        new() { FirstName = "Teacher", LastName = "Two", Email = "teacher2@email.com", Password = "99999999" },
        new() { FirstName = "Teacher", LastName = "Three", Email = "teacher3@email.com", Password = "99999999" },
        new() { FirstName = "Teacher", LastName = "Four", Email = "teacher4@email.com", Password = "99999999" },
        new() { FirstName = "Teacher", LastName = "Five", Email = "teacher5@email.com", Password = "99999999" },
        new() { FirstName = "Teacher", LastName = "Six", Email = "teacher6@email.com", Password = "99999999" }
    };

    List<User> students = new()
    {
        new() { FirstName = "Student", LastName = "One", Email = "student1@email.com", Password = "99999999" },
        new() { FirstName = "Student", LastName = "Two", Email = "student2@email.com", Password = "99999999" },
        new() { FirstName = "Student", LastName = "Three", Email = "student3@email.com", Password = "99999999" },
        new() { FirstName = "Student", LastName = "Four", Email = "student4@email.com", Password = "99999999" },
        new() { FirstName = "Student", LastName = "Five", Email = "student5@email.com", Password = "99999999" },
        new() { FirstName = "Student", LastName = "Six", Email = "student6@email.com", Password = "99999999" }
    };

    //Create roles/lessons for users
    int x = 0;
    foreach (var t in teachers)
    {
        x++;
        t.UserId = x;
        Role role = new() { RoleId = x, RoleType = Enums.RoleType.TEACHER };
        UserRole userRole = new(){ UserId = t.UserId, RoleId = role.RoleId};
        Instrument instrument = instrumentList[x-1];
        UserInstrument userInstrument = new() {InstrumentId = instrument.InstrumentId, UserId = t.UserId};

        modelBuilder.Entity<User>().HasData(t);
        modelBuilder.Entity<Role>().HasData(role);
        modelBuilder.Entity<UserRole>().HasData(userRole);
        modelBuilder.Entity<Instrument>().HasData(instrument);
        modelBuilder.Entity<UserInstrument>().HasData(userInstrument);
    }

    x = 0;
    foreach (var s in students)
    {
        x++;
        s.UserId = x;
        Role role = new() { RoleId = x, RoleType = Enums.RoleType.STUDENT };
        UserRole userRole = new(){ UserId = s.UserId, RoleId = role.RoleId};

        modelBuilder.Entity<User>().HasData(s);
        modelBuilder.Entity<Role>().HasData(role);
        modelBuilder.Entity<UserRole>().HasData(userRole);
    }
    //Create Lessons offered by Teachers.

    // // Seed Data for Lessons -------------------------
    // // Two Instructors - Each offers 2 lessons

    // // INSTRUCTOR 1 - LESSON 1
    // Lesson instructor1Lesson1 = new Lesson { Id = 1, LessonName = "Beginner Guitar", LessonTypeId = instrumentList[0].Id, PricePerLesson = 50, Description = "First Lesson: $50 per lesson",  OnlineAvailable = true, InstructorId = instructor1.Id};
    // // INSTRUCTOR 1 - LESSON 2
    // Lesson instructor1Lesson2 = new Lesson { Id = 2, LessonName = "Intermediate Electric Guitar", LessonTypeId = instrumentList[1].Id, PricePerLesson = 100, Description = "Second Lesson: $100 per lesson",  OnlineAvailable = false, InstructorId = instructor1.Id};

    // // INSTRUCTOR 2 - LESSON 1
    // Lesson instructor2Lesson1 = new Lesson { Id = 3, LessonName = "Beginner Violin", LessonTypeId = instrumentList[2].Id, PricePerLesson = 150, Description = "Third Lesson: $150 per lesson",  OnlineAvailable = true, InstructorId = instructor2.Id};
    // // INSTRUCTOR 2 - LESSON 2
    // Lesson instructor2Lesson2 = new Lesson { Id = 4, LessonName = "Expert Flute", LessonTypeId = instrumentList[3].Id, PricePerLesson = 200, Description = "Fourth Lesson: $200 per lesson",  OnlineAvailable = false, InstructorId = instructor2.Id};


    // List<Lesson> LessonSeedList = new List<Lesson>();
    // LessonSeedList.Add(instructor1Lesson1);
    // LessonSeedList.Add(instructor1Lesson2);
    // LessonSeedList.Add(instructor2Lesson1);
    // LessonSeedList.Add(instructor2Lesson2);

    // modelBuilder.Entity<Lesson>().HasData(LessonSeedList);


    // // Seed Data for UserLessonBooking

    // UserLessonBooking UserLessonBooking1 = new UserLessonBooking() {
    //   Id = 1, BookingDate = DateTime.Now, BookingNotes = "Notes for the first Booking", LessonId = instructor1Lesson1.Id, UserId = firstUser.Id
    // };

    // UserLessonBooking UserLessonBooking2 = new UserLessonBooking() {
    //   Id = 2, BookingDate = DateTime.Now, BookingNotes = "Notes for the second Booking", LessonId = instructor2Lesson1.Id, UserId = secondUser.Id
    // };

    // // Bookings List
    // List<UserLessonBooking> UserLessonBookingsList = new List<UserLessonBooking>();
    // UserLessonBookingsList.Add(UserLessonBooking1);
    // UserLessonBookingsList.Add(UserLessonBooking2);

    // // Builder Seed
    // modelBuilder.Entity<UserLessonBooking>().HasData(UserLessonBookingsList);

  }

}
