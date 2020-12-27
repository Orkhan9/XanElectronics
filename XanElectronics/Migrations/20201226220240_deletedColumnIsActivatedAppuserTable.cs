using Microsoft.EntityFrameworkCore.Migrations;

namespace XanElectronics.Migrations
{
    public partial class deletedColumnIsActivatedAppuserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da7f7354-df6b-43e5-86f0-6f39c59f290d");

            migrationBuilder.DropColumn(
                name: "IsActivated",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActivated",
                table: "AspNetUsers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Fullname", "IsActivated", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "da7f7354-df6b-43e5-86f0-6f39c59f290d", 0, "5cf198ab-062d-406a-9062-07cd57d766fe", null, false, "Ulvi Mecidov", true, false, null, null, null, null, null, false, "df2b55d2-5fa2-4a02-8d3f-8cbaa2c76fe0", false, null });
        }
    }
}
