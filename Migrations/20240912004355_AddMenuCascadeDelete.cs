using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trabalhofinal.Migrations
{
    /// <inheritdoc />
    public partial class AddMenuCascadeDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 9, 11, 21, 43, 54, 770, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 9, 11, 21, 43, 54, 770, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 9, 11, 21, 43, 54, 770, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 9, 11, 21, 43, 54, 770, DateTimeKind.Local).AddTicks(230));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 9, 11, 21, 9, 28, 402, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 9, 11, 21, 9, 28, 402, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 9, 11, 21, 9, 28, 402, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 9, 11, 21, 9, 28, 402, DateTimeKind.Local).AddTicks(491));
        }
    }
}
