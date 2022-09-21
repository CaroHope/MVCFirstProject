using Microsoft.EntityFrameworkCore;

namespace AdministracionEmpresaMVC.Models
{
    public class MyDbContext:DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) :
            base(options)
        {

        }
    }
}
