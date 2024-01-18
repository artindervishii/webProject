using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProject.DataAccess.Migrations
{
    public partial class nothingMuch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUseerId",
                table: "ShoppingCarts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUseerId",
                table: "ShoppingCarts");
        }
    }
}
