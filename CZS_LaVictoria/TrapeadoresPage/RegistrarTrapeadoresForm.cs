using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.TrapeadoresPage
{
    public partial class RegistrarTrapeadoresForm : Form
    {
        double _cantidadAlambre;
        int _cantidadKit;
        MaterialModel _selectedAlambre = new MaterialModel();
        KitModel _selectedKit = new KitModel();


        public RegistrarTrapeadoresForm()
        {
            InitializeComponent();
            GetOperadores();
            GetMáquinas();
            FillComboBoxes();
            FechaPicker.Culture = new CultureInfo("es-MX");
        }

        #region Events

        void AlambreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedAlambre = (MaterialModel) AlambreCombo.SelectedItem;
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

            if (_selectedAlambre.Id != 0)
                if (_cantidadAlambre > _selectedAlambre.CantidadDisponible)
                {
                    MsgBox.Text =
                        $"El alambre no se puede seleccionar. Cantidad disponible: {_selectedAlambre.CantidadDisponible:N}.";
                    MsgBox.Visible = true;
                    return;
                }

            _selectedKit = (KitModel) SalidaCombo.SelectedItem;

            for (var i = 0; i < _selectedKit.Materiales.Count; i++)
            {
                var material = _selectedKit.Materiales[i];
                var cantidadRequerida = _selectedKit.Cantidades[i] * _cantidadKit;
                if (cantidadRequerida > material.CantidadDisponible)
                {
                    MsgBox.Text =
                        $"El kit \"{_selectedKit.Nombre}\" no se puede seleccionar. Necesita más material \"{material.Nombre}\".";
                    MsgBox.Visible = true;
                    GuardarButton.Enabled = false;
                    return;
                }
            }

            MsgBox.Text = "Cantidades válidas.";
            MsgBox.IconColor = Color.DarkGreen;
            MsgBox.Visible = true;
            MsgBoxTimer.Start();
            GuardarButton.Enabled = true;
            CalcularButton.Enabled = false;
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            var orden = new ProducciónTrapeadoresModel();
            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            orden.Fecha = (DateTime) FechaPicker.Value;
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = MáquinaCombo.Text;
            orden.Operador = OperadorCombo.Text;
            orden.Alambre = _selectedAlambre.Nombre;
            orden.CantidadAlambre = _cantidadAlambre;
            orden.Kit = _selectedKit.Nombre;
            orden.CantidadKit = _cantidadKit;

            var saveSuccess = GlobalConfig.Connection.MopProduction_Create(orden, _selectedAlambre, _selectedKit);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Producción registrada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar producción.";
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
            var operadores = GlobalConfig.Connection.Operador_GetByArea("Trapeadores");
            foreach (var operador in operadores) OperadorCombo.Items.Add(operador);

            OperadorCombo.DisplayMember = "Nombre";
        }

        void GetMáquinas()
        {
            MáquinaCombo.Items.Clear();

            var máquinas = GlobalConfig.Connection.PlasticProduction_GetMáquinas();
            foreach (var máquina in máquinas) MáquinaCombo.Items.Add(máquina);
        }

        void FillComboBoxes()
        {
            AlambreCombo.Items.Clear();
            SalidaCombo.Items.Clear();
            AlambreCombo.DisplayMember = "Nombre";
            SalidaCombo.DisplayMember = "Nombre";

            var alambres = GlobalConfig.Connection.Material_GetByCat("Alambre");
            foreach (var alambre in alambres) AlambreCombo.Items.Add(alambre);

            var kits = GlobalConfig.Connection.Kit_GetAll();
            foreach (var kit in kits) SalidaCombo.Items.Add(kit);
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

            if (AlambreCombo.Text != "")
                if (CantidadAlambreText.Text == "0" || !double.TryParse(CantidadAlambreText.Text, out _cantidadAlambre))
                {
                    output = false;
                    MsgBox.Text += "Ingresa la cantidad de rollos de alambre.\n";
                }

            if (SalidaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un kit.\n";
            }

            if (CantidadSalidaText.Text == "0" ||
                !int.TryParse(CantidadSalidaText.Text.Replace(",", ""), out _cantidadKit))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de kits.\n";
            }

            return output;
        }

        void ClearForm()
        {
            Tools.ClearForm(this);

            CantidadAlambreText.Text = "0";
            CantidadSalidaText.Text = "0";
        }

        #endregion
    }
}