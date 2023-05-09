using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingApp.Migrations
{
    /// <inheritdoc />
    public partial class FixedRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Productss_ProductId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Productss_Categories_CategoryId",
                table: "Productss");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Productss",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Productss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Productss_ProductId",
                table: "Feedbacks",
                column: "ProductId",
                principalTable: "Productss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productss_Categories_CategoryId",
                table: "Productss",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Productss_ProductId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Productss_Categories_CategoryId",
                table: "Productss");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Productss");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Productss",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Feedbacks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Productss_ProductId",
                table: "Feedbacks",
                column: "ProductId",
                principalTable: "Productss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productss_Categories_CategoryId",
                table: "Productss",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
