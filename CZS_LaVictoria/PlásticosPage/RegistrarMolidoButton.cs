using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_ERP_Library.Models;

namespace CZS_ERP_UI.PlásticosPage
{
    public partial class RegistrarMolidoButton : Form
    {
        MaterialModel _materialEntrada = new MaterialModel();
        MaterialModel _materialSalida = new MaterialModel();

        public RegistrarMolidoButton()
        {
            InitializeComponent();
            CreateSampleData();
            //GetMateriales();
        }

        // TODO - REMOVE
        void CreateSampleData()
        {
            _materialEntrada.IdMaterial = 1;
            _materialEntrada.Area = "Plásticos";
            _materialEntrada.Nombre = "Merma Por Moler 1";
            _materialEntrada.CantidadDisponible = 100;
            _materialEntrada.Categoría = "Por Moler";

            _materialSalida.IdMaterial = 2;
            _materialSalida.Nombre = "Merma Molida";
            _materialSalida.CantidadDisponible = 100;
            _materialSalida.Categoría = "Molido";
            _materialSalida.Area = "Plásticos";

            EntradaCombo.Items.Add(_materialEntrada);
            SalidaCombo.Items.Add(_materialSalida);
            EntradaCombo.DisplayMember = "Nombre";
            SalidaCombo.DisplayMember = "Nombre";
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
            double.TryParse(CantidadEntradaText.Text, out var cantidadEntrada);
            double.TryParse(CantidadSalidaText.Text, out var cantidadSalida);
            var merma = cantidadEntrada - cantidadSalida;
            MermaText.Text = merma <= 0 ? "0.00" : merma.ToString(CultureInfo.InvariantCulture);
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            // TODO - UPDATE _materialEntrada on SQL
            // TODO - UPDATE _materialSalida on SQL
            var saveSuccess = true;

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

        void GetMateriales()
        {
            EntradaCombo.Items.Clear();
            SalidaCombo.Items.Clear();

            // TODO - "SELECT * FROM ____ WHERE Categoría = 'Por Moler'
            var materiales = new List<MaterialModel>();
            foreach (var material in materiales)
            {
                EntradaCombo.Items.Add(material);
            }

            // TODO - "SELECT * FROM ____ WHERE Categoría = 'Molido'
            materiales = new List<MaterialModel>();
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
            double.TryParse(CantidadEntradaText.Text, out var cantidadEntrada);
            double.TryParse(CantidadSalidaText.Text, out var cantidadSalida);
            MsgBox.Text = "";

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
            else if (cantidadEntrada > _materialEntrada.CantidadDisponible)
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

            if (cantidadSalida > cantidadEntrada)
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
