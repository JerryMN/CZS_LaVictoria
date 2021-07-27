using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZS_LaVictoria_Library.Models
{
    public class RetrabajoPlásticosModel
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string PiezaMala { get; set; }
        public double Piezas { get; set; }
        public string Proceso { get; set; }
        public double Peso { get; set; }
    }
}
