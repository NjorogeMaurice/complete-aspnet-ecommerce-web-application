using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingApp.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productss_Categories_CategoryId",
                table: "Productss");

            migrationBuilder.DropIndex(
                name: "IX_Productss_CategoryId",
                table: "Productss");

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "Productss",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productss_CatId",
                table: "Productss",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productss_Categories_CatId",
                table: "Productss",
                column: "CatId",
                principalTable: "Categories",
                principalColumn: "CatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productss_Categories_CatId",
                table: "Productss");

            migrationBuilder.DropIndex(
                name: "IX_Productss_CatId",
                table: "Productss");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "Productss");

            migrationBuilder.CreateIndex(
                name: "IX_Productss_CategoryId",
                table: "Productss",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productss_Categories_CategoryId",
                table: "Productss",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
