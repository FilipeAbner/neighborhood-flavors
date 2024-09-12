using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace trabalhofinal.Migrations
{
    /// <inheritdoc />
    public partial class AddPrimaryKeyItemMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemMenus",
                table: "ItemMenus");

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumns: new[] { "ItemId", "MenuId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumns: new[] { "ItemId", "MenuId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumns: new[] { "ItemId", "MenuId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumns: new[] { "ItemId", "MenuId" },
                keyValues: new object[] { 4, 2 });

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

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ItemMenus",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemMenus",
                table: "ItemMenus",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "ItemMenus",
                columns: new[] { "Id", "ItemId", "MenuId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 1 },
                    { 4, 4, 2 },
                    { 5, 1, 3 },
                    { 6, 2, 3 },
                    { 7, 3, 3 },
                    { 8, 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rating_UserId",
                table: "Rating",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMenus_MenuId",
                table: "ItemMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_User_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_User_UserId",
                table: "Rating",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_User_UserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_User_UserId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Rating_UserId",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemMenus",
                table: "ItemMenus");

            migrationBuilder.DropIndex(
                name: "IX_ItemMenus_MenuId",
                table: "ItemMenus");

            migrationBuilder.DropIndex(
                name: "IX_Comment_UserId",
                table: "Comment");

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemMenus",
                keyColumn: "Id",
                keyColumnType: "INTEGER",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ItemMenus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemMenus",
                table: "ItemMenus",
                columns: new[] { "MenuId", "ItemId" });

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
                table: "ItemMenus",
                columns: new[] { "ItemId", "MenuId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 },
                    { 2, 2 },
                    { 4, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 }
                });
        }
    }
}
