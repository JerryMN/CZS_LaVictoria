using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CZS_LaVictoria_Library;

namespace CZS_LaVictoria.CuentasPage
{
    public partial class CalculadoraForm : Form
    {
        decimal _egreso;
        decimal _ingreso;
        int _piezas;

        public CalculadoraForm()
        {
            InitializeComponent();
            DesdePicker.Culture = new CultureInfo("es-MX");
            HastaPicker.Culture = new CultureInfo("es-MX");
            DesdePicker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            HastaPicker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month,
                DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
            GetIngresos();
            GetEgresos();
        }

        void CalcularButton_Click(object sender, EventArgs e)
        {
            _egreso = decimal.Parse(EgresosText.Text.Replace("$", "").Replace(",", ""));
            _ingreso = decimal.Parse(IngresosText.Text.Replace("$", "").Replace(",", ""));
            ProductividadText.Text = (_ingreso / _egreso).ToString(CultureInfo.InvariantCulture);
            _piezas = int.Parse(PiezasText.Text.Replace(",", ""));
            if (_piezas == 0)
            {
                CostoText.Text = "$0.00";
                GananciaText.Text = "$0.00";
            }
            else
            {
                CostoText.Text = (_egreso / _piezas).ToString(CultureInfo.InvariantCulture);
                GananciaText.Text = (_ingreso / _piezas).ToString(CultureInfo.InvariantCulture);
            }
        }

        void GetIngresos()
        {
            Debug.Assert(DesdePicker.Value != null, "DesdePicker.Value != null");
            Debug.Assert(HastaPicker.Value != null, "HastaPicker.Value != null");
            var ingresos =
                GlobalConfig.Connection.Receivable_GetPagosByDate((DateTime) DesdePicker.Value,
                    (DateTime) HastaPicker.Value);
            _ingreso = ingresos.Sum(model => model.Pago);

            IngresosText.Text = _ingreso.ToString(CultureInfo.InvariantCulture);
        }

        void GetEgresos()
        {
            Debug.Assert(DesdePicker.Value != null, "DesdePicker.Value != null");
            Debug.Assert(HastaPicker.Value != null, "HastaPicker.Value != null");
            var egresos =
                GlobalConfig.Connection.Payable_GetPagosByDate((DateTime) DesdePicker.Value,
                    (DateTime) HastaPicker.Value);
            _egreso = egresos.Sum(model => model.Pago);
            EgresosText.Text = _egreso.ToString(CultureInfo.InvariantCulture);
        }
    }
}