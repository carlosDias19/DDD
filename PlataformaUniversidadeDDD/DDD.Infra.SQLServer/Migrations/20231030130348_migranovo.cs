using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDD.Infra.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class migranovo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    CidadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,7)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.CidadeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidade");
        }
    }
}
