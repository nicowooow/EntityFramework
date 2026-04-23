using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class relacionentrecursoyprofesor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfesorId",
                table: "Cursos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CursoProfesor",
                columns: table => new
                {
                    CursosId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfesoresId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoProfesor", x => new { x.CursosId, x.ProfesoresId });
                    table.ForeignKey(
                        name: "FK_CursoProfesor_Cursos_CursosId",
                        column: x => x.CursosId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursoProfesor_Profesor_ProfesoresId",
                        column: x => x.ProfesoresId,
                        principalTable: "Profesor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CursoProfesor_ProfesoresId",
                table: "CursoProfesor",
                column: "ProfesoresId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CursoProfesor");

            migrationBuilder.DropTable(
                name: "Profesor");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Cursos");
        }
    }
}
