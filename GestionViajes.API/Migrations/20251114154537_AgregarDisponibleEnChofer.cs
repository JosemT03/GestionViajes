using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionViajes.API.Migrations
{
    /// <inheritdoc />
    public partial class AgregarDisponibleEnChofer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disponible",
                table: "Choferes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponible",
                table: "Choferes");
        }
    }
}
