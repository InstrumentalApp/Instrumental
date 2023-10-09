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
    [Migration("20231008052344_FourthMigration")]
    partial class FourthMigration
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expiry")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("TeamFive.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("AcceptingNewStudents")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("InstructorAboutMe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("WillingToTravel")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("YearsExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
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

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Instruments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "String Instruments",
                            CreatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8300),
                            InstrumentName = "Acoustic Guitar",
                            UpdatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8303)
                        },
                        new
                        {
                            Id = 2,
                            Category = "String Instruments",
                            CreatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8471),
                            InstrumentName = "Electric Guitar",
                            UpdatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8472)
                        },
                        new
                        {
                            Id = 3,
                            Category = "String Instruments",
                            CreatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8489),
                            InstrumentName = "Violin",
                            UpdatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8490)
                        },
                        new
                        {
                            Id = 4,
                            Category = "Woodwind Instruments",
                            CreatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8505),
                            InstrumentName = "Flute",
                            UpdatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8505)
                        },
                        new
                        {
                            Id = 5,
                            Category = "Woodwind Instruments",
                            CreatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8535),
                            InstrumentName = "Clarinet",
                            UpdatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8535)
                        },
                        new
                        {
                            Id = 6,
                            Category = "Woodwind Instruments",
                            CreatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8558),
                            InstrumentName = "Saxophone",
                            UpdatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8559)
                        });
                });

            modelBuilder.Entity("TeamFive.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("LessonTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("OnlineAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PricePerLesson")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("LessonTypeId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("TeamFive.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("WillingToTravel")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TeamFive.Models.StudentLessonBooking", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("BookingNotes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("LessonNameId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("StudentId", "LessonId");

                    b.HasIndex("LessonId");

                    b.HasIndex("LessonNameId");

                    b.ToTable("StudentLessonBookings");
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
                            CreatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 523, DateTimeKind.Utc).AddTicks(4354),
                            Email = "a@email.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "AQAAAAIAAYagAAAAEN7z2sctfRuCAw4m1I7/fP9ERHkzuNcV7d8GiTE2Ay3CfckPcCKoxdd7PdkD0Ug4NQ==",
                            UpdatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 523, DateTimeKind.Utc).AddTicks(4358)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 606, DateTimeKind.Utc).AddTicks(3150),
                            Email = "b@email.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Password = "AQAAAAIAAYagAAAAEI1vVXqM9d0qFtWbpXHaXppOngaUZoWK/HRM+mClzbUh6qgHyHDtXkTfVP3m1cWrMw==",
                            UpdatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 606, DateTimeKind.Utc).AddTicks(3156)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 695, DateTimeKind.Utc).AddTicks(2489),
                            Email = "c@email.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Password = "AQAAAAIAAYagAAAAENjOzBToqwVTN3LrFE0X1L1TvsSqhPCOgKuzJ9f0AcDa5Mqau5aBzRlUika2l0dx/w==",
                            UpdatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 695, DateTimeKind.Utc).AddTicks(2493)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 809, DateTimeKind.Utc).AddTicks(6805),
                            Email = "d@email.com",
                            FirstName = "Bob",
                            LastName = "Williams",
                            Password = "AQAAAAIAAYagAAAAEKMroxTLyagF3HcPCXsvRUyCn250TDHc3h5s4sP1BZFrLu2Kkn1RefhLjUdBgCRieg==",
                            UpdatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 809, DateTimeKind.Utc).AddTicks(6810)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 907, DateTimeKind.Utc).AddTicks(7860),
                            Email = "e@email.com",
                            FirstName = "Eve",
                            LastName = "Davis",
                            Password = "AQAAAAIAAYagAAAAEAVsl36VbJs7TlRmJ0U/WGKI0u2suAFTrkiawmba87MG9eD2iX+CfBIpX4KEW9E/cQ==",
                            UpdatedAt = new DateTime(2023, 10, 8, 5, 23, 43, 907, DateTimeKind.Utc).AddTicks(7864)
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

            modelBuilder.Entity("TeamFive.Models.Instrument", b =>
                {
                    b.HasOne("TeamFive.Models.Student", null)
                        .WithMany("SeekingLessons")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("TeamFive.Models.Lesson", b =>
                {
                    b.HasOne("TeamFive.Models.Instructor", "LessonInstructor")
                        .WithMany("LessonCatalogue")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamFive.Models.Instrument", "LessonType")
                        .WithMany()
                        .HasForeignKey("LessonTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LessonInstructor");

                    b.Navigation("LessonType");
                });

            modelBuilder.Entity("TeamFive.Models.StudentLessonBooking", b =>
                {
                    b.HasOne("TeamFive.Models.Lesson", "BookingLesson")
                        .WithMany("BookedStudents")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamFive.Models.Lesson", "LessonName")
                        .WithMany()
                        .HasForeignKey("LessonNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamFive.Models.Student", "BookingStudent")
                        .WithMany("BookedLessons")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingLesson");

                    b.Navigation("BookingStudent");

                    b.Navigation("LessonName");
                });

            modelBuilder.Entity("TeamFive.Models.Instructor", b =>
                {
                    b.Navigation("LessonCatalogue");
                });

            modelBuilder.Entity("TeamFive.Models.Lesson", b =>
                {
                    b.Navigation("BookedStudents");
                });

            modelBuilder.Entity("TeamFive.Models.Student", b =>
                {
                    b.Navigation("BookedLessons");

                    b.Navigation("SeekingLessons");
                });
#pragma warning restore 612, 618
        }
    }
}