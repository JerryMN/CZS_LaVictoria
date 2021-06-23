using CZS_ERP_Library;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CZS_ERP_UI.DatosPage
{
    public partial class CreateProviderMaterialForm : DevExpress.XtraEditors.XtraForm
    {
        public CreateProviderMaterialForm()
        {
            InitializeComponent();

            LoadProveedores();
        }

        #region Events

        void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
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