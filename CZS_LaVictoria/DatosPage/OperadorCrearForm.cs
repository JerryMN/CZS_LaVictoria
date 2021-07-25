using CZS_LaVictoria_Library;
using System;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.ListView.Enums;

namespace CZS_LaVictoria.DatosPage
{
    public partial class OperadorCrearForm : Form
    {
        public OperadorCrearForm()
        {
            InitializeComponent();
            GetOperadores();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "Área":
                    e.Column = new GridComboBoxColumn
                        { MappingName = "Área", HeaderText = "Área", DropDownStyle = DropDownStyle.DropDownList };
                    break;
            }
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var model = new OperadorModel {Nombre = OperadorText.Text, Área = AreaCombo.Text};

            var saveSuccess = GlobalConfig.Connection.Operator_Create(model);

            if (saveSuccess)
            {
                Tools.ClearForm(this);
                MsgBox.Text = $"Operador {model.Nombre} registrado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
                GetOperadores();
            }
            else
            {
                MsgBox.Text = $"Error al registrar operador {model.Nombre}.";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void EditarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un operador a editar.", "Error", MessageBoxButtons.OK,
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

                var model = (OperadorModel)DataGrid.SelectedItem;
                var updateSuccess = GlobalConfig.Connection.Operator_Update(model);

                if (updateSuccess)
                {
                    MsgBox.Text = $"Operador {model.Nombre} actualizado con éxito.";
                    MsgBox.IconColor = Color.DarkGreen;
                }
                else
                {
                    MsgBox.Text = $"Error al actualizar operador {model.Nombre}";
                    MsgBox.IconColor = Color.DarkRed;
                }

                DataGrid.AllowEditing = false;
                EditarButton.Text = "Editar";
                MsgBox.Visible = true;
                MsgBoxTimer.Start();
            }
        }

        void BorrarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un operador a borrar.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            var model = (OperadorModel)DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar al operador {model.Nombre}? Esta acción es irreversible.", 
                "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            var deleteSuccess = GlobalConfig.Connection.Operator_Delete(model);

            if (deleteSuccess)
            {
                GetOperadores();
                MsgBox.Text = $"Operador {model.Nombre} eliminado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = $"Error al eliminar operador {model.Nombre}.";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void MsgBoxTimer_Tick(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBoxTimer.Stop();
        }

        #endregion

        #region Methods

        void GetOperadores()
        {
            DataGrid.DataSource = GlobalConfig.Connection.Operador_GetAll();
            GetAreas();
        }

        void GetAreas()
        {
            var areas = GlobalConfig.Connection.Area_GetDistinct();
            AreaCombo.Items.Clear();

            foreach (var area in areas)
            {
                AreaCombo.Items.Add(area);
            }

            ((GridComboBoxColumn)DataGrid.Columns["Área"]).DataSource = areas;
        }

        bool ValidateForm()
        {
            var output = true;

            if (OperadorText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del operador.\n";
            }

            if (AreaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el área del operador.\n";
            }

            return output;
        }

        #endregion
    }
}
