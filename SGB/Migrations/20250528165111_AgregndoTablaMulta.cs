using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using SGB.Entidades;
using System.Collections.Immutable;

#nullable disable

namespace SGB.Migrations
{
    /// <inheritdoc />
    public partial class AgregndoTablaMulta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable
            (
               name: "Multa",
               columns : table => new
               {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monto = table.Column<double>(type: "float" , nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
               },
               constraints: table =>
               {
                    table.PrimaryKey("PK_Multa", x => x.Id);
                    table.ForeignKey(
                        name : "FK_Multa_Usuarios_UsuarioId",
                        column : x => x.UsuarioId,
                        principalTable : "Usuarios",
                        principalColumn : "Id",
                        onDelete : ReferentialAction.Cascade 
                    );
               }

            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "Multa");
        }
    }
}
