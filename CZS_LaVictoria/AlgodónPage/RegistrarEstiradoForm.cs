using CZS_LaVictoria_Library.Models;
using CZS_LaVictoria_Library;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CZS_LaVictoria.AlgodónPage
{
    public partial class RegistrarEstiradoForm : Form
    {
        double _cantidadEntrada;
        double _cantidadSalida;

        public RegistrarEstiradoForm()
        {
            InitializeComponent();
            GetOperadores();
            FechaPicker.Culture = new CultureInfo("es-MX");
        }

        #region Events

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var orden = new ProducciónAlgodónModel();
            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            orden.Fecha = (DateTime)FechaPicker.Value;
            orden.Proceso = "Estirado";
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = int.Parse(MaquinaText.Text);
            orden.Operador = OperadorCombo.Text;
            orden.MaterialEntra = "Tambos Grandes";
            orden.CantidadEntra = _cantidadEntrada;
            orden.MaterialSale = "Tambos Chicos";
            orden.CantidadSale = _cantidadSalida;

            var saveSuccess = GlobalConfig.Connection.WoolProduction_CreateEstirado(orden);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Estirado registrado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar estirado.";
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

        void GetOperadores()
        {
            var operadores = GlobalConfig.Connection.Operador_GetByArea("Algodón");
            foreach (var operador in operadores)
            {
                OperadorCombo.Items.Add(operador);
            }

            OperadorCombo.DisplayMember = "Nombre";
        }

        bool ValidateForm()
        {
            var output = true;
            MsgBox.Text = "";

            if (OperadorCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un operador.\n";
            }

            if (MaquinaText.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una máquina.\n";
            }

            if (TurnoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un turno.\n";
            }

            if (CantidadEntradaText.Text == "" || CantidadEntradaText.Text == "0.00" || !double.TryParse(CantidadEntradaText.Text, out _cantidadEntrada))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de tambos grandes.\n";
            }

            if (CantidadSalidaText.Text == "" || CantidadSalidaText.Text == "0.00" || !double.TryParse(CantidadSalidaText.Text, out _cantidadSalida))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de tambos chicos.\n";
            }

            return output;
        }

        void ClearForm()
        {
            CantidadEntradaText.Text = "0.00";
            CantidadSalidaText.Text = "0.00";

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
        }

        #endregion
    }
}
