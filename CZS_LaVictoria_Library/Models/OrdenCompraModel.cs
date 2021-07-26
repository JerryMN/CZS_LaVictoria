using System;
using System.Collections.Generic;

namespace CZS_LaVictoria_Library.Models
{
    public class OrdenCompraModel
    {
        public int Id { get; set; }
        public long NumOrden { get; set; }
        public string TipoOrden { get; set; }
        public string Área { get; set; }
        public string Proveedor { get; set; }
        public string Condiciones { get; set; }
        public DateTime FechaOrden { get; set; }
        public List<OrdenCompraLíneaModel> Líneas { get; set; } = new List<OrdenCompraLíneaModel>();
        public string Notas { get; set; }
    }
}