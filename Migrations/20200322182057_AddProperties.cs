using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShopTmp.Migrations
{
    public partial class AddProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Category_BookInfo_BookId",
                table: "Book_Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Category_Categories_CategoryId",
                table: "Book_Category");

            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_Publisher_PublisherId",
                table: "BookInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publisher",
                table: "Publisher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Category",
                table: "Book_Category");

            migrationBuilder.RenameTable(
                name: "Publisher",
                newName: "Publishers");

            migrationBuilder.RenameTable(
                name: "Book_Category",
                newName: "Book_Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Category_CategoryId",
                table: "Book_Categories",
                newName: "IX_Book_Categories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "PublisherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Categories",
                table: "Book_Categories",
                columns: new[] { "BookId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Categories_BookInfo_BookId",
                table: "Book_Categories",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Categories_Categories_CategoryId",
                table: "Book_Categories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_Publishers_PublisherId",
                table: "BookInfo",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Categories_BookInfo_BookId",
                table: "Book_Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Categories_Categories_CategoryId",
                table: "Book_Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_Publishers_PublisherId",
                table: "BookInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Categories",
                table: "Book_Categories");

            migrationBuilder.RenameTable(
                name: "Publishers",
                newName: "Publisher");

            migrationBuilder.RenameTable(
                name: "Book_Categories",
                newName: "Book_Category");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Categories_CategoryId",
                table: "Book_Category",
                newName: "IX_Book_Category_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publisher",
                table: "Publisher",
                column: "PublisherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Category",
                table: "Book_Category",
                columns: new[] { "BookId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Category_BookInfo_BookId",
                table: "Book_Category",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Category_Categories_CategoryId",
                table: "Book_Category",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_Publisher_PublisherId",
                table: "BookInfo",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
