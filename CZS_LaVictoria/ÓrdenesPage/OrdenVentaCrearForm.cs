using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CZS_ERP_Library;
using CZS_ERP_Library.Models;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.Input.Enums;

namespace CZS_ERP_UI.ÓrdenesPage
{
    public partial class OrdenVentaCrearForm : Form
    {
        List<SaleOrderLineModel> _orderLines = new List<SaleOrderLineModel>();
        readonly AgregarNotasForm _addNotesForm;
        int _count;
        ClienteModel _selectedClient;

        public OrdenVentaCrearForm()
        {
            InitializeComponent();
            _addNotesForm = new AgregarNotasForm();
            GetClientes();
            GetAreas();
            DataGrid.DataSource = _orderLines;
            DataGrid.Columns["NumLinea"].Visible = false;
            DataGrid.Columns["CantidadEntregada"].Visible = false;
            DataGrid.Columns["CantidadPendiente"].Visible = false;
            TransporteCombo.Items.AddRange(new object[]{"Cliente", "Propio"});
            PuestoCombo.Items.AddRange(new object[]{"Cliente", "Planta"});
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.HeaderText == "Producto")
            {
                e.Column = new GridComboBoxColumn() { MappingName = "Producto", HeaderText = "Producto" };
            }
            if (e.Column.HeaderText == "CantidadOrden")
            {
                e.Column.HeaderText = "Cantidad";
            }

            if (e.Column.HeaderText == "PrecioUnitario")
            {
                e.Column = new GridNumericColumn()
                    { MappingName = "PrecioUnitario", HeaderText = "Precio Unitario", FormatMode = FormatMode.Currency };
            }

            if (e.Column.HeaderText == "Iva")
            {
                e.Column.HeaderText = "IVA 16%";
            }
        }

        void ClienteCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedClient = (ClienteModel)ClienteCombo.SelectedItem;
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

        void PdfGridGeneral_BeginCellLayout(object sender, PdfGridBeginCellLayoutEventArgs args)
        {
            _count++;
            if (sender is PdfGrid pdfGridGeneral && _count <= pdfGridGeneral.Headers.Count * pdfGridGeneral.Columns.Count)
            {
                args.Skip = true;
            }
        }

        #endregion

        #region Methods

        void GetClientes()
        {
            ClienteCombo.Items.Clear();
            var clientes = GlobalConfig.Connection.Cliente_GetAll();

            foreach (var cliente in clientes)
            {
                ClienteCombo.Items.Add(cliente);
            }

            ClienteCombo.DisplayMember = "Nombre";
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

        void GetProducts()
        {
            if (ClienteCombo.SelectedItem == null || AreaCombo.SelectedItem == null) return;
            var clienteModel = (ClienteModel)ClienteCombo.SelectedItem;
            ((GridComboBoxColumn)DataGrid.Columns["Producto"]).DataSource =
                GlobalConfig.Connection.ClienteProducto_GetByClienteArea(clienteModel.IdClient, AreaCombo.Text);
            ((GridComboBoxColumn)DataGrid.Columns["Producto"]).DisplayMember = "ProductoInterno";
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
        //    generalInfoTable.Columns.Add("4");

        //    generalInfoTable.Rows.Add("No. orden: " + NumOrdenText.Text.Trim(), "Atención: " + _selectedClient.Atención, "Cliente:" + ClienteCombo.Text.Trim(), "Ciudad: " + _selectedClient.Ciudad);
        //    generalInfoTable.Rows.Add("Fecha de creación: " + FechaOrdenPicker.Value.ToString().Substring(0, 10), "Presentación: " + PresentaciónCombo.Text.Trim(), "Teléfono: " + _selectedClient.Teléfono, "Dirección: " + _selectedClient.Dirección);
        //    generalInfoTable.Rows.Add("Fecha de entrega: " + FechaEntregaPicker.Value.ToString().Substring(0, 10), "Puesto en: " + PuestoCombo.Text.Trim(), "Transporte: " + TransporteCombo.Text.Trim());
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
        //    const string fileName = "/Venta/output.pdf";
        //    purchaseOrder.Save(path + fileName);
        //    purchaseOrder.Close(true);
        //    return path + fileName;
        //}

        #endregion
    }
}
