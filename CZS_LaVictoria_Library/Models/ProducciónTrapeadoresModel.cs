using System;

namespace CZS_LaVictoria_Library.Models
{
    public class ProducciónTrapeadoresModel
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Turno { get; set; }
        public string Máquina { get; set; }
        public string Operador { get; set; }
        public string Kit { get; set; }
        public int CantidadKit { get; set; }
    }
}