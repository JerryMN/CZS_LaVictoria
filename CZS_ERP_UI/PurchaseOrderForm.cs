using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CZS_ERP_Library;
using CZS_ERP_Library.Models;

namespace CZS_ERP_UI
{
    public partial class PurchaseOrderForm : XtraForm
    {
        public PurchaseOrderForm()
        {
            InitializeComponent();

            FechaText.Text = DateTime.Today.ToShortDateString();

            FechaEntregaPicker.Value = DateTime.Today;
            FechaEntregaPicker.Culture = new CultureInfo("es-MX");
            FechaEntregaPicker.AllowValueChangeOnMouseWheel = true;
            FechaEntregaPicker.DropDownSize = new Size(250, 250);

            LoadProveedores();

            
        }

        #region Events

        void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void EditOrderCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (EditOrderCheck.Checked)
            {
                OrdenText.ReadOnly = false;
            }
            else
            {
                var isNumber = int.TryParse(OrdenText.Text, out var numberResult);

                if (!isNumber)
                {
                    MessageBox.Show("Ingresa un número como Número de Orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OrdenText.Text = "";
                    OrdenText.Focus();
                    return;
                }

                OrdenText.ReadOnly = true;
            }
        }

        void ProveedorCombo_TextChanged(object sender, EventArgs e)
        {
            var selected = (ProveedorModel)ProveedorCombo.SelectedItem;

            TeléfonoText.Text = selected.Telefono;
            DirecciónText.Text = selected.Direccion;
        }

        #endregion

        #region Methods

        void LoadProveedores()
        {
            var proveedores = GlobalConfig.Connection.ProveedorGetAll();
            foreach (var proveedor in proveedores)
            {
                ProveedorCombo.Items.Add(proveedor);
            }

            ProveedorCombo.DisplayMember = "nombre";
        }

        #endregion
    }
}