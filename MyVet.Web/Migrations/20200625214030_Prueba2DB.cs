using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyVet.Web.Migrations
{
    public partial class Prueba2DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Disponible",
                table: "Agendas",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Agendas",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Agendas");

            migrationBuilder.AlterColumn<bool>(
                name: "Disponible",
                table: "Agendas",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
