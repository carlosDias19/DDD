using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDD.Infra.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class Funcionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisciplinaId",
                table: "Aluno",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [UserSequence]"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_DisciplinaId",
                table: "Aluno",
                column: "DisciplinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Disciplinas_DisciplinaId",
                table: "Aluno",
                column: "DisciplinaId",
                principalTable: "Disciplinas",
                principalColumn: "DisciplinaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Disciplinas_DisciplinaId",
                table: "Aluno");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_DisciplinaId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "DisciplinaId",
                table: "Aluno");
        }
    }
}
