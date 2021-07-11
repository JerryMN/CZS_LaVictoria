using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.Input.Enums;

namespace CZS_LaVictoria.DatosPage
{
    public partial class ProveedorProductoVerForm : Form
    {
        public ProveedorProductoVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = GetProductos();
            DataGrid.QueryRowHeight += DataGridOnQueryRowHeight;
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
        }

        #region Events

        void DataGridOnQueryRowHeight(object sender, QueryRowHeightEventArgs e)
        {
            if (DataGrid.AutoSizeController.GetAutoRowHeight(e.RowIndex, new RowAutoFitOptions(), out var autoHeight))
            {
                if (autoHeight > 24)
                {
                    e.Height = autoHeight;
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Renombrar las columnas de la tabla.
        /// </summary>
        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "Proveedor":
                    e.Column.AllowEditing = false;
                    break;
                case "MaterialExterno":
                    e.Column.HeaderText = "Nombre Proveedor";
                    break;
                case "MaterialInterno":
                    e.Column.HeaderText = "Nombre Interno";
                    break;
                case "PrecioUnitario":
                    e.Column = new GridNumericColumn
                    {
                        MappingName = "PrecioUnitario", HeaderText = "Precio Unitario", FormatMode = FormatMode.Currency
                    };
                    break;
                case "Área":
                case "Categoría":
                    e.Column.AllowEditing = false;
                    break;
                case "IdSupplier":
                    e.Cancel = true;
                    break;
            }
        }

        void EditarButton_Click(object sender, EventArgs e)
        {
            if (EditarButton.Text == "Editar")
            {
                DataGrid.AllowEditing = true;
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
                    MessageBox.Show($"Material {model.MaterialExterno} del proveedor {model.Proveedor} actualizado con éxito.", 
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al actualizar material {model.MaterialExterno} del proveedor {model.Proveedor}.", 
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataGrid.AllowEditing = false;
                EditarButton.Text = "Editar";
            }
        }

        void BorrarButton_Click(object sender, EventArgs e)
        {
            var model = (ProveedorProductoModel)DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar al producto {model.MaterialExterno} del proveedor {model.Proveedor}? Esta acción es irreversible.", 
                null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            var deleteSuccess = GlobalConfig.Connection.ProveedorProducto_Delete(model);

            if (deleteSuccess)
            {
                DataGrid.DataSource = GetProductos();
                MessageBox.Show($"Material {model.MaterialExterno} del proveedor {model.Proveedor} eliminado con éxito.", 
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar material {model.MaterialExterno} del proveedor {model.Proveedor}.", 
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
