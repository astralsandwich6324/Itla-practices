using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POS.Api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProveedorsDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    FechaRegisro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaVenta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductosComprados = table.Column<double>(type: "REAL", nullable: false),
                    IngresosProveedor = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProveedorsDB", x => x.Id);
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
                    Tipo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Stock = table.Column<double>(type: "REAL", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    FechaCaducidad = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BasePrice = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ProvedorId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProveedorId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryDB_ProveedorsDB_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "ProveedorsDB",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VentasDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    SalePrice = table.Column<double>(type: "REAL", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InventoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentasDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentasDB_InventoryDB_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "InventoryDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryDB_ProveedorId",
                table: "InventoryDB",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_VentasDB_InventoryId",
                table: "VentasDB",
                column: "InventoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioDb");

            migrationBuilder.DropTable(
                name: "VentasDB");

            migrationBuilder.DropTable(
                name: "InventoryDB");

            migrationBuilder.DropTable(
                name: "ProveedorsDB");
        }
    }
}
