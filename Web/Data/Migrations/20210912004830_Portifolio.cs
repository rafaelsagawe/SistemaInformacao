using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class Portifolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acesso",
                table: "Portifolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BandoDados",
                table: "Portifolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Clientes",
                table: "Portifolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoFonte",
                table: "Portifolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CriticidadesId",
                table: "Portifolios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Portifolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Documentacao",
                table: "Portifolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoDesenvolvimento",
                table: "Portifolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hospedagem",
                table: "Portifolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Linguagem",
                table: "Portifolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomePlataforma",
                table: "Portifolios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acesso",
                table: "Portifolios");

            migrationBuilder.DropColumn(
                name: "BandoDados",
                table: "Portifolios");

            migrationBuilder.DropColumn(
                name: "Clientes",
                table: "Portifolios");

            migrationBuilder.DropColumn(
                name: "CodigoFonte",
                table: "Portifolios");

            migrationBuilder.DropColumn(
                name: "CriticidadesId",
                table: "Portifolios");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Portifolios");

            migrationBuilder.DropColumn(
                name: "Documentacao",
                table: "Portifolios");

            migrationBuilder.DropColumn(
                name: "EstadoDesenvolvimento",
                table: "Portifolios");

            migrationBuilder.DropColumn(
                name: "Hospedagem",
                table: "Portifolios");

            migrationBuilder.DropColumn(
                name: "Linguagem",
                table: "Portifolios");

            migrationBuilder.DropColumn(
                name: "NomePlataforma",
                table: "Portifolios");
        }
    }
}
