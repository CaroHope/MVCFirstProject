using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace AdministracionEmpresaMVC.Models
{
    public class Factura
    {
        public int Id { set; get; }
        public int Monto { set; get; }
        public string fecha { set; get; }

        public string Empresa { get; set; }
        public int ClienteID { set; get; }
        public Cliente Cliente { set; get; }
        public char Status { set; get; }
    }
}
