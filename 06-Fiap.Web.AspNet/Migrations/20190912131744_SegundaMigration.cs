using Microsoft.EntityFrameworkCore.Migrations;

namespace _06_Fiap.Web.AspNet.Migrations
{
    public partial class SegundaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CondominioId",
                table: "T_ASP_CONDOMINIO",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "T_ASP_CONDOMINIO",
                newName: "CondominioId");
        }
    }
}
