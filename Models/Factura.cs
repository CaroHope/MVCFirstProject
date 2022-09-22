namespace AdministracionEmpresaMVC.Models
{
    public class Factura
    {
        public int Id { set; get; }
        public int Monto { set; get; }
        public DateTime fecha { set; get; }
        public char Status { set; get; }

        public int ClienteId { set; get; }
        public Cliente Cliente { set; get; }
    }
}
