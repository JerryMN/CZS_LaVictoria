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

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class OrdenCompraVerForm : Form
    {
        PurchaseOrderModel _orden;

        public OrdenCompraVerForm()
        {
            InitializeComponent();
            DataGrid.CurrentCellValidating += DataGridOnCurrentCellValidating;
            DataGrid.CurrentCellValidated += DataGridOnCurrentCellValidated;
        }

        #region Events

        /// <summary>
        /// Busca las líneas de una orden de compra.
        /// </summary>
        void BuscarButton_Click(object sender, EventArgs e)
        {
            // Si no hay alguna orden seleccionada, muestra todas las líneas de todas las órdenes.
            // No se pueden editar las cantidades en esta modalidad.
            if (NumOrdenText.Text == "")
            {
                DataGrid.DataSource = GlobalConfig.Connection.PurchaseOrderLine_GetAll();
                DataGrid.Columns["CantidadEntregada"].AllowEditing = false;
                ProveedorText.Text = "";
                FechaEntregaPicker.Value = new DateTime(1900, 1, 1);
                AreaText.Text = "";
                CondicionesText.Text = "";
            }
            // Al seleccionar una orden, muestra todas las líneas de esa orden.
            // Sí se pueden editar las cantidades en esta modalidad.
            else
            {
                DataGrid.DataSource = GlobalConfig.Connection.PurchaseOrderLine_GetByNumOrden(NumOrdenText.Text);
                DataGrid.Columns["CantidadEntregada"].AllowEditing = true;
                _orden = GlobalConfig.Connection.PurchaseOrder_GetByNumOrden(NumOrdenText.Text);
                if (_orden == null) return;
                ProveedorText.Text = _orden.Proveedor;
                FechaEntregaPicker.Value = _orden.FechaEntrega;
                AreaText.Text = _orden.Area;
                CondicionesText.Text = _orden.Condiciones;
            }

            // Ordenar tabla por Número de Orden.
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

        /// <summary>
        /// Una vez que la línea es válida, actualiza las tablas de SQL con las cantidades apropiadas.
        /// </summary>
        void DataGridOnCurrentCellValidated(object sender, CurrentCellValidatedEventArgs e)
        {
            var data = e.RowData as PurchaseOrderLineModel;
            UpdatePurchaseOrderLine(data);
            UpdateStock(data, double.Parse(e.OldValue.ToString()), double.Parse(e.NewValue.ToString()));

        }

        #endregion

        #region Methods

        /// <summary>
        /// Actualiza la cantidad entregada y pendiente en la tabla PurchaseOrderDetails en SQL.
        /// </summary>
        /// <param name="model">La línea a actualizar.</param>
        void UpdatePurchaseOrderLine(PurchaseOrderLineModel model)
        {
            GlobalConfig.Connection.PurchaseOrderLine_Update(_orden.UniqueIdOrder, model);
        }

        /// <summary>
        /// Crea o actualiza el material en la tabla Stock en SQL.
        /// </summary>
        /// <param name="model">La línea donde se encuentra el material.</param>
        /// <param name="oldQty">La cantidad entregada anterior.</param>
        /// <param name="newQty">La cantidad entregada actualizada.</param>
        void UpdateStock(PurchaseOrderLineModel model, double oldQty, double newQty)
        {
            // Obtener el modelo ProveedorProducto para obtener el nombre interno (que es el usado en Stock).
            var producto = GlobalConfig.Connection.ProveedorProducto_Find(model?.Producto, AreaText.Text, ProveedorText.Text);

            // Averiguar si el material ya existe en la tabla Stock.
            var material = GlobalConfig.Connection.Material_GetByNombreArea(producto.MaterialInterno, AreaText.Text);
            if (material  == null)
            {
                // Si no existe se crea.
                var newMaterial = new MaterialModel(producto.MaterialInterno, AreaText.Text, producto.Categoría, 
                    model?.CantidadEntregada.ToString(CultureInfo.InvariantCulture), null);
                GlobalConfig.Connection.Material_Create(newMaterial);
            }
            else
            {
                // Si existe, se actualiza la cantidad disponible.
                material.CantidadDisponible += (newQty - oldQty);
                GlobalConfig.Connection.Material_Update(material);
            }
        }

        #endregion
    }
}
