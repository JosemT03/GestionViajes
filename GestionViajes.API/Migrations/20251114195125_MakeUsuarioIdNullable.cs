using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionViajes.API.Migrations
{
    /// <inheritdoc />
    public partial class MakeUsuarioIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choferes_Usuarios_UsuarioId",
                table: "Choferes");

            // 2. Volver columna nullable
            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Choferes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            // 3. Crear FK nueva con SET NULL
            migrationBuilder.AddForeignKey(
                name: "FK_Choferes_Usuarios_UsuarioId",
                table: "Choferes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
              name: "FK_Choferes_Usuarios_UsuarioId",
              table: "Choferes");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Choferes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Choferes_Usuarios_UsuarioId",
                table: "Choferes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
