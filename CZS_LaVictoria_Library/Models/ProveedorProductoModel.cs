namespace CZS_LaVictoria_Library.Models
{
    public class ProveedorProductoModel
    {
        public int Id { get; set; }
        public string MaterialExterno { get; set; }
        public string MaterialInterno { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Area { get; set; }
        public string Categoría { get; set; }
        public int IdProvider { get; set; }
        public string Proveedor { get; set; }

        public ProveedorProductoModel()
        {
        }

        public ProveedorProductoModel(string materialExterno, string materialInterno, string precioUnitario, string area, string categoría)
        {
            MaterialExterno = materialExterno;
            MaterialInterno = materialInterno;

            decimal.TryParse(precioUnitario.Replace("$", "").Replace(",", "").Trim(), out var precioResult);
            PrecioUnitario = precioResult;

            Area = area;
            Categoría = categoría;
        }
    }
}
