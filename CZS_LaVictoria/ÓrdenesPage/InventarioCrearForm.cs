using CZS_LaVictoria_Library;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class InventarioCrearForm : Form
    {
        public InventarioCrearForm()
        {
            InitializeComponent();
            GetAreas();
            GetCategorías();
        }

        #region Events

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var material = new MaterialModel(MaterialText.Text, AreaCombo.Text, CategoríaCombo.Text, CantidadText.Text);
            var saveSuccess = GlobalConfig.Connection.Material_Create(material);

            if (saveSuccess)
            {
                MsgBox.Text = $"{MaterialText.Text} guardado en inventario";
                MsgBox.IconColor = Color.DarkGreen;
                ClearForm();
            }
            else
            {
                MsgBox.Text = $"Ocurrió un error al guardar {MaterialText.Text}";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void MsgBoxTimer_Tick(object sender, EventArgs e)
        {
            MsgBoxTimer.Stop();
            MsgBox.Visible = false;
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

        void GetCategorías()
        {
            var categorías = GlobalConfig.Connection.Material_GetDistinctCategorías();

            foreach (var categoría in categorías)
            {
                if (categoría != null) CategoríaCombo.Items.Add(categoría);
            }
        }

        bool ValidateForm()
        {
            var output = true;

            if (MaterialText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del material.\n";
            }

            if (AreaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un área.\n";
            }

            if (CategoríaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa una categoría.\n";
            }

            if (CantidadText.Text == "0.00")
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad en inventario.\n";
            }

            return output;
        }

        void ClearForm()
        {
            CantidadText.Text = "0";
            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox box)
                        box.Clear();
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.SelectedItem = null;
                        comboBox.Text = "";
                    }
                    else
                        Func(control.Controls);
            }

            Func(Controls);
        }

        #endregion
    }
}
