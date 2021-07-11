using System;
using System.Collections;
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
        MezclaModel _selectedModel;

        public MezclaVerForm()
        {
            InitializeComponent();
            GetMezclas();
        }

        #region Events

        void NombreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NombreCombo.SelectedItem == null) return;

            MaterialesListBox.Items.Clear();
            CantidadesListBox.Items.Clear();

            _selectedModel = NombreCombo.SelectedItem as MezclaModel;
            Debug.Assert(_selectedModel?.Materiales != null, "selected?.Materiales != null");

            foreach (var material in _selectedModel?.Materiales)
            {
                MaterialesListBox.Items.Add(material.Nombre);
            }

            foreach (var cantidad in _selectedModel?.Cantidades)
            {
                CantidadesListBox.Items.Add(cantidad);
            }

            CantidadText.Text = _selectedModel.CantidadMezcla.ToString(CultureInfo.InvariantCulture);
        }

        void EliminarButton_Click(object sender, EventArgs e)
        {
            if (_selectedModel == null) return;

            var deleteSuccess = GlobalConfig.Connection.Mezcla_Delete(_selectedModel);

            if (deleteSuccess)
            {
                ClearForm();
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

            foreach (var mezcla in mezclas)
            {
                NombreCombo.Items.Add(mezcla);
            }

            NombreCombo.DisplayMember = "Nombre";
        }

        void ClearForm()
        {
            CantidadText.Text = "0";
            MaterialesListBox.Items.Clear();
            CantidadesListBox.Items.Clear();

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
