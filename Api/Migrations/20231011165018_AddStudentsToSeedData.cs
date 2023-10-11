using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentsToSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(20), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(290), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(310), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(330), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(380), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(400), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(420), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(440), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(470), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(480), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(520), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(540), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(560), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(580), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(600), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(640), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(650), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(670), new DateTime(2023, 10, 11, 16, 50, 14, 6, DateTimeKind.Utc).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 84, DateTimeKind.Utc).AddTicks(8990), new DateTime(2023, 10, 11, 16, 50, 14, 84, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 159, DateTimeKind.Utc).AddTicks(1630), new DateTime(2023, 10, 11, 16, 50, 14, 159, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 230, DateTimeKind.Utc).AddTicks(9290), new DateTime(2023, 10, 11, 16, 50, 14, 230, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 302, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 10, 11, 16, 50, 14, 302, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 371, DateTimeKind.Utc).AddTicks(1810), new DateTime(2023, 10, 11, 16, 50, 14, 371, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 440, DateTimeKind.Utc).AddTicks(6020), new DateTime(2023, 10, 11, 16, 50, 14, 440, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 511, DateTimeKind.Utc).AddTicks(5360), new DateTime(2023, 10, 11, 16, 50, 14, 511, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 577, DateTimeKind.Utc).AddTicks(8820), new DateTime(2023, 10, 11, 16, 50, 14, 577, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 646, DateTimeKind.Utc).AddTicks(470), new DateTime(2023, 10, 11, 16, 50, 14, 646, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 712, DateTimeKind.Utc).AddTicks(2480), new DateTime(2023, 10, 11, 16, 50, 14, 712, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 779, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 10, 11, 16, 50, 14, 779, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 847, DateTimeKind.Utc).AddTicks(1530), new DateTime(2023, 10, 11, 16, 50, 14, 847, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 913, DateTimeKind.Utc).AddTicks(5680), new DateTime(2023, 10, 11, 16, 50, 14, 913, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 979, DateTimeKind.Utc).AddTicks(5730), new DateTime(2023, 10, 11, 16, 50, 14, 979, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 43, DateTimeKind.Utc).AddTicks(9700), new DateTime(2023, 10, 11, 16, 50, 15, 43, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 110, DateTimeKind.Utc).AddTicks(8520), new DateTime(2023, 10, 11, 16, 50, 15, 110, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 175, DateTimeKind.Utc).AddTicks(8870), new DateTime(2023, 10, 11, 16, 50, 15, 175, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 240, DateTimeKind.Utc).AddTicks(8720), new DateTime(2023, 10, 11, 16, 50, 15, 240, DateTimeKind.Utc).AddTicks(8720) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Bio", "CreatedAt", "RoleType", "UpdatedAt" },
                values: new object[,]
                {
                    { 19, null, new DateTime(2023, 10, 11, 16, 50, 15, 305, DateTimeKind.Utc).AddTicks(9950), 1, new DateTime(2023, 10, 11, 16, 50, 15, 305, DateTimeKind.Utc).AddTicks(9950) },
                    { 20, null, new DateTime(2023, 10, 11, 16, 50, 15, 370, DateTimeKind.Utc).AddTicks(8480), 1, new DateTime(2023, 10, 11, 16, 50, 15, 370, DateTimeKind.Utc).AddTicks(8480) },
                    { 21, null, new DateTime(2023, 10, 11, 16, 50, 15, 435, DateTimeKind.Utc).AddTicks(80), 1, new DateTime(2023, 10, 11, 16, 50, 15, 435, DateTimeKind.Utc).AddTicks(80) },
                    { 22, null, new DateTime(2023, 10, 11, 16, 50, 15, 498, DateTimeKind.Utc).AddTicks(8550), 1, new DateTime(2023, 10, 11, 16, 50, 15, 498, DateTimeKind.Utc).AddTicks(8550) },
                    { 23, null, new DateTime(2023, 10, 11, 16, 50, 15, 563, DateTimeKind.Utc).AddTicks(820), 1, new DateTime(2023, 10, 11, 16, 50, 15, 563, DateTimeKind.Utc).AddTicks(830) },
                    { 24, null, new DateTime(2023, 10, 11, 16, 50, 15, 629, DateTimeKind.Utc).AddTicks(960), 1, new DateTime(2023, 10, 11, 16, 50, 15, 629, DateTimeKind.Utc).AddTicks(960) },
                    { 25, null, new DateTime(2023, 10, 11, 16, 50, 15, 694, DateTimeKind.Utc).AddTicks(9260), 1, new DateTime(2023, 10, 11, 16, 50, 15, 694, DateTimeKind.Utc).AddTicks(9260) },
                    { 26, null, new DateTime(2023, 10, 11, 16, 50, 15, 759, DateTimeKind.Utc).AddTicks(5790), 1, new DateTime(2023, 10, 11, 16, 50, 15, 759, DateTimeKind.Utc).AddTicks(5790) },
                    { 27, null, new DateTime(2023, 10, 11, 16, 50, 15, 825, DateTimeKind.Utc).AddTicks(9960), 1, new DateTime(2023, 10, 11, 16, 50, 15, 825, DateTimeKind.Utc).AddTicks(9960) },
                    { 28, null, new DateTime(2023, 10, 11, 16, 50, 15, 891, DateTimeKind.Utc).AddTicks(2910), 1, new DateTime(2023, 10, 11, 16, 50, 15, 891, DateTimeKind.Utc).AddTicks(2910) },
                    { 29, null, new DateTime(2023, 10, 11, 16, 50, 15, 956, DateTimeKind.Utc).AddTicks(7920), 1, new DateTime(2023, 10, 11, 16, 50, 15, 956, DateTimeKind.Utc).AddTicks(7920) },
                    { 30, null, new DateTime(2023, 10, 11, 16, 50, 16, 23, DateTimeKind.Utc).AddTicks(440), 1, new DateTime(2023, 10, 11, 16, 50, 16, 23, DateTimeKind.Utc).AddTicks(440) },
                    { 31, null, new DateTime(2023, 10, 11, 16, 50, 16, 90, DateTimeKind.Utc).AddTicks(5880), 1, new DateTime(2023, 10, 11, 16, 50, 16, 90, DateTimeKind.Utc).AddTicks(5880) },
                    { 32, null, new DateTime(2023, 10, 11, 16, 50, 16, 157, DateTimeKind.Utc).AddTicks(7590), 1, new DateTime(2023, 10, 11, 16, 50, 16, 157, DateTimeKind.Utc).AddTicks(7600) },
                    { 33, null, new DateTime(2023, 10, 11, 16, 50, 16, 224, DateTimeKind.Utc).AddTicks(780), 1, new DateTime(2023, 10, 11, 16, 50, 16, 224, DateTimeKind.Utc).AddTicks(780) },
                    { 34, null, new DateTime(2023, 10, 11, 16, 50, 16, 289, DateTimeKind.Utc).AddTicks(9950), 1, new DateTime(2023, 10, 11, 16, 50, 16, 289, DateTimeKind.Utc).AddTicks(9950) },
                    { 35, null, new DateTime(2023, 10, 11, 16, 50, 16, 355, DateTimeKind.Utc).AddTicks(7200), 1, new DateTime(2023, 10, 11, 16, 50, 16, 355, DateTimeKind.Utc).AddTicks(7200) },
                    { 36, null, new DateTime(2023, 10, 11, 16, 50, 16, 421, DateTimeKind.Utc).AddTicks(2030), 1, new DateTime(2023, 10, 11, 16, 50, 16, 421, DateTimeKind.Utc).AddTicks(2030) },
                    { 37, null, new DateTime(2023, 10, 11, 16, 50, 16, 485, DateTimeKind.Utc).AddTicks(7880), 1, new DateTime(2023, 10, 11, 16, 50, 16, 485, DateTimeKind.Utc).AddTicks(7880) },
                    { 38, null, new DateTime(2023, 10, 11, 16, 50, 16, 550, DateTimeKind.Utc).AddTicks(1240), 1, new DateTime(2023, 10, 11, 16, 50, 16, 550, DateTimeKind.Utc).AddTicks(1240) },
                    { 39, null, new DateTime(2023, 10, 11, 16, 50, 16, 614, DateTimeKind.Utc).AddTicks(3370), 1, new DateTime(2023, 10, 11, 16, 50, 16, 614, DateTimeKind.Utc).AddTicks(3370) },
                    { 40, null, new DateTime(2023, 10, 11, 16, 50, 16, 678, DateTimeKind.Utc).AddTicks(3040), 1, new DateTime(2023, 10, 11, 16, 50, 16, 678, DateTimeKind.Utc).AddTicks(3040) },
                    { 41, null, new DateTime(2023, 10, 11, 16, 50, 16, 743, DateTimeKind.Utc).AddTicks(3890), 1, new DateTime(2023, 10, 11, 16, 50, 16, 743, DateTimeKind.Utc).AddTicks(3890) },
                    { 42, null, new DateTime(2023, 10, 11, 16, 50, 16, 808, DateTimeKind.Utc).AddTicks(3170), 1, new DateTime(2023, 10, 11, 16, 50, 16, 808, DateTimeKind.Utc).AddTicks(3170) },
                    { 43, null, new DateTime(2023, 10, 11, 16, 50, 16, 873, DateTimeKind.Utc).AddTicks(1290), 1, new DateTime(2023, 10, 11, 16, 50, 16, 873, DateTimeKind.Utc).AddTicks(1290) },
                    { 44, null, new DateTime(2023, 10, 11, 16, 50, 16, 937, DateTimeKind.Utc).AddTicks(9910), 1, new DateTime(2023, 10, 11, 16, 50, 16, 937, DateTimeKind.Utc).AddTicks(9910) },
                    { 45, null, new DateTime(2023, 10, 11, 16, 50, 17, 5, DateTimeKind.Utc).AddTicks(4710), 1, new DateTime(2023, 10, 11, 16, 50, 17, 5, DateTimeKind.Utc).AddTicks(4710) },
                    { 46, null, new DateTime(2023, 10, 11, 16, 50, 17, 70, DateTimeKind.Utc).AddTicks(3530), 1, new DateTime(2023, 10, 11, 16, 50, 17, 70, DateTimeKind.Utc).AddTicks(3530) },
                    { 47, null, new DateTime(2023, 10, 11, 16, 50, 17, 138, DateTimeKind.Utc).AddTicks(9830), 1, new DateTime(2023, 10, 11, 16, 50, 17, 138, DateTimeKind.Utc).AddTicks(9830) },
                    { 48, null, new DateTime(2023, 10, 11, 16, 50, 17, 211, DateTimeKind.Utc).AddTicks(9550), 1, new DateTime(2023, 10, 11, 16, 50, 17, 211, DateTimeKind.Utc).AddTicks(9550) },
                    { 49, null, new DateTime(2023, 10, 11, 16, 50, 17, 276, DateTimeKind.Utc).AddTicks(5600), 1, new DateTime(2023, 10, 11, 16, 50, 17, 276, DateTimeKind.Utc).AddTicks(5600) },
                    { 50, null, new DateTime(2023, 10, 11, 16, 50, 17, 343, DateTimeKind.Utc).AddTicks(320), 1, new DateTime(2023, 10, 11, 16, 50, 17, 343, DateTimeKind.Utc).AddTicks(320) },
                    { 51, null, new DateTime(2023, 10, 11, 16, 50, 17, 407, DateTimeKind.Utc).AddTicks(8990), 1, new DateTime(2023, 10, 11, 16, 50, 17, 407, DateTimeKind.Utc).AddTicks(8990) },
                    { 52, null, new DateTime(2023, 10, 11, 16, 50, 17, 472, DateTimeKind.Utc).AddTicks(9670), 1, new DateTime(2023, 10, 11, 16, 50, 17, 472, DateTimeKind.Utc).AddTicks(9670) },
                    { 53, null, new DateTime(2023, 10, 11, 16, 50, 17, 537, DateTimeKind.Utc).AddTicks(610), 1, new DateTime(2023, 10, 11, 16, 50, 17, 537, DateTimeKind.Utc).AddTicks(610) },
                    { 54, null, new DateTime(2023, 10, 11, 16, 50, 17, 604, DateTimeKind.Utc).AddTicks(1920), 1, new DateTime(2023, 10, 11, 16, 50, 17, 604, DateTimeKind.Utc).AddTicks(1920) },
                    { 55, null, new DateTime(2023, 10, 11, 16, 50, 17, 670, DateTimeKind.Utc).AddTicks(1730), 1, new DateTime(2023, 10, 11, 16, 50, 17, 670, DateTimeKind.Utc).AddTicks(1730) },
                    { 56, null, new DateTime(2023, 10, 11, 16, 50, 17, 735, DateTimeKind.Utc).AddTicks(400), 1, new DateTime(2023, 10, 11, 16, 50, 17, 735, DateTimeKind.Utc).AddTicks(400) },
                    { 57, null, new DateTime(2023, 10, 11, 16, 50, 17, 799, DateTimeKind.Utc).AddTicks(7960), 1, new DateTime(2023, 10, 11, 16, 50, 17, 799, DateTimeKind.Utc).AddTicks(7960) },
                    { 58, null, new DateTime(2023, 10, 11, 16, 50, 17, 864, DateTimeKind.Utc).AddTicks(5050), 1, new DateTime(2023, 10, 11, 16, 50, 17, 864, DateTimeKind.Utc).AddTicks(5060) },
                    { 59, null, new DateTime(2023, 10, 11, 16, 50, 17, 927, DateTimeKind.Utc).AddTicks(7090), 1, new DateTime(2023, 10, 11, 16, 50, 17, 927, DateTimeKind.Utc).AddTicks(7090) },
                    { 60, null, new DateTime(2023, 10, 11, 16, 50, 17, 991, DateTimeKind.Utc).AddTicks(8320), 1, new DateTime(2023, 10, 11, 16, 50, 17, 991, DateTimeKind.Utc).AddTicks(8320) },
                    { 61, null, new DateTime(2023, 10, 11, 16, 50, 18, 55, DateTimeKind.Utc).AddTicks(6600), 1, new DateTime(2023, 10, 11, 16, 50, 18, 55, DateTimeKind.Utc).AddTicks(6600) },
                    { 62, null, new DateTime(2023, 10, 11, 16, 50, 18, 121, DateTimeKind.Utc).AddTicks(8470), 1, new DateTime(2023, 10, 11, 16, 50, 18, 121, DateTimeKind.Utc).AddTicks(8480) },
                    { 63, null, new DateTime(2023, 10, 11, 16, 50, 18, 186, DateTimeKind.Utc).AddTicks(8000), 1, new DateTime(2023, 10, 11, 16, 50, 18, 186, DateTimeKind.Utc).AddTicks(8000) },
                    { 64, null, new DateTime(2023, 10, 11, 16, 50, 18, 252, DateTimeKind.Utc).AddTicks(3630), 1, new DateTime(2023, 10, 11, 16, 50, 18, 252, DateTimeKind.Utc).AddTicks(3630) },
                    { 65, null, new DateTime(2023, 10, 11, 16, 50, 18, 317, DateTimeKind.Utc).AddTicks(1590), 1, new DateTime(2023, 10, 11, 16, 50, 18, 317, DateTimeKind.Utc).AddTicks(1590) },
                    { 66, null, new DateTime(2023, 10, 11, 16, 50, 18, 380, DateTimeKind.Utc).AddTicks(5880), 1, new DateTime(2023, 10, 11, 16, 50, 18, 380, DateTimeKind.Utc).AddTicks(5880) },
                    { 67, null, new DateTime(2023, 10, 11, 16, 50, 18, 445, DateTimeKind.Utc).AddTicks(350), 1, new DateTime(2023, 10, 11, 16, 50, 18, 445, DateTimeKind.Utc).AddTicks(350) },
                    { 68, null, new DateTime(2023, 10, 11, 16, 50, 18, 509, DateTimeKind.Utc).AddTicks(1270), 1, new DateTime(2023, 10, 11, 16, 50, 18, 509, DateTimeKind.Utc).AddTicks(1270) }
                });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 84, DateTimeKind.Utc).AddTicks(9000), new DateTime(2023, 10, 11, 16, 50, 14, 84, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 159, DateTimeKind.Utc).AddTicks(1640), new DateTime(2023, 10, 11, 16, 50, 14, 159, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 230, DateTimeKind.Utc).AddTicks(9300), new DateTime(2023, 10, 11, 16, 50, 14, 230, DateTimeKind.Utc).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 302, DateTimeKind.Utc).AddTicks(1390), new DateTime(2023, 10, 11, 16, 50, 14, 302, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 371, DateTimeKind.Utc).AddTicks(1810), new DateTime(2023, 10, 11, 16, 50, 14, 371, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 440, DateTimeKind.Utc).AddTicks(6060), new DateTime(2023, 10, 11, 16, 50, 14, 440, DateTimeKind.Utc).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 511, DateTimeKind.Utc).AddTicks(5370), new DateTime(2023, 10, 11, 16, 50, 14, 511, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 577, DateTimeKind.Utc).AddTicks(8830), new DateTime(2023, 10, 11, 16, 50, 14, 577, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 646, DateTimeKind.Utc).AddTicks(480), new DateTime(2023, 10, 11, 16, 50, 14, 646, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 11, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 712, DateTimeKind.Utc).AddTicks(2490), new DateTime(2023, 10, 11, 16, 50, 14, 712, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 12, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 779, DateTimeKind.Utc).AddTicks(9400), new DateTime(2023, 10, 11, 16, 50, 14, 779, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 13, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 847, DateTimeKind.Utc).AddTicks(1550), new DateTime(2023, 10, 11, 16, 50, 14, 847, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 14, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 913, DateTimeKind.Utc).AddTicks(5690), new DateTime(2023, 10, 11, 16, 50, 14, 913, DateTimeKind.Utc).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 15, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 979, DateTimeKind.Utc).AddTicks(5740), new DateTime(2023, 10, 11, 16, 50, 14, 979, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 17, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 43, DateTimeKind.Utc).AddTicks(9700), new DateTime(2023, 10, 11, 16, 50, 15, 43, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 18, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 110, DateTimeKind.Utc).AddTicks(8530), new DateTime(2023, 10, 11, 16, 50, 15, 110, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 19, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 175, DateTimeKind.Utc).AddTicks(8880), new DateTime(2023, 10, 11, 16, 50, 15, 175, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 20, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 240, DateTimeKind.Utc).AddTicks(8730), new DateTime(2023, 10, 11, 16, 50, 15, 240, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 84, DateTimeKind.Utc).AddTicks(8990), new DateTime(2023, 10, 11, 16, 50, 14, 84, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 159, DateTimeKind.Utc).AddTicks(1630), new DateTime(2023, 10, 11, 16, 50, 14, 159, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 230, DateTimeKind.Utc).AddTicks(9300), new DateTime(2023, 10, 11, 16, 50, 14, 230, DateTimeKind.Utc).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 302, DateTimeKind.Utc).AddTicks(1390), new DateTime(2023, 10, 11, 16, 50, 14, 302, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 371, DateTimeKind.Utc).AddTicks(1810), new DateTime(2023, 10, 11, 16, 50, 14, 371, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 440, DateTimeKind.Utc).AddTicks(6050), new DateTime(2023, 10, 11, 16, 50, 14, 440, DateTimeKind.Utc).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 511, DateTimeKind.Utc).AddTicks(5360), new DateTime(2023, 10, 11, 16, 50, 14, 511, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 577, DateTimeKind.Utc).AddTicks(8820), new DateTime(2023, 10, 11, 16, 50, 14, 577, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 646, DateTimeKind.Utc).AddTicks(470), new DateTime(2023, 10, 11, 16, 50, 14, 646, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 712, DateTimeKind.Utc).AddTicks(2480), new DateTime(2023, 10, 11, 16, 50, 14, 712, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 779, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 10, 11, 16, 50, 14, 779, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 847, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 10, 11, 16, 50, 14, 847, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 913, DateTimeKind.Utc).AddTicks(5680), new DateTime(2023, 10, 11, 16, 50, 14, 913, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 979, DateTimeKind.Utc).AddTicks(5740), new DateTime(2023, 10, 11, 16, 50, 14, 979, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 43, DateTimeKind.Utc).AddTicks(9700), new DateTime(2023, 10, 11, 16, 50, 15, 43, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 110, DateTimeKind.Utc).AddTicks(8530), new DateTime(2023, 10, 11, 16, 50, 15, 110, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 175, DateTimeKind.Utc).AddTicks(8880), new DateTime(2023, 10, 11, 16, 50, 15, 175, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 240, DateTimeKind.Utc).AddTicks(8720), new DateTime(2023, 10, 11, 16, 50, 15, 240, DateTimeKind.Utc).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 9, DateTimeKind.Utc).AddTicks(2810), "evan.pouros@email.com", "Evan", "Pouros", "AQAAAAIAAYagAAAAEOOQUHdcfvlE2O/AFNSEKtZGf3PmHAjCnSa2XtGGDhlC8BkIEjd4BS/150BmwIsrjA==", new DateTime(2023, 10, 11, 16, 50, 14, 9, DateTimeKind.Utc).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 87, DateTimeKind.Utc).AddTicks(850), "charlene.gaylord@email.com", "Charlene", "Gaylord", "AQAAAAIAAYagAAAAEFpH61lOSuM+Hx+Y2COALg7BNMTStd4iTmHpRteGOxIp1AZWpaT7TCAZtwtj7TrB0g==", new DateTime(2023, 10, 11, 16, 50, 14, 87, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 161, DateTimeKind.Utc).AddTicks(6670), "arden.wyman@email.com", "Arden", "Wyman", "AQAAAAIAAYagAAAAEMkpD5TT/yGUiIWrOtraZAC8t/0/C3xW+SKK0/149r4Ca6V8/LibMZFSzhmXWOQueg==", new DateTime(2023, 10, 11, 16, 50, 14, 161, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 233, DateTimeKind.Utc).AddTicks(7630), "helena.rippin@email.com", "Helena", "Rippin", "AQAAAAIAAYagAAAAEJGurv1H1CWXYcxEjpowwARVab4lIfiGU8rAS3BUEAnoNMKziWvJV6Xlzgh1d+GsVg==", new DateTime(2023, 10, 11, 16, 50, 14, 233, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 304, DateTimeKind.Utc).AddTicks(2540), "marco.collier@email.com", "Marco", "Collier", "AQAAAAIAAYagAAAAEO2YSvCX6XwqNCLTR7okTlPL4d6jCrFYWG4J2IhoaH9N15SzmrHZwa2HQ3/9cTX0bw==", new DateTime(2023, 10, 11, 16, 50, 14, 304, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 373, DateTimeKind.Utc).AddTicks(2620), "alanis.klocko@email.com", "Alanis", "Klocko", "AQAAAAIAAYagAAAAEJzj0/kgibwPkEtYHoon9vvqVbP+4t0Oe6/Pz1+SPkYIsFNQtG+1PezClDa9kpck5g==", new DateTime(2023, 10, 11, 16, 50, 14, 373, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 442, DateTimeKind.Utc).AddTicks(7940), "karlee.cormier@email.com", "Karlee", "Cormier", "AQAAAAIAAYagAAAAEEgoV1uO/ifZMRUYW7Llrxjuf0hsDA5dYEnxx1dfd/bOQRLMthaLEQssvwr00F7dcg==", new DateTime(2023, 10, 11, 16, 50, 14, 442, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 513, DateTimeKind.Utc).AddTicks(7980), "dawn.bosco@email.com", "Dawn", "Bosco", "AQAAAAIAAYagAAAAEALBdlOApHz3US6g0h5+lFxhhrYbdIYIAoU9z4kDtdSegqw0Tz9tv0hq903Xj/Pblg==", new DateTime(2023, 10, 11, 16, 50, 14, 513, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 580, DateTimeKind.Utc).AddTicks(950), "vicenta.durgan@email.com", "Vicenta", "Durgan", "AQAAAAIAAYagAAAAEIaYJeiirwqePs08+mxKzWj0IuBCqcK7nR4Y2uFlxNbNh4TcaZkHV18qRhd1Vn+hEQ==", new DateTime(2023, 10, 11, 16, 50, 14, 580, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 648, DateTimeKind.Utc).AddTicks(4020), "freddie.west@email.com", "Freddie", "West", "AQAAAAIAAYagAAAAEOEuCcuWJRdpXTz+cI3ipx7ksllNy2WYdQKFoqg0i6wmXYgnOzAMPMXvW4amY2pGUg==", new DateTime(2023, 10, 11, 16, 50, 14, 648, DateTimeKind.Utc).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 714, DateTimeKind.Utc).AddTicks(4850), "jaylan.spinka@email.com", "Jaylan", "Spinka", "AQAAAAIAAYagAAAAEAnIo73yMfp0RVuXq8YtlUku7jQKHUfELAPjeIOMaJqwzgNLw7cv59xpCAn7Ge4Wcg==", new DateTime(2023, 10, 11, 16, 50, 14, 714, DateTimeKind.Utc).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 781, DateTimeKind.Utc).AddTicks(9890), "rhoda.quitzon@email.com", "Rhoda", "Quitzon", "AQAAAAIAAYagAAAAEAVi0pr1Pw7NGMLzbVyAIA3fS5ScLWtYrtSlKY+Wf1kT0mOJ8o8b3Chd7Id+qZln3Q==", new DateTime(2023, 10, 11, 16, 50, 14, 781, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 849, DateTimeKind.Utc).AddTicks(2650), "kendall.carter@email.com", "Kendall", "Carter", "AQAAAAIAAYagAAAAEBDrk1pdFRQgTf5LPrdBG2XWqJ/Vn+STDo+E4j2puuqO9SY1QFN0PiYxblW0HzAKFQ==", new DateTime(2023, 10, 11, 16, 50, 14, 849, DateTimeKind.Utc).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 916, DateTimeKind.Utc).AddTicks(160), "rollin.wehner@email.com", "Rollin", "Wehner", "AQAAAAIAAYagAAAAENldNwukA/rAt9nXl7KjdhfCNe5pjaFqJ40y595SDwbiWiwZR9+Xg1UD+icOsRTGZg==", new DateTime(2023, 10, 11, 16, 50, 14, 916, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 14, 981, DateTimeKind.Utc).AddTicks(2650), "julio.streich@email.com", "Julio", "Streich", "AQAAAAIAAYagAAAAEOzkev0ocGH1/sFkKRqyGLadvbOX6ZCgrSU83UGyY0WcmrFSxBb3/I1UoTP8uxygOw==", new DateTime(2023, 10, 11, 16, 50, 14, 981, DateTimeKind.Utc).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 45, DateTimeKind.Utc).AddTicks(4400), "janick.ratke@email.com", "Janick", "Ratke", "AQAAAAIAAYagAAAAEIO7JPunF4rrkZcE16CvEju4p0N/raA30LQcS2cU+BuhehXV38qG421UPFUCfapc5Q==", new DateTime(2023, 10, 11, 16, 50, 15, 45, DateTimeKind.Utc).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 112, DateTimeKind.Utc).AddTicks(7680), "angela.kassulke@email.com", "Angela", "Kassulke", "AQAAAAIAAYagAAAAELzZu15cc3Q5IxQmTQQyF897is65GT0qM4fAjVC4yc0k8baP9u0Yz8nkcN5CsQRDaw==", new DateTime(2023, 10, 11, 16, 50, 15, 112, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 16, 50, 15, 177, DateTimeKind.Utc).AddTicks(6820), "rodrick.mueller@email.com", "Rodrick", "Mueller", "AQAAAAIAAYagAAAAEJvDnfXIg5jHVpJEVm7r+TuNU529EW9XUvmuzm83sbxPXNyC7CPllwxUktq1+DtrMQ==", new DateTime(2023, 10, 11, 16, 50, 15, 177, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 19, new DateTime(2023, 10, 11, 16, 50, 15, 242, DateTimeKind.Utc).AddTicks(4760), "jules.kovacek@email.com", "Jules", "Kovacek", "AQAAAAIAAYagAAAAEDyxmVfnDzjI8K2QsRAA81feq5i8IY32YHX0sQfWRQyOwJv6GvhxDnn0V9rxjQ97uw==", new DateTime(2023, 10, 11, 16, 50, 15, 242, DateTimeKind.Utc).AddTicks(4760) },
                    { 20, new DateTime(2023, 10, 11, 16, 50, 15, 307, DateTimeKind.Utc).AddTicks(8470), "juliet.hamill@email.com", "Juliet", "Hamill", "AQAAAAIAAYagAAAAEFeDT9sOdxKsj0sI8TzcUzeV+zoxsl9NlFTpxn5FPRcCr6upGFZW/hruYMgTxMYKbA==", new DateTime(2023, 10, 11, 16, 50, 15, 307, DateTimeKind.Utc).AddTicks(8470) },
                    { 21, new DateTime(2023, 10, 11, 16, 50, 15, 372, DateTimeKind.Utc).AddTicks(4290), "ora.marks@email.com", "Ora", "Marks", "AQAAAAIAAYagAAAAEIdMAGqdBA1b6XaO/Z560GEmVI6wgR1HrcSSIa8lWD0BDpqQ8FGhxK+1ctQ28DUw3w==", new DateTime(2023, 10, 11, 16, 50, 15, 372, DateTimeKind.Utc).AddTicks(4290) },
                    { 22, new DateTime(2023, 10, 11, 16, 50, 15, 436, DateTimeKind.Utc).AddTicks(4820), "aditya.anderson@email.com", "Aditya", "Anderson", "AQAAAAIAAYagAAAAEJCz6IaSSRb6mA2/mPMcdiWVFDv7c+Lh0GGXp4bSN5uR0Ys/DsbFfRzPgTXj1bHxjg==", new DateTime(2023, 10, 11, 16, 50, 15, 436, DateTimeKind.Utc).AddTicks(4820) },
                    { 23, new DateTime(2023, 10, 11, 16, 50, 15, 500, DateTimeKind.Utc).AddTicks(1920), "marielle.huels@email.com", "Marielle", "Huels", "AQAAAAIAAYagAAAAELMmY8+5mm8clsnzwSMqbipwyfl/fwaeDehXhOi9ubJ0pNRABhpeFTryxoMUA2BC6g==", new DateTime(2023, 10, 11, 16, 50, 15, 500, DateTimeKind.Utc).AddTicks(1920) },
                    { 24, new DateTime(2023, 10, 11, 16, 50, 15, 564, DateTimeKind.Utc).AddTicks(6720), "noemie.runolfsson@email.com", "Noemie", "Runolfsson", "AQAAAAIAAYagAAAAEAteijG/+h/xOv8JTYO7aaaid/0mlXb3bImwjToNBye+/TW+wCsC0NCF7ICsEyNyUg==", new DateTime(2023, 10, 11, 16, 50, 15, 564, DateTimeKind.Utc).AddTicks(6720) },
                    { 25, new DateTime(2023, 10, 11, 16, 50, 15, 630, DateTimeKind.Utc).AddTicks(8360), "pauline.russel@email.com", "Pauline", "Russel", "AQAAAAIAAYagAAAAENAcjlZuT6ny68mevT1Y6hBgYKysy9a1v96gq/YIFW4g9GemQzhBHsergUauBPpGuQ==", new DateTime(2023, 10, 11, 16, 50, 15, 630, DateTimeKind.Utc).AddTicks(8360) },
                    { 26, new DateTime(2023, 10, 11, 16, 50, 15, 696, DateTimeKind.Utc).AddTicks(6140), "liana.schultz@email.com", "Liana", "Schultz", "AQAAAAIAAYagAAAAEGZjVs0TJqhX5ytP3VHQZp6rtG4+/4DnK9tKUihcpxXgVBsN3+nrejZpAzMjkmRw8Q==", new DateTime(2023, 10, 11, 16, 50, 15, 696, DateTimeKind.Utc).AddTicks(6140) },
                    { 27, new DateTime(2023, 10, 11, 16, 50, 15, 761, DateTimeKind.Utc).AddTicks(990), "claud.kautzer@email.com", "Claud", "Kautzer", "AQAAAAIAAYagAAAAEJnyjtfbLzHqGhhOFwBVDZFBBN+dUI2EFU1izHSEOjCiMSvjbVaEBzvsmQzdPpUpwA==", new DateTime(2023, 10, 11, 16, 50, 15, 761, DateTimeKind.Utc).AddTicks(990) },
                    { 28, new DateTime(2023, 10, 11, 16, 50, 15, 828, DateTimeKind.Utc).AddTicks(4030), "hulda.connelly@email.com", "Hulda", "Connelly", "AQAAAAIAAYagAAAAEBOJo1IROSitGCd0fJzyh+ntTSAydjkT5YvfB0JnNnzjpPxJcDx/GseEf6/4svomGg==", new DateTime(2023, 10, 11, 16, 50, 15, 828, DateTimeKind.Utc).AddTicks(4030) },
                    { 29, new DateTime(2023, 10, 11, 16, 50, 15, 892, DateTimeKind.Utc).AddTicks(9600), "kevin.hintz@email.com", "Kevin", "Hintz", "AQAAAAIAAYagAAAAEIOycBFYdlDVPoREfB2V4CVqI212zJ4+X+DPImjxCzgPZCt2cnXM47qE29GEsuRtdg==", new DateTime(2023, 10, 11, 16, 50, 15, 892, DateTimeKind.Utc).AddTicks(9600) },
                    { 30, new DateTime(2023, 10, 11, 16, 50, 15, 958, DateTimeKind.Utc).AddTicks(7860), "kailyn.goodwin@email.com", "Kailyn", "Goodwin", "AQAAAAIAAYagAAAAEMGHULc9HgnpOQmXMe815lHGSwUsa+0uk+d0KTmh1fznfzfhI766G/1jFNqo/+DV9A==", new DateTime(2023, 10, 11, 16, 50, 15, 958, DateTimeKind.Utc).AddTicks(7860) },
                    { 31, new DateTime(2023, 10, 11, 16, 50, 16, 24, DateTimeKind.Utc).AddTicks(8240), "emanuel.feeney@email.com", "Emanuel", "Feeney", "AQAAAAIAAYagAAAAEIav0Rd4Mb8yFolCKQ3Pw0rng0Ojv6z6kGClbcj5xo9X/mjxrnZK1zm9m4qSb5bJmA==", new DateTime(2023, 10, 11, 16, 50, 16, 24, DateTimeKind.Utc).AddTicks(8240) },
                    { 32, new DateTime(2023, 10, 11, 16, 50, 16, 92, DateTimeKind.Utc).AddTicks(5370), "damaris.kunze@email.com", "Damaris", "Kunze", "AQAAAAIAAYagAAAAEC0Xuv0VS0+8W6NR4d9YxJxopIUPUvzzI9sVlZNyYt4imf7TLp68spFLr8e8sB0FJg==", new DateTime(2023, 10, 11, 16, 50, 16, 92, DateTimeKind.Utc).AddTicks(5370) },
                    { 33, new DateTime(2023, 10, 11, 16, 50, 16, 160, DateTimeKind.Utc).AddTicks(2730), "mathias.reynolds@email.com", "Mathias", "Reynolds", "AQAAAAIAAYagAAAAEFP6cy2tUJn/u15J+Ew2/psxMAQq8UMMjy+L35uC8RV8eQGrvOXt0Tf5tHo+v8vZrA==", new DateTime(2023, 10, 11, 16, 50, 16, 160, DateTimeKind.Utc).AddTicks(2730) },
                    { 34, new DateTime(2023, 10, 11, 16, 50, 16, 226, DateTimeKind.Utc).AddTicks(1450), "conor.kihn@email.com", "Conor", "Kihn", "AQAAAAIAAYagAAAAEB8h1R2A+fLigPOALuj/jLiXudnpJZMLvwJn9GEVh+GlulYYJX6Oifp9K5wadwfj2w==", new DateTime(2023, 10, 11, 16, 50, 16, 226, DateTimeKind.Utc).AddTicks(1450) },
                    { 35, new DateTime(2023, 10, 11, 16, 50, 16, 292, DateTimeKind.Utc).AddTicks(100), "ozella.cole@email.com", "Ozella", "Cole", "AQAAAAIAAYagAAAAENUWfvdqVks40N1vM5cyxo+z7gTckkVW73SwADXP02BQMfN/0PNblbkp8rD9zyHn1g==", new DateTime(2023, 10, 11, 16, 50, 16, 292, DateTimeKind.Utc).AddTicks(100) },
                    { 36, new DateTime(2023, 10, 11, 16, 50, 16, 357, DateTimeKind.Utc).AddTicks(5680), "olin.bednar@email.com", "Olin", "Bednar", "AQAAAAIAAYagAAAAEAeLMADIvIfcSAKOOnBJzyK2E40Y7H5cpfhRuiGUatn/c3HCiw0AOCOLOqJO3NoANA==", new DateTime(2023, 10, 11, 16, 50, 16, 357, DateTimeKind.Utc).AddTicks(5680) },
                    { 37, new DateTime(2023, 10, 11, 16, 50, 16, 422, DateTimeKind.Utc).AddTicks(8130), "imani.huel@email.com", "Imani", "Huel", "AQAAAAIAAYagAAAAEBzog98bdptvEjbNGM5YYG4PFbufKQjinGYCeadvGEAmF1zkJsTG3jIBV+F+vvLumQ==", new DateTime(2023, 10, 11, 16, 50, 16, 422, DateTimeKind.Utc).AddTicks(8130) },
                    { 38, new DateTime(2023, 10, 11, 16, 50, 16, 487, DateTimeKind.Utc).AddTicks(3450), "alfonso.rempel@email.com", "Alfonso", "Rempel", "AQAAAAIAAYagAAAAEMP6y0ej7OEGKf1R4u0WGodA7trcJXg+QfUJxHVUlej7q8iNjQrumtf0ua/unwlSXw==", new DateTime(2023, 10, 11, 16, 50, 16, 487, DateTimeKind.Utc).AddTicks(3450) },
                    { 39, new DateTime(2023, 10, 11, 16, 50, 16, 551, DateTimeKind.Utc).AddTicks(6200), "percy.luettgen@email.com", "Percy", "Luettgen", "AQAAAAIAAYagAAAAEJkP+lGgPhpoz7F0PILUnrcw8yYds/OgQmdSYWeJy6SAEr+HPxtK8w8Q2GGHoDC16w==", new DateTime(2023, 10, 11, 16, 50, 16, 551, DateTimeKind.Utc).AddTicks(6200) },
                    { 40, new DateTime(2023, 10, 11, 16, 50, 16, 615, DateTimeKind.Utc).AddTicks(9410), "fredrick.fritsch@email.com", "Fredrick", "Fritsch", "AQAAAAIAAYagAAAAEJH0yb292C6pcs1DYh2llslUlKMqraIYcudTfQM/+r+U2fK4kINvZ09KjcKDi1Ehag==", new DateTime(2023, 10, 11, 16, 50, 16, 615, DateTimeKind.Utc).AddTicks(9410) },
                    { 41, new DateTime(2023, 10, 11, 16, 50, 16, 679, DateTimeKind.Utc).AddTicks(7750), "richmond.langworth@email.com", "Richmond", "Langworth", "AQAAAAIAAYagAAAAEFOeFVYhfD+WannT363IbJozlYX5Z3rq3ZqbJL0wX/e5Ka71vMcwqaTbrDi5jxo8iw==", new DateTime(2023, 10, 11, 16, 50, 16, 679, DateTimeKind.Utc).AddTicks(7750) },
                    { 42, new DateTime(2023, 10, 11, 16, 50, 16, 745, DateTimeKind.Utc).AddTicks(400), "velma.bechtelar@email.com", "Velma", "Bechtelar", "AQAAAAIAAYagAAAAEC6LRxEjiZk9mMF8QlO5anQDl7821XY59Qjgi7y72yQn0Kegg5MAE38y0MwGeDMq6A==", new DateTime(2023, 10, 11, 16, 50, 16, 745, DateTimeKind.Utc).AddTicks(410) },
                    { 43, new DateTime(2023, 10, 11, 16, 50, 16, 810, DateTimeKind.Utc).AddTicks(1160), "xander.daugherty@email.com", "Xander", "Daugherty", "AQAAAAIAAYagAAAAEFQ3Ni8n9Um7vzyAFb8Dw5LOHKqsU5PpE+2QB9crnL30RN8l+Lvsm5ffKvlUzvw5RQ==", new DateTime(2023, 10, 11, 16, 50, 16, 810, DateTimeKind.Utc).AddTicks(1160) },
                    { 44, new DateTime(2023, 10, 11, 16, 50, 16, 874, DateTimeKind.Utc).AddTicks(8050), "ona.wisoky@email.com", "Ona", "Wisoky", "AQAAAAIAAYagAAAAENX8531UcQebz7i4yZXxZj7cRyNYcUGT98TxVGOULZU7FHS9R/pNR1FzAAQC0VcL9Q==", new DateTime(2023, 10, 11, 16, 50, 16, 874, DateTimeKind.Utc).AddTicks(8050) },
                    { 45, new DateTime(2023, 10, 11, 16, 50, 16, 939, DateTimeKind.Utc).AddTicks(7960), "grayson.schinner@email.com", "Grayson", "Schinner", "AQAAAAIAAYagAAAAEKpzhRuJed7cKv5kfCtV+BOdTDlS0dU3pii4Ckg2ofLqFx3cD6EdK37zn/E8ND2e2Q==", new DateTime(2023, 10, 11, 16, 50, 16, 939, DateTimeKind.Utc).AddTicks(7960) },
                    { 46, new DateTime(2023, 10, 11, 16, 50, 17, 7, DateTimeKind.Utc).AddTicks(6580), "iliana.morissette@email.com", "Iliana", "Morissette", "AQAAAAIAAYagAAAAEDGLAWFgbbZYNn1t/1DnU2kxytRjMd+gdbxsMIgDaWvRsiIlLVLH6kWDaVgTtiMuqw==", new DateTime(2023, 10, 11, 16, 50, 17, 7, DateTimeKind.Utc).AddTicks(6580) },
                    { 47, new DateTime(2023, 10, 11, 16, 50, 17, 72, DateTimeKind.Utc).AddTicks(2980), "erich.bogisich@email.com", "Erich", "Bogisich", "AQAAAAIAAYagAAAAEEenHgdAorJoCEq1ZwzZHd7X1fWuxRR2d8rQnAE2E166UklA+69e1Qn/gOLhCRNsrQ==", new DateTime(2023, 10, 11, 16, 50, 17, 72, DateTimeKind.Utc).AddTicks(2980) },
                    { 48, new DateTime(2023, 10, 11, 16, 50, 17, 148, DateTimeKind.Utc).AddTicks(9760), "henriette.goodwin@email.com", "Henriette", "Goodwin", "AQAAAAIAAYagAAAAECpEPe7C26soIXrtE3BIsvr9b2kaFJLCG9hKUlh7sXBh5p6ApRMQfSyxNfNqyr/Lyw==", new DateTime(2023, 10, 11, 16, 50, 17, 148, DateTimeKind.Utc).AddTicks(9760) },
                    { 49, new DateTime(2023, 10, 11, 16, 50, 17, 212, DateTimeKind.Utc).AddTicks(9110), "jeanette.olson@email.com", "Jeanette", "Olson", "AQAAAAIAAYagAAAAEHwP1JBj9nyu9YRitfrqAnR6vGHsBM+RITfi23nDzARTE3XXOCU1Wa/YcVr++yDwKg==", new DateTime(2023, 10, 11, 16, 50, 17, 212, DateTimeKind.Utc).AddTicks(9110) },
                    { 50, new DateTime(2023, 10, 11, 16, 50, 17, 277, DateTimeKind.Utc).AddTicks(5180), "mohammed.upton@email.com", "Mohammed", "Upton", "AQAAAAIAAYagAAAAECcd4/ua3umZdXdIuEdpCpx9/aSOzblsj3y4spLwNpKD1eDs8Z+ZulZh0UTmCgaM0w==", new DateTime(2023, 10, 11, 16, 50, 17, 277, DateTimeKind.Utc).AddTicks(5180) },
                    { 51, new DateTime(2023, 10, 11, 16, 50, 17, 344, DateTimeKind.Utc).AddTicks(540), "laisha.luettgen@email.com", "Laisha", "Luettgen", "AQAAAAIAAYagAAAAEMXan1fO2qVYTSA/YClMl9LFSRPtsH0VAFl0mPJ7NlvJA45Wrlm3TatRnwLO7w7SSw==", new DateTime(2023, 10, 11, 16, 50, 17, 344, DateTimeKind.Utc).AddTicks(540) },
                    { 52, new DateTime(2023, 10, 11, 16, 50, 17, 408, DateTimeKind.Utc).AddTicks(8340), "shaina.douglas@email.com", "Shaina", "Douglas", "AQAAAAIAAYagAAAAEPGW0HUXN+8GDjfV+/3o8vs+ZQsrbVo16nBUipD0G8HGAKMYMQmKs3zTCilGWhlwiQ==", new DateTime(2023, 10, 11, 16, 50, 17, 408, DateTimeKind.Utc).AddTicks(8340) },
                    { 53, new DateTime(2023, 10, 11, 16, 50, 17, 473, DateTimeKind.Utc).AddTicks(8730), "kamron.durgan@email.com", "Kamron", "Durgan", "AQAAAAIAAYagAAAAEKt55lWyaCcVHIrbG83/BhFJoHN15Bkh2Pf906pmcp0uEBZwd47s+jtvDe3hygyJnA==", new DateTime(2023, 10, 11, 16, 50, 17, 473, DateTimeKind.Utc).AddTicks(8730) },
                    { 54, new DateTime(2023, 10, 11, 16, 50, 17, 538, DateTimeKind.Utc).AddTicks(710), "crystal.upton@email.com", "Crystal", "Upton", "AQAAAAIAAYagAAAAEJuBuIeIl2tAYV2uivn5j+UWM3uE+Wr/aoQX2FJWGRf2F1wyZm0DKW2NHpWOevy3rg==", new DateTime(2023, 10, 11, 16, 50, 17, 538, DateTimeKind.Utc).AddTicks(710) },
                    { 55, new DateTime(2023, 10, 11, 16, 50, 17, 605, DateTimeKind.Utc).AddTicks(3700), "wilbert.herzog@email.com", "Wilbert", "Herzog", "AQAAAAIAAYagAAAAEEJUaRsj9u0t6wq+uWc0bqxOVxGSXfmKRuYUhkb6wJS7RkFP7ElwaVF52Ia21CqtDQ==", new DateTime(2023, 10, 11, 16, 50, 17, 605, DateTimeKind.Utc).AddTicks(3700) },
                    { 56, new DateTime(2023, 10, 11, 16, 50, 17, 671, DateTimeKind.Utc).AddTicks(1690), "bertrand.wyman@email.com", "Bertrand", "Wyman", "AQAAAAIAAYagAAAAEA7K1cDuwi3SAIoUotC/1qPyzpNYE+8/utKNFcjXmnGIQlCjNa6pmIGpQqOnwWeIUg==", new DateTime(2023, 10, 11, 16, 50, 17, 671, DateTimeKind.Utc).AddTicks(1690) },
                    { 57, new DateTime(2023, 10, 11, 16, 50, 17, 736, DateTimeKind.Utc).AddTicks(230), "imani.mayert@email.com", "Imani", "Mayert", "AQAAAAIAAYagAAAAEJSAfKzwTXqJJPvYZeRPYPvJBaY3VNHFeu+lGbASy3xacazVtSWLseHS6ILNViiFqg==", new DateTime(2023, 10, 11, 16, 50, 17, 736, DateTimeKind.Utc).AddTicks(230) },
                    { 58, new DateTime(2023, 10, 11, 16, 50, 17, 800, DateTimeKind.Utc).AddTicks(8080), "malvina.davis@email.com", "Malvina", "Davis", "AQAAAAIAAYagAAAAEGuX7RdozIkLObV/MJnaFokDPHiml7TI9xsL6gtO52RykYUQ15I6btgbTdtBTrJEXw==", new DateTime(2023, 10, 11, 16, 50, 17, 800, DateTimeKind.Utc).AddTicks(8080) },
                    { 59, new DateTime(2023, 10, 11, 16, 50, 17, 865, DateTimeKind.Utc).AddTicks(4120), "kaela.hodkiewicz@email.com", "Kaela", "Hodkiewicz", "AQAAAAIAAYagAAAAEFAtZiP9UIc+RXGjTuP+Wu2vcreMwS63oeU76ttY9rZ1pxc+aCWpheIcrl6bIq8d2w==", new DateTime(2023, 10, 11, 16, 50, 17, 865, DateTimeKind.Utc).AddTicks(4120) },
                    { 60, new DateTime(2023, 10, 11, 16, 50, 17, 928, DateTimeKind.Utc).AddTicks(8950), "princess.stamm@email.com", "Princess", "Stamm", "AQAAAAIAAYagAAAAEJz+xn+llD+6eo09ioOnzoJIh6LGhejIW3MKVNwL66/D5iC2ArdElZQMaBk3AU6v5g==", new DateTime(2023, 10, 11, 16, 50, 17, 928, DateTimeKind.Utc).AddTicks(8950) },
                    { 61, new DateTime(2023, 10, 11, 16, 50, 17, 992, DateTimeKind.Utc).AddTicks(8980), "vance.rowe@email.com", "Vance", "Rowe", "AQAAAAIAAYagAAAAEG+LxhELyorSnwhemgfWKRVObAZFY23Kgx/dz+vysBd8uCaEDXpdgtM3CecXLgNQnA==", new DateTime(2023, 10, 11, 16, 50, 17, 992, DateTimeKind.Utc).AddTicks(8980) },
                    { 62, new DateTime(2023, 10, 11, 16, 50, 18, 56, DateTimeKind.Utc).AddTicks(6070), "ernie.kovacek@email.com", "Ernie", "Kovacek", "AQAAAAIAAYagAAAAEHBBA3FPq9H7wves499eSb3c3HrO2gmEC3NAlB5SaK68N3/FeSeFof8oG8185NPdDg==", new DateTime(2023, 10, 11, 16, 50, 18, 56, DateTimeKind.Utc).AddTicks(6070) },
                    { 63, new DateTime(2023, 10, 11, 16, 50, 18, 122, DateTimeKind.Utc).AddTicks(8760), "summer.hansen@email.com", "Summer", "Hansen", "AQAAAAIAAYagAAAAEMrE69ryPFzLK2BBJ2UjvRrsUXBR7zm7H9YeLEdUkyB+1mz07F+5qmpCkkt3/bxwHA==", new DateTime(2023, 10, 11, 16, 50, 18, 122, DateTimeKind.Utc).AddTicks(8760) },
                    { 64, new DateTime(2023, 10, 11, 16, 50, 18, 187, DateTimeKind.Utc).AddTicks(8380), "kaela.littel@email.com", "Kaela", "Littel", "AQAAAAIAAYagAAAAELUxmda7ntaHG4bEUYLrCWy/DW3MoQ6EZQ0Dg8mqtg5WRUSenMY7d9b08v45+n5ABQ==", new DateTime(2023, 10, 11, 16, 50, 18, 187, DateTimeKind.Utc).AddTicks(8380) },
                    { 65, new DateTime(2023, 10, 11, 16, 50, 18, 253, DateTimeKind.Utc).AddTicks(3060), "carlee.huel@email.com", "Carlee", "Huel", "AQAAAAIAAYagAAAAEBKreMm+u2/pRzlGctMj2hkCtvWCdTE/QiNe5p8nhgRMIKGWwDOHJRw1iW2QT0LINg==", new DateTime(2023, 10, 11, 16, 50, 18, 253, DateTimeKind.Utc).AddTicks(3060) },
                    { 66, new DateTime(2023, 10, 11, 16, 50, 18, 318, DateTimeKind.Utc).AddTicks(1940), "adriel.o'hara@email.com", "Adriel", "O'Hara", "AQAAAAIAAYagAAAAEIGxdh2GNlN9ev/dljsRQ3bi1/QKHH8UVT++wBhEYZrj35tZs33Y1pC/wWjJ1XYyfA==", new DateTime(2023, 10, 11, 16, 50, 18, 318, DateTimeKind.Utc).AddTicks(1940) },
                    { 67, new DateTime(2023, 10, 11, 16, 50, 18, 381, DateTimeKind.Utc).AddTicks(7120), "betty.windler@email.com", "Betty", "Windler", "AQAAAAIAAYagAAAAEOvDn7m76d7FgjkarFuSFiOFu9oWPEZAsTdZrjEVGwpcWJR9kS+HZdJHt1cAOuAN3w==", new DateTime(2023, 10, 11, 16, 50, 18, 381, DateTimeKind.Utc).AddTicks(7120) },
                    { 68, new DateTime(2023, 10, 11, 16, 50, 18, 446, DateTimeKind.Utc).AddTicks(2970), "moshe.kub@email.com", "Moshe", "Kub", "AQAAAAIAAYagAAAAEOAsXhCR1YClONiylO8a7WiU7lbKbH+cG9AEcW5/BCOi162xzM+LVtMKtfnUWrAJrA==", new DateTime(2023, 10, 11, 16, 50, 18, 446, DateTimeKind.Utc).AddTicks(2970) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 19, 19, new DateTime(2023, 10, 11, 16, 50, 15, 305, DateTimeKind.Utc).AddTicks(9960), new DateTime(2023, 10, 11, 16, 50, 15, 305, DateTimeKind.Utc).AddTicks(9960) },
                    { 20, 20, new DateTime(2023, 10, 11, 16, 50, 15, 370, DateTimeKind.Utc).AddTicks(8480), new DateTime(2023, 10, 11, 16, 50, 15, 370, DateTimeKind.Utc).AddTicks(8480) },
                    { 21, 21, new DateTime(2023, 10, 11, 16, 50, 15, 435, DateTimeKind.Utc).AddTicks(90), new DateTime(2023, 10, 11, 16, 50, 15, 435, DateTimeKind.Utc).AddTicks(90) },
                    { 22, 22, new DateTime(2023, 10, 11, 16, 50, 15, 498, DateTimeKind.Utc).AddTicks(8560), new DateTime(2023, 10, 11, 16, 50, 15, 498, DateTimeKind.Utc).AddTicks(8560) },
                    { 23, 23, new DateTime(2023, 10, 11, 16, 50, 15, 563, DateTimeKind.Utc).AddTicks(830), new DateTime(2023, 10, 11, 16, 50, 15, 563, DateTimeKind.Utc).AddTicks(830) },
                    { 24, 24, new DateTime(2023, 10, 11, 16, 50, 15, 629, DateTimeKind.Utc).AddTicks(960), new DateTime(2023, 10, 11, 16, 50, 15, 629, DateTimeKind.Utc).AddTicks(960) },
                    { 25, 25, new DateTime(2023, 10, 11, 16, 50, 15, 694, DateTimeKind.Utc).AddTicks(9270), new DateTime(2023, 10, 11, 16, 50, 15, 694, DateTimeKind.Utc).AddTicks(9270) },
                    { 26, 26, new DateTime(2023, 10, 11, 16, 50, 15, 759, DateTimeKind.Utc).AddTicks(5800), new DateTime(2023, 10, 11, 16, 50, 15, 759, DateTimeKind.Utc).AddTicks(5800) },
                    { 27, 27, new DateTime(2023, 10, 11, 16, 50, 15, 825, DateTimeKind.Utc).AddTicks(9960), new DateTime(2023, 10, 11, 16, 50, 15, 825, DateTimeKind.Utc).AddTicks(9960) },
                    { 28, 28, new DateTime(2023, 10, 11, 16, 50, 15, 891, DateTimeKind.Utc).AddTicks(2910), new DateTime(2023, 10, 11, 16, 50, 15, 891, DateTimeKind.Utc).AddTicks(2910) },
                    { 29, 29, new DateTime(2023, 10, 11, 16, 50, 15, 956, DateTimeKind.Utc).AddTicks(7930), new DateTime(2023, 10, 11, 16, 50, 15, 956, DateTimeKind.Utc).AddTicks(7930) },
                    { 30, 30, new DateTime(2023, 10, 11, 16, 50, 16, 23, DateTimeKind.Utc).AddTicks(440), new DateTime(2023, 10, 11, 16, 50, 16, 23, DateTimeKind.Utc).AddTicks(440) },
                    { 31, 31, new DateTime(2023, 10, 11, 16, 50, 16, 90, DateTimeKind.Utc).AddTicks(5880), new DateTime(2023, 10, 11, 16, 50, 16, 90, DateTimeKind.Utc).AddTicks(5880) },
                    { 32, 32, new DateTime(2023, 10, 11, 16, 50, 16, 157, DateTimeKind.Utc).AddTicks(7600), new DateTime(2023, 10, 11, 16, 50, 16, 157, DateTimeKind.Utc).AddTicks(7600) },
                    { 33, 33, new DateTime(2023, 10, 11, 16, 50, 16, 224, DateTimeKind.Utc).AddTicks(790), new DateTime(2023, 10, 11, 16, 50, 16, 224, DateTimeKind.Utc).AddTicks(790) },
                    { 34, 34, new DateTime(2023, 10, 11, 16, 50, 16, 289, DateTimeKind.Utc).AddTicks(9960), new DateTime(2023, 10, 11, 16, 50, 16, 289, DateTimeKind.Utc).AddTicks(9960) },
                    { 35, 35, new DateTime(2023, 10, 11, 16, 50, 16, 355, DateTimeKind.Utc).AddTicks(7200), new DateTime(2023, 10, 11, 16, 50, 16, 355, DateTimeKind.Utc).AddTicks(7210) },
                    { 36, 36, new DateTime(2023, 10, 11, 16, 50, 16, 421, DateTimeKind.Utc).AddTicks(2030), new DateTime(2023, 10, 11, 16, 50, 16, 421, DateTimeKind.Utc).AddTicks(2030) },
                    { 37, 37, new DateTime(2023, 10, 11, 16, 50, 16, 485, DateTimeKind.Utc).AddTicks(7890), new DateTime(2023, 10, 11, 16, 50, 16, 485, DateTimeKind.Utc).AddTicks(7890) },
                    { 38, 38, new DateTime(2023, 10, 11, 16, 50, 16, 550, DateTimeKind.Utc).AddTicks(1240), new DateTime(2023, 10, 11, 16, 50, 16, 550, DateTimeKind.Utc).AddTicks(1240) },
                    { 39, 39, new DateTime(2023, 10, 11, 16, 50, 16, 614, DateTimeKind.Utc).AddTicks(3380), new DateTime(2023, 10, 11, 16, 50, 16, 614, DateTimeKind.Utc).AddTicks(3380) },
                    { 40, 40, new DateTime(2023, 10, 11, 16, 50, 16, 678, DateTimeKind.Utc).AddTicks(3040), new DateTime(2023, 10, 11, 16, 50, 16, 678, DateTimeKind.Utc).AddTicks(3040) },
                    { 41, 41, new DateTime(2023, 10, 11, 16, 50, 16, 743, DateTimeKind.Utc).AddTicks(3890), new DateTime(2023, 10, 11, 16, 50, 16, 743, DateTimeKind.Utc).AddTicks(3890) },
                    { 42, 42, new DateTime(2023, 10, 11, 16, 50, 16, 808, DateTimeKind.Utc).AddTicks(3170), new DateTime(2023, 10, 11, 16, 50, 16, 808, DateTimeKind.Utc).AddTicks(3170) },
                    { 43, 43, new DateTime(2023, 10, 11, 16, 50, 16, 873, DateTimeKind.Utc).AddTicks(1290), new DateTime(2023, 10, 11, 16, 50, 16, 873, DateTimeKind.Utc).AddTicks(1290) },
                    { 44, 44, new DateTime(2023, 10, 11, 16, 50, 16, 937, DateTimeKind.Utc).AddTicks(9910), new DateTime(2023, 10, 11, 16, 50, 16, 937, DateTimeKind.Utc).AddTicks(9910) },
                    { 45, 45, new DateTime(2023, 10, 11, 16, 50, 17, 5, DateTimeKind.Utc).AddTicks(4710), new DateTime(2023, 10, 11, 16, 50, 17, 5, DateTimeKind.Utc).AddTicks(4710) },
                    { 46, 46, new DateTime(2023, 10, 11, 16, 50, 17, 70, DateTimeKind.Utc).AddTicks(3540), new DateTime(2023, 10, 11, 16, 50, 17, 70, DateTimeKind.Utc).AddTicks(3540) },
                    { 47, 47, new DateTime(2023, 10, 11, 16, 50, 17, 138, DateTimeKind.Utc).AddTicks(9840), new DateTime(2023, 10, 11, 16, 50, 17, 138, DateTimeKind.Utc).AddTicks(9840) },
                    { 48, 48, new DateTime(2023, 10, 11, 16, 50, 17, 211, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 10, 11, 16, 50, 17, 211, DateTimeKind.Utc).AddTicks(9550) },
                    { 49, 49, new DateTime(2023, 10, 11, 16, 50, 17, 276, DateTimeKind.Utc).AddTicks(5610), new DateTime(2023, 10, 11, 16, 50, 17, 276, DateTimeKind.Utc).AddTicks(5610) },
                    { 50, 50, new DateTime(2023, 10, 11, 16, 50, 17, 343, DateTimeKind.Utc).AddTicks(330), new DateTime(2023, 10, 11, 16, 50, 17, 343, DateTimeKind.Utc).AddTicks(330) },
                    { 51, 51, new DateTime(2023, 10, 11, 16, 50, 17, 407, DateTimeKind.Utc).AddTicks(8990), new DateTime(2023, 10, 11, 16, 50, 17, 407, DateTimeKind.Utc).AddTicks(8990) },
                    { 52, 52, new DateTime(2023, 10, 11, 16, 50, 17, 472, DateTimeKind.Utc).AddTicks(9670), new DateTime(2023, 10, 11, 16, 50, 17, 472, DateTimeKind.Utc).AddTicks(9670) },
                    { 53, 53, new DateTime(2023, 10, 11, 16, 50, 17, 537, DateTimeKind.Utc).AddTicks(610), new DateTime(2023, 10, 11, 16, 50, 17, 537, DateTimeKind.Utc).AddTicks(610) },
                    { 54, 54, new DateTime(2023, 10, 11, 16, 50, 17, 604, DateTimeKind.Utc).AddTicks(1930), new DateTime(2023, 10, 11, 16, 50, 17, 604, DateTimeKind.Utc).AddTicks(1930) },
                    { 55, 55, new DateTime(2023, 10, 11, 16, 50, 17, 670, DateTimeKind.Utc).AddTicks(1730), new DateTime(2023, 10, 11, 16, 50, 17, 670, DateTimeKind.Utc).AddTicks(1730) },
                    { 56, 56, new DateTime(2023, 10, 11, 16, 50, 17, 735, DateTimeKind.Utc).AddTicks(400), new DateTime(2023, 10, 11, 16, 50, 17, 735, DateTimeKind.Utc).AddTicks(400) },
                    { 57, 57, new DateTime(2023, 10, 11, 16, 50, 17, 799, DateTimeKind.Utc).AddTicks(7960), new DateTime(2023, 10, 11, 16, 50, 17, 799, DateTimeKind.Utc).AddTicks(7960) },
                    { 58, 58, new DateTime(2023, 10, 11, 16, 50, 17, 864, DateTimeKind.Utc).AddTicks(5060), new DateTime(2023, 10, 11, 16, 50, 17, 864, DateTimeKind.Utc).AddTicks(5060) },
                    { 59, 59, new DateTime(2023, 10, 11, 16, 50, 17, 927, DateTimeKind.Utc).AddTicks(7090), new DateTime(2023, 10, 11, 16, 50, 17, 927, DateTimeKind.Utc).AddTicks(7090) },
                    { 60, 60, new DateTime(2023, 10, 11, 16, 50, 17, 991, DateTimeKind.Utc).AddTicks(8320), new DateTime(2023, 10, 11, 16, 50, 17, 991, DateTimeKind.Utc).AddTicks(8320) },
                    { 61, 61, new DateTime(2023, 10, 11, 16, 50, 18, 55, DateTimeKind.Utc).AddTicks(6610), new DateTime(2023, 10, 11, 16, 50, 18, 55, DateTimeKind.Utc).AddTicks(6610) },
                    { 62, 62, new DateTime(2023, 10, 11, 16, 50, 18, 121, DateTimeKind.Utc).AddTicks(8480), new DateTime(2023, 10, 11, 16, 50, 18, 121, DateTimeKind.Utc).AddTicks(8480) },
                    { 63, 63, new DateTime(2023, 10, 11, 16, 50, 18, 186, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 10, 11, 16, 50, 18, 186, DateTimeKind.Utc).AddTicks(8010) },
                    { 64, 64, new DateTime(2023, 10, 11, 16, 50, 18, 252, DateTimeKind.Utc).AddTicks(3630), new DateTime(2023, 10, 11, 16, 50, 18, 252, DateTimeKind.Utc).AddTicks(3630) },
                    { 65, 65, new DateTime(2023, 10, 11, 16, 50, 18, 317, DateTimeKind.Utc).AddTicks(1600), new DateTime(2023, 10, 11, 16, 50, 18, 317, DateTimeKind.Utc).AddTicks(1600) },
                    { 66, 66, new DateTime(2023, 10, 11, 16, 50, 18, 380, DateTimeKind.Utc).AddTicks(5880), new DateTime(2023, 10, 11, 16, 50, 18, 380, DateTimeKind.Utc).AddTicks(5880) },
                    { 67, 67, new DateTime(2023, 10, 11, 16, 50, 18, 445, DateTimeKind.Utc).AddTicks(350), new DateTime(2023, 10, 11, 16, 50, 18, 445, DateTimeKind.Utc).AddTicks(350) },
                    { 68, 68, new DateTime(2023, 10, 11, 16, 50, 18, 509, DateTimeKind.Utc).AddTicks(1280), new DateTime(2023, 10, 11, 16, 50, 18, 509, DateTimeKind.Utc).AddTicks(1280) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 19, 19 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 20, 20 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 21, 21 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 22, 22 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 23, 23 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 24, 24 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 25, 25 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 26, 26 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 27, 27 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 28, 28 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 29, 29 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 30, 30 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 31, 31 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 32, 32 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 33, 33 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 34, 34 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 35, 35 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 36, 36 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 37, 37 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 38, 38 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 39, 39 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 40, 40 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 41, 41 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 42, 42 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 43, 43 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 44, 44 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 45, 45 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 46, 46 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 47, 47 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 48, 48 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 49, 49 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 50, 50 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 51, 51 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 52, 52 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 53, 53 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 54, 54 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 55, 55 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 56, 56 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 57, 57 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 58, 58 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 59, 59 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 60, 60 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 61, 61 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 62, 62 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 63, 63 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 64, 64 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 65, 65 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 66, 66 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 67, 67 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 68, 68 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 68);

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8080), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8250), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8270), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8280), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8320), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8330), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8350), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8360), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8380), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8390), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8420), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8430), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8450), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8460), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8470), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8500), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8510), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8520), new DateTime(2023, 10, 11, 15, 48, 34, 955, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610), new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2700), new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7300), new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220), new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2030), new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1910), new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830), new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110), new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1980), new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300), new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8440), new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6630), new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8490), new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8500), new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8520), new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410), new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4070), new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610), new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2710), new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7310), new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220), new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2090), new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1920), new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830), new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110), new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1990), new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 11, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300), new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 12, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8450), new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 13, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6640), new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 14, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8220), new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 15, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8500), new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 17, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8520), new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 18, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8530), new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 19, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410), new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 20, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4080), new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610), new DateTime(2023, 10, 11, 15, 48, 35, 20, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2710), new DateTime(2023, 10, 11, 15, 48, 35, 85, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7300), new DateTime(2023, 10, 11, 15, 48, 35, 151, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220), new DateTime(2023, 10, 11, 15, 48, 35, 218, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2030), new DateTime(2023, 10, 11, 15, 48, 35, 282, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1910), new DateTime(2023, 10, 11, 15, 48, 35, 347, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830), new DateTime(2023, 10, 11, 15, 48, 35, 412, DateTimeKind.Utc).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110), new DateTime(2023, 10, 11, 15, 48, 35, 477, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1980), new DateTime(2023, 10, 11, 15, 48, 35, 542, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 10, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300), new DateTime(2023, 10, 11, 15, 48, 35, 607, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 11, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8450), new DateTime(2023, 10, 11, 15, 48, 35, 671, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 12, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6630), new DateTime(2023, 10, 11, 15, 48, 35, 736, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 13, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 10, 11, 15, 48, 35, 803, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 14, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8500), new DateTime(2023, 10, 11, 15, 48, 35, 871, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 15, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8510), new DateTime(2023, 10, 11, 15, 48, 35, 942, DateTimeKind.Utc).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 16, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8520), new DateTime(2023, 10, 11, 15, 48, 36, 13, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 17, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410), new DateTime(2023, 10, 11, 15, 48, 36, 82, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 18, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4080), new DateTime(2023, 10, 11, 15, 48, 36, 152, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 34, 957, DateTimeKind.Utc).AddTicks(9030), "ole.gerlach@email.com", "Ole", "Gerlach", "AQAAAAIAAYagAAAAEFRW7f4APJR2wirXSe1QDlv/yqswzbiiTldFe3TE+Tq+lwmYYG2jhdWUf8PVZF0lsQ==", new DateTime(2023, 10, 11, 15, 48, 34, 957, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 22, DateTimeKind.Utc).AddTicks(5680), "tianna.auer@email.com", "Tianna", "Auer", "AQAAAAIAAYagAAAAEHaKHnnl/QZ006XLCBFlCl8/EO5wscRXRqF5wU8mj1hOoKtVrJi6K1YFE1YgwSyAWQ==", new DateTime(2023, 10, 11, 15, 48, 35, 22, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 87, DateTimeKind.Utc).AddTicks(2630), "abraham.reinger@email.com", "Abraham", "Reinger", "AQAAAAIAAYagAAAAEH+69RcAoFUxHTmLA99AY1WXuqj/8L8/Sg4tXv/deS9carq3LxF9Wb5+Qn+jzyXJRA==", new DateTime(2023, 10, 11, 15, 48, 35, 87, DateTimeKind.Utc).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 154, DateTimeKind.Utc).AddTicks(6180), "antonietta.weimann@email.com", "Antonietta", "Weimann", "AQAAAAIAAYagAAAAEKqtYXir+0672KBdJY0HdIG27B9yh/7lXkKN+2yZS3WzYuz+ZPmtkXP84bsG3guwQQ==", new DateTime(2023, 10, 11, 15, 48, 35, 154, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 220, DateTimeKind.Utc).AddTicks(2810), "creola.luettgen@email.com", "Creola", "Luettgen", "AQAAAAIAAYagAAAAEMgNEAlKcGEqyZ9piN4iBQ4pYcPonzyzFkk6YGln+MzIk6d5QofvqzUAv/9q4DDcCA==", new DateTime(2023, 10, 11, 15, 48, 35, 220, DateTimeKind.Utc).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 284, DateTimeKind.Utc).AddTicks(1840), "darrick.ankunding@email.com", "Darrick", "Ankunding", "AQAAAAIAAYagAAAAEMEzSEl8vI0DZexH1cpZIaq4EivxyBoD/nvEzkjMrUqqBw1ZoEZOaS4UduP2Y+0btQ==", new DateTime(2023, 10, 11, 15, 48, 35, 284, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 349, DateTimeKind.Utc).AddTicks(3850), "marcelino.spencer@email.com", "Marcelino", "Spencer", "AQAAAAIAAYagAAAAEAJKiMxKLlCXd4NfLJv5/L/8VZTpHKnFHEcKcIxsuLyQPbSL127URefd6eMIowstzA==", new DateTime(2023, 10, 11, 15, 48, 35, 349, DateTimeKind.Utc).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 414, DateTimeKind.Utc).AddTicks(2150), "penelope.grady@email.com", "Penelope", "Grady", "AQAAAAIAAYagAAAAEOUq6MYwPytaN+ztZ9B1j9PnhQdupze6qkGGQiuPjXFxYlZM/JbkXU741/464mIrYA==", new DateTime(2023, 10, 11, 15, 48, 35, 414, DateTimeKind.Utc).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 478, DateTimeKind.Utc).AddTicks(9760), "sandy.christiansen@email.com", "Sandy", "Christiansen", "AQAAAAIAAYagAAAAEBqxGbd1CU1zbRpvSzaJTrDKNSk3vUzmu9hslLu1wmkpD0jIANtnHY5MTAExKvEK5A==", new DateTime(2023, 10, 11, 15, 48, 35, 478, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 545, DateTimeKind.Utc).AddTicks(2910), "gerry.morar@email.com", "Gerry", "Morar", "AQAAAAIAAYagAAAAENCY78d0hUlweeASiiX46w4aSU3RhDzTCXv/Ki5wOHrJNolfF5E01OEtr7q8462iag==", new DateTime(2023, 10, 11, 15, 48, 35, 545, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 609, DateTimeKind.Utc).AddTicks(7430), "louvenia.herzog@email.com", "Louvenia", "Herzog", "AQAAAAIAAYagAAAAECyp6FYwAL4HbBKEl7YXKi5vuMyDzCtH5Hkxt2AgGn5UgenXSY35XmqEr/NwufISRQ==", new DateTime(2023, 10, 11, 15, 48, 35, 609, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 673, DateTimeKind.Utc).AddTicks(8580), "luciano.emard@email.com", "Luciano", "Emard", "AQAAAAIAAYagAAAAEOhOEtwuFpw8KJyxYJyE1RyTPGqG7fnaJvgwuP5bqh1cFPvXQ9iJlsWxGEVdras5JQ==", new DateTime(2023, 10, 11, 15, 48, 35, 673, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 738, DateTimeKind.Utc).AddTicks(5840), "keeley.marquardt@email.com", "Keeley", "Marquardt", "AQAAAAIAAYagAAAAEJNGY1sUX5VFkuwU57UAVr05TUF2M9i5oQqkMD5aDqMoWvwnFupSCca0Q9xTccK6tg==", new DateTime(2023, 10, 11, 15, 48, 35, 738, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 805, DateTimeKind.Utc).AddTicks(9330), "lincoln.cartwright@email.com", "Lincoln", "Cartwright", "AQAAAAIAAYagAAAAEEc9+2cAnC4tazMH/fKQG7eUn6CZs2leluf4B1MtNGCVVOQmYiqO6aEkqrYCpJjGJg==", new DateTime(2023, 10, 11, 15, 48, 35, 805, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 873, DateTimeKind.Utc).AddTicks(9550), "earl.kohler@email.com", "Earl", "Kohler", "AQAAAAIAAYagAAAAEDeucBNkcFJ3AotIuNYR13a6rrwLUCr6QPP39UN0IHYxpyL4dCm0OGOmM7+Y3su/eg==", new DateTime(2023, 10, 11, 15, 48, 35, 873, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 35, 945, DateTimeKind.Utc).AddTicks(6290), "brad.goyette@email.com", "Brad", "Goyette", "AQAAAAIAAYagAAAAEGbfbRuuY8fC6xWAsYt+FIWjQJlN5VwJRO1RcZKBB1NMm41JV3kUGtYpYj4RYJiRmA==", new DateTime(2023, 10, 11, 15, 48, 35, 945, DateTimeKind.Utc).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 36, 17, DateTimeKind.Utc).AddTicks(4900), "nellie.ryan@email.com", "Nellie", "Ryan", "AQAAAAIAAYagAAAAEJ5Nsjv2mAsdDEq1JeORXtmiLGU+XsKto7cBAYA5qGWXDSI/MjFq//GJwQGgjwz1EA==", new DateTime(2023, 10, 11, 15, 48, 36, 17, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 11, 15, 48, 36, 83, DateTimeKind.Utc).AddTicks(9870), "lyla.mclaughlin@email.com", "Lyla", "McLaughlin", "AQAAAAIAAYagAAAAEBqwb6G766nFpTu2UQj6exlJWRQBAPrudb4XpY3jk3eCZSKCT4N9uR7i8NJdV00LFA==", new DateTime(2023, 10, 11, 15, 48, 36, 83, DateTimeKind.Utc).AddTicks(9870) });
        }
    }
}
