using System.Windows.Forms;
using CZS_LaVictoria.DatosPage;
using CZS_LaVictoria.ÓrdenesPage;
using CZS_LaVictoria.PlásticosPage;
using DevExpress.XtraBars;

namespace CZS_LaVictoria
{
    public partial class MainMenuForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Form _currentChildForm;

        public MainMenuForm()
        {
            InitializeComponent();
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

        void OpcionesBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new OpcionesForm());
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

        void VerInventarioButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new InventarioVerForm());
        }

        void VerHistorialButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new HistorialVerForm());
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
            OpenChildForm(new MezclaVerForm());
        }

        #endregion

        #region Datos - Personal

        void CrearOperadorButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new OperadorCrearForm());
        }

        #endregion

        #region Plásticos

        void RegistrarMolidoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarMolidoForm());
        }

        void RegistrarExtruídoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarExtruídoForm());
        }

        void RegistrarCortadoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarCortadoForm());
        }

        void RegistrarInyecciónMezclaButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarInyecciónMezclaForm());
        }

        void RegistrarInyecciónButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarInyecciónForm());
        }

        void RegistrarInsertadoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarInsertadoForm());
        }

        #endregion
    }
}
