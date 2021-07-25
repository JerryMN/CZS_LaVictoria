using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using CZS_LaVictoria.Properties;

namespace CZS_LaVictoria.DatosPage
{
    public partial class OpcionesForm : Form
    {
        public OpcionesForm()
        {
            InitializeComponent();
            LoadPreferences();
        }

        #region Events

        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (!ValidatePreferences())
            {
                MsgBox.IconColor = Color.DarkRed;
                MsgBox.Visible = true;
                return;
            }

            Settings.Default.smtpServer = SmtpText.Text;
            Settings.Default.smtpPort = PuertoText.Text;
            Settings.Default.emailAddress = CorreoText.Text;
            Settings.Default.emailPassword = ContraseñaText.Text;
            Settings.Default.Save();

            MsgBox.Text = "Datos guardados exitosamente.";
            MsgBox.IconColor = Color.DarkGreen;
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

        void LoadPreferences()
        {
            SmtpText.Text = Settings.Default.smtpServer;
            PuertoText.Text = Settings.Default.smtpPort;
            CorreoText.Text = Settings.Default.emailAddress;
            ContraseñaText.Text = Settings.Default.emailPassword;
        }

        bool ValidatePreferences()
        {
            var output = true;

            if (SmtpText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el servidor SMTP.\n";
            }

            if (PuertoText.Text == "" || !int.TryParse(PuertoText.Text, out _))
            {
                output = false;
                MsgBox.Text += "Ingresa el puerto SMTP.\n";
            }

            if (CorreoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa la dirección de la que van a salir los correos.\n";
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

            if (ContraseñaText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa la contraseña del correo ingresado.\n";
            }

            return output;
        }

        #endregion
    }
}