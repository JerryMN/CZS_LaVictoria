namespace CZS_LaVictoria_Library.Models
{
    public class ProveedorProductoModel
    {
        public ProveedorProductoModel()
        {
        }

        public ProveedorProductoModel(string materialExterno, string materialInterno, string precioUnitario,
            string area, string categoría)
        {
            MaterialExterno = materialExterno;
            MaterialInterno = materialInterno;

            decimal.TryParse(precioUnitario.Replace("$", "").Replace(",", "").Trim(), out var precioResult);
            PrecioUnitario = precioResult;

            Área = area;
            Categoría = categoría;
        }

        public int Id { get; set; }
        public string MaterialExterno { get; set; }
        public string MaterialInterno { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Área { get; set; }
        public string Categoría { get; set; }
        public int IdSupplier { get; set; }
        public string Proveedor { get; set; }
    }
}