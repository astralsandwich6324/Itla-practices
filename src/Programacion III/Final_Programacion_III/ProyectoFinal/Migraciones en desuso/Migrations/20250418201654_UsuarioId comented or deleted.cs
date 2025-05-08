using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Courier.web.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioIdcomentedordeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "PreaAlertasDb");

            migrationBuilder.AlterColumn<int>(
                name: "HistoryId",
                table: "PreaAlertasDb",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HistoryId",
                table: "PreaAlertasDb",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "PreaAlertasDb",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
