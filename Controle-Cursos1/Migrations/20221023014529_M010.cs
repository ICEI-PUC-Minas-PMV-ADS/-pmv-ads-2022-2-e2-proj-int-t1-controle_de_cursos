using Microsoft.EntityFrameworkCore.Migrations;

namespace Controle.cursos.Migrations
{
    public partial class M010 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "string");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Tipo",
                table: "Alunos",
                type: "string",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
