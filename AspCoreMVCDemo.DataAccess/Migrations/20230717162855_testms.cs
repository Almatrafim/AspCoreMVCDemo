using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspCoreMVCDemo.DataAccess.Migrations
{
    public partial class testms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "xy",
                table: "categories",
                type: "NVARCHAR2(2000)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "xy",
                table: "categories");
        }
    }
}
