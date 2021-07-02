using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CZS_ERP_Library;
using CZS_ERP_Library.Models;

namespace CZS_ERP_UI.DatosPage
{
    public partial class MezclaCrearForm : Form
    {
        public MezclaCrearForm()
        {
            InitializeComponent();
            GetMateriales();
            MaterialesListBox.DisplayMember = "Nombre";
        }

        #region Events

        void AgregarButton_Click(object sender, EventArgs e)
        {
            NombreText.Enabled = false;
            MsgBox.Visible = false;
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var material = (MaterialModel)MaterialCombo.SelectedItem;
            double.TryParse(CantidadText.Text, out var cantidad);

            MaterialesListBox.Items.Add(material);
            MaterialesListBox.SelectedItem = null;
            MaterialCombo.Items.Remove(material);
            CantidadesListBox.Items.Add(cantidad);
            CantidadText.Text = "0.00";
        }

        void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MaterialesListBox.SelectedItem == null)
            {
                MsgBox.Text = "Selecciona un material a borrar.";
                MsgBox.Visible = true;
                return;
            }

            MaterialCombo.Items.Add(MaterialesListBox.SelectedItem);
            MaterialCombo.Sorted = true;
            var index = MaterialesListBox.SelectedIndex;
            MaterialesListBox.Items.RemoveAt(index);
            CantidadesListBox.Items.RemoveAt(index);
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (MaterialesListBox.Items.Count <= 1 || CantidadesListBox.Items.Count <= 1)
            {
                MsgBox.Text = "Selecciona más de un material y su cantidad.";
                MsgBox.Visible = true;
                return;
            }

            if (MaterialesListBox.Items.Count != CantidadesListBox.Items.Count)
            {
                MsgBox.Text = "Las listas no son del mismo largo. Vuelve a iniciar.";
                MsgBox.Visible = true;
                return;
            }

            var model = CreateModel();
            var saveSuccess = GlobalConfig.Connection.Mezcla_Create(model);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = $"Mezcla {model.Nombre} guardada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al crear mezcla.";
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

        void GetMateriales()
        {
            var materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Molido");

            foreach (var material in materiales)
            {
                MaterialCombo.Items.Add(material);
            }

            MaterialCombo.DisplayMember = "Nombre";
            MaterialCombo.Sorted = true;
        }

        bool ValidateForm()
        {
            var output = true;
            MsgBox.Text = "";

            if (NombreText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre de la mezcla.\n";
            }

            if (MaterialCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un material.\n";
            }

            if (CantidadText.Text == "" || CantidadText.Text == "0.00" || !double.TryParse(CantidadText.Text, out _))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad.\n";
            }

            return output;
        }

        MezclaModel CreateModel()
        {
            var model = new MezclaModel();
            var materiales = MaterialesListBox.Items.Cast<MaterialModel>().ToList();
            var cantidades = CantidadesListBox.Items.Cast<double>().ToList();
            var cantidad = CantidadesListBox.Items.Cast<object>().Sum(item => double.Parse(item.ToString()));

            model.Nombre = NombreText.Text;
            model.Materiales = materiales;
            model.Cantidades = cantidades;
            model.CantidadMezcla = cantidad;

            return model;
        }

        void ClearForm()
        {
            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox box)
                    {
                        box.Clear();
                        box.Enabled = true;
                    }
                    else if (control is ComboBox cbox)
                    {
                        cbox.Text = "";
                        cbox.SelectedItem = null;
                    }
                    else if (control is ListBox listBox)
                    {
                        listBox.Items.Clear();
                    }
                    else
                        Func(control.Controls);
            }

            Func(Controls);
        }

        #endregion
    }
}
