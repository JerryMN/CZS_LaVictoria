using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class InventarioEditarForm : Form
    {
        readonly MaterialModel _material;
        double _cantidad;

        public InventarioEditarForm(MaterialModel material)
        {
            InitializeComponent();
            GetCategorías();
            _material = material;
            MaterialText.Text = _material.Nombre;
            AreaText.Text = _material.Área;
            CategoríaCombo.Text = _material.Categoría;
            CantidadText.Text = _material.CantidadDisponible.ToString(CultureInfo.InvariantCulture);
        }

        #region Events

        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            _material.Categoría = CategoríaCombo.Text;
            _material.CantidadDisponible = _cantidad;

            var saveSuccess = GlobalConfig.Connection.Material_Update(_material);

            if (saveSuccess)
            {
                MsgBox.Text = $"{MaterialText.Text} actualizado";
                MsgBox.IconColor = Color.DarkGreen;
                Tools.ClearForm(this);
                CantidadText.Text = "0";
            }
            else
            {
                MsgBox.Text = $"Ocurrió un error al actualizar {MaterialText.Text}";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void MsgBoxTimer_Tick(object sender, EventArgs e)
        {
            MsgBoxTimer.Stop();
            MsgBox.Visible = false;
            Dispose();
        }

        #endregion

        #region Methods

        void GetCategorías()
        {
            var categorías = GlobalConfig.Connection.Material_GetDistinctCategorías();

            foreach (var categoría in categorías)
                if (categoría != null)
                    CategoríaCombo.Items.Add(categoría);
        }

        bool ValidateForm()
        {
            var output = true;

            if (CategoríaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa una categoría.\n";
            }

            if (CantidadText.Text == "0.00" || !double.TryParse(CantidadText.Text.Replace(",", ""), out _cantidad))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad en inventario.\n";
            }

            return output;
        }

        #endregion
    }
}