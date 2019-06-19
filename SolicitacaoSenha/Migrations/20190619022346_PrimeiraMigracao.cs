using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademySystem.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Professor",
                columns: table => new
                {
                    CodigoProfessor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    _nome = table.Column<string>(type: "varchar(500)", nullable: true),
                    _idade = table.Column<string>(type: "varchar(2)", nullable: true),
                    _rg = table.Column<string>(type: "varchar(9)", nullable: true),
                    _sexo = table.Column<int>(type: "int", nullable: false),
                    _formacao = table.Column<string>(type: "varchar(50)", nullable: true),
                    _materiaLecionada = table.Column<string>(type: "varchar(150)", nullable: true),
                    _contratacao = table.Column<DateTime>(type: "Date", nullable: false),
                    _ativo = table.Column<bool>(type: "bit", nullable: false),
                    _foto = table.Column<string>(type: "varchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Professor", x => x.CodigoProfessor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Professor");
        }
    }
}
