namespace CZS_LaVictoria_Library.Models
{
    public class GastoFijoModel
    {
        public int Id { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }

        public GastoFijoModel()
        {
            
        }

        public GastoFijoModel(string concepto, string monto)
        {
            Concepto = concepto;
            var precio = monto.Replace(",", "").Replace("$", "");
            Monto = decimal.Parse(precio);
        }
    }
}