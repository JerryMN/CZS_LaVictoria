using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CZS_ERP_Library;
using CZS_ERP_Library.Models;
using Syncfusion.WinForms.DataGrid.Enums;

namespace CZS_ERP_UI.DatosPage
{
    public partial class ProveedorVerForm : Form
    {
        public ProveedorVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = GetProveedores();
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.HeaderText == "IdProvider")
            {
                e.Column.HeaderText = "Id Proveedor";
            }
        }

        void EditarButton_Click(object sender, EventArgs e)
        {
            if (EditarButton.Text == "Editar")
            {
                DataGrid.AllowEditing = true;
                DataGrid.Columns["IdProvider"].AllowEditing = false;
                EditarButton.Text = "Guardar";
                
            }
            else if (EditarButton.Text == "Guardar")
            {
                
                var model = (ProveedorModel) DataGrid.SelectedItem;
                var updateSuccess = GlobalConfig.Connection.Proveedor_Update(model);

                if (updateSuccess)
                {
                    DataGrid.AllowEditing = false;
                    EditarButton.Text = "Editar";
                    MessageBox.Show($"Proveedor {model.Nombre} actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al actualizar proveedor {model.Nombre}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataGrid.AllowEditing = false;
                EditarButton.Text = "Editar";
            }
        }

        void BorrarButton_Click(object sender, EventArgs e)
        {
            var model = (ProveedorModel)DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar al proveedor {model.Nombre}? Esta acción es irreversible.", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            var deleteSuccess = GlobalConfig.Connection.Proveedor_Delete(model);

            if (deleteSuccess)
            {
                DataGrid.DataSource = GetProveedores();
                MessageBox.Show($"Proveedor {model.Nombre} eliminado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar proveedor {model.Nombre}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Methods

        static List<ProveedorModel> GetProveedores()
        {
            return GlobalConfig.Connection.Proveedor_GetAll();
        }

        #endregion
    }
}
