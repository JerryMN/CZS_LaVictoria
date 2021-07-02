using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;
using CZS_ERP_Library;
using CZS_ERP_Library.Models;

namespace CZS_ERP_UI.DatosPage
{
    public partial class ClienteCrearForm : Form
    {
        public ClienteCrearForm()
        {
            InitializeComponent();
            GetCiudad();
        }

        #region Events

        void Teléfono1Text_Enter(object sender, EventArgs e)
        {
            Teléfono1Text.SelectionStart = 1;
        }

        void Teléfono2Text_Enter(object sender, EventArgs e)
        {
            Teléfono2Text.SelectionStart = 1;
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;

            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var model = new ClienteModel(NombreText.Text, AtencionText.Text, CorreoText.Text, Teléfono1Text.Text,
                Teléfono2Text.Text, DirecciónText.Text, CiudadCombo.Text);
            var saveSuccess = GlobalConfig.Connection.Cliente_Create(model);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = $"Cliente {model.Nombre} guardado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al crear cliente.";
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

        void GetCiudad()
        {
            var ciudades = GlobalConfig.Connection.ClienteCiudad_GetDistinct();

            foreach (var ciudad in ciudades)
            {
                CiudadCombo.Items.Add(ciudad);
            }

            CiudadCombo.DisplayMember = "Ciudad";
        }

        bool ValidateForm()
        {
            var output = true;

            if (NombreText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del cliente.\n";
            }

            if (AtencionText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del contacto.\n";
            }

            if (CorreoText.Text == "" || !IsValidEmailAddress(CorreoText.Text))
            {
                output = false;
                MsgBox.Text += "Ingresa el correo del cliente.\n";
            }

            if (Teléfono1Text.Text == "(   )         ")
            {
                output = false;
                MsgBox.Text += "Ingresa el teléfono del cliente.\n";
            }

            if (DirecciónText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa la dirección del cliente.\n";
            }

            if (CiudadCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa la ciudad del cliente.\n";
            }

            return output;
        }

        static bool IsValidEmailAddress(string address) => address != null && new EmailAddressAttribute().IsValid(address);

        void ClearForm()
        {
            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox box)
                        box.Clear();
                    else if (control is ComboBox cbox)
                    {
                        cbox.SelectedItem = null;
                    }
                    else
                        Func(control.Controls);
            }

            Func(Controls);
        }

        #endregion
    }
}
