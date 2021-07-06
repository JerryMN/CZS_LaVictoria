using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Globalization;
using CZS_LaVictoria_Library.Models;
using Syncfusion.Data;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class OrdenCompraVerForm : Form
    {
        PurchaseOrderModel _orden;

        public OrdenCompraVerForm()
        {
            InitializeComponent();
            DataGrid.CurrentCellValidating += DataGridOnCurrentCellValidating;
        }

        #region Events

        /// <summary>
        /// Busca las líneas de una orden de compra.
        /// Si no hay alguna orden seleccionada, muestra todas las líneas de todas las órdenes.
        /// </summary>
        void BuscarButton_Click(object sender, EventArgs e)
        {
            if (NumOrdenText.Text == "")
            {
                DataGrid.DataSource = GlobalConfig.Connection.PurchaseOrderLine_GetAll();
                ProveedorText.Text = "";
                FechaEntregaPicker.Value = new DateTime(1900, 1, 1);
                AreaText.Text = "";
                CondicionesText.Text = "";
                GuardarButton.Enabled = false;
            }
            else
            {
                DataGrid.DataSource = GlobalConfig.Connection.PurchaseOrderLine_GetByNumOrden(NumOrdenText.Text);
                _orden = GlobalConfig.Connection.PurchaseOrder_GetByNumOrden(NumOrdenText.Text);
                if (_orden == null) return;
                ProveedorText.Text = _orden.Proveedor;
                FechaEntregaPicker.Value = _orden.FechaEntrega;
                AreaText.Text = _orden.Area;
                CondicionesText.Text = _orden.Condiciones;
                GuardarButton.Enabled = true;
            }

            if (DataGrid.SortColumnDescriptions.Count != 0)
            {
                DataGrid.SortColumnDescriptions.RemoveAt(0);
            }

            DataGrid.SortColumnDescriptions.Add(new SortColumnDescription { ColumnName = "NumOrden", SortDirection = ListSortDirection.Ascending });
        }

        /// <summary>
        /// Genera las columnas de la tabla.
        /// </summary>
        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "NumOrden")
            {
                var nfi = new NumberFormatInfo { NumberDecimalDigits = 0, NumberGroupSizes = new int[] { } };
                e.Column = new GridNumericColumn
                { MappingName = "NumOrden", HeaderText = "Orden", NumberFormatInfo = nfi };
            }

            if (e.Column.MappingName == "NumLinea")
            {
                e.Column.HeaderText = "Línea";
            }

            if (e.Column.MappingName == "Producto")
            {
                e.Column.HeaderText = "Producto";
                e.Column.AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
            }

            if (e.Column.MappingName == "CantidadOrden")
            {
                e.Column.HeaderText = "Cantidad Orden";
            }

            if (e.Column.MappingName == "CantidadEntregada")
            {
                e.Column.HeaderText = "Cantidad Entregada";
                e.Column.AllowEditing = true;
            }

            if (e.Column.MappingName == "CantidadPendiente")
            {
                e.Column.HeaderText = "Cantidad Pendiente";
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
        /// Valida la cantidad entregada de la línea.
        /// </summary>
        void DataGridOnCurrentCellValidating(object sender, CurrentCellValidatingEventArgs e)
        {
            var data = e.RowData as PurchaseOrderLineModel;
            Debug.Assert(data != null, nameof(data) + " != null");
            var cantidadOrden = data.CantidadOrden;
            var cantidadEntregada = (double)e.NewValue;
            var cantidadPendiente = cantidadOrden - cantidadEntregada;
            if (cantidadPendiente < 0)
            {
                e.IsValid = false;
                e.ErrorMessage = "La cantidad entregada no puede ser mayor a la cantidad ordenada.";
            }
            else
            {
                data.CantidadPendiente = cantidadPendiente;
            }
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (_orden == null) return;
            foreach (var record in DataGrid.View.Records)
            {
                UpdatePurchaseOrderLine(record);
                UpdateStock(record);
            }

            MessageBox.Show($"Orden de compra {_orden.NumOrden} actualizada con éxito.");
        }

        #endregion

        #region Methods

        void UpdatePurchaseOrderLine(RecordEntry record)
        {
            var model = record.Data as PurchaseOrderLineModel;
            GlobalConfig.Connection.PurchaseOrderLine_Update(_orden.UniqueIdOrder, model);
        }

        void UpdateStock(RecordEntry record)
        {
            var model = record.Data as PurchaseOrderLineModel;

            // Obtener el modelo ProveedorProducto para obtener el nombre interno (que es el usado en inventarios).
            var producto = GlobalConfig.Connection.ProveedorProducto_Find(model?.Producto, AreaText.Text, ProveedorText.Text);

            // Averiguar si el material ya existe en el inventario.
            var material = GlobalConfig.Connection.Material_GetByNombreArea(producto.MaterialInterno, AreaText.Text);
            if (material  == null)
            {
                // Si no existe lo creamos.
                var newMaterial = new MaterialModel(producto.MaterialInterno, AreaText.Text, null, 
                    model?.CantidadEntregada.ToString(CultureInfo.InvariantCulture), null);
                GlobalConfig.Connection.Material_Create(newMaterial);
            }
            else
            {
                // Si existe, actualizamos la cantidad disponible.
                // TODO - Fix this next line
                Debug.Assert(model != null, nameof(model) + " != null");
                material.CantidadDisponible += (model.CantidadEntregada);
                GlobalConfig.Connection.Material_Update(material);
            }
        }

        #endregion
    }
}
