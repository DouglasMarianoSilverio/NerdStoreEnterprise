using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NSE.Catalogo.API.Migrations
{
    public partial class CorrecaoDataCadastro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastrado",
                table: "Produtos");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Produtos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Produtos");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastrado",
                table: "Produtos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
