using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Nutricional.Migrations
{
    public partial class CriandoTabelaAlimentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    DescricaoNutricional = table.Column<string>(type: "text", nullable: false),
                    Calorias = table.Column<string>(type: "text", nullable: false),
                    GrupoAlimentar = table.Column<string>(type: "text", nullable: true),
                    Umidade = table.Column<double>(type: "double", nullable: false),
                    Energia = table.Column<double>(type: "double", nullable: false),
                    Proteína = table.Column<double>(type: "double", nullable: false),
                    Lipídeos = table.Column<double>(type: "double", nullable: false),
                    Colesterol = table.Column<string>(type: "text", nullable: true),
                    Carboidrato = table.Column<double>(type: "double", nullable: false),
                    FibraAlimentar = table.Column<double>(type: "double", nullable: false),
                    Cinzas = table.Column<double>(type: "double", nullable: false),
                    Cálcio = table.Column<double>(type: "double", nullable: false),
                    Magnésio = table.Column<double>(type: "double", nullable: false),
                    Manganês = table.Column<string>(type: "text", nullable: true),
                    Fósforo = table.Column<double>(type: "double", nullable: false),
                    Ferro = table.Column<double>(type: "double", nullable: false),
                    Sódio = table.Column<double>(type: "double", nullable: false),
                    Potássio = table.Column<double>(type: "double", nullable: false),
                    Cobre = table.Column<string>(type: "text", nullable: true),
                    Zinco = table.Column<double>(type: "double", nullable: false),
                    Retinol = table.Column<string>(type: "text", nullable: true),
                    RE = table.Column<string>(type: "text", nullable: true),
                    RAE = table.Column<string>(type: "text", nullable: true),
                    Tiamina = table.Column<string>(type: "text", nullable: true),
                    Riboflavina = table.Column<string>(type: "text", nullable: true),
                    Piridoxina = table.Column<string>(type: "text", nullable: true),
                    Niacina = table.Column<string>(type: "text", nullable: true),
                    VitaminaC = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alimentos");
        }
    }
}
