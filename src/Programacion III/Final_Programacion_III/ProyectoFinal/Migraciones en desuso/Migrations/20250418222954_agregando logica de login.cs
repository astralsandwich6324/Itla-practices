using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Courier.web.Migrations
{
    /// <inheritdoc />
    public partial class agregandologicadelogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "PreaAlertasDb",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "PreaAlertasDb");
        }
    }
}
