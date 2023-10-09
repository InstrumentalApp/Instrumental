﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamFive.DataStorage;

#nullable disable

namespace TeamFive.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20231006055132_SecondMigration")]
    partial class SecondMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyApp.Models.RefreshToken", b =>
                {
                    b.Property<int>("RefreshTokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expiry")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RefreshTokenId");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("TeamFive.Models.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("InstrumentName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Instruments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "String Instruments",
                            CreatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4562),
                            InstrumentName = "Acoustic Guitar",
                            UpdatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4565)
                        },
                        new
                        {
                            Id = 2,
                            Category = "Woodwind Instruments",
                            CreatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4718),
                            InstrumentName = "Flute",
                            UpdatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4719)
                        });
                });

            modelBuilder.Entity("TeamFive.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 760, DateTimeKind.Utc).AddTicks(3073),
                            Email = "a@email.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "AQAAAAIAAYagAAAAEAgGpUHvu7aI9ipHU0CW6SpG3077I4CZIFe9BOfAyn4neJ1iOfhvJ2fiRuey+WTWFg==",
                            UpdatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 760, DateTimeKind.Utc).AddTicks(3076)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 832, DateTimeKind.Utc).AddTicks(9323),
                            Email = "b@email.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Password = "AQAAAAIAAYagAAAAEO0f1l4t5IjbAVRfwYW1z1NanF7mjPAHiQ/vS6cHPb6yX/Dr9aS0fBbuhj3BClvCjA==",
                            UpdatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 832, DateTimeKind.Utc).AddTicks(9327)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 905, DateTimeKind.Utc).AddTicks(5649),
                            Email = "c@email.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Password = "AQAAAAIAAYagAAAAEJwuTdib122kdIYFvHCZG31Q4rzZcpdFcVREdJ8VZmJgrAnedGrgkFYROEQETl0Fyw==",
                            UpdatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 905, DateTimeKind.Utc).AddTicks(5653)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 978, DateTimeKind.Utc).AddTicks(2706),
                            Email = "d@email.com",
                            FirstName = "Bob",
                            LastName = "Williams",
                            Password = "AQAAAAIAAYagAAAAEAJVExwPc2dqmBdYW3jXHWIKbDuQBW4kbGuJhH9A3etekHkOYG+6t8rk7CVfoJrqnA==",
                            UpdatedAt = new DateTime(2023, 10, 6, 5, 51, 31, 978, DateTimeKind.Utc).AddTicks(2710)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 10, 6, 5, 51, 32, 52, DateTimeKind.Utc).AddTicks(1348),
                            Email = "e@email.com",
                            FirstName = "Eve",
                            LastName = "Davis",
                            Password = "AQAAAAIAAYagAAAAEGQBxSF1ZPNY+UW2ByIL02OTcC+S858y5Nf2fsNQ0p37evB7o7A4vvIWbTdyOvL3PA==",
                            UpdatedAt = new DateTime(2023, 10, 6, 5, 51, 32, 52, DateTimeKind.Utc).AddTicks(1352)
                        });
                });

            modelBuilder.Entity("MyApp.Models.RefreshToken", b =>
                {
                    b.HasOne("TeamFive.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}