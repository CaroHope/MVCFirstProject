using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdministracionEmpresaMVC.Migrations
{
    public partial class ArregladoR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFacturas_Facturas_FacturaId",
                table: "DetalleFacturas");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFacturas_Productos_ProductoId",
                table: "DetalleFacturas");

            migrationBuilder.DropIndex(
                name: "IX_DetalleFacturas_ProductoId",
                table: "DetalleFacturas");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "DetalleFacturas");

            migrationBuilder.RenameColumn(
                name: "FacturaId",
                table: "DetalleFacturas",
                newName: "FacturaID");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleFacturas_FacturaId",
                table: "DetalleFacturas",
                newName: "IX_DetalleFacturas_FacturaID");

            migrationBuilder.AddColumn<int>(
                name: "DetalleFacturaId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_DetalleFacturaId",
                table: "Productos",
                column: "DetalleFacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFacturas_Facturas_FacturaID",
                table: "DetalleFacturas",
                column: "FacturaID",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_DetalleFacturas_DetalleFacturaId",
                table: "Productos",
                column: "DetalleFacturaId",
                principalTable: "DetalleFacturas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFacturas_Facturas_FacturaID",
                table: "DetalleFacturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_DetalleFacturas_DetalleFacturaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_DetalleFacturaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "DetalleFacturaId",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "FacturaID",
                table: "DetalleFacturas",
                newName: "FacturaId");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleFacturas_FacturaID",
                table: "DetalleFacturas",
                newName: "IX_DetalleFacturas_FacturaId");

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "DetalleFacturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_ProductoId",
                table: "DetalleFacturas",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFacturas_Facturas_FacturaId",
                table: "DetalleFacturas",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFacturas_Productos_ProductoId",
                table: "DetalleFacturas",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
