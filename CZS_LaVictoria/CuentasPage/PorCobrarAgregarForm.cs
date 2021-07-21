using CZS_LaVictoria_Library.Models;
using CZS_LaVictoria_Library;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace CZS_LaVictoria.CuentasPage
{
    public partial class PorCobrarAgregarForm : Form
    {
        decimal _monto;
        decimal _cobrado;

        public PorCobrarAgregarForm()
        {
            InitializeComponent();
            FechaFacturaPicker.Culture = new CultureInfo("es-MX");
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
            var línea = new PorCobrarModel()
            {
                Factura = FacturaText.Text,
                FechaFactura = (DateTime)FechaFacturaPicker.Value,
                Cliente = ClienteText.Text,
                Monto = _monto,
                Cobrado = _cobrado,
                Pendiente = _monto - _cobrado,
                Estatus = _monto == _cobrado ? "Pagado" : "Pendiente",
                Notas = NotasText.Text
            };

            var saveSuccess = GlobalConfig.Connection.Receivable_Create(línea);

            if (saveSuccess)
            {
                ClearForm();
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
        }

        #endregion

        #region Methods

        bool ValidateForm()
        {
            var output = true;
            MsgBox.Text = "";

            if (ClienteText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del cliente.\n";
            }

            if (MontoText.Text == "$0.00" || !decimal.TryParse(MontoText.Text.Replace("$", "").Replace(",", ""), out _monto))
            {
                output = false;
                MsgBox.Text += "Ingresa el monto del cobro a registrar.\n";
            }

            if (!decimal.TryParse(CobradoText.Text.Replace("$", "").Replace(",", ""), out _cobrado))
            {
                output = false;
                MsgBox.Text += "Ingresa el monto del cobro que ya fue pagado.\n";
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
            MontoText.Text = "0";
            CobradoText.Text = "0";
        }

        #endregion
    }
}
