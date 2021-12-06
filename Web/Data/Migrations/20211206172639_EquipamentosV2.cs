using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class EquipamentosV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipamentosV2",
                columns: table => new
                {
                    IdEquipamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipDescricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipNuSerie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipNuControle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipValor = table.Column<int>(type: "int", nullable: false),
                    NomeUE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipamentosV2", x => x.IdEquipamento);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipamentosV2");
        }
    }
}
