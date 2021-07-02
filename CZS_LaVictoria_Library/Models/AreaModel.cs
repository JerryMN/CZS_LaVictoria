namespace CZS_LaVictoria_Library.Models
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
