using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exercicio_PS.Migrations
{
    public partial class banco1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_ASP_GENERO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ASP_GENERO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_ASP_JOGO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    DataLancamento = table.Column<DateTime>(nullable: false),
                    Plataforma = table.Column<int>(nullable: false),
                    Disponivel = table.Column<bool>(nullable: false),
                    GeneroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ASP_JOGO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ASP_JOGO_T_ASP_GENERO_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "T_ASP_GENERO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_ASP_JOGO_GeneroId",
                table: "T_ASP_JOGO",
                column: "GeneroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_ASP_JOGO");

            migrationBuilder.DropTable(
                name: "T_ASP_GENERO");
        }
    }
}
