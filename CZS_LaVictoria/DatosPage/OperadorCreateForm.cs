using CZS_LaVictoria_Library;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.ListView.Enums;

namespace CZS_LaVictoria.DatosPage
{
    public partial class OperadorCreateForm : Form
    {
        public OperadorCreateForm()
        {
            InitializeComponent();
            GetOperadores();
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Nombre")
            {
                e.Column.AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
            }

            if (e.Column.MappingName == "Area")
            {
                e.Column = new GridComboBoxColumn
                    { MappingName = "Area", HeaderText = "Área", DropDownStyle = DropDownStyle.DropDownList };
            }
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var model = new OperadorModel {Nombre = OperadorText.Text, Area = AreaCombo.Text};

            var saveSuccess = GlobalConfig.Connection.Operator_Create(model);

            if (saveSuccess)
            {
                ClearForm();
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
            if (EditarButton.Text == "Editar")
            {
                DataGrid.AllowEditing = true;
                DataGrid.Columns["Id"].AllowEditing = false;
                EditarButton.Text = "Guardar";

            }
            else if (EditarButton.Text == "Guardar")
            {

                var model = (OperadorModel)DataGrid.SelectedItem;
                var updateSuccess = GlobalConfig.Connection.Operator_Update(model);

                if (updateSuccess)
                {
                    DataGrid.AllowEditing = false;
                    EditarButton.Text = "Editar";
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
            var model = (OperadorModel)DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar al operador {model.Nombre}? Esta acción es irreversible.", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
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
            var areas = GlobalConfig.Connection.Area_GetAll();
            AreaCombo.Items.Clear();

            foreach (var area in areas)
            {
                AreaCombo.Items.Add(area);
            }

            AreaCombo.DisplayMember = "Area";

            ((GridComboBoxColumn)DataGrid.Columns["Area"]).DataSource = areas;
            ((GridComboBoxColumn)DataGrid.Columns["Area"]).DisplayMember = "Area";
            ((GridComboBoxColumn)DataGrid.Columns["Area"]).ValueMember = "Area";
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

        void ClearForm()
        {
            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox box)
                        box.Clear();
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.Text = "";
                        comboBox.SelectedItem = null;
                    }
                    else
                        Func(control.Controls);
            }

            Func(Controls);
        }

        #endregion
    }
}
