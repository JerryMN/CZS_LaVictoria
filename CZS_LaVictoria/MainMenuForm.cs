using DevExpress.XtraBars;
using System.Windows.Forms;
using CZS_ERP_UI.DatosPage;
using CZS_ERP_UI.ÓrdenesPage;

namespace CZS_ERP_UI
{
    public partial class MainMenuForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Form _currentChildForm;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        #region Ordenes

        void CrearOrdenCompraButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new OrdenCompraCrearForm());
        }

        void VerOrdenCompraButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new OrdenCompraVerForm());
        }

        void CrearOrdenVentaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new OrdenVentaCrearForm());
        }

        void VerOrdenVentaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new OrdenVentaVerForm());
        }

        #endregion

        #region Datos - Proveedores

        void CrearProveedorButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ProveedorCrearForm());
        }

        void VerProveedoresButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ProveedorVerForm());
        }

        void CrearMaterialButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ProveedorProductoCrearForm());
        }

        void VerMaterialesButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ProveedorProductoVerForm());
        }

        #endregion

        #region Datos - Clientes

        void CrearClienteButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ClienteCrearForm());
        }

        void VerClientesButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ClienteVerForm());
        }

        void CrearProductoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ClienteProductoCrearForm());
        }

        void VerProductosButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ClienteProductoVerForm());
        }

        #endregion

        #region Datos - Areas

        void CrearAreaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new AreaCrearForm());
        }

        void VerAreasButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new AreaVerForm());
        }

        #endregion

        #region Datos - Mezclas

        void CrearMezclaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new MezclaCrearForm());
        }

        void VerMezclasButton_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        #endregion

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
