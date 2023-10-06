using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InstrumentName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "Category", "CreatedAt", "InstrumentName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "String Instruments", new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4562), "Acoustic Guitar", new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4565) },
                    { 2, "Woodwind Instruments", new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4718), "Flute", new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4719) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 6, 5, 51, 31, 760, DateTimeKind.Utc).AddTicks(3073), "a@email.com", "John", "Doe", "AQAAAAIAAYagAAAAEAgGpUHvu7aI9ipHU0CW6SpG3077I4CZIFe9BOfAyn4neJ1iOfhvJ2fiRuey+WTWFg==", new DateTime(2023, 10, 6, 5, 51, 31, 760, DateTimeKind.Utc).AddTicks(3076) },
                    { 2, new DateTime(2023, 10, 6, 5, 51, 31, 832, DateTimeKind.Utc).AddTicks(9323), "b@email.com", "Jane", "Smith", "AQAAAAIAAYagAAAAEO0f1l4t5IjbAVRfwYW1z1NanF7mjPAHiQ/vS6cHPb6yX/Dr9aS0fBbuhj3BClvCjA==", new DateTime(2023, 10, 6, 5, 51, 31, 832, DateTimeKind.Utc).AddTicks(9327) },
                    { 3, new DateTime(2023, 10, 6, 5, 51, 31, 905, DateTimeKind.Utc).AddTicks(5649), "c@email.com", "Alice", "Johnson", "AQAAAAIAAYagAAAAEJwuTdib122kdIYFvHCZG31Q4rzZcpdFcVREdJ8VZmJgrAnedGrgkFYROEQETl0Fyw==", new DateTime(2023, 10, 6, 5, 51, 31, 905, DateTimeKind.Utc).AddTicks(5653) },
                    { 4, new DateTime(2023, 10, 6, 5, 51, 31, 978, DateTimeKind.Utc).AddTicks(2706), "d@email.com", "Bob", "Williams", "AQAAAAIAAYagAAAAEAJVExwPc2dqmBdYW3jXHWIKbDuQBW4kbGuJhH9A3etekHkOYG+6t8rk7CVfoJrqnA==", new DateTime(2023, 10, 6, 5, 51, 31, 978, DateTimeKind.Utc).AddTicks(2710) },
                    { 5, new DateTime(2023, 10, 6, 5, 51, 32, 52, DateTimeKind.Utc).AddTicks(1348), "e@email.com", "Eve", "Davis", "AQAAAAIAAYagAAAAEGQBxSF1ZPNY+UW2ByIL02OTcC+S858y5Nf2fsNQ0p37evB7o7A4vvIWbTdyOvL3PA==", new DateTime(2023, 10, 6, 5, 51, 32, 52, DateTimeKind.Utc).AddTicks(1352) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
