using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeMVC.Migrations
{
    /// <inheritdoc />
    public partial class testRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93b9a695-2ae8-460e-a26c-a0e334340b44", "2/19/2024 2:32:11 PM", "Admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93b9a695-2ae8-460e-a26c-a0e334340b44");
        }
    }
}
