using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations
{
    public partial class addedratingcolumnnaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_ChefDishes_ChefDishChefId_ChefDishDishId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_ChefDishChefId_ChefDishDishId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "ChefDishChefId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "ChefDishDishId",
                table: "Ratings");

            migrationBuilder.AddColumn<int>(
                name: "ChefId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ChefId_DishId",
                table: "Ratings",
                columns: new[] { "ChefId", "DishId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_ChefDishes_ChefId_DishId",
                table: "Ratings",
                columns: new[] { "ChefId", "DishId" },
                principalTable: "ChefDishes",
                principalColumns: new[] { "ChefId", "DishId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_ChefDishes_ChefId_DishId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_ChefId_DishId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "ChefId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "Ratings");

            migrationBuilder.AddColumn<int>(
                name: "ChefDishChefId",
                table: "Ratings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChefDishDishId",
                table: "Ratings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ChefDishChefId_ChefDishDishId",
                table: "Ratings",
                columns: new[] { "ChefDishChefId", "ChefDishDishId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_ChefDishes_ChefDishChefId_ChefDishDishId",
                table: "Ratings",
                columns: new[] { "ChefDishChefId", "ChefDishDishId" },
                principalTable: "ChefDishes",
                principalColumns: new[] { "ChefId", "DishId" });
        }
    }
}
