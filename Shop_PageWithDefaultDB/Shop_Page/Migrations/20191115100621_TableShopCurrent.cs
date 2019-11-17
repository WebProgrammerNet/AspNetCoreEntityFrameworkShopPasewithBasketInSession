using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop_Page.Migrations
{
    public partial class TableShopCurrent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShopCardId",
                table: "ShopCartItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "carId",
                table: "ShopCartItems",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "ShopCartItems",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItems_carId",
                table: "ShopCartItems",
                column: "carId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItems_Cars_carId",
                table: "ShopCartItems",
                column: "carId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItems_Cars_carId",
                table: "ShopCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShopCartItems_carId",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "ShopCardId",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "carId",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "price",
                table: "ShopCartItems");
        }
    }
}
