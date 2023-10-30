using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDD.Infra.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class migranov1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "Cidade",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Cidade");
        }
    }
}
