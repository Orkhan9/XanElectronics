using Microsoft.EntityFrameworkCore.Migrations;

namespace XanElectronics.Migrations
{
    public partial class changedBioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Bios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Bios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Bios");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Bios");
        }
    }
}
