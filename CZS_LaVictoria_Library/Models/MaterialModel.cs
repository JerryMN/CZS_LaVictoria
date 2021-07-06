namespace CZS_LaVictoria_Library.Models
{
    public class MaterialModel
    {
        public int IdMaterial { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
        public string Categoría { get; set; }
        public double CantidadDisponible { get; set; }
        public double Peso { get; set; }

        public MaterialModel()
        {
            
        }

        public MaterialModel(string nombre, string area, string categoría, string cantidadDisponible, string peso)
        {
            Nombre = nombre;
            Area = area;
            Categoría = categoría;

            double.TryParse(cantidadDisponible, out var cantidadResult);
            CantidadDisponible = cantidadResult;

            double.TryParse(peso, out var pesoResult);
            Peso = pesoResult;
        }

        public MaterialModel(string nombre, string area, string categoría, double cantidadDisponible, double peso)
        {
            Nombre = nombre;
            Area = area;
            Categoría = categoría;
            CantidadDisponible = cantidadDisponible;
            Peso = peso;
        }
    }
}
