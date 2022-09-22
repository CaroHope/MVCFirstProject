using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdministracionEmpresaMVC.Migrations
{
    public partial class NR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Detalle",
                table: "DetalleFacturas",
                newName: "Descripcion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "DetalleFacturas",
                newName: "Detalle");
        }
    }
}
