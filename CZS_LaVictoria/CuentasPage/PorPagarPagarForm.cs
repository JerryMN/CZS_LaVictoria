using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.CuentasPage
{
    public partial class PorPagarPagarForm : Form
    {
        readonly PorPagarModel _línea;
        decimal _monto;
        decimal _pagado;
        decimal _pendiente;
        decimal _nuevo;

        public PorPagarPagarForm(PorPagarModel línea)
        {
            InitializeComponent();
            _línea = línea;
            LoadForm();
            FechaFacturaPicker.Culture = new CultureInfo("es-MX");
            FechaPagoPicker.Culture = new CultureInfo("es-MX");
        }

        #region Events

        void InputChanged(object sender, EventArgs e)
        {
            _monto = decimal.Parse(MontoText.Text.Replace("$", "").Replace(",", ""));
            _pagado = decimal.Parse(PagadoText.Text.Replace("$", "").Replace(",", ""));
            _pendiente = _monto - _pagado;
            _línea.Monto = _monto;
            _línea.Pagado = _pagado;
            _línea.Pendiente = _pendiente;
            PendienteText.Text = _pendiente.ToString(CultureInfo.CurrentUICulture);
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            Debug.Assert(FechaPagoPicker.Value != null, "FechaPagoPicker.Value != null");
            var registro = new PorPagarPagosModel
            {
                Factura = FacturaText.Text == "" ? _línea.NumOrden.ToString() : FacturaText.Text,
                Pago = _nuevo,
                FechaPago = (DateTime) FechaPagoPicker.Value
            };

            _línea.Factura = FacturaText.Text;
            _línea.FechaFactura = _línea.Factura == "" ? null : FechaFacturaPicker.Value;
            _línea.Pagado = _nuevo + _pagado;
            _línea.Pendiente = _pendiente - _nuevo;
            if (_línea.Pendiente == decimal.Zero)
            {
                _línea.FechaLiquidación = registro.FechaPago;
                _línea.Estatus = "Pagado";
            }
            else
            {
                _línea.FechaLiquidación = null;
                _línea.Estatus = "Parcial";
            }

            _línea.Notas = NotasText.Text;

            var saveSuccess = GlobalConfig.Connection.Payable_Create(_línea, registro);

            if (saveSuccess)
            {
                MsgBox.Text = "Pago registrado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar pago.";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void MsgBoxTimer_Tick(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBoxTimer.Stop();
            Dispose();
        }

        #endregion

        #region Methods

        void LoadForm()
        {
            NumOrdenText.Text = _línea.NumOrden.ToString();
            FacturaText.Text = _línea.Factura;
            FechaFacturaPicker.Value = _línea.FechaFactura;
            MontoText.Text = _línea.Monto.ToString(CultureInfo.CurrentUICulture);
            PagadoText.Text = _línea.Pagado.ToString(CultureInfo.CurrentUICulture);
            PendienteText.Text = _línea.Pendiente.ToString(CultureInfo.CurrentUICulture);
            NotasText.Text = _línea.Notas;
            MontoText.TextChanged += InputChanged;
            PagadoText.TextChanged += InputChanged;
            NuevoText.TextChanged += InputChanged;
        }

        bool ValidateForm()
        {
            var output = true;
            MsgBox.Text = "";

            if (NuevoText.Text == "$0.00" || !decimal.TryParse(NuevoText.Text.Replace("$", "").Replace(",", ""), out _nuevo))
            {
                output = false;
                MsgBox.Text += "Ingresa el monto del pago a registrar.\n";
            }

            if (_nuevo > _línea.Pendiente)
            {
                output = false;
                MsgBox.Text += "La cantidad del pago no puede ser mayor a la cantidad debida.\n";
            }

            return output;
        }

        #endregion
    }
}
