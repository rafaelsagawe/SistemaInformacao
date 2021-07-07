using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class Equipamentos01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    IdEquipamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipDescricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipNuSerie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipNuControle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipLocalizacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipTipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipOrigem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipValor = table.Column<int>(type: "int", nullable: false),
                    EquipLocal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.IdEquipamento);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipamentos");
        }
    }
}
