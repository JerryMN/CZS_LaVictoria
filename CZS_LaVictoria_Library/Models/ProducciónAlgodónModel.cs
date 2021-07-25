using System;

namespace CZS_LaVictoria_Library.Models
{
    public class ProducciónAlgodónModel
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Proceso { get; set; }
        public int Turno { get; set; }
        public string Máquina { get; set; }
        public string Operador { get; set; }
        public string MaterialEntra { get; set; }
        public double CantidadEntra { get; set; }
        public string MaterialSale { get; set; }
        public double CantidadSale { get; set; }
        public double Merma { get; set; }
    }
}