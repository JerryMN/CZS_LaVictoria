using System;
using System.Collections.Generic;

namespace CZS_LaVictoria_Library.Models
{
    public class OrdenVentaModel
    {
        public int Id { get; set; }
        public long NumOrden { get; set; }
        public string TipoOrden { get; set; }
        public string Area { get; set; }
        public string Cliente { get; set; }
        public string Transporte { get; set; }
        public string PuestoEn { get; set; }
        public string Presentación { get; set; }
        public DateTime FechaOrden { get; set; }
        public DateTime FechaEntrega { get; set; }
        public List<OrdenVentaLíneaModel> Líneas { get; set; } = new List<OrdenVentaLíneaModel>();
    }
}
