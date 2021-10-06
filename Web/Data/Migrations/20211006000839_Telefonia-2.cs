using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class Telefonia2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RamalidRamal",
                table: "Linha",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ramal",
                columns: table => new
                {
                    idRamal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MACAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<int>(type: "int", nullable: false),
                    Linha = table.Column<int>(type: "int", nullable: false),
                    localizacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ramal", x => x.idRamal);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Linha_RamalidRamal",
                table: "Linha",
                column: "RamalidRamal");

            migrationBuilder.AddForeignKey(
                name: "FK_Linha_Ramal_RamalidRamal",
                table: "Linha",
                column: "RamalidRamal",
                principalTable: "Ramal",
                principalColumn: "idRamal",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Linha_Ramal_RamalidRamal",
                table: "Linha");

            migrationBuilder.DropTable(
                name: "Ramal");

            migrationBuilder.DropIndex(
                name: "IX_Linha_RamalidRamal",
                table: "Linha");

            migrationBuilder.DropColumn(
                name: "RamalidRamal",
                table: "Linha");
        }
    }
}
