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

namespace CZS_LaVictoria.CuentasPage
{
    public partial class GastosFijosForm : Form
    {
        public GastosFijosForm()
        {
            InitializeComponent();
            DataGrid.DataSource = LoadTable();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            if (GlobalConfig.Connection.CZS_GetLicencia()) return;
            MessageBox.Show(
                "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "Monto":
                    e.Column = new GridNumericColumn
                        {MappingName = "Monto", HeaderText = "Monto", FormatMode = FormatMode.Currency};
                    break;
            }
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var model = new GastoFijoModel(ConceptoText.Text, MontoText.Text);

            var saveSuccess = GlobalConfig.Connection.GastoFijo_Create(model);

            if (saveSuccess)
            {
                Tools.ClearForm(this);
                MontoText.Text = "0.00";
                MsgBox.Text = $"Gasto {model.Concepto} registrado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
                DataGrid.DataSource = LoadTable();
            }
            else
            {
                MsgBox.Text = $"Error al registrar gasto {model.Concepto}.";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void EditarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un gasto a editar.", "Error", MessageBoxButtons.OK,
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
                var model = (GastoFijoModel) DataGrid.SelectedItem;
                var updateSuccess = GlobalConfig.Connection.GastoFijo_Update(model);

                if (updateSuccess)
                {
                    MsgBox.Text = $"Gasto {model.Concepto} actualizado con éxito.";
                    MsgBox.IconColor = Color.DarkGreen;
                }
                else
                {
                    MsgBox.Text = $"Error al actualizar gasto {model.Concepto}";
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
                MessageBox.Show("Selecciona un gasto a borrar.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            var model = (GastoFijoModel) DataGrid.SelectedItem;

            if (MessageBox.Show($"Estás seguro de eliminar al gasto {model.Concepto}? Esta acción es irreversible.",
                "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            var deleteSuccess = GlobalConfig.Connection.GastoFijo_Delete(model);

            if (deleteSuccess)
            {
                LoadTable();
                MsgBox.Text = $"Gasto {model.Concepto} eliminado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = $"Error al eliminar gasto {model.Concepto}.";
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

        static List<GastoFijoModel> LoadTable()
        {
            return GlobalConfig.Connection.GastoFijo_GetAll();
        }

        bool ValidateForm()
        {
            var output = true;

            if (ConceptoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el concepto del gasto.\n";
            }

            if (MontoText.Text == "$0.00")
            {
                output = false;
                MsgBox.Text += "Ingresa el monto del gasto.\n";
            }

            return output;
        }

        #endregion
    }
}