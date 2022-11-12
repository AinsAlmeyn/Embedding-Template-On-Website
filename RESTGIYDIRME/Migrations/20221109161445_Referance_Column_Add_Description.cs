using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RESTGIYDIRME.Migrations
{
    public partial class Referance_Column_Add_Description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Referances",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Referances");
        }
    }
}
