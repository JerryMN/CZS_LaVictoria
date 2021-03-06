using System;
using System.Drawing;
using System.Threading;
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

        public MainMenuForm()
        {
            InitializeComponent();
        }

        void MainMenuForm_Load(object sender, EventArgs e)
        {
            var licencia = GlobalConfig.Connection.CZS_SelectLicencia();
            var op = new FluentSplashScreenOptions
            {
                Title = "Escobas La Victoria",
                Subtitle = "Por CZ Systems",
                RightFooter = "Iniciando...",
                LeftFooter = $"Copyright © 2021 CZ Systems \nVersión {Application.ProductVersion}",
                LoadingIndicatorType = FluentLoadingIndicatorType.Dots,
                Opacity = 50,
                OpacityColor = Color.DarkRed
            };

            SplashScreenManager.ShowFluentSplashScreen(op, parentForm: this, useFadeIn: true, useFadeOut: true);
            Thread.Sleep(3000);
            SplashScreenManager.CloseForm();

            var días = (licencia.SigPago - DateTime.Today).TotalDays;
            if (!licencia.Habilitado)
            {
                MessageBox.Show(
                    "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                    "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (días <= 15)
            {
                MessageBox.Show($"La licencia caducará el {licencia.SigPago:dd/MMM/yyyy} (en {días} día(s)).",
                    "Aviso de licencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        ///     Abre un formulario dentro del formulario principal.
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

        void AboutButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show($"Versión {Application.ProductVersion}.", "Información", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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

        void VerReporteInventario_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ReporteInventarioForm());
        }

        void VerHistorialButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new HistorialVerForm());
        }

        void VerReporteCompras_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ReporteHistorialCompraForm());
        }

        void VerReporteVentas_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ReporteHistorialVentaForm());
        }

        #endregion

        #region Plásticos

        void RegistrarMolidoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarMolidoForm());
        }

        void RegistrarExtruídoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RegistrarExtruidoForm());
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

        void VerPiezasMalasButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new PiezasMalasVerForm());
        }

        void ProcesarPiezasMalasButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RetrabajoCrearForm());
        }

        void VerRetrabajosButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new RetrabajoVerForm());
        }

        void VerProduccionesButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ProducciónPlásticosVerForm());
        }

        void VerReporteProducciónPlásticosButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ReporteProducciónPlásticosForm());
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

        void VerReporteProducciónAlgodónButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ReporteProducciónAlgodónForm());
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

        void VerReporteProducciónTrapeadoresButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ReporteProducciónTrapeadoresForm());
        }

        #endregion

        #region Cuentas

        void CrearGastoFijoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new GastosFijosForm());
        }

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

        void VerCalculadoraButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new CalculadoraForm());
        }

        void VerGastosFijosButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ReporteGastosFijosForm());
        }

        void VerPagosHechosButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ReportePorPagarForm());
        }

        void VerCobrosRecibidosButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ReportePorCobrarForm());
        }

        void VerCuentasButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new ReporteCuentasForm());
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

        #region Datos - Correo

        void ConfigurarCorreoButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenChildForm(new OpcionesForm());
        }

        #endregion
    }
}