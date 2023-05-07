using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcEmployee.Migrations
{
    public partial class Apellido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Employee");
        }
    }
}
