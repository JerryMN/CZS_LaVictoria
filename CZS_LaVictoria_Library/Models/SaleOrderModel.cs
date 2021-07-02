using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZS_ERP_Library.Models
{
    public class SaleOrderModel
    {
        public int UniqueIdOrder { get; set; }
        public long NumOrden { get; set; }
        public string TipoOrden { get; set; }
        public string Area { get; set; }
        public string Cliente { get; set; }
        public string Transporte { get; set; }
        public string PuestoEn { get; set; }
        public string Presentación { get; set; }
        public DateTime FechaOrden { get; set; }
        public DateTime FechaEntrega { get; set; }
        public List<SaleOrderLineModel> Líneas { get; set; } = new List<SaleOrderLineModel>();
    }
}
