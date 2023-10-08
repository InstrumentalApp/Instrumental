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

    // InstrumentJson data is formatted to Instrument Model
    string InstrumentJson = 
                @"[
                    {""Id"": 1, ""InstrumentName"": ""Acoustic Guitar"", ""Category"": ""String Instruments""},
                    {""Id"": 2, ""InstrumentName"": ""Electric Guitar"", ""Category"": ""String Instruments""},
                    {""Id"": 3, ""InstrumentName"": ""Violin"", ""Category"": ""String Instruments""},
                    {""Id"": 4, ""InstrumentName"": ""Flute"", ""Category"": ""Woodwind Instruments""}
                    {""Id"": 5, ""InstrumentName"": ""Clarinet"", ""Category"": ""Woodwind Instruments""}
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




    // Test for User Seed data

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

  }
}