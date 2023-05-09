using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingApp.Migrations
{
    /// <inheritdoc />
    public partial class Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BedId",
                table: "Feedbacks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChairId",
                table: "Feedbacks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SofaSetSofaId",
                table: "Feedbacks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "Feedbacks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Beds",
                columns: table => new
                {
                    BedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockStatus = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beds", x => x.BedId);
                    table.ForeignKey(
                        name: "FK_Beds_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chairs",
                columns: table => new
                {
                    ChairId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChairImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChairName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockStatus = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chairs", x => x.ChairId);
                    table.ForeignKey(
                        name: "FK_Chairs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sofasets",
                columns: table => new
                {
                    SofaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SofaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockStatus = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sofasets", x => x.SofaId);
                    table.ForeignKey(
                        name: "FK_Sofasets_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockStatus = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableId);
                    table.ForeignKey(
                        name: "FK_Tables_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_BedId",
                table: "Feedbacks",
                column: "BedId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ChairId",
                table: "Feedbacks",
                column: "ChairId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_SofaSetSofaId",
                table: "Feedbacks",
                column: "SofaSetSofaId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_TableId",
                table: "Feedbacks",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Beds_CategoryId",
                table: "Beds",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Chairs_CategoryId",
                table: "Chairs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sofasets_CategoryId",
                table: "Sofasets",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_CategoryId",
                table: "Tables",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Beds_BedId",
                table: "Feedbacks",
                column: "BedId",
                principalTable: "Beds",
                principalColumn: "BedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Chairs_ChairId",
                table: "Feedbacks",
                column: "ChairId",
                principalTable: "Chairs",
                principalColumn: "ChairId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Sofasets_SofaSetSofaId",
                table: "Feedbacks",
                column: "SofaSetSofaId",
                principalTable: "Sofasets",
                principalColumn: "SofaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Tables_TableId",
                table: "Feedbacks",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Beds_BedId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Chairs_ChairId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Sofasets_SofaSetSofaId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Tables_TableId",
                table: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Beds");

            migrationBuilder.DropTable(
                name: "Chairs");

            migrationBuilder.DropTable(
                name: "Sofasets");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_BedId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_ChairId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_SofaSetSofaId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_TableId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "BedId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "ChairId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "SofaSetSofaId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "Feedbacks");
        }
    }
}
