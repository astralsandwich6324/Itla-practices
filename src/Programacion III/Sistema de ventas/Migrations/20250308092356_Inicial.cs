using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P.Final.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComprasDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Proveedor = table.Column<string>(type: "TEXT", nullable: false),
                    FechaCompra = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false),
                    IngresosProveedor = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprasDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductosDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Stock = table.Column<double>(type: "REAL", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    FechaV = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: true),
                    Total = table.Column<double>(type: "REAL", nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InventoryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductosDB_ProductosDB_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "ProductosDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioDb", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductosDB_InventoryId",
                table: "ProductosDB",
                column: "InventoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComprasDB");

            migrationBuilder.DropTable(
                name: "ProductosDB");

            migrationBuilder.DropTable(
                name: "UsuarioDb");
        }
    }
}
