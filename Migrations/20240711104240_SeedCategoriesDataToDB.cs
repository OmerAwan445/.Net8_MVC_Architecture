using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_api_dotnet.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoriesDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Categories");
        }
    }
}
