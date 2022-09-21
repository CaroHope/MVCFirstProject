using Microsoft.EntityFrameworkCore;

namespace AdministracionEmpresaMVC.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) :
            base(options)
        {

        }
    }
}
