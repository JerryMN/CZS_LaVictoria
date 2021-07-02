using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid.Enums;

namespace CZS_LaVictoria.DatosPage
{
    public partial class ClienteVerForm : Form
    {
        public ClienteVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = GetClientes();
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.HeaderText == "IdClient")
            {
                e.Column.HeaderText = "Id Cliente";
            }

            if (e.Column.HeaderText == "TeléfonoDos")
            {
                e.Column.HeaderText = "Teléfono Dos";
            }
        }

        void EditarButton_Click(object sender, EventArgs e)
        {
            if (EditarButton.Text == "Editar")
            {
                DataGrid.AllowEditing = true;
                DataGrid.Columns["IdClient"].AllowEditing = false;
                EditarButton.Text = "Guardar";

            }
            else if (EditarButton.Text == "Guardar")
            {

                var model = (ClienteModel)DataGrid.SelectedItem;
                var updateSuccess = GlobalConfig.Connection.Cliente_Update(model);

                if (updateSuccess)
                {
                    DataGrid.AllowEditing = false;
                    EditarButton.Text = "Editar";
                    MessageBox.Show($"Cliente {model.Nombre} actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al actualizar cliente {model.Nombre}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataGrid.AllowEditing = false;
                EditarButton.Text = "Editar";
            }
        }

        void BorrarButton_Click(object sender, EventArgs e)
        {
            var model = (ClienteModel)DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar al cliente {model.Nombre}? Esta acción es irreversible.", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            var deleteSuccess = GlobalConfig.Connection.Cliente_Delete(model);

            if (deleteSuccess)
            {
                DataGrid.DataSource = GetClientes();
                MessageBox.Show($"Cliente {model.Nombre} eliminado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar cliente {model.Nombre}.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Methods

        static List<ClienteModel> GetClientes()
        {
            return GlobalConfig.Connection.Cliente_GetAll();
        }

        #endregion
    }
}
