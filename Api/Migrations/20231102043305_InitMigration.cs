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
                    ImageUrl = table.Column<string>(type: "longtext", nullable: false)
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
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleType = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Roles_Users_UserId",
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

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "CreatedAt", "Family", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7089), "String", "/client/assets/instrument-pictures/acousticguitar.jpg", "Acoustic Guitar", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7090) },
                    { 2, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7400), "String", "/client/assets/instrument-pictures/autoharp.jpg", "Autoharp", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7401) },
                    { 3, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7427), "String", "/client/assets/instrument-pictures/violin.jpg", "Violin", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7427) },
                    { 4, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7465), "String", "/client/assets/instrument-pictures/cello.jpg", "Cello", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7465) },
                    { 5, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7483), "String", "/client/assets/instrument-pictures/banjo.jpg", "Banjo", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7483) },
                    { 6, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7512), "String", "/client/assets/instrument-pictures/yamatogoto.jpg", "Yamatogoto", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7513) },
                    { 7, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7535), "String", "/client/assets/instrument-pictures/tambura.jpg", "Tambura", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7535) },
                    { 8, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7550), "String", "/client/assets/instrument-pictures/vina.jpg", "Vina", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7551) },
                    { 9, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7573), "String", "/client/assets/instrument-pictures/sitar.jpg", "Sitar", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7573) },
                    { 10, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7590), "String", "/client/assets/instrument-pictures/tar.jpg", "Tar", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7590) },
                    { 11, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7631), "String", "/client/assets/instrument-pictures/biwa.jpg", "Biwa", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7631) },
                    { 12, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7647), "String", "/client/assets/instrument-pictures/dulcimer.jpg", "Dulcimer", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7648) },
                    { 13, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7668), "String", "/client/assets/instrument-pictures/fiddle.jpg", "Fiddle", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7669) },
                    { 14, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7684), "String", "/client/assets/instrument-pictures/kora.jpg", "Kora", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7684) },
                    { 15, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7710), "String", "/client/assets/instrument-pictures/koto.jpg", "Koto", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7710) },
                    { 16, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7741), "String", "/client/assets/instrument-pictures/lute.jpg", "Lute", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7741) },
                    { 17, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7757), "String", "/client/assets/instrument-pictures/lyre.jpg", "Lyre", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7758) },
                    { 18, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7773), "String", "/client/assets/instrument-pictures/mandolin.jpg", "Mandolin", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7773) },
                    { 19, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7788), "String", "/client/assets/instrument-pictures/setar.jpg", "Setar", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7789) },
                    { 20, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7805), "String", "/client/assets/instrument-pictures/ukulele.jpg", "Ukulele", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7805) },
                    { 21, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7820), "String", "/client/assets/instrument-pictures/shamisen.jpg", "Shamisen", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7820) },
                    { 22, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7873), "String", "/client/assets/instrument-pictures/zither.jpg", "Zither", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7873) },
                    { 23, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7891), "Woodwind", "/client/assets/instrument-pictures/flute.jpg", "Flute", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7891) },
                    { 24, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7907), "Woodwind", "/client/assets/instrument-pictures/clarinet.jpg", "Clarinet", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7907) },
                    { 25, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7921), "Woodwind", "/client/assets/instrument-pictures/saxophone.jpg", "Saxophone", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7922) },
                    { 26, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7940), "Woodwind", "/client/assets/instrument-pictures/oboe.jpg", "Oboe", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7940) },
                    { 27, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7953), "Woodwind", "/client/assets/instrument-pictures/bassoon.jpg", "Bassoon", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7954) },
                    { 28, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7970), "Woodwind", "/client/assets/instrument-pictures/contrabassoon.jpg", "Contrabassoon", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7970) },
                    { 29, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7992), "Woodwind", "/client/assets/instrument-pictures/englishhorn.jpg", "English Horn", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(7992) },
                    { 30, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8023), "Woodwind", "/client/assets/instrument-pictures/piccolo.jpg", "Piccolo", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8023) },
                    { 31, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8102), "Keyboard", "/client/assets/instrument-pictures/piano.jpg", "Piano", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8102) },
                    { 32, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8118), "Keyboard", "/client/assets/instrument-pictures/synthesizer.jpg", "Keyboard/Synthesizer", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8118) },
                    { 33, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8134), "Keyboard", "/client/assets/instrument-pictures/organ.jpg", "Organ", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8134) },
                    { 34, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8150), "Keyboard", "/client/assets/instrument-pictures/accordion.jpg", "Accordion", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8150) },
                    { 35, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8164), "Keyboard", "/client/assets/instrument-pictures/celesta.jpg", "Celesta", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8164) },
                    { 36, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8180), "Keyboard", "/client/assets/instrument-pictures/harpsichord.jpg", "Harpsichord", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8181) },
                    { 37, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8195), "Electronic", "/client/assets/instrument-pictures/theremin.jpg", "Theremin", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8195) },
                    { 38, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8212), "Vocal", "/client/assets/instrument-pictures/microphone.jpg", "Beatboxing", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8212) },
                    { 39, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8228), "Vocal", "/client/assets/instrument-pictures/microphone.jpg", "Tuvan Throat Singing", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8228) },
                    { 40, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8244), "Vocal", "/client/assets/instrument-pictures/microphone.jpg", "Yodeling", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8244) },
                    { 41, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8259), "Vocal", "/client/assets/instrument-pictures/microphone.jpg", "Singing", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8259) },
                    { 42, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8273), "Percussion", "/client/assets/instrument-pictures/chimes.jpg", "Chimes", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8274) },
                    { 43, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8290), "Percussion", "/client/assets/instrument-pictures/drum.jpg", "Drum Kit", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8290) },
                    { 44, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8336), "Percussion", "/client/assets/instrument-pictures/snaredrum.jpg", "Snare Drum", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8336) },
                    { 45, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8354), "Percussion", "/client/assets/instrument-pictures/bassdrum.jpg", "Bass Drum", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8354) },
                    { 46, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8368), "Percussion", "/client/assets/instrument-pictures/djembe.jpg", "Djembe", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8368) },
                    { 47, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8384), "Percussion", "/client/assets/instrument-pictures/marimba.jpg", "Marimba", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8384) },
                    { 48, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8399), "Percussion", "/client/assets/instrument-pictures/xylophone.jpg", "Xylophone", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8399) },
                    { 49, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8415), "Percussion", "/client/assets/instrument-pictures/steeldrum.jpg", "Steel Drum", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8415) },
                    { 50, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8429), "Percussion", "/client/assets/instrument-pictures/taiko.jpg", "Taiko Drum", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8430) },
                    { 51, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8445), "Percussion", "/client/assets/instrument-pictures/bodhran.jpg", "Bodhrán", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8446) },
                    { 52, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8461), "Percussion", "/client/assets/instrument-pictures/congas.jpg", "Congas", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8461) },
                    { 53, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8477), "Percussion", "/client/assets/instrument-pictures/cymbals.jpg", "Cymbals", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8477) },
                    { 54, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8491), "Percussion", "/client/assets/instrument-pictures/dadaiko.jpg", "Da-daiko", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8491) },
                    { 55, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8506), "Percussion", "/client/assets/instrument-pictures/glockenspiel.jpg", "Glockenspiel", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8507) },
                    { 56, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8520), "Percussion", "/client/assets/instrument-pictures/gong.jpg", "Gong", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8521) },
                    { 57, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8537), "Percussion", "/client/assets/instrument-pictures/kettledrum.jpg", "Kettle Drum", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8537) },
                    { 58, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8551), "Percussion", "/client/assets/instrument-pictures/maracas.jpg", "Maracas", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8552) },
                    { 59, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8567), "Percussion", "/client/assets/instrument-pictures/marimba.jpg", "Marimba", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8567) },
                    { 60, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8581), "Percussion", "/client/assets/instrument-pictures/mbira.jpg", "Mbira", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8581) },
                    { 61, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8597), "Percussion", "/client/assets/instrument-pictures/metallophone.jpg", "Metallophone", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8598) },
                    { 62, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8611), "Percussion", "/client/assets/instrument-pictures/atumpan.jpg", "Atumpan", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8612) },
                    { 63, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8627), "Percussion", "/client/assets/instrument-pictures/bells.jpg", "Bells", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8628) },
                    { 64, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8641), "Perscussion", "/client/assets/instrument-pictures/claves.jpg", "Claves", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8641) },
                    { 65, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8657), "Brass", "/client/assets/instrument-pictures/tuba.jpg", "Tuba", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8657) },
                    { 66, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8706), "Brass", "/client/assets/instrument-pictures/trumpet.jpg", "Trumpet", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8707) },
                    { 67, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8722), "Brass", "/client/assets/instrument-pictures/cornet.jpg", "Cornet", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8722) },
                    { 68, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8738), "Brass", "/client/assets/instrument-pictures/trombone.jpg", "Trombone", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8738) },
                    { 69, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8753), "Brass", "/client/assets/instrument-pictures/frenchhorn.jpg", "French Horn", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8753) },
                    { 70, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8767), "Wind", "/client/assets/instrument-pictures/bagpipe.jpg", "Bagpipe", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8768) },
                    { 71, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8783), "Wind", "/client/assets/instrument-pictures/concertina.jpg", "Concertina", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8783) },
                    { 72, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8797), "Wind", "/client/assets/instrument-pictures/harmonica.jpg", "Harmonica", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8797) },
                    { 73, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8813), "Wind", "/client/assets/instrument-pictures/nohkan.jpg", "Nohkan", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8813) },
                    { 74, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8827), "Wind", "/client/assets/instrument-pictures/recorder.jpg", "Recorder", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8828) },
                    { 75, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8842), "Wind", "/client/assets/instrument-pictures/shakuhachi.jpg", "Shakuhachi", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8842) },
                    { 76, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8857), "Wind", "/client/assets/instrument-pictures/venu.jpg", "Venu", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8857) },
                    { 77, new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8871), "Wind", "/client/assets/instrument-pictures/didgeridoo.jpg", "Didgeridoo", new DateTime(2023, 11, 2, 4, 32, 57, 168, DateTimeKind.Utc).AddTicks(8871) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 2, 4, 32, 57, 170, DateTimeKind.Utc).AddTicks(2074), "jarred.keeling@email.com", "Jarred", "Keeling", "AQAAAAIAAYagAAAAEOCx3PtyjV7z+jIh6XPXXU5K5pVBp2SrFk9uv0KOijK3ZtEnHKUU+xEZFNtYnH09zA==", new DateTime(2023, 11, 2, 4, 32, 57, 170, DateTimeKind.Utc).AddTicks(2075) },
                    { 2, new DateTime(2023, 11, 2, 4, 32, 57, 242, DateTimeKind.Utc).AddTicks(2381), "gia.harvey@email.com", "Gia", "Harvey", "AQAAAAIAAYagAAAAEKVeVVQx8bS58lZC6He1kDBtYlIgdVgL5EHHrjMMtga9lQMKvGnbUuhx8tQ8AWW4VA==", new DateTime(2023, 11, 2, 4, 32, 57, 242, DateTimeKind.Utc).AddTicks(2383) },
                    { 3, new DateTime(2023, 11, 2, 4, 32, 57, 309, DateTimeKind.Utc).AddTicks(9750), "frida.brown@email.com", "Frida", "Brown", "AQAAAAIAAYagAAAAECzMtQ9bepNfbcGZr8sWVD5OGes4NtCZQfuC+L2ctjdDusnRvbTR7aTRVbcL+amF1A==", new DateTime(2023, 11, 2, 4, 32, 57, 309, DateTimeKind.Utc).AddTicks(9751) },
                    { 4, new DateTime(2023, 11, 2, 4, 32, 57, 378, DateTimeKind.Utc).AddTicks(1848), "donna.mraz@email.com", "Donna", "Mraz", "AQAAAAIAAYagAAAAENtbmpmkl6iqBtgR95FYK838VYHrKsgREYDSwOufL442P0uECHW+tyGNdjPcAHwdHA==", new DateTime(2023, 11, 2, 4, 32, 57, 378, DateTimeKind.Utc).AddTicks(1850) },
                    { 5, new DateTime(2023, 11, 2, 4, 32, 57, 446, DateTimeKind.Utc).AddTicks(3767), "derick.feest@email.com", "Derick", "Feest", "AQAAAAIAAYagAAAAEKVisWVaL4/kvClcssmGuHt6zYv6cokdS0vTLH2MK4gXPwvyLgYLWHEaxlFyIjon4A==", new DateTime(2023, 11, 2, 4, 32, 57, 446, DateTimeKind.Utc).AddTicks(3768) },
                    { 6, new DateTime(2023, 11, 2, 4, 32, 57, 513, DateTimeKind.Utc).AddTicks(9162), "westley.larson@email.com", "Westley", "Larson", "AQAAAAIAAYagAAAAEPADXMhU/UB/YBTofCdwy2W6FSuZKo/wBljVikrte/1Ft/sHQBuq9mcLjnMRT4L0JA==", new DateTime(2023, 11, 2, 4, 32, 57, 513, DateTimeKind.Utc).AddTicks(9164) },
                    { 7, new DateTime(2023, 11, 2, 4, 32, 57, 581, DateTimeKind.Utc).AddTicks(3962), "jerod.kovacek@email.com", "Jerod", "Kovacek", "AQAAAAIAAYagAAAAED9pChXc3CifiHAOFD8p3gycIc5Z7DYDp1lwzTyV9OLGaSHSqgXzzILh/xj6qKrqMw==", new DateTime(2023, 11, 2, 4, 32, 57, 581, DateTimeKind.Utc).AddTicks(3963) },
                    { 8, new DateTime(2023, 11, 2, 4, 32, 57, 648, DateTimeKind.Utc).AddTicks(6811), "leola.runolfsdottir@email.com", "Leola", "Runolfsdottir", "AQAAAAIAAYagAAAAEOfGd3w5zoJZL1jUWe2On2ZC1f4Ddw8QrTGQznZ6qc0utV7WhEg91QhRR2AaQIAZZg==", new DateTime(2023, 11, 2, 4, 32, 57, 648, DateTimeKind.Utc).AddTicks(6815) },
                    { 9, new DateTime(2023, 11, 2, 4, 32, 57, 715, DateTimeKind.Utc).AddTicks(9651), "shea.kassulke@email.com", "Shea", "Kassulke", "AQAAAAIAAYagAAAAEDjFzI9ZpEEjCzU+eC57G68ZVovYmO8sr514iMeOxjNFDA5CF43o3M2MTo3v9ESzGg==", new DateTime(2023, 11, 2, 4, 32, 57, 715, DateTimeKind.Utc).AddTicks(9652) },
                    { 10, new DateTime(2023, 11, 2, 4, 32, 57, 783, DateTimeKind.Utc).AddTicks(8730), "jermaine.spencer@email.com", "Jermaine", "Spencer", "AQAAAAIAAYagAAAAEEgvsadTVYccxIZNir7tqEu7/LK2B9NYIXfITQd4tUrbM7YBD0YhGPtvI2XPYB9y7Q==", new DateTime(2023, 11, 2, 4, 32, 57, 783, DateTimeKind.Utc).AddTicks(8731) },
                    { 11, new DateTime(2023, 11, 2, 4, 32, 57, 851, DateTimeKind.Utc).AddTicks(3418), "emerson.howe@email.com", "Emerson", "Howe", "AQAAAAIAAYagAAAAEDAiulW4njn9i28QhNB4UQGp78HzoyxpypPD4u9MA7hPqLL8HD/UCX8xdbpcVLWBiw==", new DateTime(2023, 11, 2, 4, 32, 57, 851, DateTimeKind.Utc).AddTicks(3419) },
                    { 12, new DateTime(2023, 11, 2, 4, 32, 57, 919, DateTimeKind.Utc).AddTicks(3110), "otis.mills@email.com", "Otis", "Mills", "AQAAAAIAAYagAAAAENMM3adeyG4iozk9xYBi/NiIoWRnt7tfszMIQ00hhA1TCcVmjj9Ujm1hurd7agprJw==", new DateTime(2023, 11, 2, 4, 32, 57, 919, DateTimeKind.Utc).AddTicks(3111) },
                    { 13, new DateTime(2023, 11, 2, 4, 32, 57, 987, DateTimeKind.Utc).AddTicks(5625), "francisco.baumbach@email.com", "Francisco", "Baumbach", "AQAAAAIAAYagAAAAEJUM8gP3vTeNl+orgssieOYA9hV7vLmA5xZQelO0fIx1wNElGGMDzEIKb/A1+RrWZQ==", new DateTime(2023, 11, 2, 4, 32, 57, 987, DateTimeKind.Utc).AddTicks(5625) },
                    { 14, new DateTime(2023, 11, 2, 4, 32, 58, 55, DateTimeKind.Utc).AddTicks(4767), "joanny.kris@email.com", "Joanny", "Kris", "AQAAAAIAAYagAAAAEAG+ZmHqNu7ovFCRFKYqUXDWFM1M+KZtY9GLn2qZ7VNKzg0hJP/0jdurQNGMlWXiEA==", new DateTime(2023, 11, 2, 4, 32, 58, 55, DateTimeKind.Utc).AddTicks(4772) },
                    { 15, new DateTime(2023, 11, 2, 4, 32, 58, 123, DateTimeKind.Utc).AddTicks(2389), "lisette.buckridge@email.com", "Lisette", "Buckridge", "AQAAAAIAAYagAAAAEKBUypdwX+6d+gSmr06lW9zV2JARXyBF/kwJiP9UXr0GAzln07vSRzHJfEjXA2TN9w==", new DateTime(2023, 11, 2, 4, 32, 58, 123, DateTimeKind.Utc).AddTicks(2391) },
                    { 16, new DateTime(2023, 11, 2, 4, 32, 58, 190, DateTimeKind.Utc).AddTicks(8604), "micheal.williamson@email.com", "Micheal", "Williamson", "AQAAAAIAAYagAAAAEMWlqct4bFAwEr5cd+cW74kIj0oQ+Zhsj0zTHS+B9cOy1Qqur45LZW5dZYccLJhA3Q==", new DateTime(2023, 11, 2, 4, 32, 58, 190, DateTimeKind.Utc).AddTicks(8605) },
                    { 17, new DateTime(2023, 11, 2, 4, 32, 58, 258, DateTimeKind.Utc).AddTicks(6349), "lonnie.muller@email.com", "Lonnie", "Muller", "AQAAAAIAAYagAAAAECUmTaxs7p3m/wpKrrXF4uPFeKgxYhhOsxy9vj45cR1vowZv/fedJo0fY2ZDuChEdA==", new DateTime(2023, 11, 2, 4, 32, 58, 258, DateTimeKind.Utc).AddTicks(6350) },
                    { 18, new DateTime(2023, 11, 2, 4, 32, 58, 326, DateTimeKind.Utc).AddTicks(1904), "giovani.lang@email.com", "Giovani", "Lang", "AQAAAAIAAYagAAAAEI2ni81ZiNgU/+p8N8duI8LH2xd5Lm9Ko7kW4oj+97Hl+aRp78u4WyxMi6wEQ5S8jw==", new DateTime(2023, 11, 2, 4, 32, 58, 326, DateTimeKind.Utc).AddTicks(1905) },
                    { 19, new DateTime(2023, 11, 2, 4, 32, 58, 394, DateTimeKind.Utc).AddTicks(1963), "tatyana.kohler@email.com", "Tatyana", "Kohler", "AQAAAAIAAYagAAAAEFSRjuYvH2Bk/LaymhnvzuShI2xjbJ5TpwrhV5Zqmwci+0lgPeAZ1Xc01WJhPseFRg==", new DateTime(2023, 11, 2, 4, 32, 58, 394, DateTimeKind.Utc).AddTicks(1964) },
                    { 20, new DateTime(2023, 11, 2, 4, 32, 58, 462, DateTimeKind.Utc).AddTicks(6734), "mona.kuhn@email.com", "Mona", "Kuhn", "AQAAAAIAAYagAAAAEBebrAKvhacSQMsqKQbgmuR/+qLb5bRExy/Q0bk7EdRfWc4JKzovKokqFVI3UDnk4Q==", new DateTime(2023, 11, 2, 4, 32, 58, 462, DateTimeKind.Utc).AddTicks(6735) },
                    { 21, new DateTime(2023, 11, 2, 4, 32, 58, 530, DateTimeKind.Utc).AddTicks(4769), "elena.stoltenberg@email.com", "Elena", "Stoltenberg", "AQAAAAIAAYagAAAAEDPi/jethpcu89tWMxPaYg9domX/eNMpgF16O+iDSjY5kFbgc5lQi1gGiDfhM0WSKQ==", new DateTime(2023, 11, 2, 4, 32, 58, 530, DateTimeKind.Utc).AddTicks(4770) },
                    { 22, new DateTime(2023, 11, 2, 4, 32, 58, 598, DateTimeKind.Utc).AddTicks(3303), "johnnie.kuphal@email.com", "Johnnie", "Kuphal", "AQAAAAIAAYagAAAAEDB8kRPfKZ7pBgBfrbLKFu2hd9U7F81Y4z/uuJ171B8D+zLuHJZ5qFifIMj/YvSiKw==", new DateTime(2023, 11, 2, 4, 32, 58, 598, DateTimeKind.Utc).AddTicks(3304) },
                    { 23, new DateTime(2023, 11, 2, 4, 32, 58, 666, DateTimeKind.Utc).AddTicks(5078), "jordan.hackett@email.com", "Jordan", "Hackett", "AQAAAAIAAYagAAAAEHhiMQqsAbfzS4MJKIw//lpZjUsyxSVfvrQ1DKSY7infOcIaDcI0bujvMJBe07RNaw==", new DateTime(2023, 11, 2, 4, 32, 58, 666, DateTimeKind.Utc).AddTicks(5080) },
                    { 24, new DateTime(2023, 11, 2, 4, 32, 58, 734, DateTimeKind.Utc).AddTicks(906), "karina.dubuque@email.com", "Karina", "DuBuque", "AQAAAAIAAYagAAAAEGVvZi/+3viFyzxYYrBb404nQ6xtqKPrDwrkpGmEPBjYGJ5GWbfkGkqyv0ayNuZ6Fw==", new DateTime(2023, 11, 2, 4, 32, 58, 734, DateTimeKind.Utc).AddTicks(908) },
                    { 25, new DateTime(2023, 11, 2, 4, 32, 58, 801, DateTimeKind.Utc).AddTicks(3915), "alexys.emmerich@email.com", "Alexys", "Emmerich", "AQAAAAIAAYagAAAAEEr38eST2Ra4p0jAcudm7G2Qxd316+JXkElkZetBdWIIHIdZ8TB9X4I9zTu+lXk9mw==", new DateTime(2023, 11, 2, 4, 32, 58, 801, DateTimeKind.Utc).AddTicks(3916) },
                    { 26, new DateTime(2023, 11, 2, 4, 32, 58, 868, DateTimeKind.Utc).AddTicks(8600), "marielle.hartmann@email.com", "Marielle", "Hartmann", "AQAAAAIAAYagAAAAEFMA1O8Mt/rr4kfWj71DYI2ZsW6RiVf5O6h7GttGZG+LyAQLYtlz7wLPj5slXS81EQ==", new DateTime(2023, 11, 2, 4, 32, 58, 868, DateTimeKind.Utc).AddTicks(8601) },
                    { 27, new DateTime(2023, 11, 2, 4, 32, 58, 936, DateTimeKind.Utc).AddTicks(5334), "erich.dickinson@email.com", "Erich", "Dickinson", "AQAAAAIAAYagAAAAECLojDApXIxOVKXyWBWP8mNultvtYLN3t7oAwd5o6e2hED78jQbaaSWERNTaPiRj0w==", new DateTime(2023, 11, 2, 4, 32, 58, 936, DateTimeKind.Utc).AddTicks(5335) },
                    { 28, new DateTime(2023, 11, 2, 4, 32, 59, 3, DateTimeKind.Utc).AddTicks(8480), "maudie.lindgren@email.com", "Maudie", "Lindgren", "AQAAAAIAAYagAAAAEDZRHTnPPMpnnKWCpzDebF9Tpb2EW6c5YvzzSCNQVjsqbdkkvBTlVbY/avZvrLFW3g==", new DateTime(2023, 11, 2, 4, 32, 59, 3, DateTimeKind.Utc).AddTicks(8482) },
                    { 29, new DateTime(2023, 11, 2, 4, 32, 59, 70, DateTimeKind.Utc).AddTicks(9534), "crystal.hermiston@email.com", "Crystal", "Hermiston", "AQAAAAIAAYagAAAAEMOHbhI1mvzqWOuiAB25d2MwQFWZ74dSRgfDJNdd+yGDTV71+EtD3PKYWW6ZaaTMtQ==", new DateTime(2023, 11, 2, 4, 32, 59, 70, DateTimeKind.Utc).AddTicks(9535) },
                    { 30, new DateTime(2023, 11, 2, 4, 32, 59, 138, DateTimeKind.Utc).AddTicks(7244), "willow.swaniawski@email.com", "Willow", "Swaniawski", "AQAAAAIAAYagAAAAECHJ0NSb+GnKeM8kMEAVYuBUry/L+ThVfSOkJ+vPZZ3YKVUiohPHPdL2aQCP4IYAag==", new DateTime(2023, 11, 2, 4, 32, 59, 138, DateTimeKind.Utc).AddTicks(7245) },
                    { 31, new DateTime(2023, 11, 2, 4, 32, 59, 206, DateTimeKind.Utc).AddTicks(757), "brennon.sipes@email.com", "Brennon", "Sipes", "AQAAAAIAAYagAAAAEPIAGIfWqKCBYYG0qFQJrDOpOrYB9Ir5r7H5EsmKKo8/V/1uZO73dKCFIJl1qf23ag==", new DateTime(2023, 11, 2, 4, 32, 59, 206, DateTimeKind.Utc).AddTicks(758) },
                    { 32, new DateTime(2023, 11, 2, 4, 32, 59, 274, DateTimeKind.Utc).AddTicks(1141), "darien.blick@email.com", "Darien", "Blick", "AQAAAAIAAYagAAAAEOhwT7LdiNaOhH+S4N7gu8w65lPaw5ABwKwKIcyxd9VbuuRJExA0SmWKJ81m0t/wPQ==", new DateTime(2023, 11, 2, 4, 32, 59, 274, DateTimeKind.Utc).AddTicks(1142) },
                    { 33, new DateTime(2023, 11, 2, 4, 32, 59, 342, DateTimeKind.Utc).AddTicks(690), "philip.stokes@email.com", "Philip", "Stokes", "AQAAAAIAAYagAAAAEKAttD0wsPC8gkTMjQ73ZcmjA+YX7qwk3UR+cQFgytv4YJRFkawOs2S+WbeZcqMRSw==", new DateTime(2023, 11, 2, 4, 32, 59, 342, DateTimeKind.Utc).AddTicks(691) },
                    { 34, new DateTime(2023, 11, 2, 4, 32, 59, 409, DateTimeKind.Utc).AddTicks(7005), "luz.bauch@email.com", "Luz", "Bauch", "AQAAAAIAAYagAAAAEFeVzvH0nBLk6wQZzMa/YWZm3M2C1pROm7AW5oWtNpwTP/NlLwOUK7oHDcFGPc2hdw==", new DateTime(2023, 11, 2, 4, 32, 59, 409, DateTimeKind.Utc).AddTicks(7006) },
                    { 35, new DateTime(2023, 11, 2, 4, 32, 59, 477, DateTimeKind.Utc).AddTicks(3365), "shaina.runolfsdottir@email.com", "Shaina", "Runolfsdottir", "AQAAAAIAAYagAAAAEJcRTDBwJzaIik00/BzR4g6mzUiTvNUT8RBexHTXJ6DepxumrgsG0IbAfiEtZwpQ9w==", new DateTime(2023, 11, 2, 4, 32, 59, 477, DateTimeKind.Utc).AddTicks(3367) },
                    { 36, new DateTime(2023, 11, 2, 4, 32, 59, 544, DateTimeKind.Utc).AddTicks(7497), "wade.tromp@email.com", "Wade", "Tromp", "AQAAAAIAAYagAAAAEDKy09tlgDBqmCFCexQvGgYwygKDcDRi0RPevrqa2g7QELnm9I6FpPc1SHJrQ6+MDA==", new DateTime(2023, 11, 2, 4, 32, 59, 544, DateTimeKind.Utc).AddTicks(7498) },
                    { 37, new DateTime(2023, 11, 2, 4, 32, 59, 612, DateTimeKind.Utc).AddTicks(2710), "lucile.torp@email.com", "Lucile", "Torp", "AQAAAAIAAYagAAAAEEFeMQUsqllEQoNNyoRIr8nW0EHJ88ABzVmi0B71CEaRg42fowBrQ+80NC8+B8u9wA==", new DateTime(2023, 11, 2, 4, 32, 59, 612, DateTimeKind.Utc).AddTicks(2711) },
                    { 38, new DateTime(2023, 11, 2, 4, 32, 59, 679, DateTimeKind.Utc).AddTicks(6162), "annie.cole@email.com", "Annie", "Cole", "AQAAAAIAAYagAAAAEAZTZo+5DCiR+DYohsg9g5x4hShe4WKt2HcJ918apYFjGho+AcVMXbjtO2bB59TLCQ==", new DateTime(2023, 11, 2, 4, 32, 59, 679, DateTimeKind.Utc).AddTicks(6163) },
                    { 39, new DateTime(2023, 11, 2, 4, 32, 59, 747, DateTimeKind.Utc).AddTicks(1856), "jewell.kunze@email.com", "Jewell", "Kunze", "AQAAAAIAAYagAAAAEB+UlQJ3JRVls7mbthCiv+PnHNe8pQ9pWX03K63h6lx6O38jBx8R8aRR3jr4mNQCpw==", new DateTime(2023, 11, 2, 4, 32, 59, 747, DateTimeKind.Utc).AddTicks(1857) },
                    { 40, new DateTime(2023, 11, 2, 4, 32, 59, 814, DateTimeKind.Utc).AddTicks(8663), "ayden.terry@email.com", "Ayden", "Terry", "AQAAAAIAAYagAAAAEOPsxKgq47k+PH1DmJK9I1n0JSIglqEHzjHf5W/AFbtt4tcax8bKnJt1jjkR4Irc+g==", new DateTime(2023, 11, 2, 4, 32, 59, 814, DateTimeKind.Utc).AddTicks(8665) },
                    { 41, new DateTime(2023, 11, 2, 4, 32, 59, 882, DateTimeKind.Utc).AddTicks(5552), "esperanza.gaylord@email.com", "Esperanza", "Gaylord", "AQAAAAIAAYagAAAAEGykiC7O24cvOnsxQ3dnmB4X5vXM7qVxF+C07qBWCuGAnzb0N/1fOtQInrgxpDh7kw==", new DateTime(2023, 11, 2, 4, 32, 59, 882, DateTimeKind.Utc).AddTicks(5553) },
                    { 42, new DateTime(2023, 11, 2, 4, 32, 59, 949, DateTimeKind.Utc).AddTicks(9249), "roger.mills@email.com", "Roger", "Mills", "AQAAAAIAAYagAAAAEOD72jUIfK8kc7phKL82ODTyaj2jyjxUeKzeK4Fk1ax5Af5xmLAZMAbqkGI2BVL0Kg==", new DateTime(2023, 11, 2, 4, 32, 59, 949, DateTimeKind.Utc).AddTicks(9250) },
                    { 43, new DateTime(2023, 11, 2, 4, 33, 0, 17, DateTimeKind.Utc).AddTicks(6093), "mohammed.hessel@email.com", "Mohammed", "Hessel", "AQAAAAIAAYagAAAAEHkpOj890IP0ujIbLjDYcEtTsG9CRMFVOVS5C8ZKGmPQaHs77Y9Tq8485x+F6sKh7A==", new DateTime(2023, 11, 2, 4, 33, 0, 17, DateTimeKind.Utc).AddTicks(6094) },
                    { 44, new DateTime(2023, 11, 2, 4, 33, 0, 85, DateTimeKind.Utc).AddTicks(1337), "tania.walsh@email.com", "Tania", "Walsh", "AQAAAAIAAYagAAAAEFB3ODuA+hFbZjUFkuANvToJ/SyznAbA4YaQoOxkCCM4XCPFJucEceJm4bIjUfZI/A==", new DateTime(2023, 11, 2, 4, 33, 0, 85, DateTimeKind.Utc).AddTicks(1338) },
                    { 45, new DateTime(2023, 11, 2, 4, 33, 0, 153, DateTimeKind.Utc).AddTicks(3585), "fletcher.roberts@email.com", "Fletcher", "Roberts", "AQAAAAIAAYagAAAAEH4sSzEgBVNprr7GP97gDuhyMyYd308OsMtLjQHqattwYSxLsSVqaA83L4GBb6+pcQ==", new DateTime(2023, 11, 2, 4, 33, 0, 153, DateTimeKind.Utc).AddTicks(3587) },
                    { 46, new DateTime(2023, 11, 2, 4, 33, 0, 221, DateTimeKind.Utc).AddTicks(2211), "idell.schimmel@email.com", "Idell", "Schimmel", "AQAAAAIAAYagAAAAEDXmTvg5D4YMMaaeGUI1/tZTZ39/sBuwn/bu/HZOJc6zMCiBP/CDWYxxYOYk32pw7Q==", new DateTime(2023, 11, 2, 4, 33, 0, 221, DateTimeKind.Utc).AddTicks(2211) },
                    { 47, new DateTime(2023, 11, 2, 4, 33, 0, 288, DateTimeKind.Utc).AddTicks(4927), "genevieve.kerluke@email.com", "Genevieve", "Kerluke", "AQAAAAIAAYagAAAAECrxNdhDiO3ZeeOv6Q+J9+Cz3rnRlQ9ApxUz6hDZ/eU2zi+NtsrdMPJK0M8oDdUr6A==", new DateTime(2023, 11, 2, 4, 33, 0, 288, DateTimeKind.Utc).AddTicks(4927) },
                    { 48, new DateTime(2023, 11, 2, 4, 33, 0, 355, DateTimeKind.Utc).AddTicks(7614), "jedediah.heaney@email.com", "Jedediah", "Heaney", "AQAAAAIAAYagAAAAEJcDeiLW7XGnKb52GOm4SA/SQS4yCujsoHYaiHmhI/szLQINPzb6bHkSmfoAS/NxOg==", new DateTime(2023, 11, 2, 4, 33, 0, 355, DateTimeKind.Utc).AddTicks(7615) },
                    { 49, new DateTime(2023, 11, 2, 4, 33, 0, 423, DateTimeKind.Utc).AddTicks(2089), "garrison.lemke@email.com", "Garrison", "Lemke", "AQAAAAIAAYagAAAAEC/iGMxyz88JW/S/3LqR0o+DmNDwFTKXvJTnhercrvHsebVq5eojbj6ASATjASIaxw==", new DateTime(2023, 11, 2, 4, 33, 0, 423, DateTimeKind.Utc).AddTicks(2089) },
                    { 50, new DateTime(2023, 11, 2, 4, 33, 0, 490, DateTimeKind.Utc).AddTicks(9516), "pansy.veum@email.com", "Pansy", "Veum", "AQAAAAIAAYagAAAAEP6bFxV69idkkXMqpHmG1VndQiYC+7O8Y7FI9kU3jRuT7vUjluLwu8XYEzeWl0SMqQ==", new DateTime(2023, 11, 2, 4, 33, 0, 490, DateTimeKind.Utc).AddTicks(9517) },
                    { 51, new DateTime(2023, 11, 2, 4, 33, 0, 558, DateTimeKind.Utc).AddTicks(2475), "brenda.bosco@email.com", "Brenda", "Bosco", "AQAAAAIAAYagAAAAEHXNoewW/Mvbvc1sZJXGHQC3TLr/CKdPjXRqbLNgyAbZo55SdkaJoZNrn/yxrEjsJw==", new DateTime(2023, 11, 2, 4, 33, 0, 558, DateTimeKind.Utc).AddTicks(2476) },
                    { 52, new DateTime(2023, 11, 2, 4, 33, 0, 626, DateTimeKind.Utc).AddTicks(394), "lela.runte@email.com", "Lela", "Runte", "AQAAAAIAAYagAAAAEHWdzaVN9iV8hTb6LsyINi31837FF92bVffAa6mmi/hgQQfBWuHbP5JqmOaNMx2K3Q==", new DateTime(2023, 11, 2, 4, 33, 0, 626, DateTimeKind.Utc).AddTicks(395) },
                    { 53, new DateTime(2023, 11, 2, 4, 33, 0, 693, DateTimeKind.Utc).AddTicks(9430), "markus.windler@email.com", "Markus", "Windler", "AQAAAAIAAYagAAAAEF7feEkGl+r/53wx9idBiOxEySCcU83VpFpZ3UJoYYscixszdoE39IM+CbpCL/D+xg==", new DateTime(2023, 11, 2, 4, 33, 0, 693, DateTimeKind.Utc).AddTicks(9431) },
                    { 54, new DateTime(2023, 11, 2, 4, 33, 0, 761, DateTimeKind.Utc).AddTicks(9068), "filiberto.bednar@email.com", "Filiberto", "Bednar", "AQAAAAIAAYagAAAAEL7gzZIzkIl2juSC+Xr92gvtqFFCoYcquhhGRwGwssl8R61ChAiXGypISqa0gqiDrw==", new DateTime(2023, 11, 2, 4, 33, 0, 761, DateTimeKind.Utc).AddTicks(9069) },
                    { 55, new DateTime(2023, 11, 2, 4, 33, 0, 829, DateTimeKind.Utc).AddTicks(4007), "garry.luettgen@email.com", "Garry", "Luettgen", "AQAAAAIAAYagAAAAENfAINeD4luWQ6Vm0s0TJdDrfCU9z2T5OGAYCi54BsmFh0Qpdm1z+zUVHzgLTK95LA==", new DateTime(2023, 11, 2, 4, 33, 0, 829, DateTimeKind.Utc).AddTicks(4008) },
                    { 56, new DateTime(2023, 11, 2, 4, 33, 0, 896, DateTimeKind.Utc).AddTicks(9011), "onie.botsford@email.com", "Onie", "Botsford", "AQAAAAIAAYagAAAAEASiQ5asd8Q4pW/XVKQfW76tOpOPiYnOg5SvQCAjnNY65ibdbyYYnmZXQHYlyokeng==", new DateTime(2023, 11, 2, 4, 33, 0, 896, DateTimeKind.Utc).AddTicks(9012) },
                    { 57, new DateTime(2023, 11, 2, 4, 33, 0, 964, DateTimeKind.Utc).AddTicks(4337), "makenna.moen@email.com", "Makenna", "Moen", "AQAAAAIAAYagAAAAELxqU5fXmfskdojuvkuIQCZxltKE4yfeIp/yt+lv9nIDB0yhpl4bgZ9vUcOrA0f+TQ==", new DateTime(2023, 11, 2, 4, 33, 0, 964, DateTimeKind.Utc).AddTicks(4339) },
                    { 58, new DateTime(2023, 11, 2, 4, 33, 1, 32, DateTimeKind.Utc).AddTicks(4627), "vince.wunsch@email.com", "Vince", "Wunsch", "AQAAAAIAAYagAAAAEELPvJ3j02F2x7SpTCquPvBNQLDPEvdjR2ivnQJji9hgHfZo0kWNt2m71HCOHWIhQg==", new DateTime(2023, 11, 2, 4, 33, 1, 32, DateTimeKind.Utc).AddTicks(4629) },
                    { 59, new DateTime(2023, 11, 2, 4, 33, 1, 100, DateTimeKind.Utc).AddTicks(156), "tyrel.orn@email.com", "Tyrel", "Orn", "AQAAAAIAAYagAAAAEIiXz6tfdc3T3aey7g5i2m5Dvc1R37qmJoU+ACsfp8I0vl7+rZRfo7mezVi1OL5sFQ==", new DateTime(2023, 11, 2, 4, 33, 1, 100, DateTimeKind.Utc).AddTicks(157) },
                    { 60, new DateTime(2023, 11, 2, 4, 33, 1, 167, DateTimeKind.Utc).AddTicks(8574), "valerie.rohan@email.com", "Valerie", "Rohan", "AQAAAAIAAYagAAAAEA3087xdSjV9T7jj7qvM/FvOnilFlDpdTR6kYqkfgcuOMLuTJ/GqDfTp50kypg+cbQ==", new DateTime(2023, 11, 2, 4, 33, 1, 167, DateTimeKind.Utc).AddTicks(8575) },
                    { 61, new DateTime(2023, 11, 2, 4, 33, 1, 235, DateTimeKind.Utc).AddTicks(4383), "darby.kuhn@email.com", "Darby", "Kuhn", "AQAAAAIAAYagAAAAEIeJ7Tak3OUAUXAn5Yg+GdErOD4TGo92oHpnlQ5AY8qOE1njB656ab2nn819aNN9aA==", new DateTime(2023, 11, 2, 4, 33, 1, 235, DateTimeKind.Utc).AddTicks(4384) },
                    { 62, new DateTime(2023, 11, 2, 4, 33, 1, 303, DateTimeKind.Utc).AddTicks(1584), "alexie.buckridge@email.com", "Alexie", "Buckridge", "AQAAAAIAAYagAAAAEMYoKJPodVrb8Kts9Swf5vbPg5mXhyY9Uqe8Is+RjF5k1O/ycHdv14Z/NIdE9dGbjg==", new DateTime(2023, 11, 2, 4, 33, 1, 303, DateTimeKind.Utc).AddTicks(1586) },
                    { 63, new DateTime(2023, 11, 2, 4, 33, 1, 370, DateTimeKind.Utc).AddTicks(6374), "ottis.o'connell@email.com", "Ottis", "O'Connell", "AQAAAAIAAYagAAAAECSlxnKWgNxuthYwcft71n30QVny40ITz3T+uAXG9259j4ii0ffJhjPSpXm8eZ/tgA==", new DateTime(2023, 11, 2, 4, 33, 1, 370, DateTimeKind.Utc).AddTicks(6375) },
                    { 64, new DateTime(2023, 11, 2, 4, 33, 1, 438, DateTimeKind.Utc).AddTicks(8289), "kailee.kunze@email.com", "Kailee", "Kunze", "AQAAAAIAAYagAAAAEAJdQJwtctg0MvXWJdQ4v42b6z52EZBXG2tck8+sD4EIH6COnxabmamlaTKN02uUFA==", new DateTime(2023, 11, 2, 4, 33, 1, 438, DateTimeKind.Utc).AddTicks(8290) },
                    { 65, new DateTime(2023, 11, 2, 4, 33, 1, 506, DateTimeKind.Utc).AddTicks(479), "hugh.rolfson@email.com", "Hugh", "Rolfson", "AQAAAAIAAYagAAAAEC/fIJExkXnfl5VE5JUveIuDj/3N4mONtZVCLEOlwAXomBTFuWXhzC7ENBlaQ/I1bQ==", new DateTime(2023, 11, 2, 4, 33, 1, 506, DateTimeKind.Utc).AddTicks(480) },
                    { 66, new DateTime(2023, 11, 2, 4, 33, 1, 574, DateTimeKind.Utc).AddTicks(92), "willis.stracke@email.com", "Willis", "Stracke", "AQAAAAIAAYagAAAAEO/p06tOCAgYqGy8eHeyzUdz6+NWgNs5gKbd7aoT/r0P4gwYIuvK5mtBA93r9luAgA==", new DateTime(2023, 11, 2, 4, 33, 1, 574, DateTimeKind.Utc).AddTicks(96) },
                    { 67, new DateTime(2023, 11, 2, 4, 33, 1, 641, DateTimeKind.Utc).AddTicks(2510), "jett.bradtke@email.com", "Jett", "Bradtke", "AQAAAAIAAYagAAAAECzGlp4wPp7lnzae2zw/GFLOZc2ymZvY2olNUn5q1OBFLpzngtKVlPRKbtI1FbBx+g==", new DateTime(2023, 11, 2, 4, 33, 1, 641, DateTimeKind.Utc).AddTicks(2511) },
                    { 68, new DateTime(2023, 11, 2, 4, 33, 1, 708, DateTimeKind.Utc).AddTicks(1929), "lemuel.crooks@email.com", "Lemuel", "Crooks", "AQAAAAIAAYagAAAAEP+X6wXfeB5QR7ue4kiDckkFJ5tzGhjFxHexCk/mrqfHtCkl0TERmqp2SinJ1LuXNg==", new DateTime(2023, 11, 2, 4, 33, 1, 708, DateTimeKind.Utc).AddTicks(1931) },
                    { 69, new DateTime(2023, 11, 2, 4, 33, 1, 775, DateTimeKind.Utc).AddTicks(7641), "ivy.emard@email.com", "Ivy", "Emard", "AQAAAAIAAYagAAAAED09vkDTMnjDQW0GCPHQZTdgUKbxHKy6g9ZjL7d3inj/v/wUTToZj3WtdcRaRc0xYg==", new DateTime(2023, 11, 2, 4, 33, 1, 775, DateTimeKind.Utc).AddTicks(7643) },
                    { 70, new DateTime(2023, 11, 2, 4, 33, 1, 843, DateTimeKind.Utc).AddTicks(2302), "isabelle.leannon@email.com", "Isabelle", "Leannon", "AQAAAAIAAYagAAAAEGhUx7+5VT6/jhLPi5cBqSYPgoG5pbbcXJj5J4iAY9RK3u7bNIbgTNHxtwv2lfzVlQ==", new DateTime(2023, 11, 2, 4, 33, 1, 843, DateTimeKind.Utc).AddTicks(2303) },
                    { 71, new DateTime(2023, 11, 2, 4, 33, 1, 910, DateTimeKind.Utc).AddTicks(8035), "kimberly.ankunding@email.com", "Kimberly", "Ankunding", "AQAAAAIAAYagAAAAEOOHmQGP1ezm9muZYu0ngercOFizsh3YW90Z6I7fNQPGoaOKULwsFLxEcjZLVzpEAg==", new DateTime(2023, 11, 2, 4, 33, 1, 910, DateTimeKind.Utc).AddTicks(8036) },
                    { 72, new DateTime(2023, 11, 2, 4, 33, 1, 978, DateTimeKind.Utc).AddTicks(6278), "grant.macgyver@email.com", "Grant", "MacGyver", "AQAAAAIAAYagAAAAEIHcTsC3ckHoU/CL4UAtCxoVgn+IsAA60hKofKr5z4SLTfOZxqa8p6kBJED51Mxu/w==", new DateTime(2023, 11, 2, 4, 33, 1, 978, DateTimeKind.Utc).AddTicks(6280) },
                    { 73, new DateTime(2023, 11, 2, 4, 33, 2, 46, DateTimeKind.Utc).AddTicks(195), "cortez.bashirian@email.com", "Cortez", "Bashirian", "AQAAAAIAAYagAAAAEBmGsNgVdDrk4CbK7F/DzL4aFxqdJ+M52vXPt0N/VswbYYQrEBAZ/hNedm9a5qHJIw==", new DateTime(2023, 11, 2, 4, 33, 2, 46, DateTimeKind.Utc).AddTicks(197) },
                    { 74, new DateTime(2023, 11, 2, 4, 33, 2, 113, DateTimeKind.Utc).AddTicks(3024), "alexa.hammes@email.com", "Alexa", "Hammes", "AQAAAAIAAYagAAAAEHnG5Jzp3KSOpAVAbxtLuJM2IKClDSalJBVdsFcrvyqymzxlArJwzR1J4LDKhezwJQ==", new DateTime(2023, 11, 2, 4, 33, 2, 113, DateTimeKind.Utc).AddTicks(3025) },
                    { 75, new DateTime(2023, 11, 2, 4, 33, 2, 180, DateTimeKind.Utc).AddTicks(4889), "trudie.hintz@email.com", "Trudie", "Hintz", "AQAAAAIAAYagAAAAEMcUJfD3vqGMNlKGNPbLPQjbFdCQ9n1F6WDq2UhU/B5Nxn56Cjzifv90Ucoa5SmJtA==", new DateTime(2023, 11, 2, 4, 33, 2, 180, DateTimeKind.Utc).AddTicks(4891) },
                    { 76, new DateTime(2023, 11, 2, 4, 33, 2, 248, DateTimeKind.Utc).AddTicks(3277), "fannie.feeney@email.com", "Fannie", "Feeney", "AQAAAAIAAYagAAAAEBwuuP68RmDATDUEnWhEXuHGI2W3EmLkSO0IlM5GllGr9xxCQXmGxGEprW4FGi+8Qg==", new DateTime(2023, 11, 2, 4, 33, 2, 248, DateTimeKind.Utc).AddTicks(3278) },
                    { 77, new DateTime(2023, 11, 2, 4, 33, 2, 316, DateTimeKind.Utc).AddTicks(1931), "earl.grant@email.com", "Earl", "Grant", "AQAAAAIAAYagAAAAEBgwgMBb8FdCfWZ0oparBbxO2bFX9KWN4TEhgXBIOljkTRfME8uK0bv41M3Ua9Y/qQ==", new DateTime(2023, 11, 2, 4, 33, 2, 316, DateTimeKind.Utc).AddTicks(1933) },
                    { 78, new DateTime(2023, 11, 2, 4, 33, 2, 385, DateTimeKind.Utc).AddTicks(4807), "savanna.o'connell@email.com", "Savanna", "O'Connell", "AQAAAAIAAYagAAAAEHK1wMWqc8o0r9rw9xnJ2Go4vOW4Wg8dxPx00JpW4xOi7euHYIWsfKL/MrdJ6W0Ulw==", new DateTime(2023, 11, 2, 4, 33, 2, 385, DateTimeKind.Utc).AddTicks(4808) },
                    { 79, new DateTime(2023, 11, 2, 4, 33, 2, 452, DateTimeKind.Utc).AddTicks(9620), "jerod.romaguera@email.com", "Jerod", "Romaguera", "AQAAAAIAAYagAAAAEHZOzK8jxMJHCX8hlZ0Gy/op3S9MTgtgYW2DhTQLhjR7btR5ayFl3Sl2yprREgG7ZQ==", new DateTime(2023, 11, 2, 4, 33, 2, 452, DateTimeKind.Utc).AddTicks(9621) },
                    { 80, new DateTime(2023, 11, 2, 4, 33, 2, 520, DateTimeKind.Utc).AddTicks(7551), "idell.hirthe@email.com", "Idell", "Hirthe", "AQAAAAIAAYagAAAAEFOsKWncCkV9Yu6XZgytAK8iH4nDM17krHI7Ejo+aa6TrBuV1Yyo7h0Zqt5GKUeHWw==", new DateTime(2023, 11, 2, 4, 33, 2, 520, DateTimeKind.Utc).AddTicks(7552) },
                    { 81, new DateTime(2023, 11, 2, 4, 33, 2, 588, DateTimeKind.Utc).AddTicks(4104), "ludwig.rempel@email.com", "Ludwig", "Rempel", "AQAAAAIAAYagAAAAEO5NUqCd/kfi+vacLOHhp3dg89XG2WheRrMRYCx7bvtKBB4fQ9S8PQQQxDmdkJqwVQ==", new DateTime(2023, 11, 2, 4, 33, 2, 588, DateTimeKind.Utc).AddTicks(4105) },
                    { 82, new DateTime(2023, 11, 2, 4, 33, 2, 655, DateTimeKind.Utc).AddTicks(8972), "cade.kris@email.com", "Cade", "Kris", "AQAAAAIAAYagAAAAEP38Ol6dniTpAqdt2uRr9nsmZCHcnC2Xc3G12XkgPrOs1W4/wCfRN+62/ltPPSYbvg==", new DateTime(2023, 11, 2, 4, 33, 2, 655, DateTimeKind.Utc).AddTicks(8973) },
                    { 83, new DateTime(2023, 11, 2, 4, 33, 2, 723, DateTimeKind.Utc).AddTicks(6308), "erica.o'keefe@email.com", "Erica", "O'Keefe", "AQAAAAIAAYagAAAAEBP4ftkMkveQ8Ip2hor8VdNURhZKZA9lUAz6P9xLBGGpbyKqpK+8QMNkRUdxyqpIJw==", new DateTime(2023, 11, 2, 4, 33, 2, 723, DateTimeKind.Utc).AddTicks(6309) },
                    { 84, new DateTime(2023, 11, 2, 4, 33, 2, 790, DateTimeKind.Utc).AddTicks(9048), "michele.parker@email.com", "Michele", "Parker", "AQAAAAIAAYagAAAAEEEezGO4MXh+tehvNuShP2ZbOWPBvMuON+CTpVKNvwgXU8rhnzAqS1h8EljXVlsBlQ==", new DateTime(2023, 11, 2, 4, 33, 2, 790, DateTimeKind.Utc).AddTicks(9048) },
                    { 85, new DateTime(2023, 11, 2, 4, 33, 2, 858, DateTimeKind.Utc).AddTicks(4195), "mossie.blick@email.com", "Mossie", "Blick", "AQAAAAIAAYagAAAAECJwAFe5p0ZG3frqY2KrQdg93sl5+K3kjbECeLnbaCRxl5jaaoePKwXLkDilSu9UQg==", new DateTime(2023, 11, 2, 4, 33, 2, 858, DateTimeKind.Utc).AddTicks(4196) },
                    { 86, new DateTime(2023, 11, 2, 4, 33, 2, 926, DateTimeKind.Utc).AddTicks(2892), "may.hammes@email.com", "May", "Hammes", "AQAAAAIAAYagAAAAEGSnhx4YLyuz8RQQqtZag6u1+QzUd9L+hjDXeBAZRr4+ZeAVEdIcl7HD/pCrZg6T6g==", new DateTime(2023, 11, 2, 4, 33, 2, 926, DateTimeKind.Utc).AddTicks(2894) },
                    { 87, new DateTime(2023, 11, 2, 4, 33, 2, 993, DateTimeKind.Utc).AddTicks(4168), "ivory.barton@email.com", "Ivory", "Barton", "AQAAAAIAAYagAAAAENtZEVBOcMcWCzm3bOGX5hu5O/C2hgPGQ5k9wjgktdaKeGOegfF/0ZWgJEz213kcUQ==", new DateTime(2023, 11, 2, 4, 33, 2, 993, DateTimeKind.Utc).AddTicks(4170) },
                    { 88, new DateTime(2023, 11, 2, 4, 33, 3, 61, DateTimeKind.Utc).AddTicks(2187), "lois.ziemann@email.com", "Lois", "Ziemann", "AQAAAAIAAYagAAAAEOLwzoaz2fE4e3ZNi7yYC1jx2BAR6ETIwoFmS9kOJWSrv3HUNB8k1uaU/L8i9Vw+vw==", new DateTime(2023, 11, 2, 4, 33, 3, 61, DateTimeKind.Utc).AddTicks(2188) },
                    { 89, new DateTime(2023, 11, 2, 4, 33, 3, 128, DateTimeKind.Utc).AddTicks(7656), "eldon.bogan@email.com", "Eldon", "Bogan", "AQAAAAIAAYagAAAAEFnebegR/tSH9IQxJ8XE/S7/t6JHMcxKhvP3I+cCShg+sDRxEuX7cmwcFEUpzBznyw==", new DateTime(2023, 11, 2, 4, 33, 3, 128, DateTimeKind.Utc).AddTicks(7657) },
                    { 90, new DateTime(2023, 11, 2, 4, 33, 3, 196, DateTimeKind.Utc).AddTicks(1302), "earl.mayer@email.com", "Earl", "Mayer", "AQAAAAIAAYagAAAAEGVH3tKiHDoJPrT0ktznYQO5vxD42BB44lK0+/TyjSilCgItD+o8dUJnreTVQuBHNg==", new DateTime(2023, 11, 2, 4, 33, 3, 196, DateTimeKind.Utc).AddTicks(1304) },
                    { 91, new DateTime(2023, 11, 2, 4, 33, 3, 263, DateTimeKind.Utc).AddTicks(5618), "demetris.bednar@email.com", "Demetris", "Bednar", "AQAAAAIAAYagAAAAEC8Mo6N5kFL8oDM7KSKCPd5xNFYmJfOXpCx+3aofAvc01uOif+hmX3BCOuwUBVFyRA==", new DateTime(2023, 11, 2, 4, 33, 3, 263, DateTimeKind.Utc).AddTicks(5620) },
                    { 92, new DateTime(2023, 11, 2, 4, 33, 3, 331, DateTimeKind.Utc).AddTicks(2668), "reuben.tromp@email.com", "Reuben", "Tromp", "AQAAAAIAAYagAAAAECNsqB5TCSG6wuP3bR7biFhkRcJlVf7q56/88KVhKL+tnLtkZPtaOtE/Sc2WPZuh7Q==", new DateTime(2023, 11, 2, 4, 33, 3, 331, DateTimeKind.Utc).AddTicks(2669) },
                    { 93, new DateTime(2023, 11, 2, 4, 33, 3, 399, DateTimeKind.Utc).AddTicks(922), "donnie.weissnat@email.com", "Donnie", "Weissnat", "AQAAAAIAAYagAAAAEIbomIpb+kwYY6lg6JIQ9R19vnx2ZO4mefTe8/Dki/sSxIfgDhe2swIWmJxXIq4X/A==", new DateTime(2023, 11, 2, 4, 33, 3, 399, DateTimeKind.Utc).AddTicks(923) },
                    { 94, new DateTime(2023, 11, 2, 4, 33, 3, 466, DateTimeKind.Utc).AddTicks(4939), "ernest.renner@email.com", "Ernest", "Renner", "AQAAAAIAAYagAAAAEIBw5CuD61AzX+V/4/2VPe34OVh4qSyy67AF0FMy5iJ3dnbujLEdk5uns7wljol2EQ==", new DateTime(2023, 11, 2, 4, 33, 3, 466, DateTimeKind.Utc).AddTicks(4940) },
                    { 95, new DateTime(2023, 11, 2, 4, 33, 3, 534, DateTimeKind.Utc).AddTicks(287), "kiana.schuppe@email.com", "Kiana", "Schuppe", "AQAAAAIAAYagAAAAEDjeSOOoNmDzawJYoSk1wtDLMxCyvdI4GlPqkqC3PwERTgSf01J1C1Un9OiOz1tVNA==", new DateTime(2023, 11, 2, 4, 33, 3, 534, DateTimeKind.Utc).AddTicks(289) },
                    { 96, new DateTime(2023, 11, 2, 4, 33, 3, 601, DateTimeKind.Utc).AddTicks(5894), "alexandrea.lebsack@email.com", "Alexandrea", "Lebsack", "AQAAAAIAAYagAAAAENnIL6Wo/I1jUhzqDKolk1XYMzX+/NJ9htdTPFzKLmuOQsT6Sr8K27fz62EH7opalw==", new DateTime(2023, 11, 2, 4, 33, 3, 601, DateTimeKind.Utc).AddTicks(5896) },
                    { 97, new DateTime(2023, 11, 2, 4, 33, 3, 669, DateTimeKind.Utc).AddTicks(66), "savanna.schimmel@email.com", "Savanna", "Schimmel", "AQAAAAIAAYagAAAAEB2H9IFNdT12LjA6E8o4by6h/q5zYm0Y/p3xaMWq5VEuvSCABRSVJ67xR3TGHlFbPQ==", new DateTime(2023, 11, 2, 4, 33, 3, 669, DateTimeKind.Utc).AddTicks(68) },
                    { 98, new DateTime(2023, 11, 2, 4, 33, 3, 736, DateTimeKind.Utc).AddTicks(4638), "ethel.stanton@email.com", "Ethel", "Stanton", "AQAAAAIAAYagAAAAEG03XxvNhVFu2oFERrTGD7kpeRltnXdsV5VClLlJhMkw+q4QxoEi/QQ6tHkqEatdjw==", new DateTime(2023, 11, 2, 4, 33, 3, 736, DateTimeKind.Utc).AddTicks(4639) },
                    { 99, new DateTime(2023, 11, 2, 4, 33, 3, 804, DateTimeKind.Utc).AddTicks(2068), "junior.smitham@email.com", "Junior", "Smitham", "AQAAAAIAAYagAAAAEMg/X8RD1zIk2pUzYSg9ga94myjFpNY3kNlMuo4PQWFfir9VR/YLWrCKnWrrQLeMag==", new DateTime(2023, 11, 2, 4, 33, 3, 804, DateTimeKind.Utc).AddTicks(2069) },
                    { 100, new DateTime(2023, 11, 2, 4, 33, 3, 871, DateTimeKind.Utc).AddTicks(8050), "alicia.hartmann@email.com", "Alicia", "Hartmann", "AQAAAAIAAYagAAAAEHi+uWVOl3AcE6quekTf8gg411p6ZV3jx07tlmgvvY1NmePabqsR/iUVCjuk8gKLPA==", new DateTime(2023, 11, 2, 4, 33, 3, 871, DateTimeKind.Utc).AddTicks(8050) },
                    { 101, new DateTime(2023, 11, 2, 4, 33, 3, 939, DateTimeKind.Utc).AddTicks(9574), "sonya.ullrich@email.com", "Sonya", "Ullrich", "AQAAAAIAAYagAAAAEKuVCvYQEYBlN2jSeFuYhvPxS5IHukJNCyhBOfZEznKDmGeZjHZvNqnS/nXKIkGE3Q==", new DateTime(2023, 11, 2, 4, 33, 3, 939, DateTimeKind.Utc).AddTicks(9575) },
                    { 102, new DateTime(2023, 11, 2, 4, 33, 4, 7, DateTimeKind.Utc).AddTicks(4535), "leonor.toy@email.com", "Leonor", "Toy", "AQAAAAIAAYagAAAAECyNBc0uFY4VreOWNEWpBLkAigzybLZPHynuYx1kRU8pafbjzs6vfd2G3b9NzXTJhg==", new DateTime(2023, 11, 2, 4, 33, 4, 7, DateTimeKind.Utc).AddTicks(4536) },
                    { 103, new DateTime(2023, 11, 2, 4, 33, 4, 75, DateTimeKind.Utc).AddTicks(4633), "ollie.mccullough@email.com", "Ollie", "McCullough", "AQAAAAIAAYagAAAAEBf7vDXsjtazkBAYe+R67bv/X1CHMcxE/jSg9byyJWPyzdxYSefkDD+uMMQheIAtbw==", new DateTime(2023, 11, 2, 4, 33, 4, 75, DateTimeKind.Utc).AddTicks(4634) },
                    { 104, new DateTime(2023, 11, 2, 4, 33, 4, 143, DateTimeKind.Utc).AddTicks(1000), "flavio.o'conner@email.com", "Flavio", "O'Conner", "AQAAAAIAAYagAAAAEMgIdPJoorFsHrb65aeXofkcfP4N2DBPFrKstgB/h1/kX7EqehEGsUEIWjCCyJ8Nbw==", new DateTime(2023, 11, 2, 4, 33, 4, 143, DateTimeKind.Utc).AddTicks(1002) },
                    { 105, new DateTime(2023, 11, 2, 4, 33, 4, 211, DateTimeKind.Utc).AddTicks(329), "lukas.morissette@email.com", "Lukas", "Morissette", "AQAAAAIAAYagAAAAEEMqdpJyQhjXpBkjMG2xehTY+flLTJdowe+jhwh/oaXpKJm+GilsdfkeF9t8KKGK3Q==", new DateTime(2023, 11, 2, 4, 33, 4, 211, DateTimeKind.Utc).AddTicks(331) },
                    { 106, new DateTime(2023, 11, 2, 4, 33, 4, 278, DateTimeKind.Utc).AddTicks(3086), "casimer.murazik@email.com", "Casimer", "Murazik", "AQAAAAIAAYagAAAAEP64EPurPhGTi7rNpbo7tU6iFlw3QeqWnPFVrTghbwWbZsCjviSmaIfH770HL7lcRA==", new DateTime(2023, 11, 2, 4, 33, 4, 278, DateTimeKind.Utc).AddTicks(3088) },
                    { 107, new DateTime(2023, 11, 2, 4, 33, 4, 346, DateTimeKind.Utc).AddTicks(9707), "amy.hyatt@email.com", "Amy", "Hyatt", "AQAAAAIAAYagAAAAEEoGpbb5DKvtoHfVlQ1khLSAEFRqXtZVCvPeI9eEaPIq3buLynJ5TtErMwbAd3JtJA==", new DateTime(2023, 11, 2, 4, 33, 4, 346, DateTimeKind.Utc).AddTicks(9709) },
                    { 108, new DateTime(2023, 11, 2, 4, 33, 4, 414, DateTimeKind.Utc).AddTicks(3711), "vivien.hyatt@email.com", "Vivien", "Hyatt", "AQAAAAIAAYagAAAAEJL/72nWBRHIgRW09ZnvHBabEnIZAZPF61HZuT2Lx4tLzHe7FivLS6maULbvDxn9ow==", new DateTime(2023, 11, 2, 4, 33, 4, 414, DateTimeKind.Utc).AddTicks(3712) },
                    { 109, new DateTime(2023, 11, 2, 4, 33, 4, 481, DateTimeKind.Utc).AddTicks(4355), "joany.auer@email.com", "Joany", "Auer", "AQAAAAIAAYagAAAAEHT1qtcfkcwp9JqhtPYet0gbMBHYRI5MGF4WTIxMYjGX3mybC8APB9V6AZarxtOqOg==", new DateTime(2023, 11, 2, 4, 33, 4, 481, DateTimeKind.Utc).AddTicks(4356) },
                    { 110, new DateTime(2023, 11, 2, 4, 33, 4, 548, DateTimeKind.Utc).AddTicks(6790), "clovis.collins@email.com", "Clovis", "Collins", "AQAAAAIAAYagAAAAEGRVRyowQ05FuwwOSVeYOo4D/TnOdsB/FETwNejKIP5WmeRVjyHGjR9Ni+zmJIRTaQ==", new DateTime(2023, 11, 2, 4, 33, 4, 548, DateTimeKind.Utc).AddTicks(6792) },
                    { 111, new DateTime(2023, 11, 2, 4, 33, 4, 616, DateTimeKind.Utc).AddTicks(2898), "jarod.abernathy@email.com", "Jarod", "Abernathy", "AQAAAAIAAYagAAAAEGBULdCp86Y3JlO00p0Yr3dLBG+egYs9CKCX+iExzTSsmkU38mDTMBSWTNXW54OlFA==", new DateTime(2023, 11, 2, 4, 33, 4, 616, DateTimeKind.Utc).AddTicks(2899) },
                    { 112, new DateTime(2023, 11, 2, 4, 33, 4, 683, DateTimeKind.Utc).AddTicks(9368), "aurelie.balistreri@email.com", "Aurelie", "Balistreri", "AQAAAAIAAYagAAAAEA+B+Sjc3VZlJLf68BMGctb7cBf1931m22QCHVbgxbjL6wfhTjEs+YFBk8AY2+BBsQ==", new DateTime(2023, 11, 2, 4, 33, 4, 683, DateTimeKind.Utc).AddTicks(9369) },
                    { 113, new DateTime(2023, 11, 2, 4, 33, 4, 751, DateTimeKind.Utc).AddTicks(1771), "julie.west@email.com", "Julie", "West", "AQAAAAIAAYagAAAAEMbJJjTDIPmvC6VetzGx/otLDVBzhFeiWT7qb87/wxnRBRY7X6eKDZK0PWwYg/qrSg==", new DateTime(2023, 11, 2, 4, 33, 4, 751, DateTimeKind.Utc).AddTicks(1772) },
                    { 114, new DateTime(2023, 11, 2, 4, 33, 4, 818, DateTimeKind.Utc).AddTicks(7024), "brittany.auer@email.com", "Brittany", "Auer", "AQAAAAIAAYagAAAAEPhu76dwSKJPlUEAwlJXJBNWfSnGKg9ZDofwzSWm2mnPh3MI2uf/jSQJMxsqUos1fQ==", new DateTime(2023, 11, 2, 4, 33, 4, 818, DateTimeKind.Utc).AddTicks(7026) },
                    { 115, new DateTime(2023, 11, 2, 4, 33, 4, 886, DateTimeKind.Utc).AddTicks(1692), "mitchel.maggio@email.com", "Mitchel", "Maggio", "AQAAAAIAAYagAAAAECazzNvNkUdn1rpnz+ThKj5CCAkUVVP6eBylFwd/5pdtCTXkz46KXuijoqLeya4Y3w==", new DateTime(2023, 11, 2, 4, 33, 4, 886, DateTimeKind.Utc).AddTicks(1693) },
                    { 116, new DateTime(2023, 11, 2, 4, 33, 4, 953, DateTimeKind.Utc).AddTicks(5775), "earlene.walter@email.com", "Earlene", "Walter", "AQAAAAIAAYagAAAAEDtYnX92Crs60l5yownG3MfexKm19iLysMMtZbsxRL5VwdCa1wgPyp6Xia//GfPFzQ==", new DateTime(2023, 11, 2, 4, 33, 4, 953, DateTimeKind.Utc).AddTicks(5776) },
                    { 117, new DateTime(2023, 11, 2, 4, 33, 5, 21, DateTimeKind.Utc).AddTicks(4201), "amya.sipes@email.com", "Amya", "Sipes", "AQAAAAIAAYagAAAAECmZwUGYzokZ28FMPgOF9PhS22RzYdntv1A5uKeoHxyC0FheIukQR5WaVdO7mkKp2g==", new DateTime(2023, 11, 2, 4, 33, 5, 21, DateTimeKind.Utc).AddTicks(4202) },
                    { 118, new DateTime(2023, 11, 2, 4, 33, 5, 88, DateTimeKind.Utc).AddTicks(5471), "chanel.zulauf@email.com", "Chanel", "Zulauf", "AQAAAAIAAYagAAAAELazSals9n/do3U/IJyJxnRTKC/5GhR0dHIJ5mTODptfFR5msvkO12H8QACGoqUGYg==", new DateTime(2023, 11, 2, 4, 33, 5, 88, DateTimeKind.Utc).AddTicks(5472) },
                    { 119, new DateTime(2023, 11, 2, 4, 33, 5, 156, DateTimeKind.Utc).AddTicks(679), "kiera.daugherty@email.com", "Kiera", "Daugherty", "AQAAAAIAAYagAAAAEOcBCpMDa+1NLuYv9dskXrAqBHDCUnZEZIqtKtZsGsNQjbHASjSFiJguyzJSgxDB2Q==", new DateTime(2023, 11, 2, 4, 33, 5, 156, DateTimeKind.Utc).AddTicks(680) },
                    { 120, new DateTime(2023, 11, 2, 4, 33, 5, 223, DateTimeKind.Utc).AddTicks(8215), "irving.hand@email.com", "Irving", "Hand", "AQAAAAIAAYagAAAAEAP7MoMjalgBGFb2ZA8GL2VHSJOQ1im0j5GP3u2BlqTaNnXgQmx76oIJa+dXB2EHBw==", new DateTime(2023, 11, 2, 4, 33, 5, 223, DateTimeKind.Utc).AddTicks(8216) },
                    { 121, new DateTime(2023, 11, 2, 4, 33, 5, 291, DateTimeKind.Utc).AddTicks(8626), "catherine.boehm@email.com", "Catherine", "Boehm", "AQAAAAIAAYagAAAAEEIU4LLHbNnIKVkwbkbreeyVykF6g/MizZcUclSNfylNP4/emnamZ7lyAWG3Ld52pQ==", new DateTime(2023, 11, 2, 4, 33, 5, 291, DateTimeKind.Utc).AddTicks(8626) },
                    { 122, new DateTime(2023, 11, 2, 4, 33, 5, 359, DateTimeKind.Utc).AddTicks(692), "cecilia.collier@email.com", "Cecilia", "Collier", "AQAAAAIAAYagAAAAEDWpeCaGB7gStjPVZyeDWB5eSv1gw4RaL/RGPZS1vtNKqWeaqj5ZxBVMqy0VMqtv+A==", new DateTime(2023, 11, 2, 4, 33, 5, 359, DateTimeKind.Utc).AddTicks(693) },
                    { 123, new DateTime(2023, 11, 2, 4, 33, 5, 426, DateTimeKind.Utc).AddTicks(9545), "kiley.koelpin@email.com", "Kiley", "Koelpin", "AQAAAAIAAYagAAAAEBwmYowzQjApmdCpnniQjMFUTV0SFgTPeZG4dfa5eFaNA2mDLbTgVEHchW4RbhYFhA==", new DateTime(2023, 11, 2, 4, 33, 5, 426, DateTimeKind.Utc).AddTicks(9546) },
                    { 124, new DateTime(2023, 11, 2, 4, 33, 5, 494, DateTimeKind.Utc).AddTicks(7295), "jennie.okuneva@email.com", "Jennie", "Okuneva", "AQAAAAIAAYagAAAAEJ3i2NirdB0bhBwnQzMkdjLozlIWTvKmtGfTOoWmAFYck0YTmzXDXa4NUj8Wo2ryXw==", new DateTime(2023, 11, 2, 4, 33, 5, 494, DateTimeKind.Utc).AddTicks(7296) },
                    { 125, new DateTime(2023, 11, 2, 4, 33, 5, 562, DateTimeKind.Utc).AddTicks(1252), "concepcion.kutch@email.com", "Concepcion", "Kutch", "AQAAAAIAAYagAAAAENd1k7KXQjQkXpnQYHuL6lKMPAtfUYlhZO93BhNUJmeUSwdUP+Oawo8YbdMsT3oeBQ==", new DateTime(2023, 11, 2, 4, 33, 5, 562, DateTimeKind.Utc).AddTicks(1253) },
                    { 126, new DateTime(2023, 11, 2, 4, 33, 5, 629, DateTimeKind.Utc).AddTicks(5898), "savanah.west@email.com", "Savanah", "West", "AQAAAAIAAYagAAAAECBLPexd1HBf7kDTV99PVkMoLml4UhxODO8hvMcyLJDgXDSeua5CblVP3rCNAnzLsw==", new DateTime(2023, 11, 2, 4, 33, 5, 629, DateTimeKind.Utc).AddTicks(5899) },
                    { 127, new DateTime(2023, 11, 2, 4, 33, 5, 696, DateTimeKind.Utc).AddTicks(7692), "aniyah.stark@email.com", "Aniyah", "Stark", "AQAAAAIAAYagAAAAEKceDJNZN4Bf4kHpFSYd1Lc+vpeLD6eC62Lwi/cWKrhDcDhHMpJgS0fnHBrDgl5srw==", new DateTime(2023, 11, 2, 4, 33, 5, 696, DateTimeKind.Utc).AddTicks(7693) },
                    { 128, new DateTime(2023, 11, 2, 4, 33, 5, 763, DateTimeKind.Utc).AddTicks(845), "superuser@mail.com", "super", "user", "AQAAAAIAAYagAAAAEEOQ7ZULYUiGSnb/r6bbHHPCdVGPGD71Y05g68IwfN+EXS2GEqoaM7KecHh3J3d6hA==", new DateTime(2023, 11, 2, 4, 33, 5, 763, DateTimeKind.Utc).AddTicks(845) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Bio", "CreatedAt", "RoleType", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 11, 2, 4, 32, 57, 236, DateTimeKind.Utc).AddTicks(6713), 0, new DateTime(2023, 11, 2, 4, 32, 57, 236, DateTimeKind.Utc).AddTicks(6720), 1 },
                    { 2, null, new DateTime(2023, 11, 2, 4, 32, 57, 308, DateTimeKind.Utc).AddTicks(6986), 0, new DateTime(2023, 11, 2, 4, 32, 57, 308, DateTimeKind.Utc).AddTicks(6990), 2 },
                    { 3, null, new DateTime(2023, 11, 2, 4, 32, 57, 376, DateTimeKind.Utc).AddTicks(9102), 0, new DateTime(2023, 11, 2, 4, 32, 57, 376, DateTimeKind.Utc).AddTicks(9105), 3 },
                    { 4, null, new DateTime(2023, 11, 2, 4, 32, 57, 445, DateTimeKind.Utc).AddTicks(3153), 0, new DateTime(2023, 11, 2, 4, 32, 57, 445, DateTimeKind.Utc).AddTicks(3156), 4 },
                    { 5, null, new DateTime(2023, 11, 2, 4, 32, 57, 512, DateTimeKind.Utc).AddTicks(8933), 0, new DateTime(2023, 11, 2, 4, 32, 57, 512, DateTimeKind.Utc).AddTicks(8937), 5 },
                    { 6, null, new DateTime(2023, 11, 2, 4, 32, 57, 580, DateTimeKind.Utc).AddTicks(3366), 0, new DateTime(2023, 11, 2, 4, 32, 57, 580, DateTimeKind.Utc).AddTicks(3368), 6 },
                    { 7, null, new DateTime(2023, 11, 2, 4, 32, 57, 647, DateTimeKind.Utc).AddTicks(6536), 0, new DateTime(2023, 11, 2, 4, 32, 57, 647, DateTimeKind.Utc).AddTicks(6539), 7 },
                    { 8, null, new DateTime(2023, 11, 2, 4, 32, 57, 714, DateTimeKind.Utc).AddTicks(9545), 0, new DateTime(2023, 11, 2, 4, 32, 57, 714, DateTimeKind.Utc).AddTicks(9548), 8 },
                    { 9, null, new DateTime(2023, 11, 2, 4, 32, 57, 782, DateTimeKind.Utc).AddTicks(8444), 0, new DateTime(2023, 11, 2, 4, 32, 57, 782, DateTimeKind.Utc).AddTicks(8447), 9 },
                    { 10, null, new DateTime(2023, 11, 2, 4, 32, 57, 850, DateTimeKind.Utc).AddTicks(3174), 0, new DateTime(2023, 11, 2, 4, 32, 57, 850, DateTimeKind.Utc).AddTicks(3178), 10 },
                    { 11, null, new DateTime(2023, 11, 2, 4, 32, 57, 917, DateTimeKind.Utc).AddTicks(9924), 0, new DateTime(2023, 11, 2, 4, 32, 57, 917, DateTimeKind.Utc).AddTicks(9928), 11 },
                    { 12, null, new DateTime(2023, 11, 2, 4, 32, 57, 986, DateTimeKind.Utc).AddTicks(4872), 0, new DateTime(2023, 11, 2, 4, 32, 57, 986, DateTimeKind.Utc).AddTicks(4876), 12 },
                    { 13, null, new DateTime(2023, 11, 2, 4, 32, 58, 54, DateTimeKind.Utc).AddTicks(4433), 0, new DateTime(2023, 11, 2, 4, 32, 58, 54, DateTimeKind.Utc).AddTicks(4437), 13 },
                    { 14, null, new DateTime(2023, 11, 2, 4, 32, 58, 121, DateTimeKind.Utc).AddTicks(8723), 0, new DateTime(2023, 11, 2, 4, 32, 58, 121, DateTimeKind.Utc).AddTicks(8727), 14 },
                    { 15, null, new DateTime(2023, 11, 2, 4, 32, 58, 189, DateTimeKind.Utc).AddTicks(6414), 0, new DateTime(2023, 11, 2, 4, 32, 58, 189, DateTimeKind.Utc).AddTicks(6417), 15 },
                    { 16, null, new DateTime(2023, 11, 2, 4, 32, 58, 257, DateTimeKind.Utc).AddTicks(3050), 0, new DateTime(2023, 11, 2, 4, 32, 58, 257, DateTimeKind.Utc).AddTicks(3054), 16 },
                    { 17, null, new DateTime(2023, 11, 2, 4, 32, 58, 325, DateTimeKind.Utc).AddTicks(825), 0, new DateTime(2023, 11, 2, 4, 32, 58, 325, DateTimeKind.Utc).AddTicks(830), 17 },
                    { 18, null, new DateTime(2023, 11, 2, 4, 32, 58, 393, DateTimeKind.Utc).AddTicks(675), 0, new DateTime(2023, 11, 2, 4, 32, 58, 393, DateTimeKind.Utc).AddTicks(679), 18 },
                    { 19, null, new DateTime(2023, 11, 2, 4, 32, 58, 461, DateTimeKind.Utc).AddTicks(5166), 0, new DateTime(2023, 11, 2, 4, 32, 58, 461, DateTimeKind.Utc).AddTicks(5171), 19 },
                    { 20, null, new DateTime(2023, 11, 2, 4, 32, 58, 529, DateTimeKind.Utc).AddTicks(4556), 0, new DateTime(2023, 11, 2, 4, 32, 58, 529, DateTimeKind.Utc).AddTicks(4559), 20 },
                    { 21, null, new DateTime(2023, 11, 2, 4, 32, 58, 596, DateTimeKind.Utc).AddTicks(8949), 0, new DateTime(2023, 11, 2, 4, 32, 58, 596, DateTimeKind.Utc).AddTicks(8952), 21 },
                    { 22, null, new DateTime(2023, 11, 2, 4, 32, 58, 665, DateTimeKind.Utc).AddTicks(3573), 0, new DateTime(2023, 11, 2, 4, 32, 58, 665, DateTimeKind.Utc).AddTicks(3576), 22 },
                    { 23, null, new DateTime(2023, 11, 2, 4, 32, 58, 733, DateTimeKind.Utc).AddTicks(252), 0, new DateTime(2023, 11, 2, 4, 32, 58, 733, DateTimeKind.Utc).AddTicks(257), 23 },
                    { 24, null, new DateTime(2023, 11, 2, 4, 32, 58, 800, DateTimeKind.Utc).AddTicks(3383), 0, new DateTime(2023, 11, 2, 4, 32, 58, 800, DateTimeKind.Utc).AddTicks(3391), 24 },
                    { 25, null, new DateTime(2023, 11, 2, 4, 32, 58, 867, DateTimeKind.Utc).AddTicks(8240), 0, new DateTime(2023, 11, 2, 4, 32, 58, 867, DateTimeKind.Utc).AddTicks(8243), 25 },
                    { 26, null, new DateTime(2023, 11, 2, 4, 32, 58, 935, DateTimeKind.Utc).AddTicks(5076), 0, new DateTime(2023, 11, 2, 4, 32, 58, 935, DateTimeKind.Utc).AddTicks(5079), 26 },
                    { 27, null, new DateTime(2023, 11, 2, 4, 32, 59, 2, DateTimeKind.Utc).AddTicks(7607), 0, new DateTime(2023, 11, 2, 4, 32, 59, 2, DateTimeKind.Utc).AddTicks(7612), 27 },
                    { 28, null, new DateTime(2023, 11, 2, 4, 32, 59, 69, DateTimeKind.Utc).AddTicks(9058), 0, new DateTime(2023, 11, 2, 4, 32, 59, 69, DateTimeKind.Utc).AddTicks(9062), 28 },
                    { 29, null, new DateTime(2023, 11, 2, 4, 32, 59, 137, DateTimeKind.Utc).AddTicks(6471), 0, new DateTime(2023, 11, 2, 4, 32, 59, 137, DateTimeKind.Utc).AddTicks(6475), 29 },
                    { 30, null, new DateTime(2023, 11, 2, 4, 32, 59, 205, DateTimeKind.Utc).AddTicks(625), 0, new DateTime(2023, 11, 2, 4, 32, 59, 205, DateTimeKind.Utc).AddTicks(628), 30 },
                    { 31, null, new DateTime(2023, 11, 2, 4, 32, 59, 273, DateTimeKind.Utc).AddTicks(505), 0, new DateTime(2023, 11, 2, 4, 32, 59, 273, DateTimeKind.Utc).AddTicks(509), 31 },
                    { 32, null, new DateTime(2023, 11, 2, 4, 32, 59, 341, DateTimeKind.Utc).AddTicks(225), 0, new DateTime(2023, 11, 2, 4, 32, 59, 341, DateTimeKind.Utc).AddTicks(232), 32 },
                    { 33, null, new DateTime(2023, 11, 2, 4, 32, 59, 408, DateTimeKind.Utc).AddTicks(6526), 0, new DateTime(2023, 11, 2, 4, 32, 59, 408, DateTimeKind.Utc).AddTicks(6534), 33 },
                    { 34, null, new DateTime(2023, 11, 2, 4, 32, 59, 476, DateTimeKind.Utc).AddTicks(3136), 0, new DateTime(2023, 11, 2, 4, 32, 59, 476, DateTimeKind.Utc).AddTicks(3140), 34 },
                    { 35, null, new DateTime(2023, 11, 2, 4, 32, 59, 543, DateTimeKind.Utc).AddTicks(7088), 0, new DateTime(2023, 11, 2, 4, 32, 59, 543, DateTimeKind.Utc).AddTicks(7092), 35 },
                    { 36, null, new DateTime(2023, 11, 2, 4, 32, 59, 611, DateTimeKind.Utc).AddTicks(2517), 0, new DateTime(2023, 11, 2, 4, 32, 59, 611, DateTimeKind.Utc).AddTicks(2521), 36 },
                    { 37, null, new DateTime(2023, 11, 2, 4, 32, 59, 678, DateTimeKind.Utc).AddTicks(6026), 0, new DateTime(2023, 11, 2, 4, 32, 59, 678, DateTimeKind.Utc).AddTicks(6029), 37 },
                    { 38, null, new DateTime(2023, 11, 2, 4, 32, 59, 746, DateTimeKind.Utc).AddTicks(1399), 0, new DateTime(2023, 11, 2, 4, 32, 59, 746, DateTimeKind.Utc).AddTicks(1403), 38 },
                    { 39, null, new DateTime(2023, 11, 2, 4, 32, 59, 813, DateTimeKind.Utc).AddTicks(7984), 0, new DateTime(2023, 11, 2, 4, 32, 59, 813, DateTimeKind.Utc).AddTicks(7988), 39 },
                    { 40, null, new DateTime(2023, 11, 2, 4, 32, 59, 881, DateTimeKind.Utc).AddTicks(5300), 0, new DateTime(2023, 11, 2, 4, 32, 59, 881, DateTimeKind.Utc).AddTicks(5305), 40 },
                    { 41, null, new DateTime(2023, 11, 2, 4, 32, 59, 948, DateTimeKind.Utc).AddTicks(8954), 0, new DateTime(2023, 11, 2, 4, 32, 59, 948, DateTimeKind.Utc).AddTicks(8958), 41 },
                    { 42, null, new DateTime(2023, 11, 2, 4, 33, 0, 16, DateTimeKind.Utc).AddTicks(4983), 0, new DateTime(2023, 11, 2, 4, 33, 0, 16, DateTimeKind.Utc).AddTicks(4988), 42 },
                    { 43, null, new DateTime(2023, 11, 2, 4, 33, 0, 84, DateTimeKind.Utc).AddTicks(747), 0, new DateTime(2023, 11, 2, 4, 33, 0, 84, DateTimeKind.Utc).AddTicks(752), 43 },
                    { 44, null, new DateTime(2023, 11, 2, 4, 33, 0, 152, DateTimeKind.Utc).AddTicks(1304), 0, new DateTime(2023, 11, 2, 4, 33, 0, 152, DateTimeKind.Utc).AddTicks(1307), 44 },
                    { 45, null, new DateTime(2023, 11, 2, 4, 33, 0, 220, DateTimeKind.Utc).AddTicks(1709), 0, new DateTime(2023, 11, 2, 4, 33, 0, 220, DateTimeKind.Utc).AddTicks(1713), 45 },
                    { 46, null, new DateTime(2023, 11, 2, 4, 33, 0, 287, DateTimeKind.Utc).AddTicks(4316), 0, new DateTime(2023, 11, 2, 4, 33, 0, 287, DateTimeKind.Utc).AddTicks(4320), 46 },
                    { 47, null, new DateTime(2023, 11, 2, 4, 33, 0, 354, DateTimeKind.Utc).AddTicks(7228), 0, new DateTime(2023, 11, 2, 4, 33, 0, 354, DateTimeKind.Utc).AddTicks(7232), 47 },
                    { 48, null, new DateTime(2023, 11, 2, 4, 33, 0, 422, DateTimeKind.Utc).AddTicks(1879), 0, new DateTime(2023, 11, 2, 4, 33, 0, 422, DateTimeKind.Utc).AddTicks(1883), 48 },
                    { 49, null, new DateTime(2023, 11, 2, 4, 33, 0, 489, DateTimeKind.Utc).AddTicks(9427), 0, new DateTime(2023, 11, 2, 4, 33, 0, 489, DateTimeKind.Utc).AddTicks(9430), 49 },
                    { 50, null, new DateTime(2023, 11, 2, 4, 33, 0, 557, DateTimeKind.Utc).AddTicks(1561), 0, new DateTime(2023, 11, 2, 4, 33, 0, 557, DateTimeKind.Utc).AddTicks(1566), 50 },
                    { 51, null, new DateTime(2023, 11, 2, 4, 33, 0, 625, DateTimeKind.Utc).AddTicks(30), 0, new DateTime(2023, 11, 2, 4, 33, 0, 625, DateTimeKind.Utc).AddTicks(34), 51 },
                    { 52, null, new DateTime(2023, 11, 2, 4, 33, 0, 692, DateTimeKind.Utc).AddTicks(9236), 0, new DateTime(2023, 11, 2, 4, 33, 0, 692, DateTimeKind.Utc).AddTicks(9240), 52 },
                    { 53, null, new DateTime(2023, 11, 2, 4, 33, 0, 760, DateTimeKind.Utc).AddTicks(8306), 0, new DateTime(2023, 11, 2, 4, 33, 0, 760, DateTimeKind.Utc).AddTicks(8310), 53 },
                    { 54, null, new DateTime(2023, 11, 2, 4, 33, 0, 828, DateTimeKind.Utc).AddTicks(3658), 0, new DateTime(2023, 11, 2, 4, 33, 0, 828, DateTimeKind.Utc).AddTicks(3663), 54 },
                    { 55, null, new DateTime(2023, 11, 2, 4, 33, 0, 895, DateTimeKind.Utc).AddTicks(8355), 0, new DateTime(2023, 11, 2, 4, 33, 0, 895, DateTimeKind.Utc).AddTicks(8358), 55 },
                    { 56, null, new DateTime(2023, 11, 2, 4, 33, 0, 963, DateTimeKind.Utc).AddTicks(4028), 0, new DateTime(2023, 11, 2, 4, 33, 0, 963, DateTimeKind.Utc).AddTicks(4031), 56 },
                    { 57, null, new DateTime(2023, 11, 2, 4, 33, 1, 31, DateTimeKind.Utc).AddTicks(4020), 0, new DateTime(2023, 11, 2, 4, 33, 1, 31, DateTimeKind.Utc).AddTicks(4024), 57 },
                    { 58, null, new DateTime(2023, 11, 2, 4, 33, 1, 98, DateTimeKind.Utc).AddTicks(9851), 0, new DateTime(2023, 11, 2, 4, 33, 1, 98, DateTimeKind.Utc).AddTicks(9855), 58 },
                    { 59, null, new DateTime(2023, 11, 2, 4, 33, 1, 166, DateTimeKind.Utc).AddTicks(8096), 0, new DateTime(2023, 11, 2, 4, 33, 1, 166, DateTimeKind.Utc).AddTicks(8100), 59 },
                    { 60, null, new DateTime(2023, 11, 2, 4, 33, 1, 234, DateTimeKind.Utc).AddTicks(4273), 0, new DateTime(2023, 11, 2, 4, 33, 1, 234, DateTimeKind.Utc).AddTicks(4277), 60 },
                    { 61, null, new DateTime(2023, 11, 2, 4, 33, 1, 302, DateTimeKind.Utc).AddTicks(894), 0, new DateTime(2023, 11, 2, 4, 33, 1, 302, DateTimeKind.Utc).AddTicks(899), 61 },
                    { 62, null, new DateTime(2023, 11, 2, 4, 33, 1, 369, DateTimeKind.Utc).AddTicks(5688), 0, new DateTime(2023, 11, 2, 4, 33, 1, 369, DateTimeKind.Utc).AddTicks(5693), 62 },
                    { 63, null, new DateTime(2023, 11, 2, 4, 33, 1, 437, DateTimeKind.Utc).AddTicks(8063), 0, new DateTime(2023, 11, 2, 4, 33, 1, 437, DateTimeKind.Utc).AddTicks(8066), 63 },
                    { 64, null, new DateTime(2023, 11, 2, 4, 33, 1, 504, DateTimeKind.Utc).AddTicks(9821), 0, new DateTime(2023, 11, 2, 4, 33, 1, 504, DateTimeKind.Utc).AddTicks(9825), 64 },
                    { 65, null, new DateTime(2023, 11, 2, 4, 33, 1, 572, DateTimeKind.Utc).AddTicks(9858), 0, new DateTime(2023, 11, 2, 4, 33, 1, 572, DateTimeKind.Utc).AddTicks(9861), 65 },
                    { 66, null, new DateTime(2023, 11, 2, 4, 33, 1, 640, DateTimeKind.Utc).AddTicks(2163), 0, new DateTime(2023, 11, 2, 4, 33, 1, 640, DateTimeKind.Utc).AddTicks(2167), 66 },
                    { 67, null, new DateTime(2023, 11, 2, 4, 33, 1, 707, DateTimeKind.Utc).AddTicks(1972), 0, new DateTime(2023, 11, 2, 4, 33, 1, 707, DateTimeKind.Utc).AddTicks(1974), 67 },
                    { 68, null, new DateTime(2023, 11, 2, 4, 33, 1, 774, DateTimeKind.Utc).AddTicks(7222), 0, new DateTime(2023, 11, 2, 4, 33, 1, 774, DateTimeKind.Utc).AddTicks(7227), 68 },
                    { 69, null, new DateTime(2023, 11, 2, 4, 33, 1, 842, DateTimeKind.Utc).AddTicks(1808), 0, new DateTime(2023, 11, 2, 4, 33, 1, 842, DateTimeKind.Utc).AddTicks(1811), 69 },
                    { 70, null, new DateTime(2023, 11, 2, 4, 33, 1, 909, DateTimeKind.Utc).AddTicks(7787), 0, new DateTime(2023, 11, 2, 4, 33, 1, 909, DateTimeKind.Utc).AddTicks(7791), 70 },
                    { 71, null, new DateTime(2023, 11, 2, 4, 33, 1, 977, DateTimeKind.Utc).AddTicks(5904), 0, new DateTime(2023, 11, 2, 4, 33, 1, 977, DateTimeKind.Utc).AddTicks(5907), 71 },
                    { 72, null, new DateTime(2023, 11, 2, 4, 33, 2, 44, DateTimeKind.Utc).AddTicks(9159), 0, new DateTime(2023, 11, 2, 4, 33, 2, 44, DateTimeKind.Utc).AddTicks(9163), 72 },
                    { 73, null, new DateTime(2023, 11, 2, 4, 33, 2, 112, DateTimeKind.Utc).AddTicks(2620), 0, new DateTime(2023, 11, 2, 4, 33, 2, 112, DateTimeKind.Utc).AddTicks(2625), 73 },
                    { 74, null, new DateTime(2023, 11, 2, 4, 33, 2, 179, DateTimeKind.Utc).AddTicks(4795), 0, new DateTime(2023, 11, 2, 4, 33, 2, 179, DateTimeKind.Utc).AddTicks(4798), 74 },
                    { 75, null, new DateTime(2023, 11, 2, 4, 33, 2, 247, DateTimeKind.Utc).AddTicks(2520), 0, new DateTime(2023, 11, 2, 4, 33, 2, 247, DateTimeKind.Utc).AddTicks(2525), 75 },
                    { 76, null, new DateTime(2023, 11, 2, 4, 33, 2, 315, DateTimeKind.Utc).AddTicks(1410), 0, new DateTime(2023, 11, 2, 4, 33, 2, 315, DateTimeKind.Utc).AddTicks(1414), 76 },
                    { 77, null, new DateTime(2023, 11, 2, 4, 33, 2, 384, DateTimeKind.Utc).AddTicks(3598), 0, new DateTime(2023, 11, 2, 4, 33, 2, 384, DateTimeKind.Utc).AddTicks(3603), 77 },
                    { 78, null, new DateTime(2023, 11, 2, 4, 33, 2, 451, DateTimeKind.Utc).AddTicks(9459), 1, new DateTime(2023, 11, 2, 4, 33, 2, 451, DateTimeKind.Utc).AddTicks(9464), 78 },
                    { 79, null, new DateTime(2023, 11, 2, 4, 33, 2, 519, DateTimeKind.Utc).AddTicks(7269), 1, new DateTime(2023, 11, 2, 4, 33, 2, 519, DateTimeKind.Utc).AddTicks(7275), 79 },
                    { 80, null, new DateTime(2023, 11, 2, 4, 33, 2, 587, DateTimeKind.Utc).AddTicks(3389), 1, new DateTime(2023, 11, 2, 4, 33, 2, 587, DateTimeKind.Utc).AddTicks(3394), 80 },
                    { 81, null, new DateTime(2023, 11, 2, 4, 33, 2, 654, DateTimeKind.Utc).AddTicks(8443), 1, new DateTime(2023, 11, 2, 4, 33, 2, 654, DateTimeKind.Utc).AddTicks(8447), 81 },
                    { 82, null, new DateTime(2023, 11, 2, 4, 33, 2, 722, DateTimeKind.Utc).AddTicks(5736), 1, new DateTime(2023, 11, 2, 4, 33, 2, 722, DateTimeKind.Utc).AddTicks(5741), 82 },
                    { 83, null, new DateTime(2023, 11, 2, 4, 33, 2, 789, DateTimeKind.Utc).AddTicks(8607), 1, new DateTime(2023, 11, 2, 4, 33, 2, 789, DateTimeKind.Utc).AddTicks(8611), 83 },
                    { 84, null, new DateTime(2023, 11, 2, 4, 33, 2, 857, DateTimeKind.Utc).AddTicks(3769), 1, new DateTime(2023, 11, 2, 4, 33, 2, 857, DateTimeKind.Utc).AddTicks(3774), 84 },
                    { 85, null, new DateTime(2023, 11, 2, 4, 33, 2, 925, DateTimeKind.Utc).AddTicks(1933), 1, new DateTime(2023, 11, 2, 4, 33, 2, 925, DateTimeKind.Utc).AddTicks(1941), 85 },
                    { 86, null, new DateTime(2023, 11, 2, 4, 33, 2, 992, DateTimeKind.Utc).AddTicks(3930), 1, new DateTime(2023, 11, 2, 4, 33, 2, 992, DateTimeKind.Utc).AddTicks(3936), 86 },
                    { 87, null, new DateTime(2023, 11, 2, 4, 33, 3, 60, DateTimeKind.Utc).AddTicks(1809), 1, new DateTime(2023, 11, 2, 4, 33, 3, 60, DateTimeKind.Utc).AddTicks(1813), 87 },
                    { 88, null, new DateTime(2023, 11, 2, 4, 33, 3, 127, DateTimeKind.Utc).AddTicks(6759), 1, new DateTime(2023, 11, 2, 4, 33, 3, 127, DateTimeKind.Utc).AddTicks(6763), 88 },
                    { 89, null, new DateTime(2023, 11, 2, 4, 33, 3, 195, DateTimeKind.Utc).AddTicks(1038), 1, new DateTime(2023, 11, 2, 4, 33, 3, 195, DateTimeKind.Utc).AddTicks(1042), 89 },
                    { 90, null, new DateTime(2023, 11, 2, 4, 33, 3, 262, DateTimeKind.Utc).AddTicks(5308), 1, new DateTime(2023, 11, 2, 4, 33, 3, 262, DateTimeKind.Utc).AddTicks(5311), 90 },
                    { 91, null, new DateTime(2023, 11, 2, 4, 33, 3, 330, DateTimeKind.Utc).AddTicks(2008), 1, new DateTime(2023, 11, 2, 4, 33, 3, 330, DateTimeKind.Utc).AddTicks(2013), 91 },
                    { 92, null, new DateTime(2023, 11, 2, 4, 33, 3, 398, DateTimeKind.Utc).AddTicks(376), 1, new DateTime(2023, 11, 2, 4, 33, 3, 398, DateTimeKind.Utc).AddTicks(380), 92 },
                    { 93, null, new DateTime(2023, 11, 2, 4, 33, 3, 465, DateTimeKind.Utc).AddTicks(4725), 1, new DateTime(2023, 11, 2, 4, 33, 3, 465, DateTimeKind.Utc).AddTicks(4728), 93 },
                    { 94, null, new DateTime(2023, 11, 2, 4, 33, 3, 532, DateTimeKind.Utc).AddTicks(9928), 1, new DateTime(2023, 11, 2, 4, 33, 3, 532, DateTimeKind.Utc).AddTicks(9932), 94 },
                    { 95, null, new DateTime(2023, 11, 2, 4, 33, 3, 600, DateTimeKind.Utc).AddTicks(5526), 1, new DateTime(2023, 11, 2, 4, 33, 3, 600, DateTimeKind.Utc).AddTicks(5530), 95 },
                    { 96, null, new DateTime(2023, 11, 2, 4, 33, 3, 667, DateTimeKind.Utc).AddTicks(9845), 1, new DateTime(2023, 11, 2, 4, 33, 3, 667, DateTimeKind.Utc).AddTicks(9849), 96 },
                    { 97, null, new DateTime(2023, 11, 2, 4, 33, 3, 735, DateTimeKind.Utc).AddTicks(4257), 1, new DateTime(2023, 11, 2, 4, 33, 3, 735, DateTimeKind.Utc).AddTicks(4261), 97 },
                    { 98, null, new DateTime(2023, 11, 2, 4, 33, 3, 803, DateTimeKind.Utc).AddTicks(1604), 1, new DateTime(2023, 11, 2, 4, 33, 3, 803, DateTimeKind.Utc).AddTicks(1608), 98 },
                    { 99, null, new DateTime(2023, 11, 2, 4, 33, 3, 870, DateTimeKind.Utc).AddTicks(7665), 1, new DateTime(2023, 11, 2, 4, 33, 3, 870, DateTimeKind.Utc).AddTicks(7668), 99 },
                    { 100, null, new DateTime(2023, 11, 2, 4, 33, 3, 938, DateTimeKind.Utc).AddTicks(9093), 1, new DateTime(2023, 11, 2, 4, 33, 3, 938, DateTimeKind.Utc).AddTicks(9097), 100 },
                    { 101, null, new DateTime(2023, 11, 2, 4, 33, 4, 6, DateTimeKind.Utc).AddTicks(4223), 1, new DateTime(2023, 11, 2, 4, 33, 4, 6, DateTimeKind.Utc).AddTicks(4228), 101 },
                    { 102, null, new DateTime(2023, 11, 2, 4, 33, 4, 74, DateTimeKind.Utc).AddTicks(4499), 1, new DateTime(2023, 11, 2, 4, 33, 4, 74, DateTimeKind.Utc).AddTicks(4504), 102 },
                    { 103, null, new DateTime(2023, 11, 2, 4, 33, 4, 142, DateTimeKind.Utc).AddTicks(32), 1, new DateTime(2023, 11, 2, 4, 33, 4, 142, DateTimeKind.Utc).AddTicks(36), 103 },
                    { 104, null, new DateTime(2023, 11, 2, 4, 33, 4, 209, DateTimeKind.Utc).AddTicks(9728), 1, new DateTime(2023, 11, 2, 4, 33, 4, 209, DateTimeKind.Utc).AddTicks(9731), 104 },
                    { 105, null, new DateTime(2023, 11, 2, 4, 33, 4, 277, DateTimeKind.Utc).AddTicks(2777), 1, new DateTime(2023, 11, 2, 4, 33, 4, 277, DateTimeKind.Utc).AddTicks(2781), 105 },
                    { 106, null, new DateTime(2023, 11, 2, 4, 33, 4, 344, DateTimeKind.Utc).AddTicks(9424), 1, new DateTime(2023, 11, 2, 4, 33, 4, 344, DateTimeKind.Utc).AddTicks(9428), 106 },
                    { 107, null, new DateTime(2023, 11, 2, 4, 33, 4, 413, DateTimeKind.Utc).AddTicks(3423), 1, new DateTime(2023, 11, 2, 4, 33, 4, 413, DateTimeKind.Utc).AddTicks(3427), 107 },
                    { 108, null, new DateTime(2023, 11, 2, 4, 33, 4, 480, DateTimeKind.Utc).AddTicks(4258), 1, new DateTime(2023, 11, 2, 4, 33, 4, 480, DateTimeKind.Utc).AddTicks(4261), 108 },
                    { 109, null, new DateTime(2023, 11, 2, 4, 33, 4, 547, DateTimeKind.Utc).AddTicks(6644), 1, new DateTime(2023, 11, 2, 4, 33, 4, 547, DateTimeKind.Utc).AddTicks(6647), 109 },
                    { 110, null, new DateTime(2023, 11, 2, 4, 33, 4, 615, DateTimeKind.Utc).AddTicks(2505), 1, new DateTime(2023, 11, 2, 4, 33, 4, 615, DateTimeKind.Utc).AddTicks(2509), 110 },
                    { 111, null, new DateTime(2023, 11, 2, 4, 33, 4, 682, DateTimeKind.Utc).AddTicks(9002), 1, new DateTime(2023, 11, 2, 4, 33, 4, 682, DateTimeKind.Utc).AddTicks(9007), 111 },
                    { 112, null, new DateTime(2023, 11, 2, 4, 33, 4, 750, DateTimeKind.Utc).AddTicks(1210), 1, new DateTime(2023, 11, 2, 4, 33, 4, 750, DateTimeKind.Utc).AddTicks(1218), 112 },
                    { 113, null, new DateTime(2023, 11, 2, 4, 33, 4, 817, DateTimeKind.Utc).AddTicks(5634), 1, new DateTime(2023, 11, 2, 4, 33, 4, 817, DateTimeKind.Utc).AddTicks(5639), 113 },
                    { 114, null, new DateTime(2023, 11, 2, 4, 33, 4, 885, DateTimeKind.Utc).AddTicks(1450), 1, new DateTime(2023, 11, 2, 4, 33, 4, 885, DateTimeKind.Utc).AddTicks(1454), 114 },
                    { 115, null, new DateTime(2023, 11, 2, 4, 33, 4, 952, DateTimeKind.Utc).AddTicks(5629), 1, new DateTime(2023, 11, 2, 4, 33, 4, 952, DateTimeKind.Utc).AddTicks(5632), 115 },
                    { 116, null, new DateTime(2023, 11, 2, 4, 33, 5, 20, DateTimeKind.Utc).AddTicks(3850), 1, new DateTime(2023, 11, 2, 4, 33, 5, 20, DateTimeKind.Utc).AddTicks(3854), 116 },
                    { 117, null, new DateTime(2023, 11, 2, 4, 33, 5, 87, DateTimeKind.Utc).AddTicks(4806), 1, new DateTime(2023, 11, 2, 4, 33, 5, 87, DateTimeKind.Utc).AddTicks(4811), 117 },
                    { 118, null, new DateTime(2023, 11, 2, 4, 33, 5, 155, DateTimeKind.Utc).AddTicks(303), 1, new DateTime(2023, 11, 2, 4, 33, 5, 155, DateTimeKind.Utc).AddTicks(307), 118 },
                    { 119, null, new DateTime(2023, 11, 2, 4, 33, 5, 222, DateTimeKind.Utc).AddTicks(8017), 1, new DateTime(2023, 11, 2, 4, 33, 5, 222, DateTimeKind.Utc).AddTicks(8022), 119 },
                    { 120, null, new DateTime(2023, 11, 2, 4, 33, 5, 290, DateTimeKind.Utc).AddTicks(7983), 1, new DateTime(2023, 11, 2, 4, 33, 5, 290, DateTimeKind.Utc).AddTicks(7987), 120 },
                    { 121, null, new DateTime(2023, 11, 2, 4, 33, 5, 358, DateTimeKind.Utc).AddTicks(406), 1, new DateTime(2023, 11, 2, 4, 33, 5, 358, DateTimeKind.Utc).AddTicks(410), 121 },
                    { 122, null, new DateTime(2023, 11, 2, 4, 33, 5, 425, DateTimeKind.Utc).AddTicks(8690), 1, new DateTime(2023, 11, 2, 4, 33, 5, 425, DateTimeKind.Utc).AddTicks(8695), 122 },
                    { 123, null, new DateTime(2023, 11, 2, 4, 33, 5, 493, DateTimeKind.Utc).AddTicks(6974), 1, new DateTime(2023, 11, 2, 4, 33, 5, 493, DateTimeKind.Utc).AddTicks(6979), 123 },
                    { 124, null, new DateTime(2023, 11, 2, 4, 33, 5, 561, DateTimeKind.Utc).AddTicks(910), 1, new DateTime(2023, 11, 2, 4, 33, 5, 561, DateTimeKind.Utc).AddTicks(914), 124 },
                    { 125, null, new DateTime(2023, 11, 2, 4, 33, 5, 628, DateTimeKind.Utc).AddTicks(5371), 1, new DateTime(2023, 11, 2, 4, 33, 5, 628, DateTimeKind.Utc).AddTicks(5376), 125 },
                    { 126, null, new DateTime(2023, 11, 2, 4, 33, 5, 695, DateTimeKind.Utc).AddTicks(7663), 1, new DateTime(2023, 11, 2, 4, 33, 5, 695, DateTimeKind.Utc).AddTicks(7665), 126 },
                    { 127, null, new DateTime(2023, 11, 2, 4, 33, 5, 763, DateTimeKind.Utc).AddTicks(708), 1, new DateTime(2023, 11, 2, 4, 33, 5, 763, DateTimeKind.Utc).AddTicks(712), 127 },
                    { 129, null, new DateTime(2023, 11, 2, 4, 33, 5, 830, DateTimeKind.Utc).AddTicks(3088), 2, new DateTime(2023, 11, 2, 4, 33, 5, 830, DateTimeKind.Utc).AddTicks(3092), 128 }
                });

            migrationBuilder.InsertData(
                table: "UserInstruments",
                columns: new[] { "InstrumentId", "UserId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 2, 4, 32, 57, 236, DateTimeKind.Utc).AddTicks(6726), new DateTime(2023, 11, 2, 4, 32, 57, 236, DateTimeKind.Utc).AddTicks(6727) },
                    { 2, 2, new DateTime(2023, 11, 2, 4, 32, 57, 308, DateTimeKind.Utc).AddTicks(6998), new DateTime(2023, 11, 2, 4, 32, 57, 308, DateTimeKind.Utc).AddTicks(6998) },
                    { 3, 3, new DateTime(2023, 11, 2, 4, 32, 57, 376, DateTimeKind.Utc).AddTicks(9113), new DateTime(2023, 11, 2, 4, 32, 57, 376, DateTimeKind.Utc).AddTicks(9113) },
                    { 4, 4, new DateTime(2023, 11, 2, 4, 32, 57, 445, DateTimeKind.Utc).AddTicks(3162), new DateTime(2023, 11, 2, 4, 32, 57, 445, DateTimeKind.Utc).AddTicks(3162) },
                    { 5, 5, new DateTime(2023, 11, 2, 4, 32, 57, 512, DateTimeKind.Utc).AddTicks(8942), new DateTime(2023, 11, 2, 4, 32, 57, 512, DateTimeKind.Utc).AddTicks(8942) },
                    { 6, 6, new DateTime(2023, 11, 2, 4, 32, 57, 580, DateTimeKind.Utc).AddTicks(3374), new DateTime(2023, 11, 2, 4, 32, 57, 580, DateTimeKind.Utc).AddTicks(3375) },
                    { 7, 7, new DateTime(2023, 11, 2, 4, 32, 57, 647, DateTimeKind.Utc).AddTicks(6544), new DateTime(2023, 11, 2, 4, 32, 57, 647, DateTimeKind.Utc).AddTicks(6545) },
                    { 8, 8, new DateTime(2023, 11, 2, 4, 32, 57, 714, DateTimeKind.Utc).AddTicks(9557), new DateTime(2023, 11, 2, 4, 32, 57, 714, DateTimeKind.Utc).AddTicks(9557) },
                    { 9, 9, new DateTime(2023, 11, 2, 4, 32, 57, 782, DateTimeKind.Utc).AddTicks(8454), new DateTime(2023, 11, 2, 4, 32, 57, 782, DateTimeKind.Utc).AddTicks(8454) },
                    { 10, 10, new DateTime(2023, 11, 2, 4, 32, 57, 850, DateTimeKind.Utc).AddTicks(3185), new DateTime(2023, 11, 2, 4, 32, 57, 850, DateTimeKind.Utc).AddTicks(3185) },
                    { 11, 11, new DateTime(2023, 11, 2, 4, 32, 57, 917, DateTimeKind.Utc).AddTicks(9936), new DateTime(2023, 11, 2, 4, 32, 57, 917, DateTimeKind.Utc).AddTicks(9937) },
                    { 12, 12, new DateTime(2023, 11, 2, 4, 32, 57, 986, DateTimeKind.Utc).AddTicks(4884), new DateTime(2023, 11, 2, 4, 32, 57, 986, DateTimeKind.Utc).AddTicks(4884) },
                    { 13, 13, new DateTime(2023, 11, 2, 4, 32, 58, 54, DateTimeKind.Utc).AddTicks(4446), new DateTime(2023, 11, 2, 4, 32, 58, 54, DateTimeKind.Utc).AddTicks(4446) },
                    { 14, 14, new DateTime(2023, 11, 2, 4, 32, 58, 121, DateTimeKind.Utc).AddTicks(8733), new DateTime(2023, 11, 2, 4, 32, 58, 121, DateTimeKind.Utc).AddTicks(8734) },
                    { 15, 15, new DateTime(2023, 11, 2, 4, 32, 58, 189, DateTimeKind.Utc).AddTicks(6423), new DateTime(2023, 11, 2, 4, 32, 58, 189, DateTimeKind.Utc).AddTicks(6423) },
                    { 16, 16, new DateTime(2023, 11, 2, 4, 32, 58, 257, DateTimeKind.Utc).AddTicks(3062), new DateTime(2023, 11, 2, 4, 32, 58, 257, DateTimeKind.Utc).AddTicks(3062) },
                    { 17, 17, new DateTime(2023, 11, 2, 4, 32, 58, 325, DateTimeKind.Utc).AddTicks(839), new DateTime(2023, 11, 2, 4, 32, 58, 325, DateTimeKind.Utc).AddTicks(839) },
                    { 18, 18, new DateTime(2023, 11, 2, 4, 32, 58, 393, DateTimeKind.Utc).AddTicks(687), new DateTime(2023, 11, 2, 4, 32, 58, 393, DateTimeKind.Utc).AddTicks(688) },
                    { 19, 19, new DateTime(2023, 11, 2, 4, 32, 58, 461, DateTimeKind.Utc).AddTicks(5179), new DateTime(2023, 11, 2, 4, 32, 58, 461, DateTimeKind.Utc).AddTicks(5179) },
                    { 20, 20, new DateTime(2023, 11, 2, 4, 32, 58, 529, DateTimeKind.Utc).AddTicks(4568), new DateTime(2023, 11, 2, 4, 32, 58, 529, DateTimeKind.Utc).AddTicks(4568) },
                    { 21, 21, new DateTime(2023, 11, 2, 4, 32, 58, 596, DateTimeKind.Utc).AddTicks(8958), new DateTime(2023, 11, 2, 4, 32, 58, 596, DateTimeKind.Utc).AddTicks(8958) },
                    { 22, 22, new DateTime(2023, 11, 2, 4, 32, 58, 665, DateTimeKind.Utc).AddTicks(3584), new DateTime(2023, 11, 2, 4, 32, 58, 665, DateTimeKind.Utc).AddTicks(3584) },
                    { 23, 23, new DateTime(2023, 11, 2, 4, 32, 58, 733, DateTimeKind.Utc).AddTicks(267), new DateTime(2023, 11, 2, 4, 32, 58, 733, DateTimeKind.Utc).AddTicks(268) },
                    { 24, 24, new DateTime(2023, 11, 2, 4, 32, 58, 800, DateTimeKind.Utc).AddTicks(3398), new DateTime(2023, 11, 2, 4, 32, 58, 800, DateTimeKind.Utc).AddTicks(3399) },
                    { 25, 25, new DateTime(2023, 11, 2, 4, 32, 58, 867, DateTimeKind.Utc).AddTicks(8252), new DateTime(2023, 11, 2, 4, 32, 58, 867, DateTimeKind.Utc).AddTicks(8252) },
                    { 26, 26, new DateTime(2023, 11, 2, 4, 32, 58, 935, DateTimeKind.Utc).AddTicks(5086), new DateTime(2023, 11, 2, 4, 32, 58, 935, DateTimeKind.Utc).AddTicks(5086) },
                    { 27, 27, new DateTime(2023, 11, 2, 4, 32, 59, 2, DateTimeKind.Utc).AddTicks(7621), new DateTime(2023, 11, 2, 4, 32, 59, 2, DateTimeKind.Utc).AddTicks(7621) },
                    { 28, 28, new DateTime(2023, 11, 2, 4, 32, 59, 69, DateTimeKind.Utc).AddTicks(9071), new DateTime(2023, 11, 2, 4, 32, 59, 69, DateTimeKind.Utc).AddTicks(9071) },
                    { 29, 29, new DateTime(2023, 11, 2, 4, 32, 59, 137, DateTimeKind.Utc).AddTicks(6486), new DateTime(2023, 11, 2, 4, 32, 59, 137, DateTimeKind.Utc).AddTicks(6486) },
                    { 30, 30, new DateTime(2023, 11, 2, 4, 32, 59, 205, DateTimeKind.Utc).AddTicks(636), new DateTime(2023, 11, 2, 4, 32, 59, 205, DateTimeKind.Utc).AddTicks(636) },
                    { 31, 31, new DateTime(2023, 11, 2, 4, 32, 59, 273, DateTimeKind.Utc).AddTicks(517), new DateTime(2023, 11, 2, 4, 32, 59, 273, DateTimeKind.Utc).AddTicks(518) },
                    { 32, 32, new DateTime(2023, 11, 2, 4, 32, 59, 341, DateTimeKind.Utc).AddTicks(240), new DateTime(2023, 11, 2, 4, 32, 59, 341, DateTimeKind.Utc).AddTicks(240) },
                    { 33, 33, new DateTime(2023, 11, 2, 4, 32, 59, 408, DateTimeKind.Utc).AddTicks(6540), new DateTime(2023, 11, 2, 4, 32, 59, 408, DateTimeKind.Utc).AddTicks(6540) },
                    { 34, 34, new DateTime(2023, 11, 2, 4, 32, 59, 476, DateTimeKind.Utc).AddTicks(3150), new DateTime(2023, 11, 2, 4, 32, 59, 476, DateTimeKind.Utc).AddTicks(3150) },
                    { 35, 35, new DateTime(2023, 11, 2, 4, 32, 59, 543, DateTimeKind.Utc).AddTicks(7101), new DateTime(2023, 11, 2, 4, 32, 59, 543, DateTimeKind.Utc).AddTicks(7102) },
                    { 36, 36, new DateTime(2023, 11, 2, 4, 32, 59, 611, DateTimeKind.Utc).AddTicks(2527), new DateTime(2023, 11, 2, 4, 32, 59, 611, DateTimeKind.Utc).AddTicks(2527) },
                    { 37, 37, new DateTime(2023, 11, 2, 4, 32, 59, 678, DateTimeKind.Utc).AddTicks(6038), new DateTime(2023, 11, 2, 4, 32, 59, 678, DateTimeKind.Utc).AddTicks(6038) },
                    { 38, 38, new DateTime(2023, 11, 2, 4, 32, 59, 746, DateTimeKind.Utc).AddTicks(1409), new DateTime(2023, 11, 2, 4, 32, 59, 746, DateTimeKind.Utc).AddTicks(1410) },
                    { 39, 39, new DateTime(2023, 11, 2, 4, 32, 59, 813, DateTimeKind.Utc).AddTicks(7995), new DateTime(2023, 11, 2, 4, 32, 59, 813, DateTimeKind.Utc).AddTicks(7996) },
                    { 40, 40, new DateTime(2023, 11, 2, 4, 32, 59, 881, DateTimeKind.Utc).AddTicks(5313), new DateTime(2023, 11, 2, 4, 32, 59, 881, DateTimeKind.Utc).AddTicks(5313) },
                    { 41, 41, new DateTime(2023, 11, 2, 4, 32, 59, 948, DateTimeKind.Utc).AddTicks(8965), new DateTime(2023, 11, 2, 4, 32, 59, 948, DateTimeKind.Utc).AddTicks(8965) },
                    { 42, 42, new DateTime(2023, 11, 2, 4, 33, 0, 16, DateTimeKind.Utc).AddTicks(4996), new DateTime(2023, 11, 2, 4, 33, 0, 16, DateTimeKind.Utc).AddTicks(4996) },
                    { 43, 43, new DateTime(2023, 11, 2, 4, 33, 0, 84, DateTimeKind.Utc).AddTicks(758), new DateTime(2023, 11, 2, 4, 33, 0, 84, DateTimeKind.Utc).AddTicks(758) },
                    { 44, 44, new DateTime(2023, 11, 2, 4, 33, 0, 152, DateTimeKind.Utc).AddTicks(1314), new DateTime(2023, 11, 2, 4, 33, 0, 152, DateTimeKind.Utc).AddTicks(1315) },
                    { 45, 45, new DateTime(2023, 11, 2, 4, 33, 0, 220, DateTimeKind.Utc).AddTicks(1720), new DateTime(2023, 11, 2, 4, 33, 0, 220, DateTimeKind.Utc).AddTicks(1720) },
                    { 46, 46, new DateTime(2023, 11, 2, 4, 33, 0, 287, DateTimeKind.Utc).AddTicks(4328), new DateTime(2023, 11, 2, 4, 33, 0, 287, DateTimeKind.Utc).AddTicks(4328) },
                    { 47, 47, new DateTime(2023, 11, 2, 4, 33, 0, 354, DateTimeKind.Utc).AddTicks(7240), new DateTime(2023, 11, 2, 4, 33, 0, 354, DateTimeKind.Utc).AddTicks(7240) },
                    { 48, 48, new DateTime(2023, 11, 2, 4, 33, 0, 422, DateTimeKind.Utc).AddTicks(1892), new DateTime(2023, 11, 2, 4, 33, 0, 422, DateTimeKind.Utc).AddTicks(1892) },
                    { 49, 49, new DateTime(2023, 11, 2, 4, 33, 0, 489, DateTimeKind.Utc).AddTicks(9437), new DateTime(2023, 11, 2, 4, 33, 0, 489, DateTimeKind.Utc).AddTicks(9438) },
                    { 50, 50, new DateTime(2023, 11, 2, 4, 33, 0, 557, DateTimeKind.Utc).AddTicks(1576), new DateTime(2023, 11, 2, 4, 33, 0, 557, DateTimeKind.Utc).AddTicks(1576) },
                    { 51, 51, new DateTime(2023, 11, 2, 4, 33, 0, 625, DateTimeKind.Utc).AddTicks(39), new DateTime(2023, 11, 2, 4, 33, 0, 625, DateTimeKind.Utc).AddTicks(40) },
                    { 52, 52, new DateTime(2023, 11, 2, 4, 33, 0, 692, DateTimeKind.Utc).AddTicks(9250), new DateTime(2023, 11, 2, 4, 33, 0, 692, DateTimeKind.Utc).AddTicks(9250) },
                    { 53, 53, new DateTime(2023, 11, 2, 4, 33, 0, 760, DateTimeKind.Utc).AddTicks(8320), new DateTime(2023, 11, 2, 4, 33, 0, 760, DateTimeKind.Utc).AddTicks(8320) },
                    { 54, 54, new DateTime(2023, 11, 2, 4, 33, 0, 828, DateTimeKind.Utc).AddTicks(3693), new DateTime(2023, 11, 2, 4, 33, 0, 828, DateTimeKind.Utc).AddTicks(3694) },
                    { 55, 55, new DateTime(2023, 11, 2, 4, 33, 0, 895, DateTimeKind.Utc).AddTicks(8365), new DateTime(2023, 11, 2, 4, 33, 0, 895, DateTimeKind.Utc).AddTicks(8365) },
                    { 56, 56, new DateTime(2023, 11, 2, 4, 33, 0, 963, DateTimeKind.Utc).AddTicks(4038), new DateTime(2023, 11, 2, 4, 33, 0, 963, DateTimeKind.Utc).AddTicks(4038) },
                    { 57, 57, new DateTime(2023, 11, 2, 4, 33, 1, 31, DateTimeKind.Utc).AddTicks(4031), new DateTime(2023, 11, 2, 4, 33, 1, 31, DateTimeKind.Utc).AddTicks(4032) },
                    { 58, 58, new DateTime(2023, 11, 2, 4, 33, 1, 98, DateTimeKind.Utc).AddTicks(9863), new DateTime(2023, 11, 2, 4, 33, 1, 98, DateTimeKind.Utc).AddTicks(9863) },
                    { 59, 59, new DateTime(2023, 11, 2, 4, 33, 1, 166, DateTimeKind.Utc).AddTicks(8106), new DateTime(2023, 11, 2, 4, 33, 1, 166, DateTimeKind.Utc).AddTicks(8106) },
                    { 60, 60, new DateTime(2023, 11, 2, 4, 33, 1, 234, DateTimeKind.Utc).AddTicks(4283), new DateTime(2023, 11, 2, 4, 33, 1, 234, DateTimeKind.Utc).AddTicks(4283) },
                    { 61, 61, new DateTime(2023, 11, 2, 4, 33, 1, 302, DateTimeKind.Utc).AddTicks(908), new DateTime(2023, 11, 2, 4, 33, 1, 302, DateTimeKind.Utc).AddTicks(908) },
                    { 62, 62, new DateTime(2023, 11, 2, 4, 33, 1, 369, DateTimeKind.Utc).AddTicks(5701), new DateTime(2023, 11, 2, 4, 33, 1, 369, DateTimeKind.Utc).AddTicks(5701) },
                    { 63, 63, new DateTime(2023, 11, 2, 4, 33, 1, 437, DateTimeKind.Utc).AddTicks(8075), new DateTime(2023, 11, 2, 4, 33, 1, 437, DateTimeKind.Utc).AddTicks(8075) },
                    { 64, 64, new DateTime(2023, 11, 2, 4, 33, 1, 504, DateTimeKind.Utc).AddTicks(9832), new DateTime(2023, 11, 2, 4, 33, 1, 504, DateTimeKind.Utc).AddTicks(9832) },
                    { 65, 65, new DateTime(2023, 11, 2, 4, 33, 1, 572, DateTimeKind.Utc).AddTicks(9868), new DateTime(2023, 11, 2, 4, 33, 1, 572, DateTimeKind.Utc).AddTicks(9868) },
                    { 66, 66, new DateTime(2023, 11, 2, 4, 33, 1, 640, DateTimeKind.Utc).AddTicks(2174), new DateTime(2023, 11, 2, 4, 33, 1, 640, DateTimeKind.Utc).AddTicks(2174) },
                    { 67, 67, new DateTime(2023, 11, 2, 4, 33, 1, 707, DateTimeKind.Utc).AddTicks(1984), new DateTime(2023, 11, 2, 4, 33, 1, 707, DateTimeKind.Utc).AddTicks(1984) },
                    { 68, 68, new DateTime(2023, 11, 2, 4, 33, 1, 774, DateTimeKind.Utc).AddTicks(7236), new DateTime(2023, 11, 2, 4, 33, 1, 774, DateTimeKind.Utc).AddTicks(7236) },
                    { 69, 69, new DateTime(2023, 11, 2, 4, 33, 1, 842, DateTimeKind.Utc).AddTicks(1819), new DateTime(2023, 11, 2, 4, 33, 1, 842, DateTimeKind.Utc).AddTicks(1819) },
                    { 70, 70, new DateTime(2023, 11, 2, 4, 33, 1, 909, DateTimeKind.Utc).AddTicks(7801), new DateTime(2023, 11, 2, 4, 33, 1, 909, DateTimeKind.Utc).AddTicks(7801) },
                    { 71, 71, new DateTime(2023, 11, 2, 4, 33, 1, 977, DateTimeKind.Utc).AddTicks(5914), new DateTime(2023, 11, 2, 4, 33, 1, 977, DateTimeKind.Utc).AddTicks(5915) },
                    { 72, 72, new DateTime(2023, 11, 2, 4, 33, 2, 44, DateTimeKind.Utc).AddTicks(9174), new DateTime(2023, 11, 2, 4, 33, 2, 44, DateTimeKind.Utc).AddTicks(9174) },
                    { 73, 73, new DateTime(2023, 11, 2, 4, 33, 2, 112, DateTimeKind.Utc).AddTicks(2633), new DateTime(2023, 11, 2, 4, 33, 2, 112, DateTimeKind.Utc).AddTicks(2633) },
                    { 74, 74, new DateTime(2023, 11, 2, 4, 33, 2, 179, DateTimeKind.Utc).AddTicks(4805), new DateTime(2023, 11, 2, 4, 33, 2, 179, DateTimeKind.Utc).AddTicks(4805) },
                    { 75, 75, new DateTime(2023, 11, 2, 4, 33, 2, 247, DateTimeKind.Utc).AddTicks(2535), new DateTime(2023, 11, 2, 4, 33, 2, 247, DateTimeKind.Utc).AddTicks(2535) },
                    { 76, 76, new DateTime(2023, 11, 2, 4, 33, 2, 315, DateTimeKind.Utc).AddTicks(1426), new DateTime(2023, 11, 2, 4, 33, 2, 315, DateTimeKind.Utc).AddTicks(1426) },
                    { 77, 77, new DateTime(2023, 11, 2, 4, 33, 2, 384, DateTimeKind.Utc).AddTicks(3611), new DateTime(2023, 11, 2, 4, 33, 2, 384, DateTimeKind.Utc).AddTicks(3611) }
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
                name: "IX_Roles_UserId",
                table: "Roles",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInstruments_InstrumentId",
                table: "UserInstruments",
                column: "InstrumentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserInstruments");

            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
