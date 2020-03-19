using Microsoft.EntityFrameworkCore.Migrations;

namespace BestRestaurant.Migrations
{
    public partial class RestaurantNoRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Restaurants");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0);
        }
    }
}
