using Microsoft.EntityFrameworkCore.Migrations;

namespace MyVet.Web.Migrations
{
    public partial class Prueba1DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "Agendas",
                newName: "Disponible");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Disponible",
                table: "Agendas",
                newName: "IsAvailable");
        }
    }
}
