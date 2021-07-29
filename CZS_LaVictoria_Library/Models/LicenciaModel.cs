using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CZS_LaVictoria_Library.Annotations;

namespace CZS_LaVictoria_Library.Models
{
    public class LicenciaModel : INotifyPropertyChanged
    {
        string _contacto;
        string _correo;
        string _empresa;
        bool _habilitado;
        int _id;
        decimal _precio;
        DateTime _sigPago;
        string _teléfono;
        DateTime _ultPago;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Empresa
        {
            get => _empresa;
            set
            {
                _empresa = value;
                OnPropertyChanged(nameof(Empresa));
            }
        }

        public string Contacto
        {
            get => _contacto;
            set
            {
                _contacto = value;
                OnPropertyChanged(nameof(Contacto));
            }
        }

        public string Teléfono
        {
            get => _teléfono;
            set
            {
                _teléfono = value;
                OnPropertyChanged(nameof(Teléfono));
            }
        }

        public string Correo
        {
            get => _correo;
            set
            {
                _correo = value;
                OnPropertyChanged(nameof(Correo));
            }
        }

        public decimal Precio
        {
            get => _precio;
            set
            {
                _precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }

        public DateTime UltPago
        {
            get => _ultPago;
            set
            {
                _ultPago = value;
                OnPropertyChanged(nameof(UltPago));
            }
        }

        public DateTime SigPago
        {
            get => _sigPago;
            set
            {
                _sigPago = value;
                OnPropertyChanged(nameof(SigPago));
            }
        }

        public bool Habilitado
        {
            get => _habilitado;
            set
            {
                _habilitado = value;
                OnPropertyChanged(nameof(Habilitado));
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