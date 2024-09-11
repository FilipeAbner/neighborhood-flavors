using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace trabalhofinal.Migrations
{
    /// <inheritdoc />
    public partial class Newmenudata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 9, 7, 23, 47, 15, 156, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 9, 7, 23, 47, 15, 157, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 9, 7, 23, 47, 15, 157, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 9, 7, 23, 47, 15, 157, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "RestaurantId", "avgRating" },
                values: new object[] { 3, 1, 4.75 });

            migrationBuilder.InsertData(
                table: "ItemMenus",
                columns: new[] { "ItemId", "MenuId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumns: new[] { "ItemId", "MenuId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumns: new[] { "ItemId", "MenuId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumns: new[] { "ItemId", "MenuId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumns: new[] { "ItemId", "MenuId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 9, 7, 20, 11, 40, 598, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2024, 9, 7, 20, 11, 40, 598, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2024, 9, 7, 20, 11, 40, 598, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2024, 9, 7, 20, 11, 40, 598, DateTimeKind.Local).AddTicks(5596));
        }
    }
}
