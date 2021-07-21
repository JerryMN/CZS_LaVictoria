using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.CuentasPage
{
    public partial class PorPagarAgregarForm : Form
    {
        decimal _monto;
        decimal _pagado;

        public PorPagarAgregarForm()
        {
            InitializeComponent();
            GetCondiciones();
        }

        #region Events

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            Debug.Assert(FechaFacturaPicker.Value != null, "FechaFacturaPicker.Value != null");
            Debug.Assert(FechaLimitePicker.Value != null, "FechaLimitePicker.Value != null");
            var línea = new PorPagarModel
            {
                Factura = FacturaText.Text,
                FechaFactura = (DateTime) FechaFacturaPicker.Value,
                Proveedor = ProveedorText.Text,
                Monto = _monto,
                Pagado = _pagado,
                Condiciones = CondicionesCombo.Text,
                FechaLímite = (DateTime) FechaLimitePicker.Value,
                Estatus = _monto == _pagado ? "Pagado" : "Pendiente",
                Notas = NotasText.Text
            };

            var saveSuccess = GlobalConfig.Connection.Payable_Create(línea);

            if (saveSuccess)
            {
                ClearForm();
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
        }

        #endregion

        #region Methods

        void GetCondiciones()
        {
            var condiciones = GlobalConfig.Connection.Proveedor_GetDistinctCondiciones();
            foreach (var condición in condiciones)
            {
                CondicionesCombo.Items.Add(condición);
            }
        }

        bool ValidateForm()
        {
            var output = true;
            MsgBox.Text = "";

            if (ProveedorText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del proveedor.\n";
            }

            if (MontoText.Text == "$0.00" || !decimal.TryParse(MontoText.Text.Replace("$", "").Replace(",", ""), out _monto))
            {
                output = false;
                MsgBox.Text += "Ingresa el monto del pago a registrar.\n";
            }

            if (!decimal.TryParse(PagadoText.Text.Replace("$", "").Replace(",", ""), out _pagado))
            {
                output = false;
                MsgBox.Text += "Ingresa el monto del pago que ya fue pagado.\n";
            }

            return output;
        }

        void ClearForm()
        {
            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox box)
                        box.Clear();
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.Text = "";
                        comboBox.SelectedItem = null;
                    }
                    else
                        Func(control.Controls);
            }

            Func(Controls);
            FechaFacturaPicker.Value = DateTime.Today;
            FechaLimitePicker.Value = DateTime.Today;
            MontoText.Text = "0";
            PagadoText.Text = "0";
        }

        #endregion
    }
}
