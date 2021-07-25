using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.DatosPage
{
    public partial class MezclaCrearForm : Form
    {
        public MezclaCrearForm()
        {
            InitializeComponent();
            GetMateriales();
            MaterialesListBox.DisplayMember = "Nombre";
            if (GlobalConfig.Connection.CZS_GetLicencia()) return;
            MessageBox.Show(
                "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        #region Events

        void AgregarButton_Click(object sender, EventArgs e)
        {
            NombreText.Enabled = false;
            MsgBox.Visible = false;
            MsgBox.Text = "";

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

            var model = new MezclaModel
            {
                Nombre = NombreText.Text,
                Materiales = MaterialesListBox.Items.Cast<MaterialModel>().ToList(),
                Cantidades = CantidadesListBox.Items.Cast<double>().ToList(),
                CantidadMezcla = CantidadesListBox.Items.Cast<object>().Sum(item => double.Parse(item.ToString()))
            };

            var saveSuccess = GlobalConfig.Connection.Mezcla_Create(model);

            if (saveSuccess)
            {
                Tools.ClearForm(this);
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

        #endregion
    }
}
