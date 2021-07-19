using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CZS_LaVictoria.PlásticosPage
{
    public partial class RegistrarCortadoForm : Form
    {
        MaterialModel _materialEntrada = new MaterialModel();
        double _cantidadEntrada;
        MaterialModel _materialSalida = new MaterialModel();
        double _cantidadSalida;
        double _mermaMoler;

        public RegistrarCortadoForm()
        {
            InitializeComponent();
            GetOperadores();
            GetMáquinas();
            GetMazos();
            GetFibras();
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

        void InputOutputChanged(object sender, EventArgs e)
        {
            GuardarButton.Enabled = false;
            CalcularButton.Enabled = true;
        }

        void CalcularButton_Click(object sender, EventArgs e)
        {
            MsgBox.IconColor = Color.DarkRed;
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            if (_cantidadEntrada > _materialEntrada.CantidadDisponible)
            {
                MsgBox.Text =
                    $"El mazo \"{EntradaCombo.Text}\" no se puede seleccionar. Cantidad disponible: {_materialEntrada.CantidadDisponible}.";
                MsgBox.Visible = true;
                GuardarButton.Enabled = false;
                return;
            }

            var mermaFinal = _cantidadEntrada - _cantidadSalida - _mermaMoler;
            if (mermaFinal < 0)
            {
                MsgBox.Text = "Revisa los valores de entrada o de salida.";
                MsgBox.Visible = true;
                MermaRealText.Text = "0.00";
                GuardarButton.Enabled = false;
                return;
            }

            MermaRealText.Text = mermaFinal.ToString(CultureInfo.InvariantCulture);
            MsgBox.Text = "Cantidades válidas.";
            MsgBox.IconColor = Color.DarkGreen;
            MsgBox.Visible = true;
            MsgBoxTimer.Start();
            GuardarButton.Enabled = true;
            CalcularButton.Enabled = false;
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            var orden = new ProducciónPlásticosModel();
            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            orden.Fecha = (DateTime)FechaPicker.Value;
            orden.Proceso = "Cortado";
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = MáquinaCombo.Text;
            orden.Operador = OperadorCombo.Text;
            orden.MaterialEntra = _materialEntrada.Nombre;
            orden.CantidadEntra = double.Parse(CantidadEntradaText.Text);
            orden.CantidadSale = double.Parse(CantidadSalidaText.Text);
            orden.MermaMoler = double.Parse(MermaMolerText.Text);
            orden.MermaFinal = double.Parse(MermaRealText.Text);

            _materialEntrada.CantidadDisponible -= _cantidadEntrada;
            if (_materialSalida == null || _materialSalida.Id == 0)
            {
                _materialSalida = new MaterialModel(SalidaCombo.Text, "Plásticos", "Cortado", _cantidadSalida);
            }
            else
            {
                _materialSalida.CantidadDisponible += _cantidadSalida;
            }

            orden.MaterialSale = _materialSalida.Nombre;

            var saveSuccess = GlobalConfig.Connection.PlasticProduction_CreateCortado(orden, _materialEntrada, _materialSalida);

            if (saveSuccess)
            {
                ClearForm();
                GetFibras();
                MsgBox.Text = "Cortado registrado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar cortado.";
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

        void GetMáquinas()
        {
            MáquinaCombo.Items.Clear();
            
            var máquinas = GlobalConfig.Connection.PlasticProduction_GetMáquinas();
            foreach (var máquina in máquinas)
            {
                MáquinaCombo.Items.Add(máquina);
            }
        }

        void GetMazos()
        {
            EntradaCombo.Items.Clear();

            var materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Extruído");
            foreach (var material in materiales)
            {
                EntradaCombo.Items.Add(material);
            }

            EntradaCombo.DisplayMember = "Nombre";
        }

        void GetFibras()
        {
            SalidaCombo.Items.Clear();

            var materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Cortado");
            foreach (var material in materiales)
            {
                SalidaCombo.Items.Add(material);
            }

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
                MsgBox.Text += "Selecciona un mazo.\n";
            }

            if (CantidadEntradaText.Text == "" || CantidadEntradaText.Text == "0.00" || !double.TryParse(CantidadEntradaText.Text, out _cantidadEntrada))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de mazos.\n";
            }

            if (SalidaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un material de salida.\n";
            }

            if (CantidadSalidaText.Text == "" || CantidadSalidaText.Text == "0" || !double.TryParse(CantidadSalidaText.Text, out _cantidadSalida))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de mazos.\n";
            }

            if (MermaMolerText.Text == "" || !double.TryParse(MermaMolerText.Text, out _mermaMoler))
            {
                output = false;
                MsgBox.Text += "Ingresa la merma que se puede moler.\n";
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

            TurnoText.Text = "1";
            CantidadEntradaText.Text = "0.00";
            CantidadSalidaText.Text = "0.00";
            MermaMolerText.Text = "0";
            MermaRealText.Text = "0";
        }

        #endregion
    }
}
