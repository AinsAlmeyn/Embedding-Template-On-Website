using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RESTGIYDIRME.Migrations
{
    public partial class Portfolio_To_PortfolioSlider_Many_To_One : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PortfolioSliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortId = table.Column<int>(type: "int", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioSliders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PortfolioSliders_Portfolios_PortId",
                        column: x => x.PortId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioSliders_PortId",
                table: "PortfolioSliders",
                column: "PortId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioSliders");
        }
    }
}
