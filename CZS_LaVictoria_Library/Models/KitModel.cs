using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZS_LaVictoria_Library.Models
{
    public class KitModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<MaterialModel> Materiales { get; set; } = new List<MaterialModel>();
        public List<double> Cantidades { get; set; } = new List<double>();
    }
}
