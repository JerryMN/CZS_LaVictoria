namespace CZS_LaVictoria_Library.Models
{
    public class SaleOrderLineModel
    {
        public int NumLinea { get; set; }
        public string Producto { get; set; }
        public double CantidadOrden { get; set; }
        public double CantidadEntregada { get; set; }
        public double CantidadPendiente { get; set; }
        public decimal PrecioUnitario { get; set; }
        public bool Iva { get; set; }
        public decimal Subtotal { get; set; }
    }
}
