using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalClinic.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Patient",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Patient",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FechaNacimiento",
                table: "Patient",
                newName: "Birthdate");

            migrationBuilder.RenameColumn(
                name: "CorreoElectronico",
                table: "Patient",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Patient",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Patient",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Patient",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Patient",
                newName: "CorreoElectronico");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Patient",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "Birthdate",
                table: "Patient",
                newName: "FechaNacimiento");
        }
    }
}
