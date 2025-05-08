using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Courier.web.Migrations
{
    /// <inheritdoc />
    public partial class iniciandosqlserver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaquetesDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistoryId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Retenido = table.Column<bool>(type: "bit", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Volumen = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaquetesDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreaAlertasDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistoryId = table.Column<int>(type: "int", nullable: true),
                    Trasportista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tracking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntregaEstimada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<int>(type: "int", nullable: true),
                    Contenido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioId = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
