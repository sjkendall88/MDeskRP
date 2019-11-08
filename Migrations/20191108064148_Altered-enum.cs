using Microsoft.EntityFrameworkCore.Migrations;

namespace MDeskRP.Migrations
{
    public partial class Alteredenum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskSpecs_DeskTypeDescription_Desktop type",
                table: "DeskSpecs");

            migrationBuilder.AlterColumn<string>(
                name: "Desktop type",
                table: "DeskSpecs",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "Rosewood",
                oldClrType: typeof(string),
                oldType: "nvarchar15",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DeskSpecs_DeskTypeDescription_Desktop type",
                table: "DeskSpecs",
                column: "Desktop type",
                principalTable: "DeskTypeDescription",
                principalColumn: "DeskTypeString",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskSpecs_DeskTypeDescription_Desktop type",
                table: "DeskSpecs");

            migrationBuilder.AlterColumn<string>(
                name: "Desktop type",
                table: "DeskSpecs",
                type: "nvarchar15",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldDefaultValue: "Rosewood");

            migrationBuilder.AddForeignKey(
                name: "FK_DeskSpecs_DeskTypeDescription_Desktop type",
                table: "DeskSpecs",
                column: "Desktop type",
                principalTable: "DeskTypeDescription",
                principalColumn: "DeskTypeString",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
