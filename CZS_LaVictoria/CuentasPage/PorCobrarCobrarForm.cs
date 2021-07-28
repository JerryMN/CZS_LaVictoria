using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.CuentasPage
{
    public partial class PorCobrarCobrarForm : Form
    {
        readonly PorCobrarModel _línea;
        decimal _cobrado;
        decimal _monto;
        decimal _nuevo;
        decimal _pendiente;

        public PorCobrarCobrarForm(PorCobrarModel línea)
        {
            InitializeComponent();
            _línea = línea;
            LoadForm();
            FechaFacturaPicker.Culture = new CultureInfo("es-MX");
            FechaCobroPicker.Culture = new CultureInfo("es-MX");
        }

        #region Events

        void InputChanged(object sender, EventArgs e)
        {
            _monto = decimal.Parse(MontoText.Text.Replace("$", "").Replace(",", ""));
            _cobrado = decimal.Parse(CobradoText.Text.Replace("$", "").Replace(",", ""));
            _pendiente = _monto - _cobrado;
            _línea.Monto = _monto;
            _línea.Cobrado = _cobrado;
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

            Debug.Assert(FechaCobroPicker.Value != null, "FechaPagoPicker.Value != null");
            var registro = new PorCobrarPagosModel
            {
                Factura = FacturaText.Text == "" ? _línea.NumOrden.ToString() : FacturaText.Text,
                Pago = _nuevo,
                FechaPago = (DateTime) FechaCobroPicker.Value
            };

            _línea.Factura = FacturaText.Text;
            _línea.FechaFactura = _línea.Factura == "" ? null : FechaFacturaPicker.Value;
            _línea.Cobrado = _nuevo + _cobrado;
            _línea.Pendiente = _pendiente - _nuevo;
            if (_línea.Pendiente == decimal.Zero)
            {
                _línea.FechaLiquidación = registro.FechaPago;
                _línea.Estatus = "Cobrado";
            }
            else
            {
                _línea.FechaLiquidación = null;
                _línea.Estatus = "Parcial";
            }

            _línea.Notas = NotasText.Text;

            var saveSuccess = GlobalConfig.Connection.Receivable_Create(_línea, registro);

            if (saveSuccess)
            {
                MsgBox.Text = "Cobro registrado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar cobro.";
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
            CobradoText.Text = _línea.Cobrado.ToString(CultureInfo.CurrentUICulture);
            PendienteText.Text = _línea.Pendiente.ToString(CultureInfo.CurrentUICulture);
            NotasText.Text = _línea.Notas;
            MontoText.TextChanged += InputChanged;
            CobradoText.TextChanged += InputChanged;
            NuevoText.TextChanged += InputChanged;
        }

        bool ValidateForm()
        {
            var output = true;
            MsgBox.Text = "";

            if (NuevoText.Text == "$0.00" ||
                !decimal.TryParse(NuevoText.Text.Replace("$", "").Replace(",", ""), out _nuevo))
            {
                output = false;
                MsgBox.Text += "Ingresa el monto del cobro a registrar.\n";
            }

            if (_nuevo > _línea.Pendiente)
            {
                output = false;
                MsgBox.Text += "La cantidad del cobro no puede ser mayor a la cantidad debida.\n";
            }

            return output;
        }

        #endregion
    }
}