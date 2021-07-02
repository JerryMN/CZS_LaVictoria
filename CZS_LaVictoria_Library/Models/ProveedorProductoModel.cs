using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZS_ERP_Library.Models
{
    public class ProveedorProductoModel
    {
        public int IdProviderProduct { get; set; }
        public string MaterialExterno { get; set; }
        public string MaterialInterno { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Area { get; set; }
        public int IdProvider { get; set; }
        public string Proveedor { get; set; }

        public ProveedorProductoModel()
        {
        }

        public ProveedorProductoModel(string materialExterno, string materialInterno, string precioUnitario, string area)
        {
            MaterialExterno = materialExterno;
            MaterialInterno = materialInterno;

            decimal.TryParse(precioUnitario.Replace("$", "").Replace(",", "").Trim(), out var precioResult);
            PrecioUnitario = precioResult;

            Area = area;
        }
    }
}
