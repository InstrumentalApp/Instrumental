using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class DBRestructure : Migration
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
                    { 1, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8080), "Keyboard", "Piano", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8080) },
                    { 2, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8250), "String", "Guitar", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8250) },
                    { 3, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8270), "Woodwind", "Flute", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8270) },
                    { 4, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8280), "Percussion", "Drums", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8280) },
                    { 5, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8320), "String", "Violin", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8320) },
                    { 6, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8330), "Brass", "Trumpet", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8330) },
                    { 7, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8350), "Woodwind", "Saxophone", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8350) },
                    { 8, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8360), "String", "Bass Guitar", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8360) },
                    { 9, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8380), "Woodwind", "Clarinet", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8380) },
                    { 11, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8390), "Brass", "Trombone", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8390) },
                    { 12, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8420), "String", "Harp", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8420) },
                    { 13, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8430), "Percussion", "Vibrophone", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8430) },
                    { 14, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8450), "Woodwind", "Oboe", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8450) },
                    { 15, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8460), "Woodwind", "Bassoon", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8460) },
                    { 17, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8470), "String", "Classical Guitar", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8470) },
                    { 18, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8500), "Brass", "French Horn", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8500) },
                    { 19, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8510), "Keyboard", "Accordion", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8510) },
                    { 20, new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8520), "String", "Cello", new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8520) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Bio", "CreatedAt", "RoleType", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610), 0, new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610) },
                    { 2, null, new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2700), 0, new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2700) },
                    { 3, null, new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7300), 0, new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7300) },
                    { 4, null, new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220), 0, new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220) },
                    { 5, null, new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2030), 0, new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2030) },
                    { 6, null, new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1910), 0, new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1910) },
                    { 7, null, new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830), 0, new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830) },
                    { 8, null, new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110), 0, new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110) },
                    { 9, null, new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1980), 0, new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1980) },
                    { 10, null, new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300), 0, new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300) },
                    { 11, null, new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8440), 0, new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8440) },
                    { 12, null, new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6630), 0, new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6630) },
                    { 13, null, new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8210), 0, new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8210) },
                    { 14, null, new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8490), 0, new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8490) },
                    { 15, null, new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8500), 0, new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8500) },
                    { 16, null, new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8520), 0, new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8520) },
                    { 17, null, new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410), 0, new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410) },
                    { 18, null, new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4070), 0, new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4070) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 11, 15, 48, 34, 957, DateTimeKind.Utc).AddTicks(9030), "ole.gerlach@email.com", "Ole", "Gerlach", "AQAAAAIAAYagAAAAEFRW7f4APJR2wirXSe1QDlv/yqswzbiiTldFe3TE+Tq+lwmYYG2jhdWUf8PVZF0lsQ==", new DateTime(2023, 10, 11, 15, 48, 34, 957, DateTimeKind.Utc).AddTicks(9030) },
                    { 2, new DateTime(2023, 10, 11, 15, 48, 35, 22, DateTimeKind.Utc).AddTicks(5680), "tianna.auer@email.com", "Tianna", "Auer", "AQAAAAIAAYagAAAAEHaKHnnl/QZ006XLCBFlCl8/EO5wscRXRqF5wU8mj1hOoKtVrJi6K1YFE1YgwSyAWQ==", new DateTime(2023, 10, 11, 15, 48, 35, 22, DateTimeKind.Utc).AddTicks(5680) },
                    { 3, new DateTime(2023, 10, 11, 15, 48, 35, 87, DateTimeKind.Utc).AddTicks(2630), "abraham.reinger@email.com", "Abraham", "Reinger", "AQAAAAIAAYagAAAAEH+69RcAoFUxHTmLA99AY1WXuqj/8L8/Sg4tXv/deS9carq3LxF9Wb5+Qn+jzyXJRA==", new DateTime(2023, 10, 11, 15, 48, 35, 87, DateTimeKind.Utc).AddTicks(2630) },
                    { 4, new DateTime(2023, 10, 11, 15, 48, 35, 154, DateTimeKind.Utc).AddTicks(6180), "antonietta.weimann@email.com", "Antonietta", "Weimann", "AQAAAAIAAYagAAAAEKqtYXir+0672KBdJY0HdIG27B9yh/7lXkKN+2yZS3WzYuz+ZPmtkXP84bsG3guwQQ==", new DateTime(2023, 10, 11, 15, 48, 35, 154, DateTimeKind.Utc).AddTicks(6180) },
                    { 5, new DateTime(2023, 10, 11, 15, 48, 35, 220, DateTimeKind.Utc).AddTicks(2810), "creola.luettgen@email.com", "Creola", "Luettgen", "AQAAAAIAAYagAAAAEMgNEAlKcGEqyZ9piN4iBQ4pYcPonzyzFkk6YGln+MzIk6d5QofvqzUAv/9q4DDcCA==", new DateTime(2023, 10, 11, 15, 48, 35, 220, DateTimeKind.Utc).AddTicks(2810) },
                    { 6, new DateTime(2023, 10, 11, 15, 48, 35, 284, DateTimeKind.Utc).AddTicks(1840), "darrick.ankunding@email.com", "Darrick", "Ankunding", "AQAAAAIAAYagAAAAEMEzSEl8vI0DZexH1cpZIaq4EivxyBoD/nvEzkjMrUqqBw1ZoEZOaS4UduP2Y+0btQ==", new DateTime(2023, 10, 11, 15, 48, 35, 284, DateTimeKind.Utc).AddTicks(1840) },
                    { 7, new DateTime(2023, 10, 11, 15, 48, 35, 349, DateTimeKind.Utc).AddTicks(3850), "marcelino.spencer@email.com", "Marcelino", "Spencer", "AQAAAAIAAYagAAAAEAJKiMxKLlCXd4NfLJv5/L/8VZTpHKnFHEcKcIxsuLyQPbSL127URefd6eMIowstzA==", new DateTime(2023, 10, 11, 15, 48, 35, 349, DateTimeKind.Utc).AddTicks(3850) },
                    { 8, new DateTime(2023, 10, 11, 15, 48, 35, 414, DateTimeKind.Utc).AddTicks(2150), "penelope.grady@email.com", "Penelope", "Grady", "AQAAAAIAAYagAAAAEOUq6MYwPytaN+ztZ9B1j9PnhQdupze6qkGGQiuPjXFxYlZM/JbkXU741/464mIrYA==", new DateTime(2023, 10, 11, 15, 48, 35, 414, DateTimeKind.Utc).AddTicks(2150) },
                    { 9, new DateTime(2023, 10, 11, 15, 48, 35, 478, DateTimeKind.Utc).AddTicks(9760), "sandy.christiansen@email.com", "Sandy", "Christiansen", "AQAAAAIAAYagAAAAEBqxGbd1CU1zbRpvSzaJTrDKNSk3vUzmu9hslLu1wmkpD0jIANtnHY5MTAExKvEK5A==", new DateTime(2023, 10, 11, 15, 48, 35, 478, DateTimeKind.Utc).AddTicks(9760) },
                    { 10, new DateTime(2023, 10, 11, 15, 48, 35, 545, DateTimeKind.Utc).AddTicks(2910), "gerry.morar@email.com", "Gerry", "Morar", "AQAAAAIAAYagAAAAENCY78d0hUlweeASiiX46w4aSU3RhDzTCXv/Ki5wOHrJNolfF5E01OEtr7q8462iag==", new DateTime(2023, 10, 11, 15, 48, 35, 545, DateTimeKind.Utc).AddTicks(2910) },
                    { 11, new DateTime(2023, 10, 11, 15, 48, 35, 609, DateTimeKind.Utc).AddTicks(7430), "louvenia.herzog@email.com", "Louvenia", "Herzog", "AQAAAAIAAYagAAAAECyp6FYwAL4HbBKEl7YXKi5vuMyDzCtH5Hkxt2AgGn5UgenXSY35XmqEr/NwufISRQ==", new DateTime(2023, 10, 11, 15, 48, 35, 609, DateTimeKind.Utc).AddTicks(7430) },
                    { 12, new DateTime(2023, 10, 11, 15, 48, 35, 673, DateTimeKind.Utc).AddTicks(8580), "luciano.emard@email.com", "Luciano", "Emard", "AQAAAAIAAYagAAAAEOhOEtwuFpw8KJyxYJyE1RyTPGqG7fnaJvgwuP5bqh1cFPvXQ9iJlsWxGEVdras5JQ==", new DateTime(2023, 10, 11, 15, 48, 35, 673, DateTimeKind.Utc).AddTicks(8580) },
                    { 13, new DateTime(2023, 10, 11, 15, 48, 35, 738, DateTimeKind.Utc).AddTicks(5840), "keeley.marquardt@email.com", "Keeley", "Marquardt", "AQAAAAIAAYagAAAAEJNGY1sUX5VFkuwU57UAVr05TUF2M9i5oQqkMD5aDqMoWvwnFupSCca0Q9xTccK6tg==", new DateTime(2023, 10, 11, 15, 48, 35, 738, DateTimeKind.Utc).AddTicks(5840) },
                    { 14, new DateTime(2023, 10, 11, 15, 48, 35, 805, DateTimeKind.Utc).AddTicks(9330), "lincoln.cartwright@email.com", "Lincoln", "Cartwright", "AQAAAAIAAYagAAAAEEc9+2cAnC4tazMH/fKQG7eUn6CZs2leluf4B1MtNGCVVOQmYiqO6aEkqrYCpJjGJg==", new DateTime(2023, 10, 11, 15, 48, 35, 805, DateTimeKind.Utc).AddTicks(9330) },
                    { 15, new DateTime(2023, 10, 11, 15, 48, 35, 873, DateTimeKind.Utc).AddTicks(9550), "earl.kohler@email.com", "Earl", "Kohler", "AQAAAAIAAYagAAAAEDeucBNkcFJ3AotIuNYR13a6rrwLUCr6QPP39UN0IHYxpyL4dCm0OGOmM7+Y3su/eg==", new DateTime(2023, 10, 11, 15, 48, 35, 873, DateTimeKind.Utc).AddTicks(9550) },
                    { 16, new DateTime(2023, 10, 11, 15, 48, 35, 945, DateTimeKind.Utc).AddTicks(6290), "brad.goyette@email.com", "Brad", "Goyette", "AQAAAAIAAYagAAAAEGbfbRuuY8fC6xWAsYt+FIWjQJlN5VwJRO1RcZKBB1NMm41JV3kUGtYpYj4RYJiRmA==", new DateTime(2023, 10, 11, 15, 48, 35, 945, DateTimeKind.Utc).AddTicks(6290) },
                    { 17, new DateTime(2023, 10, 11, 15, 48, 36, 17, DateTimeKind.Utc).AddTicks(4900), "nellie.ryan@email.com", "Nellie", "Ryan", "AQAAAAIAAYagAAAAEJ5Nsjv2mAsdDEq1JeORXtmiLGU+XsKto7cBAYA5qGWXDSI/MjFq//GJwQGgjwz1EA==", new DateTime(2023, 10, 11, 15, 48, 36, 17, DateTimeKind.Utc).AddTicks(4900) },
                    { 18, new DateTime(2023, 10, 11, 15, 48, 36, 83, DateTimeKind.Utc).AddTicks(9870), "lyla.mclaughlin@email.com", "Lyla", "McLaughlin", "AQAAAAIAAYagAAAAEBqwb6G766nFpTu2UQj6exlJWRQBAPrudb4XpY3jk3eCZSKCT4N9uR7i8NJdV00LFA==", new DateTime(2023, 10, 11, 15, 48, 36, 83, DateTimeKind.Utc).AddTicks(9870) }
                });

            migrationBuilder.InsertData(
                table: "UserInstruments",
                columns: new[] { "InstrumentId", "UserId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610), new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610) },
                    { 2, 2, new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2710), new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2710) },
                    { 3, 3, new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7310), new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7310) },
                    { 4, 4, new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220), new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220) },
                    { 5, 5, new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2090), new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2090) },
                    { 6, 6, new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1920), new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1920) },
                    { 7, 7, new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830), new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830) },
                    { 8, 8, new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110), new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110) },
                    { 9, 9, new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1990), new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1990) },
                    { 11, 10, new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300), new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300) },
                    { 12, 11, new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8450), new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8450) },
                    { 13, 12, new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6640), new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6640) },
                    { 14, 13, new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8220), new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8220) },
                    { 15, 14, new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8500), new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8500) },
                    { 17, 15, new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8520), new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8520) },
                    { 18, 16, new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8530), new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8530) },
                    { 19, 17, new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410), new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410) },
                    { 20, 18, new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4080), new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4080) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610), new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610) },
                    { 2, 2, new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2710), new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2710) },
                    { 3, 3, new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7300), new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7310) },
                    { 4, 4, new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220), new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220) },
                    { 5, 5, new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2030), new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2030) },
                    { 6, 6, new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1910), new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1920) },
                    { 7, 7, new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830), new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830) },
                    { 8, 8, new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110), new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110) },
                    { 9, 9, new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1980), new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1980) },
                    { 10, 10, new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300), new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300) },
                    { 11, 11, new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8450), new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8450) },
                    { 12, 12, new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6630), new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6630) },
                    { 13, 13, new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8210) },
                    { 14, 14, new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8500), new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8500) },
                    { 15, 15, new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8510), new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8510) },
                    { 16, 16, new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8520), new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8520) },
                    { 17, 17, new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410), new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410) },
                    { 18, 18, new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4080), new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4080) }
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
