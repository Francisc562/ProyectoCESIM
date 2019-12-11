using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Final_Registro_CESIM.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Docente",
                columns: table => new
                {
                    docenteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Sexo = table.Column<int>(nullable: true),
                    Especialidad = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docente", x => x.docenteID);
                });

            migrationBuilder.CreateTable(
                name: "Periodo",
                columns: table => new
                {
                    periodoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parcial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodo", x => x.periodoID);
                });

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    tutorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Identificacion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.tutorID);
                });

            migrationBuilder.CreateTable(
                name: "Grado",
                columns: table => new
                {
                    gradoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    docenteID = table.Column<int>(nullable: false),
                    Nivel = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grado", x => x.gradoID);
                    table.ForeignKey(
                        name: "FK_Grado_Docente_docenteID",
                        column: x => x.docenteID,
                        principalTable: "Docente",
                        principalColumn: "docenteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    estudianteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tutorID = table.Column<int>(nullable: false),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Sexo = table.Column<int>(nullable: true),
                    Nacimiento = table.Column<DateTime>(nullable: false),
                    Codigo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.estudianteID);
                    table.ForeignKey(
                        name: "FK_Estudiante_Tutor_tutorID",
                        column: x => x.tutorID,
                        principalTable: "Tutor",
                        principalColumn: "tutorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matricula",
                columns: table => new
                {
                    matriculaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gradoID = table.Column<int>(nullable: false),
                    periodoID = table.Column<int>(nullable: false),
                    estudianteID = table.Column<int>(nullable: false),
                    Grad = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matricula", x => x.matriculaID);
                    table.ForeignKey(
                        name: "FK_Matricula_Estudiante_estudianteID",
                        column: x => x.estudianteID,
                        principalTable: "Estudiante",
                        principalColumn: "estudianteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matricula_Grado_gradoID",
                        column: x => x.gradoID,
                        principalTable: "Grado",
                        principalColumn: "gradoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matricula_Periodo_periodoID",
                        column: x => x.periodoID,
                        principalTable: "Periodo",
                        principalColumn: "periodoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usuarioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Correo = table.Column<string>(nullable: true),
                    Clave = table.Column<string>(nullable: true),
                    matriculaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usuarioID);
                    table.ForeignKey(
                        name: "FK_Usuario_Matricula_matriculaID",
                        column: x => x.matriculaID,
                        principalTable: "Matricula",
                        principalColumn: "matriculaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_tutorID",
                table: "Estudiante",
                column: "tutorID");

            migrationBuilder.CreateIndex(
                name: "IX_Grado_docenteID",
                table: "Grado",
                column: "docenteID");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_estudianteID",
                table: "Matricula",
                column: "estudianteID");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_gradoID",
                table: "Matricula",
                column: "gradoID");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_periodoID",
                table: "Matricula",
                column: "periodoID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_matriculaID",
                table: "Usuario",
                column: "matriculaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Matricula");

            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "Grado");

            migrationBuilder.DropTable(
                name: "Periodo");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropTable(
                name: "Docente");
        }
    }
}
