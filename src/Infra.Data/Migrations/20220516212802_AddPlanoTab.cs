using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class AddPlanoTab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabTelecomConsolidado");

            migrationBuilder.CreateTable(
                name: "PlanoDescricoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContratoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParcelaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomePlano = table.Column<string>(type: "varchar(200)", nullable: false),
                    DescricaoPlano = table.Column<string>(type: "varchar(1000)", nullable: false),
                    DescontoPlano = table.Column<decimal>(type: "decimal", nullable: false),
                    DataCadastroParcela = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoDescricoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanoDescricoes_Contratos_ContratoId",
                        column: x => x.ContratoId,
                        principalTable: "Contratos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanoDescricoes_Parcelas_ParcelaId",
                        column: x => x.ParcelaId,
                        principalTable: "Parcelas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanoDescricoes_ContratoId",
                table: "PlanoDescricoes",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanoDescricoes_ParcelaId",
                table: "PlanoDescricoes",
                column: "ParcelaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanoDescricoes");

            migrationBuilder.CreateTable(
                name: "TabTelecomConsolidado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Custo = table.Column<decimal>(type: "decimal", nullable: false),
                    Dia = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Disparos = table.Column<int>(type: "int", nullable: false),
                    Fila = table.Column<int>(type: "int", nullable: false),
                    Servidor = table.Column<string>(type: "varchar(100)", nullable: false),
                    StatusFinal = table.Column<string>(type: "varchar(100)", nullable: false),
                    StatusInicial = table.Column<string>(type: "varchar(255)", nullable: false),
                    Terminator = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabTelecomConsolidado", x => x.Id);
                });
        }
    }
}
