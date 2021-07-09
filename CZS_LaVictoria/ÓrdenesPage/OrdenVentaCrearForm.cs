using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.Data;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGridConverter.Events;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.Input.Events;
using Syncfusion.WinForms.ListView.Enums;
using Syncfusion.WinForms.DataGrid.Interactivity;
using System.Collections;
using System.Net.Mail;
using System.Net;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class OrdenVentaCrearForm : Form
    {
        ClienteModel _selectedClient;
        List<ClienteProductoModel> _productos;
        readonly List<OrdenVentaLíneaModel> _orderLines = new List<OrdenVentaLíneaModel>();
        int _numLinea = 1;
        string _pdfPath;

        public OrdenVentaCrearForm()
        {
            InitializeComponent();
            FechaOrdenPicker.Culture = new CultureInfo("es-MX");
            FechaOrdenPicker.Value = DateTime.Today;
            NumOrdenText.Text = GetNumOrden();
            GetClientes();
            GetAreas();
            DataGrid.DataSource = _orderLines;
            DataGrid.Columns["NumLinea"].AllowEditing = false;
            DataGrid.LiveDataUpdateMode = LiveDataUpdateMode.AllowDataShaping;
            DataGrid.CellComboBoxSelectionChanged += DataGridOnCellComboBoxSelectionChanged;
            TransporteCombo.Items.AddRange(new object[]{"Cliente", "Propio"});
            PuestoCombo.Items.AddRange(new object[]{"Cliente", "Planta"});

            var tableSummary = new GridTableSummaryRow
            {
                Name = "TableSummary",
                ShowSummaryInRow = false,
                Position = VerticalPosition.Bottom
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
        /// Cambia la fecha mínima de entrega al cambiar la fecha de la orden.
        /// </summary>
        void FechaOrdenPicker_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            if (DataGrid.Columns.Count == 0) return;
            Debug.Assert(FechaOrdenPicker.Value != null, "FechaOrdenPicker.Value != null");
            ((GridDateTimeColumn)DataGrid.Columns["FechaEntrega"]).MinDateTime = (DateTime)FechaOrdenPicker.Value;
        }

        /// <summary>
        /// Llena el formulario con los datos del cliente seleccionado.
        /// </summary>
        void ClienteCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedClient = (ClienteModel)ClienteCombo.SelectedItem;
            GetProducts();
        }

        /// <summary>
        /// Obtiene los productos para el área seleccionada.
        /// </summary>
        void AreaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProducts();
        }

        /// <summary>
        /// Genera las columnas de la tabla.
        /// </summary>
        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Cliente")
            {
                e.Cancel = true;
            }

            if (e.Column.MappingName == "Area")
            {
                e.Cancel = true;
            }

            if (e.Column.MappingName == "NumOrden")
            {
                e.Cancel = true;
            }

            if (e.Column.MappingName == "NumLinea")
            {
                e.Column.HeaderText = "Línea";
                e.Column.Width = 100;
                e.Column.AllowFiltering = false;
            }

            if (e.Column.MappingName == "Producto")
            {
                e.Column = new GridComboBoxColumn
                {
                    MappingName = "Producto",
                    HeaderText = "Producto",
                    DropDownStyle = DropDownStyle.DropDownList,
                    AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill
                };
            }

            if (e.Column.MappingName == "CantidadOrden")
            {
                e.Column.HeaderText = "Cantidad";
                e.Column.AllowFiltering = false;
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
                { MappingName = "PrecioUnitario", HeaderText = "Precio Unitario", FormatMode = FormatMode.Currency, AllowFiltering = false };
            }

            if (e.Column.MappingName == "Iva")
            {
                e.Column = new GridCheckBoxColumn { MappingName = "Iva", HeaderText = "IVA" };
            }

            if (e.Column.MappingName == "Subtotal")
            {
                e.Column = new GridNumericColumn
                { MappingName = "Subtotal", HeaderText = "Subtotal", FormatMode = FormatMode.Currency, Width = 100, AllowFiltering = false };
            }

            if (e.Column.MappingName == "FechaEntrega")
            {
                Debug.Assert(FechaOrdenPicker.Value != null, "FechaOrdenPicker.Value != null");
                e.Column = new GridDateTimeColumn
                {
                    MappingName = "FechaEntrega",
                    HeaderText = "Fecha Entrega",
                    MinDateTime = (DateTime)FechaOrdenPicker.Value
                };
            }

            if (e.Column.MappingName == "FechaUltEntrega")
            {
                e.Cancel = true;
            }

            if (e.Column.MappingName == "FechaCancelación")
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Da el número de línea adecuado a cada fila de la tabla.
        /// </summary>
        void DataGrid_AddNewRowInitiating(object sender, AddNewRowInitiatingEventArgs e)
        {
            if (e.NewObject is OrdenVentaLíneaModel data)
            {
                data.NumLinea = _numLinea;
                data.FechaEntrega = DateTime.Today;
            }
            _numLinea += 1;
        }

        /// <summary>
        /// Cambia el precio unitario al del producto seleccionado.
        /// </summary>
        void DataGridOnCellComboBoxSelectionChanged(object sender, CellComboBoxSelectionChangedEventArgs e)
        {
            if (e.GridColumn.MappingName != "Producto") return;
            if (e.Record is OrdenVentaLíneaModel row)
            {
                if (e.SelectedItem is ClienteProductoModel producto)
                {
                    row.PrecioUnitario = producto.PrecioUnitario;
                    row.Producto = producto.ProductoInterno;
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

            header.Graphics.DrawString($"Escobas La Victoria — Orden de Venta {NumOrdenText.Text}", font, brush, 0, 10);
            header.Graphics.DrawString($"Fecha Orden: {FechaOrdenPicker.Value.ToString().Substring(0, 11)}  |   " +
                                       $"Área: {AreaCombo.Text}", smallFont, brush, 0, 30);
            header.Graphics.DrawString($"Cliente: {_selectedClient.Nombre}  |  Atención: {_selectedClient.Atención}", smallFont, brush, 0, 45);
            e.PdfDocumentTemplate.Top = header;
        }

        /// <summary>
        /// Guarda la orden de compra en SQL.
        /// </summary>
        void GuardarButton_Click(object sender, EventArgs e)
        {
            CreatePdf();
            SendMail();

            Debug.Assert(FechaOrdenPicker.Value != null, "FechaOrdenPicker.Value != null");
            var order = new OrdenVentaModel
            {
                NumOrden = long.Parse(NumOrdenText.Text),
                TipoOrden = "V",
                Area = AreaCombo.Text,
                Cliente = _selectedClient.Nombre,
                FechaOrden = (DateTime)FechaOrdenPicker.Value,
            };

            foreach (var record in DataGrid.View.Records)
            {
                var data = record.Data as OrdenVentaLíneaModel;
                Debug.Assert(data != null, nameof(data) + " != null");
                data.CantidadPendiente = data.CantidadOrden;
                order.Líneas.Add(data);
            }

            var saveSuccess = true; // TODO - Save order.

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Orden de venta registrada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar orden de venta.";
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
            var order = 2100000; // TODO - Get.
            order += 1;
            return order.ToString();
        }

        /// <summary>
        /// Obtiene todos los clientes en SQL.
        /// </summary>
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

        void GetProducts()
        {
            if (_selectedClient == null || AreaCombo.Text == "") return;
            // TODO - Get _productos.
            ((GridComboBoxColumn)DataGrid.Columns["Producto"]).DataSource = _productos;
            ((GridComboBoxColumn)DataGrid.Columns["Producto"]).DisplayMember = "ProductoInterno";
            ((GridComboBoxColumn)DataGrid.Columns["Producto"]).ValueMember = "ProductoInterno";
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
            if (ClienteCombo.Text == "")
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
        /// Genera un PDF con el encabezado de la orden y la tabla.
        /// </summary>
        void CreatePdf()
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                MsgBoxTimer.Start();
                return;
            }

            var options = new PdfExportingOptions { FitAllColumnsInOnePage = true, RepeatHeaders = true };
            options.HeaderFooterExporting += OnHeaderFooterExporting;
            options.CellExporting += OnCellExporting;
            try
            {
                var document = DataGrid.ExportToPdf(options);
                _pdfPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                           $"\\CZ Systems - La Victoria\\Ordenes de Venta\\{_selectedClient.Nombre}\\{DateTime.Today.Year}\\{NumOrdenText.Text}.pdf";
                document.Save(_pdfPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MsgBox.Text = "PDF guardado.";
            MsgBox.IconColor = Color.DarkGreen;
            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        /// <summary>
        /// Envía el último pdf generado por correo.
        /// </summary>
        void SendMail()
        {
            using (var mail = new MailMessage())
            {
                var addresses = "";
                using (var smtpServer = new SmtpClient("smtp.gmail.com"))
                {
                    // TODO - Obtener la dirección del responsable de area.
                    mail.From = new MailAddress("splend3ad@gmail.com");
                    mail.To.Add("gerardo.mondragonb@hotmail.com");
                    //mail.To.Add(CorreoText.Text);
                    mail.Subject = $"Orden de Venta #{NumOrdenText.Text} - Escobas La Victoria";
                    // TODO - Cambiar texto.
                    mail.Body =
                        $"Estimado Proveedor {_selectedClient.Nombre} y {_selectedClient.Atención}:" +
                        $"\nSe ha generado una nueva orden de venta #{NumOrdenText.Text} la cual encontrará anexa." +
                        "\nFavor de confirmar de recibido. Gracias, \n \nEscobas La Victoria";
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
        /// Reestablece el formulario a su aspecto original.
        /// </summary>
        void ClearForm()
        {
            NumOrdenText.Text = GetNumOrden();
            FechaOrdenPicker.Value = DateTime.Today;
            DataGrid.AllowDeleting = true;
            for (var i = DataGrid.RowCount - 1; i > 0; i--)
            {
                var record = DataGrid.GetRecordAtRowIndex(i);
                DataGrid.SelectedItem = record;
                DataGrid.DeleteSelectedRecords();
            }

            _numLinea = 1;
            DataGrid.AllowDeleting = false;
            ClienteCombo.Focus();

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
