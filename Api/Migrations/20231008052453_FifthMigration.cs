using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamFive.Migrations
{
    /// <inheritdoc />
    public partial class FifthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7815), new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7967), new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7982), new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7995), new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(8027), new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(8048), new DateTime(2023, 10, 8, 5, 24, 53, 224, DateTimeKind.Utc).AddTicks(8048) });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8300), new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8471), new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8489), new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8505), new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8535), new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8558), new DateTime(2023, 10, 8, 5, 23, 43, 518, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 523, DateTimeKind.Utc).AddTicks(4354), "AQAAAAIAAYagAAAAEN7z2sctfRuCAw4m1I7/fP9ERHkzuNcV7d8GiTE2Ay3CfckPcCKoxdd7PdkD0Ug4NQ==", new DateTime(2023, 10, 8, 5, 23, 43, 523, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 606, DateTimeKind.Utc).AddTicks(3150), "AQAAAAIAAYagAAAAEI1vVXqM9d0qFtWbpXHaXppOngaUZoWK/HRM+mClzbUh6qgHyHDtXkTfVP3m1cWrMw==", new DateTime(2023, 10, 8, 5, 23, 43, 606, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 695, DateTimeKind.Utc).AddTicks(2489), "AQAAAAIAAYagAAAAENjOzBToqwVTN3LrFE0X1L1TvsSqhPCOgKuzJ9f0AcDa5Mqau5aBzRlUika2l0dx/w==", new DateTime(2023, 10, 8, 5, 23, 43, 695, DateTimeKind.Utc).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 809, DateTimeKind.Utc).AddTicks(6805), "AQAAAAIAAYagAAAAEKMroxTLyagF3HcPCXsvRUyCn250TDHc3h5s4sP1BZFrLu2Kkn1RefhLjUdBgCRieg==", new DateTime(2023, 10, 8, 5, 23, 43, 809, DateTimeKind.Utc).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 8, 5, 23, 43, 907, DateTimeKind.Utc).AddTicks(7860), "AQAAAAIAAYagAAAAEAVsl36VbJs7TlRmJ0U/WGKI0u2suAFTrkiawmba87MG9eD2iX+CfBIpX4KEW9E/cQ==", new DateTime(2023, 10, 8, 5, 23, 43, 907, DateTimeKind.Utc).AddTicks(7864) });
        }
    }
}
