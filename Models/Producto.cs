using System.Data.SqlTypes;

namespace AdministracionEmpresaMVC.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public string FechaGarantia { get; set; }
        public char Status { get; set; }

    }
}
