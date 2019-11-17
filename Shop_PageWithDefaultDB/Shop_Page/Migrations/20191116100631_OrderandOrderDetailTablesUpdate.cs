using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop_Page.Migrations
{
    public partial class OrderandOrderDetailTablesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderTime",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderDetails");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "OrderDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrderDetails",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderTime",
                table: "OrderDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "OrderDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "OrderDetails",
                nullable: true);
        }
    }
}
