using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CZS_ERP_UI.DatosPage;

namespace CZS_ERP_UI
{
    public partial class MainMenuForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Form _currentChildForm;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        void CreatePOButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildForm(new PurchaseOrderForm());
        }

        void CreateSOButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void CreateProviderButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildForm(new CreateProviderForm());
        }

        void ViewProvidersButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildForm(new ViewProvidersForm());
        }

        void CreateMaterialButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildForm(new CreateProviderMaterialForm());
        }

        /// <summary>
        /// Abre un formulario dentro del formulario principal.
        /// </summary>
        /// <param name="childForm">El formulario a abrir.</param>
        void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildPanel.Controls.Add(childForm);
            ChildPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            _currentChildForm?.Close();
            _currentChildForm = childForm;
        }
    }
}
