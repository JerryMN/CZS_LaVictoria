using System;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.DatosPage
{
    public partial class ProveedorProductoCrearForm : Form
    {
        public ProveedorProductoCrearForm()
        {
            InitializeComponent();
            GetProveedores();
            GetMaterialInterno();
            GetAreas();
            GetCategorías();
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

            var model = new ProveedorProductoModel(MaterialProveedorText.Text, MaterialInternoCombo.Text,
                PrecioUnitarioText.Text, AreaCombo.Text, CategoríaCombo.Text);
            var proveedor = (ProveedorModel) ProveedorCombo.SelectedItem;
            var saveSuccess = GlobalConfig.Connection.ProveedorProducto_Create(model, proveedor);

            if (saveSuccess)
            {
                Tools.ClearForm(this);
                GetMaterialInterno();
                GetCategorías();
                MsgBox.Text = $"Material {model.MaterialExterno} del proveedor {proveedor.Nombre} guardado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = $"Error al crear material {model.MaterialExterno} para proveedor {proveedor.Nombre}.";
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

        void GetProveedores()
        {
            var proveedores = GlobalConfig.Connection.Proveedor_GetAll();

            foreach (var proveedor in proveedores) ProveedorCombo.Items.Add(proveedor);

            ProveedorCombo.DisplayMember = "Nombre";
        }

        void GetMaterialInterno()
        {
            var materiales = GlobalConfig.Connection.Material_GetDistinct();
            foreach (var material in materiales) MaterialInternoCombo.Items.Add(material);
        }

        void GetAreas()
        {
            var areas = GlobalConfig.Connection.Area_GetDistinct();

            foreach (var area in areas) AreaCombo.Items.Add(area);
        }

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

            if (ProveedorCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un proveedor.\n";
            }

            if (MaterialProveedorText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del material (proveedor).\n";
            }

            if (MaterialInternoCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del material (interno).\n";
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

            if (CategoríaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una categoría.\n";
            }

            return output;
        }

        #endregion
    }
}