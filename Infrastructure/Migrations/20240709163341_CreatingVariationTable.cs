using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreatingVariationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ProductCategories_ProductCategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ProductCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductCategoryId",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "Variations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VariationId = table.Column<int>(type: "int", nullable: false),
                    value = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variations_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Variations_CategoryId",
                table: "Variations",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ProductCategories_CategoryId",
                table: "Categories",
                column: "CategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ProductCategories_CategoryId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "Variations");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductCategoryId",
                table: "Categories",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ProductCategories_ProductCategoryId",
                table: "Categories",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id");
        }
    }
}
