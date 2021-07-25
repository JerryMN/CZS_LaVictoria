using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CZS_LaVictoria_Library.Annotations;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace CZS_LaVictoria_Library.Models
{
    public class PorPagarModel : INotifyPropertyChanged
    {
        string _condiciones;
        string _estatus;
        string _factura;
        DateTime? _fechaFactura;
        DateTime? _fechaLímite;
        DateTime? _fechaLiquidación;
        decimal _monto;
        string _notas;
        long _numOrden;
        decimal _pagado;
        decimal _pendiente;
        string _proveedor;

        public int Id { get; set; }

        public long NumOrden
        {
            get => _numOrden;
            set
            {
                _numOrden = value;
                OnPropertyChanged(nameof(NumOrden));
            }
        }

        public string Factura
        {
            get => _factura;
            set
            {
                _factura = value;
                OnPropertyChanged(nameof(Factura));
            }
        }

        public DateTime? FechaFactura
        {
            get => _fechaFactura;
            set
            {
                _fechaFactura = value;
                OnPropertyChanged(nameof(FechaFactura));
            }
        }

        public string Proveedor
        {
            get => _proveedor;
            set
            {
                _proveedor = value;
                OnPropertyChanged(nameof(Proveedor));
            }
        }

        public decimal Monto
        {
            get => _monto;
            set
            {
                _monto = value;
                OnPropertyChanged(nameof(Monto));
            }
        }

        public decimal Pagado
        {
            get => _pagado;
            set
            {
                _pagado = value;
                OnPropertyChanged(nameof(Pagado));
            }
        }

        public decimal Pendiente
        {
            get => _pendiente;
            set
            {
                _pendiente = value;
                OnPropertyChanged(nameof(Pendiente));
            }
        }

        public string Condiciones
        {
            get => _condiciones;
            set
            {
                _condiciones = value;
                OnPropertyChanged(nameof(Condiciones));
            }
        }

        public DateTime? FechaLímite
        {
            get => _fechaLímite;
            set
            {
                _fechaLímite = value;
                OnPropertyChanged(nameof(FechaLímite));
            }
        }

        public DateTime? FechaLiquidación
        {
            get => _fechaLiquidación;
            set
            {
                _fechaLiquidación = value;
                OnPropertyChanged(nameof(FechaLiquidación));
            }
        }

        public string Estatus
        {
            get => _estatus;
            set
            {
                _estatus = value;
                OnPropertyChanged(nameof(Estatus));
            }
        }

        public string Notas
        {
            get => _notas;
            set
            {
                _notas = value;
                OnPropertyChanged(nameof(Notas));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}