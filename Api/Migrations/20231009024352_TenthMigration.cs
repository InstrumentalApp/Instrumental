using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class TenthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentLessonBookings");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.CreateTable(
                name: "UserLessonBookings",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    BookingNotes = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLessonBookings", x => new { x.UserId, x.LessonId });
                    table.ForeignKey(
                        name: "FK_UserLessonBookings_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLessonBookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(1893), new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(1904), new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(1906), new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "InstrumentName", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2407), "Cello", new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2605), new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2622), new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2640), new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2669), new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2694), new DateTime(2023, 10, 9, 2, 43, 52, 190, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2009), new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2015), new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2018), new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2022), new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.InsertData(
                table: "UserLessonBookings",
                columns: new[] { "LessonId", "UserId", "BookingDate", "BookingNotes", "CreatedAt", "Id", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 8, 19, 43, 52, 630, DateTimeKind.Local).AddTicks(2172), "Notes for the first Booking", new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2160), 1, new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2161) },
                    { 3, 2, new DateTime(2023, 10, 8, 19, 43, 52, 630, DateTimeKind.Local).AddTicks(2249), "Notes for the second Booking", new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2247), 2, new DateTime(2023, 10, 9, 2, 43, 52, 630, DateTimeKind.Utc).AddTicks(2248) }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 196, DateTimeKind.Utc).AddTicks(3914), "AQAAAAIAAYagAAAAEMaYrXu1f2MxC/lMqoNGyp/lMFSeZebjwmWrQu8cSgXuvjU2/BkUQdb/OPzTv54eJA==", new DateTime(2023, 10, 9, 2, 43, 52, 196, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 275, DateTimeKind.Utc).AddTicks(9139), "AQAAAAIAAYagAAAAECkYi9GB8v3iDSO/nWrS6ac2sIQJKIFi6lsp4dvyPoBT9KYgs27yC4oAtwDey3VozQ==", new DateTime(2023, 10, 9, 2, 43, 52, 275, DateTimeKind.Utc).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 354, DateTimeKind.Utc).AddTicks(4459), "AQAAAAIAAYagAAAAEDQs80/rdp6sgvzDWLE4PqcHmDPHvrFNhQVNLiJ489EzOE6zJzxjhuf6BSRmEwvYzw==", new DateTime(2023, 10, 9, 2, 43, 52, 354, DateTimeKind.Utc).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 435, DateTimeKind.Utc).AddTicks(8328), "AQAAAAIAAYagAAAAEPKoJNR8T5r+QrvjEzrEF+TITQb3GD2zkphOeTryk7vxXZiK77oXDCNNTG67Ms3Ngg==", new DateTime(2023, 10, 9, 2, 43, 52, 435, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 9, 2, 43, 52, 515, DateTimeKind.Utc).AddTicks(1831), "AQAAAAIAAYagAAAAEPvvvrdv6yz4Kk17kriY68i9eckLTqD03x+QEVGCs6y+tHILmRpTDHXA6t4Cc8vKfQ==", new DateTime(2023, 10, 9, 2, 43, 52, 515, DateTimeKind.Utc).AddTicks(1836) });

            migrationBuilder.CreateIndex(
                name: "IX_UserLessonBookings_LessonId",
                table: "UserLessonBookings",
                column: "LessonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLessonBookings");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WillingToTravel = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StudentLessonBookings",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    BookingNotes = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLessonBookings", x => new { x.StudentId, x.LessonId });
                    table.ForeignKey(
                        name: "FK_StudentLessonBookings_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentLessonBookings_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
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
                columns: new[] { "CreatedAt", "InstrumentName", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6228), "Acoustic Guitar", new DateTime(2023, 10, 8, 7, 39, 13, 409, DateTimeKind.Utc).AddTicks(6231) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6045), new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6051), new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6054), new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6057), new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Description", "FirstName", "LastName", "Location", "UpdatedAt", "WillingToTravel" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5913), "The First Student in Instrumental", "John", "Doe", "Online", new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5917), false },
                    { 2, new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5924), "Second Student in DB", "Jane", "Smith", "Seattle, WA", new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5924), true },
                    { 5, new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5926), "When the student is truly ready, the teacher disappears.", "Eve", "Davis", "Hidden Cave, Sacred Mountains", new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(5927), false }
                });

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

            migrationBuilder.InsertData(
                table: "StudentLessonBookings",
                columns: new[] { "LessonId", "StudentId", "BookingDate", "BookingNotes", "CreatedAt", "Id", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 8, 0, 39, 13, 837, DateTimeKind.Local).AddTicks(6104), "Notes for the first Booking", new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6094), 1, new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6095) },
                    { 3, 2, new DateTime(2023, 10, 8, 0, 39, 13, 837, DateTimeKind.Local).AddTicks(6186), "Notes for the second Booking", new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6184), 1, new DateTime(2023, 10, 8, 7, 39, 13, 837, DateTimeKind.Utc).AddTicks(6185) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentLessonBookings_LessonId",
                table: "StudentLessonBookings",
                column: "LessonId");
        }
    }
}
