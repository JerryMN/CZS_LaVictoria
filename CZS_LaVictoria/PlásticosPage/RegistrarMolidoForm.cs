using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.PlásticosPage
{
    public partial class RegistrarMolidoForm : Form
    {
        double _cantidadEntrada;
        double _cantidadSalida;
        MaterialModel _materialEntrada = new MaterialModel();
        MaterialModel _materialSalida = new MaterialModel();
        double _merma;

        public RegistrarMolidoForm()
        {
            InitializeComponent();
            GetOperadores();
            GetMáquinas();
            GetMateriales();
            FechaPicker.Culture = new CultureInfo("es-MX");
            if (GlobalConfig.Connection.CZS_GetLicencia()) return;
            MessageBox.Show(
                "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        #region Events

        void EntradaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _materialEntrada = (MaterialModel) EntradaCombo.SelectedItem;
        }

        void SalidaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _materialSalida = (MaterialModel) SalidaCombo.SelectedItem;
        }

        void CantidadText_TextChanged(object sender, EventArgs e)
        {
            if (CantidadEntradaText.Text == "" || CantidadEntradaText.Text == "0.00" || CantidadSalidaText.Text == "" ||
                CantidadSalidaText.Text == "0.00") return;
            double.TryParse(CantidadEntradaText.Text.Replace(",", ""), out _cantidadEntrada);
            double.TryParse(CantidadSalidaText.Text.Replace(",", ""), out _cantidadSalida);
            _merma = _cantidadEntrada - _cantidadSalida;
            MermaText.Text = _merma <= 0 ? "0.00" : _merma.ToString(CultureInfo.InvariantCulture);
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            if (SalidaCombo.Text != _materialSalida.Nombre) _materialSalida = new MaterialModel();

            var orden = new ProducciónPlásticosModel();
            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            orden.Fecha = (DateTime) FechaPicker.Value;
            orden.Proceso = "Molido";
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = MáquinaCombo.Text;
            orden.Operador = OperadorCombo.Text;
            orden.MaterialEntra = _materialEntrada.Nombre;
            orden.CantidadEntra = _cantidadEntrada;
            orden.MaterialSale = SalidaCombo.Text;
            orden.CantidadSale = _cantidadSalida;
            orden.MermaFinal = _merma;

            var saveSuccess =
                GlobalConfig.Connection.PlasticProduction_CreateMolido(orden, _materialEntrada, _materialSalida);

            if (saveSuccess)
            {
                ClearForm();
                GetMáquinas();
                GetMateriales();
                MsgBox.Text = "Molido registrado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar molido.";
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
            var operadores = GlobalConfig.Connection.Operador_GetByArea("Plásticos");
            foreach (var operador in operadores) OperadorCombo.Items.Add(operador);

            OperadorCombo.DisplayMember = "Nombre";
        }

        void GetMáquinas()
        {
            MáquinaCombo.Items.Clear();

            var máquinas = GlobalConfig.Connection.PlasticProduction_GetMáquinas();
            foreach (var máquina in máquinas) MáquinaCombo.Items.Add(máquina);
        }

        void GetMateriales()
        {
            EntradaCombo.Items.Clear();
            SalidaCombo.Items.Clear();

            var materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Por Moler");
            foreach (var material in materiales) EntradaCombo.Items.Add(material);

            materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Molido");
            foreach (var material in materiales) SalidaCombo.Items.Add(material);

            EntradaCombo.DisplayMember = "Nombre";
            SalidaCombo.DisplayMember = "Nombre";
        }

        bool ValidateForm()
        {
            var output = true;
            
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

            if (EntradaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un material sin moler.\n";
            }

            if (CantidadEntradaText.Text == "" || CantidadEntradaText.Text == "0.00")
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad sin moler.\n";
            }
            else if (_cantidadEntrada > _materialEntrada.CantidadDisponible)
            {
                output = false;
                MsgBox.Text += $"El material {_materialEntrada.Nombre} no se puede seleccionar. " +
                               $"Cantidad disponible: {_materialEntrada.CantidadDisponible:N} kg.\n";
            }

            if (SalidaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un material molido.\n";
            }

            if (CantidadSalidaText.Text == "" || CantidadSalidaText.Text == "0.00")
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad molida.\n";
            }

            if (_cantidadSalida > _cantidadEntrada)
            {
                output = false;
                MsgBox.Text += "Cantidad de salida no puede ser mayor a cantidad de entrada.\n";
            }

            return output;
        }

        void ClearForm()
        {
            Tools.ClearForm(this);

            TurnoText.Text = "1";
            CantidadEntradaText.Text = "0.00";
            CantidadSalidaText.Text = "0.00";
            MermaText.Text = "0.00";
        }

        #endregion
    }
}