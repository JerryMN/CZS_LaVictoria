using System;
using System.ComponentModel;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace CZS_LaVictoria_Library.Models
{
    public class OrdenCompraLíneaModel : INotifyPropertyChanged
    {
        int _numLinea;
        string _producto;
        double _cantidadOrden;
        double _cantidadRecibida;
        double _cantidadPendiente;
        decimal _precioUnitario;
        bool _iva;
        decimal _subtotal;
        DateTime? _fechaEntrega;
        DateTime? _fechaUltRecepción;
        DateTime? _fechaCancelación;
        string _estatus;

        public string Proveedor { get; set; }
        public string Area { get; set; }
        public long NumOrden { get; set;  }

        public int NumLinea
        {
            get => _numLinea;
            set { _numLinea = value; RaisePropertyChanged("NumLinea"); }
        }

        public string Producto
        {
            get => _producto;
            set { _producto = value; RaisePropertyChanged("Producto"); }
        }

        public double CantidadOrden
        {
            get => _cantidadOrden;
            set { _cantidadOrden = value; RaisePropertyChanged("CantidadOrden"); }
        }

        public double CantidadRecibida
        {
            get => _cantidadRecibida;
            set { _cantidadRecibida = value; RaisePropertyChanged("CantidadRecibida"); }
        }

        public double CantidadPendiente
        {
            get => _cantidadPendiente;
            set { _cantidadPendiente = value; RaisePropertyChanged("CantidadPendiente"); }
        }

        public decimal PrecioUnitario
        {
            get => _precioUnitario;
            set { _precioUnitario = value; RaisePropertyChanged("PrecioUnitario"); }
        }

        public bool Iva
        {
            get => _iva;
            set { _iva = value; RaisePropertyChanged("Iva"); }
        }

        public decimal Subtotal
        {
            get => _subtotal;
            set { _subtotal = value; RaisePropertyChanged("Subtotal"); }
        }

        public DateTime? FechaEntrega
        {
            get => _fechaEntrega;
            set { _fechaEntrega = value; RaisePropertyChanged("FechaEntrega"); }
        }

        public DateTime? FechaUltRecepción
        {
            get => _fechaUltRecepción;
            set { _fechaUltRecepción = value; RaisePropertyChanged("FechaUltRecepción"); }
        }

        public DateTime? FechaCancelación
        {
            get => _fechaCancelación;
            set { _fechaCancelación = value; RaisePropertyChanged("FechaCancelación"); }
        }

        public string Estatus
        {
            get => _estatus;
            set { _estatus = value; RaisePropertyChanged("Estatus"); }
        }


        public OrdenCompraLíneaModel()
        {
            
        }

        public OrdenCompraLíneaModel(int numLinea, string producto, string cantidadOrden, string precioUnitario)
        {
            NumLinea = numLinea;
            Producto = producto;
            CantidadOrden = double.Parse(cantidadOrden);
            var precio = precioUnitario.Replace("$", "").Replace(",", "");
            PrecioUnitario = decimal.Parse(precio);
            Iva = false;
            Subtotal = (decimal) CantidadOrden * PrecioUnitario;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
