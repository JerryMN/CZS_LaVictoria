using System;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
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
            MsgBox.Visible = false;
            MsgBox.Text = "";

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
                Tools.ClearForm(this);
                CantidadText.Text = "0";
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
            var areas = GlobalConfig.Connection.Area_GetDistinct();

            foreach (var area in areas) AreaCombo.Items.Add(area);
        }

        void GetCategorías()
        {
            CategoríaCombo.Items.AddRange(new object[]
            {
                "Por Moler", "Molido", "Alambre", "Algodón Sucio", "Bases", "Caja", "Cortado", "Extruido",
                "Producto Terminado"
            });

            CategoríaCombo.Sorted = true;
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

        #endregion
    }
}