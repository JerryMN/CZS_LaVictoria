using System;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.DatosPage
{
    public partial class ClienteProductoCrearForm : Form
    {
        public ClienteProductoCrearForm()
        {
            InitializeComponent();
            GetMaterialInterno();
            GetAreas();
            if (GlobalConfig.Connection.CZS_GetLicencia()) return;
            MessageBox.Show(
                "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
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

            var model = new ClienteProductoModel(ProductoInternoCombo.Text, PrecioUnitarioText.Text, AreaCombo.Text);

            var saveSuccess = GlobalConfig.Connection.ClienteProducto_Create(model);

            if (saveSuccess)
            {
                Tools.ClearForm(this);
                MsgBox.Text = $"Producto {model.ProductoInterno} guardado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = $"Error al crear producto {model.ProductoInterno}.";
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

        void GetAreas()
        {
            var areas = GlobalConfig.Connection.Area_GetDistinct();

            foreach (var area in areas) AreaCombo.Items.Add(area);
        }

        void GetMaterialInterno()
        {
            var materiales = GlobalConfig.Connection.Material_GetDistinct();
            foreach (var material in materiales) ProductoInternoCombo.Items.Add(material);
        }

        bool ValidateForm()
        {
            var output = true;

            if (ProductoInternoCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del material.\n";
            }

            if (PrecioUnitarioText.Text == "$0.00")
            {
                output = false;
                MsgBox.Text += "El precio no puede ser $0.00.\n";
            }

            if (AreaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un área.\n";
            }

            return output;
        }

        #endregion
    }
}