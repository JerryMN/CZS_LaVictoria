using CZS_LaVictoria_Library.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;

namespace CZS_LaVictoria.DatosPage
{
    public partial class OperadorVerForm : Form
    {
        public OperadorVerForm()
        {
            InitializeComponent();
            GetOperadores();
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
        }

        #region Events

        void EditarButton_Click(object sender, EventArgs e)
        {
            if (EditarButton.Text == "Editar")
            {
                DataGrid.AllowEditing = true;
                DataGrid.Columns["Id"].AllowEditing = false;
                EditarButton.Text = "Guardar";

            }
            else if (EditarButton.Text == "Guardar")
            {

                var model = (OperadorModel)DataGrid.SelectedItem;
                var updateSuccess = true; // TODO - Update.

                if (updateSuccess)
                {
                    DataGrid.AllowEditing = false;
                    EditarButton.Text = "Editar";
                    MessageBox.Show($"Operador actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al actualizar operador.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataGrid.AllowEditing = false;
                EditarButton.Text = "Editar";
            }
        }

        void BorrarButton_Click(object sender, EventArgs e)
        {
            var model = (OperadorModel)DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar al operador {model.Nombre}? Esta acción es irreversible.", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            var deleteSuccess = true; // TODO - Delete.

            if (deleteSuccess)
            {
                DataGrid.DataSource = GetOperadores();
                MessageBox.Show($"Operador {model.Nombre} eliminada con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar operador {model.Nombre}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Methods

        static List<OperadorModel> GetOperadores()
        {
            // TODO - Get.
            return new List<OperadorModel>();
        }

        #endregion
    }
}
