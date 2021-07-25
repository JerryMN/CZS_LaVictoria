using System;

namespace CZS_LaVictoria_Library.Models
{
    public class ProducciónPlásticosModel
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Proceso { get; set; }
        public int Turno { get; set; }
        public string Máquina { get; set; }
        public string Operador { get; set; }
        public string MaterialEntra { get; set; }
        public double CantidadEntra { get; set; }
        public string FibraEntra { get; set; }
        public double CantidadFibraEntra { get; set; }
        public string MaterialSale { get; set; }
        public double CantidadSale { get; set; }
        public double PesoPromedio { get; set; }
        public int PiezasBuenas { get; set; }
        public int PiezasMalas { get; set; }
        public double MermaBases { get; set; }
        public double MermaFibra { get; set; }
        public string TipoAlambre { get; set; }
        public int RollosAlambre { get; set; }
        public string TipoCaja { get; set; }
        public int CantidadCajas { get; set; }
        public double MermaMoler { get; set; }
        public double MermaFinal { get; set; }
    }
}