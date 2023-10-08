using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class SixthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_Students_StudentId",
                table: "Instruments");

            migrationBuilder.DropIndex(
                name: "IX_Instruments_StudentId",
                table: "Instruments");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Instruments");

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

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Description", "FirstName", "LastName", "Location", "UpdatedAt", "WillingToTravel" },
                values: new object[] { 1, new DateTime(2023, 10, 8, 5, 48, 58, 169, DateTimeKind.Utc).AddTicks(7425), "The First Student in Instrumental", "John", "Doe", "Online", new DateTime(2023, 10, 8, 5, 48, 58, 169, DateTimeKind.Utc).AddTicks(7429), false });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Instruments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7815), null, new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7967), null, new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7982), null, new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7995), null, new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(8027), null, new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "StudentId", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(8048), null, new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 229, DateTimeKind.Utc).AddTicks(5344), "AQAAAAIAAYagAAAAEIYbMoMeW1kaBZP2S7N2F8+5L9koVQLow71nCrrzqVjcHMIFAn9wo3Y7D+Xsj/QnPA==", new DateTime(2023, 10, 8, 5, 24, 53, 229, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 305, DateTimeKind.Utc).AddTicks(8815), "AQAAAAIAAYagAAAAECotU5J+Wy8P30iiaxzjN1FY4y/QwDlz1uKHZAGjoeVhN92cxbw1m7nI9dGE6+zqpg==", new DateTime(2023, 10, 8, 5, 24, 53, 305, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 382, DateTimeKind.Utc).AddTicks(9742), "AQAAAAIAAYagAAAAEPYpW2v+pVl5kVmoP61E0UUIJ31plkjsqzefgQiu1Oi0K+xfhuAEM28eAA53U08kpA==", new DateTime(2023, 10, 8, 5, 24, 53, 382, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 466, DateTimeKind.Utc).AddTicks(8651), "AQAAAAIAAYagAAAAED0VtxhNDg6z6vvVaApO16mnwNFPE1icLXIPA2wBvLNYOSxNP8CTDvMIHXhTOlmGow==", new DateTime(2023, 10, 8, 5, 24, 53, 466, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 571, DateTimeKind.Utc).AddTicks(406), "AQAAAAIAAYagAAAAEMuztCTGFDiY+1oexy5StMKkOe/g0W4BU2JKHZYfxlfrAJ0uh5gA04fRIwAugD6ARA==", new DateTime(2023, 10, 8, 5, 24, 53, 571, DateTimeKind.Utc).AddTicks(411) });

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_StudentId",
                table: "Instruments",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_Students_StudentId",
                table: "Instruments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }
    }
}
