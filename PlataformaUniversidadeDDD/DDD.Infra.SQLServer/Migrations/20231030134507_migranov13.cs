using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDD.Infra.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class migranov13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Denuncias",
                columns: table => new
                {
                    DenunciasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    CEP = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,7)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denuncias", x => x.DenunciasId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Denuncias");
        }
    }
}
