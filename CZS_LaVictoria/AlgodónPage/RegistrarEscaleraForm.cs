using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.AlgodónPage
{
    public partial class RegistrarEscaleraForm : Form
    {
        MaterialModel _materialEntrada = new MaterialModel();
        double _cantidadEntrada;
        double _cantidadSalida;

        public RegistrarEscaleraForm()
        {
            InitializeComponent();
            GetOperadores();
            GetAlgodones();
            FechaPicker.Culture = new CultureInfo("es-MX");
        }

        #region Events

        void EntradaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _materialEntrada = (MaterialModel)EntradaCombo.SelectedItem;
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            _materialEntrada.CantidadDisponible -= _cantidadEntrada;
            
            var orden = new ProducciónAlgodónModel();
            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            orden.Fecha = (DateTime)FechaPicker.Value;
            orden.Proceso = "Escalera";
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = int.Parse(MaquinaText.Text);
            orden.Operador = OperadorCombo.Text;
            orden.MaterialEntra = _materialEntrada.Nombre;
            orden.CantidadEntra = _cantidadEntrada;
            orden.MaterialSale = "Algodón Limpio";
            orden.CantidadSale = _cantidadSalida;

            var saveSuccess = GlobalConfig.Connection.WoolProduction_CreateEscalera(orden, _materialEntrada);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Escalera registrada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar escalera.";
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

        void GetAlgodones()
        {
            EntradaCombo.Items.Clear();

            var materiales = GlobalConfig.Connection.Material_GetByAreaCat("Algodón", "Algodón Sucio");
            foreach (var material in materiales)
            {
                EntradaCombo.Items.Add(material);
            }

            EntradaCombo.DisplayMember = "Nombre";
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

            if (EntradaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un algodón sucio.\n";
            }

            if (CantidadEntradaText.Text == "" || CantidadEntradaText.Text == "0.00" || !double.TryParse(CantidadEntradaText.Text, out _cantidadEntrada))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de algodón sucio.\n";
            }
            else if (_cantidadEntrada > _materialEntrada.CantidadDisponible)
            {
                output = false;
                MsgBox.Text += $"Cantidad de entrada excede el disponible ({_materialEntrada.CantidadDisponible}).\n";
            }

            if (CantidadSalidaText.Text == "" || CantidadSalidaText.Text == "0.00" || !double.TryParse(CantidadSalidaText.Text, out _cantidadSalida))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de algodón limpio.\n";
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