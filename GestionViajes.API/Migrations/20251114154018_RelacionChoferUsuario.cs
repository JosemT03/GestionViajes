using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionViajes.API.Migrations
{
    /// <inheritdoc />
    public partial class RelacionChoferUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Choferes_UsuarioId",
                table: "Choferes",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Choferes_Usuarios_UsuarioId",
                table: "Choferes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choferes_Usuarios_UsuarioId",
                table: "Choferes");

            migrationBuilder.DropIndex(
                name: "IX_Choferes_UsuarioId",
                table: "Choferes");
        }
    }
}
