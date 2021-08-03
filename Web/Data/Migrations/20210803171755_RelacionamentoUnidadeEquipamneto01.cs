using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class RelacionamentoUnidadeEquipamneto01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unidades_Equipamentos_EquipamentosIdEquipamento",
                table: "Unidades");

            migrationBuilder.DropIndex(
                name: "IX_Unidades_EquipamentosIdEquipamento",
                table: "Unidades");

            migrationBuilder.DropColumn(
                name: "EquipamentosIdEquipamento",
                table: "Unidades");

            migrationBuilder.CreateTable(
                name: "EquipamentosUnidades",
                columns: table => new
                {
                    EquipamentosIdEquipamento = table.Column<int>(type: "int", nullable: false),
                    UnidadesIdUE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipamentosUnidades", x => new { x.EquipamentosIdEquipamento, x.UnidadesIdUE });
                    table.ForeignKey(
                        name: "FK_EquipamentosUnidades_Equipamentos_EquipamentosIdEquipamento",
                        column: x => x.EquipamentosIdEquipamento,
                        principalTable: "Equipamentos",
                        principalColumn: "IdEquipamento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipamentosUnidades_Unidades_UnidadesIdUE",
                        column: x => x.UnidadesIdUE,
                        principalTable: "Unidades",
                        principalColumn: "IdUE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipamentosUnidades_UnidadesIdUE",
                table: "EquipamentosUnidades",
                column: "UnidadesIdUE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipamentosUnidades");

            migrationBuilder.AddColumn<int>(
                name: "EquipamentosIdEquipamento",
                table: "Unidades",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Unidades_EquipamentosIdEquipamento",
                table: "Unidades",
                column: "EquipamentosIdEquipamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Unidades_Equipamentos_EquipamentosIdEquipamento",
                table: "Unidades",
                column: "EquipamentosIdEquipamento",
                principalTable: "Equipamentos",
                principalColumn: "IdEquipamento",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
