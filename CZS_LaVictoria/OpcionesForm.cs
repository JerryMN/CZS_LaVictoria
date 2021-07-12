using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace CZS_LaVictoria
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
            if (!ValidatePreferences())
            {
                MsgBox.IconColor = Color.DarkRed;
                MsgBox.Visible = true;
                return;
            }

            Properties.Settings.Default.smtpServer = SmtpText.Text;
            Properties.Settings.Default.emailAddress = CorreoText.Text;
            Properties.Settings.Default.emailPassword = ContraseñaText.Text;
            Properties.Settings.Default.Save();

            MsgBox.Text = "Datos guardados exitosamente.";
            MsgBox.IconColor = Color.DarkGreen;
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
            SmtpText.Text = Properties.Settings.Default.smtpServer;
            CorreoText.Text = Properties.Settings.Default.emailAddress;
            ContraseñaText.Text = Properties.Settings.Default.emailPassword;
        }

        bool ValidatePreferences()
        {
            var output = true;

            if (SmtpText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el servidor SMTP.\n";
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
