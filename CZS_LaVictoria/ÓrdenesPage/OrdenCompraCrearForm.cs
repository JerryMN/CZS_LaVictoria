using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.WinForms.DataGridConverter.Events;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class OrdenCompraCrearForm : Form
    {
        ProveedorModel _selectedProveedor;
        List<ProveedorProductoModel> _productos;
        readonly List<PurchaseOrderLineModel> _orderLines = new List<PurchaseOrderLineModel>();
        int _numLinea = 1;
        string _pdfPath;

        public OrdenCompraCrearForm()
        {
            InitializeComponent();
            FechaOrdenPicker.Culture = new CultureInfo("es-MX");
            FechaEntregaPicker.Culture = new CultureInfo("es-MX");
            GetProveedores();
            GetAreas();
            DataGrid.DataSource = _orderLines;
            DataGrid.CellComboBoxSelectionChanged += DataGridOnCellComboBoxSelectionChanged;

            var tableSummary = new GridTableSummaryRow
            {
                Name = "TableSummary", ShowSummaryInRow = false, Position = VerticalPosition.Bottom
            };

            var productSummary = new GridSummaryColumn
            {
                Name = "NumLinea",
                SummaryType = SummaryType.Int32Aggregate,
                Format = "Productos: {Count:D}",
                MappingName = "NumLinea"
            };

            var subtotalSummary = new GridSummaryColumn
            {
                Name = "Subtotal",
                SummaryType = SummaryType.DoubleAggregate,
                Format = "Total: {Sum:c}",
                MappingName = "Subtotal"
            };

            tableSummary.SummaryColumns.Add(productSummary);
            tableSummary.SummaryColumns.Add(subtotalSummary);

            DataGrid.TableSummaryRows.Add(tableSummary);
        }

        #region Events

        /// <summary>
        /// Llena el formulario con los datos del proveedor seleccionado.
        /// </summary>
        void ProveedorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProveedor = (ProveedorModel)ProveedorCombo.SelectedItem;
            GetCondiciones();
            TeléfonoText.Text = _selectedProveedor.Teléfono;
            CorreoText.Text = _selectedProveedor.Correo;
            AtencionText.Text = _selectedProveedor.Responsable;
            CondicionesCombo.Text = _selectedProveedor.Condiciones;
            if (AreaCombo.Text == "") return;
            GetProducts();
        }

        /// <summary>
        /// Obtiene los productos para el proveedor y área seleccionadas.
        /// </summary>
        void AreaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProveedorCombo.Text == "") return;
            GetProducts();
        }

        /// <summary>
        /// Genera las columnas de la tabla.
        /// </summary>
        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "NumLinea")
            {
                e.Column.HeaderText = "Línea";
            }

            if (e.Column.MappingName == "Producto")
            {
                e.Column = new GridComboBoxColumn { MappingName = "Producto", HeaderText = "Producto" };
            }

            if (e.Column.MappingName == "CantidadOrden")
            {
                e.Column.HeaderText = "Cantidad";
            }

            if (e.Column.MappingName == "CantidadEntregada")
            {
                e.Cancel = true;
            }

            if (e.Column.MappingName == "CantidadPendiente")
            {
                e.Cancel = true;
            }

            if (e.Column.MappingName == "PrecioUnitario")
            {
                e.Column = new GridNumericColumn
                    { MappingName = "PrecioUnitario", HeaderText = "Precio Unitario", FormatMode = FormatMode.Currency };
            }

            if (e.Column.MappingName == "Iva")
            {
                e.Column = new GridCheckBoxColumn { MappingName = "Iva", HeaderText = "IVA" };
            }

            if (e.Column.MappingName == "Subtotal")
            {
                e.Column = new GridNumericColumn
                    { MappingName = "Subtotal", HeaderText = "Subtotal", FormatMode = FormatMode.Currency };
            }
        }

        /// <summary>
        /// Da el número de línea adecuado a cada fila de la tabla.
        /// </summary>
        void DataGrid_AddNewRowInitiating(object sender, AddNewRowInitiatingEventArgs e)
        {
            if (e.NewObject is PurchaseOrderLineModel data) data.NumLinea = _numLinea;
            _numLinea += 1;
        }

        /// <summary>
        /// Cambia el precio unitario al del producto seleccionado.
        /// </summary>
        void DataGridOnCellComboBoxSelectionChanged(object sender, CellComboBoxSelectionChangedEventArgs e)
        {
            if (e.GridColumn.MappingName != "Producto") return;
            if (e.Record is PurchaseOrderLineModel row)
            {
                if (e.SelectedItem is ProveedorProductoModel producto)
                {
                    row.PrecioUnitario = producto.PrecioUnitario;
                }
            }
            if (e.RowIndex == DataGrid.GetAddNewRowIndex())
            {
                DataGrid.TableControl.Invalidate(DataGrid.TableControl.GetRowRectangle(DataGrid.GetAddNewRowIndex(), false));
            }
        }

        /// <summary>
        /// Calcula el subtotal al cambiar la cantidad o el precio unitario.
        /// </summary>
        void DataGrid_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs e)
        {
            var rowIndex = e.DataRow.RowIndex;
            var col = e.DataColumn.GridColumn;

            var recordIndex = DataGrid.TableControl.ResolveToRecordIndex(rowIndex);
            if (recordIndex < 0) return;
            object data;
            if (DataGrid.View.TopLevelGroup != null)
            {
                var record = DataGrid.View.TopLevelGroup.DisplayElements[recordIndex];
                if (!record.IsRecords)
                    return;
                data = ((RecordEntry)record).Data;
            }
            else
            {
                data = DataGrid.View.Records.GetItemAt(recordIndex);
            }

            var cantidad = decimal.Parse(DataGrid.View.GetPropertyAccessProvider().GetValue(data, "CantidadOrden").ToString());
            var precio = decimal.Parse(DataGrid.View.GetPropertyAccessProvider().GetValue(data, "PrecioUnitario").ToString());

            if (col.MappingName == "CantidadOrden" || col.MappingName == "PrecioUnitario")
            {
                DataGrid.View.GetPropertyAccessProvider().SetValue(data, "Subtotal", cantidad * precio);
            }
        }

        /// <summary>
        /// Calcula el subtotal al seleccionar o deseleccionar la casilla de IVA.
        /// </summary>
        void DataGrid_CellCheckBoxClick(object sender, CellCheckBoxClickEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var recordIndex = DataGrid.TableControl.ResolveToRecordIndex(rowIndex);
            if (recordIndex < 0) return;
            object data;
            if (DataGrid.View.TopLevelGroup != null)
            {
                var record = DataGrid.View.TopLevelGroup.DisplayElements[recordIndex];
                if (!record.IsRecords)
                    return;
                data = ((RecordEntry)record).Data;
            }
            else
            {
                data = DataGrid.View.Records.GetItemAt(recordIndex);
            }

            var cantidad = decimal.Parse(DataGrid.View.GetPropertyAccessProvider().GetValue(data, "CantidadOrden").ToString());
            var precio = decimal.Parse(DataGrid.View.GetPropertyAccessProvider().GetValue(data, "PrecioUnitario").ToString());

            if (e.NewValue == CheckState.Checked)
            {
                DataGrid.View.GetPropertyAccessProvider().SetValue(data, "Subtotal", cantidad * precio * 1.16m);
            }
            else
            {
                DataGrid.View.GetPropertyAccessProvider().SetValue(data, "Subtotal", cantidad * precio);
            }
        }

        /// <summary>
        /// Genera un PDF con el encabezado de la orden y la tabla.
        /// </summary>
        void PdfButton_Click(object sender, EventArgs e)
        {
            var options = new PdfExportingOptions { AutoColumnWidth = true };
            options.HeaderFooterExporting += OnHeaderFooterExporting;
            options.CellExporting += OnCellExporting;
            var document = DataGrid.ExportToPdf(options);
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files(*.pdf)|*.pdf",
                FileName = NumOrdenText.Text,
                RestoreDirectory = true
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _pdfPath = saveFileDialog.FileName;
                using (var stream = saveFileDialog.OpenFile()) document.Save(stream);
                if (MessageBox.Show("Quieres abrir el PDF?", "PDF guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }

        }

        /// <summary>
        /// Cambia el texto de la columna IVA del pdf.
        /// </summary>
        static void OnCellExporting(object sender, DataGridCellPdfExportingEventArgs e)
        {
            if (e.ColumnName == "Iva" && e.CellType == ExportCellType.RecordCell)
            {
                e.CellValue = e.CellValue.ToString() == "True" ? "Sí" : "No";
            }
        }

        /// <summary>
        /// Genera el encabezado del pdf.
        /// </summary>
        void OnHeaderFooterExporting(object sender, PdfHeaderFooterEventArgs e)
        {
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 16f, PdfFontStyle.Bold);
            PdfFont smallFont = new PdfStandardFont(PdfFontFamily.Helvetica, 12f, PdfFontStyle.Regular);
            var brush = new PdfSolidBrush(Color.Black);
            var width = e.PdfPage.GetClientSize().Width;
            var header = new PdfPageTemplateElement(width, 80);

            header.Graphics.DrawString($"Escobas La Victoria -- Orden de Compra {NumOrdenText.Text}", font, brush, 0, 10);
            header.Graphics.DrawString($"Fecha Orden: {FechaOrdenPicker.Value.ToString().Substring(0, 11)}  |   " +
                                       $"Fecha Entrega: {FechaEntregaPicker.Value.ToString().Substring(0, 11)}  |  " +
                                       $"Área: {AreaCombo.Text}", smallFont, brush, 0, 30);
            header.Graphics.DrawString($"Proveedor: {_selectedProveedor.Nombre}  |  Atención: {AtencionText.Text}", smallFont, brush, 0, 45);
            e.PdfDocumentTemplate.Top = header;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Obtiene todos los proveedores en SQL.
        /// </summary>
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

        /// <summary>
        /// Obtiene todas las áreas en SQL.
        /// </summary>
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

        /// <summary>
        /// Obtiene todas las diferentes condiciones en SQL.
        /// </summary>
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

        /// <summary>
        /// Obtiene los productos para el proveedor y área seleccionadas.
        /// </summary>
        void GetProducts()
        {
            if (_selectedProveedor == null || AreaCombo.Text == "") return;
            _productos = GlobalConfig.Connection.ProveedorProducto_GetByProveedorArea(_selectedProveedor.IdProvider, AreaCombo.Text);
            ((GridComboBoxColumn) DataGrid.Columns["Producto"]).DataSource = _productos;
            ((GridComboBoxColumn) DataGrid.Columns["Producto"]).DisplayMember = "MaterialExterno";
        }

        #endregion

        void MailButton_Click(object sender, EventArgs e)
        {
            using (var mail = new MailMessage())
            {
                using (var smtpServer = new SmtpClient("smtp.gmail.com"))
                {
                    mail.From = new MailAddress("splend3ad@gmail.com");
                    mail.To.Add("gerardo.mondragonb@hotmail.com");
                    mail.Subject = "Test Mail 1";
                    mail.Body =
                        $"Estimado Proveedor {_selectedProveedor.Nombre}:" +
                        $"\nSe ha generado una nueva orden de compra #{NumOrdenText.Text} la cual encontrará anexa." +
                        $"\nFavor de confirmar de recibido. Gracias, \n \n Escobas La Victoria";
                    mail.Attachments.Add(new Attachment(_pdfPath));
                    smtpServer.Port = 587;
                    smtpServer.Credentials = new NetworkCredential("splend3ad@gmail.com", "xggtroybzdniydta");
                    smtpServer.EnableSsl = true;
                    smtpServer.Send(mail);
                }
            }
        }
    }
}