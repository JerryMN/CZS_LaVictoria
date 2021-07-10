using System.Collections.Generic;

namespace CZS_LaVictoria_Library.Models
{
    public class MezclaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<MaterialModel> Materiales { get; set; } = new List<MaterialModel>();
        public List<double> Cantidades { get; set; } = new List<double>();
        public double CantidadMezcla { get; set; }

        public MezclaModel()
        {
        }
    }
}
