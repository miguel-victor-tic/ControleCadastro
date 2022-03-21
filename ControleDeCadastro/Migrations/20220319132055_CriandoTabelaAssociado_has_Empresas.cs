using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeCadastro.Migrations
{
    public partial class CriandoTabelaAssociado_has_Empresas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Associados_has_Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAssociado = table.Column<int>(type: "nvarchar(max)", nullable: false),
                    IdEmpresa = table.Column<int>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associados_has_Empresas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Associados_has_Empresas");
        }
    }
}
