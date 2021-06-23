using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZS_ERP_Library.Models
{
    public class ProveedorModel
    {
        public int IdProvider { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Responsable { get; set; }

        public ProveedorModel()
        {
            
        }

        public ProveedorModel(string nombre, string teléfono, string correo, string dirección, string responsable)
        {
            Nombre = nombre;
            Telefono = teléfono.Replace("(", "").Replace(")", "").Replace(" ", "").Trim();
            Correo = correo;
            Direccion = dirección;
            Responsable = responsable;
        }
    }
}
