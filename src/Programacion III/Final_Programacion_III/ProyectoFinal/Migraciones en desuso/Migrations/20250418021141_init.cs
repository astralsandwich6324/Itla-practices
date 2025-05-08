using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Courier.web.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Usuario = table.Column<string>(type: "TEXT", nullable: false),
                    Mail = table.Column<string>(type: "TEXT", nullable: false),
                    Contrasena = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaquetesDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false),
                    Retenido = table.Column<bool>(type: "INTEGER", nullable: false),
                    Numero = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Destino = table.Column<string>(type: "TEXT", nullable: false),
                    Proveedor = table.Column<string>(type: "TEXT", nullable: false),
                    Contenido = table.Column<string>(type: "TEXT", nullable: false),
                    Peso = table.Column<double>(type: "REAL", nullable: false),
                    Volumen = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaquetesDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreaAlertasDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Trasportista = table.Column<string>(type: "TEXT", nullable: true),
                    Tracking = table.Column<string>(type: "TEXT", nullable: true),
                    EntregaEstimada = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Proveedor = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<int>(type: "INTEGER", nullable: true),
                    Contenido = table.Column<string>(type: "TEXT", nullable: true),
                    UsuarioId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreaAlertasDb", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginDB");

            migrationBuilder.DropTable(
                name: "PaquetesDB");

            migrationBuilder.DropTable(
                name: "PreaAlertasDb");
        }
    }
}
