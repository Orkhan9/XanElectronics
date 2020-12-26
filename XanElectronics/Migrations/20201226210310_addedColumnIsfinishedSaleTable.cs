using Microsoft.EntityFrameworkCore.Migrations;

namespace XanElectronics.Migrations
{
    public partial class addedColumnIsfinishedSaleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ceb8d654-cecc-45f4-9f0d-a2fc5c3488d7");

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Sales",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Fullname", "IsActivated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "da7f7354-df6b-43e5-86f0-6f39c59f290d", 0, "5cf198ab-062d-406a-9062-07cd57d766fe", null, false, "Ulvi Mecidov", true, false, null, null, null, null, null, false, "df2b55d2-5fa2-4a02-8d3f-8cbaa2c76fe0", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da7f7354-df6b-43e5-86f0-6f39c59f290d");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Sales");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Fullname", "IsActivated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ceb8d654-cecc-45f4-9f0d-a2fc5c3488d7", 0, "6db1125f-05f0-4ad8-bc4b-0e068f5c3d77", null, false, "Ulvi Mecidov", true, false, null, null, null, null, null, false, "8f85ce20-9817-4a97-9226-e996cb1314fd", false, null });
        }
    }
}
