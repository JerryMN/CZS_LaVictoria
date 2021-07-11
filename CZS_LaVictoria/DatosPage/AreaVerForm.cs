using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Styles;

namespace CZS_LaVictoria.DatosPage
{
    public partial class AreaVerForm : Form
    {
        public AreaVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = GetAreas();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.HeaderText == "Id")
            {
                e.Cancel = true;
            }
        }

        void EditarButton_Click(object sender, EventArgs e)
        {
            if (EditarButton.Text == "Editar")
            {
                DataGrid.AllowEditing = true;
                EditarButton.Text = "Guardar";

            }
            else if (EditarButton.Text == "Guardar")
            {

                var model = (AreaModel)DataGrid.SelectedItem;
                var updateSuccess = GlobalConfig.Connection.Area_Update(model);

                if (updateSuccess)
                {
                    DataGrid.AllowEditing = false;
                    EditarButton.Text = "Editar";
                    MessageBox.Show($"Área {model.Área} actualizada con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al actualizar área {model.Área}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataGrid.AllowEditing = false;
                EditarButton.Text = "Editar";
            }
        }

        void BorrarButton_Click(object sender, EventArgs e)
        {
            var model = (AreaModel)DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar el área {model.Área}? Esta acción es irreversible.", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            var deleteSuccess = GlobalConfig.Connection.Area_Delete(model);

            if (deleteSuccess)
            {
                DataGrid.DataSource = GetAreas();
                MessageBox.Show($"Área {model.Área} eliminada con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar área {model.Área}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Methods

        static List<AreaModel> GetAreas()
        {
            return GlobalConfig.Connection.Area_GetAll();
        }

        #endregion
    }
}
