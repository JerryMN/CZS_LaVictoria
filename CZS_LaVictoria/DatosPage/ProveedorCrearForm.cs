using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.DatosPage
{
    public partial class ProveedorCrearForm : Form
    {
        public ProveedorCrearForm()
        {
            InitializeComponent();
            GetCondiciones();
            if (GlobalConfig.Connection.CZS_GetLicencia()) return;
            MessageBox.Show(
                "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        void TeléfonoText_Enter(object sender, EventArgs e)
        {
            TeléfonoText.SelectionStart = 1;
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

            var model = new ProveedorModel(NombreText.Text, TeléfonoText.Text, CorreoText.Text, DirecciónText.Text,
                ResponsableText.Text, CondicionesCombo.Text);
            var saveSuccess = GlobalConfig.Connection.Proveedor_Create(model);

            if (saveSuccess)
            {
                Tools.ClearForm(this);
                MsgBox.Text = $"Proveedor {model.Nombre} guardado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al crear proveedor.";
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

        #region Methods

        void GetCondiciones()
        {
            var condiciones = GlobalConfig.Connection.Proveedor_GetDistinctCondiciones();

            foreach (var condición in condiciones) CondicionesCombo.Items.Add(condición);

            CondicionesCombo.DisplayMember = "Condiciones";
        }

        bool ValidateForm()
        {
            var output = true;

            if (NombreText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del proveedor.\n";
            }

            if (TeléfonoText.Text == "(   )         ")
            {
                output = false;
                MsgBox.Text += "Ingresa el teléfono del proveedor.\n";
            }

            if (CorreoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el correo del proveedor.\n";
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

            if (ResponsableText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa la persona responsable.\n";
            }

            return output;
        }

        #endregion
    }
}