namespace CZS_LaVictoria_Library.Models
{
    public class PurchaseOrderLineModel
    {
        public long NumOrden { get; private set; }
        public int NumLinea { get; set; }
        public string Producto { get; set; }
        public double CantidadOrden { get; set; }
        public double CantidadEntregada { get; set; }
        public double CantidadPendiente { get; set; }
        public decimal PrecioUnitario { get; set; }
        public bool Iva { get; set; }
        public decimal Subtotal { get; set; }

        public PurchaseOrderLineModel()
        {
            
        }

        public PurchaseOrderLineModel(int numLinea, string producto, string cantidadOrden, string precioUnitario)
        {
            NumLinea = numLinea;
            Producto = producto;
            CantidadOrden = double.Parse(cantidadOrden);
            var precio = precioUnitario.Replace("$", "").Replace(",", "");
            PrecioUnitario = decimal.Parse(precio);
            Iva = false;
            Subtotal = (decimal) CantidadOrden * PrecioUnitario;
        }
    }
}
