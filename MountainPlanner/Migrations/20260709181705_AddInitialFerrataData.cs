using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MountainPlanner.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialFerrataData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ferratas",
                columns: new[] { "Id", "Difficulty", "Name" },
                values: new object[,]
                {
                    { 1, 6, "Johann Klettersteig" },
                    { 2, 4, "Donnerkogel Klettersteig" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ferratas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ferratas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
