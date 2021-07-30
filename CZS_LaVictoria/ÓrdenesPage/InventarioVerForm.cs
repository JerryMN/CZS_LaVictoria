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

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class InventarioVerForm : Form
    {
        public InventarioVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = GetStock();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCellsWithLastColumnFill;
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "Nombre":
                    e.Column.AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
                    break;
                case "CantidadDisponible":
                    e.Column = new GridNumericColumn
                    {
                        MappingName = "CantidadDisponible",
                        HeaderText = "Cantidad Disponible",
                        FormatMode = FormatMode.Numeric
                    };
                    break;
            }
        }

        void NuevoButton_Click(object sender, EventArgs e)
        {
            var newForm = new InventarioCrearForm();
            newForm.Show();
            newForm.Disposed += FormOnDisposed;
        }

        void EditarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un material a editar.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var editForm = new InventarioEditarForm((MaterialModel) DataGrid.SelectedItem);
            editForm.Show();
            editForm.Disposed += FormOnDisposed;
        }

        void BorrarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un material a borrar.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var model = (MaterialModel) DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar el material \"{model.Nombre}\"? Esta acción es irreversible.",
                "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            var deleteSuccess = GlobalConfig.Connection.Material_Delete(model);

            if (deleteSuccess)
            {
                DataGrid.DataSource = GetStock();
                MessageBox.Show($"Material \"{model.Nombre}\" eliminado con éxito.", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar material \"{model.Área}\".", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        void FormOnDisposed(object sender, EventArgs e)
        {
            DataGrid.DataSource = GetStock();
        }

        #endregion

        #region Methods

        static List<MaterialModel> GetStock()
        {
            return GlobalConfig.Connection.Material_GetAll();
        }

        #endregion
    }
}