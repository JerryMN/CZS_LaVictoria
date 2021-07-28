using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using CZS_LaVictoria.Properties;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.Data;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Interactivity;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.WinForms.DataGridConverter.Events;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.Input.Events;
using Syncfusion.WinForms.ListView.Enums;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class OrdenCompraCrearForm : Form
    {
        readonly List<OrdenCompraLíneaModel> _orderLines = new List<OrdenCompraLíneaModel>();
        int _numLinea = 1;
        string _notas = "";
        string _pdfPath;
        List<ProveedorProductoModel> _productos;
        List<AreaModel> _selectedArea;
        ProveedorModel _selectedProveedor;
        int _ticks;

        public OrdenCompraCrearForm()
        {
            InitializeComponent();
            FechaOrdenPicker.Culture = new CultureInfo("es-MX");
            FechaOrdenPicker.Value = DateTime.Today;
            NumOrdenText.Text = GetNumOrden();
            GetProveedores();
            GetAreas();
            DataGrid.DataSource = _orderLines;
            DataGrid.Columns["NumLinea"].AllowEditing = false;
            DataGrid.LiveDataUpdateMode = LiveDataUpdateMode.AllowDataShaping;
            DataGrid.CellComboBoxSelectionChanged += DataGridOnCellComboBoxSelectionChanged;
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.TableSummaryRowStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            
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

            if (GlobalConfig.Connection.CZS_GetLicencia()) return;
            MessageBox.Show(
                "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        #region Events

        /// <summary>
        ///     Cambia la fecha mínima de entrega al cambiar la fecha de la orden.
        /// </summary>
        void FechaOrdenPicker_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            if (DataGrid.Columns.Count == 0) return;
            Debug.Assert(FechaOrdenPicker.Value != null, "FechaOrdenPicker.Value != null");
            ((GridDateTimeColumn) DataGrid.Columns["FechaEntrega"]).MinDateTime = (DateTime) FechaOrdenPicker.Value;
        }

        /// <summary>
        ///     Llena el formulario con los datos del proveedor seleccionado.
        /// </summary>
        void ProveedorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProveedor = (ProveedorModel) ProveedorCombo.SelectedItem;
            if (_selectedProveedor == null || _selectedProveedor.Id == 0) return;
            GetCondiciones();
            CondicionesCombo.Text = _selectedProveedor.Condiciones;
            if (AreaCombo.Text == "") return;
            GetProducts();
        }

        /// <summary>
        ///     Obtiene los productos para el proveedor y área seleccionadas.
        /// </summary>
        void AreaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedArea = AreaCombo.Text;
            _selectedArea = GlobalConfig.Connection.Area_GetByArea(selectedArea);
            GetProducts();
        }

        /// <summary>
        ///     Genera las columnas de la tabla.
        /// </summary>
        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Proveedor":
                case "Área":
                case "NumOrden":
                case "CantidadRecibida":
                case "CantidadPendiente":
                case "FechaUltRecepción":
                case "FechaCancelación":
                case "Estatus":
                    e.Cancel = true;
                    break;
                case "NumLinea":
                    e.Column.HeaderText = "Línea";
                    e.Column.Width = 120;
                    e.Column.AllowFiltering = false;
                    break;
                case "Producto":
                    e.Column = new GridComboBoxColumn
                    {
                        MappingName = "Producto", HeaderText = "Producto", DropDownStyle = DropDownStyle.DropDownList,
                        AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill
                    };
                    break;
                case "CantidadOrden":
                    e.Column.HeaderText = "Cantidad";
                    e.Column.AllowFiltering = false;
                    break;
                case "PrecioUnitario":
                    e.Column = new GridNumericColumn
                    {
                        MappingName = "PrecioUnitario", HeaderText = "Precio Unitario",
                        FormatMode = FormatMode.Currency, AllowFiltering = false
                    };
                    break;
                case "Iva":
                    e.Column = new GridCheckBoxColumn {MappingName = "Iva", HeaderText = "IVA"};
                    break;
                case "Subtotal":
                    e.Column = new GridNumericColumn
                    {
                        MappingName = "Subtotal", HeaderText = "Subtotal", FormatMode = FormatMode.Currency,
                        Width = 175, AllowFiltering = false
                    };
                    break;
                case "FechaEntrega":
                    Debug.Assert(FechaOrdenPicker.Value != null, "FechaOrdenPicker.Value != null");
                    e.Column = new GridDateTimeColumn
                    {
                        MappingName = "FechaEntrega",
                        HeaderText = "Fecha Entrega",
                        MinDateTime = (DateTime) FechaOrdenPicker.Value
                    };
                    break;
            }
        }

        /// <summary>
        ///     Da el número de línea adecuado a cada fila de la tabla.
        /// </summary>
        void DataGrid_AddNewRowInitiating(object sender, AddNewRowInitiatingEventArgs e)
        {
            if (e.NewObject is OrdenCompraLíneaModel data)
            {
                data.NumLinea = _numLinea;
                data.FechaEntrega = DateTime.Today;
            }

            _numLinea += 1;
        }

        /// <summary>
        ///     Cambia el precio unitario al del producto seleccionado.
        /// </summary>
        void DataGridOnCellComboBoxSelectionChanged(object sender, CellComboBoxSelectionChangedEventArgs e)
        {
            if (e.GridColumn.MappingName != "Producto") return;
            if (e.Record is OrdenCompraLíneaModel row)
                if (e.SelectedItem is ProveedorProductoModel producto)
                {
                    row.PrecioUnitario = producto.PrecioUnitario;
                    row.Producto = producto.MaterialInterno;
                }

            if (e.RowIndex == DataGrid.GetAddNewRowIndex())
                DataGrid.TableControl.Invalidate(
                    DataGrid.TableControl.GetRowRectangle(DataGrid.GetAddNewRowIndex(), false));
        }

        /// <summary>
        ///     Calcula el subtotal al cambiar la cantidad o el precio unitario.
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
                data = ((RecordEntry) record).Data;
            }
            else
            {
                data = DataGrid.View.Records.GetItemAt(recordIndex);
            }

            var cantidad = decimal.Parse(DataGrid.View.GetPropertyAccessProvider().GetValue(data, "CantidadOrden")
                .ToString());
            var precio = decimal.Parse(DataGrid.View.GetPropertyAccessProvider().GetValue(data, "PrecioUnitario")
                .ToString());

            if (col.MappingName == "CantidadOrden" || col.MappingName == "PrecioUnitario")
                DataGrid.View.GetPropertyAccessProvider().SetValue(data, "Subtotal", cantidad * precio);
        }

        /// <summary>
        ///     Calcula el subtotal al seleccionar o deseleccionar la casilla de IVA.
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
                data = ((RecordEntry) record).Data;
            }
            else
            {
                data = DataGrid.View.Records.GetItemAt(recordIndex);
            }

            var cantidad = decimal.Parse(DataGrid.View.GetPropertyAccessProvider().GetValue(data, "CantidadOrden")
                .ToString());
            var precio = decimal.Parse(DataGrid.View.GetPropertyAccessProvider().GetValue(data, "PrecioUnitario")
                .ToString());

            if (e.NewValue == CheckState.Checked)
                DataGrid.View.GetPropertyAccessProvider().SetValue(data, "Subtotal", cantidad * precio * 1.16m);
            else
                DataGrid.View.GetPropertyAccessProvider().SetValue(data, "Subtotal", cantidad * precio);
        }

        /// <summary>
        ///     Cambia el texto de la columna IVA del pdf.
        /// </summary>
        static void OnCellExporting(object sender, DataGridCellPdfExportingEventArgs e)
        {
            if (e.ColumnName == "Iva" && e.CellType == ExportCellType.RecordCell)
                e.CellValue = e.CellValue.ToString() == "True" ? "Sí" : "No";
        }

        /// <summary>
        ///     Genera el encabezado del pdf.
        /// </summary>
        void OnHeaderFooterExporting(object sender, PdfHeaderFooterEventArgs e)
        {
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 16f, PdfFontStyle.Bold);
            PdfFont smallFont = new PdfStandardFont(PdfFontFamily.Helvetica, 12f, PdfFontStyle.Regular);
            var brush = new PdfSolidBrush(Color.Black);
            var width = e.PdfPage.GetClientSize().Width;
            var header = new PdfPageTemplateElement(width, 80);
            var footer = new PdfPageTemplateElement(width, 80);

            header.Graphics.DrawImage(PdfImage.FromFile(@"..\..\Resources\Logo.png"), width - 70, 0, 70, 70);
            header.Graphics.DrawString($"Escobas La Victoria — Orden de Compra {NumOrdenText.Text}", font, brush, 0, 0);
            header.Graphics.DrawString($"Fecha Orden: {FechaOrdenPicker.Value.ToString().Substring(0, 11)}  |   " +
                                       $"Área: {AreaCombo.Text}", smallFont, brush, 0, 30);
            header.Graphics.DrawString(
                $"Proveedor: {_selectedProveedor.Nombre}  |  Atención: {_selectedProveedor.Responsable}", smallFont,
                brush, 0, 45);

            footer.Graphics.DrawString("Notas: " + _notas, smallFont, brush, 0, 0);

            e.PdfDocumentTemplate.Top = header;
            e.PdfDocumentTemplate.Bottom = footer;
        }

        /// <summary>
        ///     Guarda la orden de compra en SQL.
        /// </summary>
        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBox.Text = "";
            MsgBox.IconColor = Color.DarkGreen;

            if (!ValidateForm())
            {
                MsgBox.IconColor = Color.DarkRed;
                MsgBox.Visible = true;
                return;
            }

            CreatePdf();
            if (MsgBox.IconColor == Color.DarkRed)
            {
                MsgBox.Text = "Error al guardar PDF. Abortando.\n";
                return;
            }

            Debug.Assert(FechaOrdenPicker.Value != null, "FechaOrdenPicker.Value != null");
            var order = new OrdenCompraModel
            {
                NumOrden = long.Parse(NumOrdenText.Text),
                TipoOrden = "C",
                Área = AreaCombo.Text,
                Proveedor = _selectedProveedor.Nombre,
                Condiciones = CondicionesCombo.Text,
                FechaOrden = (DateTime) FechaOrdenPicker.Value
            };

            foreach (var record in DataGrid.View.Records)
            {
                var data = record.Data as OrdenCompraLíneaModel;
                Debug.Assert(data != null, nameof(data) + " != null");
                data.CantidadPendiente = data.CantidadOrden;
                order.Líneas.Add(data);
            }

            order.Notas = _notas;

            var saveSuccess = GlobalConfig.Connection.OrdenCompra_Create(order);

            if (saveSuccess)
            {
                MsgBox.Text += "Orden de compra registrada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar orden de compra.";
                File.Delete(_pdfPath);
                MsgBox.IconColor = Color.DarkRed;
                return;
            }

            SendMail();
            if (MsgBox.IconColor == Color.DarkRed)
            {
                MsgBox.Text = "Error al enviar correo. Abortando. " +
                              "Puedes enviar el correo manualmente.\n";
                return;
            }

            ClearForm();
            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void NotasButton_Click(object sender, EventArgs e)
        {
            using (var form = new AgregarNotasForm())
            {
                var result = form.ShowDialog();
                _notas = result == DialogResult.OK ? form.Notas : "";
            }
        }

        void MsgBoxTimer_Tick(object sender, EventArgs e)
        {
            if (_ticks == 1)
            {
                MsgBoxTimer.Stop();
                MsgBox.Visible = false;
            }

            _ticks += 1;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Obtiene el número de la última orden, y le suma 1. Si el año cambia, resetea el contador.
        /// </summary>
        /// <returns>El número consecutivo para la orden nueva.</returns>
        static string GetNumOrden()
        {
            var order = GlobalConfig.Connection.OrdenCompra_GetLastNumOrden();
            var lastOrderYear = order.ToString().Substring(0, 2);
            var thisYear = DateTime.Today.Year.ToString().Substring(2, 2);
            if (lastOrderYear != thisYear) order = long.Parse(thisYear + "00000");

            order += 1;
            return order.ToString();
        }

        /// <summary>
        ///     Obtiene todos los proveedores en SQL.
        /// </summary>
        void GetProveedores()
        {
            ProveedorCombo.Items.Clear();
            var proveedores = GlobalConfig.Connection.Proveedor_GetAll();

            foreach (var proveedor in proveedores) ProveedorCombo.Items.Add(proveedor);

            ProveedorCombo.DisplayMember = "Nombre";
            ProveedorCombo.Sorted = true;
        }

        /// <summary>
        ///     Obtiene todas las áreas en SQL.
        /// </summary>
        void GetAreas()
        {
            AreaCombo.Items.Clear();
            var areas = GlobalConfig.Connection.Area_GetDistinct();

            foreach (var area in areas) AreaCombo.Items.Add(area);
        }

        /// <summary>
        ///     Obtiene todas las diferentes condiciones en SQL.
        /// </summary>
        void GetCondiciones()
        {
            CondicionesCombo.Items.Clear();
            var condiciones = GlobalConfig.Connection.Proveedor_GetDistinctCondiciones();

            foreach (var condición in condiciones) CondicionesCombo.Items.Add(condición);
        }

        /// <summary>
        ///     Obtiene los productos para el proveedor y área seleccionadas.
        /// </summary>
        void GetProducts()
        {
            if (_selectedProveedor == null || AreaCombo.Text == "") return;
            _productos =
                GlobalConfig.Connection.ProveedorProducto_GetByProveedorArea(_selectedProveedor.Id, AreaCombo.Text);
            ((GridComboBoxColumn) DataGrid.Columns["Producto"]).DataSource = _productos;
            ((GridComboBoxColumn) DataGrid.Columns["Producto"]).DisplayMember = "MaterialExterno";
            ((GridComboBoxColumn) DataGrid.Columns["Producto"]).ValueMember = "MaterialExterno";
            ((GridComboBoxColumn) DataGrid.Columns["Producto"]).SortMode = DataReflectionMode.Display;
        }

        /// <summary>
        ///     Valida que la orden se pueda crear.
        /// </summary>
        /// <returns>True, si la orden se puede crear, False de lo contrario.</returns>
        bool ValidateForm()
        {
            var output = true;

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
                MsgBox.Text += "Agrega al menos una línea a la orden.\n";
            }

            return output;
        }

        /// <summary>
        ///     Genera un PDF con el encabezado de la orden y la tabla.
        /// </summary>
        void CreatePdf()
        {
            var options = new PdfExportingOptions {FitAllColumnsInOnePage = true, RepeatHeaders = true};
            options.HeaderFooterExporting += OnHeaderFooterExporting;
            options.CellExporting += OnCellExporting;
            try
            {
                var document = DataGrid.ExportToPdf(options);
                _pdfPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                           $"\\CZ Systems - La Victoria\\Órdenes de Compra\\{_selectedProveedor.Nombre}\\{DateTime.Today.Year}\\{NumOrdenText.Text}.pdf";
                document.Save(_pdfPath);
                MsgBox.Text += "PDF guardado.\n";
                MsgBox.IconColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MsgBox.IconColor = Color.DarkRed;
            }
        }

        /// <summary>
        ///     Envía el último pdf generado por correo.
        /// </summary>
        void SendMail()
        {
            using (var mail = new MailMessage())
            using (var smtpServer = new SmtpClient(Settings.Default.smtpServer))
            {
                try
                {
                    mail.From = new MailAddress(Settings.Default.emailAddress);
                    mail.To.Add(_selectedProveedor.Correo);
                    foreach (var area in _selectedArea) mail.To.Add(area.Correo);

                    mail.Subject = $"Orden de Compra #{NumOrdenText.Text} - Escobas La Victoria";
                    mail.Body =
                        $"Estimado Proveedor {_selectedProveedor.Nombre} y {_selectedProveedor.Responsable}:" +
                        $"\nSe ha generado una nueva orden de compra #{NumOrdenText.Text} la cual encontrará anexa." +
                        "\nFavor de confirmar de recibido. \nGracias, \n \nEscobas La Victoria";
                    mail.Attachments.Add(new Attachment(_pdfPath));
                    smtpServer.Port = int.Parse(Settings.Default.smtpPort);
                    smtpServer.Credentials = new NetworkCredential(Settings.Default.emailAddress,
                        Settings.Default.emailPassword);
                    smtpServer.EnableSsl = true;
                    smtpServer.Send(mail);

                    var addresses = string.Join(", ", mail.To);
                    MsgBox.Text += $"Mensaje enviado a {addresses}.\n";
                    MsgBox.IconColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MsgBox.IconColor = Color.DarkRed;
                }
            }
        }

        /// <summary>
        ///     Reestablece el formulario a su aspecto original.
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
            _notas = "";
            _ticks = 1;
            DataGrid.AllowDeleting = false;
            ProveedorCombo.Focus();

            Tools.ClearForm(this);
        }

        #endregion
    }
}