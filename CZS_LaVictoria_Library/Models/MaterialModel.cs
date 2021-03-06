namespace CZS_LaVictoria_Library.Models
{
    public class MaterialModel
    {
        public MaterialModel()
        {
        }

        public MaterialModel(string nombre, string area, string categoría, string cantidadDisponible)
        {
            Nombre = nombre;
            Área = area;
            Categoría = categoría;

            double.TryParse(cantidadDisponible, out var cantidadResult);
            CantidadDisponible = cantidadResult;
        }

        public MaterialModel(string nombre, string area, string categoría, double cantidadDisponible)
        {
            Nombre = nombre;
            Área = area;
            Categoría = categoría;
            CantidadDisponible = cantidadDisponible;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Área { get; set; }
        public string Categoría { get; set; }
        public double CantidadDisponible { get; set; }
    }
}