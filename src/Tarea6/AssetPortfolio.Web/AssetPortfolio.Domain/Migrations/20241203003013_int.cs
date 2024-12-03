using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetPortfolio.Domain.Migrations
{
    /// <inheritdoc />
    public partial class @int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Portfolio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Assets = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CurrentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InvestorId = table.Column<int>(type: "int", nullable: false),
                    PortfolioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_Investor_InvestorId",
                        column: x => x.InvestorId,
                        principalTable: "Investor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asset_Portfolio_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asset_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_InvestorId",
                table: "Asset",
                column: "InvestorId");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_PortfolioId",
                table: "Asset",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_StatusId",
                table: "Asset",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "Investor");

            migrationBuilder.DropTable(
                name: "Portfolio");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
