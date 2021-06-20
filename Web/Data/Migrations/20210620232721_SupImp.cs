using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class SupImp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupImp",
                columns: table => new
                {
                    IdSupImp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeloToner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtdImpressoas = table.Column<int>(type: "int", nullable: false),
                    QtdToner = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupImp", x => x.IdSupImp);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupImp");
        }
    }
}
