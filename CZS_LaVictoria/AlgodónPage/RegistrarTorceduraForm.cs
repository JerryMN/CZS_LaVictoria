using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.AlgodónPage
{
    public partial class RegistrarTorceduraForm : Form
    {
        readonly MaterialModel _materialEntrada = GlobalConfig.Connection.Material_GetByNombreArea("Hilo", "Algodón");
        double _cantidadEntrada;
        double _cantidadSalida;

        public RegistrarTorceduraForm()
        {
            InitializeComponent();
            GetOperadores();
            GetMáquinas();
            FechaPicker.Culture = new CultureInfo("es-MX");
            if (GlobalConfig.Connection.CZS_GetLicencia()) return;
            MessageBox.Show(
                "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
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
            orden.Proceso = "Torcedura";
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = MáquinaCombo.Text;
            orden.Operador = OperadorCombo.Text;
            orden.MaterialEntra = "Hilo";
            orden.CantidadEntra = _cantidadEntrada;
            orden.MaterialSale = "Carretes";
            orden.CantidadSale = _cantidadSalida;

            var saveSuccess = GlobalConfig.Connection.WoolProduction_CreateTorcedura(orden);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Torcedura registrada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar torcedura.";
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

            var máquinas = GlobalConfig.Connection.WoolProduction_GetMáquinas();
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

            if (CantidadEntradaText.Text == "" || CantidadEntradaText.Text == "0.00" ||
                !double.TryParse(CantidadEntradaText.Text, out _cantidadEntrada))
            {
                output = false;
                MsgBox.Text += "Ingresa los kg de hilo.\n";
            }
            else if (_cantidadEntrada > _materialEntrada.CantidadDisponible)
            {
                output = false;
                MsgBox.Text += $"Cantidad de entrada excede el disponible ({_materialEntrada.CantidadDisponible:N}).\n";
            }

            if (CantidadSalidaText.Text == "" || CantidadSalidaText.Text == "0" ||
                !double.TryParse(CantidadSalidaText.Text, out _cantidadSalida))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de carretes.\n";
            }

            return output;
        }

        void ClearForm()
        {
            Tools.ClearForm(this);

            CantidadEntradaText.Text = "0.00";
            CantidadSalidaText.Text = "0.00";
        }

        #endregion
    }
}