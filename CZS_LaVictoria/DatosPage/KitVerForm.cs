using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.DatosPage
{
    public partial class KitVerForm : Form
    {
        KitModel _selectedModel = new KitModel();

        public KitVerForm()
        {
            InitializeComponent();
            GetKits();
        }

        #region Events

        void NombreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (NombreCombo.SelectedIndex < 0) return;

            MaterialesListBox.Items.Clear();
            CantidadesListBox.Items.Clear();

            _selectedModel = (KitModel) NombreCombo.SelectedItem;
            Debug.Assert(_selectedModel?.Materiales != null, "selected?.Materiales != null");

            foreach (var material in _selectedModel?.Materiales) MaterialesListBox.Items.Add(material.Nombre);

            foreach (var cantidad in _selectedModel?.Cantidades) CantidadesListBox.Items.Add(cantidad);
        }

        void EliminarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (NombreCombo.SelectedIndex < 0)
            {
                MsgBox.Text = "Selecciona un kit a borrar.";
                MsgBox.IconColor = Color.DarkRed;
                MsgBox.Visible = true;
                return;
            }

            if (MessageBox.Show(
                $"Estás seguro de eliminar el kit {_selectedModel.Nombre}? Esta acción es irreversible.", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            var deleteSuccess = GlobalConfig.Connection.Kit_Delete(_selectedModel);

            if (deleteSuccess)
            {
                Tools.ClearForm(this);
                GetKits();
                MsgBox.Text = $"Kit {_selectedModel.Nombre} eliminado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = $"Error al eliminar kit {_selectedModel.Nombre}.";
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

        void GetKits()
        {
            var kits = GlobalConfig.Connection.Kit_GetAll();

            foreach (var kit in kits) NombreCombo.Items.Add(kit);

            NombreCombo.DisplayMember = "Nombre";
        }
        
        #endregion
    }
}