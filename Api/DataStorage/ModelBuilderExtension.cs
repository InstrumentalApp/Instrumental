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
    string _filePath = "seedInstruments.json";
    if (!File.Exists(_filePath))
    {
        throw new FileNotFoundException("seedInstruments.json file not found!");
    }
    PasswordHasher<User> hasher = new();
    string? _jsonData = File.ReadAllText(_filePath);
    List<Instrument> instrumentList = JsonSerializer.Deserialize<List<Instrument>>(_jsonData)!;

    //Create a teacher per instrument in seedInsturments.json
    int x = 0;
    foreach (var i in instrumentList)
    {
        x++;
        Faker<User> faker = new Faker<User>()
            .RuleFor(u=>u.UserId, f => x)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Email, (f, u) => $"{u.FirstName.ToLower()}.{u.LastName.ToLower()}@email.com")
            .RuleFor(u=> u.Password, f=> "99999999");
        User t = faker.Generate();
        t.Password = hasher.HashPassword(t, t.Password);
        Role role = new() { RoleId = x, RoleType = Enums.RoleType.TEACHER };
        UserRole userRole = new(){ UserId = t.UserId, RoleId = role.RoleId};
        Instrument instrument1 = instrumentList[x-1];
        Instrument instrument2 = instrumentList[instrumentList.Count - x];

        List<UserInstrument> userInstrumentsList = new List<UserInstrument>()
        {
            new UserInstrument { UserId = t.UserId, InstrumentId = instrument1.InstrumentId },
            new UserInstrument { UserId = t.UserId, InstrumentId = instrument2.InstrumentId }
        };

        modelBuilder.Entity<User>().HasData(t);
        modelBuilder.Entity<Role>().HasData(role);
        modelBuilder.Entity<UserRole>().HasData(userRole);
        modelBuilder.Entity<Instrument>().HasData(instrument1);
        modelBuilder.Entity<UserInstrument>().HasData(userInstrumentsList);
    }

    //create students
    int y = 50;
    while (y > 0)
    {
        x++;
        Faker<User> faker = new Faker<User>()
            .RuleFor(u=>u.UserId, f => x)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Email, (f, u) => $"{u.FirstName.ToLower()}.{u.LastName.ToLower()}@email.com")
            .RuleFor(u=> u.Password, f=> "99999999");
        User t = faker.Generate();
        t.Password = hasher.HashPassword(t, t.Password);
        Role role = new() { RoleId = x, RoleType = Enums.RoleType.STUDENT };
        UserRole userRole = new(){ UserId = t.UserId, RoleId = role.RoleId};

        modelBuilder.Entity<User>().HasData(t);
        modelBuilder.Entity<Role>().HasData(role);
        modelBuilder.Entity<UserRole>().HasData(userRole);
        y--;
    }

    // Lesson Builder

    int z = 0;
    while(z < 10)
    {
        z++;
        Lesson lesson = new Lesson()
        {
            LessonId  = z, 
            BookingDate = DateTime.Now.AddDays(30), 
            DurationMinutes = 30,  
            TeacherId = z, 
            StudentId = z + 30, 
            InstrumentId = z
        };

        modelBuilder.Entity<Lesson>().HasData(lesson);

        // Test to see if Lessons are inserting
        Console.WriteLine("++++ LessonId " + lesson.LessonId + " ++++++++++++++" );
        Console.WriteLine("++++ BookingDate " + lesson.BookingDate + " ++++++++++++++" );
        Console.WriteLine("++++ DurationMinutes " + lesson.DurationMinutes + " ++++++++++++++" );
        Console.WriteLine("++++ TeacherId " + lesson.TeacherId + " ++++++++++++++" );
        Console.WriteLine("++++ StudentId " + lesson.StudentId + " ++++++++++++++" );
        Console.WriteLine("++++ InstrumentId " + lesson.InstrumentId + " +++++++++++++" );
    }

  }

}
