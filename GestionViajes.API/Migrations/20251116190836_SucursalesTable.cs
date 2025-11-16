using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionViajes.API.Migrations
{
    /// <inheritdoc />
    public partial class SucursalesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ChoferId",
                table: "Pedidos",
                column: "ChoferId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_VehiculoId",
                table: "Pedidos",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Choferes_ChoferId",
                table: "Pedidos",
                column: "ChoferId",
                principalTable: "Choferes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Vehiculos_VehiculoId",
                table: "Pedidos",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Choferes_ChoferId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Vehiculos_VehiculoId",
                table: "Pedidos");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ChoferId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_VehiculoId",
                table: "Pedidos");
        }
    }
}
