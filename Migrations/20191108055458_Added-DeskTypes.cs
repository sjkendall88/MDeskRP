using Microsoft.EntityFrameworkCore.Migrations;

namespace MDeskRP.Migrations
{
    public partial class AddedDeskTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskSpecs_DeskTypeDescription_DeskType",
                table: "DeskSpecs");

            migrationBuilder.RenameColumn(
                name: "RushDays",
                table: "DeskSpecs",
                newName: "Rush Days");

            migrationBuilder.RenameColumn(
                name: "NumOfDrawers",
                table: "DeskSpecs",
                newName: "Number of Drawers");

            migrationBuilder.RenameColumn(
                name: "DeskType",
                table: "DeskSpecs",
                newName: "Desktop type");

            migrationBuilder.RenameIndex(
                name: "IX_DeskSpecs_DeskType",
                table: "DeskSpecs",
                newName: "IX_DeskSpecs_Desktop type");

            migrationBuilder.AlterColumn<string>(
                name: "Desktop type",
                table: "DeskSpecs",
                type: "nvarchar15",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar15");

            migrationBuilder.AddForeignKey(
                name: "FK_DeskSpecs_DeskTypeDescription_Desktop type",
                table: "DeskSpecs",
                column: "Desktop type",
                principalTable: "DeskTypeDescription",
                principalColumn: "DeskTypeString",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskSpecs_DeskTypeDescription_Desktop type",
                table: "DeskSpecs");

            migrationBuilder.RenameColumn(
                name: "Rush Days",
                table: "DeskSpecs",
                newName: "RushDays");

            migrationBuilder.RenameColumn(
                name: "Number of Drawers",
                table: "DeskSpecs",
                newName: "NumOfDrawers");

            migrationBuilder.RenameColumn(
                name: "Desktop type",
                table: "DeskSpecs",
                newName: "DeskType");

            migrationBuilder.RenameIndex(
                name: "IX_DeskSpecs_Desktop type",
                table: "DeskSpecs",
                newName: "IX_DeskSpecs_DeskType");

            migrationBuilder.AlterColumn<string>(
                name: "DeskType",
                table: "DeskSpecs",
                type: "nvarchar15",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar15",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DeskSpecs_DeskTypeDescription_DeskType",
                table: "DeskSpecs",
                column: "DeskType",
                principalTable: "DeskTypeDescription",
                principalColumn: "DeskTypeString",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
