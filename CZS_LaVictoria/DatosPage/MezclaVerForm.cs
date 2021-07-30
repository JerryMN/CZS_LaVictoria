using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.DatosPage
{
    public partial class MezclaVerForm : Form
    {
        MezclaModel _selectedModel = new MezclaModel();

        public MezclaVerForm()
        {
            InitializeComponent();
            GetMezclas();
        }

        #region Events

        void NombreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (NombreCombo.SelectedIndex < 0) return;

            MaterialesListBox.Items.Clear();
            CantidadesListBox.Items.Clear();

            _selectedModel = (MezclaModel) NombreCombo.SelectedItem;
            Debug.Assert(_selectedModel?.Materiales != null, "selected?.Materiales != null");

            foreach (var material in _selectedModel?.Materiales) MaterialesListBox.Items.Add(material.Nombre);

            foreach (var cantidad in _selectedModel?.Cantidades) CantidadesListBox.Items.Add(cantidad);

            CantidadText.Text = _selectedModel.CantidadMezcla.ToString(CultureInfo.CurrentUICulture);
        }

        void EliminarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (NombreCombo.SelectedIndex < 0)
            {
                MsgBox.Text = "Selecciona una mezcla a borrar.";
                MsgBox.IconColor = Color.DarkRed;
                MsgBox.Visible = true;
                return;
            }

            if (MessageBox.Show(
                $"Estás seguro de eliminar la mezcla {_selectedModel.Nombre}? Esta acción es irreversible.", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            var deleteSuccess = GlobalConfig.Connection.Mezcla_Delete(_selectedModel);

            if (deleteSuccess)
            {
                Tools.ClearForm(this);
                CantidadText.Text = "0.00";
                GetMezclas();
                MsgBox.Text = $"Mezcla {_selectedModel.Nombre} eliminada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = $"Error al eliminar mezcla {_selectedModel.Nombre}.";
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

        void GetMezclas()
        {
            var mezclas = GlobalConfig.Connection.Mezcla_GetAll();

            foreach (var mezcla in mezclas) NombreCombo.Items.Add(mezcla);

            NombreCombo.DisplayMember = "Nombre";
        }

        #endregion
    }
}