using Microsoft.EntityFrameworkCore.Migrations;

namespace _06_Fiap.Web.AspNet.Migrations
{
    public partial class BancoAtualizado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "condominio_id",
                table: "T_ASP_CONDOMINIO",
                newName: "CondominioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CondominioId",
                table: "T_ASP_CONDOMINIO",
                newName: "condominio_id");
        }
    }
}
