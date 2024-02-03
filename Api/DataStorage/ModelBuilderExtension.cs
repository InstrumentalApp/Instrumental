using Microsoft.EntityFrameworkCore;
using Instrumental.Models;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;
using Bogus;

namespace Instrumental.DataStorage;

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

    modelBuilder.Entity<Instrument>().HasData(instrumentList);
    //Create a teacher per instrument in seedInsturments.json
    int numberOfTeachers = 200;
    int numberOfInstruments = instrumentList.Count;

    for (int i = 1; i <= numberOfTeachers; i++)
    {
        int instrumentIndex = (i - 1) % numberOfInstruments;
        Instrument instrument = instrumentList[instrumentIndex];

        Faker<User> faker = new Faker<User>()
            .RuleFor(u => u.UserId, f => i)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Email, (f, u) => $"{u.FirstName.ToLower()}.{u.LastName.ToLower()}@email.com")
            .RuleFor(u => u.Password, f => "99999999");

        User t = faker.Generate();
        t.Password = hasher.HashPassword(t, t.Password);

        Role role = new() { UserId = t.UserId, RoleId = i, RoleType = Enums.RoleType.TEACHER };
        UserInstrument userInstrument = new() { InstrumentId = instrument.InstrumentId, UserId = t.UserId };

        modelBuilder.Entity<User>().HasData(t);
        modelBuilder.Entity<Role>().HasData(role);
        modelBuilder.Entity<UserInstrument>().HasData(userInstrument);
    }

    int x = numberOfTeachers;
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
        Role role = new() {UserId =t.UserId, RoleId = x, RoleType = Enums.RoleType.STUDENT };

        modelBuilder.Entity<User>().HasData(t);
        modelBuilder.Entity<Role>().HasData(role);
        y--;
    }

    User superUser = new()
    {
        UserId = ++x,
        FirstName = "super",
        LastName = "user",
        Email = "superuser@mail.com",
        Password = "3e^8RUBz"
    };

    superUser.Password = hasher.HashPassword(superUser, superUser.Password);
    Role superRole = new() {UserId=superUser.UserId, RoleId = ++x, RoleType = Enums.RoleType.SUPERUSER };
    modelBuilder.Entity<User>().HasData(superUser);
    modelBuilder.Entity<Role>().HasData(superRole);
  }
}
