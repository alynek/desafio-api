using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleApi.Migrations
{
    public partial class AlteradaFaixaEtaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faixa1",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa10",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa11",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa12",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa13",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa2",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa3",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa4",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa5",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa6",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa7",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa8",
                table: "FaixasEtarias");

            migrationBuilder.DropColumn(
                name: "Faixa9",
                table: "FaixasEtarias");

            migrationBuilder.AddColumn<string>(
                name: "Faixa",
                table: "FaixasEtarias",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faixa",
                table: "FaixasEtarias");

            migrationBuilder.AddColumn<string>(
                name: "Faixa1",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa10",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa11",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa12",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa13",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa2",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa3",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa4",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa5",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa6",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa7",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa8",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faixa9",
                table: "FaixasEtarias",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
