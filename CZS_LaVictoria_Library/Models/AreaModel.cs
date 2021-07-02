using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZS_ERP_Library.Models
{
    public class AreaModel
    {
        public int IdArea { get; set; }
        public string Area { get; set; }
        public string Responsable { get; set; }

        public AreaModel()
        {
        }

        public AreaModel(string area, string responsable)
        {
            Area = area;
            Responsable = responsable;
        }
    }
}
