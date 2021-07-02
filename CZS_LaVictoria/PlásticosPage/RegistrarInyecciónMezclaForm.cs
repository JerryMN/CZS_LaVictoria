using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_ERP_Library;
using CZS_ERP_Library.Models;

namespace CZS_ERP_UI.PlásticosPage
{
    public partial class RegistrarInyecciónMezclaForm : Form
    {
        MezclaModel _mezclaEntrada = new MezclaModel();
        MaterialModel _materialSalida = new MaterialModel();
        double _kgEntrada;
        double _kgSalida;
        double _piezasBuenas;
        double _pesoProm;
        double _mermaMoler;

        public RegistrarInyecciónMezclaForm()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        #region Events

        void MezclaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mezclaEntrada = (MezclaModel) MezclaCombo.SelectedItem;
        }

        void SalidaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _materialSalida = (MaterialModel)SalidaCombo.SelectedItem;
            if (_materialSalida.Nombre == null) return;
            PesoPromText.Text = _materialSalida.Peso.ToString(CultureInfo.InvariantCulture);
        }

        void InputOutputChanged(object sender, EventArgs e)
        {
            GuardarButton.Enabled = false;
            CalcularButton.Enabled = true;
        }

        void CalcularButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            for (var i = 0; i < _mezclaEntrada.Materiales.Count; i++)
            {
                var material = _mezclaEntrada.Materiales[i];
                var cantidadRequerida = _kgEntrada * _mezclaEntrada.Cantidades[i] / _mezclaEntrada.CantidadMezcla;
                if (cantidadRequerida > material.CantidadDisponible)
                {
                    MsgBox.Text =
                        $"La mezcla \"{MezclaCombo.Text}\" no se puede seleccionar. Necesita más material \"{material.Nombre}\".";
                    MsgBox.Visible = true;
                    GuardarButton.Enabled = false;
                    return;
                }
            }

            _kgSalida = _piezasBuenas * _pesoProm / 1000;
            var mermaFinal = _kgEntrada - _kgSalida - _mermaMoler;
            if (mermaFinal < 0)
            {
                MsgBox.Text = "Revisa los valores de entrada o de salida.";
                MsgBox.Visible = true;
                MermaFinalText.Text = "0.00";
                GuardarButton.Enabled = false;
                return;
            }

            MermaFinalText.Text = mermaFinal.ToString(CultureInfo.InvariantCulture);
            MsgBox.Text = "Cantidades válidas.";
            MsgBox.IconColor = Color.DarkGreen;
            MsgBox.Visible = true;
            MsgBoxTimer.Start();
            GuardarButton.Enabled = true;
            CalcularButton.Enabled = false;
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            // TODO - Update cantidad de por moler.
            // TODO - Fill Productions table.
            bool saveSuccess;

            // Actualizar las cantidades de cada material en la mezcla.
            var index = 0;
            foreach (var material in _mezclaEntrada.Materiales)
            {
                material.CantidadDisponible -= _mezclaEntrada.Cantidades[index];
                GlobalConfig.Connection.Material_Update(material);
                index += 1;
                saveSuccess = true;
            }

            // Si no se seleccionó una base del ComboBox, guardarla como una base nueva.
            // Si sí se seleccionó una, actualizar cantidades y, de ser necesario, el peso.
            if (_materialSalida.Nombre == null)
            {
                _materialSalida.Nombre = SalidaCombo.Text;
                _materialSalida.Area = "Plásticos";
                _materialSalida.Categoría = "Bases";
                _materialSalida.CantidadDisponible = _piezasBuenas;
                _materialSalida.Peso = double.Parse(PesoPromText.Text);
                saveSuccess = GlobalConfig.Connection.Material_Create(_materialSalida);
            }
            else
            {
                _materialSalida.CantidadDisponible = _piezasBuenas;
                _materialSalida.Peso = double.Parse(PesoPromText.Text);
                saveSuccess = GlobalConfig.Connection.Material_Update(_materialSalida);
            }

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Inyección registrada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar inyección.";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void MsgBoxTimer_Tick(object sender, EventArgs e)
        {
            MsgBoxTimer.Stop();
            MsgBox.Visible = false;
        }

        #endregion

        #region Methods

        void FillComboBoxes()
        {
            MezclaCombo.Items.Clear();
            SalidaCombo.Items.Clear();

            var mezclas = GlobalConfig.Connection.Mezcla_GetAll();
            var bases = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Bases");

            foreach (var mezcla in mezclas)
            {
                MezclaCombo.Items.Add(mezcla);
            }

            foreach (var material in bases)
            {
                SalidaCombo.Items.Add(material);
            }

            MezclaCombo.DisplayMember = "Nombre";
            MezclaCombo.Sorted = true;
            SalidaCombo.DisplayMember = "Nombre";
            SalidaCombo.Sorted = true;
        }

        bool ValidateForm()
        {
            var output = true;

            MsgBox.Text = "";
            MsgBox.IconColor = Color.DarkRed;

            if (MezclaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una mezcla o ingresa una.\n";
            }

            
            if (CantidadEntradaText.Text == "0.00" || !double.TryParse(CantidadEntradaText.Text, out _kgEntrada))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de mezcla.\n";
            }

            if (SalidaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una producto de salida.\n";
            }

            if (CantidadSalidaText.Text == "" || CantidadSalidaText.Text == "0" || !double.TryParse(CantidadSalidaText.Text, out _piezasBuenas))
            {
                output = false;
                MsgBox.Text += "Ingresa las piezas buenas.\n";
            }

            if (PesoPromText.Text == "" || PesoPromText.Text == "0.00" || !double.TryParse(PesoPromText.Text, out _pesoProm))
            {
                output = false;
                MsgBox.Text += "Ingresa el peso promedio de una pieza.\n";
            }

            if (MermaMolerText.Text == "" || MermaMolerText.Text == "0.00" || !double.TryParse(MermaMolerText.Text, out _mermaMoler))
            {
                output = false;
                MsgBox.Text += "Ingresa la merma que se puede moler.\n";
            }

            return output;
        }

        void ClearForm()
        {
            CantidadEntradaText.Text = "0.00";
            CantidadSalidaText.Text = "0";
            PesoPromText.Text = "0.00";
            MermaMolerText.Text = "0.00";
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
