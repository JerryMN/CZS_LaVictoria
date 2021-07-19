using System;

namespace CZS_LaVictoria_Library.Models
{
    public class HistorialModel
    {
        public string TipoOrden { get; set; }
        public long NumOrden { get; set; }
        public int NumLinea { get; set; }
        public string Producto { get; set; }
        public double Cantidad { get; set; }
        public decimal Precio { get; set; }
        public DateTime Fecha { get; set; }
    }
}
