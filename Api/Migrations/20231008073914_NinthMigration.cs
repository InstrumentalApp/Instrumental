using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class NinthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentLessonBookings_Lessons_LessonNameId",
                table: "StudentLessonBookings");

            migrationBuilder.DropIndex(
                name: "IX_StudentLessonBookings_LessonNameId",
                table: "StudentLessonBookings");

            migrationBuilder.DropColumn(
                name: "LessonNameId",
                table: "StudentLessonBookings");

            migrationBuilder.AddColumn<string>(
                name: "LessonName",
                table: "Lessons",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5965), new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5970), new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5971), new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6228), new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6423), new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6440), new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6453), new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6484), new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6503), new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LessonName", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6045), "Beginner Guitar", new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LessonName", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6051), "Intermediate Electric Guitar", new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LessonName", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6054), "Beginner Violin", new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LessonName", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6057), "Expert Flute", new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.InsertData(
                table: "StudentLessonBookings",
                columns: new[] { "LessonId", "StudentId", "BookingDate", "BookingNotes", "CreatedAt", "Id", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 8, 0, 39, 13, 837, DateTimeKind.Local).AddTicks(6104), "Notes for the first Booking", new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6094), 1, new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6095) },
                    { 3, 2, new DateTime(2023, 10, 8, 0, 39, 13, 837, DateTimeKind.Local).AddTicks(6186), "Notes for the second Booking", new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6184), 1, new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6185) }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5913), new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5924), new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5926), new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 415, DateTimeKind.Utc).AddTicks(5276), "AQAAAAIAAYagAAAAEKEnvwPZoQiLUuWOzzS+S57E3zxE8wbLQJ8cdC6PojR6V75re9Eosw1Vpm22XXYyJQ==", new DateTime(2023, 10, 8, 7, 39, 13, 415, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 491, DateTimeKind.Utc).AddTicks(6136), "AQAAAAIAAYagAAAAEMnZI3nxZXVBpJWuOdiGEgfI/hrYfC/Pwtaxyc68JGEjbUh+0rYY5TLpNKyGBhzl0Q==", new DateTime(2023, 10, 8, 7, 39, 13, 491, DateTimeKind.Utc).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 572, DateTimeKind.Utc).AddTicks(5638), "AQAAAAIAAYagAAAAEDi/PytRqjZNhHywmPXJhSNcCw7dN6QQWPnuD3K+w/zI66SgbPDMnQvpguyCR86+gA==", new DateTime(2023, 10, 8, 7, 39, 13, 572, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 650, DateTimeKind.Utc).AddTicks(712), "AQAAAAIAAYagAAAAEMAs0fG16m8SC/aRhSermx+gxoKHEIxTxjKLsX1K0aRxv6cHWdPR4Y/e099sDUNrvg==", new DateTime(2023, 10, 8, 7, 39, 13, 650, DateTimeKind.Utc).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 744, DateTimeKind.Utc).AddTicks(6068), "AQAAAAIAAYagAAAAENJ+6DEIFtSf65/ijpIffATpF8SRn0vp3IvW3zpn7RdIkmnM8HqjTxmlZ1b/MNlpPA==", new DateTime(2023, 10, 8, 7, 39, 13, 744, DateTimeKind.Utc).AddTicks(6072) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentLessonBookings",
                keyColumns: new[] { "LessonId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentLessonBookings",
                keyColumns: new[] { "LessonId", "StudentId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DropColumn(
                name: "LessonName",
                table: "Lessons");

            migrationBuilder.AddColumn<int>(
                name: "LessonNameId",
                table: "StudentLessonBookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4431), new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4438), new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4440), new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4443), new DateTime(2023, 10, 8, 7, 11, 15, 497, DateTimeKind.Utc).AddTicks(4443) });

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

            migrationBuilder.CreateIndex(
                name: "IX_StudentLessonBookings_LessonNameId",
                table: "StudentLessonBookings",
                column: "LessonNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentLessonBookings_Lessons_LessonNameId",
                table: "StudentLessonBookings",
                column: "LessonNameId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
