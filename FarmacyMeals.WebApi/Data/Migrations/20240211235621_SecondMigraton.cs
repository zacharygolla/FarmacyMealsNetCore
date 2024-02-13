using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FarmacyMeals.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigraton : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5218fbd6-2c98-437d-8504-15fb022b83e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2b4e7e1-2ca3-477a-a783-a47e6fa2f106");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29c9b4ea-b81c-426c-9dcd-09ba1fcf755d", null, "Member", "MEMBER" },
                    { "b089b4c4-3656-4e7f-b9bd-701e86f2f527", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29c9b4ea-b81c-426c-9dcd-09ba1fcf755d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b089b4c4-3656-4e7f-b9bd-701e86f2f527");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5218fbd6-2c98-437d-8504-15fb022b83e3", null, "Admin", "ADMIN" },
                    { "d2b4e7e1-2ca3-477a-a783-a47e6fa2f106", null, "Member", "MEMBER" }
                });
        }
    }
}
