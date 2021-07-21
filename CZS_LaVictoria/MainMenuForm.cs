using System;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria.AlgodónPage;
using CZS_LaVictoria.CuentasPage;
using CZS_LaVictoria.DatosPage;
using CZS_LaVictoria.ÓrdenesPage;
using CZS_LaVictoria.PlásticosPage;
using CZS_LaVictoria.TrapeadoresPage;
using CZS_LaVictoria_Library;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSplashScreen;

namespace CZS_LaVictoria
{
    public partial class MainMenuForm : RibbonForm
    {
        Form _currentChildForm;
        bool _validLicense;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        void MainMenuForm_Load(object sender, EventArgs e)
        {
            _validLicense = GlobalConfig.Connection.CZS_GetLicencia();
            var op = new FluentSplashScreenOptions
            {
                Title = "Escobas La Victoria",
                Subtitle = "Por CZ Systems",
                RightFooter = "Iniciando...",
                LeftFooter = "Copyright © 2020 - 2021 CZ Systems \nTodos los derechos reservados.",
                LoadingIndicatorType = FluentLoadingIndicatorType.Dots,
                Opacity = 30,
                OpacityColor = Color.DarkRed
            };

            SplashScreenManager.ShowFluentSplashScreen(op, parentForm: this, useFadeIn: true, useFadeOut: true);
            System.Threading.Thread.Sleep(5000);
            SplashScreenManager.CloseForm();

            if (_validLicense) return;
            MessageBox.Show("Licencia no válida o vencida.", "Error de licencia", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Application.Exit();
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

        #region Datos - Kits

        void CrearKitButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new KitCrearForm());
        }

        void VerKitsButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new KitVerForm());
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

        void VerProduccionesButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ProducciónPlásticosVerForm());
        }

        void VerPiezasMalasButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new PiezasMalasVerForm());
        }

        #endregion

        #region Algodón

        void RegistrarEscaleraButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarEscaleraForm());
        }

        void RegistrarCardasButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarCardasForm());
        }

        void RegistrarEstiradoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarEstiradoForm());
        }

        void RegistrarOpenEndButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarOpenEndForm());
        }

        void RegistrarTorceduraButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarTorceduraForm());
        }

        void RegistrarEnrolladoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarEnrolladoForm());
        }

        void VerProduccionesAlgodónButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ProducciónAlgodónVerForm());
        }

        #endregion

        #region Trapeadores

        void RegistrarTrapeadoresButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarTrapeadoresForm());
        }

        void VerProduccionesTrapeadoresButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ProducciónTrapeadoresVerForm());
        }

        #endregion

        #region Cuentas

        void VerPorPagarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new PorPagarVerForm());
        }

        void VerPagosButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new PagosPorPagarVerForm());
        }

        void VerPorCobrarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new PorCobrarVerForm());
        }

        void VerCobrosButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new PagosPorCobrarVerForm());
        }

        #endregion
    }
}
