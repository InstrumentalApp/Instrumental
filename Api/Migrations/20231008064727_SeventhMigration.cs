using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class SeventhMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "AcceptingNewStudents", "CreatedAt", "InstructorAboutMe", "Location", "UpdatedAt", "WillingToTravel", "YearsExperience" },
                values: new object[,]
                {
                    { 3, true, new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4205), "Best Floutist on the web", "Online", new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4205), false, 3 },
                    { 4, false, new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4212), "Teaching Guitar up and down the Coast.", "Sacremento, CA", new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4212), true, 10 },
                    { 5, true, new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4214), "When the student is ready, the teacher will appear.", "Hidden Cave, Sacred Mountains", new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4214), false, 100 }
                });

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

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Description", "FirstName", "LastName", "Location", "UpdatedAt", "WillingToTravel" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4127), "Second Student in DB", "Jane", "Smith", "Seattle, WA", new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4127), true },
                    { 5, new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4131), "When the student is truly ready, the teacher disappears.", "Eve", "Davis", "Hidden Cave, Sacred Mountains", new DateTime(2023, 10, 8, 6, 47, 27, 332, DateTimeKind.Utc).AddTicks(4131), false }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3143), new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3307), new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3324), new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3338), new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3368), new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3387), new DateTime(2023, 10, 8, 5, 48, 57, 701, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 58, 169, DateTimeKind.Utc).AddTicks(7425), new DateTime(2023, 10, 8, 5, 48, 58, 169, DateTimeKind.Utc).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 57, 707, DateTimeKind.Utc).AddTicks(106), "AQAAAAIAAYagAAAAEHeQAaFRuqK3oiWsBK9Hk2qkhIyBwF9sHX3p2XUJMLJdZ7bQYOmzjpI0DxwQucXaoQ==", new DateTime(2023, 10, 8, 5, 48, 57, 707, DateTimeKind.Utc).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 57, 791, DateTimeKind.Utc).AddTicks(9850), "AQAAAAIAAYagAAAAEDn3pvA2ud2i32Y2CW+bIZLA0Vl18MMPuxKtPfDUQDRVO/BcnztKWftFcVY7LQFNsw==", new DateTime(2023, 10, 8, 5, 48, 57, 791, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 57, 883, DateTimeKind.Utc).AddTicks(4716), "AQAAAAIAAYagAAAAEJShwNjV+Igzwlv8h7NbUJ5S84Njmn/dg8Lbbh0TQw5XMlaF/Sg/lfPQ70FQogbwxA==", new DateTime(2023, 10, 8, 5, 48, 57, 883, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 57, 962, DateTimeKind.Utc).AddTicks(5509), "AQAAAAIAAYagAAAAEPeKQJNzts/+yGFViCZbwMKJkefUnyIgaAbdiPiCqnWC9t8mYRmYML1LnRVhW7OB0A==", new DateTime(2023, 10, 8, 5, 48, 57, 962, DateTimeKind.Utc).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 48, 58, 51, DateTimeKind.Utc).AddTicks(7951), "AQAAAAIAAYagAAAAEL/XtRfSZlOcE3EpDDQ1ssLlWeM4EOznOw5G7Ipk3xH9Wny4HpN0CnncmdHdnJMtLA==", new DateTime(2023, 10, 8, 5, 48, 58, 51, DateTimeKind.Utc).AddTicks(7955) });
        }
    }
}
