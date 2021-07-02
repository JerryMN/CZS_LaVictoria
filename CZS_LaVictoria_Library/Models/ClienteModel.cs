using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZS_ERP_Library.Models
{
    public class ClienteModel
    {
        public int IdClient { get; set; }
        public string Nombre { get; set; }
        public string Atención { get; set; }
        public string Correo { get; set; }
        public string Teléfono { get; set; }
        public string TeléfonoDos { get; set; }
        public string Dirección { get; set; }
        public string Ciudad { get; set; }

        public ClienteModel()
        {
        }

        public ClienteModel(string nombre, string atención, string correo, string teléfono, string teléfonoDos, string dirección, string ciudad)
        {
            Nombre = nombre;
            Atención = atención;
            Correo = correo;
            Teléfono = teléfono.Replace("(", "").Replace(")", "").Replace(" ", "").Trim();
            TeléfonoDos = teléfonoDos.Replace("(", "").Replace(")", "").Replace(" ", "").Trim();
            Dirección = dirección;
            Ciudad = ciudad;
        }
    }
}
