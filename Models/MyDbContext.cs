using Microsoft.EntityFrameworkCore;

namespace AdministracionEmpresaMVC.Models
{
    public class MyDbContext:DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) :
            base(options)
        {

        }
    }
}
