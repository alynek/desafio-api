using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleApi.Migrations
{
    public partial class RemovidoFaixaEtaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_FaixasEtarias_FaixaEtariaId",
                table: "Pessoas");

            migrationBuilder.DropTable(
                name: "FaixasEtarias");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_FaixaEtariaId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "FaixaEtariaId",
                table: "Pessoas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FaixaEtariaId",
                table: "Pessoas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FaixasEtarias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Faixa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaixasEtarias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_FaixaEtariaId",
                table: "Pessoas",
                column: "FaixaEtariaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_FaixasEtarias_FaixaEtariaId",
                table: "Pessoas",
                column: "FaixaEtariaId",
                principalTable: "FaixasEtarias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
