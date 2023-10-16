using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9048), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9206), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9225), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9257), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9276), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9296), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9310), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9330), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9344), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9362), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9374), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9402), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9419), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9450), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9463), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9477), new DateTime(2023, 10, 15, 19, 22, 47, 235, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 22, 52, 595, DateTimeKind.Local).AddTicks(6976), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(6967), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 22, 52, 595, DateTimeKind.Local).AddTicks(7055), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(7055), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 22, 52, 595, DateTimeKind.Local).AddTicks(7061), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(7060), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 22, 52, 595, DateTimeKind.Local).AddTicks(7066), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(7065), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 22, 52, 595, DateTimeKind.Local).AddTicks(8543), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8528), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 22, 52, 595, DateTimeKind.Local).AddTicks(8593), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8591), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 7,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 22, 52, 595, DateTimeKind.Local).AddTicks(8603), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8602), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 8,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 22, 52, 595, DateTimeKind.Local).AddTicks(8610), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8609), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 9,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 22, 52, 595, DateTimeKind.Local).AddTicks(8617), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8616), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 10,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 22, 52, 595, DateTimeKind.Local).AddTicks(8624), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8624), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 11,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 22, 52, 595, DateTimeKind.Local).AddTicks(8734), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8732), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 315, DateTimeKind.Utc).AddTicks(254), new DateTime(2023, 10, 15, 19, 22, 47, 315, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 391, DateTimeKind.Utc).AddTicks(1255), new DateTime(2023, 10, 15, 19, 22, 47, 391, DateTimeKind.Utc).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 487, DateTimeKind.Utc).AddTicks(4408), new DateTime(2023, 10, 15, 19, 22, 47, 487, DateTimeKind.Utc).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 573, DateTimeKind.Utc).AddTicks(1273), new DateTime(2023, 10, 15, 19, 22, 47, 573, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 664, DateTimeKind.Utc).AddTicks(756), new DateTime(2023, 10, 15, 19, 22, 47, 664, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 751, DateTimeKind.Utc).AddTicks(5419), new DateTime(2023, 10, 15, 19, 22, 47, 751, DateTimeKind.Utc).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 839, DateTimeKind.Utc).AddTicks(3568), new DateTime(2023, 10, 15, 19, 22, 47, 839, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 917, DateTimeKind.Utc).AddTicks(357), new DateTime(2023, 10, 15, 19, 22, 47, 917, DateTimeKind.Utc).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 992, DateTimeKind.Utc).AddTicks(6318), new DateTime(2023, 10, 15, 19, 22, 47, 992, DateTimeKind.Utc).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 69, DateTimeKind.Utc).AddTicks(5094), new DateTime(2023, 10, 15, 19, 22, 48, 69, DateTimeKind.Utc).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 150, DateTimeKind.Utc).AddTicks(545), new DateTime(2023, 10, 15, 19, 22, 48, 150, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 226, DateTimeKind.Utc).AddTicks(4075), new DateTime(2023, 10, 15, 19, 22, 48, 226, DateTimeKind.Utc).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 303, DateTimeKind.Utc).AddTicks(8014), new DateTime(2023, 10, 15, 19, 22, 48, 303, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 381, DateTimeKind.Utc).AddTicks(468), new DateTime(2023, 10, 15, 19, 22, 48, 381, DateTimeKind.Utc).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 459, DateTimeKind.Utc).AddTicks(5554), new DateTime(2023, 10, 15, 19, 22, 48, 459, DateTimeKind.Utc).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 536, DateTimeKind.Utc).AddTicks(2383), new DateTime(2023, 10, 15, 19, 22, 48, 536, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 611, DateTimeKind.Utc).AddTicks(8508), new DateTime(2023, 10, 15, 19, 22, 48, 611, DateTimeKind.Utc).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 688, DateTimeKind.Utc).AddTicks(8185), new DateTime(2023, 10, 15, 19, 22, 48, 688, DateTimeKind.Utc).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 766, DateTimeKind.Utc).AddTicks(6017), new DateTime(2023, 10, 15, 19, 22, 48, 766, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 844, DateTimeKind.Utc).AddTicks(6691), new DateTime(2023, 10, 15, 19, 22, 48, 844, DateTimeKind.Utc).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 921, DateTimeKind.Utc).AddTicks(1176), new DateTime(2023, 10, 15, 19, 22, 48, 921, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 998, DateTimeKind.Utc).AddTicks(1564), new DateTime(2023, 10, 15, 19, 22, 48, 998, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 75, DateTimeKind.Utc).AddTicks(7537), new DateTime(2023, 10, 15, 19, 22, 49, 75, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 155, DateTimeKind.Utc).AddTicks(485), new DateTime(2023, 10, 15, 19, 22, 49, 155, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 232, DateTimeKind.Utc).AddTicks(3608), new DateTime(2023, 10, 15, 19, 22, 49, 232, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 309, DateTimeKind.Utc).AddTicks(1026), new DateTime(2023, 10, 15, 19, 22, 49, 309, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 389, DateTimeKind.Utc).AddTicks(18), new DateTime(2023, 10, 15, 19, 22, 49, 389, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 470, DateTimeKind.Utc).AddTicks(2844), new DateTime(2023, 10, 15, 19, 22, 49, 470, DateTimeKind.Utc).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 547, DateTimeKind.Utc).AddTicks(3826), new DateTime(2023, 10, 15, 19, 22, 49, 547, DateTimeKind.Utc).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 623, DateTimeKind.Utc).AddTicks(3935), new DateTime(2023, 10, 15, 19, 22, 49, 623, DateTimeKind.Utc).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 699, DateTimeKind.Utc).AddTicks(6060), new DateTime(2023, 10, 15, 19, 22, 49, 699, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 777, DateTimeKind.Utc).AddTicks(999), new DateTime(2023, 10, 15, 19, 22, 49, 777, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 854, DateTimeKind.Utc).AddTicks(7874), new DateTime(2023, 10, 15, 19, 22, 49, 854, DateTimeKind.Utc).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 929, DateTimeKind.Utc).AddTicks(8084), new DateTime(2023, 10, 15, 19, 22, 49, 929, DateTimeKind.Utc).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 8, DateTimeKind.Utc).AddTicks(1250), new DateTime(2023, 10, 15, 19, 22, 50, 8, DateTimeKind.Utc).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 92, DateTimeKind.Utc).AddTicks(565), new DateTime(2023, 10, 15, 19, 22, 50, 92, DateTimeKind.Utc).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 168, DateTimeKind.Utc).AddTicks(31), new DateTime(2023, 10, 15, 19, 22, 50, 168, DateTimeKind.Utc).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 246, DateTimeKind.Utc).AddTicks(5444), new DateTime(2023, 10, 15, 19, 22, 50, 246, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 325, DateTimeKind.Utc).AddTicks(6665), new DateTime(2023, 10, 15, 19, 22, 50, 325, DateTimeKind.Utc).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 404, DateTimeKind.Utc).AddTicks(7630), new DateTime(2023, 10, 15, 19, 22, 50, 404, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 482, DateTimeKind.Utc).AddTicks(8156), new DateTime(2023, 10, 15, 19, 22, 50, 482, DateTimeKind.Utc).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 559, DateTimeKind.Utc).AddTicks(8648), new DateTime(2023, 10, 15, 19, 22, 50, 559, DateTimeKind.Utc).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 635, DateTimeKind.Utc).AddTicks(5704), new DateTime(2023, 10, 15, 19, 22, 50, 635, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 710, DateTimeKind.Utc).AddTicks(8042), new DateTime(2023, 10, 15, 19, 22, 50, 710, DateTimeKind.Utc).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 788, DateTimeKind.Utc).AddTicks(7411), new DateTime(2023, 10, 15, 19, 22, 50, 788, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 866, DateTimeKind.Utc).AddTicks(2082), new DateTime(2023, 10, 15, 19, 22, 50, 866, DateTimeKind.Utc).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 942, DateTimeKind.Utc).AddTicks(4301), new DateTime(2023, 10, 15, 19, 22, 50, 942, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 17, DateTimeKind.Utc).AddTicks(4074), new DateTime(2023, 10, 15, 19, 22, 51, 17, DateTimeKind.Utc).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 99, DateTimeKind.Utc).AddTicks(7600), new DateTime(2023, 10, 15, 19, 22, 51, 99, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 179, DateTimeKind.Utc).AddTicks(2266), new DateTime(2023, 10, 15, 19, 22, 51, 179, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 256, DateTimeKind.Utc).AddTicks(2798), new DateTime(2023, 10, 15, 19, 22, 51, 256, DateTimeKind.Utc).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 349, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 10, 15, 19, 22, 51, 349, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 426, DateTimeKind.Utc).AddTicks(5059), new DateTime(2023, 10, 15, 19, 22, 51, 426, DateTimeKind.Utc).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 508, DateTimeKind.Utc).AddTicks(5503), new DateTime(2023, 10, 15, 19, 22, 51, 508, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 588, DateTimeKind.Utc).AddTicks(9189), new DateTime(2023, 10, 15, 19, 22, 51, 588, DateTimeKind.Utc).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 666, DateTimeKind.Utc).AddTicks(9761), new DateTime(2023, 10, 15, 19, 22, 51, 666, DateTimeKind.Utc).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 743, DateTimeKind.Utc).AddTicks(950), new DateTime(2023, 10, 15, 19, 22, 51, 743, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 822, DateTimeKind.Utc).AddTicks(9683), new DateTime(2023, 10, 15, 19, 22, 51, 822, DateTimeKind.Utc).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 899, DateTimeKind.Utc).AddTicks(7205), new DateTime(2023, 10, 15, 19, 22, 51, 899, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 975, DateTimeKind.Utc).AddTicks(6051), new DateTime(2023, 10, 15, 19, 22, 51, 975, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 51, DateTimeKind.Utc).AddTicks(4735), new DateTime(2023, 10, 15, 19, 22, 52, 51, DateTimeKind.Utc).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 128, DateTimeKind.Utc).AddTicks(6655), new DateTime(2023, 10, 15, 19, 22, 52, 128, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 208, DateTimeKind.Utc).AddTicks(773), new DateTime(2023, 10, 15, 19, 22, 52, 208, DateTimeKind.Utc).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 285, DateTimeKind.Utc).AddTicks(1460), new DateTime(2023, 10, 15, 19, 22, 52, 285, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 363, DateTimeKind.Utc).AddTicks(371), new DateTime(2023, 10, 15, 19, 22, 52, 363, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 440, DateTimeKind.Utc).AddTicks(5349), new DateTime(2023, 10, 15, 19, 22, 52, 440, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 517, DateTimeKind.Utc).AddTicks(3684), new DateTime(2023, 10, 15, 19, 22, 52, 517, DateTimeKind.Utc).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(6811), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 315, DateTimeKind.Utc).AddTicks(275), new DateTime(2023, 10, 15, 19, 22, 47, 315, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 315, DateTimeKind.Utc).AddTicks(284), new DateTime(2023, 10, 15, 19, 22, 47, 315, DateTimeKind.Utc).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 391, DateTimeKind.Utc).AddTicks(1278), new DateTime(2023, 10, 15, 19, 22, 47, 391, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 19, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 391, DateTimeKind.Utc).AddTicks(1287), new DateTime(2023, 10, 15, 19, 22, 47, 391, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 487, DateTimeKind.Utc).AddTicks(4529), new DateTime(2023, 10, 15, 19, 22, 47, 487, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 18, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 487, DateTimeKind.Utc).AddTicks(4538), new DateTime(2023, 10, 15, 19, 22, 47, 487, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 573, DateTimeKind.Utc).AddTicks(1296), new DateTime(2023, 10, 15, 19, 22, 47, 573, DateTimeKind.Utc).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 17, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 573, DateTimeKind.Utc).AddTicks(1305), new DateTime(2023, 10, 15, 19, 22, 47, 573, DateTimeKind.Utc).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 664, DateTimeKind.Utc).AddTicks(890), new DateTime(2023, 10, 15, 19, 22, 47, 664, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 15, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 664, DateTimeKind.Utc).AddTicks(903), new DateTime(2023, 10, 15, 19, 22, 47, 664, DateTimeKind.Utc).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 751, DateTimeKind.Utc).AddTicks(5437), new DateTime(2023, 10, 15, 19, 22, 47, 751, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 14, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 751, DateTimeKind.Utc).AddTicks(5449), new DateTime(2023, 10, 15, 19, 22, 47, 751, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 839, DateTimeKind.Utc).AddTicks(3591), new DateTime(2023, 10, 15, 19, 22, 47, 839, DateTimeKind.Utc).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 13, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 839, DateTimeKind.Utc).AddTicks(3601), new DateTime(2023, 10, 15, 19, 22, 47, 839, DateTimeKind.Utc).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 917, DateTimeKind.Utc).AddTicks(378), new DateTime(2023, 10, 15, 19, 22, 47, 917, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 12, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 917, DateTimeKind.Utc).AddTicks(462), new DateTime(2023, 10, 15, 19, 22, 47, 917, DateTimeKind.Utc).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 992, DateTimeKind.Utc).AddTicks(6339), new DateTime(2023, 10, 15, 19, 22, 47, 992, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 11, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 992, DateTimeKind.Utc).AddTicks(6350), new DateTime(2023, 10, 15, 19, 22, 47, 992, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 9, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 69, DateTimeKind.Utc).AddTicks(5264), new DateTime(2023, 10, 15, 19, 22, 48, 69, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 11, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 69, DateTimeKind.Utc).AddTicks(5252), new DateTime(2023, 10, 15, 19, 22, 48, 69, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 8, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 150, DateTimeKind.Utc).AddTicks(578), new DateTime(2023, 10, 15, 19, 22, 48, 150, DateTimeKind.Utc).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 12, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 150, DateTimeKind.Utc).AddTicks(568), new DateTime(2023, 10, 15, 19, 22, 48, 150, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 7, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 226, DateTimeKind.Utc).AddTicks(4104), new DateTime(2023, 10, 15, 19, 22, 48, 226, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 13, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 226, DateTimeKind.Utc).AddTicks(4093), new DateTime(2023, 10, 15, 19, 22, 48, 226, DateTimeKind.Utc).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 6, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 303, DateTimeKind.Utc).AddTicks(8045), new DateTime(2023, 10, 15, 19, 22, 48, 303, DateTimeKind.Utc).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 14, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 303, DateTimeKind.Utc).AddTicks(8032), new DateTime(2023, 10, 15, 19, 22, 48, 303, DateTimeKind.Utc).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 5, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 381, DateTimeKind.Utc).AddTicks(498), new DateTime(2023, 10, 15, 19, 22, 48, 381, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 15, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 381, DateTimeKind.Utc).AddTicks(489), new DateTime(2023, 10, 15, 19, 22, 48, 381, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 4, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 459, DateTimeKind.Utc).AddTicks(5580), new DateTime(2023, 10, 15, 19, 22, 48, 459, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 17, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 459, DateTimeKind.Utc).AddTicks(5571), new DateTime(2023, 10, 15, 19, 22, 48, 459, DateTimeKind.Utc).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 3, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 536, DateTimeKind.Utc).AddTicks(2409), new DateTime(2023, 10, 15, 19, 22, 48, 536, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 18, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 536, DateTimeKind.Utc).AddTicks(2401), new DateTime(2023, 10, 15, 19, 22, 48, 536, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 2, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 611, DateTimeKind.Utc).AddTicks(8541), new DateTime(2023, 10, 15, 19, 22, 48, 611, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 19, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 611, DateTimeKind.Utc).AddTicks(8529), new DateTime(2023, 10, 15, 19, 22, 48, 611, DateTimeKind.Utc).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 1, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 688, DateTimeKind.Utc).AddTicks(8215), new DateTime(2023, 10, 15, 19, 22, 48, 688, DateTimeKind.Utc).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 20, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 688, DateTimeKind.Utc).AddTicks(8206), new DateTime(2023, 10, 15, 19, 22, 48, 688, DateTimeKind.Utc).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 315, DateTimeKind.Utc).AddTicks(265), new DateTime(2023, 10, 15, 19, 22, 47, 315, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 391, DateTimeKind.Utc).AddTicks(1264), new DateTime(2023, 10, 15, 19, 22, 47, 391, DateTimeKind.Utc).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 487, DateTimeKind.Utc).AddTicks(4520), new DateTime(2023, 10, 15, 19, 22, 47, 487, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 573, DateTimeKind.Utc).AddTicks(1285), new DateTime(2023, 10, 15, 19, 22, 47, 573, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 664, DateTimeKind.Utc).AddTicks(768), new DateTime(2023, 10, 15, 19, 22, 47, 664, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 751, DateTimeKind.Utc).AddTicks(5428), new DateTime(2023, 10, 15, 19, 22, 47, 751, DateTimeKind.Utc).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 839, DateTimeKind.Utc).AddTicks(3579), new DateTime(2023, 10, 15, 19, 22, 47, 839, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 917, DateTimeKind.Utc).AddTicks(365), new DateTime(2023, 10, 15, 19, 22, 47, 917, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 992, DateTimeKind.Utc).AddTicks(6330), new DateTime(2023, 10, 15, 19, 22, 47, 992, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 69, DateTimeKind.Utc).AddTicks(5105), new DateTime(2023, 10, 15, 19, 22, 48, 69, DateTimeKind.Utc).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 150, DateTimeKind.Utc).AddTicks(554), new DateTime(2023, 10, 15, 19, 22, 48, 150, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 226, DateTimeKind.Utc).AddTicks(4083), new DateTime(2023, 10, 15, 19, 22, 48, 226, DateTimeKind.Utc).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 303, DateTimeKind.Utc).AddTicks(8022), new DateTime(2023, 10, 15, 19, 22, 48, 303, DateTimeKind.Utc).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 381, DateTimeKind.Utc).AddTicks(476), new DateTime(2023, 10, 15, 19, 22, 48, 381, DateTimeKind.Utc).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 459, DateTimeKind.Utc).AddTicks(5562), new DateTime(2023, 10, 15, 19, 22, 48, 459, DateTimeKind.Utc).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 536, DateTimeKind.Utc).AddTicks(2391), new DateTime(2023, 10, 15, 19, 22, 48, 536, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 611, DateTimeKind.Utc).AddTicks(8518), new DateTime(2023, 10, 15, 19, 22, 48, 611, DateTimeKind.Utc).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 688, DateTimeKind.Utc).AddTicks(8195), new DateTime(2023, 10, 15, 19, 22, 48, 688, DateTimeKind.Utc).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 766, DateTimeKind.Utc).AddTicks(6027), new DateTime(2023, 10, 15, 19, 22, 48, 766, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 844, DateTimeKind.Utc).AddTicks(6700), new DateTime(2023, 10, 15, 19, 22, 48, 844, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 921, DateTimeKind.Utc).AddTicks(1184), new DateTime(2023, 10, 15, 19, 22, 48, 921, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 998, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 10, 15, 19, 22, 48, 998, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 75, DateTimeKind.Utc).AddTicks(7546), new DateTime(2023, 10, 15, 19, 22, 49, 75, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 155, DateTimeKind.Utc).AddTicks(494), new DateTime(2023, 10, 15, 19, 22, 49, 155, DateTimeKind.Utc).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 232, DateTimeKind.Utc).AddTicks(3619), new DateTime(2023, 10, 15, 19, 22, 49, 232, DateTimeKind.Utc).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 309, DateTimeKind.Utc).AddTicks(1034), new DateTime(2023, 10, 15, 19, 22, 49, 309, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 389, DateTimeKind.Utc).AddTicks(27), new DateTime(2023, 10, 15, 19, 22, 49, 389, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 470, DateTimeKind.Utc).AddTicks(2855), new DateTime(2023, 10, 15, 19, 22, 49, 470, DateTimeKind.Utc).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 547, DateTimeKind.Utc).AddTicks(3835), new DateTime(2023, 10, 15, 19, 22, 49, 547, DateTimeKind.Utc).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 623, DateTimeKind.Utc).AddTicks(3945), new DateTime(2023, 10, 15, 19, 22, 49, 623, DateTimeKind.Utc).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 699, DateTimeKind.Utc).AddTicks(6072), new DateTime(2023, 10, 15, 19, 22, 49, 699, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 777, DateTimeKind.Utc).AddTicks(1008), new DateTime(2023, 10, 15, 19, 22, 49, 777, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 854, DateTimeKind.Utc).AddTicks(7886), new DateTime(2023, 10, 15, 19, 22, 49, 854, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 929, DateTimeKind.Utc).AddTicks(8092), new DateTime(2023, 10, 15, 19, 22, 49, 929, DateTimeKind.Utc).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 8, DateTimeKind.Utc).AddTicks(1259), new DateTime(2023, 10, 15, 19, 22, 50, 8, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 92, DateTimeKind.Utc).AddTicks(573), new DateTime(2023, 10, 15, 19, 22, 50, 92, DateTimeKind.Utc).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 168, DateTimeKind.Utc).AddTicks(40), new DateTime(2023, 10, 15, 19, 22, 50, 168, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 246, DateTimeKind.Utc).AddTicks(5453), new DateTime(2023, 10, 15, 19, 22, 50, 246, DateTimeKind.Utc).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 325, DateTimeKind.Utc).AddTicks(6673), new DateTime(2023, 10, 15, 19, 22, 50, 325, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 404, DateTimeKind.Utc).AddTicks(7638), new DateTime(2023, 10, 15, 19, 22, 50, 404, DateTimeKind.Utc).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 482, DateTimeKind.Utc).AddTicks(8169), new DateTime(2023, 10, 15, 19, 22, 50, 482, DateTimeKind.Utc).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 559, DateTimeKind.Utc).AddTicks(8659), new DateTime(2023, 10, 15, 19, 22, 50, 559, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 635, DateTimeKind.Utc).AddTicks(5712), new DateTime(2023, 10, 15, 19, 22, 50, 635, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 710, DateTimeKind.Utc).AddTicks(8053), new DateTime(2023, 10, 15, 19, 22, 50, 710, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 788, DateTimeKind.Utc).AddTicks(7508), new DateTime(2023, 10, 15, 19, 22, 50, 788, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 866, DateTimeKind.Utc).AddTicks(2092), new DateTime(2023, 10, 15, 19, 22, 50, 866, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 942, DateTimeKind.Utc).AddTicks(4310), new DateTime(2023, 10, 15, 19, 22, 50, 942, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 17, DateTimeKind.Utc).AddTicks(4085), new DateTime(2023, 10, 15, 19, 22, 51, 17, DateTimeKind.Utc).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 99, DateTimeKind.Utc).AddTicks(7612), new DateTime(2023, 10, 15, 19, 22, 51, 99, DateTimeKind.Utc).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 179, DateTimeKind.Utc).AddTicks(2278), new DateTime(2023, 10, 15, 19, 22, 51, 179, DateTimeKind.Utc).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 256, DateTimeKind.Utc).AddTicks(2807), new DateTime(2023, 10, 15, 19, 22, 51, 256, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 349, DateTimeKind.Utc).AddTicks(9208), new DateTime(2023, 10, 15, 19, 22, 51, 349, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 426, DateTimeKind.Utc).AddTicks(5068), new DateTime(2023, 10, 15, 19, 22, 51, 426, DateTimeKind.Utc).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 508, DateTimeKind.Utc).AddTicks(5512), new DateTime(2023, 10, 15, 19, 22, 51, 508, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 588, DateTimeKind.Utc).AddTicks(9198), new DateTime(2023, 10, 15, 19, 22, 51, 588, DateTimeKind.Utc).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 666, DateTimeKind.Utc).AddTicks(9773), new DateTime(2023, 10, 15, 19, 22, 51, 666, DateTimeKind.Utc).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 743, DateTimeKind.Utc).AddTicks(958), new DateTime(2023, 10, 15, 19, 22, 51, 743, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 822, DateTimeKind.Utc).AddTicks(9695), new DateTime(2023, 10, 15, 19, 22, 51, 822, DateTimeKind.Utc).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 899, DateTimeKind.Utc).AddTicks(7214), new DateTime(2023, 10, 15, 19, 22, 51, 899, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 975, DateTimeKind.Utc).AddTicks(6063), new DateTime(2023, 10, 15, 19, 22, 51, 975, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 51, DateTimeKind.Utc).AddTicks(4744), new DateTime(2023, 10, 15, 19, 22, 52, 51, DateTimeKind.Utc).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 128, DateTimeKind.Utc).AddTicks(6663), new DateTime(2023, 10, 15, 19, 22, 52, 128, DateTimeKind.Utc).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 208, DateTimeKind.Utc).AddTicks(781), new DateTime(2023, 10, 15, 19, 22, 52, 208, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 285, DateTimeKind.Utc).AddTicks(1468), new DateTime(2023, 10, 15, 19, 22, 52, 285, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 363, DateTimeKind.Utc).AddTicks(380), new DateTime(2023, 10, 15, 19, 22, 52, 363, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 440, DateTimeKind.Utc).AddTicks(5358), new DateTime(2023, 10, 15, 19, 22, 52, 440, DateTimeKind.Utc).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 517, DateTimeKind.Utc).AddTicks(3695), new DateTime(2023, 10, 15, 19, 22, 52, 517, DateTimeKind.Utc).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(6820), new DateTime(2023, 10, 15, 19, 22, 52, 595, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 237, DateTimeKind.Utc).AddTicks(5510), "aidan.abbott@email.com", "Aidan", "Abbott", "AQAAAAIAAYagAAAAEDDpa0V7gXtbjrjTTq19tH/aG5J12SY5vkn2obbCnsUtdAcmQV+hg4V164fEt2IOEg==", new DateTime(2023, 10, 15, 19, 22, 47, 237, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 316, DateTimeKind.Utc).AddTicks(4049), "lexie.price@email.com", "Lexie", "Price", "AQAAAAIAAYagAAAAECo9s/658HMN4MHRn/Tgp/2RuUaN4/z9nA8zAwDxgwifSb2ilpqO6McFIbnyDcqtMA==", new DateTime(2023, 10, 15, 19, 22, 47, 316, DateTimeKind.Utc).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 392, DateTimeKind.Utc).AddTicks(6318), "tony.miller@email.com", "Tony", "Miller", "AQAAAAIAAYagAAAAECM8WOTuwJ/WaTTGJ24Ubn7Rnffc9cNEX5RtquCN4eyjaUvufkpiEaOkR3xaSxWk9Q==", new DateTime(2023, 10, 15, 19, 22, 47, 392, DateTimeKind.Utc).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 489, DateTimeKind.Utc).AddTicks(1503), "jeanette.gutmann@email.com", "Jeanette", "Gutmann", "AQAAAAIAAYagAAAAEA2SHVuH3YSl98FcTxpIfIKOx9YCO5p36X9JTOZSwdHd8lzA/Sztm6+W/PL5idTVeA==", new DateTime(2023, 10, 15, 19, 22, 47, 489, DateTimeKind.Utc).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 575, DateTimeKind.Utc).AddTicks(3437), "keshawn.collier@email.com", "Keshawn", "Collier", "AQAAAAIAAYagAAAAEAiM9+zPwCMw0UnwJ3eQ6Pv4W8oIGzSI3RxgKFzvhQ6VRrSc4zKsQRvQOF3hx7wU7Q==", new DateTime(2023, 10, 15, 19, 22, 47, 575, DateTimeKind.Utc).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 666, DateTimeKind.Utc).AddTicks(2531), "haylee.konopelski@email.com", "Haylee", "Konopelski", "AQAAAAIAAYagAAAAEK0zwRd0LHG9t0C5yUXu+PKK0acTlvl1i+m7DIxdIO6QJelna5L5A/lrFYBzGYe33A==", new DateTime(2023, 10, 15, 19, 22, 47, 666, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 753, DateTimeKind.Utc).AddTicks(7930), "alessia.schultz@email.com", "Alessia", "Schultz", "AQAAAAIAAYagAAAAEDiGfS9uprfv7LpT2QJ5nI9oGcuUTht+wqpzfqzmcgx8QIA6G4wIk/IUZut9DKWEyQ==", new DateTime(2023, 10, 15, 19, 22, 47, 753, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 842, DateTimeKind.Utc).AddTicks(638), "carlos.orn@email.com", "Carlos", "Orn", "AQAAAAIAAYagAAAAEOfl06fKg073Mu6wt+YTYgx753haiGzQaWhAkKMkglX6f7hDzclhwtRwiJa3tUV/8w==", new DateTime(2023, 10, 15, 19, 22, 47, 842, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 918, DateTimeKind.Utc).AddTicks(4883), "lori.luettgen@email.com", "Lori", "Luettgen", "AQAAAAIAAYagAAAAEK2xIXOMDDgJqIqt83FOMp+IsQS6/pQtIe8N1OHciNQashn9IbKxn8s6YlXi7sYAZQ==", new DateTime(2023, 10, 15, 19, 22, 47, 918, DateTimeKind.Utc).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 47, 994, DateTimeKind.Utc).AddTicks(362), "cathryn.bailey@email.com", "Cathryn", "Bailey", "AQAAAAIAAYagAAAAEGTlzQH/IoMymNF7+TMuZzjej3eQv09PYDAQsCGGq/Xde+g9fdcSh9usVsFLoNY22Q==", new DateTime(2023, 10, 15, 19, 22, 47, 994, DateTimeKind.Utc).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 71, DateTimeKind.Utc).AddTicks(2414), "tia.schmeler@email.com", "Tia", "Schmeler", "AQAAAAIAAYagAAAAEJfZ3kRXonrWmlmiocv3HWnq9vJDeA4TCTJJpf5zB0TwjoCW2fm1+dDIZ74qamaF5g==", new DateTime(2023, 10, 15, 19, 22, 48, 71, DateTimeKind.Utc).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 151, DateTimeKind.Utc).AddTicks(4630), "nestor.schaden@email.com", "Nestor", "Schaden", "AQAAAAIAAYagAAAAEHJuM8/3JIhwvSqEfG11oUuXowU4UhEhb7BfsWMtX3sT3Xa3+/g+CtfzNCA8U57otQ==", new DateTime(2023, 10, 15, 19, 22, 48, 151, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 227, DateTimeKind.Utc).AddTicks(8406), "leila.blick@email.com", "Leila", "Blick", "AQAAAAIAAYagAAAAEB/J2jUDhCrA9/NVgT2fKa/fkW7n9Psa3Ok333L4uOhw4h9BoNUgwl14rO9vXPp4EQ==", new DateTime(2023, 10, 15, 19, 22, 48, 227, DateTimeKind.Utc).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 305, DateTimeKind.Utc).AddTicks(3241), "kadin.vonrueden@email.com", "Kadin", "VonRueden", "AQAAAAIAAYagAAAAEL3tbhjXHBax73WH8UQ7jx6uFXXR2AVsZ8mBHRuxBeFOhqc8Elk4QgYgLBWmdTqFeQ==", new DateTime(2023, 10, 15, 19, 22, 48, 305, DateTimeKind.Utc).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 382, DateTimeKind.Utc).AddTicks(4307), "angelita.kulas@email.com", "Angelita", "Kulas", "AQAAAAIAAYagAAAAEI+Lm2PgMKpHX9MWgUd75S1MlOC8f84YTGMN7mkjvLe68757aXdFy53dbJR3LBIVqg==", new DateTime(2023, 10, 15, 19, 22, 48, 382, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 460, DateTimeKind.Utc).AddTicks(9983), "bethel.streich@email.com", "Bethel", "Streich", "AQAAAAIAAYagAAAAEJ+FWVVBZ0Fgtl9cZxjzTJrLWwjGGRHs7GBdKOuVWiT/M5W4mrZY2Pw4i5d7eo7LHw==", new DateTime(2023, 10, 15, 19, 22, 48, 460, DateTimeKind.Utc).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 537, DateTimeKind.Utc).AddTicks(9237), "brisa.littel@email.com", "Brisa", "Littel", "AQAAAAIAAYagAAAAEOlU/n/VZRwCPPMwiQgv7z9w8L0yaF0ssw2Y0xsGV5KMHIM9Z3En2dK/Zhj3N4rmew==", new DateTime(2023, 10, 15, 19, 22, 48, 537, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 613, DateTimeKind.Utc).AddTicks(3569), "wyatt.hammes@email.com", "Wyatt", "Hammes", "AQAAAAIAAYagAAAAEPDJQP6LcHQbuOtqeKaiHfrrZKRvL0j1WHSSkzLj0bTtFftHzTkYLiv/xleDhb5BJA==", new DateTime(2023, 10, 15, 19, 22, 48, 613, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 690, DateTimeKind.Utc).AddTicks(4275), "darius.pacocha@email.com", "Darius", "Pacocha", "AQAAAAIAAYagAAAAEE7OzGRoKXbG3Ulzt7zPD/zv4ltBLRB6JY9CqS7q47RjEouGSuIbRUrxpBF3MtCADQ==", new DateTime(2023, 10, 15, 19, 22, 48, 690, DateTimeKind.Utc).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 768, DateTimeKind.Utc).AddTicks(440), "mina.hodkiewicz@email.com", "Mina", "Hodkiewicz", "AQAAAAIAAYagAAAAEB4K4YFkiknqsEiPNVcwiJRPq0YY6hlcTAThoCWk3u1pwMsCLRvvGqh1BFjtPp3nHg==", new DateTime(2023, 10, 15, 19, 22, 48, 768, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 846, DateTimeKind.Utc).AddTicks(4223), "anabel.little@email.com", "Anabel", "Little", "AQAAAAIAAYagAAAAEDLkiBkgIMhyBDP00ws7io0Bo/Yn+usdhK0ejOmg8xItVDFogJPZMN0OTuaT2SFbNA==", new DateTime(2023, 10, 15, 19, 22, 48, 846, DateTimeKind.Utc).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 922, DateTimeKind.Utc).AddTicks(5315), "charley.kuvalis@email.com", "Charley", "Kuvalis", "AQAAAAIAAYagAAAAENNGhgDpkxYABOrI8d3VjGv23rN22tTC/Nrsnx6IfYM4wqSDP1zo6IHD6ItKWE4qlA==", new DateTime(2023, 10, 15, 19, 22, 48, 922, DateTimeKind.Utc).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 48, 999, DateTimeKind.Utc).AddTicks(7830), "kristin.robel@email.com", "Kristin", "Robel", "AQAAAAIAAYagAAAAEKVkR4u3opfXEMh8/6s432q2/aWHnrGYviVYt0KWsghqHVn+Std/7xsT2I4b6UWeqw==", new DateTime(2023, 10, 15, 19, 22, 48, 999, DateTimeKind.Utc).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 77, DateTimeKind.Utc).AddTicks(2295), "adelia.morissette@email.com", "Adelia", "Morissette", "AQAAAAIAAYagAAAAEA7KF27/Mpu67skXQNB26pC87l0ZuHgE+cGYPyJOEMmiFtCV9GD/a54tFmPmOh+IZg==", new DateTime(2023, 10, 15, 19, 22, 49, 77, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 156, DateTimeKind.Utc).AddTicks(7676), "lyla.kuhlman@email.com", "Lyla", "Kuhlman", "AQAAAAIAAYagAAAAEII8vqDm2LqziRrndANf93V5ZrWZS0fAfW3ICK4MZP88yu0Pt4wD1Kjk0koB+IDOsQ==", new DateTime(2023, 10, 15, 19, 22, 49, 156, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 233, DateTimeKind.Utc).AddTicks(7882), "orie.bernhard@email.com", "Orie", "Bernhard", "AQAAAAIAAYagAAAAEO8mOA3bWuFjXNcPsv1xmeG4a7NepOTZ0t/cHEOMMduV3lHu1EHNswLXeqeGxCKoiQ==", new DateTime(2023, 10, 15, 19, 22, 49, 233, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 310, DateTimeKind.Utc).AddTicks(4983), "rosalinda.kertzmann@email.com", "Rosalinda", "Kertzmann", "AQAAAAIAAYagAAAAEBqIqKukdp2XuPNVUlC3fzAOzFI/K4ZnXfGI02nbWs4Z6pItiZJnhlAHycEEyxlg6g==", new DateTime(2023, 10, 15, 19, 22, 49, 310, DateTimeKind.Utc).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 390, DateTimeKind.Utc).AddTicks(6545), "bertrand.harvey@email.com", "Bertrand", "Harvey", "AQAAAAIAAYagAAAAEB4iOeqhcwAPTNzMX9MkF6t3ON9WXvQJgGNoGTNmtLPlvX9Qe0kDJhxZL79b1X549Q==", new DateTime(2023, 10, 15, 19, 22, 49, 390, DateTimeKind.Utc).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 472, DateTimeKind.Utc).AddTicks(6921), "tyson.borer@email.com", "Tyson", "Borer", "AQAAAAIAAYagAAAAEOo5u/JVt2dh+gWK1+Qjvc/VKBhJVQAGKKFTG4mxPNnnhhcJaXKrHXxwBHd9jgfunw==", new DateTime(2023, 10, 15, 19, 22, 49, 472, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 548, DateTimeKind.Utc).AddTicks(8825), "berry.parker@email.com", "Berry", "Parker", "AQAAAAIAAYagAAAAEE5h/wvjU5fsALNtu352XlPLYPUvf820SEkqVhbLHoKq0KMcg2QrMMjkS3qzB+jpUw==", new DateTime(2023, 10, 15, 19, 22, 49, 548, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 624, DateTimeKind.Utc).AddTicks(9182), "fredy.hirthe@email.com", "Fredy", "Hirthe", "AQAAAAIAAYagAAAAEFF+fX7VoV0SHe0w+zWL3hucysOBirVMEzWFIobzAQOTlGLemHEYPHhPyv8c/w+5GQ==", new DateTime(2023, 10, 15, 19, 22, 49, 624, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 700, DateTimeKind.Utc).AddTicks(9347), "cleta.ratke@email.com", "Cleta", "Ratke", "AQAAAAIAAYagAAAAEAc4CMzvVyUj1stToXYeFEdbLCzKbK37YLHTqpTA/vwwX8dXeGjtQyMAK3QoRi37yQ==", new DateTime(2023, 10, 15, 19, 22, 49, 700, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 778, DateTimeKind.Utc).AddTicks(7287), "cristobal.mcclure@email.com", "Cristobal", "McClure", "AQAAAAIAAYagAAAAEF8Lk6y1ByvBM9vgjPqIL4LgPqoA+oRBrUgasBbXJgmk/6JHJuHiaOLBCBvphP1lgA==", new DateTime(2023, 10, 15, 19, 22, 49, 778, DateTimeKind.Utc).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 856, DateTimeKind.Utc).AddTicks(2400), "giovanni.treutel@email.com", "Giovanni", "Treutel", "AQAAAAIAAYagAAAAEAKMBtW4T3c4JCOTsNu1CA5T64jSdU+tXYs/FBzRORAcTiEkCWthr/seXDESw1J9nQ==", new DateTime(2023, 10, 15, 19, 22, 49, 856, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 49, 931, DateTimeKind.Utc).AddTicks(1840), "tracy.wilkinson@email.com", "Tracy", "Wilkinson", "AQAAAAIAAYagAAAAEG+anZ19yueZ02aOYmbqKNq/PW58SVNogGhHlmgCWfCJxbmSD0kVBexkvONnNLmCMA==", new DateTime(2023, 10, 15, 19, 22, 49, 931, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 9, DateTimeKind.Utc).AddTicks(8342), "marina.williamson@email.com", "Marina", "Williamson", "AQAAAAIAAYagAAAAEFlZ2ZzVQlQ81A6guA2zFcSIZxeVc11O26/RF2JkMWzmfCTfxVI3yAdzaaJjLAedKg==", new DateTime(2023, 10, 15, 19, 22, 50, 9, DateTimeKind.Utc).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 93, DateTimeKind.Utc).AddTicks(4765), "nathanial.little@email.com", "Nathanial", "Little", "AQAAAAIAAYagAAAAEICMboBseVRh04qtXfQdsWNNzDs71/PKtds37JKQIhB25ura6wlVrOT0agnL/ouDIA==", new DateTime(2023, 10, 15, 19, 22, 50, 93, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 169, DateTimeKind.Utc).AddTicks(4764), "jessica.wilderman@email.com", "Jessica", "Wilderman", "AQAAAAIAAYagAAAAECqeOV4IV5zpcU71PcBDNicSf9xp5HLZjJ8LbTZyFjTx3iD2RiBNkvfhxhHNcIUe5w==", new DateTime(2023, 10, 15, 19, 22, 50, 169, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 248, DateTimeKind.Utc).AddTicks(5434), "roel.stanton@email.com", "Roel", "Stanton", "AQAAAAIAAYagAAAAEL5h/cvVuQg/QC2owQelbdjjpko91uyCFpCNGzwTdmirxOUyeY1kwRHIJfXUEri/Kg==", new DateTime(2023, 10, 15, 19, 22, 50, 248, DateTimeKind.Utc).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 327, DateTimeKind.Utc).AddTicks(776), "tavares.fadel@email.com", "Tavares", "Fadel", "AQAAAAIAAYagAAAAEBXR4pKpukLfkEeU9TrOSuhebIrwWk0C/X6cGle4V+YmxZ38nGPciAG3krydc1iEbA==", new DateTime(2023, 10, 15, 19, 22, 50, 327, DateTimeKind.Utc).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 406, DateTimeKind.Utc).AddTicks(2776), "albertha.bartoletti@email.com", "Albertha", "Bartoletti", "AQAAAAIAAYagAAAAEKKsA+uPvITHfOm00EEoKKCLsFyvAJp/GSqve0yd/ZDdmzXzz7SWq4fT4pGOmXPcww==", new DateTime(2023, 10, 15, 19, 22, 50, 406, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 484, DateTimeKind.Utc).AddTicks(2531), "cornelius.casper@email.com", "Cornelius", "Casper", "AQAAAAIAAYagAAAAEE7sdV5HvDS6tJhRab35Nft4MB/D5HvMBaSnPIvMlK7yRB1QAY77b3d5yxEZt6sBgQ==", new DateTime(2023, 10, 15, 19, 22, 50, 484, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 561, DateTimeKind.Utc).AddTicks(3117), "braulio.steuber@email.com", "Braulio", "Steuber", "AQAAAAIAAYagAAAAEJtD000DQG8xpL8n3LJXPejAppdUinhBwLFMuvqtuG2iQBtr+K4vsaLLbm12Ngk0xQ==", new DateTime(2023, 10, 15, 19, 22, 50, 561, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 637, DateTimeKind.Utc).AddTicks(2286), "favian.o'hara@email.com", "Favian", "O'Hara", "AQAAAAIAAYagAAAAEN6eJvKIagKmmGKrtWxMvfBi78TFQhDYvyOA3AO4+dF+1aJ3cQpyCBP2GfWWWysjKQ==", new DateTime(2023, 10, 15, 19, 22, 50, 637, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 712, DateTimeKind.Utc).AddTicks(5742), "junius.o'conner@email.com", "Junius", "O'Conner", "AQAAAAIAAYagAAAAEK7XWq38KxtghKoRVlHDbvf+kqoBAJFD/m8kx6hVD7o4fsJEYo/DxCKnI720lRXvsw==", new DateTime(2023, 10, 15, 19, 22, 50, 712, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 790, DateTimeKind.Utc).AddTicks(2015), "deontae.stehr@email.com", "Deontae", "Stehr", "AQAAAAIAAYagAAAAEEs1bEnOLKlKBSb2diGISbxS5uAiHKvW3u4rFf26finBSf5rXzRXOkacc8QnYUR/qw==", new DateTime(2023, 10, 15, 19, 22, 50, 790, DateTimeKind.Utc).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 867, DateTimeKind.Utc).AddTicks(8393), "eldridge.murray@email.com", "Eldridge", "Murray", "AQAAAAIAAYagAAAAEAu1XWIl9TtJZ3Y4nkgYEfnsfX/VErtyOO8ujbBSG2UfK7Wa1owxsbANYQmKs6QRog==", new DateTime(2023, 10, 15, 19, 22, 50, 867, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 50, 943, DateTimeKind.Utc).AddTicks(8604), "daphney.schinner@email.com", "Daphney", "Schinner", "AQAAAAIAAYagAAAAEKMEfU1MEEfsPRjQjGQCTfD33R1MQtq7HIw9L1mL7Dfkb7It3ispq79E/tefuBzcSQ==", new DateTime(2023, 10, 15, 19, 22, 50, 943, DateTimeKind.Utc).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 18, DateTimeKind.Utc).AddTicks(8497), "kelsie.oberbrunner@email.com", "Kelsie", "Oberbrunner", "AQAAAAIAAYagAAAAEP8mmYS3TgVXvLGrUVHh/cbZPvpj8kMAJ5WUEb3gTBvuiI7Khm0vZjaMr2wX/WGOyA==", new DateTime(2023, 10, 15, 19, 22, 51, 18, DateTimeKind.Utc).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 101, DateTimeKind.Utc).AddTicks(4096), "rosetta.kihn@email.com", "Rosetta", "Kihn", "AQAAAAIAAYagAAAAEJg68kiUsAOvWtsq+zT82iFsLO2+DyKH0L5O8s1slShvmnsME/TnpqdC1WvJ33wf9g==", new DateTime(2023, 10, 15, 19, 22, 51, 101, DateTimeKind.Utc).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 51,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 180, DateTimeKind.Utc).AddTicks(8261), "ambrose.murphy@email.com", "Ambrose", "Murphy", "AQAAAAIAAYagAAAAEEj8Q3Czd7NkRvvOJhSjpEGuPTwHPC4OyWoUs9y3bJtZKoFzLt30LokJoqczia1tDg==", new DateTime(2023, 10, 15, 19, 22, 51, 180, DateTimeKind.Utc).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 52,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 257, DateTimeKind.Utc).AddTicks(9250), "pearlie.murray@email.com", "Pearlie", "Murray", "AQAAAAIAAYagAAAAEPmMsLpdaJ/Dvny11DzS5AIVjeHBXDJhWYFZo0sEjvAzSXPBkPEBCzT7OkOenkL6cA==", new DateTime(2023, 10, 15, 19, 22, 51, 257, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 53,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 351, DateTimeKind.Utc).AddTicks(3740), "dimitri.brekke@email.com", "Dimitri", "Brekke", "AQAAAAIAAYagAAAAEMPvx78M7FvpONizOSK0h7wELBL5hlMVlgC/VGxODTXicpKv6Ce9z6SwmNtCclMssw==", new DateTime(2023, 10, 15, 19, 22, 51, 351, DateTimeKind.Utc).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 428, DateTimeKind.Utc).AddTicks(283), "jordy.gutkowski@email.com", "Jordy", "Gutkowski", "AQAAAAIAAYagAAAAEA9lDoAH5hW6OSLsE2C/PSCwuT6clBnktjiFFohVAJDlJCC7UoBXAEfdiTnOegs29Q==", new DateTime(2023, 10, 15, 19, 22, 51, 428, DateTimeKind.Utc).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 510, DateTimeKind.Utc).AddTicks(2605), "precious.marks@email.com", "Precious", "Marks", "AQAAAAIAAYagAAAAEKwffdmbkVciyoPiwPODlGqf+fhx/NDSjcuNktlvjv6LA37CCJFYDwnnqOm/Jvu6yA==", new DateTime(2023, 10, 15, 19, 22, 51, 510, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 589, DateTimeKind.Utc).AddTicks(9805), "faye.carter@email.com", "Faye", "Carter", "AQAAAAIAAYagAAAAEJWjtqlcyTD51xUgGhDvyJLNyogJ6Mnb1yA06W2vpgYDzvNfW4tbgpqheGYmTlI1iQ==", new DateTime(2023, 10, 15, 19, 22, 51, 589, DateTimeKind.Utc).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 57,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 668, DateTimeKind.Utc).AddTicks(5385), "trudie.trantow@email.com", "Trudie", "Trantow", "AQAAAAIAAYagAAAAEEkKXQD9cYkGvoiso5zIXjS9ZWC5WGJbiEcuHesz+QEi38k2QC6rb6zgQGslMcOENQ==", new DateTime(2023, 10, 15, 19, 22, 51, 668, DateTimeKind.Utc).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 744, DateTimeKind.Utc).AddTicks(5222), "moriah.thompson@email.com", "Moriah", "Thompson", "AQAAAAIAAYagAAAAEEevmMOJMmqq4qB2p+w5y/XIaPb6hCU2kswxjXLUPtLakOGU8iGMiXxCc2dTnzEfyw==", new DateTime(2023, 10, 15, 19, 22, 51, 744, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 824, DateTimeKind.Utc).AddTicks(5389), "shakira.koch@email.com", "Shakira", "Koch", "AQAAAAIAAYagAAAAEM/T4HZKxEfkxvJr0nvfo/YQQG8I4rps1wdObWTVKqQeN0sBPOI7C9mpxUky0k4h9g==", new DateTime(2023, 10, 15, 19, 22, 51, 824, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 60,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 901, DateTimeKind.Utc).AddTicks(1741), "edgar.rempel@email.com", "Edgar", "Rempel", "AQAAAAIAAYagAAAAEBQBTqrsqyB/kLi2bsFq1/IlIlkkuwgqpJ5AL1w3mViS1O0QwWwrUviIW7/5ptmLpQ==", new DateTime(2023, 10, 15, 19, 22, 51, 901, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 61,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 51, 977, DateTimeKind.Utc).AddTicks(364), "maria.lehner@email.com", "Maria", "Lehner", "AQAAAAIAAYagAAAAEMVUQKqB0mX+GjovNk4Q2UKi1Kbm/C2KkZcQcbXt0TXXQ7bmsT8QZw6wVKwL7spZVQ==", new DateTime(2023, 10, 15, 19, 22, 51, 977, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 62,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 52, DateTimeKind.Utc).AddTicks(9939), "bryce.price@email.com", "Bryce", "Price", "AQAAAAIAAYagAAAAEID2OdB/5r8ipIhH5q6lRZGytixc/KdgxYLJufPDI2+s96JTttyU1tMgXy43idUw7w==", new DateTime(2023, 10, 15, 19, 22, 52, 52, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 63,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 132, DateTimeKind.Utc).AddTicks(340), "martin.boyer@email.com", "Martin", "Boyer", "AQAAAAIAAYagAAAAECcXvA/zBHdevDiTigDUk9YQoLRHE3azFXfCSfMmUvOq0fUkz7AjK2pdF2DAMw+ouA==", new DateTime(2023, 10, 15, 19, 22, 52, 132, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 64,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 209, DateTimeKind.Utc).AddTicks(9392), "jean.aufderhar@email.com", "Jean", "Aufderhar", "AQAAAAIAAYagAAAAEPZtcYKFsPxx8iSLjy+q1QMEaQvULfVppJl226cbUITu7NYYLIBm80CN0bwDMQwFnw==", new DateTime(2023, 10, 15, 19, 22, 52, 209, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 65,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 287, DateTimeKind.Utc).AddTicks(4992), "wilson.wilderman@email.com", "Wilson", "Wilderman", "AQAAAAIAAYagAAAAEFJuOrh94rRHA6V3WzgKDXzGE+XrcCOd74gLQmFLD+Dtsn/fn79rzuf/H6qNIzxAAQ==", new DateTime(2023, 10, 15, 19, 22, 52, 287, DateTimeKind.Utc).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 66,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 366, DateTimeKind.Utc).AddTicks(4075), "kenya.abshire@email.com", "Kenya", "Abshire", "AQAAAAIAAYagAAAAEN2kCnzELaAUbFbMhnwrwPd81rCGuTg7er8HtDDol5/atL5Y4/n5bXbI137oibSbZA==", new DateTime(2023, 10, 15, 19, 22, 52, 366, DateTimeKind.Utc).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 67,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 442, DateTimeKind.Utc).AddTicks(9854), "alessandro.lakin@email.com", "Alessandro", "Lakin", "AQAAAAIAAYagAAAAEK4BXMnvOD3areeey4hpJM+fS0WaLvrqDrnRfCuTFfy1lmyq7aHX+Zbbu5wwJJp++Q==", new DateTime(2023, 10, 15, 19, 22, 52, 442, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 68,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 22, 52, 519, DateTimeKind.Utc).AddTicks(2466), "jocelyn.ernser@email.com", "Jocelyn", "Ernser", "AQAAAAIAAYagAAAAEODlKTKPsDGcShKzZ3IrqS9KEmQAtwUsCMnNqBDFDlS+rQjQwltjeOESrbAqzBdOUg==", new DateTime(2023, 10, 15, 19, 22, 52, 519, DateTimeKind.Utc).AddTicks(2466) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8067), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8231), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8293), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8310), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8348), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8367), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8385), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8397), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8417), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8429), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8447), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8459), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8470), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8482), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8499), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8540), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8553), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8565), new DateTime(2023, 10, 15, 19, 19, 6, 850, DateTimeKind.Utc).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 19, 12, 137, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6409), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 19, 12, 137, DateTimeKind.Local).AddTicks(6503), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6502), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 19, 12, 137, DateTimeKind.Local).AddTicks(6508), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6507), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 19, 12, 137, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6512), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 19, 12, 137, DateTimeKind.Local).AddTicks(7674), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7672), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 19, 12, 137, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7690), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 7,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 19, 12, 137, DateTimeKind.Local).AddTicks(7695), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7695), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 8,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 19, 12, 137, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7882), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 9,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 19, 12, 137, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7888), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 10,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 19, 12, 137, DateTimeKind.Local).AddTicks(7894), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7894), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 11,
                columns: new[] { "BookingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 14, 12, 19, 12, 137, DateTimeKind.Local).AddTicks(7899), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7898), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 927, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 10, 15, 19, 19, 6, 927, DateTimeKind.Utc).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 4, DateTimeKind.Utc).AddTicks(301), new DateTime(2023, 10, 15, 19, 19, 7, 4, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 84, DateTimeKind.Utc).AddTicks(220), new DateTime(2023, 10, 15, 19, 19, 7, 84, DateTimeKind.Utc).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 163, DateTimeKind.Utc).AddTicks(8423), new DateTime(2023, 10, 15, 19, 19, 7, 163, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 246, DateTimeKind.Utc).AddTicks(7434), new DateTime(2023, 10, 15, 19, 19, 7, 246, DateTimeKind.Utc).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 325, DateTimeKind.Utc).AddTicks(3671), new DateTime(2023, 10, 15, 19, 19, 7, 325, DateTimeKind.Utc).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 410, DateTimeKind.Utc).AddTicks(594), new DateTime(2023, 10, 15, 19, 19, 7, 410, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 487, DateTimeKind.Utc).AddTicks(372), new DateTime(2023, 10, 15, 19, 19, 7, 487, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 565, DateTimeKind.Utc).AddTicks(5819), new DateTime(2023, 10, 15, 19, 19, 7, 565, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 642, DateTimeKind.Utc).AddTicks(1032), new DateTime(2023, 10, 15, 19, 19, 7, 642, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 720, DateTimeKind.Utc).AddTicks(9053), new DateTime(2023, 10, 15, 19, 19, 7, 720, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 797, DateTimeKind.Utc).AddTicks(9079), new DateTime(2023, 10, 15, 19, 19, 7, 797, DateTimeKind.Utc).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 876, DateTimeKind.Utc).AddTicks(9270), new DateTime(2023, 10, 15, 19, 19, 7, 876, DateTimeKind.Utc).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 953, DateTimeKind.Utc).AddTicks(2128), new DateTime(2023, 10, 15, 19, 19, 7, 953, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 29, DateTimeKind.Utc).AddTicks(2997), new DateTime(2023, 10, 15, 19, 19, 8, 29, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 105, DateTimeKind.Utc).AddTicks(6121), new DateTime(2023, 10, 15, 19, 19, 8, 105, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 181, DateTimeKind.Utc).AddTicks(2528), new DateTime(2023, 10, 15, 19, 19, 8, 181, DateTimeKind.Utc).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 257, DateTimeKind.Utc).AddTicks(3939), new DateTime(2023, 10, 15, 19, 19, 8, 257, DateTimeKind.Utc).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 334, DateTimeKind.Utc).AddTicks(6793), new DateTime(2023, 10, 15, 19, 19, 8, 334, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 411, DateTimeKind.Utc).AddTicks(4084), new DateTime(2023, 10, 15, 19, 19, 8, 411, DateTimeKind.Utc).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 487, DateTimeKind.Utc).AddTicks(894), new DateTime(2023, 10, 15, 19, 19, 8, 487, DateTimeKind.Utc).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 563, DateTimeKind.Utc).AddTicks(8214), new DateTime(2023, 10, 15, 19, 19, 8, 563, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 638, DateTimeKind.Utc).AddTicks(4122), new DateTime(2023, 10, 15, 19, 19, 8, 638, DateTimeKind.Utc).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 716, DateTimeKind.Utc).AddTicks(1750), new DateTime(2023, 10, 15, 19, 19, 8, 716, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 800, DateTimeKind.Utc).AddTicks(8542), new DateTime(2023, 10, 15, 19, 19, 8, 800, DateTimeKind.Utc).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 877, DateTimeKind.Utc).AddTicks(903), new DateTime(2023, 10, 15, 19, 19, 8, 877, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 952, DateTimeKind.Utc).AddTicks(8314), new DateTime(2023, 10, 15, 19, 19, 8, 952, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 29, DateTimeKind.Utc).AddTicks(3503), new DateTime(2023, 10, 15, 19, 19, 9, 29, DateTimeKind.Utc).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 106, DateTimeKind.Utc).AddTicks(3834), new DateTime(2023, 10, 15, 19, 19, 9, 106, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 182, DateTimeKind.Utc).AddTicks(5542), new DateTime(2023, 10, 15, 19, 19, 9, 182, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 259, DateTimeKind.Utc).AddTicks(3102), new DateTime(2023, 10, 15, 19, 19, 9, 259, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 337, DateTimeKind.Utc).AddTicks(3188), new DateTime(2023, 10, 15, 19, 19, 9, 337, DateTimeKind.Utc).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 414, DateTimeKind.Utc).AddTicks(8913), new DateTime(2023, 10, 15, 19, 19, 9, 414, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 493, DateTimeKind.Utc).AddTicks(9973), new DateTime(2023, 10, 15, 19, 19, 9, 493, DateTimeKind.Utc).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 570, DateTimeKind.Utc).AddTicks(4626), new DateTime(2023, 10, 15, 19, 19, 9, 570, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 647, DateTimeKind.Utc).AddTicks(6842), new DateTime(2023, 10, 15, 19, 19, 9, 647, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 723, DateTimeKind.Utc).AddTicks(3866), new DateTime(2023, 10, 15, 19, 19, 9, 723, DateTimeKind.Utc).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 802, DateTimeKind.Utc).AddTicks(3533), new DateTime(2023, 10, 15, 19, 19, 9, 802, DateTimeKind.Utc).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 878, DateTimeKind.Utc).AddTicks(3948), new DateTime(2023, 10, 15, 19, 19, 9, 878, DateTimeKind.Utc).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 954, DateTimeKind.Utc).AddTicks(9740), new DateTime(2023, 10, 15, 19, 19, 9, 954, DateTimeKind.Utc).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 31, DateTimeKind.Utc).AddTicks(3620), new DateTime(2023, 10, 15, 19, 19, 10, 31, DateTimeKind.Utc).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 108, DateTimeKind.Utc).AddTicks(6987), new DateTime(2023, 10, 15, 19, 19, 10, 108, DateTimeKind.Utc).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 186, DateTimeKind.Utc).AddTicks(529), new DateTime(2023, 10, 15, 19, 19, 10, 186, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 264, DateTimeKind.Utc).AddTicks(7624), new DateTime(2023, 10, 15, 19, 19, 10, 264, DateTimeKind.Utc).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 342, DateTimeKind.Utc).AddTicks(6880), new DateTime(2023, 10, 15, 19, 19, 10, 342, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 418, DateTimeKind.Utc).AddTicks(6147), new DateTime(2023, 10, 15, 19, 19, 10, 418, DateTimeKind.Utc).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 495, DateTimeKind.Utc).AddTicks(5994), new DateTime(2023, 10, 15, 19, 19, 10, 495, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 571, DateTimeKind.Utc).AddTicks(598), new DateTime(2023, 10, 15, 19, 19, 10, 571, DateTimeKind.Utc).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 648, DateTimeKind.Utc).AddTicks(5763), new DateTime(2023, 10, 15, 19, 19, 10, 648, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 724, DateTimeKind.Utc).AddTicks(4337), new DateTime(2023, 10, 15, 19, 19, 10, 724, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 802, DateTimeKind.Utc).AddTicks(3492), new DateTime(2023, 10, 15, 19, 19, 10, 802, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 881, DateTimeKind.Utc).AddTicks(5741), new DateTime(2023, 10, 15, 19, 19, 10, 881, DateTimeKind.Utc).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 959, DateTimeKind.Utc).AddTicks(7580), new DateTime(2023, 10, 15, 19, 19, 10, 959, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 37, DateTimeKind.Utc).AddTicks(6994), new DateTime(2023, 10, 15, 19, 19, 11, 37, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 117, DateTimeKind.Utc).AddTicks(5526), new DateTime(2023, 10, 15, 19, 19, 11, 117, DateTimeKind.Utc).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 199, DateTimeKind.Utc).AddTicks(4099), new DateTime(2023, 10, 15, 19, 19, 11, 199, DateTimeKind.Utc).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 278, DateTimeKind.Utc).AddTicks(3915), new DateTime(2023, 10, 15, 19, 19, 11, 278, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 355, DateTimeKind.Utc).AddTicks(4935), new DateTime(2023, 10, 15, 19, 19, 11, 355, DateTimeKind.Utc).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 435, DateTimeKind.Utc).AddTicks(2609), new DateTime(2023, 10, 15, 19, 19, 11, 435, DateTimeKind.Utc).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 523, DateTimeKind.Utc).AddTicks(4175), new DateTime(2023, 10, 15, 19, 19, 11, 523, DateTimeKind.Utc).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 601, DateTimeKind.Utc).AddTicks(3542), new DateTime(2023, 10, 15, 19, 19, 11, 601, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 677, DateTimeKind.Utc).AddTicks(1887), new DateTime(2023, 10, 15, 19, 19, 11, 677, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 753, DateTimeKind.Utc).AddTicks(5284), new DateTime(2023, 10, 15, 19, 19, 11, 753, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 832, DateTimeKind.Utc).AddTicks(1651), new DateTime(2023, 10, 15, 19, 19, 11, 832, DateTimeKind.Utc).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 907, DateTimeKind.Utc).AddTicks(2674), new DateTime(2023, 10, 15, 19, 19, 11, 907, DateTimeKind.Utc).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 983, DateTimeKind.Utc).AddTicks(3047), new DateTime(2023, 10, 15, 19, 19, 11, 983, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 12, 61, DateTimeKind.Utc).AddTicks(7631), new DateTime(2023, 10, 15, 19, 19, 12, 61, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6255), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 927, DateTimeKind.Utc).AddTicks(4209), new DateTime(2023, 10, 15, 19, 19, 6, 927, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 20, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 927, DateTimeKind.Utc).AddTicks(4220), new DateTime(2023, 10, 15, 19, 19, 6, 927, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 4, DateTimeKind.Utc).AddTicks(325), new DateTime(2023, 10, 15, 19, 19, 7, 4, DateTimeKind.Utc).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 19, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 4, DateTimeKind.Utc).AddTicks(336), new DateTime(2023, 10, 15, 19, 19, 7, 4, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 84, DateTimeKind.Utc).AddTicks(239), new DateTime(2023, 10, 15, 19, 19, 7, 84, DateTimeKind.Utc).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 18, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 84, DateTimeKind.Utc).AddTicks(247), new DateTime(2023, 10, 15, 19, 19, 7, 84, DateTimeKind.Utc).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 163, DateTimeKind.Utc).AddTicks(8441), new DateTime(2023, 10, 15, 19, 19, 7, 163, DateTimeKind.Utc).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 17, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 163, DateTimeKind.Utc).AddTicks(8449), new DateTime(2023, 10, 15, 19, 19, 7, 163, DateTimeKind.Utc).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 246, DateTimeKind.Utc).AddTicks(7450), new DateTime(2023, 10, 15, 19, 19, 7, 246, DateTimeKind.Utc).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 15, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 246, DateTimeKind.Utc).AddTicks(7458), new DateTime(2023, 10, 15, 19, 19, 7, 246, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 325, DateTimeKind.Utc).AddTicks(3686), new DateTime(2023, 10, 15, 19, 19, 7, 325, DateTimeKind.Utc).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 14, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 325, DateTimeKind.Utc).AddTicks(3694), new DateTime(2023, 10, 15, 19, 19, 7, 325, DateTimeKind.Utc).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 410, DateTimeKind.Utc).AddTicks(614), new DateTime(2023, 10, 15, 19, 19, 7, 410, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 13, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 410, DateTimeKind.Utc).AddTicks(625), new DateTime(2023, 10, 15, 19, 19, 7, 410, DateTimeKind.Utc).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 487, DateTimeKind.Utc).AddTicks(389), new DateTime(2023, 10, 15, 19, 19, 7, 487, DateTimeKind.Utc).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 12, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 487, DateTimeKind.Utc).AddTicks(400), new DateTime(2023, 10, 15, 19, 19, 7, 487, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 565, DateTimeKind.Utc).AddTicks(5836), new DateTime(2023, 10, 15, 19, 19, 7, 565, DateTimeKind.Utc).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 11, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 565, DateTimeKind.Utc).AddTicks(5846), new DateTime(2023, 10, 15, 19, 19, 7, 565, DateTimeKind.Utc).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 9, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 642, DateTimeKind.Utc).AddTicks(1058), new DateTime(2023, 10, 15, 19, 19, 7, 642, DateTimeKind.Utc).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 11, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 642, DateTimeKind.Utc).AddTicks(1049), new DateTime(2023, 10, 15, 19, 19, 7, 642, DateTimeKind.Utc).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 8, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 720, DateTimeKind.Utc).AddTicks(9077), new DateTime(2023, 10, 15, 19, 19, 7, 720, DateTimeKind.Utc).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 12, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 720, DateTimeKind.Utc).AddTicks(9069), new DateTime(2023, 10, 15, 19, 19, 7, 720, DateTimeKind.Utc).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 7, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 797, DateTimeKind.Utc).AddTicks(9104), new DateTime(2023, 10, 15, 19, 19, 7, 797, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 13, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 797, DateTimeKind.Utc).AddTicks(9096), new DateTime(2023, 10, 15, 19, 19, 7, 797, DateTimeKind.Utc).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 6, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 876, DateTimeKind.Utc).AddTicks(9297), new DateTime(2023, 10, 15, 19, 19, 7, 876, DateTimeKind.Utc).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 14, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 876, DateTimeKind.Utc).AddTicks(9289), new DateTime(2023, 10, 15, 19, 19, 7, 876, DateTimeKind.Utc).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 5, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 953, DateTimeKind.Utc).AddTicks(2156), new DateTime(2023, 10, 15, 19, 19, 7, 953, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 15, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 953, DateTimeKind.Utc).AddTicks(2147), new DateTime(2023, 10, 15, 19, 19, 7, 953, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 4, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 29, DateTimeKind.Utc).AddTicks(3023), new DateTime(2023, 10, 15, 19, 19, 8, 29, DateTimeKind.Utc).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 17, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 29, DateTimeKind.Utc).AddTicks(3015), new DateTime(2023, 10, 15, 19, 19, 8, 29, DateTimeKind.Utc).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 3, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 105, DateTimeKind.Utc).AddTicks(6154), new DateTime(2023, 10, 15, 19, 19, 8, 105, DateTimeKind.Utc).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 18, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 105, DateTimeKind.Utc).AddTicks(6146), new DateTime(2023, 10, 15, 19, 19, 8, 105, DateTimeKind.Utc).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 2, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 181, DateTimeKind.Utc).AddTicks(2558), new DateTime(2023, 10, 15, 19, 19, 8, 181, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 19, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 181, DateTimeKind.Utc).AddTicks(2549), new DateTime(2023, 10, 15, 19, 19, 8, 181, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 1, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 257, DateTimeKind.Utc).AddTicks(3965), new DateTime(2023, 10, 15, 19, 19, 8, 257, DateTimeKind.Utc).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 20, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 257, DateTimeKind.Utc).AddTicks(3957), new DateTime(2023, 10, 15, 19, 19, 8, 257, DateTimeKind.Utc).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 927, DateTimeKind.Utc).AddTicks(4197), new DateTime(2023, 10, 15, 19, 19, 6, 927, DateTimeKind.Utc).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 4, DateTimeKind.Utc).AddTicks(309), new DateTime(2023, 10, 15, 19, 19, 7, 4, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 84, DateTimeKind.Utc).AddTicks(231), new DateTime(2023, 10, 15, 19, 19, 7, 84, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 163, DateTimeKind.Utc).AddTicks(8431), new DateTime(2023, 10, 15, 19, 19, 7, 163, DateTimeKind.Utc).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 246, DateTimeKind.Utc).AddTicks(7440), new DateTime(2023, 10, 15, 19, 19, 7, 246, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 325, DateTimeKind.Utc).AddTicks(3678), new DateTime(2023, 10, 15, 19, 19, 7, 325, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 410, DateTimeKind.Utc).AddTicks(605), new DateTime(2023, 10, 15, 19, 19, 7, 410, DateTimeKind.Utc).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 487, DateTimeKind.Utc).AddTicks(380), new DateTime(2023, 10, 15, 19, 19, 7, 487, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 565, DateTimeKind.Utc).AddTicks(5825), new DateTime(2023, 10, 15, 19, 19, 7, 565, DateTimeKind.Utc).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 642, DateTimeKind.Utc).AddTicks(1039), new DateTime(2023, 10, 15, 19, 19, 7, 642, DateTimeKind.Utc).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 720, DateTimeKind.Utc).AddTicks(9059), new DateTime(2023, 10, 15, 19, 19, 7, 720, DateTimeKind.Utc).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 797, DateTimeKind.Utc).AddTicks(9086), new DateTime(2023, 10, 15, 19, 19, 7, 797, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 876, DateTimeKind.Utc).AddTicks(9277), new DateTime(2023, 10, 15, 19, 19, 7, 876, DateTimeKind.Utc).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 953, DateTimeKind.Utc).AddTicks(2136), new DateTime(2023, 10, 15, 19, 19, 7, 953, DateTimeKind.Utc).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 29, DateTimeKind.Utc).AddTicks(3005), new DateTime(2023, 10, 15, 19, 19, 8, 29, DateTimeKind.Utc).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 105, DateTimeKind.Utc).AddTicks(6130), new DateTime(2023, 10, 15, 19, 19, 8, 105, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 181, DateTimeKind.Utc).AddTicks(2539), new DateTime(2023, 10, 15, 19, 19, 8, 181, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 257, DateTimeKind.Utc).AddTicks(3946), new DateTime(2023, 10, 15, 19, 19, 8, 257, DateTimeKind.Utc).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 19, 19 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 334, DateTimeKind.Utc).AddTicks(6803), new DateTime(2023, 10, 15, 19, 19, 8, 334, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 20, 20 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 411, DateTimeKind.Utc).AddTicks(4095), new DateTime(2023, 10, 15, 19, 19, 8, 411, DateTimeKind.Utc).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 21, 21 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 487, DateTimeKind.Utc).AddTicks(904), new DateTime(2023, 10, 15, 19, 19, 8, 487, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 22, 22 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 563, DateTimeKind.Utc).AddTicks(8222), new DateTime(2023, 10, 15, 19, 19, 8, 563, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 23, 23 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 638, DateTimeKind.Utc).AddTicks(4133), new DateTime(2023, 10, 15, 19, 19, 8, 638, DateTimeKind.Utc).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 24, 24 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 716, DateTimeKind.Utc).AddTicks(1757), new DateTime(2023, 10, 15, 19, 19, 8, 716, DateTimeKind.Utc).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 25, 25 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 800, DateTimeKind.Utc).AddTicks(8551), new DateTime(2023, 10, 15, 19, 19, 8, 800, DateTimeKind.Utc).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 26, 26 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 877, DateTimeKind.Utc).AddTicks(911), new DateTime(2023, 10, 15, 19, 19, 8, 877, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 27, 27 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 952, DateTimeKind.Utc).AddTicks(8325), new DateTime(2023, 10, 15, 19, 19, 8, 952, DateTimeKind.Utc).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 28, 28 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 29, DateTimeKind.Utc).AddTicks(3511), new DateTime(2023, 10, 15, 19, 19, 9, 29, DateTimeKind.Utc).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 29, 29 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 106, DateTimeKind.Utc).AddTicks(3844), new DateTime(2023, 10, 15, 19, 19, 9, 106, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 30, 30 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 182, DateTimeKind.Utc).AddTicks(5549), new DateTime(2023, 10, 15, 19, 19, 9, 182, DateTimeKind.Utc).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 31, 31 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 259, DateTimeKind.Utc).AddTicks(3110), new DateTime(2023, 10, 15, 19, 19, 9, 259, DateTimeKind.Utc).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 32, 32 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 337, DateTimeKind.Utc).AddTicks(3200), new DateTime(2023, 10, 15, 19, 19, 9, 337, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 33, 33 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 414, DateTimeKind.Utc).AddTicks(9032), new DateTime(2023, 10, 15, 19, 19, 9, 414, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 34, 34 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 493, DateTimeKind.Utc).AddTicks(9980), new DateTime(2023, 10, 15, 19, 19, 9, 493, DateTimeKind.Utc).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 35, 35 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 570, DateTimeKind.Utc).AddTicks(4637), new DateTime(2023, 10, 15, 19, 19, 9, 570, DateTimeKind.Utc).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 36, 36 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 647, DateTimeKind.Utc).AddTicks(6853), new DateTime(2023, 10, 15, 19, 19, 9, 647, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 37, 37 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 723, DateTimeKind.Utc).AddTicks(3873), new DateTime(2023, 10, 15, 19, 19, 9, 723, DateTimeKind.Utc).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 38, 38 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 802, DateTimeKind.Utc).AddTicks(3540), new DateTime(2023, 10, 15, 19, 19, 9, 802, DateTimeKind.Utc).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 39, 39 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 878, DateTimeKind.Utc).AddTicks(3955), new DateTime(2023, 10, 15, 19, 19, 9, 878, DateTimeKind.Utc).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 40, 40 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 954, DateTimeKind.Utc).AddTicks(9748), new DateTime(2023, 10, 15, 19, 19, 9, 954, DateTimeKind.Utc).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 41, 41 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 31, DateTimeKind.Utc).AddTicks(3628), new DateTime(2023, 10, 15, 19, 19, 10, 31, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 42, 42 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 108, DateTimeKind.Utc).AddTicks(6994), new DateTime(2023, 10, 15, 19, 19, 10, 108, DateTimeKind.Utc).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 43, 43 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 186, DateTimeKind.Utc).AddTicks(537), new DateTime(2023, 10, 15, 19, 19, 10, 186, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 44, 44 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 264, DateTimeKind.Utc).AddTicks(7634), new DateTime(2023, 10, 15, 19, 19, 10, 264, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 45, 45 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 342, DateTimeKind.Utc).AddTicks(6892), new DateTime(2023, 10, 15, 19, 19, 10, 342, DateTimeKind.Utc).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 46, 46 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 418, DateTimeKind.Utc).AddTicks(6155), new DateTime(2023, 10, 15, 19, 19, 10, 418, DateTimeKind.Utc).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 47, 47 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 495, DateTimeKind.Utc).AddTicks(6002), new DateTime(2023, 10, 15, 19, 19, 10, 495, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 48, 48 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 571, DateTimeKind.Utc).AddTicks(605), new DateTime(2023, 10, 15, 19, 19, 10, 571, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 49, 49 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 648, DateTimeKind.Utc).AddTicks(5771), new DateTime(2023, 10, 15, 19, 19, 10, 648, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 50, 50 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 724, DateTimeKind.Utc).AddTicks(4344), new DateTime(2023, 10, 15, 19, 19, 10, 724, DateTimeKind.Utc).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 51, 51 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 802, DateTimeKind.Utc).AddTicks(3501), new DateTime(2023, 10, 15, 19, 19, 10, 802, DateTimeKind.Utc).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 52, 52 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 881, DateTimeKind.Utc).AddTicks(5748), new DateTime(2023, 10, 15, 19, 19, 10, 881, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 53, 53 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 959, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 10, 15, 19, 19, 10, 959, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 54, 54 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 37, DateTimeKind.Utc).AddTicks(7005), new DateTime(2023, 10, 15, 19, 19, 11, 37, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 55, 55 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 117, DateTimeKind.Utc).AddTicks(5533), new DateTime(2023, 10, 15, 19, 19, 11, 117, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 56, 56 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 199, DateTimeKind.Utc).AddTicks(4111), new DateTime(2023, 10, 15, 19, 19, 11, 199, DateTimeKind.Utc).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 57, 57 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 278, DateTimeKind.Utc).AddTicks(3924), new DateTime(2023, 10, 15, 19, 19, 11, 278, DateTimeKind.Utc).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 58, 58 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 355, DateTimeKind.Utc).AddTicks(4943), new DateTime(2023, 10, 15, 19, 19, 11, 355, DateTimeKind.Utc).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 59, 59 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 435, DateTimeKind.Utc).AddTicks(2616), new DateTime(2023, 10, 15, 19, 19, 11, 435, DateTimeKind.Utc).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 60, 60 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 523, DateTimeKind.Utc).AddTicks(4184), new DateTime(2023, 10, 15, 19, 19, 11, 523, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 61, 61 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 601, DateTimeKind.Utc).AddTicks(3549), new DateTime(2023, 10, 15, 19, 19, 11, 601, DateTimeKind.Utc).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 62, 62 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 677, DateTimeKind.Utc).AddTicks(1898), new DateTime(2023, 10, 15, 19, 19, 11, 677, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 63, 63 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 753, DateTimeKind.Utc).AddTicks(5292), new DateTime(2023, 10, 15, 19, 19, 11, 753, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 64, 64 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 832, DateTimeKind.Utc).AddTicks(1659), new DateTime(2023, 10, 15, 19, 19, 11, 832, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 65, 65 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 907, DateTimeKind.Utc).AddTicks(2682), new DateTime(2023, 10, 15, 19, 19, 11, 907, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 66, 66 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 983, DateTimeKind.Utc).AddTicks(3058), new DateTime(2023, 10, 15, 19, 19, 11, 983, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 67, 67 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 12, 61, DateTimeKind.Utc).AddTicks(7638), new DateTime(2023, 10, 15, 19, 19, 12, 61, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 68, 68 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6265), new DateTime(2023, 10, 15, 19, 19, 12, 137, DateTimeKind.Utc).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 852, DateTimeKind.Utc).AddTicks(3224), "maurice.prohaska@email.com", "Maurice", "Prohaska", "AQAAAAIAAYagAAAAEPlfi6btxCfC93IkGOtPPAO+Zkde1AFhrT9EVaxEJyP3Nmu4wIMSg9iC4pQv8+yfvQ==", new DateTime(2023, 10, 15, 19, 19, 6, 852, DateTimeKind.Utc).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 6, 929, DateTimeKind.Utc).AddTicks(1866), "fred.klocko@email.com", "Fred", "Klocko", "AQAAAAIAAYagAAAAEPPG0iHs1lmF9xxwrDzv0bMIF9NaqBUlPqDam1wbZ4NQRccF2Y2Kh/QCn1l/VzPZew==", new DateTime(2023, 10, 15, 19, 19, 6, 929, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 5, DateTimeKind.Utc).AddTicks(9863), "rachelle.treutel@email.com", "Rachelle", "Treutel", "AQAAAAIAAYagAAAAEKPFudAvmg1UVgY5lmP8LwOD814y62leswmP2W1n76txqHqsFuwkYN8vJzT1x011QA==", new DateTime(2023, 10, 15, 19, 19, 7, 5, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 85, DateTimeKind.Utc).AddTicks(4839), "merle.greenfelder@email.com", "Merle", "Greenfelder", "AQAAAAIAAYagAAAAEJI2kne2nwe9nrC68f+XluZBf8eX+LYoVWszQPRaPduIXwEMscgTxl2P6gjPPcUwUA==", new DateTime(2023, 10, 15, 19, 19, 7, 85, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 165, DateTimeKind.Utc).AddTicks(4775), "damien.doyle@email.com", "Damien", "Doyle", "AQAAAAIAAYagAAAAEKImf1mzaO0RqFBWR8MTKifup51gxH5E79cCfjhJcjX8erU75CWlPvK1CcclUcvSkA==", new DateTime(2023, 10, 15, 19, 19, 7, 165, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 248, DateTimeKind.Utc).AddTicks(3604), "danyka.cummings@email.com", "Danyka", "Cummings", "AQAAAAIAAYagAAAAEARltGfCMXqiIFfoHRcPFjNv8tg9q+uPbYK/0vq4lYBxT0bwXjWJt4dxqp+wTFip8A==", new DateTime(2023, 10, 15, 19, 19, 7, 248, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 326, DateTimeKind.Utc).AddTicks(7835), "isabell.waters@email.com", "Isabell", "Waters", "AQAAAAIAAYagAAAAELN/BNgfapyw0FpJU72BJHdEQvH03mnftE+DDyxYhCRNcDQFig4iRhLOAxD6drSBNw==", new DateTime(2023, 10, 15, 19, 19, 7, 326, DateTimeKind.Utc).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 411, DateTimeKind.Utc).AddTicks(5424), "madilyn.smith@email.com", "Madilyn", "Smith", "AQAAAAIAAYagAAAAEEV7e1+0zfsz/jjONzYOBvXcaQ+/K8VMXxLDeYMZMeNAntKJSD27M5xdrmw0UJok3A==", new DateTime(2023, 10, 15, 19, 19, 7, 411, DateTimeKind.Utc).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 489, DateTimeKind.Utc).AddTicks(4543), "carissa.kuhn@email.com", "Carissa", "Kuhn", "AQAAAAIAAYagAAAAEDfT6SgKaNETteeP26xHlsXVt8/Wtd+2CRvLzrY+nlTIwDAVCfPKJFiMFBV+mqZX3g==", new DateTime(2023, 10, 15, 19, 19, 7, 489, DateTimeKind.Utc).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 567, DateTimeKind.Utc).AddTicks(782), "esperanza.lehner@email.com", "Esperanza", "Lehner", "AQAAAAIAAYagAAAAEOkgJ02TUqbdF+wCY29TuocG36jA7eXNOFFzp35OwSZDOZgVc8UQJKmlvl0VAK1C0A==", new DateTime(2023, 10, 15, 19, 19, 7, 567, DateTimeKind.Utc).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 643, DateTimeKind.Utc).AddTicks(6587), "amparo.beatty@email.com", "Amparo", "Beatty", "AQAAAAIAAYagAAAAEGmJ1lcp0cOzorsek0gs3rN49GSXIqv5/t/k7nRUK2zK764gSGmg2JOdPqgQP8GS2w==", new DateTime(2023, 10, 15, 19, 19, 7, 643, DateTimeKind.Utc).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 721, DateTimeKind.Utc).AddTicks(9777), "jaeden.rolfson@email.com", "Jaeden", "Rolfson", "AQAAAAIAAYagAAAAEKznejFQi9T+MDiq/YeYG9fNiy3Zw0yf0pYBVVOUNdM7AxEymppA6tZi6MYjq4wM1g==", new DateTime(2023, 10, 15, 19, 19, 7, 721, DateTimeKind.Utc).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 799, DateTimeKind.Utc).AddTicks(140), "jules.white@email.com", "Jules", "White", "AQAAAAIAAYagAAAAEJ5MuPyzpMfWH8T5u+WvVn6TTL1bR1IYErNzLFnrsgsv3v7KLztoSE2m0WBd9Cgndw==", new DateTime(2023, 10, 15, 19, 19, 7, 799, DateTimeKind.Utc).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 878, DateTimeKind.Utc).AddTicks(4641), "tanner.frami@email.com", "Tanner", "Frami", "AQAAAAIAAYagAAAAEGXX73C4w4LzgcRA/DUkC1ulLd0pxoMj6dklzPsoXvZZvFDqRLjC0qTHSuyJt3ijoA==", new DateTime(2023, 10, 15, 19, 19, 7, 878, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 7, 954, DateTimeKind.Utc).AddTicks(7783), "ronaldo.rowe@email.com", "Ronaldo", "Rowe", "AQAAAAIAAYagAAAAEIMg/8Ymi2cDy7RS8h6wQCfCEdnTvlAju2afnx9JzMUcAL/L9KPu8qP/EDx5KHGNqQ==", new DateTime(2023, 10, 15, 19, 19, 7, 954, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 30, DateTimeKind.Utc).AddTicks(8343), "arnoldo.west@email.com", "Arnoldo", "West", "AQAAAAIAAYagAAAAEAz18zD9vx+CRXv316C8rZfz2TP5nwqcWxBLJxpoKoL4sWuZ2Yt83oSLP7Rh8mTqOw==", new DateTime(2023, 10, 15, 19, 19, 8, 30, DateTimeKind.Utc).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 107, DateTimeKind.Utc).AddTicks(390), "nora.schulist@email.com", "Nora", "Schulist", "AQAAAAIAAYagAAAAECCIYXGrM70L0bfphdxGq9EZCrJ/riHpOdlg9k1mhFteJ/ma31Fq5pu/Yot1wiPF6Q==", new DateTime(2023, 10, 15, 19, 19, 8, 107, DateTimeKind.Utc).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 182, DateTimeKind.Utc).AddTicks(5145), "iva.rippin@email.com", "Iva", "Rippin", "AQAAAAIAAYagAAAAEM1qwB+Hau+J6Ek6rCdB7LPo5V44heLl/fWxOMgDG6s591cY2SR7hrAG9bve8ky02w==", new DateTime(2023, 10, 15, 19, 19, 8, 182, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 258, DateTimeKind.Utc).AddTicks(7850), "murray.hirthe@email.com", "Murray", "Hirthe", "AQAAAAIAAYagAAAAEKE9uwej0qaF+Oumr/gplUDI+isUORdr+MtEjvtaw3TJ2R/uR73HpZkyStQJ4fk7dw==", new DateTime(2023, 10, 15, 19, 19, 8, 258, DateTimeKind.Utc).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 336, DateTimeKind.Utc).AddTicks(1469), "leanna.yost@email.com", "Leanna", "Yost", "AQAAAAIAAYagAAAAEAjRCAmzyxzIG8RcyzR2ekWmMrgK2yjGy/8rtl76yRKSeUmes+LGoMpyLGHxpZSYiQ==", new DateTime(2023, 10, 15, 19, 19, 8, 336, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 413, DateTimeKind.Utc).AddTicks(2268), "kamron.kreiger@email.com", "Kamron", "Kreiger", "AQAAAAIAAYagAAAAECK4iuCNEGdOBTsNCT5g+G15anrqAh1lNH/+uw6czVWZ7DW36MA1perQRIxtPOq4Gg==", new DateTime(2023, 10, 15, 19, 19, 8, 413, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 489, DateTimeKind.Utc).AddTicks(1111), "deshaun.murphy@email.com", "Deshaun", "Murphy", "AQAAAAIAAYagAAAAEEPE9Gv7LCkm5bgUQ/lqbc9RfZKhW9SmDdfcSmdXkxS/2gsQ42ejadf9ceXdAvXGuw==", new DateTime(2023, 10, 15, 19, 19, 8, 489, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 565, DateTimeKind.Utc).AddTicks(809), "gay.friesen@email.com", "Gay", "Friesen", "AQAAAAIAAYagAAAAEKhQJeKkxrCAj/K8jPMyT3uvDQ3LFueqCIMeDQGlmAAa2rBr29CtuDhPdE1kRA8Eqg==", new DateTime(2023, 10, 15, 19, 19, 8, 565, DateTimeKind.Utc).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 640, DateTimeKind.Utc).AddTicks(3731), "tre.durgan@email.com", "Tre", "Durgan", "AQAAAAIAAYagAAAAECxzu7kvKbbf/klyBXTRE7yhWdLDlaZbmxgv9Yj0zzRf10zo1slmHKLIdCM1/HNLBw==", new DateTime(2023, 10, 15, 19, 19, 8, 640, DateTimeKind.Utc).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 717, DateTimeKind.Utc).AddTicks(3109), "jena.cruickshank@email.com", "Jena", "Cruickshank", "AQAAAAIAAYagAAAAEFXO9h5DLT2FZyGXgOBrEcob6Ao1Ej5GdS7EHCKTjEORUENUQnrnhnROOiDXQ/jI+g==", new DateTime(2023, 10, 15, 19, 19, 8, 717, DateTimeKind.Utc).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 802, DateTimeKind.Utc).AddTicks(3289), "declan.johnson@email.com", "Declan", "Johnson", "AQAAAAIAAYagAAAAEDDGzWixt7+PzVRkOoFCSKk/+tFIs7kqGhCIGxHthwi0sX/eUaVSi0uYiq43q5UqeQ==", new DateTime(2023, 10, 15, 19, 19, 8, 802, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 878, DateTimeKind.Utc).AddTicks(9106), "nina.koch@email.com", "Nina", "Koch", "AQAAAAIAAYagAAAAEG2mOdojfIakCc+/+BOpMFaHBA4fZvlrO9eK6oWLLpke6/HXNiCIDSsH1p7H/CEVrg==", new DateTime(2023, 10, 15, 19, 19, 8, 878, DateTimeKind.Utc).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 8, 954, DateTimeKind.Utc).AddTicks(7223), "kieran.schoen@email.com", "Kieran", "Schoen", "AQAAAAIAAYagAAAAEJTA7sNTPOjLkV8cwAvz6fVk97y5dTVNae+PsNlKHhukuprneSuAbKTGCwdkuzpMYA==", new DateTime(2023, 10, 15, 19, 19, 8, 954, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 30, DateTimeKind.Utc).AddTicks(5001), "trycia.hilll@email.com", "Trycia", "Hilll", "AQAAAAIAAYagAAAAEMHaJ4iEA6mcBX/Ww3stH34nCQhYY6xN7sGzLRUSccavcQ6MPObUrHBYojlYvi19Lw==", new DateTime(2023, 10, 15, 19, 19, 9, 30, DateTimeKind.Utc).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 107, DateTimeKind.Utc).AddTicks(8507), "jada.rutherford@email.com", "Jada", "Rutherford", "AQAAAAIAAYagAAAAEBv1+IvernqFbMGNkkMDbrLzb+FaOCTyhnT1YU7udw27pJeulKydRHQAjUcGjABnog==", new DateTime(2023, 10, 15, 19, 19, 9, 107, DateTimeKind.Utc).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 184, DateTimeKind.Utc).AddTicks(1661), "garth.rohan@email.com", "Garth", "Rohan", "AQAAAAIAAYagAAAAEK78+90Y28Ov7tMmv56e5YBqkEr7d2USEYRN8x++T70jfJ3wILsDrXYsBFk/SFohfg==", new DateTime(2023, 10, 15, 19, 19, 9, 184, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 260, DateTimeKind.Utc).AddTicks(9004), "casper.greenholt@email.com", "Casper", "Greenholt", "AQAAAAIAAYagAAAAEK5A4Ky8F5oJqConE5+XwJqIwth1ZpIOgGRBm2Zzg7NqhNW9wfSwLnmbeu7x/cSZYA==", new DateTime(2023, 10, 15, 19, 19, 9, 260, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 338, DateTimeKind.Utc).AddTicks(8879), "hoyt.bartoletti@email.com", "Hoyt", "Bartoletti", "AQAAAAIAAYagAAAAEFhO+gsJon81/E8NRw6R9WqFtWnlhFTiLBXeWWxMJnEcaCr5gac/NvlnDJIEy5YEhA==", new DateTime(2023, 10, 15, 19, 19, 9, 338, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 416, DateTimeKind.Utc).AddTicks(9045), "mayra.kilback@email.com", "Mayra", "Kilback", "AQAAAAIAAYagAAAAENp0UR1lBshHIuyEbfAd1utdgarohH3Wf2ib6sPR6gG+qWBLwIldM6abZxHpAfaKzA==", new DateTime(2023, 10, 15, 19, 19, 9, 416, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 495, DateTimeKind.Utc).AddTicks(7405), "josh.schuster@email.com", "Josh", "Schuster", "AQAAAAIAAYagAAAAEBaE4Mb6IgNJpmqvSNsNXdxcWkux8RWAL9mdYiU+iUoz4pTCBrBd5BOWk56DxoVp9g==", new DateTime(2023, 10, 15, 19, 19, 9, 495, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 572, DateTimeKind.Utc).AddTicks(7787), "lucius.grimes@email.com", "Lucius", "Grimes", "AQAAAAIAAYagAAAAEPoSvKI4F/Eulrn7663bQlGLlDRB36OsCPQ1k362Rngrf5epwsdgiylqAjNbod23AQ==", new DateTime(2023, 10, 15, 19, 19, 9, 572, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 649, DateTimeKind.Utc).AddTicks(338), "berneice.morar@email.com", "Berneice", "Morar", "AQAAAAIAAYagAAAAEPaWcCWCX5jRqFNnsgW5iLi1NmjzraWMjeExlGCuFBCuMidQow9k+T8xaOLJ6wElyw==", new DateTime(2023, 10, 15, 19, 19, 9, 649, DateTimeKind.Utc).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 724, DateTimeKind.Utc).AddTicks(8050), "donna.haag@email.com", "Donna", "Haag", "AQAAAAIAAYagAAAAEHLByM+bkTou4npnkn0OdlW5qR+vk2JRfJknUeao1w4pUGuc3KNnx3WTvHWXofeaeA==", new DateTime(2023, 10, 15, 19, 19, 9, 724, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 803, DateTimeKind.Utc).AddTicks(7919), "davon.hackett@email.com", "Davon", "Hackett", "AQAAAAIAAYagAAAAEGcWnvtkdcjr8SNQwDUCa3zVfJ+2ikLkmdUFeCgoMO2N0kuBDo0K8Ipr1M2e18LZkQ==", new DateTime(2023, 10, 15, 19, 19, 9, 803, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 879, DateTimeKind.Utc).AddTicks(9206), "odessa.johnston@email.com", "Odessa", "Johnston", "AQAAAAIAAYagAAAAEG+MH0xHY9tDLy/R3fTUGqeUUG58aotJR1uSpr4N60h0G7YdWr4duGH2JDnWXGrSFg==", new DateTime(2023, 10, 15, 19, 19, 9, 879, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 9, 956, DateTimeKind.Utc).AddTicks(3707), "chad.schulist@email.com", "Chad", "Schulist", "AQAAAAIAAYagAAAAEFOvdF43hQFeGK4m7um6CXobqc0MVy2RO7suGq6b+hLeH0jW1cYITRVewxcki9SW/A==", new DateTime(2023, 10, 15, 19, 19, 9, 956, DateTimeKind.Utc).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 32, DateTimeKind.Utc).AddTicks(9170), "luz.ruecker@email.com", "Luz", "Ruecker", "AQAAAAIAAYagAAAAEGSNkVg0Yy3oCVHTHgTFVaYHj8zOwICNIwC+g1EMhdNHJz8WOSd/6wHyO+TIqEECXw==", new DateTime(2023, 10, 15, 19, 19, 10, 32, DateTimeKind.Utc).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 110, DateTimeKind.Utc).AddTicks(3905), "kevin.wintheiser@email.com", "Kevin", "Wintheiser", "AQAAAAIAAYagAAAAEMvb2ppWhJj4g6Hn2EohTybcVHqHHbT7j8jbL0HAUaaVRRxV0ezJFcwZQk4tlsXzZQ==", new DateTime(2023, 10, 15, 19, 19, 10, 110, DateTimeKind.Utc).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 187, DateTimeKind.Utc).AddTicks(7413), "nick.hilll@email.com", "Nick", "Hilll", "AQAAAAIAAYagAAAAENKogB18J82iisSu7evAPOohd5JZk80mIfHz7Y57XxmDNJh54inuuUqtZzTinf0DFA==", new DateTime(2023, 10, 15, 19, 19, 10, 187, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 266, DateTimeKind.Utc).AddTicks(3293), "vanessa.huel@email.com", "Vanessa", "Huel", "AQAAAAIAAYagAAAAEDWIoDiNF03kKIuxIqAPX8cUZYkbpVjAMu1WiUKWyt8OQTwN9fmdsgAVjeS314AOQw==", new DateTime(2023, 10, 15, 19, 19, 10, 266, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 344, DateTimeKind.Utc).AddTicks(759), "amya.stracke@email.com", "Amya", "Stracke", "AQAAAAIAAYagAAAAEBXE0LZgVDjcvc8oVRMyWGmichRsIS0k/NxVg+uRX2cSg0WwGCwrMyhDQMMOEpksPQ==", new DateTime(2023, 10, 15, 19, 19, 10, 344, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 420, DateTimeKind.Utc).AddTicks(1399), "jordi.schmeler@email.com", "Jordi", "Schmeler", "AQAAAAIAAYagAAAAECmqT4smz9gzw2AxrkOJ+/+TOLZz1CKepojw2ZRZTf0rVYmQmy03SjslW3ZzMMeVYw==", new DateTime(2023, 10, 15, 19, 19, 10, 420, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 497, DateTimeKind.Utc).AddTicks(1855), "delta.fisher@email.com", "Delta", "Fisher", "AQAAAAIAAYagAAAAEGQNWl1V7keH7Dp1K/mQpwmnKlqzXOKyQ90gD6sYIzJcJfa+semrhZARtEDGInIndg==", new DateTime(2023, 10, 15, 19, 19, 10, 497, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 572, DateTimeKind.Utc).AddTicks(7884), "molly.sporer@email.com", "Molly", "Sporer", "AQAAAAIAAYagAAAAEBMl3vVZzMB6V7XiH1EVp0bV0rxVMSSdfptTjNbzjC0NfxzacaLpVb2YILQHbMW6ww==", new DateTime(2023, 10, 15, 19, 19, 10, 572, DateTimeKind.Utc).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 650, DateTimeKind.Utc).AddTicks(363), "linnie.sporer@email.com", "Linnie", "Sporer", "AQAAAAIAAYagAAAAEBNYh1Zn/za/k2aM9bwqns/X/FLvYq6JPRbK/pPkFKDvP0aLqzaJl0+DE3Ls0E3NQA==", new DateTime(2023, 10, 15, 19, 19, 10, 650, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 51,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 725, DateTimeKind.Utc).AddTicks(8359), "gudrun.zboncak@email.com", "Gudrun", "Zboncak", "AQAAAAIAAYagAAAAEHqQk78K0NtMg4rSjqwgHkouT+hWj2rsdGDn7l8qUm5TXRLs1IoyZCXVsfEup+bO2w==", new DateTime(2023, 10, 15, 19, 19, 10, 725, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 52,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 804, DateTimeKind.Utc).AddTicks(1518), "alayna.marvin@email.com", "Alayna", "Marvin", "AQAAAAIAAYagAAAAEJ8gWZNxrfPFZ8HvDKSuRsxGKWDUnQIXy/Ti8WVbnH/oAo+XOMC+StKbumb1tTcPqg==", new DateTime(2023, 10, 15, 19, 19, 10, 804, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 53,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 883, DateTimeKind.Utc).AddTicks(219), "malachi.hartmann@email.com", "Malachi", "Hartmann", "AQAAAAIAAYagAAAAEDwzCMm6KVAbHP4/Y5xPuMnICTrQ88KqVS6HS4roCqZ18wH5BWjAfSgtqqZ2DPz0iA==", new DateTime(2023, 10, 15, 19, 19, 10, 883, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 10, 961, DateTimeKind.Utc).AddTicks(1623), "miracle.ernser@email.com", "Miracle", "Ernser", "AQAAAAIAAYagAAAAEHCUi0a/gMcJC5CiPrrfRCG1xGFksxxs55w6wgd1Rhk8FrgaoDRxEjFom6eBbp7DoQ==", new DateTime(2023, 10, 15, 19, 19, 10, 961, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 39, DateTimeKind.Utc).AddTicks(7673), "angelo.white@email.com", "Angelo", "White", "AQAAAAIAAYagAAAAED2ZB/sT9zj1QSipl9EJ0I2fWB+F63vTGoUHb2LgphxzJWBM9fCqY1rdtu08ulFxSQ==", new DateTime(2023, 10, 15, 19, 19, 11, 39, DateTimeKind.Utc).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 119, DateTimeKind.Utc).AddTicks(1735), "catherine.pfeffer@email.com", "Catherine", "Pfeffer", "AQAAAAIAAYagAAAAEL7ogyyRUmAdtY+WU08LL/Vn9qkRyVubc4sTWrgzHErm9QtYEILt7wf1Qjw7oJe57w==", new DateTime(2023, 10, 15, 19, 19, 11, 119, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 57,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 201, DateTimeKind.Utc).AddTicks(1184), "alford.hagenes@email.com", "Alford", "Hagenes", "AQAAAAIAAYagAAAAEEqsa0LFZoLkPnVbAvtCgJfHd5SgWrIk4FnsZlvVaE0T1p81TNLu47hpyvRuBRDWPA==", new DateTime(2023, 10, 15, 19, 19, 11, 201, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 279, DateTimeKind.Utc).AddTicks(8576), "kaitlyn.stamm@email.com", "Kaitlyn", "Stamm", "AQAAAAIAAYagAAAAEEY7vp/f59upZPkNSDqaRv2ZwOKJXt6zHhpOcNnPWslU9DmePoQAg0x2XcEry/7EvA==", new DateTime(2023, 10, 15, 19, 19, 11, 279, DateTimeKind.Utc).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 357, DateTimeKind.Utc).AddTicks(289), "bridie.o'connell@email.com", "Bridie", "O'Connell", "AQAAAAIAAYagAAAAEOuBMr+5dFXDzZVvXEjrg+NPBAS5N5h6Mpj72OQOMVEEOICJLIu47+M07jJk+bTYtg==", new DateTime(2023, 10, 15, 19, 19, 11, 357, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 60,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 436, DateTimeKind.Utc).AddTicks(8889), "cristal.jast@email.com", "Cristal", "Jast", "AQAAAAIAAYagAAAAEDQaghvFOFYQomaNJ+6YLOsHCmE0/3W6dhg8lYz+LbfK0iKAuKzfBuNSqF3qs9o6Eg==", new DateTime(2023, 10, 15, 19, 19, 11, 436, DateTimeKind.Utc).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 61,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 525, DateTimeKind.Utc).AddTicks(3082), "johnnie.cremin@email.com", "Johnnie", "Cremin", "AQAAAAIAAYagAAAAEO65FDvjrr1W9LEZ4mjmCyyp8bMpei5hK9Asncr+eYf8ImXQnmK7qmLYsmWkdpSWrA==", new DateTime(2023, 10, 15, 19, 19, 11, 525, DateTimeKind.Utc).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 62,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 602, DateTimeKind.Utc).AddTicks(8375), "wayne.padberg@email.com", "Wayne", "Padberg", "AQAAAAIAAYagAAAAED9Fcpo4R8lZUs8JiWITMPxB+b/Bwb4wfQnz51rXzHTvnlsormRAaOAgdLxFm+u9cQ==", new DateTime(2023, 10, 15, 19, 19, 11, 602, DateTimeKind.Utc).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 63,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 678, DateTimeKind.Utc).AddTicks(9926), "georgiana.brakus@email.com", "Georgiana", "Brakus", "AQAAAAIAAYagAAAAEBIgf7PGHjaluRbSaltD2t1uhgzUWG5ul0JPScDkDpLgrKA/9gWXNmwS66qfCK6iTA==", new DateTime(2023, 10, 15, 19, 19, 11, 678, DateTimeKind.Utc).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 64,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 755, DateTimeKind.Utc).AddTicks(2187), "reta.christiansen@email.com", "Reta", "Christiansen", "AQAAAAIAAYagAAAAEJRodxjgiRDdsJZhn74IpgbBwfH18j4S/YHYYcG+VSkeV9Xq8tIfI2b/OIjxqveJWQ==", new DateTime(2023, 10, 15, 19, 19, 11, 755, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 65,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 833, DateTimeKind.Utc).AddTicks(5517), "sydni.kling@email.com", "Sydni", "Kling", "AQAAAAIAAYagAAAAECu7ny1hnPr7O8maww1JHFs5xPnFWydKJq6LRXucd4DI2CcmnJr69nDLVgnosxkbpw==", new DateTime(2023, 10, 15, 19, 19, 11, 833, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 66,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 908, DateTimeKind.Utc).AddTicks(7046), "therese.macgyver@email.com", "Therese", "MacGyver", "AQAAAAIAAYagAAAAEKLcvreMClo9Rteygc+f9hOcchx4XRd9hUX4DbWvrCMk9EactFqiOcwdzAhiha35NA==", new DateTime(2023, 10, 15, 19, 19, 11, 908, DateTimeKind.Utc).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 67,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 11, 984, DateTimeKind.Utc).AddTicks(7822), "anastacio.nolan@email.com", "Anastacio", "Nolan", "AQAAAAIAAYagAAAAEKb8Yiq5HNMIjKpqDdOLEdvK150tmlfRekOF3Y4fHPhGOsESIwpPt4zdDGYuGQip3w==", new DateTime(2023, 10, 15, 19, 19, 11, 984, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 68,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 19, 12, 63, DateTimeKind.Utc).AddTicks(2514), "chloe.flatley@email.com", "Chloe", "Flatley", "AQAAAAIAAYagAAAAEHLDULxI+P1yOGLWmj4Whq1Tzc9q3QAlruj8fxLR/54s5TOudpuoiTfWEIR+n3O19A==", new DateTime(2023, 10, 15, 19, 19, 12, 63, DateTimeKind.Utc).AddTicks(2515) });
        }
    }
}
