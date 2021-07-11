﻿using System;
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
    public partial class ClienteProductoVerForm : Form
    {
        public ClienteProductoVerForm()
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

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Id")
            {
                e.Cancel = true;
            }

            if (e.Column.MappingName == "ProductoInterno")
            {
                e.Column.HeaderText = "Producto Interno";
            }

            if (e.Column.MappingName == "PrecioUnitario")
            {
                e.Column.HeaderText = "Precio Unitario";
            }

            if (e.Column.MappingName == "IdClient")
            {
                e.Cancel = true;
            }
        }

        void EditarButton_Click(object sender, EventArgs e)
        {
            if (EditarButton.Text == "Editar")
            {
                DataGrid.AllowEditing = true;
                DataGrid.Columns["Cliente"].AllowEditing = false;
                EditarButton.Text = "Guardar";

            }
            else if (EditarButton.Text == "Guardar")
            {

                var model = (ClienteProductoModel)DataGrid.SelectedItem;
                var updateSuccess = GlobalConfig.Connection.ClienteProducto_Update(model);

                if (updateSuccess && model.Cliente != "")
                {
                    DataGrid.AllowEditing = false;
                    EditarButton.Text = "Editar";
                    MessageBox.Show($"Producto {model.ProductoInterno} para cliente {model.Cliente} actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (updateSuccess && model.Cliente == "")
                {
                    DataGrid.AllowEditing = false;
                    EditarButton.Text = "Editar";
                    MessageBox.Show($"Producto {model.ProductoInterno} actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al actualizar producto {model.ProductoInterno}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataGrid.AllowEditing = false;
                EditarButton.Text = "Editar";
            }
        }

        void BorrarButton_Click(object sender, EventArgs e)
        {
            var model = (ClienteProductoModel)DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar al producto {model.ProductoInterno}? Esta acción es irreversible.", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            var deleteSuccess = GlobalConfig.Connection.ClienteProducto_Delete(model);

            if (deleteSuccess)
            {
                DataGrid.DataSource = GetProductos();
                MessageBox.Show($"Material {model.ProductoInterno} eliminado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar material {model.ProductoInterno}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Methods

        static List<ClienteProductoModel> GetProductos()
        {
            return GlobalConfig.Connection.ClienteProducto_GetAll();
        }

        #endregion
    }
}
