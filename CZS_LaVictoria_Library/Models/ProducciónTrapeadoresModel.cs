using System;

namespace CZS_LaVictoria_Library.Models
{
    public class ProducciónTrapeadoresModel
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Turno { get; set; }
        public int Máquina { get; set; }
        public string Operador { get; set; }
        public string Bastón { get; set; }
        public double CantidadBastón { get; set; }
        public string Alambre { get; set; }
        public double CantidadAlambre { get; set; }
        public string Bolsa { get; set; }
        public double CantidadBolsa { get; set; }
        public string Mecha { get; set; }
        public double CantidadMecha { get; set; }
        public string Etiqueta { get; set; }
        public double CantidadEtiqueta { get; set; }
        public string Kit { get; set; }
        public int CantidadKit { get; set; }
    }
}
