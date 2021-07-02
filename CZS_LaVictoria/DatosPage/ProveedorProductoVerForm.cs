using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid.Enums;

namespace CZS_LaVictoria.DatosPage
{
    public partial class ProveedorProductoVerForm : Form
    {
        public ProveedorProductoVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = GetProductos();
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            DataGrid.Columns["IdProvider"].Visible = false;
        }

        #region Events

        /// <summary>
        /// Renombrar las columnas de la tabla.
        /// </summary>
        void DataGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.HeaderText == "IdProviderProduct")
            {
                e.Column.HeaderText = "Id Producto";
            }

            if (e.Column.HeaderText == "MaterialExterno")
            {
                e.Column.HeaderText = "Material Externo";
            }

            if (e.Column.HeaderText == "MaterialInterno")
            {
                e.Column.HeaderText = "Material Interno";
            }

            if (e.Column.HeaderText == "PrecioUnitario")
            {
                e.Column.HeaderText = "Precio Unitario";
            }

            if (e.Column.HeaderText == "Area")
            {
                e.Column.HeaderText = "Área";
            }
        }

        void EditarButton_Click(object sender, EventArgs e)
        {
            if (EditarButton.Text == "Editar")
            {
                DataGrid.AllowEditing = true;
                DataGrid.Columns["IdProviderProduct"].AllowEditing = false;
                DataGrid.Columns["Proveedor"].AllowEditing = false;
                EditarButton.Text = "Guardar";

            }
            else if (EditarButton.Text == "Guardar")
            {

                var model = (ProveedorProductoModel)DataGrid.SelectedItem;
                var updateSuccess = GlobalConfig.Connection.ProveedorProducto_Update(model);

                if (updateSuccess)
                {
                    DataGrid.AllowEditing = false;
                    EditarButton.Text = "Editar";
                    MessageBox.Show($"Material {model.MaterialExterno} del proveedor {model.Proveedor} actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al actualizar material {model.MaterialExterno} del proveedor {model.Proveedor}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataGrid.AllowEditing = false;
                EditarButton.Text = "Editar";
            }
        }

        void BorrarButton_Click(object sender, EventArgs e)
        {
            var model = (ProveedorProductoModel)DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar al producto {model.MaterialExterno} del proveedor {model.Proveedor}? Esta acción es irreversible.", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            var deleteSuccess = GlobalConfig.Connection.ProveedorProducto_Delete(model);

            if (deleteSuccess)
            {
                DataGrid.DataSource = GetProductos();
                MessageBox.Show($"Material {model.MaterialExterno} del proveedor {model.Proveedor} eliminado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar material {model.MaterialExterno} del proveedor {model.Proveedor}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Methods

        static List<ProveedorProductoModel> GetProductos()
        {
            return GlobalConfig.Connection.ProveedorProducto_GetAll();
        }

        #endregion
    }
}
