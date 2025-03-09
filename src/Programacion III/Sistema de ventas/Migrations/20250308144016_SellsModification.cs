using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P.Final.Migrations
{
    /// <inheritdoc />
    public partial class SellsModification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "ProductosDB",
                newName: "PriceInicial");

            migrationBuilder.AddColumn<double>(
                name: "PriceF",
                table: "ProductosDB",
                type: "REAL",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceF",
                table: "ProductosDB");

            migrationBuilder.RenameColumn(
                name: "PriceInicial",
                table: "ProductosDB",
                newName: "Price");
        }
    }
}
