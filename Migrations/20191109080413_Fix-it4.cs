using Microsoft.EntityFrameworkCore.Migrations;

namespace MDeskRP.Migrations
{
    public partial class Fixit4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskSpecs_DeskTypeDescription_DeskTypeDescriptionDeskTypeString",
                table: "DeskSpecs");

            migrationBuilder.DropIndex(
                name: "IX_DeskSpecs_DeskTypeDescriptionDeskTypeString",
                table: "DeskSpecs");

            migrationBuilder.DropColumn(
                name: "DeskTypeDescriptionDeskTypeString",
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
                name: "DeskTypeString",
                table: "DeskSpecs",
                newName: "Desktop type");

            migrationBuilder.AlterColumn<string>(
                name: "DeskType",
                table: "DeskTypeDescription",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeskTypeString",
                table: "DeskTypeDescription",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Width",
                table: "DeskSpecs",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Depth",
                table: "DeskSpecs",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rush Days",
                table: "DeskSpecs",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Number of Drawers",
                table: "DeskSpecs",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Desktop type",
                table: "DeskSpecs",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_DeskSpecs_Desktop type",
                table: "DeskSpecs",
                column: "Desktop type");

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

            migrationBuilder.DropIndex(
                name: "IX_DeskSpecs_Desktop type",
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
                newName: "DeskTypeString");

            migrationBuilder.AlterColumn<string>(
                name: "DeskType",
                table: "DeskTypeDescription",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "DeskTypeString",
                table: "DeskTypeDescription",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Width",
                table: "DeskSpecs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Depth",
                table: "DeskSpecs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "RushDays",
                table: "DeskSpecs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "NumOfDrawers",
                table: "DeskSpecs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<int>(
                name: "DeskTypeString",
                table: "DeskSpecs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AddColumn<int>(
                name: "DeskTypeDescriptionDeskTypeString",
                table: "DeskSpecs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeskSpecs_DeskTypeDescriptionDeskTypeString",
                table: "DeskSpecs",
                column: "DeskTypeDescriptionDeskTypeString");

            migrationBuilder.AddForeignKey(
                name: "FK_DeskSpecs_DeskTypeDescription_DeskTypeDescriptionDeskTypeString",
                table: "DeskSpecs",
                column: "DeskTypeDescriptionDeskTypeString",
                principalTable: "DeskTypeDescription",
                principalColumn: "DeskTypeString",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
