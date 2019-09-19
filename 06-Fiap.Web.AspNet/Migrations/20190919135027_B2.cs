using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _06_Fiap.Web.AspNet.Migrations
{
    public partial class B2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SindicoId",
                table: "T_ASP_CONDOMINIO",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Construtoras",
                columns: table => new
                {
                    ConstrutoraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Construtoras", x => x.ConstrutoraId);
                });

            migrationBuilder.CreateTable(
                name: "Imoveis",
                columns: table => new
                {
                    ImovelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(nullable: true),
                    AreaUtil = table.Column<float>(nullable: false),
                    CondominioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imoveis", x => x.ImovelId);
                    table.ForeignKey(
                        name: "FK_Imoveis_T_ASP_CONDOMINIO_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "T_ASP_CONDOMINIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sindicos",
                columns: table => new
                {
                    SindicoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sindicos", x => x.SindicoId);
                });

            migrationBuilder.CreateTable(
                name: "CondominioConstrutora",
                columns: table => new
                {
                    ConstrutoraId = table.Column<int>(nullable: false),
                    CondominioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondominioConstrutora", x => new { x.ConstrutoraId, x.CondominioId });
                    table.ForeignKey(
                        name: "FK_CondominioConstrutora_T_ASP_CONDOMINIO_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "T_ASP_CONDOMINIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CondominioConstrutora_Construtoras_ConstrutoraId",
                        column: x => x.ConstrutoraId,
                        principalTable: "Construtoras",
                        principalColumn: "ConstrutoraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_ASP_CONDOMINIO_SindicoId",
                table: "T_ASP_CONDOMINIO",
                column: "SindicoId");

            migrationBuilder.CreateIndex(
                name: "IX_CondominioConstrutora_CondominioId",
                table: "CondominioConstrutora",
                column: "CondominioId");

            migrationBuilder.CreateIndex(
                name: "IX_Imoveis_CondominioId",
                table: "Imoveis",
                column: "CondominioId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_ASP_CONDOMINIO_Sindicos_SindicoId",
                table: "T_ASP_CONDOMINIO",
                column: "SindicoId",
                principalTable: "Sindicos",
                principalColumn: "SindicoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_ASP_CONDOMINIO_Sindicos_SindicoId",
                table: "T_ASP_CONDOMINIO");

            migrationBuilder.DropTable(
                name: "CondominioConstrutora");

            migrationBuilder.DropTable(
                name: "Imoveis");

            migrationBuilder.DropTable(
                name: "Sindicos");

            migrationBuilder.DropTable(
                name: "Construtoras");

            migrationBuilder.DropIndex(
                name: "IX_T_ASP_CONDOMINIO_SindicoId",
                table: "T_ASP_CONDOMINIO");

            migrationBuilder.DropColumn(
                name: "SindicoId",
                table: "T_ASP_CONDOMINIO");
        }
    }
}
