using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableWithUtc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 15, 11, 15, 2, 299, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 15, 11, 15, 2, 299, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 15, 11, 15, 2, 299, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 15, 11, 15, 2, 299, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 15, 11, 15, 2, 299, DateTimeKind.Utc).AddTicks(6100));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 15, 16, 47, 28, 776, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 15, 16, 47, 28, 776, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 15, 16, 47, 28, 776, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 15, 16, 47, 28, 776, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 15, 16, 47, 28, 776, DateTimeKind.Local).AddTicks(6330));
        }
    }
}
