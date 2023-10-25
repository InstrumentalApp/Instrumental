using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    InstrumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Family = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.InstrumentId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleType = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookingDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    InstrumentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_Lessons_Instruments_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instruments",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lessons_Users_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    RefreshTokenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Expiry = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.RefreshTokenId);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserInstruments",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InstrumentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInstruments", x => new { x.UserId, x.InstrumentId });
                    table.ForeignKey(
                        name: "FK_UserInstruments_Instruments_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instruments",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInstruments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "CreatedAt", "Family", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2055), "Keyboard", "Piano", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2056) },
                    { 2, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2234), "String", "Guitar", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2234) },
                    { 3, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2252), "Woodwind", "Flute", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2252) },
                    { 4, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2274), "Percussion", "Drums", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2274) },
                    { 5, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2293), "String", "Violin", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2293) },
                    { 6, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2307), "Brass", "Trumpet", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2307) },
                    { 7, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2325), "Woodwind", "Saxophone", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2325) },
                    { 8, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2427), "String", "Bass Guitar", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2427) },
                    { 9, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2451), "Woodwind", "Clarinet", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2451) },
                    { 11, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2463), "Brass", "Trombone", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2464) },
                    { 12, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2481), "String", "Harp", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2481) },
                    { 13, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2492), "Percussion", "Vibrophone", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2492) },
                    { 14, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2504), "Woodwind", "Oboe", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2505) },
                    { 15, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2515), "Woodwind", "Bassoon", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2515) },
                    { 17, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2534), "String", "Classical Guitar", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2535) },
                    { 18, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2571), "Brass", "French Horn", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2572) },
                    { 19, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2582), "Keyboard", "Accordion", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2582) },
                    { 20, new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2593), "String", "Cello", new DateTime(2023, 10, 24, 1, 26, 36, 271, DateTimeKind.Utc).AddTicks(2593) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Bio", "CreatedAt", "RoleType", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 10, 24, 1, 26, 36, 339, DateTimeKind.Utc).AddTicks(7071), 0, new DateTime(2023, 10, 24, 1, 26, 36, 339, DateTimeKind.Utc).AddTicks(7075) },
                    { 2, null, new DateTime(2023, 10, 24, 1, 26, 36, 408, DateTimeKind.Utc).AddTicks(4070), 0, new DateTime(2023, 10, 24, 1, 26, 36, 408, DateTimeKind.Utc).AddTicks(4075) },
                    { 3, null, new DateTime(2023, 10, 24, 1, 26, 36, 476, DateTimeKind.Utc).AddTicks(6317), 0, new DateTime(2023, 10, 24, 1, 26, 36, 476, DateTimeKind.Utc).AddTicks(6320) },
                    { 4, null, new DateTime(2023, 10, 24, 1, 26, 36, 545, DateTimeKind.Utc).AddTicks(1661), 0, new DateTime(2023, 10, 24, 1, 26, 36, 545, DateTimeKind.Utc).AddTicks(1663) },
                    { 5, null, new DateTime(2023, 10, 24, 1, 26, 36, 613, DateTimeKind.Utc).AddTicks(9570), 0, new DateTime(2023, 10, 24, 1, 26, 36, 613, DateTimeKind.Utc).AddTicks(9573) },
                    { 6, null, new DateTime(2023, 10, 24, 1, 26, 36, 682, DateTimeKind.Utc).AddTicks(879), 0, new DateTime(2023, 10, 24, 1, 26, 36, 682, DateTimeKind.Utc).AddTicks(882) },
                    { 7, null, new DateTime(2023, 10, 24, 1, 26, 36, 750, DateTimeKind.Utc).AddTicks(244), 0, new DateTime(2023, 10, 24, 1, 26, 36, 750, DateTimeKind.Utc).AddTicks(247) },
                    { 8, null, new DateTime(2023, 10, 24, 1, 26, 36, 818, DateTimeKind.Utc).AddTicks(7674), 0, new DateTime(2023, 10, 24, 1, 26, 36, 818, DateTimeKind.Utc).AddTicks(7678) },
                    { 9, null, new DateTime(2023, 10, 24, 1, 26, 36, 887, DateTimeKind.Utc).AddTicks(3926), 0, new DateTime(2023, 10, 24, 1, 26, 36, 887, DateTimeKind.Utc).AddTicks(3933) },
                    { 10, null, new DateTime(2023, 10, 24, 1, 26, 36, 955, DateTimeKind.Utc).AddTicks(7440), 0, new DateTime(2023, 10, 24, 1, 26, 36, 955, DateTimeKind.Utc).AddTicks(7447) },
                    { 11, null, new DateTime(2023, 10, 24, 1, 26, 37, 23, DateTimeKind.Utc).AddTicks(6919), 0, new DateTime(2023, 10, 24, 1, 26, 37, 23, DateTimeKind.Utc).AddTicks(6923) },
                    { 12, null, new DateTime(2023, 10, 24, 1, 26, 37, 91, DateTimeKind.Utc).AddTicks(4787), 0, new DateTime(2023, 10, 24, 1, 26, 37, 91, DateTimeKind.Utc).AddTicks(4791) },
                    { 13, null, new DateTime(2023, 10, 24, 1, 26, 37, 159, DateTimeKind.Utc).AddTicks(5265), 0, new DateTime(2023, 10, 24, 1, 26, 37, 159, DateTimeKind.Utc).AddTicks(5269) },
                    { 14, null, new DateTime(2023, 10, 24, 1, 26, 37, 228, DateTimeKind.Utc).AddTicks(981), 0, new DateTime(2023, 10, 24, 1, 26, 37, 228, DateTimeKind.Utc).AddTicks(985) },
                    { 15, null, new DateTime(2023, 10, 24, 1, 26, 37, 296, DateTimeKind.Utc).AddTicks(3783), 0, new DateTime(2023, 10, 24, 1, 26, 37, 296, DateTimeKind.Utc).AddTicks(3787) },
                    { 16, null, new DateTime(2023, 10, 24, 1, 26, 37, 369, DateTimeKind.Utc).AddTicks(8623), 0, new DateTime(2023, 10, 24, 1, 26, 37, 369, DateTimeKind.Utc).AddTicks(8631) },
                    { 17, null, new DateTime(2023, 10, 24, 1, 26, 37, 439, DateTimeKind.Utc).AddTicks(7166), 0, new DateTime(2023, 10, 24, 1, 26, 37, 439, DateTimeKind.Utc).AddTicks(7172) },
                    { 18, null, new DateTime(2023, 10, 24, 1, 26, 37, 508, DateTimeKind.Utc).AddTicks(154), 0, new DateTime(2023, 10, 24, 1, 26, 37, 508, DateTimeKind.Utc).AddTicks(162) },
                    { 19, null, new DateTime(2023, 10, 24, 1, 26, 37, 576, DateTimeKind.Utc).AddTicks(4050), 1, new DateTime(2023, 10, 24, 1, 26, 37, 576, DateTimeKind.Utc).AddTicks(4054) },
                    { 20, null, new DateTime(2023, 10, 24, 1, 26, 37, 645, DateTimeKind.Utc).AddTicks(2793), 1, new DateTime(2023, 10, 24, 1, 26, 37, 645, DateTimeKind.Utc).AddTicks(2798) },
                    { 21, null, new DateTime(2023, 10, 24, 1, 26, 37, 713, DateTimeKind.Utc).AddTicks(1665), 1, new DateTime(2023, 10, 24, 1, 26, 37, 713, DateTimeKind.Utc).AddTicks(1669) },
                    { 22, null, new DateTime(2023, 10, 24, 1, 26, 37, 781, DateTimeKind.Utc).AddTicks(5359), 1, new DateTime(2023, 10, 24, 1, 26, 37, 781, DateTimeKind.Utc).AddTicks(5364) },
                    { 23, null, new DateTime(2023, 10, 24, 1, 26, 37, 849, DateTimeKind.Utc).AddTicks(8347), 1, new DateTime(2023, 10, 24, 1, 26, 37, 849, DateTimeKind.Utc).AddTicks(8352) },
                    { 24, null, new DateTime(2023, 10, 24, 1, 26, 37, 918, DateTimeKind.Utc).AddTicks(239), 1, new DateTime(2023, 10, 24, 1, 26, 37, 918, DateTimeKind.Utc).AddTicks(243) },
                    { 25, null, new DateTime(2023, 10, 24, 1, 26, 37, 986, DateTimeKind.Utc).AddTicks(1268), 1, new DateTime(2023, 10, 24, 1, 26, 37, 986, DateTimeKind.Utc).AddTicks(1276) },
                    { 26, null, new DateTime(2023, 10, 24, 1, 26, 38, 54, DateTimeKind.Utc).AddTicks(2139), 1, new DateTime(2023, 10, 24, 1, 26, 38, 54, DateTimeKind.Utc).AddTicks(2143) },
                    { 27, null, new DateTime(2023, 10, 24, 1, 26, 38, 122, DateTimeKind.Utc).AddTicks(4596), 1, new DateTime(2023, 10, 24, 1, 26, 38, 122, DateTimeKind.Utc).AddTicks(4601) },
                    { 28, null, new DateTime(2023, 10, 24, 1, 26, 38, 190, DateTimeKind.Utc).AddTicks(6757), 1, new DateTime(2023, 10, 24, 1, 26, 38, 190, DateTimeKind.Utc).AddTicks(6761) },
                    { 29, null, new DateTime(2023, 10, 24, 1, 26, 38, 258, DateTimeKind.Utc).AddTicks(9690), 1, new DateTime(2023, 10, 24, 1, 26, 38, 258, DateTimeKind.Utc).AddTicks(9695) },
                    { 30, null, new DateTime(2023, 10, 24, 1, 26, 38, 327, DateTimeKind.Utc).AddTicks(6036), 1, new DateTime(2023, 10, 24, 1, 26, 38, 327, DateTimeKind.Utc).AddTicks(6043) },
                    { 31, null, new DateTime(2023, 10, 24, 1, 26, 38, 396, DateTimeKind.Utc).AddTicks(960), 1, new DateTime(2023, 10, 24, 1, 26, 38, 396, DateTimeKind.Utc).AddTicks(965) },
                    { 32, null, new DateTime(2023, 10, 24, 1, 26, 38, 464, DateTimeKind.Utc).AddTicks(4060), 1, new DateTime(2023, 10, 24, 1, 26, 38, 464, DateTimeKind.Utc).AddTicks(4068) },
                    { 33, null, new DateTime(2023, 10, 24, 1, 26, 38, 533, DateTimeKind.Utc).AddTicks(8302), 1, new DateTime(2023, 10, 24, 1, 26, 38, 533, DateTimeKind.Utc).AddTicks(8306) },
                    { 34, null, new DateTime(2023, 10, 24, 1, 26, 38, 601, DateTimeKind.Utc).AddTicks(9997), 1, new DateTime(2023, 10, 24, 1, 26, 38, 602, DateTimeKind.Utc).AddTicks(55) },
                    { 35, null, new DateTime(2023, 10, 24, 1, 26, 38, 669, DateTimeKind.Utc).AddTicks(7662), 1, new DateTime(2023, 10, 24, 1, 26, 38, 669, DateTimeKind.Utc).AddTicks(7666) },
                    { 36, null, new DateTime(2023, 10, 24, 1, 26, 38, 737, DateTimeKind.Utc).AddTicks(8894), 1, new DateTime(2023, 10, 24, 1, 26, 38, 737, DateTimeKind.Utc).AddTicks(8898) },
                    { 37, null, new DateTime(2023, 10, 24, 1, 26, 38, 805, DateTimeKind.Utc).AddTicks(9284), 1, new DateTime(2023, 10, 24, 1, 26, 38, 805, DateTimeKind.Utc).AddTicks(9289) },
                    { 38, null, new DateTime(2023, 10, 24, 1, 26, 38, 874, DateTimeKind.Utc).AddTicks(2425), 1, new DateTime(2023, 10, 24, 1, 26, 38, 874, DateTimeKind.Utc).AddTicks(2430) },
                    { 39, null, new DateTime(2023, 10, 24, 1, 26, 38, 942, DateTimeKind.Utc).AddTicks(4433), 1, new DateTime(2023, 10, 24, 1, 26, 38, 942, DateTimeKind.Utc).AddTicks(4440) },
                    { 40, null, new DateTime(2023, 10, 24, 1, 26, 39, 10, DateTimeKind.Utc).AddTicks(7259), 1, new DateTime(2023, 10, 24, 1, 26, 39, 10, DateTimeKind.Utc).AddTicks(7263) },
                    { 41, null, new DateTime(2023, 10, 24, 1, 26, 39, 79, DateTimeKind.Utc).AddTicks(1428), 1, new DateTime(2023, 10, 24, 1, 26, 39, 79, DateTimeKind.Utc).AddTicks(1432) },
                    { 42, null, new DateTime(2023, 10, 24, 1, 26, 39, 147, DateTimeKind.Utc).AddTicks(1576), 1, new DateTime(2023, 10, 24, 1, 26, 39, 147, DateTimeKind.Utc).AddTicks(1581) },
                    { 43, null, new DateTime(2023, 10, 24, 1, 26, 39, 215, DateTimeKind.Utc).AddTicks(6999), 1, new DateTime(2023, 10, 24, 1, 26, 39, 215, DateTimeKind.Utc).AddTicks(7003) },
                    { 44, null, new DateTime(2023, 10, 24, 1, 26, 39, 283, DateTimeKind.Utc).AddTicks(9841), 1, new DateTime(2023, 10, 24, 1, 26, 39, 283, DateTimeKind.Utc).AddTicks(9845) },
                    { 45, null, new DateTime(2023, 10, 24, 1, 26, 39, 352, DateTimeKind.Utc).AddTicks(5512), 1, new DateTime(2023, 10, 24, 1, 26, 39, 352, DateTimeKind.Utc).AddTicks(5519) },
                    { 46, null, new DateTime(2023, 10, 24, 1, 26, 39, 421, DateTimeKind.Utc).AddTicks(1094), 1, new DateTime(2023, 10, 24, 1, 26, 39, 421, DateTimeKind.Utc).AddTicks(1099) },
                    { 47, null, new DateTime(2023, 10, 24, 1, 26, 39, 490, DateTimeKind.Utc).AddTicks(363), 1, new DateTime(2023, 10, 24, 1, 26, 39, 490, DateTimeKind.Utc).AddTicks(367) },
                    { 48, null, new DateTime(2023, 10, 24, 1, 26, 39, 557, DateTimeKind.Utc).AddTicks(8257), 1, new DateTime(2023, 10, 24, 1, 26, 39, 557, DateTimeKind.Utc).AddTicks(8262) },
                    { 49, null, new DateTime(2023, 10, 24, 1, 26, 39, 625, DateTimeKind.Utc).AddTicks(9466), 1, new DateTime(2023, 10, 24, 1, 26, 39, 625, DateTimeKind.Utc).AddTicks(9472) },
                    { 50, null, new DateTime(2023, 10, 24, 1, 26, 39, 693, DateTimeKind.Utc).AddTicks(8858), 1, new DateTime(2023, 10, 24, 1, 26, 39, 693, DateTimeKind.Utc).AddTicks(8863) },
                    { 51, null, new DateTime(2023, 10, 24, 1, 26, 39, 762, DateTimeKind.Utc).AddTicks(765), 1, new DateTime(2023, 10, 24, 1, 26, 39, 762, DateTimeKind.Utc).AddTicks(771) },
                    { 52, null, new DateTime(2023, 10, 24, 1, 26, 39, 831, DateTimeKind.Utc).AddTicks(4091), 1, new DateTime(2023, 10, 24, 1, 26, 39, 831, DateTimeKind.Utc).AddTicks(4095) },
                    { 53, null, new DateTime(2023, 10, 24, 1, 26, 39, 900, DateTimeKind.Utc).AddTicks(4805), 1, new DateTime(2023, 10, 24, 1, 26, 39, 900, DateTimeKind.Utc).AddTicks(4810) },
                    { 54, null, new DateTime(2023, 10, 24, 1, 26, 39, 968, DateTimeKind.Utc).AddTicks(9228), 1, new DateTime(2023, 10, 24, 1, 26, 39, 968, DateTimeKind.Utc).AddTicks(9232) },
                    { 55, null, new DateTime(2023, 10, 24, 1, 26, 40, 37, DateTimeKind.Utc).AddTicks(1504), 1, new DateTime(2023, 10, 24, 1, 26, 40, 37, DateTimeKind.Utc).AddTicks(1508) },
                    { 56, null, new DateTime(2023, 10, 24, 1, 26, 40, 105, DateTimeKind.Utc).AddTicks(2543), 1, new DateTime(2023, 10, 24, 1, 26, 40, 105, DateTimeKind.Utc).AddTicks(2547) },
                    { 57, null, new DateTime(2023, 10, 24, 1, 26, 40, 173, DateTimeKind.Utc).AddTicks(5102), 1, new DateTime(2023, 10, 24, 1, 26, 40, 173, DateTimeKind.Utc).AddTicks(5107) },
                    { 58, null, new DateTime(2023, 10, 24, 1, 26, 40, 242, DateTimeKind.Utc).AddTicks(2493), 1, new DateTime(2023, 10, 24, 1, 26, 40, 242, DateTimeKind.Utc).AddTicks(2497) },
                    { 59, null, new DateTime(2023, 10, 24, 1, 26, 40, 311, DateTimeKind.Utc).AddTicks(40), 1, new DateTime(2023, 10, 24, 1, 26, 40, 311, DateTimeKind.Utc).AddTicks(44) },
                    { 60, null, new DateTime(2023, 10, 24, 1, 26, 40, 379, DateTimeKind.Utc).AddTicks(2481), 1, new DateTime(2023, 10, 24, 1, 26, 40, 379, DateTimeKind.Utc).AddTicks(2485) },
                    { 61, null, new DateTime(2023, 10, 24, 1, 26, 40, 448, DateTimeKind.Utc).AddTicks(989), 1, new DateTime(2023, 10, 24, 1, 26, 40, 448, DateTimeKind.Utc).AddTicks(994) },
                    { 62, null, new DateTime(2023, 10, 24, 1, 26, 40, 516, DateTimeKind.Utc).AddTicks(593), 1, new DateTime(2023, 10, 24, 1, 26, 40, 516, DateTimeKind.Utc).AddTicks(600) },
                    { 63, null, new DateTime(2023, 10, 24, 1, 26, 40, 584, DateTimeKind.Utc).AddTicks(5295), 1, new DateTime(2023, 10, 24, 1, 26, 40, 584, DateTimeKind.Utc).AddTicks(5299) },
                    { 64, null, new DateTime(2023, 10, 24, 1, 26, 40, 652, DateTimeKind.Utc).AddTicks(9267), 1, new DateTime(2023, 10, 24, 1, 26, 40, 652, DateTimeKind.Utc).AddTicks(9271) },
                    { 65, null, new DateTime(2023, 10, 24, 1, 26, 40, 720, DateTimeKind.Utc).AddTicks(8068), 1, new DateTime(2023, 10, 24, 1, 26, 40, 720, DateTimeKind.Utc).AddTicks(8072) },
                    { 66, null, new DateTime(2023, 10, 24, 1, 26, 40, 788, DateTimeKind.Utc).AddTicks(9121), 1, new DateTime(2023, 10, 24, 1, 26, 40, 788, DateTimeKind.Utc).AddTicks(9126) },
                    { 67, null, new DateTime(2023, 10, 24, 1, 26, 40, 856, DateTimeKind.Utc).AddTicks(7790), 1, new DateTime(2023, 10, 24, 1, 26, 40, 856, DateTimeKind.Utc).AddTicks(7795) },
                    { 68, null, new DateTime(2023, 10, 24, 1, 26, 40, 925, DateTimeKind.Utc).AddTicks(120), 1, new DateTime(2023, 10, 24, 1, 26, 40, 925, DateTimeKind.Utc).AddTicks(125) },
                    { 70, null, new DateTime(2023, 10, 24, 1, 26, 40, 991, DateTimeKind.Utc).AddTicks(9575), 2, new DateTime(2023, 10, 24, 1, 26, 40, 991, DateTimeKind.Utc).AddTicks(9580) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 24, 1, 26, 36, 272, DateTimeKind.Utc).AddTicks(4716), "shemar.effertz@email.com", "Shemar", "Effertz", "AQAAAAIAAYagAAAAEM6WmeVAvMleIMT/FzupjcAkRzJvi6eCPsoZnbEpbavhrC5qgZcOCre2hAJPAwI5XA==", new DateTime(2023, 10, 24, 1, 26, 36, 272, DateTimeKind.Utc).AddTicks(4718) },
                    { 2, new DateTime(2023, 10, 24, 1, 26, 36, 341, DateTimeKind.Utc).AddTicks(343), "jerrell.nikolaus@email.com", "Jerrell", "Nikolaus", "AQAAAAIAAYagAAAAEKAnmp0c+x2MtcY6gPY3LQWG0Dy+BJK+1jIlQov17fCpPWgsHc/uzojCRp8qDN8x+Q==", new DateTime(2023, 10, 24, 1, 26, 36, 341, DateTimeKind.Utc).AddTicks(344) },
                    { 3, new DateTime(2023, 10, 24, 1, 26, 36, 409, DateTimeKind.Utc).AddTicks(5321), "lilyan.heaney@email.com", "Lilyan", "Heaney", "AQAAAAIAAYagAAAAEFJg4kS0is70chqXcYQMmH8dKfWePxWi6hdp5LQIEU0GRibSLR2KFGqTr5G4ljtSrw==", new DateTime(2023, 10, 24, 1, 26, 36, 409, DateTimeKind.Utc).AddTicks(5321) },
                    { 4, new DateTime(2023, 10, 24, 1, 26, 36, 477, DateTimeKind.Utc).AddTicks(9340), "griffin.stoltenberg@email.com", "Griffin", "Stoltenberg", "AQAAAAIAAYagAAAAENwJ9mcSHsBsznppHpsr3lkijsgzzYIm0eUSneWObiKDQynWQduyOhcSDLMvqfthNQ==", new DateTime(2023, 10, 24, 1, 26, 36, 477, DateTimeKind.Utc).AddTicks(9341) },
                    { 5, new DateTime(2023, 10, 24, 1, 26, 36, 546, DateTimeKind.Utc).AddTicks(4731), "alford.legros@email.com", "Alford", "Legros", "AQAAAAIAAYagAAAAENgbjezCEr9xGbH7toikqIVWeIkRqkiMFsBT6QE4vQAs1Q3F1+0fEXXIHc6iACYx0g==", new DateTime(2023, 10, 24, 1, 26, 36, 546, DateTimeKind.Utc).AddTicks(4733) },
                    { 6, new DateTime(2023, 10, 24, 1, 26, 36, 615, DateTimeKind.Utc).AddTicks(2721), "glenda.rodriguez@email.com", "Glenda", "Rodriguez", "AQAAAAIAAYagAAAAEI+ZYP7u7tAUec8KL3GanxqB6eGG6Pao4w2+o/FP+BiJXQ/WR7bwDQR/RmpM7y4IWA==", new DateTime(2023, 10, 24, 1, 26, 36, 615, DateTimeKind.Utc).AddTicks(2722) },
                    { 7, new DateTime(2023, 10, 24, 1, 26, 36, 683, DateTimeKind.Utc).AddTicks(1213), "cornelius.weimann@email.com", "Cornelius", "Weimann", "AQAAAAIAAYagAAAAEN62/vVlJM1oL61yV7aSjF/8Pz72JJgZ7uU8if6lD36pLQ8SKOlAGCy14Zle8zM+xw==", new DateTime(2023, 10, 24, 1, 26, 36, 683, DateTimeKind.Utc).AddTicks(1214) },
                    { 8, new DateTime(2023, 10, 24, 1, 26, 36, 751, DateTimeKind.Utc).AddTicks(4226), "jadon.mitchell@email.com", "Jadon", "Mitchell", "AQAAAAIAAYagAAAAELKTK6IHsm80bA8ymZCURAoREz7cg5SZ6uwiJ4NjTCHLO+x5D7XUFU/l3n/qfoOxFg==", new DateTime(2023, 10, 24, 1, 26, 36, 751, DateTimeKind.Utc).AddTicks(4232) },
                    { 9, new DateTime(2023, 10, 24, 1, 26, 36, 820, DateTimeKind.Utc).AddTicks(1004), "leland.bayer@email.com", "Leland", "Bayer", "AQAAAAIAAYagAAAAEDIfPEDSmHziZqMvPhqfbUAow0r4YsmGPhHpEc8aMnTx7ZWUWzFp+ASdZlFZz7jaWA==", new DateTime(2023, 10, 24, 1, 26, 36, 820, DateTimeKind.Utc).AddTicks(1005) },
                    { 10, new DateTime(2023, 10, 24, 1, 26, 36, 888, DateTimeKind.Utc).AddTicks(7119), "lesly.ullrich@email.com", "Lesly", "Ullrich", "AQAAAAIAAYagAAAAEB4uQO5JILp1OJNDr6lLW/9u1wULbJJvM68l7e9bnsnwfgkFEodZc5KLOa2i/bugkg==", new DateTime(2023, 10, 24, 1, 26, 36, 888, DateTimeKind.Utc).AddTicks(7120) },
                    { 11, new DateTime(2023, 10, 24, 1, 26, 36, 956, DateTimeKind.Utc).AddTicks(8043), "oma.macejkovic@email.com", "Oma", "Macejkovic", "AQAAAAIAAYagAAAAEGtAbr5mG6SriddGn0xrB8vhJCjjkH4jqFCsUKnR8zviAM5TnD7o6UUPZErRdrlkxA==", new DateTime(2023, 10, 24, 1, 26, 36, 956, DateTimeKind.Utc).AddTicks(8044) },
                    { 12, new DateTime(2023, 10, 24, 1, 26, 37, 25, DateTimeKind.Utc).AddTicks(685), "yessenia.pagac@email.com", "Yessenia", "Pagac", "AQAAAAIAAYagAAAAEMoBCkgUfS2Fei3fpUpQpJ9lVW/HuR/tRHvNntgZYZ3nZigL3G27j5F7jZjVdJI55w==", new DateTime(2023, 10, 24, 1, 26, 37, 25, DateTimeKind.Utc).AddTicks(685) },
                    { 13, new DateTime(2023, 10, 24, 1, 26, 37, 92, DateTimeKind.Utc).AddTicks(7098), "hans.gislason@email.com", "Hans", "Gislason", "AQAAAAIAAYagAAAAEN6mETcBaUZk5HwelDSPVOojvEcc91n7x68Q+tpMksbQlsXxRUaFoUx+xA5pT+1s3w==", new DateTime(2023, 10, 24, 1, 26, 37, 92, DateTimeKind.Utc).AddTicks(7099) },
                    { 14, new DateTime(2023, 10, 24, 1, 26, 37, 160, DateTimeKind.Utc).AddTicks(7872), "rogelio.romaguera@email.com", "Rogelio", "Romaguera", "AQAAAAIAAYagAAAAEEcQqCc6i+Qs0TeKk1F4oS84+aqmlcmxDhV5EYDlQCi7UPgPAcTnWBrIM70oneK2KQ==", new DateTime(2023, 10, 24, 1, 26, 37, 160, DateTimeKind.Utc).AddTicks(7873) },
                    { 15, new DateTime(2023, 10, 24, 1, 26, 37, 229, DateTimeKind.Utc).AddTicks(4260), "rudolph.green@email.com", "Rudolph", "Green", "AQAAAAIAAYagAAAAEEftP5Gh1GFWpNNJxQ208xWL5Lk29uWC94tX7BvD1rjn7EXLiuD9NVxL3pEelr+kzw==", new DateTime(2023, 10, 24, 1, 26, 37, 229, DateTimeKind.Utc).AddTicks(4261) },
                    { 16, new DateTime(2023, 10, 24, 1, 26, 37, 297, DateTimeKind.Utc).AddTicks(4566), "jayde.russel@email.com", "Jayde", "Russel", "AQAAAAIAAYagAAAAEBmo68kOYqCcccLfgCkyY6GHGGvIfcj7wEjL1zA52GQHITm+zfxnTy/s9Zk7t0BbQw==", new DateTime(2023, 10, 24, 1, 26, 37, 297, DateTimeKind.Utc).AddTicks(4567) },
                    { 17, new DateTime(2023, 10, 24, 1, 26, 37, 371, DateTimeKind.Utc).AddTicks(1333), "edwina.heidenreich@email.com", "Edwina", "Heidenreich", "AQAAAAIAAYagAAAAEHAKT5+R6ctwIVtqU+IPalUkKiESSVlE4ZXNTk5ePLeYSu1q6Urud3b7FO65/udYmA==", new DateTime(2023, 10, 24, 1, 26, 37, 371, DateTimeKind.Utc).AddTicks(1335) },
                    { 18, new DateTime(2023, 10, 24, 1, 26, 37, 441, DateTimeKind.Utc).AddTicks(335), "amir.kautzer@email.com", "Amir", "Kautzer", "AQAAAAIAAYagAAAAEFN4vpUDjzXYhO+hF2ECgrzNHvexyZnlAn5ET01viaFTu07qdZwK4svFVTGcX7yUtA==", new DateTime(2023, 10, 24, 1, 26, 37, 441, DateTimeKind.Utc).AddTicks(336) },
                    { 19, new DateTime(2023, 10, 24, 1, 26, 37, 509, DateTimeKind.Utc).AddTicks(3729), "talon.romaguera@email.com", "Talon", "Romaguera", "AQAAAAIAAYagAAAAEM6OQDltPF5lrIhz31GMjJIJUCtKx/IPXwh76eqE/BRqI+oFbi+RRuXfuddg+KgV2A==", new DateTime(2023, 10, 24, 1, 26, 37, 509, DateTimeKind.Utc).AddTicks(3730) },
                    { 20, new DateTime(2023, 10, 24, 1, 26, 37, 577, DateTimeKind.Utc).AddTicks(7287), "margarett.braun@email.com", "Margarett", "Braun", "AQAAAAIAAYagAAAAEDvn6YtT6Mk3E768HVakSD7LLA8lhe9ydF+XoZPLA4arrk+zPTGliyAs/isBvUbz9A==", new DateTime(2023, 10, 24, 1, 26, 37, 577, DateTimeKind.Utc).AddTicks(7288) },
                    { 21, new DateTime(2023, 10, 24, 1, 26, 37, 646, DateTimeKind.Utc).AddTicks(4314), "meda.schaefer@email.com", "Meda", "Schaefer", "AQAAAAIAAYagAAAAEOxl8uqrnS/r6t5humasXdp9dNU+tP/4EgpRMBO7GMOExa2O0wUb7QIREMlJl219Cw==", new DateTime(2023, 10, 24, 1, 26, 37, 646, DateTimeKind.Utc).AddTicks(4315) },
                    { 22, new DateTime(2023, 10, 24, 1, 26, 37, 714, DateTimeKind.Utc).AddTicks(5200), "fritz.will@email.com", "Fritz", "Will", "AQAAAAIAAYagAAAAEJPMfMBKiQaWw4kkkNfqfTAkkrKLccHapc8Hz2YVOdJ9NqcusVBsZ5JO9tAzsK0WyQ==", new DateTime(2023, 10, 24, 1, 26, 37, 714, DateTimeKind.Utc).AddTicks(5201) },
                    { 23, new DateTime(2023, 10, 24, 1, 26, 37, 782, DateTimeKind.Utc).AddTicks(9017), "peggie.stracke@email.com", "Peggie", "Stracke", "AQAAAAIAAYagAAAAEJRMCiTHwmmAVqbn4nQoMornRcvhxJPAuvUWt3PIuclegjBjelvqkv+6jxLEe0ztfA==", new DateTime(2023, 10, 24, 1, 26, 37, 782, DateTimeKind.Utc).AddTicks(9018) },
                    { 24, new DateTime(2023, 10, 24, 1, 26, 37, 851, DateTimeKind.Utc).AddTicks(4019), "hillary.wisozk@email.com", "Hillary", "Wisozk", "AQAAAAIAAYagAAAAEKBom1c66B+8m5gmWS134xfbEzv3G99WZSYDfo4BH6PNOBlXVgz3e3+j1DMGWHBrSQ==", new DateTime(2023, 10, 24, 1, 26, 37, 851, DateTimeKind.Utc).AddTicks(4023) },
                    { 25, new DateTime(2023, 10, 24, 1, 26, 37, 919, DateTimeKind.Utc).AddTicks(2825), "destinee.leannon@email.com", "Destinee", "Leannon", "AQAAAAIAAYagAAAAEFu8VDO/9lmycjgRjkEnQXfkO9fAU6WS6l1aoy+MsYs+fU3WeXoTRiLGo3lP9QRDHQ==", new DateTime(2023, 10, 24, 1, 26, 37, 919, DateTimeKind.Utc).AddTicks(2826) },
                    { 26, new DateTime(2023, 10, 24, 1, 26, 37, 987, DateTimeKind.Utc).AddTicks(4479), "bernadette.brown@email.com", "Bernadette", "Brown", "AQAAAAIAAYagAAAAEPJqQY1EPsRtiz4B54iFbAQvXu0TMIpkcOOzLmypS4MYQs0hjdjaxghFFKTyODUdyQ==", new DateTime(2023, 10, 24, 1, 26, 37, 987, DateTimeKind.Utc).AddTicks(4479) },
                    { 27, new DateTime(2023, 10, 24, 1, 26, 38, 55, DateTimeKind.Utc).AddTicks(5925), "jackeline.stamm@email.com", "Jackeline", "Stamm", "AQAAAAIAAYagAAAAEBzi8csqjCG7ikaUOutEo9mp8H1qfe/59CT5DMMIw6QHM/U7a756O7uu7LrQppXRIA==", new DateTime(2023, 10, 24, 1, 26, 38, 55, DateTimeKind.Utc).AddTicks(5926) },
                    { 28, new DateTime(2023, 10, 24, 1, 26, 38, 123, DateTimeKind.Utc).AddTicks(8447), "rhett.ziemann@email.com", "Rhett", "Ziemann", "AQAAAAIAAYagAAAAEHlnPAb1fUvQQLdfpMoSyoL/Y5PJo3+fRAxpFcUik9tu0v2XN6qcfpYcPV5S3VvNSg==", new DateTime(2023, 10, 24, 1, 26, 38, 123, DateTimeKind.Utc).AddTicks(8448) },
                    { 29, new DateTime(2023, 10, 24, 1, 26, 38, 192, DateTimeKind.Utc).AddTicks(788), "freida.roberts@email.com", "Freida", "Roberts", "AQAAAAIAAYagAAAAEP+rAmzy5lZrSCoWih7E3j+OXI5F4rnxAY3YAcKpRw/NB6wjlEU1aHFXp+QGA+0KVQ==", new DateTime(2023, 10, 24, 1, 26, 38, 192, DateTimeKind.Utc).AddTicks(790) },
                    { 30, new DateTime(2023, 10, 24, 1, 26, 38, 260, DateTimeKind.Utc).AddTicks(3312), "arno.beer@email.com", "Arno", "Beer", "AQAAAAIAAYagAAAAEIMj1DVOgTciqSpaYQTFu0IGNIhDEfXBJw5+FIgOjNQmu6Awn25cwQAR3W5GWwi3NA==", new DateTime(2023, 10, 24, 1, 26, 38, 260, DateTimeKind.Utc).AddTicks(3314) },
                    { 31, new DateTime(2023, 10, 24, 1, 26, 38, 328, DateTimeKind.Utc).AddTicks(8925), "soledad.konopelski@email.com", "Soledad", "Konopelski", "AQAAAAIAAYagAAAAEOMLTW1CWU1JSqJ2csZZrLuvBblju4pjKtVSPX7VrIoL8YP72dWlNFWJkYg+8+X7cw==", new DateTime(2023, 10, 24, 1, 26, 38, 328, DateTimeKind.Utc).AddTicks(8928) },
                    { 32, new DateTime(2023, 10, 24, 1, 26, 38, 397, DateTimeKind.Utc).AddTicks(4881), "lucas.gorczany@email.com", "Lucas", "Gorczany", "AQAAAAIAAYagAAAAED/XROQIkBNdzWUEPkIY6owFkV2tQfQbdwCGEBoAe2m6gmx1LZsz998EvARGKmWTwQ==", new DateTime(2023, 10, 24, 1, 26, 38, 397, DateTimeKind.Utc).AddTicks(4883) },
                    { 33, new DateTime(2023, 10, 24, 1, 26, 38, 465, DateTimeKind.Utc).AddTicks(7305), "annetta.oberbrunner@email.com", "Annetta", "Oberbrunner", "AQAAAAIAAYagAAAAEJDmF60VV8xtlN7tCaxmGXKWssuXtzaiuAadc6Lmqm+h03TTc6WOgfq20IItuRS/Nw==", new DateTime(2023, 10, 24, 1, 26, 38, 465, DateTimeKind.Utc).AddTicks(7306) },
                    { 34, new DateTime(2023, 10, 24, 1, 26, 38, 535, DateTimeKind.Utc).AddTicks(2138), "lazaro.turcotte@email.com", "Lazaro", "Turcotte", "AQAAAAIAAYagAAAAEDnIGtJC0O5ZBwHanYRpgtuF2s+RpjD1sGOZGfwwvG61Nz2gLowBtOeCCQLvnQvdqQ==", new DateTime(2023, 10, 24, 1, 26, 38, 535, DateTimeKind.Utc).AddTicks(2140) },
                    { 35, new DateTime(2023, 10, 24, 1, 26, 38, 603, DateTimeKind.Utc).AddTicks(3069), "dennis.collins@email.com", "Dennis", "Collins", "AQAAAAIAAYagAAAAEPoI2NNqt0UICfXvYXotf3KrAfwEIlXSJ15jnjR3itKJJuALx8O10QJAUODySj+5wA==", new DateTime(2023, 10, 24, 1, 26, 38, 603, DateTimeKind.Utc).AddTicks(3069) },
                    { 36, new DateTime(2023, 10, 24, 1, 26, 38, 671, DateTimeKind.Utc).AddTicks(861), "flossie.bernier@email.com", "Flossie", "Bernier", "AQAAAAIAAYagAAAAEAV++Rl0k6/eBEFLYkUsjbPojy2rSn1U0juaib6UhUHBInQoKXY3pYr0qAEX1x0X0Q==", new DateTime(2023, 10, 24, 1, 26, 38, 671, DateTimeKind.Utc).AddTicks(862) },
                    { 37, new DateTime(2023, 10, 24, 1, 26, 38, 739, DateTimeKind.Utc).AddTicks(2382), "juvenal.gottlieb@email.com", "Juvenal", "Gottlieb", "AQAAAAIAAYagAAAAEFmQPq1sxQioLUPbiPGcR+fEgWCW6ypZ6dATfGMPrlVElKiQU5C5vcUHU88fvWlA6w==", new DateTime(2023, 10, 24, 1, 26, 38, 739, DateTimeKind.Utc).AddTicks(2383) },
                    { 38, new DateTime(2023, 10, 24, 1, 26, 38, 807, DateTimeKind.Utc).AddTicks(3264), "casimir.hudson@email.com", "Casimir", "Hudson", "AQAAAAIAAYagAAAAEBWdXiQcJ8Xx39RYJGIaFf1jAFN4kGyspjTQLDz34zhBr/C1TTZ950t3EWLzY7MF0A==", new DateTime(2023, 10, 24, 1, 26, 38, 807, DateTimeKind.Utc).AddTicks(3266) },
                    { 39, new DateTime(2023, 10, 24, 1, 26, 38, 875, DateTimeKind.Utc).AddTicks(5494), "karine.weimann@email.com", "Karine", "Weimann", "AQAAAAIAAYagAAAAENRE1FZ2hBrDodFeqFnXa77G9bP+k2GTrUKoBxil9GKONAA8gdc9trYlLfuv05l1+A==", new DateTime(2023, 10, 24, 1, 26, 38, 875, DateTimeKind.Utc).AddTicks(5496) },
                    { 40, new DateTime(2023, 10, 24, 1, 26, 38, 943, DateTimeKind.Utc).AddTicks(7553), "candelario.schmeler@email.com", "Candelario", "Schmeler", "AQAAAAIAAYagAAAAENA2De9MGu1eVxjuLi7Fcu8N7fz4ENXcwigeF5Zsp23OoJ9QlzLMC4eehgo1aTCX3A==", new DateTime(2023, 10, 24, 1, 26, 38, 943, DateTimeKind.Utc).AddTicks(7553) },
                    { 41, new DateTime(2023, 10, 24, 1, 26, 39, 12, DateTimeKind.Utc).AddTicks(714), "raphael.schneider@email.com", "Raphael", "Schneider", "AQAAAAIAAYagAAAAELA0qnH1ca15fU7njxvdwTa4xH+qB3T19C24OnQ0rnsJ6iyl/BpwA3aV01JDnhKcLw==", new DateTime(2023, 10, 24, 1, 26, 39, 12, DateTimeKind.Utc).AddTicks(716) },
                    { 42, new DateTime(2023, 10, 24, 1, 26, 39, 80, DateTimeKind.Utc).AddTicks(4524), "brent.haag@email.com", "Brent", "Haag", "AQAAAAIAAYagAAAAECWL80WnD20aCM99UnI+h7hhhl/HJOb1OLONLJk7g8N90uDnw4fK2ehaZrTDFZXo+w==", new DateTime(2023, 10, 24, 1, 26, 39, 80, DateTimeKind.Utc).AddTicks(4526) },
                    { 43, new DateTime(2023, 10, 24, 1, 26, 39, 148, DateTimeKind.Utc).AddTicks(6153), "maymie.langosh@email.com", "Maymie", "Langosh", "AQAAAAIAAYagAAAAEH9vtK8GIcMLjpxNFFDSsFcy2gJV3YhBJMmAzqWG2N2YUeJknUByaTUNdlf/na1Syw==", new DateTime(2023, 10, 24, 1, 26, 39, 148, DateTimeKind.Utc).AddTicks(6153) },
                    { 44, new DateTime(2023, 10, 24, 1, 26, 39, 217, DateTimeKind.Utc).AddTicks(220), "erling.hauck@email.com", "Erling", "Hauck", "AQAAAAIAAYagAAAAEBDo9hyzzlIQTQR2za0Q2LnP267wuboMtjA83QOGSLlOaMLLNkV/t6Um+0KASaB7pA==", new DateTime(2023, 10, 24, 1, 26, 39, 217, DateTimeKind.Utc).AddTicks(221) },
                    { 45, new DateTime(2023, 10, 24, 1, 26, 39, 285, DateTimeKind.Utc).AddTicks(3288), "kailyn.streich@email.com", "Kailyn", "Streich", "AQAAAAIAAYagAAAAEA9V6vStH5fFVTEMbS6OtwTiZuXnpKUh8V6oTLPl0URJJ/Zld9Gpv/SITDAH2tyL/w==", new DateTime(2023, 10, 24, 1, 26, 39, 285, DateTimeKind.Utc).AddTicks(3289) },
                    { 46, new DateTime(2023, 10, 24, 1, 26, 39, 353, DateTimeKind.Utc).AddTicks(9667), "maximilian.king@email.com", "Maximilian", "King", "AQAAAAIAAYagAAAAEEfH11ssuibdJ1/1v4vPYngPVcKldToNeZDes4F4u0dffX9wAyYgd/RRIOsHYua6jw==", new DateTime(2023, 10, 24, 1, 26, 39, 353, DateTimeKind.Utc).AddTicks(9669) },
                    { 47, new DateTime(2023, 10, 24, 1, 26, 39, 422, DateTimeKind.Utc).AddTicks(6754), "hope.ferry@email.com", "Hope", "Ferry", "AQAAAAIAAYagAAAAEJvgazke7ZBPPXBLtxAn4HsPQglaAWpQHfiP1QNI7sBz6CIyIRbF6vAqcuEbNpWTew==", new DateTime(2023, 10, 24, 1, 26, 39, 422, DateTimeKind.Utc).AddTicks(6755) },
                    { 48, new DateTime(2023, 10, 24, 1, 26, 39, 491, DateTimeKind.Utc).AddTicks(3382), "juanita.gaylord@email.com", "Juanita", "Gaylord", "AQAAAAIAAYagAAAAECpkVMj+z+6j0l+gQEZdVl60GRZDV5D8pVmc2d4B+BYQ9Fzb+t4ehn1M37t2Eg5l2w==", new DateTime(2023, 10, 24, 1, 26, 39, 491, DateTimeKind.Utc).AddTicks(3384) },
                    { 49, new DateTime(2023, 10, 24, 1, 26, 39, 559, DateTimeKind.Utc).AddTicks(1754), "casimir.torphy@email.com", "Casimir", "Torphy", "AQAAAAIAAYagAAAAEJ0cFgnNZk+mzd+V7p2a5wYDARyRauYO2NPZ5siEa7Xy+vQf7nLjv/wHT4Bn63m+xw==", new DateTime(2023, 10, 24, 1, 26, 39, 559, DateTimeKind.Utc).AddTicks(1755) },
                    { 50, new DateTime(2023, 10, 24, 1, 26, 39, 627, DateTimeKind.Utc).AddTicks(3528), "guy.cremin@email.com", "Guy", "Cremin", "AQAAAAIAAYagAAAAEPRhMyib1tdnXlM9t0Gvx3UlzrCVbW53j6jzQUtePFhDARvGw5Kimnf0UFI58XHqjA==", new DateTime(2023, 10, 24, 1, 26, 39, 627, DateTimeKind.Utc).AddTicks(3529) },
                    { 51, new DateTime(2023, 10, 24, 1, 26, 39, 695, DateTimeKind.Utc).AddTicks(3091), "oceane.macejkovic@email.com", "Oceane", "Macejkovic", "AQAAAAIAAYagAAAAEKdqpbOJner0sdUc8V5zM9XHWWXlZUeUcUEi852PjD1igpEtB+kNY1DwSyLG9uffKA==", new DateTime(2023, 10, 24, 1, 26, 39, 695, DateTimeKind.Utc).AddTicks(3092) },
                    { 52, new DateTime(2023, 10, 24, 1, 26, 39, 763, DateTimeKind.Utc).AddTicks(5234), "shany.tremblay@email.com", "Shany", "Tremblay", "AQAAAAIAAYagAAAAEDXRUaaJoHZSh06TVsOIMfrMn1tFPZRH5zNz0B7pck8NwCxbPL1WqmOeba6i47ZSjQ==", new DateTime(2023, 10, 24, 1, 26, 39, 763, DateTimeKind.Utc).AddTicks(5236) },
                    { 53, new DateTime(2023, 10, 24, 1, 26, 39, 832, DateTimeKind.Utc).AddTicks(9516), "ladarius.reinger@email.com", "Ladarius", "Reinger", "AQAAAAIAAYagAAAAEDLEDlCRMe0Auz8IqejcVZBR7OaYg18amUJEwKZXiy+dgBkiw3vv5icQMO2gvYKcoQ==", new DateTime(2023, 10, 24, 1, 26, 39, 832, DateTimeKind.Utc).AddTicks(9518) },
                    { 54, new DateTime(2023, 10, 24, 1, 26, 39, 901, DateTimeKind.Utc).AddTicks(8310), "xavier.reichert@email.com", "Xavier", "Reichert", "AQAAAAIAAYagAAAAEBkQzJO0eyFgdNp3MJ254RaWxiXH3YaeSZmPOeYQqgUiyjurMJOh7n0FhcViVz2GZw==", new DateTime(2023, 10, 24, 1, 26, 39, 901, DateTimeKind.Utc).AddTicks(8311) },
                    { 55, new DateTime(2023, 10, 24, 1, 26, 39, 970, DateTimeKind.Utc).AddTicks(5151), "efrain.strosin@email.com", "Efrain", "Strosin", "AQAAAAIAAYagAAAAEAd8xuzABwdYAnrOOOrbk9hFjPaaTQgSMam8vXG8ninHu8HHD5OEdCrey8Z4rz5/+g==", new DateTime(2023, 10, 24, 1, 26, 39, 970, DateTimeKind.Utc).AddTicks(5152) },
                    { 56, new DateTime(2023, 10, 24, 1, 26, 40, 38, DateTimeKind.Utc).AddTicks(4485), "rigoberto.harris@email.com", "Rigoberto", "Harris", "AQAAAAIAAYagAAAAEICgjCL2iWXX6gBCSKFYiQaD6ZJO10W41VvgXA5T6pP3HCsif2Pp6A00EgwUHHhIQw==", new DateTime(2023, 10, 24, 1, 26, 40, 38, DateTimeKind.Utc).AddTicks(4486) },
                    { 57, new DateTime(2023, 10, 24, 1, 26, 40, 106, DateTimeKind.Utc).AddTicks(5709), "kamron.kassulke@email.com", "Kamron", "Kassulke", "AQAAAAIAAYagAAAAEKc0j+MGf2UvlJcA99O7CGsGmxrgkc4ai0kmPpyIagW4EaY0XpmVFVv4r26hjTJuvw==", new DateTime(2023, 10, 24, 1, 26, 40, 106, DateTimeKind.Utc).AddTicks(5710) },
                    { 58, new DateTime(2023, 10, 24, 1, 26, 40, 174, DateTimeKind.Utc).AddTicks(8388), "keith.heidenreich@email.com", "Keith", "Heidenreich", "AQAAAAIAAYagAAAAEMkaJCWhKrt6wDInQP1pQKwT+sESHOaOT1+H0F4rHBWpEtu3lC3akNvM9SquMKAZzA==", new DateTime(2023, 10, 24, 1, 26, 40, 174, DateTimeKind.Utc).AddTicks(8389) },
                    { 59, new DateTime(2023, 10, 24, 1, 26, 40, 243, DateTimeKind.Utc).AddTicks(5635), "jocelyn.swift@email.com", "Jocelyn", "Swift", "AQAAAAIAAYagAAAAEDDdEyUpib3mOUNd8ykF7nkR6EAEyPtn7tVtS1qIqn5D5XrLLUt5Vfi3XFx8FEOeGA==", new DateTime(2023, 10, 24, 1, 26, 40, 243, DateTimeKind.Utc).AddTicks(5636) },
                    { 60, new DateTime(2023, 10, 24, 1, 26, 40, 312, DateTimeKind.Utc).AddTicks(4739), "curt.volkman@email.com", "Curt", "Volkman", "AQAAAAIAAYagAAAAEDephzF9fx5xosafDpuQHTos6+ydhlseXynjoFEtCEnUyNZHOzGxlSDjcEUOjOFF4w==", new DateTime(2023, 10, 24, 1, 26, 40, 312, DateTimeKind.Utc).AddTicks(4741) },
                    { 61, new DateTime(2023, 10, 24, 1, 26, 40, 380, DateTimeKind.Utc).AddTicks(5739), "philip.larson@email.com", "Philip", "Larson", "AQAAAAIAAYagAAAAEBKLchbROy0MFzvZJnRSvW+EV32wDiE0f/rrCsM85lGFbuaQLWFWj9FMv2tM1C7QzQ==", new DateTime(2023, 10, 24, 1, 26, 40, 380, DateTimeKind.Utc).AddTicks(5740) },
                    { 62, new DateTime(2023, 10, 24, 1, 26, 40, 449, DateTimeKind.Utc).AddTicks(4986), "tyler.lueilwitz@email.com", "Tyler", "Lueilwitz", "AQAAAAIAAYagAAAAELhzI4ib2Syxi1OixfSCYLgj+JUr6/JFlQTPD4vrGjD7BK3V+tUFr+ndrweyOUf1mw==", new DateTime(2023, 10, 24, 1, 26, 40, 449, DateTimeKind.Utc).AddTicks(4987) },
                    { 63, new DateTime(2023, 10, 24, 1, 26, 40, 517, DateTimeKind.Utc).AddTicks(3737), "anais.smith@email.com", "Anais", "Smith", "AQAAAAIAAYagAAAAEISJrJtkCEhOumN3Dh3XXGgaSxbVJw4id86cghmZUEyfSx7d3bjJ1lAtJ6pokbuB+A==", new DateTime(2023, 10, 24, 1, 26, 40, 517, DateTimeKind.Utc).AddTicks(3740) },
                    { 64, new DateTime(2023, 10, 24, 1, 26, 40, 585, DateTimeKind.Utc).AddTicks(8509), "tierra.white@email.com", "Tierra", "White", "AQAAAAIAAYagAAAAEEKlneYivkAEb28bGGlFf+WXLQXkxKu06TSGw8naXAfxVHotSSWSgDd5u7hRZ5sNMw==", new DateTime(2023, 10, 24, 1, 26, 40, 585, DateTimeKind.Utc).AddTicks(8509) },
                    { 65, new DateTime(2023, 10, 24, 1, 26, 40, 654, DateTimeKind.Utc).AddTicks(3162), "helene.quitzon@email.com", "Helene", "Quitzon", "AQAAAAIAAYagAAAAEHVHc/QnA0Us9K6lHEQ2krkJ/jlk6jKFXT13IW0gcyO03tNhHE2yuqeQ/3vIfCxcLw==", new DateTime(2023, 10, 24, 1, 26, 40, 654, DateTimeKind.Utc).AddTicks(3164) },
                    { 66, new DateTime(2023, 10, 24, 1, 26, 40, 722, DateTimeKind.Utc).AddTicks(1493), "gino.volkman@email.com", "Gino", "Volkman", "AQAAAAIAAYagAAAAEDuIw51X+521+xkDmsgergIxPRIwq6S4IeVZ6xVsGMbfPW8R7/nKTVXhOCeX8MIXzA==", new DateTime(2023, 10, 24, 1, 26, 40, 722, DateTimeKind.Utc).AddTicks(1495) },
                    { 67, new DateTime(2023, 10, 24, 1, 26, 40, 790, DateTimeKind.Utc).AddTicks(2283), "mckenna.dibbert@email.com", "Mckenna", "Dibbert", "AQAAAAIAAYagAAAAEFhJXDKDEzfUM1j4RQTBnQiBSWYQVAkX0EJLj0jl6P/nbpwk8lwZKPDgrU/BEOMuTA==", new DateTime(2023, 10, 24, 1, 26, 40, 790, DateTimeKind.Utc).AddTicks(2284) },
                    { 68, new DateTime(2023, 10, 24, 1, 26, 40, 858, DateTimeKind.Utc).AddTicks(1687), "tanya.barrows@email.com", "Tanya", "Barrows", "AQAAAAIAAYagAAAAEKo7+1c/sTBc+eN5ysct8HvamBLSl2VpYbZoKDP1yboSqUeYU3Y+mmHSDUtNZiXO1w==", new DateTime(2023, 10, 24, 1, 26, 40, 858, DateTimeKind.Utc).AddTicks(1687) },
                    { 69, new DateTime(2023, 10, 24, 1, 26, 40, 925, DateTimeKind.Utc).AddTicks(293), "superuser@mail.com", "super", "user", "AQAAAAIAAYagAAAAEKc955YpLa2Li1vVs2qzZ/TYQNrgvBUwEuNHrMAFxuhrvNiFhv106vFw0T0939LE7w==", new DateTime(2023, 10, 24, 1, 26, 40, 925, DateTimeKind.Utc).AddTicks(293) }
                });

            migrationBuilder.InsertData(
                table: "UserInstruments",
                columns: new[] { "InstrumentId", "UserId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 24, 1, 26, 36, 339, DateTimeKind.Utc).AddTicks(7088), new DateTime(2023, 10, 24, 1, 26, 36, 339, DateTimeKind.Utc).AddTicks(7088) },
                    { 2, 2, new DateTime(2023, 10, 24, 1, 26, 36, 408, DateTimeKind.Utc).AddTicks(4086), new DateTime(2023, 10, 24, 1, 26, 36, 408, DateTimeKind.Utc).AddTicks(4087) },
                    { 3, 3, new DateTime(2023, 10, 24, 1, 26, 36, 476, DateTimeKind.Utc).AddTicks(6330), new DateTime(2023, 10, 24, 1, 26, 36, 476, DateTimeKind.Utc).AddTicks(6330) },
                    { 4, 4, new DateTime(2023, 10, 24, 1, 26, 36, 545, DateTimeKind.Utc).AddTicks(1674), new DateTime(2023, 10, 24, 1, 26, 36, 545, DateTimeKind.Utc).AddTicks(1674) },
                    { 5, 5, new DateTime(2023, 10, 24, 1, 26, 36, 613, DateTimeKind.Utc).AddTicks(9585), new DateTime(2023, 10, 24, 1, 26, 36, 613, DateTimeKind.Utc).AddTicks(9585) },
                    { 6, 6, new DateTime(2023, 10, 24, 1, 26, 36, 682, DateTimeKind.Utc).AddTicks(896), new DateTime(2023, 10, 24, 1, 26, 36, 682, DateTimeKind.Utc).AddTicks(896) },
                    { 7, 7, new DateTime(2023, 10, 24, 1, 26, 36, 750, DateTimeKind.Utc).AddTicks(261), new DateTime(2023, 10, 24, 1, 26, 36, 750, DateTimeKind.Utc).AddTicks(262) },
                    { 8, 8, new DateTime(2023, 10, 24, 1, 26, 36, 818, DateTimeKind.Utc).AddTicks(7691), new DateTime(2023, 10, 24, 1, 26, 36, 818, DateTimeKind.Utc).AddTicks(7691) },
                    { 9, 9, new DateTime(2023, 10, 24, 1, 26, 36, 887, DateTimeKind.Utc).AddTicks(3943), new DateTime(2023, 10, 24, 1, 26, 36, 887, DateTimeKind.Utc).AddTicks(3943) },
                    { 11, 10, new DateTime(2023, 10, 24, 1, 26, 36, 955, DateTimeKind.Utc).AddTicks(7458), new DateTime(2023, 10, 24, 1, 26, 36, 955, DateTimeKind.Utc).AddTicks(7458) },
                    { 12, 11, new DateTime(2023, 10, 24, 1, 26, 37, 23, DateTimeKind.Utc).AddTicks(6934), new DateTime(2023, 10, 24, 1, 26, 37, 23, DateTimeKind.Utc).AddTicks(6934) },
                    { 13, 12, new DateTime(2023, 10, 24, 1, 26, 37, 91, DateTimeKind.Utc).AddTicks(4801), new DateTime(2023, 10, 24, 1, 26, 37, 91, DateTimeKind.Utc).AddTicks(4801) },
                    { 14, 13, new DateTime(2023, 10, 24, 1, 26, 37, 159, DateTimeKind.Utc).AddTicks(5282), new DateTime(2023, 10, 24, 1, 26, 37, 159, DateTimeKind.Utc).AddTicks(5282) },
                    { 15, 14, new DateTime(2023, 10, 24, 1, 26, 37, 228, DateTimeKind.Utc).AddTicks(999), new DateTime(2023, 10, 24, 1, 26, 37, 228, DateTimeKind.Utc).AddTicks(999) },
                    { 17, 15, new DateTime(2023, 10, 24, 1, 26, 37, 296, DateTimeKind.Utc).AddTicks(3800), new DateTime(2023, 10, 24, 1, 26, 37, 296, DateTimeKind.Utc).AddTicks(3800) },
                    { 18, 16, new DateTime(2023, 10, 24, 1, 26, 37, 369, DateTimeKind.Utc).AddTicks(8642), new DateTime(2023, 10, 24, 1, 26, 37, 369, DateTimeKind.Utc).AddTicks(8642) },
                    { 19, 17, new DateTime(2023, 10, 24, 1, 26, 37, 439, DateTimeKind.Utc).AddTicks(7183), new DateTime(2023, 10, 24, 1, 26, 37, 439, DateTimeKind.Utc).AddTicks(7183) },
                    { 20, 18, new DateTime(2023, 10, 24, 1, 26, 37, 508, DateTimeKind.Utc).AddTicks(172), new DateTime(2023, 10, 24, 1, 26, 37, 508, DateTimeKind.Utc).AddTicks(173) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 24, 1, 26, 36, 339, DateTimeKind.Utc).AddTicks(7082), new DateTime(2023, 10, 24, 1, 26, 36, 339, DateTimeKind.Utc).AddTicks(7082) },
                    { 2, 2, new DateTime(2023, 10, 24, 1, 26, 36, 408, DateTimeKind.Utc).AddTicks(4079), new DateTime(2023, 10, 24, 1, 26, 36, 408, DateTimeKind.Utc).AddTicks(4080) },
                    { 3, 3, new DateTime(2023, 10, 24, 1, 26, 36, 476, DateTimeKind.Utc).AddTicks(6324), new DateTime(2023, 10, 24, 1, 26, 36, 476, DateTimeKind.Utc).AddTicks(6324) },
                    { 4, 4, new DateTime(2023, 10, 24, 1, 26, 36, 545, DateTimeKind.Utc).AddTicks(1668), new DateTime(2023, 10, 24, 1, 26, 36, 545, DateTimeKind.Utc).AddTicks(1668) },
                    { 5, 5, new DateTime(2023, 10, 24, 1, 26, 36, 613, DateTimeKind.Utc).AddTicks(9579), new DateTime(2023, 10, 24, 1, 26, 36, 613, DateTimeKind.Utc).AddTicks(9579) },
                    { 6, 6, new DateTime(2023, 10, 24, 1, 26, 36, 682, DateTimeKind.Utc).AddTicks(886), new DateTime(2023, 10, 24, 1, 26, 36, 682, DateTimeKind.Utc).AddTicks(887) },
                    { 7, 7, new DateTime(2023, 10, 24, 1, 26, 36, 750, DateTimeKind.Utc).AddTicks(255), new DateTime(2023, 10, 24, 1, 26, 36, 750, DateTimeKind.Utc).AddTicks(255) },
                    { 8, 8, new DateTime(2023, 10, 24, 1, 26, 36, 818, DateTimeKind.Utc).AddTicks(7682), new DateTime(2023, 10, 24, 1, 26, 36, 818, DateTimeKind.Utc).AddTicks(7682) },
                    { 9, 9, new DateTime(2023, 10, 24, 1, 26, 36, 887, DateTimeKind.Utc).AddTicks(3936), new DateTime(2023, 10, 24, 1, 26, 36, 887, DateTimeKind.Utc).AddTicks(3937) },
                    { 10, 10, new DateTime(2023, 10, 24, 1, 26, 36, 955, DateTimeKind.Utc).AddTicks(7451), new DateTime(2023, 10, 24, 1, 26, 36, 955, DateTimeKind.Utc).AddTicks(7452) },
                    { 11, 11, new DateTime(2023, 10, 24, 1, 26, 37, 23, DateTimeKind.Utc).AddTicks(6928), new DateTime(2023, 10, 24, 1, 26, 37, 23, DateTimeKind.Utc).AddTicks(6928) },
                    { 12, 12, new DateTime(2023, 10, 24, 1, 26, 37, 91, DateTimeKind.Utc).AddTicks(4794), new DateTime(2023, 10, 24, 1, 26, 37, 91, DateTimeKind.Utc).AddTicks(4795) },
                    { 13, 13, new DateTime(2023, 10, 24, 1, 26, 37, 159, DateTimeKind.Utc).AddTicks(5273), new DateTime(2023, 10, 24, 1, 26, 37, 159, DateTimeKind.Utc).AddTicks(5274) },
                    { 14, 14, new DateTime(2023, 10, 24, 1, 26, 37, 228, DateTimeKind.Utc).AddTicks(990), new DateTime(2023, 10, 24, 1, 26, 37, 228, DateTimeKind.Utc).AddTicks(990) },
                    { 15, 15, new DateTime(2023, 10, 24, 1, 26, 37, 296, DateTimeKind.Utc).AddTicks(3794), new DateTime(2023, 10, 24, 1, 26, 37, 296, DateTimeKind.Utc).AddTicks(3794) },
                    { 16, 16, new DateTime(2023, 10, 24, 1, 26, 37, 369, DateTimeKind.Utc).AddTicks(8636), new DateTime(2023, 10, 24, 1, 26, 37, 369, DateTimeKind.Utc).AddTicks(8636) },
                    { 17, 17, new DateTime(2023, 10, 24, 1, 26, 37, 439, DateTimeKind.Utc).AddTicks(7176), new DateTime(2023, 10, 24, 1, 26, 37, 439, DateTimeKind.Utc).AddTicks(7177) },
                    { 18, 18, new DateTime(2023, 10, 24, 1, 26, 37, 508, DateTimeKind.Utc).AddTicks(166), new DateTime(2023, 10, 24, 1, 26, 37, 508, DateTimeKind.Utc).AddTicks(166) },
                    { 19, 19, new DateTime(2023, 10, 24, 1, 26, 37, 576, DateTimeKind.Utc).AddTicks(4059), new DateTime(2023, 10, 24, 1, 26, 37, 576, DateTimeKind.Utc).AddTicks(4059) },
                    { 20, 20, new DateTime(2023, 10, 24, 1, 26, 37, 645, DateTimeKind.Utc).AddTicks(2804), new DateTime(2023, 10, 24, 1, 26, 37, 645, DateTimeKind.Utc).AddTicks(2804) },
                    { 21, 21, new DateTime(2023, 10, 24, 1, 26, 37, 713, DateTimeKind.Utc).AddTicks(1673), new DateTime(2023, 10, 24, 1, 26, 37, 713, DateTimeKind.Utc).AddTicks(1673) },
                    { 22, 22, new DateTime(2023, 10, 24, 1, 26, 37, 781, DateTimeKind.Utc).AddTicks(5371), new DateTime(2023, 10, 24, 1, 26, 37, 781, DateTimeKind.Utc).AddTicks(5371) },
                    { 23, 23, new DateTime(2023, 10, 24, 1, 26, 37, 849, DateTimeKind.Utc).AddTicks(8358), new DateTime(2023, 10, 24, 1, 26, 37, 849, DateTimeKind.Utc).AddTicks(8359) },
                    { 24, 24, new DateTime(2023, 10, 24, 1, 26, 37, 918, DateTimeKind.Utc).AddTicks(248), new DateTime(2023, 10, 24, 1, 26, 37, 918, DateTimeKind.Utc).AddTicks(249) },
                    { 25, 25, new DateTime(2023, 10, 24, 1, 26, 37, 986, DateTimeKind.Utc).AddTicks(1280), new DateTime(2023, 10, 24, 1, 26, 37, 986, DateTimeKind.Utc).AddTicks(1281) },
                    { 26, 26, new DateTime(2023, 10, 24, 1, 26, 38, 54, DateTimeKind.Utc).AddTicks(2147), new DateTime(2023, 10, 24, 1, 26, 38, 54, DateTimeKind.Utc).AddTicks(2148) },
                    { 27, 27, new DateTime(2023, 10, 24, 1, 26, 38, 122, DateTimeKind.Utc).AddTicks(4606), new DateTime(2023, 10, 24, 1, 26, 38, 122, DateTimeKind.Utc).AddTicks(4606) },
                    { 28, 28, new DateTime(2023, 10, 24, 1, 26, 38, 190, DateTimeKind.Utc).AddTicks(6766), new DateTime(2023, 10, 24, 1, 26, 38, 190, DateTimeKind.Utc).AddTicks(6766) },
                    { 29, 29, new DateTime(2023, 10, 24, 1, 26, 38, 258, DateTimeKind.Utc).AddTicks(9702), new DateTime(2023, 10, 24, 1, 26, 38, 258, DateTimeKind.Utc).AddTicks(9702) },
                    { 30, 30, new DateTime(2023, 10, 24, 1, 26, 38, 327, DateTimeKind.Utc).AddTicks(6048), new DateTime(2023, 10, 24, 1, 26, 38, 327, DateTimeKind.Utc).AddTicks(6048) },
                    { 31, 31, new DateTime(2023, 10, 24, 1, 26, 38, 396, DateTimeKind.Utc).AddTicks(969), new DateTime(2023, 10, 24, 1, 26, 38, 396, DateTimeKind.Utc).AddTicks(970) },
                    { 32, 32, new DateTime(2023, 10, 24, 1, 26, 38, 464, DateTimeKind.Utc).AddTicks(4072), new DateTime(2023, 10, 24, 1, 26, 38, 464, DateTimeKind.Utc).AddTicks(4073) },
                    { 33, 33, new DateTime(2023, 10, 24, 1, 26, 38, 533, DateTimeKind.Utc).AddTicks(8311), new DateTime(2023, 10, 24, 1, 26, 38, 533, DateTimeKind.Utc).AddTicks(8311) },
                    { 34, 34, new DateTime(2023, 10, 24, 1, 26, 38, 602, DateTimeKind.Utc).AddTicks(62), new DateTime(2023, 10, 24, 1, 26, 38, 602, DateTimeKind.Utc).AddTicks(62) },
                    { 35, 35, new DateTime(2023, 10, 24, 1, 26, 38, 669, DateTimeKind.Utc).AddTicks(7673), new DateTime(2023, 10, 24, 1, 26, 38, 669, DateTimeKind.Utc).AddTicks(7673) },
                    { 36, 36, new DateTime(2023, 10, 24, 1, 26, 38, 737, DateTimeKind.Utc).AddTicks(8905), new DateTime(2023, 10, 24, 1, 26, 38, 737, DateTimeKind.Utc).AddTicks(8905) },
                    { 37, 37, new DateTime(2023, 10, 24, 1, 26, 38, 805, DateTimeKind.Utc).AddTicks(9293), new DateTime(2023, 10, 24, 1, 26, 38, 805, DateTimeKind.Utc).AddTicks(9293) },
                    { 38, 38, new DateTime(2023, 10, 24, 1, 26, 38, 874, DateTimeKind.Utc).AddTicks(2435), new DateTime(2023, 10, 24, 1, 26, 38, 874, DateTimeKind.Utc).AddTicks(2436) },
                    { 39, 39, new DateTime(2023, 10, 24, 1, 26, 38, 942, DateTimeKind.Utc).AddTicks(4446), new DateTime(2023, 10, 24, 1, 26, 38, 942, DateTimeKind.Utc).AddTicks(4446) },
                    { 40, 40, new DateTime(2023, 10, 24, 1, 26, 39, 10, DateTimeKind.Utc).AddTicks(7267), new DateTime(2023, 10, 24, 1, 26, 39, 10, DateTimeKind.Utc).AddTicks(7268) },
                    { 41, 41, new DateTime(2023, 10, 24, 1, 26, 39, 79, DateTimeKind.Utc).AddTicks(1436), new DateTime(2023, 10, 24, 1, 26, 39, 79, DateTimeKind.Utc).AddTicks(1436) },
                    { 42, 42, new DateTime(2023, 10, 24, 1, 26, 39, 147, DateTimeKind.Utc).AddTicks(1585), new DateTime(2023, 10, 24, 1, 26, 39, 147, DateTimeKind.Utc).AddTicks(1585) },
                    { 43, 43, new DateTime(2023, 10, 24, 1, 26, 39, 215, DateTimeKind.Utc).AddTicks(7007), new DateTime(2023, 10, 24, 1, 26, 39, 215, DateTimeKind.Utc).AddTicks(7007) },
                    { 44, 44, new DateTime(2023, 10, 24, 1, 26, 39, 283, DateTimeKind.Utc).AddTicks(9850), new DateTime(2023, 10, 24, 1, 26, 39, 283, DateTimeKind.Utc).AddTicks(9850) },
                    { 45, 45, new DateTime(2023, 10, 24, 1, 26, 39, 352, DateTimeKind.Utc).AddTicks(5523), new DateTime(2023, 10, 24, 1, 26, 39, 352, DateTimeKind.Utc).AddTicks(5524) },
                    { 46, 46, new DateTime(2023, 10, 24, 1, 26, 39, 421, DateTimeKind.Utc).AddTicks(1103), new DateTime(2023, 10, 24, 1, 26, 39, 421, DateTimeKind.Utc).AddTicks(1103) },
                    { 47, 47, new DateTime(2023, 10, 24, 1, 26, 39, 490, DateTimeKind.Utc).AddTicks(375), new DateTime(2023, 10, 24, 1, 26, 39, 490, DateTimeKind.Utc).AddTicks(375) },
                    { 48, 48, new DateTime(2023, 10, 24, 1, 26, 39, 557, DateTimeKind.Utc).AddTicks(8266), new DateTime(2023, 10, 24, 1, 26, 39, 557, DateTimeKind.Utc).AddTicks(8267) },
                    { 49, 49, new DateTime(2023, 10, 24, 1, 26, 39, 625, DateTimeKind.Utc).AddTicks(9477), new DateTime(2023, 10, 24, 1, 26, 39, 625, DateTimeKind.Utc).AddTicks(9477) },
                    { 50, 50, new DateTime(2023, 10, 24, 1, 26, 39, 693, DateTimeKind.Utc).AddTicks(8868), new DateTime(2023, 10, 24, 1, 26, 39, 693, DateTimeKind.Utc).AddTicks(8868) },
                    { 51, 51, new DateTime(2023, 10, 24, 1, 26, 39, 762, DateTimeKind.Utc).AddTicks(774), new DateTime(2023, 10, 24, 1, 26, 39, 762, DateTimeKind.Utc).AddTicks(775) },
                    { 52, 52, new DateTime(2023, 10, 24, 1, 26, 39, 831, DateTimeKind.Utc).AddTicks(4099), new DateTime(2023, 10, 24, 1, 26, 39, 831, DateTimeKind.Utc).AddTicks(4099) },
                    { 53, 53, new DateTime(2023, 10, 24, 1, 26, 39, 900, DateTimeKind.Utc).AddTicks(4816), new DateTime(2023, 10, 24, 1, 26, 39, 900, DateTimeKind.Utc).AddTicks(4816) },
                    { 54, 54, new DateTime(2023, 10, 24, 1, 26, 39, 968, DateTimeKind.Utc).AddTicks(9236), new DateTime(2023, 10, 24, 1, 26, 39, 968, DateTimeKind.Utc).AddTicks(9236) },
                    { 55, 55, new DateTime(2023, 10, 24, 1, 26, 40, 37, DateTimeKind.Utc).AddTicks(1514), new DateTime(2023, 10, 24, 1, 26, 40, 37, DateTimeKind.Utc).AddTicks(1514) },
                    { 56, 56, new DateTime(2023, 10, 24, 1, 26, 40, 105, DateTimeKind.Utc).AddTicks(2553), new DateTime(2023, 10, 24, 1, 26, 40, 105, DateTimeKind.Utc).AddTicks(2553) },
                    { 57, 57, new DateTime(2023, 10, 24, 1, 26, 40, 173, DateTimeKind.Utc).AddTicks(5113), new DateTime(2023, 10, 24, 1, 26, 40, 173, DateTimeKind.Utc).AddTicks(5113) },
                    { 58, 58, new DateTime(2023, 10, 24, 1, 26, 40, 242, DateTimeKind.Utc).AddTicks(2505), new DateTime(2023, 10, 24, 1, 26, 40, 242, DateTimeKind.Utc).AddTicks(2505) },
                    { 59, 59, new DateTime(2023, 10, 24, 1, 26, 40, 311, DateTimeKind.Utc).AddTicks(49), new DateTime(2023, 10, 24, 1, 26, 40, 311, DateTimeKind.Utc).AddTicks(49) },
                    { 60, 60, new DateTime(2023, 10, 24, 1, 26, 40, 379, DateTimeKind.Utc).AddTicks(2490), new DateTime(2023, 10, 24, 1, 26, 40, 379, DateTimeKind.Utc).AddTicks(2490) },
                    { 61, 61, new DateTime(2023, 10, 24, 1, 26, 40, 448, DateTimeKind.Utc).AddTicks(1002), new DateTime(2023, 10, 24, 1, 26, 40, 448, DateTimeKind.Utc).AddTicks(1002) },
                    { 62, 62, new DateTime(2023, 10, 24, 1, 26, 40, 516, DateTimeKind.Utc).AddTicks(604), new DateTime(2023, 10, 24, 1, 26, 40, 516, DateTimeKind.Utc).AddTicks(605) },
                    { 63, 63, new DateTime(2023, 10, 24, 1, 26, 40, 584, DateTimeKind.Utc).AddTicks(5303), new DateTime(2023, 10, 24, 1, 26, 40, 584, DateTimeKind.Utc).AddTicks(5303) },
                    { 64, 64, new DateTime(2023, 10, 24, 1, 26, 40, 652, DateTimeKind.Utc).AddTicks(9275), new DateTime(2023, 10, 24, 1, 26, 40, 652, DateTimeKind.Utc).AddTicks(9275) },
                    { 65, 65, new DateTime(2023, 10, 24, 1, 26, 40, 720, DateTimeKind.Utc).AddTicks(8076), new DateTime(2023, 10, 24, 1, 26, 40, 720, DateTimeKind.Utc).AddTicks(8077) },
                    { 66, 66, new DateTime(2023, 10, 24, 1, 26, 40, 788, DateTimeKind.Utc).AddTicks(9130), new DateTime(2023, 10, 24, 1, 26, 40, 788, DateTimeKind.Utc).AddTicks(9130) },
                    { 67, 67, new DateTime(2023, 10, 24, 1, 26, 40, 856, DateTimeKind.Utc).AddTicks(7922), new DateTime(2023, 10, 24, 1, 26, 40, 856, DateTimeKind.Utc).AddTicks(7922) },
                    { 68, 68, new DateTime(2023, 10, 24, 1, 26, 40, 925, DateTimeKind.Utc).AddTicks(132), new DateTime(2023, 10, 24, 1, 26, 40, 925, DateTimeKind.Utc).AddTicks(132) },
                    { 70, 69, new DateTime(2023, 10, 24, 1, 26, 40, 991, DateTimeKind.Utc).AddTicks(9584), new DateTime(2023, 10, 24, 1, 26, 40, 991, DateTimeKind.Utc).AddTicks(9585) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_InstrumentId",
                table: "Lessons",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_StudentId",
                table: "Lessons",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_TeacherId",
                table: "Lessons",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInstruments_InstrumentId",
                table: "UserInstruments",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "UserInstruments");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
