namespace CZS_LaVictoria_Library.Models
{
    public class ClienteProductoModel
    {
        public int IdProduct { get; set; }
        public string ProductoInterno { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Area { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }

        public ClienteProductoModel()
        {
        }

        public ClienteProductoModel(string productoInterno, string precioUnitario, string area)
        {
            ProductoInterno = productoInterno;

            decimal.TryParse(precioUnitario.Replace("$", "").Replace(",", "").Trim(), out var precioResult);
            PrecioUnitario = precioResult;

            Area = area;
        }
    }
}
