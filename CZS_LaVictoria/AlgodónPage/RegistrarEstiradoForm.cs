using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.AlgodónPage
{
    public partial class RegistrarEstiradoForm : Form
    {
        double _cantidadSalida;

        public RegistrarEstiradoForm()
        {
            InitializeComponent();
            GetOperadores();
            GetMáquinas();
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
            orden.Fecha = (DateTime) FechaPicker.Value;
            orden.Proceso = "Estirado";
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = MáquinaCombo.Text;
            orden.Operador = OperadorCombo.Text;
            orden.MaterialEntra = "Tambos Grandes";
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
            foreach (var operador in operadores) OperadorCombo.Items.Add(operador);

            OperadorCombo.DisplayMember = "Nombre";
        }

        void GetMáquinas()
        {
            MáquinaCombo.Items.Clear();

            var máquinas = GlobalConfig.Connection.PlasticProduction_GetMáquinas();
            foreach (var máquina in máquinas) MáquinaCombo.Items.Add(máquina);
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

            if (MáquinaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una máquina.\n";
            }

            if (TurnoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un turno.\n";
            }

            if (CantidadSalidaText.Text == "" || CantidadSalidaText.Text == "0" ||
                !double.TryParse(CantidadSalidaText.Text, out _cantidadSalida))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de tambos chicos.\n";
            }

            return output;
        }

        void ClearForm()
        {
            Tools.ClearForm(this);

            TurnoText.Text = "1";
            CantidadSalidaText.Text = "0.00";
        }

        #endregion
    }
}