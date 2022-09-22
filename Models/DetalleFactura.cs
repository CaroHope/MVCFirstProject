namespace AdministracionEmpresaMVC.Models
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int FacturaID { get; set; }
        public Factura Factura { get; set; }

        public string Descripcion { get; set; }
        public char Status { get; set; }

        public ICollection<Producto> Productos { get; set; }
        
    }
}
