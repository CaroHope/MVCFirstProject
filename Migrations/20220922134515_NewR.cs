using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdministracionEmpresaMVC.Migrations
{
    public partial class NewR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_DetalleFacturas_DetalleFacturaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_DetalleFacturaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "DetalleFacturaId",
                table: "Productos");

            migrationBuilder.AddColumn<string>(
                name: "FechaGarantia",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "DetalleFacturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "DetalleFacturas",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_ProductoId",
                table: "DetalleFacturas",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFacturas_Productos_ProductoId",
                table: "DetalleFacturas",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFacturas_Productos_ProductoId",
                table: "DetalleFacturas");

            migrationBuilder.DropIndex(
                name: "IX_DetalleFacturas_ProductoId",
                table: "DetalleFacturas");

            migrationBuilder.DropColumn(
                name: "FechaGarantia",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "DetalleFacturas");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "DetalleFacturas");

            migrationBuilder.AddColumn<int>(
                name: "DetalleFacturaId",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_DetalleFacturaId",
                table: "Productos",
                column: "DetalleFacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_DetalleFacturas_DetalleFacturaId",
                table: "Productos",
                column: "DetalleFacturaId",
                principalTable: "DetalleFacturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
