using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MDeskRP.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 24, nullable: false),
                    LastName = table.Column<string>(maxLength: 24, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: true),
                    CityAddress = table.Column<string>(nullable: true),
                    StateAddress = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "DeskSpecs",
                columns: table => new
                {
                    DeskSpecsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Width = table.Column<string>(nullable: false),
                    Depth = table.Column<string>(nullable: false),
                    NumOfDrawers = table.Column<string>(nullable: false),
                    RushDays = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskSpecs", x => x.DeskSpecsID);
                });

            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    DeskQuoteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(nullable: false),
                    DeskSpecsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.DeskQuoteID);
                    table.ForeignKey(
                        name: "FK_DeskQuote_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeskQuote_DeskSpecs_DeskSpecsID",
                        column: x => x.DeskSpecsID,
                        principalTable: "DeskSpecs",
                        principalColumn: "DeskSpecsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeskQuote_CustomerID",
                table: "DeskQuote",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_DeskQuote_DeskSpecsID",
                table: "DeskQuote",
                column: "DeskSpecsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskQuote");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "DeskSpecs");
        }
    }
}
