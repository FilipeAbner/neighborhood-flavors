using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace trabalhofinal.Migrations
{
    /// <inheritdoc />
    public partial class initialdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    avgRating = table.Column<double>(type: "REAL", nullable: false),
                    RestaurantId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentText = table.Column<string>(type: "TEXT", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MenuId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemMenus",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    MenuId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMenus", x => new { x.MenuId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_ItemMenus_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemMenus_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    MenuId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "ItemName" },
                values: new object[,]
                {
                    { 1, "Carne bovina" },
                    { 2, "Carne Suina" },
                    { 3, "Couve de Flor" },
                    { 4, "Arroz" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Cozinharte", 2 },
                    { 2, "Suzy", 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "suzy@gmail.com", "Suzy", "senha123" },
                    { 2, "cozinharte@gmail.com", "Cozinharte", "senha456" },
                    { 3, "filipe@gmail.com", "Filipe", "123456" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "RestaurantId", "avgRating" },
                values: new object[,]
                {
                    { 1, 1, 4.5 },
                    { 2, 2, 4.0 }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "CommentText", "MenuId", "PublishDate", "UserId" },
                values: new object[,]
                {
                    { 1, "Comida muito boa!", 1, new DateTime(2024, 9, 7, 20, 11, 40, 598, DateTimeKind.Local).AddTicks(5543), 3 },
                    { 2, "Atendimento excelente", 2, new DateTime(2024, 9, 7, 20, 11, 40, 598, DateTimeKind.Local).AddTicks(5587), 3 },
                    { 3, "Pouca variedade de pratos", 1, new DateTime(2024, 9, 7, 20, 11, 40, 598, DateTimeKind.Local).AddTicks(5592), 3 },
                    { 4, "Recomendo o restaurante", 2, new DateTime(2024, 9, 7, 20, 11, 40, 598, DateTimeKind.Local).AddTicks(5596), 3 }
                });

            migrationBuilder.InsertData(
                table: "ItemMenus",
                columns: new[] { "ItemId", "MenuId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 },
                    { 2, 2 },
                    { 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "MenuId", "Score", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 5, 3 },
                    { 2, 2, 4, 3 },
                    { 3, 1, 3, 3 },
                    { 4, 2, 5, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MenuId",
                table: "Comment",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMenus_ItemId",
                table: "ItemMenus",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_RestaurantId",
                table: "Menu",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_MenuId",
                table: "Rating",
                column: "MenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "ItemMenus");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}
