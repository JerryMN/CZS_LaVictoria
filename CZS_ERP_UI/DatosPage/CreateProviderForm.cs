using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.StructuredStorage.Internal.Writer;
using System.ComponentModel.DataAnnotations;
using CZS_ERP_Library;
using CZS_ERP_Library.Models;

namespace CZS_ERP_UI.DatosPage
{
    public partial class CreateProviderForm : DevExpress.XtraEditors.XtraForm
    {
        public CreateProviderForm()
        {
            InitializeComponent();
        }

        #region Events

        void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void TeléfonoText_Enter(object sender, EventArgs e)
        {
            TeléfonoText.SelectionStart = 1;
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;

            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var model = new ProveedorModel(NombreText.Text, TeléfonoText.Text, CorreoText.Text, DireccionText.Text, ResponsableText.Text);
            var saveSuccess = GlobalConfig.Connection.ProveedorCreate(model);

            if (saveSuccess)
            {
                ClearForm();
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
        }

        #endregion

        #region Methods

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

            if (CorreoText.Text == "" || !IsValidEmailAddress(CorreoText.Text))
            {
                output = false;
                MsgBox.Text += "Ingresa el correo del proveedor.\n";
            }

            if (DireccionText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa la dirección del proveedor.\n";
            }

            if (ResponsableText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa la persona responsable.\n";
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
                    else
                        Func(control.Controls);
            }

            Func(Controls);
        }

        #endregion
    }
}