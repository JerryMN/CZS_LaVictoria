using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CZS_LaVictoria_Library.Annotations;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace CZS_LaVictoria_Library.Models
{
    public class PorCobrarModel : INotifyPropertyChanged
    {
        string _cliente;
        decimal _cobrado;
        string _estatus;
        string _factura;
        DateTime? _fechaFactura;
        DateTime? _fechaLiquidación;
        decimal _monto;
        string _notas;
        long _numOrden;
        decimal _pendiente;

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

        public string Cliente
        {
            get => _cliente;
            set
            {
                _cliente = value;
                OnPropertyChanged(nameof(Cliente));
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

        public decimal Cobrado
        {
            get => _cobrado;
            set
            {
                _cobrado = value;
                OnPropertyChanged(nameof(Cobrado));
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