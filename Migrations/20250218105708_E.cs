using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommApp.Migrations
{
    /// <inheritdoc />
    public partial class E : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categorieId",
                table: "Produits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "categorieId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                column: "categorieId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Produits_categorieId",
                table: "Produits",
                column: "categorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_categorieId",
                table: "Produits",
                column: "categorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_categorieId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_categorieId",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "categorieId",
                table: "Produits");
        }
    }
}
