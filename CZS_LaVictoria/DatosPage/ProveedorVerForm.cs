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

namespace CZS_LaVictoria.DatosPage
{
    public partial class ProveedorVerForm : Form
    {
        public ProveedorVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = GetProveedores();
            DataGrid.QueryRowHeight += DataGridOnQueryRowHeight;
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCellsWithLastColumnFill;
        }

        #region Events

        void DataGridOnQueryRowHeight(object sender, QueryRowHeightEventArgs e)
        {
            if (DataGrid.AutoSizeController.GetAutoRowHeight(e.RowIndex, new RowAutoFitOptions(), out var autoHeight))
                if (autoHeight > 24)
                {
                    e.Height = autoHeight;
                    e.Handled = true;
                }
        }

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "Dirección":
                    e.Column.AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
                    break;
            }
        }

        void EditarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un proveedor a editar.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (EditarButton.Text == "Editar")
            {
                DataGrid.AllowEditing = true;
                EditarButton.Text = "Guardar";
            }
            else if (EditarButton.Text == "Guardar")
            {
                var model = (ProveedorModel) DataGrid.SelectedItem;
                var updateSuccess = GlobalConfig.Connection.Proveedor_Update(model);

                if (updateSuccess)
                    MessageBox.Show($"Proveedor {model.Nombre} actualizado con éxito.", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show($"Error al actualizar proveedor {model.Nombre}.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                DataGrid.AllowEditing = false;
                EditarButton.Text = "Editar";
            }
        }

        void BorrarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un proveedor a borrar.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            var model = (ProveedorModel) DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar al proveedor {model.Nombre}? Esta acción es irreversible.",
                "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            var deleteSuccess = GlobalConfig.Connection.Proveedor_Delete(model);

            if (deleteSuccess)
            {
                DataGrid.DataSource = GetProveedores();
                MessageBox.Show($"Proveedor {model.Nombre} eliminado con éxito.", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar proveedor {model.Nombre}.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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