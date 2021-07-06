using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Syncfusion.WinForms.ListView.Enums;
using System.Collections;
using System.Diagnostics;
using Syncfusion.WinForms.DataGrid.Interactivity;

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
            FechaOrdenPicker.Value = DateTime.Today;
            FechaEntregaPicker.Value = DateTime.Today;
            NumOrdenText.Text = GetNumOrden();
            GetProveedores();
            GetAreas();
            DataGrid.DataSource = _orderLines;
            DataGrid.Columns["NumLinea"].AllowEditing = false;
            DataGrid.LiveDataUpdateMode = LiveDataUpdateMode.AllowDataShaping;
            DataGrid.CellComboBoxSelectionChanged += DataGridOnCellComboBoxSelectionChanged;

            var tableSummary = new GridTableSummaryRow
            {
                Name = "TableSummary", ShowSummaryInRow = false, Position = VerticalPosition.Bottom
            };

            var productSummary = new GridSummaryColumn
            {
                Name = "NumLinea",
                SummaryType = SummaryType.CountAggregate,
                Format = "Productos: {Count:D}",
                MappingName = "NumLinea"
            };

            var subtotalSummary = new GridSummaryColumn
            {
                Name = "UnitPrice",
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
            if (_selectedProveedor == null) return;
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
            if (e.Column.MappingName == "NumOrden")
            {
                e.Cancel = true;
            }

            if (e.Column.MappingName == "NumLinea")
            {
                e.Column.HeaderText = "Línea";
            }

            if (e.Column.MappingName == "Producto")
            {
                e.Column = new GridComboBoxColumn { MappingName = "Producto", HeaderText = "Producto", DropDownStyle = DropDownStyle.DropDownList };
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
                    row.Producto = producto.MaterialInterno;
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

            if (DataGrid.SortColumnDescriptions.Count != 0)
            {
                DataGrid.SortColumnDescriptions.RemoveAt(0);
            }

            DataGrid.SortColumnDescriptions.Add(new SortColumnDescription { ColumnName = "NumLinea", SortDirection = ListSortDirection.Ascending });
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

            if (DataGrid.SortColumnDescriptions.Count != 0)
            {
                DataGrid.SortColumnDescriptions.RemoveAt(0);
            }

            DataGrid.SortColumnDescriptions.Add(new SortColumnDescription { ColumnName = "NumLinea", SortDirection = ListSortDirection.Ascending });
        }

        /// <summary>
        /// Genera un PDF con el encabezado de la orden y la tabla.
        /// </summary>
        void PdfButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                MsgBoxTimer.Start();
                return;
            }

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
                    Process.Start(saveFileDialog.FileName);
                }

                MsgBox.Text = $"PDF guardado en {saveFileDialog.FileName}.";
                MsgBox.IconColor = Color.DarkGreen;
                MsgBox.Visible = true;
                MsgBoxTimer.Start();
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

        /// <summary>
        /// Envía el pdf generado por correo.
        /// </summary>
        void MailButton_Click(object sender, EventArgs e)
        {
            PdfButton_Click(sender, e);
            using (var mail = new MailMessage())
            {
                var addresses = "";
                using (var smtpServer = new SmtpClient("smtp.gmail.com"))
                {
                    // TODO - Obtener las direcciones adecuadas.
                    mail.From = new MailAddress("splend3ad@gmail.com");
                    mail.To.Add("gerardo.mondragonb@hotmail.com");
                    mail.Subject = "Test Mail 1";
                    mail.Body =
                        $"Estimado Proveedor {_selectedProveedor.Nombre}:" +
                        $"\nSe ha generado una nueva orden de compra #{NumOrdenText.Text} la cual encontrará anexa." +
                        "\nFavor de confirmar de recibido. Gracias, \n \n Escobas La Victoria";
                    mail.Attachments.Add(new Attachment(_pdfPath));
                    smtpServer.Port = 587;
                    smtpServer.Credentials = new NetworkCredential("splend3ad@gmail.com", "xggtroybzdniydta");
                    smtpServer.EnableSsl = true;
                    smtpServer.Send(mail);
                }

                foreach (var address in mail.To)
                {
                    if (mail.To.Count == 1)
                    {
                        addresses += address.Address;
                    }
                    else
                    {
                        addresses += address.Address + ", ";
                    }
                }

                MsgBox.Text = $"Mensaje enviado a {addresses}";
                MsgBox.IconColor = Color.DarkGreen;
                MsgBox.Visible = true;
                MsgBoxTimer.Start();
            }
        }

        /// <summary>
        /// Guarda la orden de compra en SQL.
        /// </summary>
        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            Debug.Assert(FechaOrdenPicker.Value != null, "FechaOrdenPicker.Value != null");
            Debug.Assert(FechaEntregaPicker.Value != null, "FechaEntregaPicker.Value != null");
            var order = new PurchaseOrderModel
            {
                NumOrden = long.Parse(NumOrdenText.Text),
                TipoOrden = "C",
                Area = AreaCombo.Text,
                Proveedor = _selectedProveedor.Nombre,
                Condiciones = CondicionesCombo.Text,
                FechaOrden = (DateTime) FechaOrdenPicker.Value,
                FechaEntrega = (DateTime) FechaEntregaPicker.Value
            };

            foreach (var record in DataGrid.View.Records)
            {
                var data = record.Data as PurchaseOrderLineModel;
                Debug.Assert(data != null, nameof(data) + " != null");
                data.CantidadPendiente = data.CantidadOrden;
                order.Líneas.Add(data);
            }

            var saveSuccess = GlobalConfig.Connection.PurchaseOrder_Insert(order);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Orden de compra registrada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar orden de compra.";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void MsgBoxTimer_Tick(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBoxTimer.Stop();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Obtiene el número de la última orden, y le suma 1.
        /// </summary>
        /// <returns>El número consecutivo para la orden nueva.</returns>
        string GetNumOrden()
        {
            var order = GlobalConfig.Connection.PurchaseOrder_GetLastNumber();
            order += 1;
            return order.ToString();
        }

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
            ((GridComboBoxColumn) DataGrid.Columns["Producto"]).ValueMember = "MaterialExterno";
        }

        /// <summary>
        /// Valida que la orden se pueda crear.
        /// </summary>
        /// <returns>True, si la orden se puede crear, False de lo contrario.</returns>
        bool ValidateForm()
        {
            var output = true;
            MsgBox.Text = "";

            if (NumOrdenText.Text == "")
            {
                MsgBox.Text += "Ocurrió un error al obtener el número de orden.\n";
                return false;
            }
            if (ProveedorCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un proveedor.\n";
            }

            if (AreaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una área.\n";
            }

            if (DataGrid.View.Records.Count == 0)
            {
                output = false;
                MsgBox.Text += "Agrega líneas a la orden.\n";
            }

            return output;
        }

        /// <summary>
        /// Reestablece el formulario a su aspecto original.
        /// </summary>
        void ClearForm()
        {
            NumOrdenText.Text = GetNumOrden();
            CorreoText.Text = "Selecciona un proveedor...";
            AtencionText.Text = "Selecciona un proveedor...";
            FechaOrdenPicker.Value = DateTime.Today;
            FechaEntregaPicker.Value = DateTime.Today;
            DataGrid.AllowDeleting = true;
            for (var i = DataGrid.RowCount - 1 ; i > 0; i--)
            {
                var record = DataGrid.GetRecordAtRowIndex(i);
                DataGrid.SelectedItem = record;
                DataGrid.DeleteSelectedRecords();
            }

            _numLinea = 1;
            DataGrid.AllowDeleting = false;
            ProveedorCombo.Focus();

            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox box)
                    {
                        if (box.Name == "NumOrdenText") continue;
                        box.Clear();
                    }
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.Text = "";
                        comboBox.SelectedItem = null;
                    }
                    else
                        Func(control.Controls);
            }

            Func(Controls);
        }

        #endregion
    }
}