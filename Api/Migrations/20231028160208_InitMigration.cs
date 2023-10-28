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
                columns: new[] { "InstrumentId", "CreatedAt", "Family", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4535), "Keyboard", "Piano", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4537) },
                    { 2, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4715), "String", "Guitar", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4715) },
                    { 3, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4732), "Woodwind", "Flute", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4732) },
                    { 4, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4758), "Percussion", "Drums", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4758) },
                    { 5, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4784), "String", "Violin", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4784) },
                    { 6, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4803), "Brass", "Trumpet", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4804) },
                    { 7, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4824), "Woodwind", "Saxophone", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4824) },
                    { 8, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4941), "String", "Bass Guitar", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4941) },
                    { 9, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4963), "Woodwind", "Clarinet", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4963) },
                    { 11, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5000), "Brass", "Trombone", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5001) },
                    { 12, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5017), "String", "Harp", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5018) },
                    { 13, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5030), "Percussion", "Vibrophone", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5030) },
                    { 14, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5047), "Woodwind", "Oboe", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5047) },
                    { 15, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5058), "Woodwind", "Bassoon", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5059) },
                    { 17, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5077), "String", "Classical Guitar", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5077) },
                    { 18, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5106), "Brass", "French Horn", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5106) },
                    { 19, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5119), "Keyboard", "Accordion", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5120) },
                    { 20, new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5133), "String", "Cello", new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5133) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 28, 16, 2, 3, 692, DateTimeKind.Utc).AddTicks(7790), "brittany.hyatt@email.com", "Brittany", "Hyatt", "AQAAAAIAAYagAAAAEP6Ew4Jhp2f5hW7GF1Vpgt7yIPO2Ge3VUtVwrJ3Oc2sRpE2kW0xYhoPakLcgZ5+JCw==", new DateTime(2023, 10, 28, 16, 2, 3, 692, DateTimeKind.Utc).AddTicks(7792) },
                    { 2, new DateTime(2023, 10, 28, 16, 2, 3, 761, DateTimeKind.Utc).AddTicks(6498), "lavon.kunze@email.com", "Lavon", "Kunze", "AQAAAAIAAYagAAAAEKhwG7ipvO5xjdEcTUdaY2lp5EC32Q6Zf8krJ5FtoZF0YhHOac/bqB4B4I1bkntHUg==", new DateTime(2023, 10, 28, 16, 2, 3, 761, DateTimeKind.Utc).AddTicks(6499) },
                    { 3, new DateTime(2023, 10, 28, 16, 2, 3, 831, DateTimeKind.Utc).AddTicks(7911), "mose.walker@email.com", "Mose", "Walker", "AQAAAAIAAYagAAAAEORhgvKGoaeu5pHQAIBMmbASKJDHARx4dr3PdND3KbT+O+VyooS31S2Enf51p1hljQ==", new DateTime(2023, 10, 28, 16, 2, 3, 831, DateTimeKind.Utc).AddTicks(7912) },
                    { 4, new DateTime(2023, 10, 28, 16, 2, 3, 902, DateTimeKind.Utc).AddTicks(2114), "colton.dietrich@email.com", "Colton", "Dietrich", "AQAAAAIAAYagAAAAEIMGpyNEYKHZj5Chkm4wkmYbSQxdVSlolBhIhqWfYKK/3NQY7F3u6a37XN5gVBBcFA==", new DateTime(2023, 10, 28, 16, 2, 3, 902, DateTimeKind.Utc).AddTicks(2120) },
                    { 5, new DateTime(2023, 10, 28, 16, 2, 3, 973, DateTimeKind.Utc).AddTicks(1689), "rex.hagenes@email.com", "Rex", "Hagenes", "AQAAAAIAAYagAAAAEEkSoR4ZslmjVz+qj6kn3iAiuPV5VM1lLdQNVqY4pAfNFpasi20Cg2JOiO+s+qWY3Q==", new DateTime(2023, 10, 28, 16, 2, 3, 973, DateTimeKind.Utc).AddTicks(1692) },
                    { 6, new DateTime(2023, 10, 28, 16, 2, 4, 43, DateTimeKind.Utc).AddTicks(9052), "bruce.schneider@email.com", "Bruce", "Schneider", "AQAAAAIAAYagAAAAEJdOP+9Bi9PpAj9XJSPkCTTuDU3wJwriKpG3rzNYL2jIF1ZWgOMBfoJ3ZZqiRmgEhw==", new DateTime(2023, 10, 28, 16, 2, 4, 43, DateTimeKind.Utc).AddTicks(9054) },
                    { 7, new DateTime(2023, 10, 28, 16, 2, 4, 114, DateTimeKind.Utc).AddTicks(6834), "allen.hoppe@email.com", "Allen", "Hoppe", "AQAAAAIAAYagAAAAEI0GjZqHVIIn/amzSCwiM3Zt4xkqCj7Di3igx/WwZNfruA21UstAD2rBsOTdJ1I7+w==", new DateTime(2023, 10, 28, 16, 2, 4, 114, DateTimeKind.Utc).AddTicks(6835) },
                    { 8, new DateTime(2023, 10, 28, 16, 2, 4, 184, DateTimeKind.Utc).AddTicks(6515), "ludwig.yost@email.com", "Ludwig", "Yost", "AQAAAAIAAYagAAAAEDMOpp9b+TI1WxOUjWPt0Ltxcbb/CEw8E1AmahrIA2w32cOUS2I5KDQqIkvxTcKF1g==", new DateTime(2023, 10, 28, 16, 2, 4, 184, DateTimeKind.Utc).AddTicks(6516) },
                    { 9, new DateTime(2023, 10, 28, 16, 2, 4, 254, DateTimeKind.Utc).AddTicks(7522), "hassie.armstrong@email.com", "Hassie", "Armstrong", "AQAAAAIAAYagAAAAEEfMJiLEdy/Fw0KChGl2IDTWY7OzdJv8GSAEGxvX7UxLLQWhbZXPXGoaJU6Z9aKSbw==", new DateTime(2023, 10, 28, 16, 2, 4, 254, DateTimeKind.Utc).AddTicks(7523) },
                    { 10, new DateTime(2023, 10, 28, 16, 2, 4, 325, DateTimeKind.Utc).AddTicks(1916), "alvis.lakin@email.com", "Alvis", "Lakin", "AQAAAAIAAYagAAAAEDohmh5v01Jhn7hRmfuk/8Ug/twkQe5GfVAtlpz0VnrH+tDYjeaAZcX2I+OA1MsX2g==", new DateTime(2023, 10, 28, 16, 2, 4, 325, DateTimeKind.Utc).AddTicks(1917) },
                    { 11, new DateTime(2023, 10, 28, 16, 2, 4, 396, DateTimeKind.Utc).AddTicks(5764), "addie.effertz@email.com", "Addie", "Effertz", "AQAAAAIAAYagAAAAEBZKFUN2bgm0UWeizStvRAmhc8MD+ySu90+9csTM6jnrvi1e7hbdmo2+wQw9RlrnPQ==", new DateTime(2023, 10, 28, 16, 2, 4, 396, DateTimeKind.Utc).AddTicks(5766) },
                    { 12, new DateTime(2023, 10, 28, 16, 2, 4, 466, DateTimeKind.Utc).AddTicks(8670), "vincenza.rosenbaum@email.com", "Vincenza", "Rosenbaum", "AQAAAAIAAYagAAAAELsa7osBWC/kOUcn/yWhC0hV8Li4VMTnvjimzkY2tO4k17Kv5lK7F5tCPuHmkH/qbA==", new DateTime(2023, 10, 28, 16, 2, 4, 466, DateTimeKind.Utc).AddTicks(8672) },
                    { 13, new DateTime(2023, 10, 28, 16, 2, 4, 536, DateTimeKind.Utc).AddTicks(1330), "zackary.doyle@email.com", "Zackary", "Doyle", "AQAAAAIAAYagAAAAEBdnuRwhvtETqe+wUBE2qs7ZguTAl8a5gQXuG6ytLhS78ITu4zjuntKEju+X94XoxQ==", new DateTime(2023, 10, 28, 16, 2, 4, 536, DateTimeKind.Utc).AddTicks(1331) },
                    { 14, new DateTime(2023, 10, 28, 16, 2, 4, 605, DateTimeKind.Utc).AddTicks(9506), "modesta.schroeder@email.com", "Modesta", "Schroeder", "AQAAAAIAAYagAAAAEPq6q0jfFyptUtVNu6wk3kGJxl1gXnFhmBYQK/01BMCCLw4XYHESxy1aAWud/xHW5g==", new DateTime(2023, 10, 28, 16, 2, 4, 605, DateTimeKind.Utc).AddTicks(9507) },
                    { 15, new DateTime(2023, 10, 28, 16, 2, 4, 675, DateTimeKind.Utc).AddTicks(5529), "amira.jacobi@email.com", "Amira", "Jacobi", "AQAAAAIAAYagAAAAEKtDBf2O53fMQajBmytzwn4cXoBJuIGVKPE2bAhy+P+3TBYbNCTtpEYVI+KH8mbUgw==", new DateTime(2023, 10, 28, 16, 2, 4, 675, DateTimeKind.Utc).AddTicks(5530) },
                    { 16, new DateTime(2023, 10, 28, 16, 2, 4, 745, DateTimeKind.Utc).AddTicks(7772), "henry.jenkins@email.com", "Henry", "Jenkins", "AQAAAAIAAYagAAAAEDeEvszz1lgikeXzyybs8WcqTWbBQ4hCtXdiAE3l3LtNovp0YXZtG6pUlKgeal2mQw==", new DateTime(2023, 10, 28, 16, 2, 4, 745, DateTimeKind.Utc).AddTicks(7772) },
                    { 17, new DateTime(2023, 10, 28, 16, 2, 4, 816, DateTimeKind.Utc).AddTicks(2051), "trenton.metz@email.com", "Trenton", "Metz", "AQAAAAIAAYagAAAAEMOw4kfLsIhnQq1SLz8enRfvg2rqXyEYgFsKFZOvnTjkUVDThcU4jHod9LtuKaJTcw==", new DateTime(2023, 10, 28, 16, 2, 4, 816, DateTimeKind.Utc).AddTicks(2052) },
                    { 18, new DateTime(2023, 10, 28, 16, 2, 4, 888, DateTimeKind.Utc).AddTicks(6507), "jed.gleichner@email.com", "Jed", "Gleichner", "AQAAAAIAAYagAAAAEDjiZwJci/ilHjAzXc8F9DNle928wtaGTCcF2N3rzeTVKJd6+tMpU4IRZE4dLFTTrQ==", new DateTime(2023, 10, 28, 16, 2, 4, 888, DateTimeKind.Utc).AddTicks(6511) },
                    { 19, new DateTime(2023, 10, 28, 16, 2, 4, 958, DateTimeKind.Utc).AddTicks(9643), "eli.thompson@email.com", "Eli", "Thompson", "AQAAAAIAAYagAAAAEH0+CiRce0AxcXB8/ZLqjmNwMKc6flFEAdnsZG/RDJsmIyIw/Nvxy0EZYyGO2ZPWwA==", new DateTime(2023, 10, 28, 16, 2, 4, 958, DateTimeKind.Utc).AddTicks(9645) },
                    { 20, new DateTime(2023, 10, 28, 16, 2, 5, 29, DateTimeKind.Utc).AddTicks(5622), "luz.runte@email.com", "Luz", "Runte", "AQAAAAIAAYagAAAAEN7Y1zJoFUQoDu9W91x3x5z1qrZvfSwytZNO9u665pBV7wchP185soUw7iMThhkR9A==", new DateTime(2023, 10, 28, 16, 2, 5, 29, DateTimeKind.Utc).AddTicks(5623) },
                    { 21, new DateTime(2023, 10, 28, 16, 2, 5, 98, DateTimeKind.Utc).AddTicks(1812), "margaretta.stracke@email.com", "Margaretta", "Stracke", "AQAAAAIAAYagAAAAEAhFTHJcQEPwIyarPa7z1XI6gCDbgzJljE5Uuf2E36YACBFYZY3GL76ZjyXI53yPeQ==", new DateTime(2023, 10, 28, 16, 2, 5, 98, DateTimeKind.Utc).AddTicks(1814) },
                    { 22, new DateTime(2023, 10, 28, 16, 2, 5, 168, DateTimeKind.Utc).AddTicks(6102), "marilou.reilly@email.com", "Marilou", "Reilly", "AQAAAAIAAYagAAAAEGqFNkWkJYYAvztoNTwpMi2d9Kc3aAtvPysBsFkd7+JJIkYg19VkLOlgserd4uQyMw==", new DateTime(2023, 10, 28, 16, 2, 5, 168, DateTimeKind.Utc).AddTicks(6102) },
                    { 23, new DateTime(2023, 10, 28, 16, 2, 5, 237, DateTimeKind.Utc).AddTicks(9013), "sofia.crona@email.com", "Sofia", "Crona", "AQAAAAIAAYagAAAAEDkQQZadXuqueq0zWlQk+bPIDxVUSsD5v6yS3kakqDayiM5L3l3IIT5qY9ROjaBLhw==", new DateTime(2023, 10, 28, 16, 2, 5, 237, DateTimeKind.Utc).AddTicks(9015) },
                    { 24, new DateTime(2023, 10, 28, 16, 2, 5, 307, DateTimeKind.Utc).AddTicks(8334), "connie.jacobi@email.com", "Connie", "Jacobi", "AQAAAAIAAYagAAAAED9Cbl/ZsuzfDrt55KKKM5RNNwlMJZNQGcBz70eMKQxRdUNZ1BUkqrhlCaCx0uvXpA==", new DateTime(2023, 10, 28, 16, 2, 5, 307, DateTimeKind.Utc).AddTicks(8335) },
                    { 25, new DateTime(2023, 10, 28, 16, 2, 5, 377, DateTimeKind.Utc).AddTicks(3855), "alexane.dach@email.com", "Alexane", "Dach", "AQAAAAIAAYagAAAAEEhyzn/taQOGZj1gO7UigMnfVl5/75DbDjAOIvffeMukGSN2sjYig9mE+3w4GHO+8A==", new DateTime(2023, 10, 28, 16, 2, 5, 377, DateTimeKind.Utc).AddTicks(3856) },
                    { 26, new DateTime(2023, 10, 28, 16, 2, 5, 446, DateTimeKind.Utc).AddTicks(8975), "hope.ferry@email.com", "Hope", "Ferry", "AQAAAAIAAYagAAAAEC1us6dWKopCsUD+UIfsA3rGdQi8j1/O6D5LIS5/c9PoVnrDc294JGWsPfMX9/BTlw==", new DateTime(2023, 10, 28, 16, 2, 5, 446, DateTimeKind.Utc).AddTicks(8976) },
                    { 27, new DateTime(2023, 10, 28, 16, 2, 5, 515, DateTimeKind.Utc).AddTicks(6838), "demond.orn@email.com", "Demond", "Orn", "AQAAAAIAAYagAAAAEApfPfi1z1iyJCclAyzqZmzA/suy4szn4s5VzlKwU7zm1jPxtf/G7ym1bvfd6de5og==", new DateTime(2023, 10, 28, 16, 2, 5, 515, DateTimeKind.Utc).AddTicks(6841) },
                    { 28, new DateTime(2023, 10, 28, 16, 2, 5, 585, DateTimeKind.Utc).AddTicks(8254), "jamaal.metz@email.com", "Jamaal", "Metz", "AQAAAAIAAYagAAAAEA/KBhVR0cVDMEkXBavaar9FjCTLKNB1f/f6tpTT0fNpCcietuKcbFkltz9LIgg3Wg==", new DateTime(2023, 10, 28, 16, 2, 5, 585, DateTimeKind.Utc).AddTicks(8255) },
                    { 29, new DateTime(2023, 10, 28, 16, 2, 5, 655, DateTimeKind.Utc).AddTicks(8781), "nels.dickinson@email.com", "Nels", "Dickinson", "AQAAAAIAAYagAAAAELmWOLhQ3LBOVZKewk8XRwDZbejBcoQFgo7aEpB5f15s0FQ4NPcF9SlEwz+RtvaoGA==", new DateTime(2023, 10, 28, 16, 2, 5, 655, DateTimeKind.Utc).AddTicks(8782) },
                    { 30, new DateTime(2023, 10, 28, 16, 2, 5, 725, DateTimeKind.Utc).AddTicks(6645), "terry.macgyver@email.com", "Terry", "MacGyver", "AQAAAAIAAYagAAAAEK3b576qP801iHkMcbtReZtj00IewN3YtBC4Jm1HJljXOmXmPcjK0Z/CxluDryjljw==", new DateTime(2023, 10, 28, 16, 2, 5, 725, DateTimeKind.Utc).AddTicks(6646) },
                    { 31, new DateTime(2023, 10, 28, 16, 2, 5, 794, DateTimeKind.Utc).AddTicks(5799), "reuben.price@email.com", "Reuben", "Price", "AQAAAAIAAYagAAAAEHEmsEc91Qda6+5eXAgTljW/YKh7J/FYT9qpgOy2k8UAnMw9WB7qOZU8ezpHRtdhiA==", new DateTime(2023, 10, 28, 16, 2, 5, 794, DateTimeKind.Utc).AddTicks(5801) },
                    { 32, new DateTime(2023, 10, 28, 16, 2, 5, 864, DateTimeKind.Utc).AddTicks(5969), "jolie.strosin@email.com", "Jolie", "Strosin", "AQAAAAIAAYagAAAAEPCNRBTBK7jAQ3nqFnM7YAk59iyW9PXMDhHzwMmFoiF0U+96bnmGNoqdJPwtUTj1Ew==", new DateTime(2023, 10, 28, 16, 2, 5, 864, DateTimeKind.Utc).AddTicks(5969) },
                    { 33, new DateTime(2023, 10, 28, 16, 2, 5, 934, DateTimeKind.Utc).AddTicks(6879), "keshaun.hackett@email.com", "Keshaun", "Hackett", "AQAAAAIAAYagAAAAEJoBbncN8vCEJqRrWxHbSfCTovi2Kc7eOXhReB38LuJ/WgcQoJ0bYo2HqI8stf7hgg==", new DateTime(2023, 10, 28, 16, 2, 5, 934, DateTimeKind.Utc).AddTicks(6880) },
                    { 34, new DateTime(2023, 10, 28, 16, 2, 6, 5, DateTimeKind.Utc).AddTicks(179), "gus.romaguera@email.com", "Gus", "Romaguera", "AQAAAAIAAYagAAAAEF93Cg9nl3Pp0zPdVhbh/sdODjErlehFrjGAOgDdqocShm2bBA04vLSnw7uJBDyriQ==", new DateTime(2023, 10, 28, 16, 2, 6, 5, DateTimeKind.Utc).AddTicks(180) },
                    { 35, new DateTime(2023, 10, 28, 16, 2, 6, 75, DateTimeKind.Utc).AddTicks(464), "rollin.boehm@email.com", "Rollin", "Boehm", "AQAAAAIAAYagAAAAEL2V51eryf5wLMcDi4Fc30UjTzqIn6H9JGuHqovbTUnmYlp6ngLSHbJxCUUOj0SeDg==", new DateTime(2023, 10, 28, 16, 2, 6, 75, DateTimeKind.Utc).AddTicks(465) },
                    { 36, new DateTime(2023, 10, 28, 16, 2, 6, 145, DateTimeKind.Utc).AddTicks(2835), "arlie.franecki@email.com", "Arlie", "Franecki", "AQAAAAIAAYagAAAAENUd3W5HDofkV7cmYgODVrJV9yRE+gZ8mbCALuY+2hkIGry719OUcsv/suBJG4T3+w==", new DateTime(2023, 10, 28, 16, 2, 6, 145, DateTimeKind.Utc).AddTicks(2841) },
                    { 37, new DateTime(2023, 10, 28, 16, 2, 6, 214, DateTimeKind.Utc).AddTicks(6522), "leif.wisozk@email.com", "Leif", "Wisozk", "AQAAAAIAAYagAAAAEH6xDRTT4Gpj/Gp0yfVZ1pX4Q8ijmyN+GkwKPZj7LzxyB6SNKF5zQICaK0j4LJbv7w==", new DateTime(2023, 10, 28, 16, 2, 6, 214, DateTimeKind.Utc).AddTicks(6525) },
                    { 38, new DateTime(2023, 10, 28, 16, 2, 6, 284, DateTimeKind.Utc).AddTicks(2650), "katelyn.jaskolski@email.com", "Katelyn", "Jaskolski", "AQAAAAIAAYagAAAAEG3SdVRYHvcVT6wLu37il0x650BQ0N6usGdWRowSlHTWOeV02kgPG5cYUphp2V2tIA==", new DateTime(2023, 10, 28, 16, 2, 6, 284, DateTimeKind.Utc).AddTicks(2652) },
                    { 39, new DateTime(2023, 10, 28, 16, 2, 6, 354, DateTimeKind.Utc).AddTicks(4011), "howell.ritchie@email.com", "Howell", "Ritchie", "AQAAAAIAAYagAAAAEHx5Cs6qqtFwGd+SZ8pWRcjHHGqZzjw6AYR/g9wv5Ja3V5UFuBw63wL8zmLiDdX3/A==", new DateTime(2023, 10, 28, 16, 2, 6, 354, DateTimeKind.Utc).AddTicks(4012) },
                    { 40, new DateTime(2023, 10, 28, 16, 2, 6, 423, DateTimeKind.Utc).AddTicks(7152), "alexandrea.lind@email.com", "Alexandrea", "Lind", "AQAAAAIAAYagAAAAEG5dwD6NHdo6xg/JK/pKcsFhV/7CgTtcCFpLBGRjor5O3Z5vI8z/Ewyb99x749Sb4A==", new DateTime(2023, 10, 28, 16, 2, 6, 423, DateTimeKind.Utc).AddTicks(7155) },
                    { 41, new DateTime(2023, 10, 28, 16, 2, 6, 493, DateTimeKind.Utc).AddTicks(1175), "kali.o'hara@email.com", "Kali", "O'Hara", "AQAAAAIAAYagAAAAEEA/yMwlBT3tmS99PdAWJ+oMYbJYlS5AF5oG9/IZq3eVKAtSMeCUrbsPo3o1Pz28OQ==", new DateTime(2023, 10, 28, 16, 2, 6, 493, DateTimeKind.Utc).AddTicks(1177) },
                    { 42, new DateTime(2023, 10, 28, 16, 2, 6, 563, DateTimeKind.Utc).AddTicks(2125), "samanta.streich@email.com", "Samanta", "Streich", "AQAAAAIAAYagAAAAECcchjJOsW1iSB7cVqfTQxfiKp2k1JFLB+4VT9nsqj6ynuHWkPD+kYmnWSrlcDqelA==", new DateTime(2023, 10, 28, 16, 2, 6, 563, DateTimeKind.Utc).AddTicks(2129) },
                    { 43, new DateTime(2023, 10, 28, 16, 2, 6, 632, DateTimeKind.Utc).AddTicks(7106), "dolly.prosacco@email.com", "Dolly", "Prosacco", "AQAAAAIAAYagAAAAECrng+71NqiRgN//8c9SVYMkVjy0lFbCDU3jZWmORAqiTFy+7NVWszbelVHyfumdcQ==", new DateTime(2023, 10, 28, 16, 2, 6, 632, DateTimeKind.Utc).AddTicks(7109) },
                    { 44, new DateTime(2023, 10, 28, 16, 2, 6, 702, DateTimeKind.Utc).AddTicks(6397), "celestino.bahringer@email.com", "Celestino", "Bahringer", "AQAAAAIAAYagAAAAEA0dcEiyW8KKrSERfsjICTWUEw5k+IuLien9WUuFJCLxXi1nURNkl/g9+cJ6gC1eMQ==", new DateTime(2023, 10, 28, 16, 2, 6, 702, DateTimeKind.Utc).AddTicks(6399) },
                    { 45, new DateTime(2023, 10, 28, 16, 2, 6, 772, DateTimeKind.Utc).AddTicks(520), "jedidiah.glover@email.com", "Jedidiah", "Glover", "AQAAAAIAAYagAAAAEIU8MTw2cCGUnvpQV6SV+bM0H8QdmO39kpTbNMhEyc1gzHjtN6k6Ugr6+KgAoLqhMw==", new DateTime(2023, 10, 28, 16, 2, 6, 772, DateTimeKind.Utc).AddTicks(521) },
                    { 46, new DateTime(2023, 10, 28, 16, 2, 6, 842, DateTimeKind.Utc).AddTicks(1118), "schuyler.jaskolski@email.com", "Schuyler", "Jaskolski", "AQAAAAIAAYagAAAAEH6MgqtlH8iOCUT0LGOnb+9SXvf/kvzxebWWmtjKl59JUCNDin0DnebDPI8Dw7qUQA==", new DateTime(2023, 10, 28, 16, 2, 6, 842, DateTimeKind.Utc).AddTicks(1119) },
                    { 47, new DateTime(2023, 10, 28, 16, 2, 6, 911, DateTimeKind.Utc).AddTicks(9754), "faye.hilll@email.com", "Faye", "Hilll", "AQAAAAIAAYagAAAAEAyGxlEOxVXNPKMImobUC3UQAR1cwOaQaX3wgSfYs9U4zzDBXVKYOCwQS3J0sKmQng==", new DateTime(2023, 10, 28, 16, 2, 6, 911, DateTimeKind.Utc).AddTicks(9755) },
                    { 48, new DateTime(2023, 10, 28, 16, 2, 6, 982, DateTimeKind.Utc).AddTicks(3479), "johathan.hahn@email.com", "Johathan", "Hahn", "AQAAAAIAAYagAAAAEMm8tBjFrAgJpfavWwJB3duzfDzWFxclIEXWMkHzZ3yk9Y70sVQaKXx84wkT77hjQA==", new DateTime(2023, 10, 28, 16, 2, 6, 982, DateTimeKind.Utc).AddTicks(3481) },
                    { 49, new DateTime(2023, 10, 28, 16, 2, 7, 50, DateTimeKind.Utc).AddTicks(8705), "eldred.mueller@email.com", "Eldred", "Mueller", "AQAAAAIAAYagAAAAEKNPmszAwH7w0Sbpk19ZAWev0WwpPFpNC6k/p256xkvHDjkY/cAN69EABSK9h6WUjw==", new DateTime(2023, 10, 28, 16, 2, 7, 50, DateTimeKind.Utc).AddTicks(8706) },
                    { 50, new DateTime(2023, 10, 28, 16, 2, 7, 120, DateTimeKind.Utc).AddTicks(605), "norma.conroy@email.com", "Norma", "Conroy", "AQAAAAIAAYagAAAAEPatxUW0p/mJlttJrIYpJkR+3fOacdusUfYLv+edotl+5fISr8nEpAcirVAel+akCQ==", new DateTime(2023, 10, 28, 16, 2, 7, 120, DateTimeKind.Utc).AddTicks(606) },
                    { 51, new DateTime(2023, 10, 28, 16, 2, 7, 190, DateTimeKind.Utc).AddTicks(3308), "joany.lindgren@email.com", "Joany", "Lindgren", "AQAAAAIAAYagAAAAEOs+3zreXraYI0bTwdULahQ3QkUSEQeadZ9HvyxG0ONDovNlLNZmX8gVQSdaqNv/Zw==", new DateTime(2023, 10, 28, 16, 2, 7, 190, DateTimeKind.Utc).AddTicks(3310) },
                    { 52, new DateTime(2023, 10, 28, 16, 2, 7, 259, DateTimeKind.Utc).AddTicks(8819), "rosario.howe@email.com", "Rosario", "Howe", "AQAAAAIAAYagAAAAEIAJoOJwVw6IIwI3y1EU0OwiizrWjxf2VZ8mVHRAfgdCctjaAjFdFA8IMnFk6X4FhA==", new DateTime(2023, 10, 28, 16, 2, 7, 259, DateTimeKind.Utc).AddTicks(8821) },
                    { 53, new DateTime(2023, 10, 28, 16, 2, 7, 330, DateTimeKind.Utc).AddTicks(3227), "jacey.emmerich@email.com", "Jacey", "Emmerich", "AQAAAAIAAYagAAAAEDtG3P/tYTPQTeVYGDLONfwRRcp33SguIDTabQjKqoJXCytqi9dVt9mo2fwrYGGwvw==", new DateTime(2023, 10, 28, 16, 2, 7, 330, DateTimeKind.Utc).AddTicks(3229) },
                    { 54, new DateTime(2023, 10, 28, 16, 2, 7, 399, DateTimeKind.Utc).AddTicks(5883), "damian.bednar@email.com", "Damian", "Bednar", "AQAAAAIAAYagAAAAEIGv6hM0LBBpnFkp51vujTkMKWMljabKC7o89Z8qMhJEyT78d9yYrshAUD0wveCUFg==", new DateTime(2023, 10, 28, 16, 2, 7, 399, DateTimeKind.Utc).AddTicks(5884) },
                    { 55, new DateTime(2023, 10, 28, 16, 2, 7, 471, DateTimeKind.Utc).AddTicks(1499), "howell.hansen@email.com", "Howell", "Hansen", "AQAAAAIAAYagAAAAEO/Aid89OU29zq+Xo6XGkxfk99SEt88sM+nzFmrBY2Suis3Eyf5kJUtpGEuJGAzDTA==", new DateTime(2023, 10, 28, 16, 2, 7, 471, DateTimeKind.Utc).AddTicks(1501) },
                    { 56, new DateTime(2023, 10, 28, 16, 2, 7, 543, DateTimeKind.Utc).AddTicks(7794), "albert.williamson@email.com", "Albert", "Williamson", "AQAAAAIAAYagAAAAEA9IntEUTsO2Qvxk84n0tvm7GLjMqZ2JrH4hNO/ogdO/KnRvd0BGGJHWORQ/0pS22g==", new DateTime(2023, 10, 28, 16, 2, 7, 543, DateTimeKind.Utc).AddTicks(7796) },
                    { 57, new DateTime(2023, 10, 28, 16, 2, 7, 612, DateTimeKind.Utc).AddTicks(7146), "kaitlin.brown@email.com", "Kaitlin", "Brown", "AQAAAAIAAYagAAAAEESOv6Wlq/4JnMFspUZ79SztUmwuVbLC1a9er+FaiWvVYL39Iqhf643BVhvcQ5p6iw==", new DateTime(2023, 10, 28, 16, 2, 7, 612, DateTimeKind.Utc).AddTicks(7147) },
                    { 58, new DateTime(2023, 10, 28, 16, 2, 7, 682, DateTimeKind.Utc).AddTicks(8063), "ansley.stracke@email.com", "Ansley", "Stracke", "AQAAAAIAAYagAAAAEHH6fXu477MFYAjrY3uNSuPoe3YLRLFeSTjUbSasKdmBiitVTMhZjTHgJRM2UPHwRg==", new DateTime(2023, 10, 28, 16, 2, 7, 682, DateTimeKind.Utc).AddTicks(8064) },
                    { 59, new DateTime(2023, 10, 28, 16, 2, 7, 751, DateTimeKind.Utc).AddTicks(9058), "fritz.olson@email.com", "Fritz", "Olson", "AQAAAAIAAYagAAAAEOQ9q4ITwpxw8KRljneywbkifutSN9VOJafdm7xaltF7VqK8XpU7ao6GMfMIkblgtw==", new DateTime(2023, 10, 28, 16, 2, 7, 751, DateTimeKind.Utc).AddTicks(9060) },
                    { 60, new DateTime(2023, 10, 28, 16, 2, 7, 825, DateTimeKind.Utc).AddTicks(1735), "graciela.zulauf@email.com", "Graciela", "Zulauf", "AQAAAAIAAYagAAAAEIlQlLSzX29/oXXuIca+S7FzGvCMbJ8kHTJ3PZtcOf1kZF2Mv646u8vbbyGB+FneaA==", new DateTime(2023, 10, 28, 16, 2, 7, 825, DateTimeKind.Utc).AddTicks(1737) },
                    { 61, new DateTime(2023, 10, 28, 16, 2, 7, 897, DateTimeKind.Utc).AddTicks(4044), "shaylee.ernser@email.com", "Shaylee", "Ernser", "AQAAAAIAAYagAAAAEDIdYH5waVO56zP7ASWBZ4hfmBgmIcSRqgZQZxY+FfG8AJFRyRbpVbMTkp4nW6UtHg==", new DateTime(2023, 10, 28, 16, 2, 7, 897, DateTimeKind.Utc).AddTicks(4045) },
                    { 62, new DateTime(2023, 10, 28, 16, 2, 7, 972, DateTimeKind.Utc).AddTicks(6792), "uriel.kuhn@email.com", "Uriel", "Kuhn", "AQAAAAIAAYagAAAAEDDhc/3j6oE4ulS9Xl+CrCXyaAMn6EPNMwIuRTrjJUthRjkLpdjSWNShxgpU6svM6w==", new DateTime(2023, 10, 28, 16, 2, 7, 972, DateTimeKind.Utc).AddTicks(6795) },
                    { 63, new DateTime(2023, 10, 28, 16, 2, 8, 44, DateTimeKind.Utc).AddTicks(229), "erik.weimann@email.com", "Erik", "Weimann", "AQAAAAIAAYagAAAAEKUQw7cmyFy+YFGTwHJNFyIaIwPxcDxm+80WdW7KOSDZRIC1c+k8MaaP407oFTdOZw==", new DateTime(2023, 10, 28, 16, 2, 8, 44, DateTimeKind.Utc).AddTicks(229) },
                    { 64, new DateTime(2023, 10, 28, 16, 2, 8, 113, DateTimeKind.Utc).AddTicks(2686), "anahi.champlin@email.com", "Anahi", "Champlin", "AQAAAAIAAYagAAAAEG00w78tPKuMXWjZWvs1Q7GXyqjqa7YvTC5Al5l867KPXb44hOZSwvPZp9oX/wjskQ==", new DateTime(2023, 10, 28, 16, 2, 8, 113, DateTimeKind.Utc).AddTicks(2687) },
                    { 65, new DateTime(2023, 10, 28, 16, 2, 8, 184, DateTimeKind.Utc).AddTicks(3421), "allie.flatley@email.com", "Allie", "Flatley", "AQAAAAIAAYagAAAAEKqNBkcBEnRTh5ldSOoe/x3isEcOsXvwOhGFZSywoN/1txco5XHManDCTzhHKb5BTA==", new DateTime(2023, 10, 28, 16, 2, 8, 184, DateTimeKind.Utc).AddTicks(3423) },
                    { 66, new DateTime(2023, 10, 28, 16, 2, 8, 259, DateTimeKind.Utc).AddTicks(7146), "candelario.hand@email.com", "Candelario", "Hand", "AQAAAAIAAYagAAAAEN4Cqv8s3cwYdh/P2ZPE17huQtV4gvKJnFxyAhGVf68+27qSMuki75ijnJuhAuo3qQ==", new DateTime(2023, 10, 28, 16, 2, 8, 259, DateTimeKind.Utc).AddTicks(7148) },
                    { 67, new DateTime(2023, 10, 28, 16, 2, 8, 334, DateTimeKind.Utc).AddTicks(6208), "kevin.russel@email.com", "Kevin", "Russel", "AQAAAAIAAYagAAAAEJI6jdoXJdJmWGd3oYLsitCBGA7DRoyloOTUQcCEJ/8gFwrkI5GrXCR5/6D09/ernQ==", new DateTime(2023, 10, 28, 16, 2, 8, 334, DateTimeKind.Utc).AddTicks(6211) },
                    { 68, new DateTime(2023, 10, 28, 16, 2, 8, 411, DateTimeKind.Utc).AddTicks(8287), "dayton.bechtelar@email.com", "Dayton", "Bechtelar", "AQAAAAIAAYagAAAAEPed+yyNxuLDdzhqCi+JAx4wx+PvCKzTCTOJ596LWMGOl+G5DCC3jgTKdzbs40TMBg==", new DateTime(2023, 10, 28, 16, 2, 8, 411, DateTimeKind.Utc).AddTicks(8292) },
                    { 69, new DateTime(2023, 10, 28, 16, 2, 8, 483, DateTimeKind.Utc).AddTicks(6377), "superuser@mail.com", "super", "user", "AQAAAAIAAYagAAAAEPA1AwAzs6qY+jZMtpcNhx/Hd8IAAexkAoqGSWjxFjEXfxbfgoKKFjI2BBB6yNQSBw==", new DateTime(2023, 10, 28, 16, 2, 8, 483, DateTimeKind.Utc).AddTicks(6378) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Bio", "CreatedAt", "RoleType", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 10, 28, 16, 2, 3, 760, DateTimeKind.Utc).AddTicks(3033), 0, new DateTime(2023, 10, 28, 16, 2, 3, 760, DateTimeKind.Utc).AddTicks(3037), 1 },
                    { 2, null, new DateTime(2023, 10, 28, 16, 2, 3, 830, DateTimeKind.Utc).AddTicks(4395), 0, new DateTime(2023, 10, 28, 16, 2, 3, 830, DateTimeKind.Utc).AddTicks(4401), 2 },
                    { 3, null, new DateTime(2023, 10, 28, 16, 2, 3, 900, DateTimeKind.Utc).AddTicks(7899), 0, new DateTime(2023, 10, 28, 16, 2, 3, 900, DateTimeKind.Utc).AddTicks(7902), 3 },
                    { 4, null, new DateTime(2023, 10, 28, 16, 2, 3, 971, DateTimeKind.Utc).AddTicks(5454), 0, new DateTime(2023, 10, 28, 16, 2, 3, 971, DateTimeKind.Utc).AddTicks(5460), 4 },
                    { 5, null, new DateTime(2023, 10, 28, 16, 2, 4, 42, DateTimeKind.Utc).AddTicks(5141), 0, new DateTime(2023, 10, 28, 16, 2, 4, 42, DateTimeKind.Utc).AddTicks(5147), 5 },
                    { 6, null, new DateTime(2023, 10, 28, 16, 2, 4, 113, DateTimeKind.Utc).AddTicks(3823), 0, new DateTime(2023, 10, 28, 16, 2, 4, 113, DateTimeKind.Utc).AddTicks(3831), 6 },
                    { 7, null, new DateTime(2023, 10, 28, 16, 2, 4, 183, DateTimeKind.Utc).AddTicks(2447), 0, new DateTime(2023, 10, 28, 16, 2, 4, 183, DateTimeKind.Utc).AddTicks(2450), 7 },
                    { 8, null, new DateTime(2023, 10, 28, 16, 2, 4, 253, DateTimeKind.Utc).AddTicks(3690), 0, new DateTime(2023, 10, 28, 16, 2, 4, 253, DateTimeKind.Utc).AddTicks(3693), 8 },
                    { 9, null, new DateTime(2023, 10, 28, 16, 2, 4, 323, DateTimeKind.Utc).AddTicks(7651), 0, new DateTime(2023, 10, 28, 16, 2, 4, 323, DateTimeKind.Utc).AddTicks(7656), 9 },
                    { 10, null, new DateTime(2023, 10, 28, 16, 2, 4, 394, DateTimeKind.Utc).AddTicks(7556), 0, new DateTime(2023, 10, 28, 16, 2, 4, 394, DateTimeKind.Utc).AddTicks(7561), 10 },
                    { 11, null, new DateTime(2023, 10, 28, 16, 2, 4, 465, DateTimeKind.Utc).AddTicks(4695), 0, new DateTime(2023, 10, 28, 16, 2, 4, 465, DateTimeKind.Utc).AddTicks(4699), 11 },
                    { 12, null, new DateTime(2023, 10, 28, 16, 2, 4, 534, DateTimeKind.Utc).AddTicks(7738), 0, new DateTime(2023, 10, 28, 16, 2, 4, 534, DateTimeKind.Utc).AddTicks(7743), 12 },
                    { 13, null, new DateTime(2023, 10, 28, 16, 2, 4, 604, DateTimeKind.Utc).AddTicks(5582), 0, new DateTime(2023, 10, 28, 16, 2, 4, 604, DateTimeKind.Utc).AddTicks(5587), 13 },
                    { 14, null, new DateTime(2023, 10, 28, 16, 2, 4, 674, DateTimeKind.Utc).AddTicks(2155), 0, new DateTime(2023, 10, 28, 16, 2, 4, 674, DateTimeKind.Utc).AddTicks(2159), 14 },
                    { 15, null, new DateTime(2023, 10, 28, 16, 2, 4, 744, DateTimeKind.Utc).AddTicks(4105), 0, new DateTime(2023, 10, 28, 16, 2, 4, 744, DateTimeKind.Utc).AddTicks(4109), 15 },
                    { 16, null, new DateTime(2023, 10, 28, 16, 2, 4, 814, DateTimeKind.Utc).AddTicks(8637), 0, new DateTime(2023, 10, 28, 16, 2, 4, 814, DateTimeKind.Utc).AddTicks(8641), 16 },
                    { 17, null, new DateTime(2023, 10, 28, 16, 2, 4, 887, DateTimeKind.Utc).AddTicks(2151), 0, new DateTime(2023, 10, 28, 16, 2, 4, 887, DateTimeKind.Utc).AddTicks(2156), 17 },
                    { 18, null, new DateTime(2023, 10, 28, 16, 2, 4, 956, DateTimeKind.Utc).AddTicks(9744), 0, new DateTime(2023, 10, 28, 16, 2, 4, 956, DateTimeKind.Utc).AddTicks(9749), 18 },
                    { 19, null, new DateTime(2023, 10, 28, 16, 2, 5, 28, DateTimeKind.Utc).AddTicks(2261), 1, new DateTime(2023, 10, 28, 16, 2, 5, 28, DateTimeKind.Utc).AddTicks(2266), 19 },
                    { 20, null, new DateTime(2023, 10, 28, 16, 2, 5, 96, DateTimeKind.Utc).AddTicks(4893), 1, new DateTime(2023, 10, 28, 16, 2, 5, 96, DateTimeKind.Utc).AddTicks(4898), 20 },
                    { 21, null, new DateTime(2023, 10, 28, 16, 2, 5, 167, DateTimeKind.Utc).AddTicks(3133), 1, new DateTime(2023, 10, 28, 16, 2, 5, 167, DateTimeKind.Utc).AddTicks(3141), 21 },
                    { 22, null, new DateTime(2023, 10, 28, 16, 2, 5, 236, DateTimeKind.Utc).AddTicks(5136), 1, new DateTime(2023, 10, 28, 16, 2, 5, 236, DateTimeKind.Utc).AddTicks(5141), 22 },
                    { 23, null, new DateTime(2023, 10, 28, 16, 2, 5, 306, DateTimeKind.Utc).AddTicks(4498), 1, new DateTime(2023, 10, 28, 16, 2, 5, 306, DateTimeKind.Utc).AddTicks(4503), 23 },
                    { 24, null, new DateTime(2023, 10, 28, 16, 2, 5, 375, DateTimeKind.Utc).AddTicks(9109), 1, new DateTime(2023, 10, 28, 16, 2, 5, 375, DateTimeKind.Utc).AddTicks(9113), 24 },
                    { 25, null, new DateTime(2023, 10, 28, 16, 2, 5, 445, DateTimeKind.Utc).AddTicks(5399), 1, new DateTime(2023, 10, 28, 16, 2, 5, 445, DateTimeKind.Utc).AddTicks(5405), 25 },
                    { 26, null, new DateTime(2023, 10, 28, 16, 2, 5, 514, DateTimeKind.Utc).AddTicks(2769), 1, new DateTime(2023, 10, 28, 16, 2, 5, 514, DateTimeKind.Utc).AddTicks(2776), 26 },
                    { 27, null, new DateTime(2023, 10, 28, 16, 2, 5, 584, DateTimeKind.Utc).AddTicks(5232), 1, new DateTime(2023, 10, 28, 16, 2, 5, 584, DateTimeKind.Utc).AddTicks(5237), 27 },
                    { 28, null, new DateTime(2023, 10, 28, 16, 2, 5, 654, DateTimeKind.Utc).AddTicks(5382), 1, new DateTime(2023, 10, 28, 16, 2, 5, 654, DateTimeKind.Utc).AddTicks(5387), 28 },
                    { 29, null, new DateTime(2023, 10, 28, 16, 2, 5, 724, DateTimeKind.Utc).AddTicks(3166), 1, new DateTime(2023, 10, 28, 16, 2, 5, 724, DateTimeKind.Utc).AddTicks(3171), 29 },
                    { 30, null, new DateTime(2023, 10, 28, 16, 2, 5, 793, DateTimeKind.Utc).AddTicks(1707), 1, new DateTime(2023, 10, 28, 16, 2, 5, 793, DateTimeKind.Utc).AddTicks(1713), 30 },
                    { 31, null, new DateTime(2023, 10, 28, 16, 2, 5, 863, DateTimeKind.Utc).AddTicks(2409), 1, new DateTime(2023, 10, 28, 16, 2, 5, 863, DateTimeKind.Utc).AddTicks(2414), 31 },
                    { 32, null, new DateTime(2023, 10, 28, 16, 2, 5, 933, DateTimeKind.Utc).AddTicks(3727), 1, new DateTime(2023, 10, 28, 16, 2, 5, 933, DateTimeKind.Utc).AddTicks(3732), 32 },
                    { 33, null, new DateTime(2023, 10, 28, 16, 2, 6, 3, DateTimeKind.Utc).AddTicks(6662), 1, new DateTime(2023, 10, 28, 16, 2, 6, 3, DateTimeKind.Utc).AddTicks(6667), 33 },
                    { 34, null, new DateTime(2023, 10, 28, 16, 2, 6, 73, DateTimeKind.Utc).AddTicks(7096), 1, new DateTime(2023, 10, 28, 16, 2, 6, 73, DateTimeKind.Utc).AddTicks(7101), 34 },
                    { 35, null, new DateTime(2023, 10, 28, 16, 2, 6, 143, DateTimeKind.Utc).AddTicks(6724), 1, new DateTime(2023, 10, 28, 16, 2, 6, 143, DateTimeKind.Utc).AddTicks(6729), 35 },
                    { 36, null, new DateTime(2023, 10, 28, 16, 2, 6, 213, DateTimeKind.Utc).AddTicks(2931), 1, new DateTime(2023, 10, 28, 16, 2, 6, 213, DateTimeKind.Utc).AddTicks(2937), 36 },
                    { 37, null, new DateTime(2023, 10, 28, 16, 2, 6, 282, DateTimeKind.Utc).AddTicks(8362), 1, new DateTime(2023, 10, 28, 16, 2, 6, 282, DateTimeKind.Utc).AddTicks(8367), 37 },
                    { 38, null, new DateTime(2023, 10, 28, 16, 2, 6, 352, DateTimeKind.Utc).AddTicks(8585), 1, new DateTime(2023, 10, 28, 16, 2, 6, 352, DateTimeKind.Utc).AddTicks(8590), 38 },
                    { 39, null, new DateTime(2023, 10, 28, 16, 2, 6, 422, DateTimeKind.Utc).AddTicks(725), 1, new DateTime(2023, 10, 28, 16, 2, 6, 422, DateTimeKind.Utc).AddTicks(729), 39 },
                    { 40, null, new DateTime(2023, 10, 28, 16, 2, 6, 491, DateTimeKind.Utc).AddTicks(4459), 1, new DateTime(2023, 10, 28, 16, 2, 6, 491, DateTimeKind.Utc).AddTicks(4465), 40 },
                    { 41, null, new DateTime(2023, 10, 28, 16, 2, 6, 561, DateTimeKind.Utc).AddTicks(6126), 1, new DateTime(2023, 10, 28, 16, 2, 6, 561, DateTimeKind.Utc).AddTicks(6213), 41 },
                    { 42, null, new DateTime(2023, 10, 28, 16, 2, 6, 631, DateTimeKind.Utc).AddTicks(2929), 1, new DateTime(2023, 10, 28, 16, 2, 6, 631, DateTimeKind.Utc).AddTicks(2935), 42 },
                    { 43, null, new DateTime(2023, 10, 28, 16, 2, 6, 701, DateTimeKind.Utc).AddTicks(2871), 1, new DateTime(2023, 10, 28, 16, 2, 6, 701, DateTimeKind.Utc).AddTicks(2876), 43 },
                    { 44, null, new DateTime(2023, 10, 28, 16, 2, 6, 770, DateTimeKind.Utc).AddTicks(6163), 1, new DateTime(2023, 10, 28, 16, 2, 6, 770, DateTimeKind.Utc).AddTicks(6169), 44 },
                    { 45, null, new DateTime(2023, 10, 28, 16, 2, 6, 840, DateTimeKind.Utc).AddTicks(7209), 1, new DateTime(2023, 10, 28, 16, 2, 6, 840, DateTimeKind.Utc).AddTicks(7214), 45 },
                    { 46, null, new DateTime(2023, 10, 28, 16, 2, 6, 910, DateTimeKind.Utc).AddTicks(5750), 1, new DateTime(2023, 10, 28, 16, 2, 6, 910, DateTimeKind.Utc).AddTicks(5755), 46 },
                    { 47, null, new DateTime(2023, 10, 28, 16, 2, 6, 980, DateTimeKind.Utc).AddTicks(8674), 1, new DateTime(2023, 10, 28, 16, 2, 6, 980, DateTimeKind.Utc).AddTicks(8680), 47 },
                    { 48, null, new DateTime(2023, 10, 28, 16, 2, 7, 49, DateTimeKind.Utc).AddTicks(5431), 1, new DateTime(2023, 10, 28, 16, 2, 7, 49, DateTimeKind.Utc).AddTicks(5436), 48 },
                    { 49, null, new DateTime(2023, 10, 28, 16, 2, 7, 118, DateTimeKind.Utc).AddTicks(6514), 1, new DateTime(2023, 10, 28, 16, 2, 7, 118, DateTimeKind.Utc).AddTicks(6518), 49 },
                    { 50, null, new DateTime(2023, 10, 28, 16, 2, 7, 188, DateTimeKind.Utc).AddTicks(9934), 1, new DateTime(2023, 10, 28, 16, 2, 7, 188, DateTimeKind.Utc).AddTicks(9939), 50 },
                    { 51, null, new DateTime(2023, 10, 28, 16, 2, 7, 258, DateTimeKind.Utc).AddTicks(5451), 1, new DateTime(2023, 10, 28, 16, 2, 7, 258, DateTimeKind.Utc).AddTicks(5459), 51 },
                    { 52, null, new DateTime(2023, 10, 28, 16, 2, 7, 329, DateTimeKind.Utc).AddTicks(136), 1, new DateTime(2023, 10, 28, 16, 2, 7, 329, DateTimeKind.Utc).AddTicks(144), 52 },
                    { 53, null, new DateTime(2023, 10, 28, 16, 2, 7, 398, DateTimeKind.Utc).AddTicks(2549), 1, new DateTime(2023, 10, 28, 16, 2, 7, 398, DateTimeKind.Utc).AddTicks(2553), 53 },
                    { 54, null, new DateTime(2023, 10, 28, 16, 2, 7, 469, DateTimeKind.Utc).AddTicks(7253), 1, new DateTime(2023, 10, 28, 16, 2, 7, 469, DateTimeKind.Utc).AddTicks(7258), 54 },
                    { 55, null, new DateTime(2023, 10, 28, 16, 2, 7, 542, DateTimeKind.Utc).AddTicks(4107), 1, new DateTime(2023, 10, 28, 16, 2, 7, 542, DateTimeKind.Utc).AddTicks(4112), 55 },
                    { 56, null, new DateTime(2023, 10, 28, 16, 2, 7, 611, DateTimeKind.Utc).AddTicks(3399), 1, new DateTime(2023, 10, 28, 16, 2, 7, 611, DateTimeKind.Utc).AddTicks(3405), 56 },
                    { 57, null, new DateTime(2023, 10, 28, 16, 2, 7, 681, DateTimeKind.Utc).AddTicks(4682), 1, new DateTime(2023, 10, 28, 16, 2, 7, 681, DateTimeKind.Utc).AddTicks(4688), 57 },
                    { 58, null, new DateTime(2023, 10, 28, 16, 2, 7, 750, DateTimeKind.Utc).AddTicks(6021), 1, new DateTime(2023, 10, 28, 16, 2, 7, 750, DateTimeKind.Utc).AddTicks(6026), 58 },
                    { 59, null, new DateTime(2023, 10, 28, 16, 2, 7, 823, DateTimeKind.Utc).AddTicks(7275), 1, new DateTime(2023, 10, 28, 16, 2, 7, 823, DateTimeKind.Utc).AddTicks(7280), 59 },
                    { 60, null, new DateTime(2023, 10, 28, 16, 2, 7, 896, DateTimeKind.Utc).AddTicks(572), 1, new DateTime(2023, 10, 28, 16, 2, 7, 896, DateTimeKind.Utc).AddTicks(576), 60 },
                    { 61, null, new DateTime(2023, 10, 28, 16, 2, 7, 970, DateTimeKind.Utc).AddTicks(3734), 1, new DateTime(2023, 10, 28, 16, 2, 7, 970, DateTimeKind.Utc).AddTicks(3738), 61 },
                    { 62, null, new DateTime(2023, 10, 28, 16, 2, 8, 42, DateTimeKind.Utc).AddTicks(7061), 1, new DateTime(2023, 10, 28, 16, 2, 8, 42, DateTimeKind.Utc).AddTicks(7066), 62 },
                    { 63, null, new DateTime(2023, 10, 28, 16, 2, 8, 111, DateTimeKind.Utc).AddTicks(8059), 1, new DateTime(2023, 10, 28, 16, 2, 8, 111, DateTimeKind.Utc).AddTicks(8064), 63 },
                    { 64, null, new DateTime(2023, 10, 28, 16, 2, 8, 182, DateTimeKind.Utc).AddTicks(8542), 1, new DateTime(2023, 10, 28, 16, 2, 8, 182, DateTimeKind.Utc).AddTicks(8549), 64 },
                    { 65, null, new DateTime(2023, 10, 28, 16, 2, 8, 258, DateTimeKind.Utc).AddTicks(3621), 1, new DateTime(2023, 10, 28, 16, 2, 8, 258, DateTimeKind.Utc).AddTicks(3626), 65 },
                    { 66, null, new DateTime(2023, 10, 28, 16, 2, 8, 332, DateTimeKind.Utc).AddTicks(9388), 1, new DateTime(2023, 10, 28, 16, 2, 8, 332, DateTimeKind.Utc).AddTicks(9394), 66 },
                    { 67, null, new DateTime(2023, 10, 28, 16, 2, 8, 410, DateTimeKind.Utc).AddTicks(3455), 1, new DateTime(2023, 10, 28, 16, 2, 8, 410, DateTimeKind.Utc).AddTicks(3463), 67 },
                    { 68, null, new DateTime(2023, 10, 28, 16, 2, 8, 483, DateTimeKind.Utc).AddTicks(6227), 1, new DateTime(2023, 10, 28, 16, 2, 8, 483, DateTimeKind.Utc).AddTicks(6231), 68 },
                    { 70, null, new DateTime(2023, 10, 28, 16, 2, 8, 553, DateTimeKind.Utc).AddTicks(8610), 2, new DateTime(2023, 10, 28, 16, 2, 8, 553, DateTimeKind.Utc).AddTicks(8615), 69 }
                });

            migrationBuilder.InsertData(
                table: "UserInstruments",
                columns: new[] { "InstrumentId", "UserId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 28, 16, 2, 3, 760, DateTimeKind.Utc).AddTicks(3048), new DateTime(2023, 10, 28, 16, 2, 3, 760, DateTimeKind.Utc).AddTicks(3049) },
                    { 2, 2, new DateTime(2023, 10, 28, 16, 2, 3, 830, DateTimeKind.Utc).AddTicks(4409), new DateTime(2023, 10, 28, 16, 2, 3, 830, DateTimeKind.Utc).AddTicks(4409) },
                    { 3, 3, new DateTime(2023, 10, 28, 16, 2, 3, 900, DateTimeKind.Utc).AddTicks(7911), new DateTime(2023, 10, 28, 16, 2, 3, 900, DateTimeKind.Utc).AddTicks(7911) },
                    { 4, 4, new DateTime(2023, 10, 28, 16, 2, 3, 971, DateTimeKind.Utc).AddTicks(5469), new DateTime(2023, 10, 28, 16, 2, 3, 971, DateTimeKind.Utc).AddTicks(5469) },
                    { 5, 5, new DateTime(2023, 10, 28, 16, 2, 4, 42, DateTimeKind.Utc).AddTicks(5156), new DateTime(2023, 10, 28, 16, 2, 4, 42, DateTimeKind.Utc).AddTicks(5156) },
                    { 6, 6, new DateTime(2023, 10, 28, 16, 2, 4, 113, DateTimeKind.Utc).AddTicks(3838), new DateTime(2023, 10, 28, 16, 2, 4, 113, DateTimeKind.Utc).AddTicks(3838) },
                    { 7, 7, new DateTime(2023, 10, 28, 16, 2, 4, 183, DateTimeKind.Utc).AddTicks(2456), new DateTime(2023, 10, 28, 16, 2, 4, 183, DateTimeKind.Utc).AddTicks(2456) },
                    { 8, 8, new DateTime(2023, 10, 28, 16, 2, 4, 253, DateTimeKind.Utc).AddTicks(3703), new DateTime(2023, 10, 28, 16, 2, 4, 253, DateTimeKind.Utc).AddTicks(3703) },
                    { 9, 9, new DateTime(2023, 10, 28, 16, 2, 4, 323, DateTimeKind.Utc).AddTicks(7664), new DateTime(2023, 10, 28, 16, 2, 4, 323, DateTimeKind.Utc).AddTicks(7665) },
                    { 11, 10, new DateTime(2023, 10, 28, 16, 2, 4, 394, DateTimeKind.Utc).AddTicks(7573), new DateTime(2023, 10, 28, 16, 2, 4, 394, DateTimeKind.Utc).AddTicks(7573) },
                    { 12, 11, new DateTime(2023, 10, 28, 16, 2, 4, 465, DateTimeKind.Utc).AddTicks(4710), new DateTime(2023, 10, 28, 16, 2, 4, 465, DateTimeKind.Utc).AddTicks(4711) },
                    { 13, 12, new DateTime(2023, 10, 28, 16, 2, 4, 534, DateTimeKind.Utc).AddTicks(7751), new DateTime(2023, 10, 28, 16, 2, 4, 534, DateTimeKind.Utc).AddTicks(7751) },
                    { 14, 13, new DateTime(2023, 10, 28, 16, 2, 4, 604, DateTimeKind.Utc).AddTicks(5597), new DateTime(2023, 10, 28, 16, 2, 4, 604, DateTimeKind.Utc).AddTicks(5598) },
                    { 15, 14, new DateTime(2023, 10, 28, 16, 2, 4, 674, DateTimeKind.Utc).AddTicks(2167), new DateTime(2023, 10, 28, 16, 2, 4, 674, DateTimeKind.Utc).AddTicks(2167) },
                    { 17, 15, new DateTime(2023, 10, 28, 16, 2, 4, 744, DateTimeKind.Utc).AddTicks(4117), new DateTime(2023, 10, 28, 16, 2, 4, 744, DateTimeKind.Utc).AddTicks(4117) },
                    { 18, 16, new DateTime(2023, 10, 28, 16, 2, 4, 814, DateTimeKind.Utc).AddTicks(8653), new DateTime(2023, 10, 28, 16, 2, 4, 814, DateTimeKind.Utc).AddTicks(8653) },
                    { 19, 17, new DateTime(2023, 10, 28, 16, 2, 4, 887, DateTimeKind.Utc).AddTicks(2164), new DateTime(2023, 10, 28, 16, 2, 4, 887, DateTimeKind.Utc).AddTicks(2164) },
                    { 20, 18, new DateTime(2023, 10, 28, 16, 2, 4, 956, DateTimeKind.Utc).AddTicks(9759), new DateTime(2023, 10, 28, 16, 2, 4, 956, DateTimeKind.Utc).AddTicks(9759) }
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
