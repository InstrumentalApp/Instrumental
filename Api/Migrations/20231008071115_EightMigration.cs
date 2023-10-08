using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class EightMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4397), new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4401), new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4403), new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(6970), new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(7138), new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(7155), new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(7173), new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(7202), new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(7221), new DateTime(2023, 10, 8, 7, 11, 15, 75, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "Description", "InstructorId", "LessonTypeId", "OnlineAvailable", "PricePerLesson", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4431), "First Lesson: $50 per lesson", 3, 1, true, 50, new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4432) },
                    { 2, new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4438), "Second Lesson: $100 per lesson", 3, 2, false, 100, new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4438) },
                    { 3, new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4440), "Third Lesson: $150 per lesson", 4, 3, true, 150, new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4441) },
                    { 4, new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4443), "Fourth Lesson: $200 per lesson", 4, 4, false, 200, new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4443) }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4323), new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4335), new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4337), new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 80, DateTimeKind.Utc).AddTicks(4380), "AQAAAAIAAYagAAAAELhp+FQs5ULwKR1yxEUdikDkcKbMwXaAkBadBVBGwj90Ox7pHSQ0034VADyArKUc0Q==", new DateTime(2023, 10, 8, 7, 11, 15, 80, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 156, DateTimeKind.Utc).AddTicks(1538), "AQAAAAIAAYagAAAAEIdDw27L0s1+Pl/sqJxyExHvLink+SRr0z8tU5Ans3VvwBxk+kib16SQ/KnCyyXmlg==", new DateTime(2023, 10, 8, 7, 11, 15, 156, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 232, DateTimeKind.Utc).AddTicks(984), "AQAAAAIAAYagAAAAEJtLW+QWCabpCC78GAV95USS2ysiv0lMWMm8A+dLf6sk7SclEh7hbM0BAvCIsa+63Q==", new DateTime(2023, 10, 8, 7, 11, 15, 232, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 313, DateTimeKind.Utc).AddTicks(1570), "AQAAAAIAAYagAAAAEBNA5NOZjQiNhtWj4bI6OLaJwTQeJBUSVAvQLmMT6PMyOoZWsWiM79nuHIIgktHBXg==", new DateTime(2023, 10, 8, 7, 11, 15, 313, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 403, DateTimeKind.Utc).AddTicks(5014), "AQAAAAIAAYagAAAAEAoRUFXnBmFQUibJbr8KIVpqD4LX6gx19SHPPFskHlJf+FiAp1YIJx7Ut4JlD4Cw8Q==", new DateTime(2023, 10, 8, 7, 11, 15, 403, DateTimeKind.Utc).AddTicks(5018) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4205), new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4212), new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4214), new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4242), new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4456), new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4493), new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4520), new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4563), new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4597), new DateTime(2023, 10, 8, 6, 47, 26, 882, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4116), new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4127), new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4131), new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 26, 886, DateTimeKind.Utc).AddTicks(9492), "AQAAAAIAAYagAAAAEOQvKnpQ6DB3FLn5xqTxr5KVMifwMJjcD22AWFqqWwomk4JlG0tNjHoXwXgU92Hm0Q==", new DateTime(2023, 10, 8, 6, 47, 26, 886, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 26, 962, DateTimeKind.Utc).AddTicks(8775), "AQAAAAIAAYagAAAAEDZJNi2p7r82tMaEwWleSpDmXNhU7hEjSoW6uZ4UCycsC4BwedKgxCgaWHj9N0xkYQ==", new DateTime(2023, 10, 8, 6, 47, 26, 962, DateTimeKind.Utc).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 27, 41, DateTimeKind.Utc).AddTicks(3881), "AQAAAAIAAYagAAAAEM8E6Eq8kX4H24eIkJ4N+Qlxv1ZBhMyXDzcfVhyfkhg5/966sZnAImzD0lE3DrOEOg==", new DateTime(2023, 10, 8, 6, 47, 27, 41, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 27, 134, DateTimeKind.Utc).AddTicks(3662), "AQAAAAIAAYagAAAAEMdIclibb+QY40W3lc1D8BYCauNlBJSEtTnvmDZ9i20NTdH2yT9VEWv2KCctG3EApA==", new DateTime(2023, 10, 8, 6, 47, 27, 134, DateTimeKind.Utc).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 6, 47, 27, 219, DateTimeKind.Utc).AddTicks(1296), "AQAAAAIAAYagAAAAENIfFi2ocmMZyRSi/g6qP/ukWzoRHwAJzlBfivGYnV4o07zKk5I+Zl8y3YataSyXrw==", new DateTime(2023, 10, 8, 6, 47, 27, 219, DateTimeKind.Utc).AddTicks(1300) });
        }
    }
}
