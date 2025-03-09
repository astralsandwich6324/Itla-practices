using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P.Final.Migrations
{
    /// <inheritdoc />
    public partial class SellsnoheredadeInventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductosDB_ProductosDB_InventoryId",
                table: "ProductosDB");

            migrationBuilder.DropIndex(
                name: "IX_ProductosDB_InventoryId",
                table: "ProductosDB");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "ProductosDB");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ProductosDB");

            migrationBuilder.DropColumn(
                name: "FechaVenta",
                table: "ProductosDB");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "ProductosDB");

            migrationBuilder.DropColumn(
                name: "PriceF",
                table: "ProductosDB");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "ProductosDB");

            migrationBuilder.CreateTable(
                name: "VentasDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceF = table.Column<double>(type: "REAL", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InventoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentasDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentasDB_ProductosDB_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "ProductosDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VentasDB_InventoryId",
                table: "VentasDB",
                column: "InventoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VentasDB");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "ProductosDB",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ProductosDB",
                type: "TEXT",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVenta",
                table: "ProductosDB",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "ProductosDB",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PriceF",
                table: "ProductosDB",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "ProductosDB",
                type: "REAL",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductosDB_InventoryId",
                table: "ProductosDB",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductosDB_ProductosDB_InventoryId",
                table: "ProductosDB",
                column: "InventoryId",
                principalTable: "ProductosDB",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
