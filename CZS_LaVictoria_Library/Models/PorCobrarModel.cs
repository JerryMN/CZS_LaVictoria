using CZS_LaVictoria_Library.Annotations;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace CZS_LaVictoria_Library.Models
{
    public class PorCobrarModel : INotifyPropertyChanged
    {
        long _numOrden;
        string _factura;
        DateTime? _fechaFactura;
        string _cliente;
        decimal _monto;
        decimal _pagado;
        decimal _pendiente;
        DateTime? _fechaLiquidación;
        string _estatus;
        string _notas;

        public long NumOrden
        {
            get => _numOrden;
            set { _numOrden = value; OnPropertyChanged(nameof(NumOrden)); }
        }

        public string Factura
        {
            get => _factura;
            set { _factura = value; OnPropertyChanged(nameof(Factura)); }
        }

        public DateTime? FechaFactura
        {
            get => _fechaFactura;
            set { _fechaFactura = value; OnPropertyChanged(nameof(FechaFactura)); }
        }

        public string Cliente
        {
            get => _cliente;
            set { _cliente = value; OnPropertyChanged(nameof(Cliente)); }
        }

        public decimal Monto
        {
            get => _monto;
            set { _monto = value; OnPropertyChanged(nameof(Monto)); }
        }

        public decimal Pagado
        {
            get => _pagado;
            set { _pagado = value; OnPropertyChanged(nameof(Pagado)); }
        }

        public decimal Pendiente
        {
            get => _pendiente;
            set { _pendiente = value; OnPropertyChanged(nameof(Pendiente)); }
        }

        public DateTime? FechaLiquidación
        {
            get => _fechaLiquidación;
            set { _fechaLiquidación = value; OnPropertyChanged(nameof(FechaLiquidación)); }
        }

        public string Estatus
        {
            get => _estatus;
            set { _estatus = value; OnPropertyChanged(nameof(Estatus)); }
        }

        public string Notas
        {
            get => _notas;
            set { _notas = value; OnPropertyChanged(nameof(Notas)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
