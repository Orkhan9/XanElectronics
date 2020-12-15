using Microsoft.EntityFrameworkCore.Migrations;

namespace XanElectronics.Migrations
{
    public partial class addedResultPriceColumnProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ResultPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResultPrice",
                table: "Products");
        }
    }
}
