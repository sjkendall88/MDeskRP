using Microsoft.EntityFrameworkCore.Migrations;

namespace MDeskRP.Migrations
{
    public partial class Fixit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeskTypeDescriptionDeskTypeString",
                table: "DeskSpecs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeskTypeString",
                table: "DeskSpecs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DeskTypeDescription",
                columns: table => new
                {
                    DeskTypeString = table.Column<int>(nullable: false),
                    DeskType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskTypeDescription", x => x.DeskTypeString);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskSpecs_DeskTypeDescription_DeskTypeDescriptionDeskTypeString",
                table: "DeskSpecs");

            migrationBuilder.DropTable(
                name: "DeskTypeDescription");

            migrationBuilder.DropIndex(
                name: "IX_DeskSpecs_DeskTypeDescriptionDeskTypeString",
                table: "DeskSpecs");

            migrationBuilder.DropColumn(
                name: "DeskTypeDescriptionDeskTypeString",
                table: "DeskSpecs");

            migrationBuilder.DropColumn(
                name: "DeskTypeString",
                table: "DeskSpecs");
        }
    }
}
