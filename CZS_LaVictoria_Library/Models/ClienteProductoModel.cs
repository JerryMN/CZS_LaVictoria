namespace CZS_LaVictoria_Library.Models
{
    public class ClienteProductoModel
    {
        public int Id { get; set; }
        public string ProductoInterno { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Área { get; set; }
        public int IdClient { get; set; }
        public string Cliente { get; set; }

        public ClienteProductoModel()
        {
        }

        public ClienteProductoModel(string productoInterno, string precioUnitario, string area)
        {
            ProductoInterno = productoInterno;

            decimal.TryParse(precioUnitario.Replace("$", "").Replace(",", "").Trim(), out var precioResult);
            PrecioUnitario = precioResult;

            Área = area;
        }
    }
}
