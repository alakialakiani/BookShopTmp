using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShopTmp.Migrations
{
    public partial class Add_Book_Category_Tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_Categories_CategoryId",
                table: "BookInfo");

            migrationBuilder.DropIndex(
                name: "IX_BookInfo_CategoryId",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "BookInfo");

            migrationBuilder.AddColumn<bool>(
                name: "Delete",
                table: "BookInfo",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublish",
                table: "BookInfo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "BookInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublishYear",
                table: "BookInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Book_Category",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book_Category", x => new { x.BookId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_Book_Category_BookInfo_BookId",
                        column: x => x.BookId,
                        principalTable: "BookInfo",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Category_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Category_CategoryId",
                table: "Book_Category",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book_Category");

            migrationBuilder.DropColumn(
                name: "Delete",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "IsPublish",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "PublishYear",
                table: "BookInfo");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "BookInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookInfo_CategoryId",
                table: "BookInfo",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_Categories_CategoryId",
                table: "BookInfo",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
