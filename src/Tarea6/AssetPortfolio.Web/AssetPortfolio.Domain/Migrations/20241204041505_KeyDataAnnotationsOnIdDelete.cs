using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetPortfolio.Domain.Migrations
{
    /// <inheritdoc />
    public partial class KeyDataAnnotationsOnIdDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "birthdate",
                table: "Investor",
                newName: "Birthdate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birthdate",
                table: "Investor",
                newName: "birthdate");
        }
    }
}
