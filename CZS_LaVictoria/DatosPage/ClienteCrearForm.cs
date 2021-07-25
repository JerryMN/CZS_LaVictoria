using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.DatosPage
{
    public partial class ClienteCrearForm : Form
    {
        public ClienteCrearForm()
        {
            InitializeComponent();
            GetCiudad();
            if (GlobalConfig.Connection.CZS_GetLicencia()) return;
            MessageBox.Show(
                "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
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
            MsgBox.Text = "";

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
                Tools.ClearForm(this);
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
            var ciudades = GlobalConfig.Connection.Cliente_GetDistinctCiudades();

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

            if (CorreoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el correo del cliente.\n";
            }
            else
            {
                try
                {
                    var unused = new MailAddress(CorreoText.Text);
                }
                catch (Exception)
                {
                    output = false;
                    MsgBox.Text += "Ingresa un correo válido.\n";
                }
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

        #endregion
    }
}
