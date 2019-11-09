using Microsoft.EntityFrameworkCore.Migrations;

namespace MDeskRP.Migrations
{
    public partial class AddDeskTypeDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RushDays",
                table: "DeskSpecs",
                newName: "Rush Days");

            migrationBuilder.RenameColumn(
                name: "NumOfDrawers",
                table: "DeskSpecs",
                newName: "Number of Drawers");

            migrationBuilder.AlterColumn<string>(
                name: "Width",
                table: "DeskSpecs",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Depth",
                table: "DeskSpecs",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Rush Days",
                table: "DeskSpecs",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Number of Drawers",
                table: "DeskSpecs",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Desktop type",
                table: "DeskSpecs",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "DeskTypeDescription",
                columns: table => new
                {
                    DeskTypeString = table.Column<string>(nullable: false),
                    DeskType = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskTypeDescription", x => x.DeskTypeString);
                });

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

            migrationBuilder.DropTable(
                name: "DeskTypeDescription");

            migrationBuilder.DropIndex(
                name: "IX_DeskSpecs_Desktop type",
                table: "DeskSpecs");

            migrationBuilder.DropColumn(
                name: "Desktop type",
                table: "DeskSpecs");

            migrationBuilder.RenameColumn(
                name: "Rush Days",
                table: "DeskSpecs",
                newName: "RushDays");

            migrationBuilder.RenameColumn(
                name: "Number of Drawers",
                table: "DeskSpecs",
                newName: "NumOfDrawers");

            migrationBuilder.AlterColumn<string>(
                name: "Width",
                table: "DeskSpecs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Depth",
                table: "DeskSpecs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "RushDays",
                table: "DeskSpecs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "NumOfDrawers",
                table: "DeskSpecs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);
        }
    }
}
