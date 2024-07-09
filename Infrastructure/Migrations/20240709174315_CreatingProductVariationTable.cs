using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreatingProductVariationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductVariation",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    VariationId = table.Column<int>(type: "int", nullable: false),
                    VariationValueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariation", x => new { x.ProductId, x.VariationId });
                    table.ForeignKey(
                        name: "FK_ProductVariation_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductVariation_Variations_VariationValueId",
                        column: x => x.VariationValueId,
                        principalTable: "Variations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariation_VariationValueId",
                table: "ProductVariation",
                column: "VariationValueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariation");
        }
    }
}
