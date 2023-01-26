using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeFactory.Migrations
{
    public partial class AddRecipeToDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Recipes");
        }
    }
}
