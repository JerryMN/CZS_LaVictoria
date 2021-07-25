using System;

namespace CZS_LaVictoria_Library.Models
{
    public class PorPagarPagosModel
    {
        public int Id { get; set; }
        public string Factura { get; set; }
        public decimal Pago { get; set; }
        public DateTime FechaPago { get; set; }
    }
}