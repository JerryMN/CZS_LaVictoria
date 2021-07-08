using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZS_LaVictoria_Library.Models
{
    public class HistorialModel
    {
        public string TipoOrden { get; set; }
        public long NumOrden { get; set; }
        public int NumLinea { get; set; }
        public string Producto { get; set; }
        public double Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
