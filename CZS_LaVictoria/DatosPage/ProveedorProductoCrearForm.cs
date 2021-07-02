using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using CZS_ERP_Library;
using CZS_ERP_Library.Models;

namespace CZS_ERP_UI.DatosPage
{
    public partial class ProveedorProductoCrearForm : Form
    {
        public ProveedorProductoCrearForm()
        {
            InitializeComponent();
            GetProveedores();
            GetAreas();
        }

        #region Events
        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;

            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var model = new ProveedorProductoModel(MaterialProveedorText.Text, MaterialInternoText.Text, PrecioUnitarioText.Text, AreaCombo.Text);
            var proveedor = (ProveedorModel)ProveedorCombo.SelectedItem;
            var saveSuccess = GlobalConfig.Connection.ProveedorProducto_Create(model, proveedor);

            if (saveSuccess)
            {
                ClearForm();
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

            foreach (var proveedor in proveedores)
            {
                ProveedorCombo.Items.Add(proveedor);
            }

            ProveedorCombo.DisplayMember = "Nombre";
        }

        void GetAreas()
        {
            var areas = GlobalConfig.Connection.Area_GetAll();

            foreach (var area in areas)
            {
                AreaCombo.Items.Add(area);
            }

            AreaCombo.DisplayMember = "Area";
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
                MsgBox.Text += "Ingresa el nombre del material.\n";
            }

            if (MaterialInternoText.Text == "")
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

        void ClearForm()
        {
            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox box)
                        box.Clear();
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.SelectedItem = null;
                        comboBox.Text = "";
                    }
                    else
                        Func(control.Controls);
            }

            Func(Controls);
        } 

        #endregion
    }
}
