using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionLibreriaPrueba.Migrations
{
    /// <inheritdoc />
    public partial class AddTableComentario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    ComentarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComentarioContenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComentarioFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LibroID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.ComentarioID);
                    table.ForeignKey(
                        name: "FK_Comentarios_Libros_LibroID",
                        column: x => x.LibroID,
                        principalTable: "Libros",
                        principalColumn: "LibroID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_LibroID",
                table: "Comentarios",
                column: "LibroID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentarios");
        }
    }
}
