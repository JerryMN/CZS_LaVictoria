namespace CZS_LaVictoria_Library.Models
{
    public class ProveedorModel
    {
        public int IdProvider { get; set; }
        public string Nombre { get; set; }
        public string Teléfono { get; set; }
        public string Correo { get; set; }
        public string Dirección { get; set; }
        public string Responsable { get; set; }
        public string Condiciones { get; set; }

        public ProveedorModel()
        {
        }

        public ProveedorModel(string nombre, string teléfono, string correo, string dirección, string responsable, string condiciones)
        {
            Nombre = nombre;
            Teléfono = teléfono.Replace("(", "").Replace(")", "").Replace(" ", "").Trim();
            Correo = correo;
            Dirección = dirección;
            Responsable = responsable;
            Condiciones = condiciones;
        }
    }
}
