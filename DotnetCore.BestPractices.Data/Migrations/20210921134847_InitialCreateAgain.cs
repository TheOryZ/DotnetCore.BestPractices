using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetCore.BestPractices.Data.Migrations
{
    public partial class InitialCreateAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRoducts_Categories_CategoryId",
                table: "PRoducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PRoducts",
                table: "PRoducts");

            migrationBuilder.RenameTable(
                name: "PRoducts",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_PRoducts_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "PRoducts");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "PRoducts",
                newName: "IX_PRoducts_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRoducts",
                table: "PRoducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PRoducts_Categories_CategoryId",
                table: "PRoducts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
