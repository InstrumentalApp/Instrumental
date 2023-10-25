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
        Instrument instrument = instrumentList[x-1];
        UserInstrument userInstrument = new() {InstrumentId = instrument.InstrumentId, UserId = t.UserId};

        modelBuilder.Entity<User>().HasData(t);
        modelBuilder.Entity<Role>().HasData(role);
        modelBuilder.Entity<UserRole>().HasData(userRole);
        modelBuilder.Entity<Instrument>().HasData(instrument);
        modelBuilder.Entity<UserInstrument>().HasData(userInstrument);
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

    User superUser = new()
    {
        UserId = ++x,
        FirstName = "super",
        LastName = "user",
        Email = "superuser@mail.com",
        Password = "99999999",
    };

    superUser.Password = hasher.HashPassword(superUser, superUser.Password);
    Role superRole = new() { RoleId = ++x, RoleType = Enums.RoleType.SUPERUSER };
    UserRole superUserRole = new(){ UserId = superUser.UserId, RoleId = superRole.RoleId};
    modelBuilder.Entity<User>().HasData(superUser);
    modelBuilder.Entity<Role>().HasData(superRole);
    modelBuilder.Entity<UserRole>().HasData(superUserRole);
  }
}
