using Microsoft.EntityFrameworkCore.Migrations;

namespace MDeskRP.Migrations
{
    public partial class Alteredenum1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Desktop type",
                table: "DeskSpecs",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldDefaultValue: "Rosewood");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Desktop type",
                table: "DeskSpecs",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "Rosewood",
                oldClrType: typeof(string),
                oldType: "varchar(30)");
        }
    }
}
