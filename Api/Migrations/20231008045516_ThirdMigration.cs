using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Category", "CreatedAt", "InstrumentName", "UpdatedAt" },
                values: new object[] { "String Instruments", new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1544), "Electric Guitar", new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "Category", "CreatedAt", "InstrumentName", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, "String Instruments", new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1560), "Violin", new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1560) },
                    { 4, "Woodwind Instruments", new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1574), "Flute", new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1574) },
                    { 5, "Woodwind Instruments", new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1586), "Clarinet", new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1586) },
                    { 6, "Woodwind Instruments", new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1602), "Saxophone", new DateTime(2023, 10, 8, 4, 55, 15, 478, DateTimeKind.Utc).AddTicks(1602) }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4562), new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "CreatedAt", "InstrumentName", "UpdatedAt" },
                values: new object[] { "Woodwind Instruments", new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4718), "Flute", new DateTime(2023, 10, 6, 5, 51, 31, 758, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 6, 5, 51, 31, 760, DateTimeKind.Utc).AddTicks(3073), "AQAAAAIAAYagAAAAEAgGpUHvu7aI9ipHU0CW6SpG3077I4CZIFe9BOfAyn4neJ1iOfhvJ2fiRuey+WTWFg==", new DateTime(2023, 10, 6, 5, 51, 31, 760, DateTimeKind.Utc).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 6, 5, 51, 31, 832, DateTimeKind.Utc).AddTicks(9323), "AQAAAAIAAYagAAAAEO0f1l4t5IjbAVRfwYW1z1NanF7mjPAHiQ/vS6cHPb6yX/Dr9aS0fBbuhj3BClvCjA==", new DateTime(2023, 10, 6, 5, 51, 31, 832, DateTimeKind.Utc).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 6, 5, 51, 31, 905, DateTimeKind.Utc).AddTicks(5649), "AQAAAAIAAYagAAAAEJwuTdib122kdIYFvHCZG31Q4rzZcpdFcVREdJ8VZmJgrAnedGrgkFYROEQETl0Fyw==", new DateTime(2023, 10, 6, 5, 51, 31, 905, DateTimeKind.Utc).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 6, 5, 51, 31, 978, DateTimeKind.Utc).AddTicks(2706), "AQAAAAIAAYagAAAAEAJVExwPc2dqmBdYW3jXHWIKbDuQBW4kbGuJhH9A3etekHkOYG+6t8rk7CVfoJrqnA==", new DateTime(2023, 10, 6, 5, 51, 31, 978, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 6, 5, 51, 32, 52, DateTimeKind.Utc).AddTicks(1348), "AQAAAAIAAYagAAAAEGQBxSF1ZPNY+UW2ByIL02OTcC+S858y5Nf2fsNQ0p37evB7o7A4vvIWbTdyOvL3PA==", new DateTime(2023, 10, 6, 5, 51, 32, 52, DateTimeKind.Utc).AddTicks(1352) });
        }
    }
}
