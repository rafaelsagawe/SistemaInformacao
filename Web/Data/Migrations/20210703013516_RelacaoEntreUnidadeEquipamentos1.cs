using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class RelacaoEntreUnidadeEquipamentos1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipLocalizacao",
                table: "Equipamentos");

            migrationBuilder.RenameColumn(
                name: "EquipLocal",
                table: "Equipamentos",
                newName: "IdUE");

            migrationBuilder.AddColumn<int>(
                name: "UnidadesIdUE",
                table: "Equipamentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_UnidadesIdUE",
                table: "Equipamentos",
                column: "UnidadesIdUE");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_Unidades_UnidadesIdUE",
                table: "Equipamentos",
                column: "UnidadesIdUE",
                principalTable: "Unidades",
                principalColumn: "IdUE",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_Unidades_UnidadesIdUE",
                table: "Equipamentos");

            migrationBuilder.DropIndex(
                name: "IX_Equipamentos_UnidadesIdUE",
                table: "Equipamentos");

            migrationBuilder.DropColumn(
                name: "UnidadesIdUE",
                table: "Equipamentos");

            migrationBuilder.RenameColumn(
                name: "IdUE",
                table: "Equipamentos",
                newName: "EquipLocal");

            migrationBuilder.AddColumn<string>(
                name: "EquipLocalizacao",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
