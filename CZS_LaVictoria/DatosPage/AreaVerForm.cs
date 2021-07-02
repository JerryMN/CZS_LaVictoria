using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid.Enums;

namespace CZS_LaVictoria.DatosPage
{
    public partial class AreaVerForm : Form
    {
        public AreaVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = GetAreas();
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.HeaderText == "IdArea")
            {
                e.Column.HeaderText = "Id Área";
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
                DataGrid.Columns["IdArea"].AllowEditing = false;
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
                    MessageBox.Show($"Área actualizada con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al actualizar área.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataGrid.AllowEditing = false;
                EditarButton.Text = "Editar";
            }
        }

        void BorrarButton_Click(object sender, EventArgs e)
        {
            var model = (AreaModel)DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar la área {model.Area}? Esta acción es irreversible.", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            var deleteSuccess = GlobalConfig.Connection.Area_Delete(model);

            if (deleteSuccess)
            {
                DataGrid.DataSource = GetAreas();
                MessageBox.Show($"Área {model.Area} eliminada con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar área {model.Area}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
