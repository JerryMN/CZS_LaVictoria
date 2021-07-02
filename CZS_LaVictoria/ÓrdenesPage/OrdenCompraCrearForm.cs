using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CZS_ERP_Library;
using CZS_ERP_Library.Models;
using DevExpress.XtraEditors.Repository;

namespace CZS_ERP_UI.ÓrdenesPage
{
    public partial class OrdenCompraCrearForm : Form
    {
        List<PurchaseOrderLineModel> _orderLines = new List<PurchaseOrderLineModel>();
        readonly AgregarNotasForm _addNotesForm;
        int _count;

        public OrdenCompraCrearForm()
        {
            InitializeComponent();
            _addNotesForm = new AgregarNotasForm();
            GetProveedores();
            GetAreas();
        }

        #region Events

        void ProveedorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var proveedorModel = (ProveedorModel)ProveedorCombo.SelectedItem;
            GetCondiciones();
            TeléfonoText.Text = proveedorModel.Teléfono;
            CorreoText.Text = proveedorModel.Correo;
            AtencionText.Text = proveedorModel.Responsable;
            CondicionesCombo.Text = proveedorModel.Condiciones;
            GetProducts();
        }

        void AreaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProducts();
        }

        void NotasButton_Click(object sender, EventArgs e)
        {
            _ = _addNotesForm.ShowDialog();
        }

        #endregion

        #region Methods

        void GetProveedores()
        {
            ProveedorCombo.Items.Clear();
            var proveedores = GlobalConfig.Connection.Proveedor_GetAll();

            foreach (var proveedor in proveedores)
            {
                ProveedorCombo.Items.Add(proveedor);
            }

            ProveedorCombo.DisplayMember = "Nombre";
        }

        void GetAreas()
        {
            AreaCombo.Items.Clear();
            var areas = GlobalConfig.Connection.Area_GetAll();

            foreach (var area in areas)
            {
                AreaCombo.Items.Add(area);
            }

            AreaCombo.DisplayMember = "Area";
        }

        void GetCondiciones()
        {
            CondicionesCombo.Items.Clear();
            var condiciones = GlobalConfig.Connection.ProveedorCondiciones_GetDistinct();

            foreach (var condición in condiciones)
            {
                CondicionesCombo.Items.Add(condición);
            }

            CondicionesCombo.DisplayMember = "Condiciones";
        }

        void GetProducts()
        {
            var proveedorModel = (ProveedorModel)ProveedorCombo.SelectedItem;
            var riComboBox = new RepositoryItemComboBox();
            var productos = GlobalConfig.Connection.ProveedorProducto_GetByProveedorArea(proveedorModel.IdProvider, AreaCombo.Text);
            foreach (var item in productos)
            {
                riComboBox.Items.Add(item.MaterialExterno); 
            }
            GridControl.RepositoryItems.Add(riComboBox);
            GridView.Columns[0].ColumnEdit = riComboBox;

        }

        //string CrearPdf()
        //{
        //    var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //    _count = 0;

        //    //Create a new PDF document
        //    var purchaseOrder = new PdfDocument();

        //    //Add a page
        //    var page = purchaseOrder.Pages.Add();

        //    //Create a PdfGrid
        //    var pdfGridGeneral = new PdfGrid();

        //    //Create a DataTable
        //    var generalInfoTable = new DataTable();

        //    //Create a PdfGrid
        //    var pdfGridProduct = new PdfGrid();

        //    //Sección de creación de la tabla de datos generales y de proveedor
        //    generalInfoTable.Columns.Add("1");
        //    generalInfoTable.Columns.Add("2");
        //    generalInfoTable.Columns.Add("3");

        //    generalInfoTable.Rows.Add("No. orden: " + NumOrdenText.Text.Trim(), "Proveedor: " + ProveedorCombo.Text.Trim(), "Atención:" + AtencionText.Text.Trim());
        //    generalInfoTable.Rows.Add("Fecha de creación: " + FechaOrdenPicker.Value.ToString().Substring(0, 10), "Teléfono: " + TeléfonoText.Text.Trim(), "Area: " + AreaCombo.Text.Trim());
        //    generalInfoTable.Rows.Add("Fecha de entrega: " + FechaEntregaPicker.Value.ToString().Substring(0, 10), "Correo: " + CorreoText.Text.Trim(), "Condiciones: " + CondicionesCombo.Text.Trim());
        //    pdfGridGeneral.DataSource = generalInfoTable;
        //    pdfGridGeneral.BeginCellLayout += PdfGridGeneral_BeginCellLayout;
        //    var layoutFormat = new PdfGridLayoutFormat {Layout = PdfLayoutType.Paginate};
        //    PdfLayoutResult result = pdfGridGeneral.Draw(page, new PointF(10, 10), layoutFormat);

        //    //Table 2 Properties
        //    //Create pdfGrid for table 2
        //    var pdfGridProducts = new PdfGrid();
        //    //Create a DataTable
        //    var productsTable = new DataTable();

        //    //Draw grid to the resultant page of the first grid
        //    pdfGridProducts.Draw(result.Page, new PointF(10, result.Bounds.Height + 20));
        //    const string fileName = "/Compra/output.pdf";
        //    purchaseOrder.Save(path + fileName);
        //    purchaseOrder.Close(true);
        //    return path + fileName;
        //}

        #endregion
    }
}

