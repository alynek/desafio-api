using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleApi.Migrations
{
    public partial class PrimeiraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FaixasEtarias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Faixa1 = table.Column<string>(nullable: true),
                    Faixa2 = table.Column<string>(nullable: true),
                    Faixa3 = table.Column<string>(nullable: true),
                    Faixa4 = table.Column<string>(nullable: true),
                    Faixa5 = table.Column<string>(nullable: true),
                    Faixa6 = table.Column<string>(nullable: true),
                    Faixa7 = table.Column<string>(nullable: true),
                    Faixa8 = table.Column<string>(nullable: true),
                    Faixa9 = table.Column<string>(nullable: true),
                    Faixa10 = table.Column<string>(nullable: true),
                    Faixa11 = table.Column<string>(nullable: true),
                    Faixa12 = table.Column<string>(nullable: true),
                    Faixa13 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaixasEtarias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    FaixaEtariaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_FaixasEtarias_FaixaEtariaId",
                        column: x => x.FaixaEtariaId,
                        principalTable: "FaixasEtarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_FaixaEtariaId",
                table: "Pessoas",
                column: "FaixaEtariaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "FaixasEtarias");
        }
    }
}
