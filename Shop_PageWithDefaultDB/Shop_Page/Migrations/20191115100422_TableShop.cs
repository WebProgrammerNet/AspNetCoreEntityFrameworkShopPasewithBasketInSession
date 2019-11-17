using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop_Page.Migrations
{
    public partial class TableShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItems_Cars_CarId",
                table: "ShopCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShopCartItems_CarId",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "ShopCardId",
                table: "ShopCartItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "ShopCartItems",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "ShopCartItems",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ShopCardId",
                table: "ShopCartItems",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItems_CarId",
                table: "ShopCartItems",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItems_Cars_CarId",
                table: "ShopCartItems",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
