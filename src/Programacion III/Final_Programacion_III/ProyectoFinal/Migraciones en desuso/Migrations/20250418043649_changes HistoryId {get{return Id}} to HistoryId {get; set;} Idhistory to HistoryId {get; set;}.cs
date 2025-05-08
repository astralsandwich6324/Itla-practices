using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Courier.web.Migrations
{
    /// <inheritdoc />
    public partial class changesHistoryIdgetreturnIdtoHistoryIdgetsetIdhistorytoHistoryIdgetset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HistoryId",
                table: "PreaAlertasDb",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HistoryId",
                table: "PaquetesDB",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HistoryId",
                table: "PreaAlertasDb");

            migrationBuilder.DropColumn(
                name: "HistoryId",
                table: "PaquetesDB");
        }
    }
}
