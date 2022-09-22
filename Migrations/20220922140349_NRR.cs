using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdministracionEmpresaMVC.Migrations
{
    public partial class NRR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_ClienteId",
                table: "Facturas");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Facturas",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_ClienteId",
                table: "Facturas",
                newName: "IX_Facturas_ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_ClienteID",
                table: "Facturas",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_ClienteID",
                table: "Facturas");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Facturas",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_ClienteID",
                table: "Facturas",
                newName: "IX_Facturas_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_ClienteId",
                table: "Facturas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
