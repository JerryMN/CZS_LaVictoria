namespace CZS_LaVictoria_Library.Models
{
    public class MaterialModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Área { get; set; }
        public string Categoría { get; set; }
        public double CantidadDisponible { get; set; }

        public MaterialModel()
        {
            
        }

        public MaterialModel(string nombre, string area, string categoría, string cantidadDisponible, string peso)
        {
            Nombre = nombre;
            Área = area;
            Categoría = categoría;

            double.TryParse(cantidadDisponible, out var cantidadResult);
            CantidadDisponible = cantidadResult;
        }

        public MaterialModel(string nombre, string area, string categoría, double cantidadDisponible, double peso)
        {
            Nombre = nombre;
            Área = area;
            Categoría = categoría;
            CantidadDisponible = cantidadDisponible;
        }
    }
}
