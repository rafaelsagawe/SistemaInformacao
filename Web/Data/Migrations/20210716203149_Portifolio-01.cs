using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class Portifolio01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUE",
                table: "Equipamentos");

            migrationBuilder.CreateTable(
                name: "Portifolios",
                columns: table => new
                {
                    IdPortefolio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeSistema = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portifolios", x => x.IdPortefolio);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portifolios");

            migrationBuilder.AddColumn<int>(
                name: "IdUE",
                table: "Equipamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
