using System;
using System.Collections;
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
        MaterialModel _materialEntrada = new MaterialModel();
        MaterialModel _materialSalida = new MaterialModel();
        double _cantidadEntrada;
        double _cantidadSalida;

        public RegistrarMolidoForm()
        {
            InitializeComponent();
            GetOperadores();
            GetMateriales();
            FechaPicker.Culture = new CultureInfo("es-MX");
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
            if (CantidadEntradaText.Text == "" || CantidadEntradaText.Text == "0.00" || CantidadSalidaText.Text == "" || CantidadSalidaText.Text == "0.00") return;
            double.TryParse(CantidadEntradaText.Text, out _cantidadEntrada);
            double.TryParse(CantidadSalidaText.Text, out _cantidadSalida);
            var merma = _cantidadEntrada - _cantidadSalida;
            MermaText.Text = merma <= 0 ? "0.00" : merma.ToString(CultureInfo.InvariantCulture);
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            _materialEntrada.CantidadDisponible -= _cantidadEntrada;
            if (_materialSalida == null)
            {
                _materialSalida = new MaterialModel(SalidaCombo.Text, "Plásticos", "Molido", _cantidadSalida);
                GetMateriales();
            }
            else
            {
                _materialSalida.CantidadDisponible += _cantidadSalida;
            }

            var orden = new ProducciónPlásticosModel();
            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            orden.Fecha = (DateTime) FechaPicker.Value;
            orden.Proceso = "Molido";
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = int.Parse(MaquinaText.Text);
            orden.Operador = OperadorCombo.Text;
            orden.MaterialEntra = _materialEntrada.Nombre;
            orden.CantidadEntra = double.Parse(CantidadEntradaText.Text);
            orden.MaterialSale = _materialSalida.Nombre;
            orden.CantidadSale = double.Parse(CantidadSalidaText.Text);
            orden.MermaFinal = double.Parse(MermaText.Text);

            var saveSuccess =
                GlobalConfig.Connection.PlasticProduction_CreateMolido(orden, _materialEntrada, _materialSalida);
            

            if (saveSuccess)
            {
                ClearForm();
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
            foreach (var operador in operadores)
            {
                OperadorCombo.Items.Add(operador);
            }

            OperadorCombo.DisplayMember = "Nombre";
        }

        void GetMateriales()
        {
            EntradaCombo.Items.Clear();
            SalidaCombo.Items.Clear();

            var materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Por Moler");
            foreach (var material in materiales)
            {
                EntradaCombo.Items.Add(material);
            }

            materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Molido");
            foreach (var material in materiales)
            {
                SalidaCombo.Items.Add(material);
            }

            EntradaCombo.DisplayMember = "Nombre";
            SalidaCombo.DisplayMember = "Nombre";
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
                MsgBox.Text += $"Cantidad de entrada excede el disponible ({_materialEntrada.CantidadDisponible}).\n";
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
            CantidadEntradaText.Text = "0.00";
            CantidadSalidaText.Text = "0.00";
            MermaText.Text = "0.00";
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
