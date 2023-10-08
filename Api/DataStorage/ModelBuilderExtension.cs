using Microsoft.EntityFrameworkCore;
using TeamFive.Models;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;
using System.Text.Json.Serialization;
// using Bogus;

namespace TeamFive.DataStorage;

public static class ModelBuilderExtensions
{
  public static void Seed(this ModelBuilder modelBuilder)
  {

    // Instrument Data ---------------------------

    // InstrumentJson data is formatted to Instrument Model
    string InstrumentJson = 
                @"[
                    {""Id"": 1, ""InstrumentName"": ""Acoustic Guitar"", ""Category"": ""String Instruments""},
                    {""Id"": 2, ""InstrumentName"": ""Electric Guitar"", ""Category"": ""String Instruments""},
                    {""Id"": 3, ""InstrumentName"": ""Violin"", ""Category"": ""String Instruments""},
                    {""Id"": 4, ""InstrumentName"": ""Flute"", ""Category"": ""Woodwind Instruments""},
                    {""Id"": 5, ""InstrumentName"": ""Clarinet"", ""Category"": ""Woodwind Instruments""},
                    {""Id"": 6, ""InstrumentName"": ""Saxophone"", ""Category"": ""Woodwind Instruments""}
                  ]";


    // JSON data is Deserialized and stored in instrument 
    List<Instrument>? instrumentList = JsonSerializer.Deserialize<List<Instrument>>(InstrumentJson);

    // Console tests
    foreach(Instrument instrument in instrumentList)
    {
      Console.WriteLine($"Instrument: {instrument.InstrumentName}");
      Console.WriteLine($"Category: {instrument.Category}");
    }

    // modelBuilder.Entity for Instrument is stored for Seed
    // Seed is called in OnModelCreating in DBContext when builder is initiated in Program
    modelBuilder.Entity<Instrument>().HasData(instrumentList);



    // Test for User Seed data ---------------------------

    PasswordHasher<User> hasher = new PasswordHasher<User>();
    List<User> UserSeedList = new List<User>();

    User firstUser = new User { Id = 1, FirstName = "John", LastName = "Doe", Email = "a@email.com", Password = "99999999"};
    firstUser.Password = hasher.HashPassword(firstUser, firstUser.Password);

    User secondUser = new User { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "b@email.com", Password = "88888888" };
    secondUser.Password = hasher.HashPassword(secondUser, secondUser.Password);

    User thirdUser = new User { Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "c@email.com", Password = "77777777" };
    thirdUser.Password = hasher.HashPassword(thirdUser, thirdUser.Password);

    User fourthUser = new User { Id = 4, FirstName = "Bob", LastName = "Williams", Email = "d@email.com", Password = "66666666" };
    fourthUser.Password = hasher.HashPassword(fourthUser, fourthUser.Password);

    User fifthUser = new User { Id = 5, FirstName = "Eve", LastName = "Davis", Email = "e@email.com", Password = "55555555" };
    fifthUser.Password = hasher.HashPassword(fifthUser, fifthUser.Password);

    UserSeedList.Add(firstUser);
    UserSeedList.Add(secondUser);
    UserSeedList.Add(thirdUser);
    UserSeedList.Add(fourthUser);
    UserSeedList.Add(fifthUser);

    foreach(User u in UserSeedList)
    {
      Console.WriteLine($"User FirstName: {u.FirstName}");
      Console.WriteLine($"User LastName: {u.LastName}");
      Console.WriteLine($"User Email: {u.Email}");
      Console.WriteLine($"User Password: {u.Password}");
    }

    modelBuilder.Entity<User>().HasData(UserSeedList);



    // SeedData for Students ------------------------

    Student student1 = new Student() { Id = firstUser.Id, FirstName = firstUser.FirstName, LastName = firstUser.LastName, Location = "Online", WillingToTravel = false, Description = "The First Student in Instrumental"};

    Student student2 = new Student() { Id = secondUser.Id, FirstName = secondUser.FirstName, LastName = secondUser.LastName, Location = "Seattle, WA", WillingToTravel = true, Description = "Second Student in DB"};

    // This student is also an instructor
    Student student3 = new Student() { Id = fifthUser.Id, FirstName = fifthUser.FirstName, LastName = fifthUser.LastName, Location = "Hidden Cave, Sacred Mountains", WillingToTravel = false, Description = "When the student is truly ready, the teacher disappears."};    

    // Student List
    List<Student> StudentSeedList = new List<Student>();
    StudentSeedList.Add(student1);
    StudentSeedList.Add(student2);
    StudentSeedList.Add(student3);

    // Builder Seed
    modelBuilder.Entity<Student>().HasData(StudentSeedList);




    // Seed Data for Instructors ---------------------
    Instructor instructor1 = new Instructor() { Id = thirdUser.Id, YearsExperience = 3, Location = "Online", WillingToTravel = false, InstructorAboutMe = "Best Floutist on the web", AcceptingNewStudents = true };

    Instructor instructor2 = new Instructor() { Id = fourthUser.Id, YearsExperience = 10, Location = "Sacremento, CA", WillingToTravel = true, InstructorAboutMe = "Teaching Guitar up and down the Coast.", AcceptingNewStudents = false };

    // This instructor is also a student
    Instructor instructor3 = new Instructor() { Id = fifthUser.Id, YearsExperience = 100, Location = "Hidden Cave, Sacred Mountains", WillingToTravel = false, InstructorAboutMe = "When the student is ready, the teacher will appear.", AcceptingNewStudents = true };

    // Instructor List
    List<Instructor> InstructorSeedList = new List<Instructor>();
    InstructorSeedList.Add(instructor1);
    InstructorSeedList.Add(instructor2);
    InstructorSeedList.Add(instructor3);

    // Builder Seed
    modelBuilder.Entity<Instructor>().HasData(InstructorSeedList);




    // Seed Data for Lessons -------------------------
    // Two Instructors - Each offers 2 lessons

    // INSTRUCTOR 1 - LESSON 1
    Lesson instructor1Lesson1 = new Lesson { Id = 1, LessonName = "Beginner Guitar", LessonTypeId = instrumentList[0].Id, PricePerLesson = 50, Description = "First Lesson: $50 per lesson",  OnlineAvailable = true, InstructorId = instructor1.Id};
    // INSTRUCTOR 1 - LESSON 2
    Lesson instructor1Lesson2 = new Lesson { Id = 2, LessonName = "Intermediate Electric Guitar", LessonTypeId = instrumentList[1].Id, PricePerLesson = 100, Description = "Second Lesson: $100 per lesson",  OnlineAvailable = false, InstructorId = instructor1.Id};

    // INSTRUCTOR 2 - LESSON 1
    Lesson instructor2Lesson1 = new Lesson { Id = 3, LessonName = "Beginner Violin", LessonTypeId = instrumentList[2].Id, PricePerLesson = 150, Description = "Third Lesson: $150 per lesson",  OnlineAvailable = true, InstructorId = instructor2.Id};
    // INSTRUCTOR 2 - LESSON 2
    Lesson instructor2Lesson2 = new Lesson { Id = 4, LessonName = "Expert Flute", LessonTypeId = instrumentList[3].Id, PricePerLesson = 200, Description = "Fourth Lesson: $200 per lesson",  OnlineAvailable = false, InstructorId = instructor2.Id};


    List<Lesson> LessonSeedList = new List<Lesson>();
    LessonSeedList.Add(instructor1Lesson1);
    LessonSeedList.Add(instructor1Lesson2);
    LessonSeedList.Add(instructor2Lesson1);
    LessonSeedList.Add(instructor2Lesson2);

    modelBuilder.Entity<Lesson>().HasData(LessonSeedList);



    // Seed Data for StudentLessonBooking 

    StudentLessonBooking studentLessonBooking1 = new StudentLessonBooking() {
      Id = 1, BookingDate = DateTime.Now, BookingNotes = "Notes for the first Booking", LessonId = instructor1Lesson1.Id, StudentId = student1.Id
    };

    StudentLessonBooking studentLessonBooking2 = new StudentLessonBooking() {
      Id = 2, BookingDate = DateTime.Now, BookingNotes = "Notes for the second Booking", LessonId = instructor2Lesson1.Id, StudentId = student2.Id
    };

    // Bookings List
    List<StudentLessonBooking> studentLessonBookingsList = new List<StudentLessonBooking>();
    studentLessonBookingsList.Add(studentLessonBooking1);
    studentLessonBookingsList.Add(studentLessonBooking2);

    // Builder Seed
    modelBuilder.Entity<StudentLessonBooking>().HasData(studentLessonBookingsList);

  }

}