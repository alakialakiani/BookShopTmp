using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShopTmp.Migrations
{
    public partial class RenameSomeAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_Books_Authors_AuthorId",
                table: "Author_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_Books_BookInfo_BookId",
                table: "Author_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Categories_BookInfo_BookId",
                table: "Book_Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Categories_Categories_CategoryId",
                table: "Book_Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Translators_BookInfo_BookId",
                table: "Book_Translators");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Translators_Translator_TranslatorId",
                table: "Book_Translators");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Books_BookInfo_BookId",
                table: "Order_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Books_Orders_OrderId",
                table: "Order_Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order_Books",
                table: "Order_Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Translators",
                table: "Book_Translators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Categories",
                table: "Book_Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author_Books",
                table: "Author_Books");

            migrationBuilder.RenameTable(
                name: "Order_Books",
                newName: "OrderBooks");

            migrationBuilder.RenameTable(
                name: "Book_Translators",
                newName: "BookTranslators");

            migrationBuilder.RenameTable(
                name: "Book_Categories",
                newName: "BookCategories");

            migrationBuilder.RenameTable(
                name: "Author_Books",
                newName: "AuthorBooks");

            migrationBuilder.RenameIndex(
                name: "IX_Order_Books_BookId",
                table: "OrderBooks",
                newName: "IX_OrderBooks_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Translators_TranslatorId",
                table: "BookTranslators",
                newName: "IX_BookTranslators_TranslatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Categories_CategoryId",
                table: "BookCategories",
                newName: "IX_BookCategories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Author_Books_AuthorId",
                table: "AuthorBooks",
                newName: "IX_AuthorBooks_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderBooks",
                table: "OrderBooks",
                columns: new[] { "OrderId", "BookId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookTranslators",
                table: "BookTranslators",
                columns: new[] { "BookId", "TranslatorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorBooks",
                table: "AuthorBooks",
                columns: new[] { "BookId", "AuthorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBooks_Authors_AuthorId",
                table: "AuthorBooks",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBooks_BookInfo_BookId",
                table: "AuthorBooks",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategories_BookInfo_BookId",
                table: "BookCategories",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategories_Categories_CategoryId",
                table: "BookCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTranslators_BookInfo_BookId",
                table: "BookTranslators",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTranslators_Translator_TranslatorId",
                table: "BookTranslators",
                column: "TranslatorId",
                principalTable: "Translator",
                principalColumn: "TranslatorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBooks_BookInfo_BookId",
                table: "OrderBooks",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderBooks_Orders_OrderId",
                table: "OrderBooks",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBooks_Authors_AuthorId",
                table: "AuthorBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBooks_BookInfo_BookId",
                table: "AuthorBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategories_BookInfo_BookId",
                table: "BookCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategories_Categories_CategoryId",
                table: "BookCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTranslators_BookInfo_BookId",
                table: "BookTranslators");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTranslators_Translator_TranslatorId",
                table: "BookTranslators");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderBooks_BookInfo_BookId",
                table: "OrderBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderBooks_Orders_OrderId",
                table: "OrderBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderBooks",
                table: "OrderBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookTranslators",
                table: "BookTranslators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorBooks",
                table: "AuthorBooks");

            migrationBuilder.RenameTable(
                name: "OrderBooks",
                newName: "Order_Books");

            migrationBuilder.RenameTable(
                name: "BookTranslators",
                newName: "Book_Translators");

            migrationBuilder.RenameTable(
                name: "BookCategories",
                newName: "Book_Categories");

            migrationBuilder.RenameTable(
                name: "AuthorBooks",
                newName: "Author_Books");

            migrationBuilder.RenameIndex(
                name: "IX_OrderBooks_BookId",
                table: "Order_Books",
                newName: "IX_Order_Books_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookTranslators_TranslatorId",
                table: "Book_Translators",
                newName: "IX_Book_Translators_TranslatorId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCategories_CategoryId",
                table: "Book_Categories",
                newName: "IX_Book_Categories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBooks_AuthorId",
                table: "Author_Books",
                newName: "IX_Author_Books_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order_Books",
                table: "Order_Books",
                columns: new[] { "OrderId", "BookId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Translators",
                table: "Book_Translators",
                columns: new[] { "BookId", "TranslatorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Categories",
                table: "Book_Categories",
                columns: new[] { "BookId", "CategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author_Books",
                table: "Author_Books",
                columns: new[] { "BookId", "AuthorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Books_Authors_AuthorId",
                table: "Author_Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Books_BookInfo_BookId",
                table: "Author_Books",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Book_Translators_BookInfo_BookId",
                table: "Book_Translators",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Translators_Translator_TranslatorId",
                table: "Book_Translators",
                column: "TranslatorId",
                principalTable: "Translator",
                principalColumn: "TranslatorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Books_BookInfo_BookId",
                table: "Order_Books",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Books_Orders_OrderId",
                table: "Order_Books",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
