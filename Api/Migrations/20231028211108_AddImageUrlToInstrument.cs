using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToInstrument : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Instruments",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7293), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7492), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7511), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7530), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7559), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7578), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7597), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7610), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7633), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7645), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7662), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7673), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7684), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7695), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7716), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7758), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7771), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7785), null, new DateTime(2023, 10, 28, 21, 11, 3, 983, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 53, DateTimeKind.Utc).AddTicks(376), new DateTime(2023, 10, 28, 21, 11, 4, 53, DateTimeKind.Utc).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 121, DateTimeKind.Utc).AddTicks(6582), new DateTime(2023, 10, 28, 21, 11, 4, 121, DateTimeKind.Utc).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 193, DateTimeKind.Utc).AddTicks(5065), new DateTime(2023, 10, 28, 21, 11, 4, 193, DateTimeKind.Utc).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 263, DateTimeKind.Utc).AddTicks(8454), new DateTime(2023, 10, 28, 21, 11, 4, 263, DateTimeKind.Utc).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 333, DateTimeKind.Utc).AddTicks(392), new DateTime(2023, 10, 28, 21, 11, 4, 333, DateTimeKind.Utc).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 402, DateTimeKind.Utc).AddTicks(4622), new DateTime(2023, 10, 28, 21, 11, 4, 402, DateTimeKind.Utc).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 471, DateTimeKind.Utc).AddTicks(7178), new DateTime(2023, 10, 28, 21, 11, 4, 471, DateTimeKind.Utc).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 542, DateTimeKind.Utc).AddTicks(708), new DateTime(2023, 10, 28, 21, 11, 4, 542, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 611, DateTimeKind.Utc).AddTicks(2674), new DateTime(2023, 10, 28, 21, 11, 4, 611, DateTimeKind.Utc).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 680, DateTimeKind.Utc).AddTicks(5962), new DateTime(2023, 10, 28, 21, 11, 4, 680, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 749, DateTimeKind.Utc).AddTicks(1202), new DateTime(2023, 10, 28, 21, 11, 4, 749, DateTimeKind.Utc).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 817, DateTimeKind.Utc).AddTicks(2746), new DateTime(2023, 10, 28, 21, 11, 4, 817, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 886, DateTimeKind.Utc).AddTicks(2411), new DateTime(2023, 10, 28, 21, 11, 4, 886, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 954, DateTimeKind.Utc).AddTicks(9798), new DateTime(2023, 10, 28, 21, 11, 4, 954, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 24, DateTimeKind.Utc).AddTicks(903), new DateTime(2023, 10, 28, 21, 11, 5, 24, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 92, DateTimeKind.Utc).AddTicks(6641), new DateTime(2023, 10, 28, 21, 11, 5, 92, DateTimeKind.Utc).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 161, DateTimeKind.Utc).AddTicks(5738), new DateTime(2023, 10, 28, 21, 11, 5, 161, DateTimeKind.Utc).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 230, DateTimeKind.Utc).AddTicks(4621), new DateTime(2023, 10, 28, 21, 11, 5, 230, DateTimeKind.Utc).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 299, DateTimeKind.Utc).AddTicks(3102), new DateTime(2023, 10, 28, 21, 11, 5, 299, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 367, DateTimeKind.Utc).AddTicks(9993), new DateTime(2023, 10, 28, 21, 11, 5, 367, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 437, DateTimeKind.Utc).AddTicks(1665), new DateTime(2023, 10, 28, 21, 11, 5, 437, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 505, DateTimeKind.Utc).AddTicks(9251), new DateTime(2023, 10, 28, 21, 11, 5, 505, DateTimeKind.Utc).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 574, DateTimeKind.Utc).AddTicks(8805), new DateTime(2023, 10, 28, 21, 11, 5, 574, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 643, DateTimeKind.Utc).AddTicks(9931), new DateTime(2023, 10, 28, 21, 11, 5, 643, DateTimeKind.Utc).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 712, DateTimeKind.Utc).AddTicks(3649), new DateTime(2023, 10, 28, 21, 11, 5, 712, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 781, DateTimeKind.Utc).AddTicks(2602), new DateTime(2023, 10, 28, 21, 11, 5, 781, DateTimeKind.Utc).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 851, DateTimeKind.Utc).AddTicks(1320), new DateTime(2023, 10, 28, 21, 11, 5, 851, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 919, DateTimeKind.Utc).AddTicks(7413), new DateTime(2023, 10, 28, 21, 11, 5, 919, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 988, DateTimeKind.Utc).AddTicks(1108), new DateTime(2023, 10, 28, 21, 11, 5, 988, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 56, DateTimeKind.Utc).AddTicks(8896), new DateTime(2023, 10, 28, 21, 11, 6, 56, DateTimeKind.Utc).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 125, DateTimeKind.Utc).AddTicks(4721), new DateTime(2023, 10, 28, 21, 11, 6, 125, DateTimeKind.Utc).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 194, DateTimeKind.Utc).AddTicks(2316), new DateTime(2023, 10, 28, 21, 11, 6, 194, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 263, DateTimeKind.Utc).AddTicks(6814), new DateTime(2023, 10, 28, 21, 11, 6, 263, DateTimeKind.Utc).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 333, DateTimeKind.Utc).AddTicks(289), new DateTime(2023, 10, 28, 21, 11, 6, 333, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 402, DateTimeKind.Utc).AddTicks(7868), new DateTime(2023, 10, 28, 21, 11, 6, 402, DateTimeKind.Utc).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 471, DateTimeKind.Utc).AddTicks(5404), new DateTime(2023, 10, 28, 21, 11, 6, 471, DateTimeKind.Utc).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 541, DateTimeKind.Utc).AddTicks(8528), new DateTime(2023, 10, 28, 21, 11, 6, 541, DateTimeKind.Utc).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 611, DateTimeKind.Utc).AddTicks(3196), new DateTime(2023, 10, 28, 21, 11, 6, 611, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 679, DateTimeKind.Utc).AddTicks(7097), new DateTime(2023, 10, 28, 21, 11, 6, 679, DateTimeKind.Utc).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 749, DateTimeKind.Utc).AddTicks(6373), new DateTime(2023, 10, 28, 21, 11, 6, 749, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 818, DateTimeKind.Utc).AddTicks(2992), new DateTime(2023, 10, 28, 21, 11, 6, 818, DateTimeKind.Utc).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 887, DateTimeKind.Utc).AddTicks(1294), new DateTime(2023, 10, 28, 21, 11, 6, 887, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 955, DateTimeKind.Utc).AddTicks(8410), new DateTime(2023, 10, 28, 21, 11, 6, 955, DateTimeKind.Utc).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 24, DateTimeKind.Utc).AddTicks(6288), new DateTime(2023, 10, 28, 21, 11, 7, 24, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 93, DateTimeKind.Utc).AddTicks(4740), new DateTime(2023, 10, 28, 21, 11, 7, 93, DateTimeKind.Utc).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 162, DateTimeKind.Utc).AddTicks(2312), new DateTime(2023, 10, 28, 21, 11, 7, 162, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 231, DateTimeKind.Utc).AddTicks(1079), new DateTime(2023, 10, 28, 21, 11, 7, 231, DateTimeKind.Utc).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 300, DateTimeKind.Utc).AddTicks(7360), new DateTime(2023, 10, 28, 21, 11, 7, 300, DateTimeKind.Utc).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 370, DateTimeKind.Utc).AddTicks(3639), new DateTime(2023, 10, 28, 21, 11, 7, 370, DateTimeKind.Utc).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 439, DateTimeKind.Utc).AddTicks(5967), new DateTime(2023, 10, 28, 21, 11, 7, 439, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 509, DateTimeKind.Utc).AddTicks(335), new DateTime(2023, 10, 28, 21, 11, 7, 509, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 578, DateTimeKind.Utc).AddTicks(1510), new DateTime(2023, 10, 28, 21, 11, 7, 578, DateTimeKind.Utc).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 646, DateTimeKind.Utc).AddTicks(7349), new DateTime(2023, 10, 28, 21, 11, 7, 646, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 715, DateTimeKind.Utc).AddTicks(5933), new DateTime(2023, 10, 28, 21, 11, 7, 715, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 784, DateTimeKind.Utc).AddTicks(5963), new DateTime(2023, 10, 28, 21, 11, 7, 784, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 853, DateTimeKind.Utc).AddTicks(9641), new DateTime(2023, 10, 28, 21, 11, 7, 853, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 922, DateTimeKind.Utc).AddTicks(4809), new DateTime(2023, 10, 28, 21, 11, 7, 922, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 991, DateTimeKind.Utc).AddTicks(1741), new DateTime(2023, 10, 28, 21, 11, 7, 991, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 60, DateTimeKind.Utc).AddTicks(1267), new DateTime(2023, 10, 28, 21, 11, 8, 60, DateTimeKind.Utc).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 128, DateTimeKind.Utc).AddTicks(9647), new DateTime(2023, 10, 28, 21, 11, 8, 128, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 197, DateTimeKind.Utc).AddTicks(5939), new DateTime(2023, 10, 28, 21, 11, 8, 197, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 267, DateTimeKind.Utc).AddTicks(118), new DateTime(2023, 10, 28, 21, 11, 8, 267, DateTimeKind.Utc).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 335, DateTimeKind.Utc).AddTicks(234), new DateTime(2023, 10, 28, 21, 11, 8, 335, DateTimeKind.Utc).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 404, DateTimeKind.Utc).AddTicks(5691), new DateTime(2023, 10, 28, 21, 11, 8, 404, DateTimeKind.Utc).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 473, DateTimeKind.Utc).AddTicks(6734), new DateTime(2023, 10, 28, 21, 11, 8, 473, DateTimeKind.Utc).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 542, DateTimeKind.Utc).AddTicks(3392), new DateTime(2023, 10, 28, 21, 11, 8, 542, DateTimeKind.Utc).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 611, DateTimeKind.Utc).AddTicks(9656), new DateTime(2023, 10, 28, 21, 11, 8, 611, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 680, DateTimeKind.Utc).AddTicks(6182), new DateTime(2023, 10, 28, 21, 11, 8, 680, DateTimeKind.Utc).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 748, DateTimeKind.Utc).AddTicks(5221), new DateTime(2023, 10, 28, 21, 11, 8, 748, DateTimeKind.Utc).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 53, DateTimeKind.Utc).AddTicks(542), new DateTime(2023, 10, 28, 21, 11, 4, 53, DateTimeKind.Utc).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 121, DateTimeKind.Utc).AddTicks(6602), new DateTime(2023, 10, 28, 21, 11, 4, 121, DateTimeKind.Utc).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 193, DateTimeKind.Utc).AddTicks(5079), new DateTime(2023, 10, 28, 21, 11, 4, 193, DateTimeKind.Utc).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 263, DateTimeKind.Utc).AddTicks(8466), new DateTime(2023, 10, 28, 21, 11, 4, 263, DateTimeKind.Utc).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 333, DateTimeKind.Utc).AddTicks(407), new DateTime(2023, 10, 28, 21, 11, 4, 333, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 402, DateTimeKind.Utc).AddTicks(4634), new DateTime(2023, 10, 28, 21, 11, 4, 402, DateTimeKind.Utc).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 471, DateTimeKind.Utc).AddTicks(7189), new DateTime(2023, 10, 28, 21, 11, 4, 471, DateTimeKind.Utc).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 542, DateTimeKind.Utc).AddTicks(720), new DateTime(2023, 10, 28, 21, 11, 4, 542, DateTimeKind.Utc).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 611, DateTimeKind.Utc).AddTicks(2689), new DateTime(2023, 10, 28, 21, 11, 4, 611, DateTimeKind.Utc).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 11, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 680, DateTimeKind.Utc).AddTicks(5977), new DateTime(2023, 10, 28, 21, 11, 4, 680, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 12, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 749, DateTimeKind.Utc).AddTicks(1219), new DateTime(2023, 10, 28, 21, 11, 4, 749, DateTimeKind.Utc).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 13, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 817, DateTimeKind.Utc).AddTicks(2759), new DateTime(2023, 10, 28, 21, 11, 4, 817, DateTimeKind.Utc).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 14, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 886, DateTimeKind.Utc).AddTicks(2427), new DateTime(2023, 10, 28, 21, 11, 4, 886, DateTimeKind.Utc).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 15, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 954, DateTimeKind.Utc).AddTicks(9811), new DateTime(2023, 10, 28, 21, 11, 4, 954, DateTimeKind.Utc).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 17, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 24, DateTimeKind.Utc).AddTicks(919), new DateTime(2023, 10, 28, 21, 11, 5, 24, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 18, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 92, DateTimeKind.Utc).AddTicks(6658), new DateTime(2023, 10, 28, 21, 11, 5, 92, DateTimeKind.Utc).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 19, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 161, DateTimeKind.Utc).AddTicks(5752), new DateTime(2023, 10, 28, 21, 11, 5, 161, DateTimeKind.Utc).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 20, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 230, DateTimeKind.Utc).AddTicks(4636), new DateTime(2023, 10, 28, 21, 11, 5, 230, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 3, 985, DateTimeKind.Utc).AddTicks(2954), "charlene.dibbert@email.com", "Charlene", "Dibbert", "AQAAAAIAAYagAAAAEFpqwj4HHQX+iuk8O5MmtkcEVFiVUD9hLa+q8rT7MYov902N6MNQXwD2oaO5xTTQFw==", new DateTime(2023, 10, 28, 21, 11, 3, 985, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 54, DateTimeKind.Utc).AddTicks(4371), "elinore.schneider@email.com", "Elinore", "Schneider", "AQAAAAIAAYagAAAAEGqIYl3haQn8lATqgNU5YnQXsgKYv0gFjPnWD0LWPs0SbUkSxOpUdExanWDIt5/nqQ==", new DateTime(2023, 10, 28, 21, 11, 4, 54, DateTimeKind.Utc).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 124, DateTimeKind.Utc).AddTicks(4689), "dominic.terry@email.com", "Dominic", "Terry", "AQAAAAIAAYagAAAAELUQpB1UOCRnt4gz+R9CLo2aPPQusdjQZfB3mV97yfLmDyIP7dTkCEwyou0odMaAcg==", new DateTime(2023, 10, 28, 21, 11, 4, 124, DateTimeKind.Utc).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 194, DateTimeKind.Utc).AddTicks(8943), "brent.bahringer@email.com", "Brent", "Bahringer", "AQAAAAIAAYagAAAAEHh7W4erRv/SJpiuSKTc5ChsR038QS9A+RGULErYNd4PnzSE1EbVqN72stkkif3+Fg==", new DateTime(2023, 10, 28, 21, 11, 4, 194, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 265, DateTimeKind.Utc).AddTicks(772), "brooks.bechtelar@email.com", "Brooks", "Bechtelar", "AQAAAAIAAYagAAAAEK3YByZGLKJ+NGLQjyeIHdhEOxGrO9BlmiSq3RS/IKQ8TlI9YujjiEkYhOpjK18Gww==", new DateTime(2023, 10, 28, 21, 11, 4, 265, DateTimeKind.Utc).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 334, DateTimeKind.Utc).AddTicks(4141), "ova.feil@email.com", "Ova", "Feil", "AQAAAAIAAYagAAAAENN0MnL2rr9LPmXAqBXRCLGYrjuP1gAU9mua7Akis42R9SEQIs74sDahbI9zvuiOAw==", new DateTime(2023, 10, 28, 21, 11, 4, 334, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 403, DateTimeKind.Utc).AddTicks(8708), "anabelle.boyle@email.com", "Anabelle", "Boyle", "AQAAAAIAAYagAAAAEME809sLYkAdjfAyEhboigBxKuav4HcDlyjt1NgsgzYvU3EWUomYXBJC5fuOos6NyA==", new DateTime(2023, 10, 28, 21, 11, 4, 403, DateTimeKind.Utc).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 473, DateTimeKind.Utc).AddTicks(2245), "alanis.wilkinson@email.com", "Alanis", "Wilkinson", "AQAAAAIAAYagAAAAEPwDUYlGsx+OxY8PCLejGax4q9EBTY1J8Mtma7X81Bs4TIKlujWZajscEfa/BhOfTw==", new DateTime(2023, 10, 28, 21, 11, 4, 473, DateTimeKind.Utc).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 543, DateTimeKind.Utc).AddTicks(4541), "reymundo.carter@email.com", "Reymundo", "Carter", "AQAAAAIAAYagAAAAEH/SfPsYOsROLaCwN6orCj97Ik1ACBu/AROE3QGByK1rs/xMd8hQKxOd4Ur4EioU4Q==", new DateTime(2023, 10, 28, 21, 11, 4, 543, DateTimeKind.Utc).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 612, DateTimeKind.Utc).AddTicks(6841), "marcellus.o'connell@email.com", "Marcellus", "O'Connell", "AQAAAAIAAYagAAAAEBViXcGOI+kdtnzb62NOQhvH6XujsXT3QmfN8CqILNlgJI4ycnfSRpWN37bdCLe7qA==", new DateTime(2023, 10, 28, 21, 11, 4, 612, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 681, DateTimeKind.Utc).AddTicks(9858), "theodora.braun@email.com", "Theodora", "Braun", "AQAAAAIAAYagAAAAEAvYOB1qHhWCq3KvqwC72Cb4BQZeImh3W2T+z1zVw0Ob8e/Oak5WJn5hkCA0Mc8vaw==", new DateTime(2023, 10, 28, 21, 11, 4, 681, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 750, DateTimeKind.Utc).AddTicks(4994), "danial.leannon@email.com", "Danial", "Leannon", "AQAAAAIAAYagAAAAEP4Kgg1E96Nvh0jHvBASLqjqZttNoVe0R91Y2viDCw8LNd9gqTLuD91jhsiaiNpQYg==", new DateTime(2023, 10, 28, 21, 11, 4, 750, DateTimeKind.Utc).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 818, DateTimeKind.Utc).AddTicks(8305), "amparo.hessel@email.com", "Amparo", "Hessel", "AQAAAAIAAYagAAAAEOhJP7eO1Jmrr0f9BlC6JNlf8ZTrYn6KbM9u8SW+zsze3icxvGl/JrmRoIMX4vN5xg==", new DateTime(2023, 10, 28, 21, 11, 4, 818, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 887, DateTimeKind.Utc).AddTicks(6106), "alek.ebert@email.com", "Alek", "Ebert", "AQAAAAIAAYagAAAAECDanROMP7hxChBSaKkSZ0DK9IARM86r0K/UZHVq/cuQzi9jnuPBcsFVvOf80JMqLw==", new DateTime(2023, 10, 28, 21, 11, 4, 887, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 4, 956, DateTimeKind.Utc).AddTicks(3243), "trey.paucek@email.com", "Trey", "Paucek", "AQAAAAIAAYagAAAAEKmDsl7iwh7Ek0/LOkiu4O2wP0FHDtKggNWd8gVjeSupZDK1pj7G16YgliiNWw+0Ag==", new DateTime(2023, 10, 28, 21, 11, 4, 956, DateTimeKind.Utc).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 25, DateTimeKind.Utc).AddTicks(4620), "jasen.yundt@email.com", "Jasen", "Yundt", "AQAAAAIAAYagAAAAEPxdg+fX2jv4e33wRaU26+ixJoPh6V4KHcOZZqhTyEVkah88CkOaVeTBm19UX1soRw==", new DateTime(2023, 10, 28, 21, 11, 5, 25, DateTimeKind.Utc).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 94, DateTimeKind.Utc).AddTicks(364), "shana.nienow@email.com", "Shana", "Nienow", "AQAAAAIAAYagAAAAEG0eHRboIyQe4m/3Dh5Uj2vY6QrR0fRQf708CkA0iXdip0ACG2gmVxW4ZEQRLalZ3Q==", new DateTime(2023, 10, 28, 21, 11, 5, 94, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 162, DateTimeKind.Utc).AddTicks(9158), "brant.simonis@email.com", "Brant", "Simonis", "AQAAAAIAAYagAAAAEFv20ypOy1rqQUjq8mFm3R3JH9OUnL0dMOt9PTOs1bGxfGZkipV+b8cnNAIdvKLnqg==", new DateTime(2023, 10, 28, 21, 11, 5, 162, DateTimeKind.Utc).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 231, DateTimeKind.Utc).AddTicks(8377), "anjali.hermann@email.com", "Anjali", "Hermann", "AQAAAAIAAYagAAAAECL+8BSQTxXLxJOK1vNqS4TEJcR5S/NvL/iSD1t3Zs9zw8keAkDfVnMW5e3UsSXSDg==", new DateTime(2023, 10, 28, 21, 11, 5, 231, DateTimeKind.Utc).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 300, DateTimeKind.Utc).AddTicks(6131), "evan.von@email.com", "Evan", "Von", "AQAAAAIAAYagAAAAEAYy7M6VNvNBpWruxUX0xQiTRzv/8hVRK6T3OUzh+jn7UbpFy4qbttN7fFnc8Q262g==", new DateTime(2023, 10, 28, 21, 11, 5, 300, DateTimeKind.Utc).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 369, DateTimeKind.Utc).AddTicks(4204), "akeem.lind@email.com", "Akeem", "Lind", "AQAAAAIAAYagAAAAENTnMrlsj2Lbua5ltr+2O3OGpyvZ+cF5R4m3UGe+dmUchpIUBx82smZPceUtzHIJzw==", new DateTime(2023, 10, 28, 21, 11, 5, 369, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 438, DateTimeKind.Utc).AddTicks(6371), "melody.mcglynn@email.com", "Melody", "McGlynn", "AQAAAAIAAYagAAAAEIVOzbezGtJUiH1zoWRNA7NlCp+gi7KCX4MOJZs5AZb5Uf/PWfNHpDH2Utfzs5VPyw==", new DateTime(2023, 10, 28, 21, 11, 5, 438, DateTimeKind.Utc).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 507, DateTimeKind.Utc).AddTicks(3063), "letitia.heathcote@email.com", "Letitia", "Heathcote", "AQAAAAIAAYagAAAAELMtYgdMpb9ESOBeR1eiswg822kAH3mTUrexIg+nnhGl8R68dylhOSwBOoRyNaVFDQ==", new DateTime(2023, 10, 28, 21, 11, 5, 507, DateTimeKind.Utc).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 576, DateTimeKind.Utc).AddTicks(1825), "ewald.west@email.com", "Ewald", "West", "AQAAAAIAAYagAAAAEDlFUl2KlvLS9zXaEcEvglyUBbihL+g+V1iZGrUbqM4oZSXsya8QyWUpPj6l87u5Jg==", new DateTime(2023, 10, 28, 21, 11, 5, 576, DateTimeKind.Utc).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 645, DateTimeKind.Utc).AddTicks(4846), "tremayne.kemmer@email.com", "Tremayne", "Kemmer", "AQAAAAIAAYagAAAAELudLVlXHrMRrDkX6QCzoP7qqh1SIZra5VV1EZgDto/gGJP2TcRDKAFSX+rKiYNwnQ==", new DateTime(2023, 10, 28, 21, 11, 5, 645, DateTimeKind.Utc).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 713, DateTimeKind.Utc).AddTicks(7369), "emely.sporer@email.com", "Emely", "Sporer", "AQAAAAIAAYagAAAAEO+TRCa3rJRMsPqw7Ws056YBXmjrirNvAPEuc35sQfMadp7qeCaDEIs5oGplhYRgPg==", new DateTime(2023, 10, 28, 21, 11, 5, 713, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 782, DateTimeKind.Utc).AddTicks(6101), "blaze.strosin@email.com", "Blaze", "Strosin", "AQAAAAIAAYagAAAAEKu/L4c6OGeLoNTJCapSxFud8ZdQy6zXo5YtNDUDwQPIwP9mdLejBBKuNFVbxvFAVQ==", new DateTime(2023, 10, 28, 21, 11, 5, 782, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 852, DateTimeKind.Utc).AddTicks(5073), "sydni.rau@email.com", "Sydni", "Rau", "AQAAAAIAAYagAAAAECNLWbFbTM3S2wxlkXM8N5lX7wMNXNxJkuA3SHJ3TczYAy7pOZp49W27znX2EY/dTw==", new DateTime(2023, 10, 28, 21, 11, 5, 852, DateTimeKind.Utc).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 921, DateTimeKind.Utc).AddTicks(1012), "wyatt.osinski@email.com", "Wyatt", "Osinski", "AQAAAAIAAYagAAAAEFEL375gmNLV3+ZK1clRcmPOd3zXGrGagxsQl0ZsJwijKnzIO1P8hzxGp+FVDqCoRQ==", new DateTime(2023, 10, 28, 21, 11, 5, 921, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 5, 989, DateTimeKind.Utc).AddTicks(5889), "hershel.goyette@email.com", "Hershel", "Goyette", "AQAAAAIAAYagAAAAEOcRG+HBNG6bXz1KkAuWFr53FZuzvoyUM3C7PaHexiXN9UDwbM833HmDIfWLtAUkvQ==", new DateTime(2023, 10, 28, 21, 11, 5, 989, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 58, DateTimeKind.Utc).AddTicks(2646), "pearline.feil@email.com", "Pearline", "Feil", "AQAAAAIAAYagAAAAEHuygqFBWMKphwjGroVNIhrkBPFieh16Si3sOYXQKXZxWsFPweD0hj6KH6RgZ6su0Q==", new DateTime(2023, 10, 28, 21, 11, 6, 58, DateTimeKind.Utc).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 126, DateTimeKind.Utc).AddTicks(8255), "elyse.schaefer@email.com", "Elyse", "Schaefer", "AQAAAAIAAYagAAAAEC1B3HQWF1gS8RzCwqwbtKhgXtKMbsXkCReK1FIhtqac3JDycpOsg2nwJ08Md3y/KQ==", new DateTime(2023, 10, 28, 21, 11, 6, 126, DateTimeKind.Utc).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 195, DateTimeKind.Utc).AddTicks(6242), "raleigh.bins@email.com", "Raleigh", "Bins", "AQAAAAIAAYagAAAAEKL5e0Y57iK4lCKxXDL0WTVH8y1iRe8pwiLl04BP8Mjuj5VEI2kLrlvMRSAXuuq32g==", new DateTime(2023, 10, 28, 21, 11, 6, 195, DateTimeKind.Utc).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 265, DateTimeKind.Utc).AddTicks(869), "pearlie.luettgen@email.com", "Pearlie", "Luettgen", "AQAAAAIAAYagAAAAEIEk8i8j1xbvqnW7atuTPAF8LLGWjc8gv/0FgHrsfMQVUsmcMDrgaKuV6nfxADIFcA==", new DateTime(2023, 10, 28, 21, 11, 6, 265, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 334, DateTimeKind.Utc).AddTicks(3584), "lois.olson@email.com", "Lois", "Olson", "AQAAAAIAAYagAAAAENF3wQIggmIK+HHdMuJ9ewEFzTw4CvG8gCtn6usgnSG9oPDWW0E48B03yXiOBs/n9Q==", new DateTime(2023, 10, 28, 21, 11, 6, 334, DateTimeKind.Utc).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 404, DateTimeKind.Utc).AddTicks(976), "raul.herman@email.com", "Raul", "Herman", "AQAAAAIAAYagAAAAEAAUWBXlO1ZG5VHJhgdhPzh7QMdqaWaCOIlF8QWYmoP6gyls9LWpJir1sU18+RGeog==", new DateTime(2023, 10, 28, 21, 11, 6, 404, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 473, DateTimeKind.Utc).AddTicks(1076), "giovanny.romaguera@email.com", "Giovanny", "Romaguera", "AQAAAAIAAYagAAAAEDzfUBRecBxgocdeYnUXs5qABMWpMuwNleHkDOsKtDdjILLh8QhzfkGf5PRviZPIdA==", new DateTime(2023, 10, 28, 21, 11, 6, 473, DateTimeKind.Utc).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 543, DateTimeKind.Utc).AddTicks(2608), "stephany.labadie@email.com", "Stephany", "Labadie", "AQAAAAIAAYagAAAAED94NfRsFhz4/lIkhXMxbXuJqPeQsJJ06ziMFrs8JvTCB5sjVmQyuQ+p1dZPsp6MjQ==", new DateTime(2023, 10, 28, 21, 11, 6, 543, DateTimeKind.Utc).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 612, DateTimeKind.Utc).AddTicks(7027), "jordon.kuhlman@email.com", "Jordon", "Kuhlman", "AQAAAAIAAYagAAAAEJWwrNpw7+XaQx3NrC8ohyTv4KwoYzWKkgopVaQWpgmG1fWSDhpdKilu2ow/3SHIMA==", new DateTime(2023, 10, 28, 21, 11, 6, 612, DateTimeKind.Utc).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 682, DateTimeKind.Utc).AddTicks(928), "columbus.witting@email.com", "Columbus", "Witting", "AQAAAAIAAYagAAAAENGfxnBZE+YCU8E7MwRuQZC03Uah9JwtzBbqSbo/5oh051mWvIDTfFmFBOH7rRlYAQ==", new DateTime(2023, 10, 28, 21, 11, 6, 682, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 751, DateTimeKind.Utc).AddTicks(790), "donnell.bashirian@email.com", "Donnell", "Bashirian", "AQAAAAIAAYagAAAAEM42/boludRQmcgiaUy/XJqwzDkZY9KGuS/k0NtNBz72lGz98nU7XkD8oUzhQJbhow==", new DateTime(2023, 10, 28, 21, 11, 6, 751, DateTimeKind.Utc).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 819, DateTimeKind.Utc).AddTicks(6261), "velda.bayer@email.com", "Velda", "Bayer", "AQAAAAIAAYagAAAAEOrCIs/3MrDeJf8gX23XzvpAWStKVDGV8FtTegqGIfuSbP2XiAlwludW8KmR2GY06w==", new DateTime(2023, 10, 28, 21, 11, 6, 819, DateTimeKind.Utc).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 888, DateTimeKind.Utc).AddTicks(6150), "eleazar.white@email.com", "Eleazar", "White", "AQAAAAIAAYagAAAAEDXdgj7eFznQNXl2+mVyfdpcPVf5mY57fPAnlKBzr9wE1CJTwO2VLi4lRZUc75ZTvA==", new DateTime(2023, 10, 28, 21, 11, 6, 888, DateTimeKind.Utc).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 6, 957, DateTimeKind.Utc).AddTicks(3182), "catherine.greenholt@email.com", "Catherine", "Greenholt", "AQAAAAIAAYagAAAAEAtwl8hJLdTWbCdT+0HqJgK/GFuZ36lCjw5SxMO3IZylG+7Ge34kQbAYQ1F7ImQY9A==", new DateTime(2023, 10, 28, 21, 11, 6, 957, DateTimeKind.Utc).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 26, DateTimeKind.Utc).AddTicks(705), "burnice.wunsch@email.com", "Burnice", "Wunsch", "AQAAAAIAAYagAAAAEH4PuJA0rv+xKbqW2p3stur42udAyxFTG9tlVDymRDrpt3nSazNu2X7Q7QQzlvjBqw==", new DateTime(2023, 10, 28, 21, 11, 7, 26, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 94, DateTimeKind.Utc).AddTicks(8624), "elmore.stamm@email.com", "Elmore", "Stamm", "AQAAAAIAAYagAAAAEF+u3qv+/l+8wNoXQL0O7aAAEyLr3X3wF6341XMnCiM7M3IduLM952TqnxFyngOCTA==", new DateTime(2023, 10, 28, 21, 11, 7, 94, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 163, DateTimeKind.Utc).AddTicks(6052), "glennie.bins@email.com", "Glennie", "Bins", "AQAAAAIAAYagAAAAEOIJK/hYJvzCYBO28q27X+OTUOW5Di2Xi1T56cdhagMNt+0GlvRbEuIbKngsLszl2Q==", new DateTime(2023, 10, 28, 21, 11, 7, 163, DateTimeKind.Utc).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 232, DateTimeKind.Utc).AddTicks(5325), "desmond.schulist@email.com", "Desmond", "Schulist", "AQAAAAIAAYagAAAAEJ0qEzBgV7wnMxTgAlfD3bV/h7WssjuPgMgRDjHQRY/x2OV39wbVStl1m0gAtmUsJg==", new DateTime(2023, 10, 28, 21, 11, 7, 232, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 302, DateTimeKind.Utc).AddTicks(9635), "garrison.quitzon@email.com", "Garrison", "Quitzon", "AQAAAAIAAYagAAAAEBqgvAul8cxMSTITOHYuOjwWQPKECA3oYArfDOdePNPIRjyvOzXidJbrk5/pcIalnw==", new DateTime(2023, 10, 28, 21, 11, 7, 302, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 371, DateTimeKind.Utc).AddTicks(7060), "rosalia.turner@email.com", "Rosalia", "Turner", "AQAAAAIAAYagAAAAEK317SxekVaHboKaySAp6qKt9+1KXeIXDGESPMvrQmzSfqTTshGXbP0pU8qg2KDdwg==", new DateTime(2023, 10, 28, 21, 11, 7, 371, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 51,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 440, DateTimeKind.Utc).AddTicks(9365), "margarett.anderson@email.com", "Margarett", "Anderson", "AQAAAAIAAYagAAAAED6/Md9TNQh0gvgTl64e6yCyA6lmeLrw14KxoIYuCeB1zL0g8TsHmYwda8wDX7cW5A==", new DateTime(2023, 10, 28, 21, 11, 7, 440, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 52,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 510, DateTimeKind.Utc).AddTicks(3942), "lavina.mclaughlin@email.com", "Lavina", "McLaughlin", "AQAAAAIAAYagAAAAEGdNBvD8b8OsHVozc9djx2v68wR/ozXozA912ntmQa8jMYHz9j/xH5n7TbkJRNoahA==", new DateTime(2023, 10, 28, 21, 11, 7, 510, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 53,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 579, DateTimeKind.Utc).AddTicks(5110), "zachery.klocko@email.com", "Zachery", "Klocko", "AQAAAAIAAYagAAAAEG/q5Yda4OAR22x8sZRhNgOoOM6f4TSjPXdD+dt2OCCbIT3ERAvJnQWGRgajE8aoPA==", new DateTime(2023, 10, 28, 21, 11, 7, 579, DateTimeKind.Utc).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 648, DateTimeKind.Utc).AddTicks(1170), "clovis.fay@email.com", "Clovis", "Fay", "AQAAAAIAAYagAAAAEHltWAcm//bO8qeTpcyfwmIqXkGUgd7pOln1wyXumUpR0a3REYiyHZ5IJ8pprT61Gw==", new DateTime(2023, 10, 28, 21, 11, 7, 648, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 716, DateTimeKind.Utc).AddTicks(9430), "alayna.bailey@email.com", "Alayna", "Bailey", "AQAAAAIAAYagAAAAEE11rBjH2uo6tUpKjoG5rXvWOq11wSerDeLLmXNUYuVA6g4k1Y/lJjqBCaBE9TZLFw==", new DateTime(2023, 10, 28, 21, 11, 7, 716, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 785, DateTimeKind.Utc).AddTicks(9241), "jacynthe.gutmann@email.com", "Jacynthe", "Gutmann", "AQAAAAIAAYagAAAAEGGXY4MhGGeOKlEBh0aDpdWnA91tDY7H1qa+oxiCpH9w4NQ3vgBXAhXwi0D+edPaFg==", new DateTime(2023, 10, 28, 21, 11, 7, 785, DateTimeKind.Utc).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 57,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 855, DateTimeKind.Utc).AddTicks(4213), "bulah.maggio@email.com", "Bulah", "Maggio", "AQAAAAIAAYagAAAAEI5Phry8fxNQEpVhdBjx5xM4z2GQ0Uv/dNx8D1yDy08AkJIXySw+SWCw7rCE9iZLgQ==", new DateTime(2023, 10, 28, 21, 11, 7, 855, DateTimeKind.Utc).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 924, DateTimeKind.Utc).AddTicks(370), "delilah.mayert@email.com", "Delilah", "Mayert", "AQAAAAIAAYagAAAAEH+cx+oHKTAZdo3ZdgfP8MqZP0Hxgh6tiQT51UCmuHynyHzuKmXnZJ1NZG1cY9foIQ==", new DateTime(2023, 10, 28, 21, 11, 7, 924, DateTimeKind.Utc).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 7, 992, DateTimeKind.Utc).AddTicks(5774), "maddison.keebler@email.com", "Maddison", "Keebler", "AQAAAAIAAYagAAAAEDa6Zer9uIh1vAUABvAUh4FM+LvxX6e/HlWxAnFYMFI4RRqv8lFRfV+EOb0xExSxHg==", new DateTime(2023, 10, 28, 21, 11, 7, 992, DateTimeKind.Utc).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 60,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 61, DateTimeKind.Utc).AddTicks(6015), "zack.friesen@email.com", "Zack", "Friesen", "AQAAAAIAAYagAAAAEBW6CuLY+KJ8X/VTUxOWb6YRPUyfqVngZSSoggIm6Z19OTssjygUh1FtMqKZ78yF/A==", new DateTime(2023, 10, 28, 21, 11, 8, 61, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 61,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 130, DateTimeKind.Utc).AddTicks(2969), "sammie.quitzon@email.com", "Sammie", "Quitzon", "AQAAAAIAAYagAAAAEOaY8a3jXUWY3t9mHbdmcItl0kINUQnFoTx3WubvT+qpVcT7qbBlB+byKr/jzGrR6w==", new DateTime(2023, 10, 28, 21, 11, 8, 130, DateTimeKind.Utc).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 62,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 198, DateTimeKind.Utc).AddTicks(9620), "reymundo.gusikowski@email.com", "Reymundo", "Gusikowski", "AQAAAAIAAYagAAAAEI3rhwCFJuO9iZ96X6fJzMEHFOXQ7xLMShStYJwdTxTOldydw3+RmgtQbCrQy0YrNw==", new DateTime(2023, 10, 28, 21, 11, 8, 198, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 63,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 268, DateTimeKind.Utc).AddTicks(3442), "hilton.torphy@email.com", "Hilton", "Torphy", "AQAAAAIAAYagAAAAEMVH6c3nUFBv4SI3RFpxZnco/c2mEU+4uTvOFKwu4EfLJJfqi1Yu8sFPW3N0NpsjXg==", new DateTime(2023, 10, 28, 21, 11, 8, 268, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 64,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 336, DateTimeKind.Utc).AddTicks(3512), "christiana.hintz@email.com", "Christiana", "Hintz", "AQAAAAIAAYagAAAAEKXJQKcZtw4VYXm9aRrtZGUVkMstQnLKWFuhId0JRuxZ5awMS4+zurQIHnFIU6nf0g==", new DateTime(2023, 10, 28, 21, 11, 8, 336, DateTimeKind.Utc).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 65,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 405, DateTimeKind.Utc).AddTicks(9730), "malvina.gusikowski@email.com", "Malvina", "Gusikowski", "AQAAAAIAAYagAAAAENz4RNW5Jx4FO7k707B/nyli29cMFsT1eizpXlJCBGm/CK6In4ezB0dlH0+WqzM5bw==", new DateTime(2023, 10, 28, 21, 11, 8, 405, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 66,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 475, DateTimeKind.Utc).AddTicks(414), "robbie.bosco@email.com", "Robbie", "Bosco", "AQAAAAIAAYagAAAAEDOsRLM7d7c4ulXFLgY2PLV3b7tZUsxVWGHRg/6SXrJVnseK5PS5LfwYP4+uBGueIQ==", new DateTime(2023, 10, 28, 21, 11, 8, 475, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 67,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 544, DateTimeKind.Utc).AddTicks(40), "alessia.rutherford@email.com", "Alessia", "Rutherford", "AQAAAAIAAYagAAAAEDaPkCCzv48tDM1/oa3rX2fFnd4AKyu//PoXiYvX+L83nxmWLBctq0Vv3YSMcXvUAw==", new DateTime(2023, 10, 28, 21, 11, 8, 544, DateTimeKind.Utc).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 68,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 613, DateTimeKind.Utc).AddTicks(3020), "ashley.schmeler@email.com", "Ashley", "Schmeler", "AQAAAAIAAYagAAAAEI7aaKHNPA7A56pIc0XoSu18yOLMO6boQzYJ4SyThU573D3mxQ4K6Jff2IlVJDMxuw==", new DateTime(2023, 10, 28, 21, 11, 8, 613, DateTimeKind.Utc).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 69,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 21, 11, 8, 680, DateTimeKind.Utc).AddTicks(6335), "AQAAAAIAAYagAAAAEBqKF58SSQ5fDmlr1KRK5XXLqCIUNndEdGA6uE89fLul2Poi3/lCiZe2QWxf1s65EQ==", new DateTime(2023, 10, 28, 21, 11, 8, 680, DateTimeKind.Utc).AddTicks(6335) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Instruments");

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4535), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4715), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4732), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4758), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4784), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4803), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4824), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4941), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4963), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5000), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5017), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5030), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5047), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5058), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5077), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5106), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5119), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5133), new DateTime(2023, 10, 28, 16, 2, 3, 691, DateTimeKind.Utc).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 760, DateTimeKind.Utc).AddTicks(3033), new DateTime(2023, 10, 28, 16, 2, 3, 760, DateTimeKind.Utc).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 830, DateTimeKind.Utc).AddTicks(4395), new DateTime(2023, 10, 28, 16, 2, 3, 830, DateTimeKind.Utc).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 900, DateTimeKind.Utc).AddTicks(7899), new DateTime(2023, 10, 28, 16, 2, 3, 900, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 971, DateTimeKind.Utc).AddTicks(5454), new DateTime(2023, 10, 28, 16, 2, 3, 971, DateTimeKind.Utc).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 42, DateTimeKind.Utc).AddTicks(5141), new DateTime(2023, 10, 28, 16, 2, 4, 42, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 113, DateTimeKind.Utc).AddTicks(3823), new DateTime(2023, 10, 28, 16, 2, 4, 113, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 183, DateTimeKind.Utc).AddTicks(2447), new DateTime(2023, 10, 28, 16, 2, 4, 183, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 253, DateTimeKind.Utc).AddTicks(3690), new DateTime(2023, 10, 28, 16, 2, 4, 253, DateTimeKind.Utc).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 323, DateTimeKind.Utc).AddTicks(7651), new DateTime(2023, 10, 28, 16, 2, 4, 323, DateTimeKind.Utc).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 394, DateTimeKind.Utc).AddTicks(7556), new DateTime(2023, 10, 28, 16, 2, 4, 394, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 465, DateTimeKind.Utc).AddTicks(4695), new DateTime(2023, 10, 28, 16, 2, 4, 465, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 534, DateTimeKind.Utc).AddTicks(7738), new DateTime(2023, 10, 28, 16, 2, 4, 534, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 604, DateTimeKind.Utc).AddTicks(5582), new DateTime(2023, 10, 28, 16, 2, 4, 604, DateTimeKind.Utc).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 674, DateTimeKind.Utc).AddTicks(2155), new DateTime(2023, 10, 28, 16, 2, 4, 674, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 744, DateTimeKind.Utc).AddTicks(4105), new DateTime(2023, 10, 28, 16, 2, 4, 744, DateTimeKind.Utc).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 814, DateTimeKind.Utc).AddTicks(8637), new DateTime(2023, 10, 28, 16, 2, 4, 814, DateTimeKind.Utc).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 887, DateTimeKind.Utc).AddTicks(2151), new DateTime(2023, 10, 28, 16, 2, 4, 887, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 956, DateTimeKind.Utc).AddTicks(9744), new DateTime(2023, 10, 28, 16, 2, 4, 956, DateTimeKind.Utc).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 28, DateTimeKind.Utc).AddTicks(2261), new DateTime(2023, 10, 28, 16, 2, 5, 28, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 96, DateTimeKind.Utc).AddTicks(4893), new DateTime(2023, 10, 28, 16, 2, 5, 96, DateTimeKind.Utc).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 167, DateTimeKind.Utc).AddTicks(3133), new DateTime(2023, 10, 28, 16, 2, 5, 167, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 236, DateTimeKind.Utc).AddTicks(5136), new DateTime(2023, 10, 28, 16, 2, 5, 236, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 306, DateTimeKind.Utc).AddTicks(4498), new DateTime(2023, 10, 28, 16, 2, 5, 306, DateTimeKind.Utc).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 375, DateTimeKind.Utc).AddTicks(9109), new DateTime(2023, 10, 28, 16, 2, 5, 375, DateTimeKind.Utc).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 445, DateTimeKind.Utc).AddTicks(5399), new DateTime(2023, 10, 28, 16, 2, 5, 445, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 514, DateTimeKind.Utc).AddTicks(2769), new DateTime(2023, 10, 28, 16, 2, 5, 514, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 584, DateTimeKind.Utc).AddTicks(5232), new DateTime(2023, 10, 28, 16, 2, 5, 584, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 654, DateTimeKind.Utc).AddTicks(5382), new DateTime(2023, 10, 28, 16, 2, 5, 654, DateTimeKind.Utc).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 724, DateTimeKind.Utc).AddTicks(3166), new DateTime(2023, 10, 28, 16, 2, 5, 724, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 793, DateTimeKind.Utc).AddTicks(1707), new DateTime(2023, 10, 28, 16, 2, 5, 793, DateTimeKind.Utc).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 863, DateTimeKind.Utc).AddTicks(2409), new DateTime(2023, 10, 28, 16, 2, 5, 863, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 933, DateTimeKind.Utc).AddTicks(3727), new DateTime(2023, 10, 28, 16, 2, 5, 933, DateTimeKind.Utc).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 3, DateTimeKind.Utc).AddTicks(6662), new DateTime(2023, 10, 28, 16, 2, 6, 3, DateTimeKind.Utc).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 73, DateTimeKind.Utc).AddTicks(7096), new DateTime(2023, 10, 28, 16, 2, 6, 73, DateTimeKind.Utc).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 143, DateTimeKind.Utc).AddTicks(6724), new DateTime(2023, 10, 28, 16, 2, 6, 143, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 213, DateTimeKind.Utc).AddTicks(2931), new DateTime(2023, 10, 28, 16, 2, 6, 213, DateTimeKind.Utc).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 282, DateTimeKind.Utc).AddTicks(8362), new DateTime(2023, 10, 28, 16, 2, 6, 282, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 352, DateTimeKind.Utc).AddTicks(8585), new DateTime(2023, 10, 28, 16, 2, 6, 352, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 422, DateTimeKind.Utc).AddTicks(725), new DateTime(2023, 10, 28, 16, 2, 6, 422, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 491, DateTimeKind.Utc).AddTicks(4459), new DateTime(2023, 10, 28, 16, 2, 6, 491, DateTimeKind.Utc).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 561, DateTimeKind.Utc).AddTicks(6126), new DateTime(2023, 10, 28, 16, 2, 6, 561, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 631, DateTimeKind.Utc).AddTicks(2929), new DateTime(2023, 10, 28, 16, 2, 6, 631, DateTimeKind.Utc).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 701, DateTimeKind.Utc).AddTicks(2871), new DateTime(2023, 10, 28, 16, 2, 6, 701, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 770, DateTimeKind.Utc).AddTicks(6163), new DateTime(2023, 10, 28, 16, 2, 6, 770, DateTimeKind.Utc).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 840, DateTimeKind.Utc).AddTicks(7209), new DateTime(2023, 10, 28, 16, 2, 6, 840, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 910, DateTimeKind.Utc).AddTicks(5750), new DateTime(2023, 10, 28, 16, 2, 6, 910, DateTimeKind.Utc).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 980, DateTimeKind.Utc).AddTicks(8674), new DateTime(2023, 10, 28, 16, 2, 6, 980, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 49, DateTimeKind.Utc).AddTicks(5431), new DateTime(2023, 10, 28, 16, 2, 7, 49, DateTimeKind.Utc).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 118, DateTimeKind.Utc).AddTicks(6514), new DateTime(2023, 10, 28, 16, 2, 7, 118, DateTimeKind.Utc).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 188, DateTimeKind.Utc).AddTicks(9934), new DateTime(2023, 10, 28, 16, 2, 7, 188, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 258, DateTimeKind.Utc).AddTicks(5451), new DateTime(2023, 10, 28, 16, 2, 7, 258, DateTimeKind.Utc).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 329, DateTimeKind.Utc).AddTicks(136), new DateTime(2023, 10, 28, 16, 2, 7, 329, DateTimeKind.Utc).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 398, DateTimeKind.Utc).AddTicks(2549), new DateTime(2023, 10, 28, 16, 2, 7, 398, DateTimeKind.Utc).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 469, DateTimeKind.Utc).AddTicks(7253), new DateTime(2023, 10, 28, 16, 2, 7, 469, DateTimeKind.Utc).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 542, DateTimeKind.Utc).AddTicks(4107), new DateTime(2023, 10, 28, 16, 2, 7, 542, DateTimeKind.Utc).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 611, DateTimeKind.Utc).AddTicks(3399), new DateTime(2023, 10, 28, 16, 2, 7, 611, DateTimeKind.Utc).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 681, DateTimeKind.Utc).AddTicks(4682), new DateTime(2023, 10, 28, 16, 2, 7, 681, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 750, DateTimeKind.Utc).AddTicks(6021), new DateTime(2023, 10, 28, 16, 2, 7, 750, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 823, DateTimeKind.Utc).AddTicks(7275), new DateTime(2023, 10, 28, 16, 2, 7, 823, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 896, DateTimeKind.Utc).AddTicks(572), new DateTime(2023, 10, 28, 16, 2, 7, 896, DateTimeKind.Utc).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 970, DateTimeKind.Utc).AddTicks(3734), new DateTime(2023, 10, 28, 16, 2, 7, 970, DateTimeKind.Utc).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 42, DateTimeKind.Utc).AddTicks(7061), new DateTime(2023, 10, 28, 16, 2, 8, 42, DateTimeKind.Utc).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 111, DateTimeKind.Utc).AddTicks(8059), new DateTime(2023, 10, 28, 16, 2, 8, 111, DateTimeKind.Utc).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 182, DateTimeKind.Utc).AddTicks(8542), new DateTime(2023, 10, 28, 16, 2, 8, 182, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 258, DateTimeKind.Utc).AddTicks(3621), new DateTime(2023, 10, 28, 16, 2, 8, 258, DateTimeKind.Utc).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 332, DateTimeKind.Utc).AddTicks(9388), new DateTime(2023, 10, 28, 16, 2, 8, 332, DateTimeKind.Utc).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 410, DateTimeKind.Utc).AddTicks(3455), new DateTime(2023, 10, 28, 16, 2, 8, 410, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 483, DateTimeKind.Utc).AddTicks(6227), new DateTime(2023, 10, 28, 16, 2, 8, 483, DateTimeKind.Utc).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 553, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 10, 28, 16, 2, 8, 553, DateTimeKind.Utc).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 760, DateTimeKind.Utc).AddTicks(3048), new DateTime(2023, 10, 28, 16, 2, 3, 760, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 830, DateTimeKind.Utc).AddTicks(4409), new DateTime(2023, 10, 28, 16, 2, 3, 830, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 900, DateTimeKind.Utc).AddTicks(7911), new DateTime(2023, 10, 28, 16, 2, 3, 900, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 971, DateTimeKind.Utc).AddTicks(5469), new DateTime(2023, 10, 28, 16, 2, 3, 971, DateTimeKind.Utc).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 42, DateTimeKind.Utc).AddTicks(5156), new DateTime(2023, 10, 28, 16, 2, 4, 42, DateTimeKind.Utc).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 113, DateTimeKind.Utc).AddTicks(3838), new DateTime(2023, 10, 28, 16, 2, 4, 113, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 183, DateTimeKind.Utc).AddTicks(2456), new DateTime(2023, 10, 28, 16, 2, 4, 183, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 253, DateTimeKind.Utc).AddTicks(3703), new DateTime(2023, 10, 28, 16, 2, 4, 253, DateTimeKind.Utc).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 323, DateTimeKind.Utc).AddTicks(7664), new DateTime(2023, 10, 28, 16, 2, 4, 323, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 11, 10 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 394, DateTimeKind.Utc).AddTicks(7573), new DateTime(2023, 10, 28, 16, 2, 4, 394, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 12, 11 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 465, DateTimeKind.Utc).AddTicks(4710), new DateTime(2023, 10, 28, 16, 2, 4, 465, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 13, 12 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 534, DateTimeKind.Utc).AddTicks(7751), new DateTime(2023, 10, 28, 16, 2, 4, 534, DateTimeKind.Utc).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 14, 13 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 604, DateTimeKind.Utc).AddTicks(5597), new DateTime(2023, 10, 28, 16, 2, 4, 604, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 15, 14 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 674, DateTimeKind.Utc).AddTicks(2167), new DateTime(2023, 10, 28, 16, 2, 4, 674, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 17, 15 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 744, DateTimeKind.Utc).AddTicks(4117), new DateTime(2023, 10, 28, 16, 2, 4, 744, DateTimeKind.Utc).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 18, 16 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 814, DateTimeKind.Utc).AddTicks(8653), new DateTime(2023, 10, 28, 16, 2, 4, 814, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 19, 17 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 887, DateTimeKind.Utc).AddTicks(2164), new DateTime(2023, 10, 28, 16, 2, 4, 887, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "UserInstruments",
                keyColumns: new[] { "InstrumentId", "UserId" },
                keyValues: new object[] { 20, 18 },
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 956, DateTimeKind.Utc).AddTicks(9759), new DateTime(2023, 10, 28, 16, 2, 4, 956, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 692, DateTimeKind.Utc).AddTicks(7790), "brittany.hyatt@email.com", "Brittany", "Hyatt", "AQAAAAIAAYagAAAAEP6Ew4Jhp2f5hW7GF1Vpgt7yIPO2Ge3VUtVwrJ3Oc2sRpE2kW0xYhoPakLcgZ5+JCw==", new DateTime(2023, 10, 28, 16, 2, 3, 692, DateTimeKind.Utc).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 761, DateTimeKind.Utc).AddTicks(6498), "lavon.kunze@email.com", "Lavon", "Kunze", "AQAAAAIAAYagAAAAEKhwG7ipvO5xjdEcTUdaY2lp5EC32Q6Zf8krJ5FtoZF0YhHOac/bqB4B4I1bkntHUg==", new DateTime(2023, 10, 28, 16, 2, 3, 761, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 831, DateTimeKind.Utc).AddTicks(7911), "mose.walker@email.com", "Mose", "Walker", "AQAAAAIAAYagAAAAEORhgvKGoaeu5pHQAIBMmbASKJDHARx4dr3PdND3KbT+O+VyooS31S2Enf51p1hljQ==", new DateTime(2023, 10, 28, 16, 2, 3, 831, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 902, DateTimeKind.Utc).AddTicks(2114), "colton.dietrich@email.com", "Colton", "Dietrich", "AQAAAAIAAYagAAAAEIMGpyNEYKHZj5Chkm4wkmYbSQxdVSlolBhIhqWfYKK/3NQY7F3u6a37XN5gVBBcFA==", new DateTime(2023, 10, 28, 16, 2, 3, 902, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 3, 973, DateTimeKind.Utc).AddTicks(1689), "rex.hagenes@email.com", "Rex", "Hagenes", "AQAAAAIAAYagAAAAEEkSoR4ZslmjVz+qj6kn3iAiuPV5VM1lLdQNVqY4pAfNFpasi20Cg2JOiO+s+qWY3Q==", new DateTime(2023, 10, 28, 16, 2, 3, 973, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 43, DateTimeKind.Utc).AddTicks(9052), "bruce.schneider@email.com", "Bruce", "Schneider", "AQAAAAIAAYagAAAAEJdOP+9Bi9PpAj9XJSPkCTTuDU3wJwriKpG3rzNYL2jIF1ZWgOMBfoJ3ZZqiRmgEhw==", new DateTime(2023, 10, 28, 16, 2, 4, 43, DateTimeKind.Utc).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 114, DateTimeKind.Utc).AddTicks(6834), "allen.hoppe@email.com", "Allen", "Hoppe", "AQAAAAIAAYagAAAAEI0GjZqHVIIn/amzSCwiM3Zt4xkqCj7Di3igx/WwZNfruA21UstAD2rBsOTdJ1I7+w==", new DateTime(2023, 10, 28, 16, 2, 4, 114, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 184, DateTimeKind.Utc).AddTicks(6515), "ludwig.yost@email.com", "Ludwig", "Yost", "AQAAAAIAAYagAAAAEDMOpp9b+TI1WxOUjWPt0Ltxcbb/CEw8E1AmahrIA2w32cOUS2I5KDQqIkvxTcKF1g==", new DateTime(2023, 10, 28, 16, 2, 4, 184, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 254, DateTimeKind.Utc).AddTicks(7522), "hassie.armstrong@email.com", "Hassie", "Armstrong", "AQAAAAIAAYagAAAAEEfMJiLEdy/Fw0KChGl2IDTWY7OzdJv8GSAEGxvX7UxLLQWhbZXPXGoaJU6Z9aKSbw==", new DateTime(2023, 10, 28, 16, 2, 4, 254, DateTimeKind.Utc).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 325, DateTimeKind.Utc).AddTicks(1916), "alvis.lakin@email.com", "Alvis", "Lakin", "AQAAAAIAAYagAAAAEDohmh5v01Jhn7hRmfuk/8Ug/twkQe5GfVAtlpz0VnrH+tDYjeaAZcX2I+OA1MsX2g==", new DateTime(2023, 10, 28, 16, 2, 4, 325, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 396, DateTimeKind.Utc).AddTicks(5764), "addie.effertz@email.com", "Addie", "Effertz", "AQAAAAIAAYagAAAAEBZKFUN2bgm0UWeizStvRAmhc8MD+ySu90+9csTM6jnrvi1e7hbdmo2+wQw9RlrnPQ==", new DateTime(2023, 10, 28, 16, 2, 4, 396, DateTimeKind.Utc).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 466, DateTimeKind.Utc).AddTicks(8670), "vincenza.rosenbaum@email.com", "Vincenza", "Rosenbaum", "AQAAAAIAAYagAAAAELsa7osBWC/kOUcn/yWhC0hV8Li4VMTnvjimzkY2tO4k17Kv5lK7F5tCPuHmkH/qbA==", new DateTime(2023, 10, 28, 16, 2, 4, 466, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 536, DateTimeKind.Utc).AddTicks(1330), "zackary.doyle@email.com", "Zackary", "Doyle", "AQAAAAIAAYagAAAAEBdnuRwhvtETqe+wUBE2qs7ZguTAl8a5gQXuG6ytLhS78ITu4zjuntKEju+X94XoxQ==", new DateTime(2023, 10, 28, 16, 2, 4, 536, DateTimeKind.Utc).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 605, DateTimeKind.Utc).AddTicks(9506), "modesta.schroeder@email.com", "Modesta", "Schroeder", "AQAAAAIAAYagAAAAEPq6q0jfFyptUtVNu6wk3kGJxl1gXnFhmBYQK/01BMCCLw4XYHESxy1aAWud/xHW5g==", new DateTime(2023, 10, 28, 16, 2, 4, 605, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 675, DateTimeKind.Utc).AddTicks(5529), "amira.jacobi@email.com", "Amira", "Jacobi", "AQAAAAIAAYagAAAAEKtDBf2O53fMQajBmytzwn4cXoBJuIGVKPE2bAhy+P+3TBYbNCTtpEYVI+KH8mbUgw==", new DateTime(2023, 10, 28, 16, 2, 4, 675, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 745, DateTimeKind.Utc).AddTicks(7772), "henry.jenkins@email.com", "Henry", "Jenkins", "AQAAAAIAAYagAAAAEDeEvszz1lgikeXzyybs8WcqTWbBQ4hCtXdiAE3l3LtNovp0YXZtG6pUlKgeal2mQw==", new DateTime(2023, 10, 28, 16, 2, 4, 745, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 816, DateTimeKind.Utc).AddTicks(2051), "trenton.metz@email.com", "Trenton", "Metz", "AQAAAAIAAYagAAAAEMOw4kfLsIhnQq1SLz8enRfvg2rqXyEYgFsKFZOvnTjkUVDThcU4jHod9LtuKaJTcw==", new DateTime(2023, 10, 28, 16, 2, 4, 816, DateTimeKind.Utc).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 888, DateTimeKind.Utc).AddTicks(6507), "jed.gleichner@email.com", "Jed", "Gleichner", "AQAAAAIAAYagAAAAEDjiZwJci/ilHjAzXc8F9DNle928wtaGTCcF2N3rzeTVKJd6+tMpU4IRZE4dLFTTrQ==", new DateTime(2023, 10, 28, 16, 2, 4, 888, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 4, 958, DateTimeKind.Utc).AddTicks(9643), "eli.thompson@email.com", "Eli", "Thompson", "AQAAAAIAAYagAAAAEH0+CiRce0AxcXB8/ZLqjmNwMKc6flFEAdnsZG/RDJsmIyIw/Nvxy0EZYyGO2ZPWwA==", new DateTime(2023, 10, 28, 16, 2, 4, 958, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 29, DateTimeKind.Utc).AddTicks(5622), "luz.runte@email.com", "Luz", "Runte", "AQAAAAIAAYagAAAAEN7Y1zJoFUQoDu9W91x3x5z1qrZvfSwytZNO9u665pBV7wchP185soUw7iMThhkR9A==", new DateTime(2023, 10, 28, 16, 2, 5, 29, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 98, DateTimeKind.Utc).AddTicks(1812), "margaretta.stracke@email.com", "Margaretta", "Stracke", "AQAAAAIAAYagAAAAEAhFTHJcQEPwIyarPa7z1XI6gCDbgzJljE5Uuf2E36YACBFYZY3GL76ZjyXI53yPeQ==", new DateTime(2023, 10, 28, 16, 2, 5, 98, DateTimeKind.Utc).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 168, DateTimeKind.Utc).AddTicks(6102), "marilou.reilly@email.com", "Marilou", "Reilly", "AQAAAAIAAYagAAAAEGqFNkWkJYYAvztoNTwpMi2d9Kc3aAtvPysBsFkd7+JJIkYg19VkLOlgserd4uQyMw==", new DateTime(2023, 10, 28, 16, 2, 5, 168, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 237, DateTimeKind.Utc).AddTicks(9013), "sofia.crona@email.com", "Sofia", "Crona", "AQAAAAIAAYagAAAAEDkQQZadXuqueq0zWlQk+bPIDxVUSsD5v6yS3kakqDayiM5L3l3IIT5qY9ROjaBLhw==", new DateTime(2023, 10, 28, 16, 2, 5, 237, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 307, DateTimeKind.Utc).AddTicks(8334), "connie.jacobi@email.com", "Connie", "Jacobi", "AQAAAAIAAYagAAAAED9Cbl/ZsuzfDrt55KKKM5RNNwlMJZNQGcBz70eMKQxRdUNZ1BUkqrhlCaCx0uvXpA==", new DateTime(2023, 10, 28, 16, 2, 5, 307, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 377, DateTimeKind.Utc).AddTicks(3855), "alexane.dach@email.com", "Alexane", "Dach", "AQAAAAIAAYagAAAAEEhyzn/taQOGZj1gO7UigMnfVl5/75DbDjAOIvffeMukGSN2sjYig9mE+3w4GHO+8A==", new DateTime(2023, 10, 28, 16, 2, 5, 377, DateTimeKind.Utc).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 446, DateTimeKind.Utc).AddTicks(8975), "hope.ferry@email.com", "Hope", "Ferry", "AQAAAAIAAYagAAAAEC1us6dWKopCsUD+UIfsA3rGdQi8j1/O6D5LIS5/c9PoVnrDc294JGWsPfMX9/BTlw==", new DateTime(2023, 10, 28, 16, 2, 5, 446, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 515, DateTimeKind.Utc).AddTicks(6838), "demond.orn@email.com", "Demond", "Orn", "AQAAAAIAAYagAAAAEApfPfi1z1iyJCclAyzqZmzA/suy4szn4s5VzlKwU7zm1jPxtf/G7ym1bvfd6de5og==", new DateTime(2023, 10, 28, 16, 2, 5, 515, DateTimeKind.Utc).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 585, DateTimeKind.Utc).AddTicks(8254), "jamaal.metz@email.com", "Jamaal", "Metz", "AQAAAAIAAYagAAAAEA/KBhVR0cVDMEkXBavaar9FjCTLKNB1f/f6tpTT0fNpCcietuKcbFkltz9LIgg3Wg==", new DateTime(2023, 10, 28, 16, 2, 5, 585, DateTimeKind.Utc).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 655, DateTimeKind.Utc).AddTicks(8781), "nels.dickinson@email.com", "Nels", "Dickinson", "AQAAAAIAAYagAAAAELmWOLhQ3LBOVZKewk8XRwDZbejBcoQFgo7aEpB5f15s0FQ4NPcF9SlEwz+RtvaoGA==", new DateTime(2023, 10, 28, 16, 2, 5, 655, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 725, DateTimeKind.Utc).AddTicks(6645), "terry.macgyver@email.com", "Terry", "MacGyver", "AQAAAAIAAYagAAAAEK3b576qP801iHkMcbtReZtj00IewN3YtBC4Jm1HJljXOmXmPcjK0Z/CxluDryjljw==", new DateTime(2023, 10, 28, 16, 2, 5, 725, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 794, DateTimeKind.Utc).AddTicks(5799), "reuben.price@email.com", "Reuben", "Price", "AQAAAAIAAYagAAAAEHEmsEc91Qda6+5eXAgTljW/YKh7J/FYT9qpgOy2k8UAnMw9WB7qOZU8ezpHRtdhiA==", new DateTime(2023, 10, 28, 16, 2, 5, 794, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 864, DateTimeKind.Utc).AddTicks(5969), "jolie.strosin@email.com", "Jolie", "Strosin", "AQAAAAIAAYagAAAAEPCNRBTBK7jAQ3nqFnM7YAk59iyW9PXMDhHzwMmFoiF0U+96bnmGNoqdJPwtUTj1Ew==", new DateTime(2023, 10, 28, 16, 2, 5, 864, DateTimeKind.Utc).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 5, 934, DateTimeKind.Utc).AddTicks(6879), "keshaun.hackett@email.com", "Keshaun", "Hackett", "AQAAAAIAAYagAAAAEJoBbncN8vCEJqRrWxHbSfCTovi2Kc7eOXhReB38LuJ/WgcQoJ0bYo2HqI8stf7hgg==", new DateTime(2023, 10, 28, 16, 2, 5, 934, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 5, DateTimeKind.Utc).AddTicks(179), "gus.romaguera@email.com", "Gus", "Romaguera", "AQAAAAIAAYagAAAAEF93Cg9nl3Pp0zPdVhbh/sdODjErlehFrjGAOgDdqocShm2bBA04vLSnw7uJBDyriQ==", new DateTime(2023, 10, 28, 16, 2, 6, 5, DateTimeKind.Utc).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 75, DateTimeKind.Utc).AddTicks(464), "rollin.boehm@email.com", "Rollin", "Boehm", "AQAAAAIAAYagAAAAEL2V51eryf5wLMcDi4Fc30UjTzqIn6H9JGuHqovbTUnmYlp6ngLSHbJxCUUOj0SeDg==", new DateTime(2023, 10, 28, 16, 2, 6, 75, DateTimeKind.Utc).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 145, DateTimeKind.Utc).AddTicks(2835), "arlie.franecki@email.com", "Arlie", "Franecki", "AQAAAAIAAYagAAAAENUd3W5HDofkV7cmYgODVrJV9yRE+gZ8mbCALuY+2hkIGry719OUcsv/suBJG4T3+w==", new DateTime(2023, 10, 28, 16, 2, 6, 145, DateTimeKind.Utc).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 214, DateTimeKind.Utc).AddTicks(6522), "leif.wisozk@email.com", "Leif", "Wisozk", "AQAAAAIAAYagAAAAEH6xDRTT4Gpj/Gp0yfVZ1pX4Q8ijmyN+GkwKPZj7LzxyB6SNKF5zQICaK0j4LJbv7w==", new DateTime(2023, 10, 28, 16, 2, 6, 214, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 284, DateTimeKind.Utc).AddTicks(2650), "katelyn.jaskolski@email.com", "Katelyn", "Jaskolski", "AQAAAAIAAYagAAAAEG3SdVRYHvcVT6wLu37il0x650BQ0N6usGdWRowSlHTWOeV02kgPG5cYUphp2V2tIA==", new DateTime(2023, 10, 28, 16, 2, 6, 284, DateTimeKind.Utc).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 354, DateTimeKind.Utc).AddTicks(4011), "howell.ritchie@email.com", "Howell", "Ritchie", "AQAAAAIAAYagAAAAEHx5Cs6qqtFwGd+SZ8pWRcjHHGqZzjw6AYR/g9wv5Ja3V5UFuBw63wL8zmLiDdX3/A==", new DateTime(2023, 10, 28, 16, 2, 6, 354, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 423, DateTimeKind.Utc).AddTicks(7152), "alexandrea.lind@email.com", "Alexandrea", "Lind", "AQAAAAIAAYagAAAAEG5dwD6NHdo6xg/JK/pKcsFhV/7CgTtcCFpLBGRjor5O3Z5vI8z/Ewyb99x749Sb4A==", new DateTime(2023, 10, 28, 16, 2, 6, 423, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 493, DateTimeKind.Utc).AddTicks(1175), "kali.o'hara@email.com", "Kali", "O'Hara", "AQAAAAIAAYagAAAAEEA/yMwlBT3tmS99PdAWJ+oMYbJYlS5AF5oG9/IZq3eVKAtSMeCUrbsPo3o1Pz28OQ==", new DateTime(2023, 10, 28, 16, 2, 6, 493, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 563, DateTimeKind.Utc).AddTicks(2125), "samanta.streich@email.com", "Samanta", "Streich", "AQAAAAIAAYagAAAAECcchjJOsW1iSB7cVqfTQxfiKp2k1JFLB+4VT9nsqj6ynuHWkPD+kYmnWSrlcDqelA==", new DateTime(2023, 10, 28, 16, 2, 6, 563, DateTimeKind.Utc).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 632, DateTimeKind.Utc).AddTicks(7106), "dolly.prosacco@email.com", "Dolly", "Prosacco", "AQAAAAIAAYagAAAAECrng+71NqiRgN//8c9SVYMkVjy0lFbCDU3jZWmORAqiTFy+7NVWszbelVHyfumdcQ==", new DateTime(2023, 10, 28, 16, 2, 6, 632, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 702, DateTimeKind.Utc).AddTicks(6397), "celestino.bahringer@email.com", "Celestino", "Bahringer", "AQAAAAIAAYagAAAAEA0dcEiyW8KKrSERfsjICTWUEw5k+IuLien9WUuFJCLxXi1nURNkl/g9+cJ6gC1eMQ==", new DateTime(2023, 10, 28, 16, 2, 6, 702, DateTimeKind.Utc).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 772, DateTimeKind.Utc).AddTicks(520), "jedidiah.glover@email.com", "Jedidiah", "Glover", "AQAAAAIAAYagAAAAEIU8MTw2cCGUnvpQV6SV+bM0H8QdmO39kpTbNMhEyc1gzHjtN6k6Ugr6+KgAoLqhMw==", new DateTime(2023, 10, 28, 16, 2, 6, 772, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 842, DateTimeKind.Utc).AddTicks(1118), "schuyler.jaskolski@email.com", "Schuyler", "Jaskolski", "AQAAAAIAAYagAAAAEH6MgqtlH8iOCUT0LGOnb+9SXvf/kvzxebWWmtjKl59JUCNDin0DnebDPI8Dw7qUQA==", new DateTime(2023, 10, 28, 16, 2, 6, 842, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 911, DateTimeKind.Utc).AddTicks(9754), "faye.hilll@email.com", "Faye", "Hilll", "AQAAAAIAAYagAAAAEAyGxlEOxVXNPKMImobUC3UQAR1cwOaQaX3wgSfYs9U4zzDBXVKYOCwQS3J0sKmQng==", new DateTime(2023, 10, 28, 16, 2, 6, 911, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 6, 982, DateTimeKind.Utc).AddTicks(3479), "johathan.hahn@email.com", "Johathan", "Hahn", "AQAAAAIAAYagAAAAEMm8tBjFrAgJpfavWwJB3duzfDzWFxclIEXWMkHzZ3yk9Y70sVQaKXx84wkT77hjQA==", new DateTime(2023, 10, 28, 16, 2, 6, 982, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 50, DateTimeKind.Utc).AddTicks(8705), "eldred.mueller@email.com", "Eldred", "Mueller", "AQAAAAIAAYagAAAAEKNPmszAwH7w0Sbpk19ZAWev0WwpPFpNC6k/p256xkvHDjkY/cAN69EABSK9h6WUjw==", new DateTime(2023, 10, 28, 16, 2, 7, 50, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 120, DateTimeKind.Utc).AddTicks(605), "norma.conroy@email.com", "Norma", "Conroy", "AQAAAAIAAYagAAAAEPatxUW0p/mJlttJrIYpJkR+3fOacdusUfYLv+edotl+5fISr8nEpAcirVAel+akCQ==", new DateTime(2023, 10, 28, 16, 2, 7, 120, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 51,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 190, DateTimeKind.Utc).AddTicks(3308), "joany.lindgren@email.com", "Joany", "Lindgren", "AQAAAAIAAYagAAAAEOs+3zreXraYI0bTwdULahQ3QkUSEQeadZ9HvyxG0ONDovNlLNZmX8gVQSdaqNv/Zw==", new DateTime(2023, 10, 28, 16, 2, 7, 190, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 52,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 259, DateTimeKind.Utc).AddTicks(8819), "rosario.howe@email.com", "Rosario", "Howe", "AQAAAAIAAYagAAAAEIAJoOJwVw6IIwI3y1EU0OwiizrWjxf2VZ8mVHRAfgdCctjaAjFdFA8IMnFk6X4FhA==", new DateTime(2023, 10, 28, 16, 2, 7, 259, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 53,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 330, DateTimeKind.Utc).AddTicks(3227), "jacey.emmerich@email.com", "Jacey", "Emmerich", "AQAAAAIAAYagAAAAEDtG3P/tYTPQTeVYGDLONfwRRcp33SguIDTabQjKqoJXCytqi9dVt9mo2fwrYGGwvw==", new DateTime(2023, 10, 28, 16, 2, 7, 330, DateTimeKind.Utc).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 399, DateTimeKind.Utc).AddTicks(5883), "damian.bednar@email.com", "Damian", "Bednar", "AQAAAAIAAYagAAAAEIGv6hM0LBBpnFkp51vujTkMKWMljabKC7o89Z8qMhJEyT78d9yYrshAUD0wveCUFg==", new DateTime(2023, 10, 28, 16, 2, 7, 399, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 471, DateTimeKind.Utc).AddTicks(1499), "howell.hansen@email.com", "Howell", "Hansen", "AQAAAAIAAYagAAAAEO/Aid89OU29zq+Xo6XGkxfk99SEt88sM+nzFmrBY2Suis3Eyf5kJUtpGEuJGAzDTA==", new DateTime(2023, 10, 28, 16, 2, 7, 471, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 543, DateTimeKind.Utc).AddTicks(7794), "albert.williamson@email.com", "Albert", "Williamson", "AQAAAAIAAYagAAAAEA9IntEUTsO2Qvxk84n0tvm7GLjMqZ2JrH4hNO/ogdO/KnRvd0BGGJHWORQ/0pS22g==", new DateTime(2023, 10, 28, 16, 2, 7, 543, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 57,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 612, DateTimeKind.Utc).AddTicks(7146), "kaitlin.brown@email.com", "Kaitlin", "Brown", "AQAAAAIAAYagAAAAEESOv6Wlq/4JnMFspUZ79SztUmwuVbLC1a9er+FaiWvVYL39Iqhf643BVhvcQ5p6iw==", new DateTime(2023, 10, 28, 16, 2, 7, 612, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 682, DateTimeKind.Utc).AddTicks(8063), "ansley.stracke@email.com", "Ansley", "Stracke", "AQAAAAIAAYagAAAAEHH6fXu477MFYAjrY3uNSuPoe3YLRLFeSTjUbSasKdmBiitVTMhZjTHgJRM2UPHwRg==", new DateTime(2023, 10, 28, 16, 2, 7, 682, DateTimeKind.Utc).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 751, DateTimeKind.Utc).AddTicks(9058), "fritz.olson@email.com", "Fritz", "Olson", "AQAAAAIAAYagAAAAEOQ9q4ITwpxw8KRljneywbkifutSN9VOJafdm7xaltF7VqK8XpU7ao6GMfMIkblgtw==", new DateTime(2023, 10, 28, 16, 2, 7, 751, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 60,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 825, DateTimeKind.Utc).AddTicks(1735), "graciela.zulauf@email.com", "Graciela", "Zulauf", "AQAAAAIAAYagAAAAEIlQlLSzX29/oXXuIca+S7FzGvCMbJ8kHTJ3PZtcOf1kZF2Mv646u8vbbyGB+FneaA==", new DateTime(2023, 10, 28, 16, 2, 7, 825, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 61,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 897, DateTimeKind.Utc).AddTicks(4044), "shaylee.ernser@email.com", "Shaylee", "Ernser", "AQAAAAIAAYagAAAAEDIdYH5waVO56zP7ASWBZ4hfmBgmIcSRqgZQZxY+FfG8AJFRyRbpVbMTkp4nW6UtHg==", new DateTime(2023, 10, 28, 16, 2, 7, 897, DateTimeKind.Utc).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 62,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 7, 972, DateTimeKind.Utc).AddTicks(6792), "uriel.kuhn@email.com", "Uriel", "Kuhn", "AQAAAAIAAYagAAAAEDDhc/3j6oE4ulS9Xl+CrCXyaAMn6EPNMwIuRTrjJUthRjkLpdjSWNShxgpU6svM6w==", new DateTime(2023, 10, 28, 16, 2, 7, 972, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 63,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 44, DateTimeKind.Utc).AddTicks(229), "erik.weimann@email.com", "Erik", "Weimann", "AQAAAAIAAYagAAAAEKUQw7cmyFy+YFGTwHJNFyIaIwPxcDxm+80WdW7KOSDZRIC1c+k8MaaP407oFTdOZw==", new DateTime(2023, 10, 28, 16, 2, 8, 44, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 64,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 113, DateTimeKind.Utc).AddTicks(2686), "anahi.champlin@email.com", "Anahi", "Champlin", "AQAAAAIAAYagAAAAEG00w78tPKuMXWjZWvs1Q7GXyqjqa7YvTC5Al5l867KPXb44hOZSwvPZp9oX/wjskQ==", new DateTime(2023, 10, 28, 16, 2, 8, 113, DateTimeKind.Utc).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 65,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 184, DateTimeKind.Utc).AddTicks(3421), "allie.flatley@email.com", "Allie", "Flatley", "AQAAAAIAAYagAAAAEKqNBkcBEnRTh5ldSOoe/x3isEcOsXvwOhGFZSywoN/1txco5XHManDCTzhHKb5BTA==", new DateTime(2023, 10, 28, 16, 2, 8, 184, DateTimeKind.Utc).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 66,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 259, DateTimeKind.Utc).AddTicks(7146), "candelario.hand@email.com", "Candelario", "Hand", "AQAAAAIAAYagAAAAEN4Cqv8s3cwYdh/P2ZPE17huQtV4gvKJnFxyAhGVf68+27qSMuki75ijnJuhAuo3qQ==", new DateTime(2023, 10, 28, 16, 2, 8, 259, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 67,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 334, DateTimeKind.Utc).AddTicks(6208), "kevin.russel@email.com", "Kevin", "Russel", "AQAAAAIAAYagAAAAEJI6jdoXJdJmWGd3oYLsitCBGA7DRoyloOTUQcCEJ/8gFwrkI5GrXCR5/6D09/ernQ==", new DateTime(2023, 10, 28, 16, 2, 8, 334, DateTimeKind.Utc).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 68,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 411, DateTimeKind.Utc).AddTicks(8287), "dayton.bechtelar@email.com", "Dayton", "Bechtelar", "AQAAAAIAAYagAAAAEPed+yyNxuLDdzhqCi+JAx4wx+PvCKzTCTOJ596LWMGOl+G5DCC3jgTKdzbs40TMBg==", new DateTime(2023, 10, 28, 16, 2, 8, 411, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 69,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 2, 8, 483, DateTimeKind.Utc).AddTicks(6377), "AQAAAAIAAYagAAAAEPA1AwAzs6qY+jZMtpcNhx/Hd8IAAexkAoqGSWjxFjEXfxbfgoKKFjI2BBB6yNQSBw==", new DateTime(2023, 10, 28, 16, 2, 8, 483, DateTimeKind.Utc).AddTicks(6378) });
        }
    }
}
