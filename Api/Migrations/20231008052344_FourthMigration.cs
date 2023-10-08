using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Instruments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    YearsExperience = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WillingToTravel = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InstructorAboutMe = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AcceptingNewStudents = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WillingToTravel = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LessonTypeId = table.Column<int>(type: "int", nullable: false),
                    PricePerLesson = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OnlineAvailable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_Instruments_LessonTypeId",
                        column: x => x.LessonTypeId,
                        principalTable: "Instruments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StudentLessonBookings",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    LessonNameId = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    BookingNotes = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLessonBookings", x => new { x.StudentId, x.LessonId });
                    table.ForeignKey(
                        name: "FK_StudentLessonBookings_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentLessonBookings_Lessons_LessonNameId",
                        column: x => x.LessonNameId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentLessonBookings_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8300), null, new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8471), null, new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8489), null, new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8505), null, new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8535), null, new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8558), null, new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 523, DateTimeKind.Utc).AddTicks(4354), "AQAAAAIAAYagAAAAEN7z2sctfRuCAw4m1I7/fP9ERHkzuNcV7d8GiTE2Ay3CfckPcCKoxdd7PdkD0Ug4NQ==", new DateTime(2023, 10, 8, 5, 23, 43, 523, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 606, DateTimeKind.Utc).AddTicks(3150), "AQAAAAIAAYagAAAAEI1vVXqM9d0qFtWbpXHaXppOngaUZoWK/HRM+mClzbUh6qgHyHDtXkTfVP3m1cWrMw==", new DateTime(2023, 10, 8, 5, 23, 43, 606, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 695, DateTimeKind.Utc).AddTicks(2489), "AQAAAAIAAYagAAAAENjOzBToqwVTN3LrFE0X1L1TvsSqhPCOgKuzJ9f0AcDa5Mqau5aBzRlUika2l0dx/w==", new DateTime(2023, 10, 8, 5, 23, 43, 695, DateTimeKind.Utc).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 809, DateTimeKind.Utc).AddTicks(6805), "AQAAAAIAAYagAAAAEKMroxTLyagF3HcPCXsvRUyCn250TDHc3h5s4sP1BZFrLu2Kkn1RefhLjUdBgCRieg==", new DateTime(2023, 10, 8, 5, 23, 43, 809, DateTimeKind.Utc).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 907, DateTimeKind.Utc).AddTicks(7860), "AQAAAAIAAYagAAAAEAVsl36VbJs7TlRmJ0U/WGKI0u2suAFTrkiawmba87MG9eD2iX+CfBIpX4KEW9E/cQ==", new DateTime(2023, 10, 8, 5, 23, 43, 907, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_StudentId",
                table: "Instruments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_InstructorId",
                table: "Lessons",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_LessonTypeId",
                table: "Lessons",
                column: "LessonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentLessonBookings_LessonId",
                table: "StudentLessonBookings",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentLessonBookings_LessonNameId",
                table: "StudentLessonBookings",
                column: "LessonNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_Students_StudentId",
                table: "Instruments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_Students_StudentId",
                table: "Instruments");

            migrationBuilder.DropTable(
                name: "StudentLessonBookings");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instruments_StudentId",
                table: "Instruments");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Instruments");

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1410), new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1544), new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1560), new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1574), new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1586), new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1602), new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 4, 55, 15, 482, DateTimeKind.Utc).AddTicks(7337), "AQAAAAIAAYagAAAAEHL0ZeX4HxYztq+6jf/dos1m9sr+xZH1DPHvOHrcMApuP41tuXRyDo/1Fgz5yVut3A==", new DateTime(2023, 10, 8, 4, 55, 15, 482, DateTimeKind.Utc).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 4, 55, 15, 568, DateTimeKind.Utc).AddTicks(6292), "AQAAAAIAAYagAAAAEFPXCijNv4q7DQSDp3l2PruE03QNfDsGOGpEll9o7uYBMgnhl1aK8ugxNtfm053xUA==", new DateTime(2023, 10, 8, 4, 55, 15, 568, DateTimeKind.Utc).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 4, 55, 15, 643, DateTimeKind.Utc).AddTicks(7965), "AQAAAAIAAYagAAAAECElLLHzdxyIWR7WjJh7oSe8rfxBLhu3+7XopMjOVf89NwY1eZz6IwVEghEMwP419w==", new DateTime(2023, 10, 8, 4, 55, 15, 643, DateTimeKind.Utc).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 4, 55, 15, 717, DateTimeKind.Utc).AddTicks(7319), "AQAAAAIAAYagAAAAECLlAvpqv9IiRI5Xc5KgJLAywnxK9gyaB0dQ1SSUiE90oAOeSRVN3JECBvcBuEI3XA==", new DateTime(2023, 10, 8, 4, 55, 15, 717, DateTimeKind.Utc).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 4, 55, 15, 796, DateTimeKind.Utc).AddTicks(4238), "AQAAAAIAAYagAAAAECkheQ4RZ8o+tp0iX6Vnxr9vUIeVq0/RqGHHLP3H+0z0Ixf/efjxMYyVUXa+sgG5hA==", new DateTime(2023, 10, 8, 4, 55, 15, 796, DateTimeKind.Utc).AddTicks(4240) });
        }
    }
}
