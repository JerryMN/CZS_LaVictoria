using CZS_LaVictoria_Library;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace CZS_LaVictoria.DatosPage
{
    public partial class OperadorCreateForm : Form
    {
        public OperadorCreateForm()
        {
            InitializeComponent();
            GetAreas();
        }

        #region Events

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var saveSuccess = true; // TODO - Save.

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Molido registrado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar molido.";
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

        void GetAreas()
        {
            var areas = GlobalConfig.Connection.Area_GetAll();

            foreach (var area in areas)
            {
                AreaCombo.Items.Add(area);
            }

            AreaCombo.DisplayMember = "Area";
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
