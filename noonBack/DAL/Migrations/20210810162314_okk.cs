using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class okk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subCategory_Categories_CategoryId",
                table: "subCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subCategory",
                table: "subCategory");

            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "products");

            migrationBuilder.RenameTable(
                name: "subCategory",
                newName: "SubCategory");

            migrationBuilder.RenameIndex(
                name: "IX_subCategory_CategoryId",
                table: "SubCategory",
                newName: "IX_SubCategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_Categories_CategoryId",
                table: "SubCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_Categories_CategoryId",
                table: "SubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory");

            migrationBuilder.RenameTable(
                name: "SubCategory",
                newName: "subCategory");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategory_CategoryId",
                table: "subCategory",
                newName: "IX_subCategory_CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_subCategory",
                table: "subCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_subCategory_Categories_CategoryId",
                table: "subCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
