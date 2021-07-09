using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.Input.Enums;
using System.Diagnostics;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class OrdenVentaVerForm : Form
    {
        OrdenVentaModel _orden;
        double _oldQty;
        double _newQty;
        string _newQtyString;

        public OrdenVentaVerForm()
        {
            InitializeComponent();
        }

        #region Events

        /// <summary>
        /// Busca las líneas de una orden de venta.
        /// </summary>
        void BuscarButton_Click(object sender, EventArgs e)
        {
            // Si no hay alguna orden seleccionada, muestra todas las líneas de todas las órdenes.
            if (NumOrdenText.Text == "" && PendientesCheck.CheckState == CheckState.Unchecked)
            {
                DataGrid.DataSource = new List<OrdenVentaLíneaModel>();  // TODO GetAll();
            }
            else if (NumOrdenText.Text == "" && PendientesCheck.CheckState == CheckState.Checked)
            {
                DataGrid.DataSource = new List<OrdenVentaLíneaModel>(); // TODO GetPending();
            }
            // Al seleccionar una orden, muestra todas las líneas de esa orden.
            else
            {
                DataGrid.DataSource = GlobalConfig.Connection.PurchaseOrderLine_GetByNumOrden(NumOrdenText.Text);
                _orden = new OrdenVentaModel(); // TODO - _GetByNumOrden(NumOrdenText.Text);
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
            if (e.Column.MappingName == "Area")
            {
                e.Column.HeaderText = "Área";
            }

            if (e.Column.MappingName == "NumOrden")
            {
                var nfi = new NumberFormatInfo { NumberDecimalDigits = 0, NumberGroupSizes = new int[] { } };
                e.Column = new GridNumericColumn
                { MappingName = "NumOrden", HeaderText = "Orden", NumberFormatInfo = nfi };
            }

            if (e.Column.MappingName == "NumLinea")
            {
                e.Column.HeaderText = "Línea";
                e.Column.AllowFiltering = false;
            }

            if (e.Column.MappingName == "Producto")
            {
                e.Column.HeaderText = "Producto";
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

            if (e.Column.MappingName == "FechaEntrega")
            {
                e.Column = new GridDateTimeColumn
                {
                    MappingName = "FechaEntrega",
                    HeaderText = "Fecha Entrega",
                    NullValue = null
                };
            }

            if (e.Column.MappingName == "FechaUltEntrega")
            {
                e.Column = new GridDateTimeColumn
                {
                    MappingName = "FechaUltEntrega",
                    HeaderText = "Fecha Últ. Entrega",
                    NullValue = null
                };
            }

            if (e.Column.MappingName == "FechaCancelación")
            {
                e.Column = new GridDateTimeColumn
                {
                    MappingName = "FechaCancelación",
                    HeaderText = "Fecha Cancelación",
                    NullValue = null,
                };
            }
        }

        /// <summary>
        /// Actualiza una línea al moverse de ella.
        /// </summary>
        void DataGridOnSelectionChanging(object sender, SelectionChangingEventArgs e)
        {
            if (e.RemovedItems.Count == 0) return;
            var línea = e.RemovedItems[0] as OrdenVentaLíneaModel;
            _orden = new OrdenVentaModel(); // TODO - GetByNumOrden(línea?.NumOrden.ToString());
            if (línea?.CantidadPendiente == 0)
            {
                línea.Estatus = "Entregada";
            }

            UpdateSaleOrderLine(_orden, línea, línea?.Estatus);
            UpdateStock(línea, _oldQty, _newQty);
            AddDelivery(línea);
            // Unhook para que este método sólo se ejecute después de Entregar Button.
            DataGrid.SelectionChanging -= DataGridOnSelectionChanging;
        }

        /// <summary>
        /// Pregunta al usuario la cantidad entregada de alguna línea seleccionada.
        /// </summary>
        void EntregarButton_Click(object sender, EventArgs e)
        {
            DataGrid.SelectionChanging += DataGridOnSelectionChanging;
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona una línea.");
                return;
            }

            var línea = DataGrid.SelectedItem as OrdenVentaLíneaModel;
            Debug.Assert(línea != null, nameof(línea) + " != null");

            // Obtener la cantidad recibida hasta el momento.
            _oldQty = línea.CantidadEntregada;
            // Preguntar la cantidad que se entregó. (No es cantidad acumulada).
            // De esta manera, la nueva cantidad es la recibida hasta el momento
            // más la ingresada por el usuario.
            ShowInputDialog(ref _newQtyString);
            if (string.IsNullOrEmpty(_newQtyString)) return;
            _newQty = _oldQty + double.Parse(_newQtyString);
            // Guardar las cantidades en la tabla.
            línea.CantidadEntregada = _newQty;
            var pendiente = línea.CantidadOrden - _newQty;
            línea.CantidadPendiente = pendiente < 0 ? 0 : pendiente;

            // Guardar la fecha de última recepción.
            // TODO - Tabla de historial de recepciones?
            línea.FechaUltEntrega = DateTime.Today;
        }

        void CancelarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona una línea.");
                return;
            }

            var línea = DataGrid.SelectedItem as OrdenVentaLíneaModel;
            Debug.Assert(línea != null, nameof(línea) + " != null");
            if (línea.Estatus == "Cancelada")
            {
                MessageBox.Show("Esta línea ya está cancelada.");
                return;
            }

            _orden = new OrdenVentaModel(); // TODO - GetByNumOrden(línea?.NumOrden.ToString());
            línea.CantidadPendiente = 0;
            línea.FechaCancelación = DateTime.Today;
            línea.Estatus = "Cancelada";
            UpdateSaleOrderLine(_orden, línea, línea.Estatus);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Muestra el diálogo para que el usuario ingrese una cantidad.
        /// Checa si el input es válido (un número).
        /// </summary>
        /// <param name="input">La variable donde se guarda el input.</param>
        static void ShowInputDialog(ref string input)
        {
            var size = new Size(300, 70);
            var inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Cantidad recibida:";

            var textBox = new TextBox();
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Location = new Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            var okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            var cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancelar";
            cancelButton.Location = new Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;
            inputBox.StartPosition = FormStartPosition.CenterScreen;

            var result = inputBox.ShowDialog();
            if (result == DialogResult.Cancel) return;
            if (!double.TryParse(textBox.Text, out _))
            {
                MessageBox.Show("Ingresa un número!");
                return;
            }
            input = textBox.Text;
        }

        /// <summary>
        /// Actualiza la cantidad entregada y pendiente en la tabla SaleOrderDetails en SQL.
        /// </summary>
        /// <param name="order">La orden a la que pertenece la línea</param>
        /// <param name="line">La línea a actualizar.</param>
        void UpdateSaleOrderLine(OrdenVentaModel order, OrdenVentaLíneaModel line, string estatus)
        {
            // TODO - Update(order.UniqueIdOrder, line, estatus);
        }

        /// <summary>
        /// Crea o actualiza el material en la tabla Stock en SQL.
        /// </summary>
        /// <param name="model">La línea donde se encuentra el material.</param>
        /// <param name="oldQty">La cantidad entregada anterior.</param>
        /// <param name="newQty">La cantidad entregada actualizada.</param>
        void UpdateStock(OrdenVentaLíneaModel model, double oldQty, double newQty)
        {
            // Obtener el modelo ProveedorProducto para obtener el nombre interno (que es el usado en Stock).
            var producto = new ClienteProductoModel(); // TODO - ClienteProducto_Find(model?.Producto, model?.Proveedor, model?.Area);

            // Averiguar si el material ya existe en la tabla Stock.
            var material = GlobalConfig.Connection.Material_GetByNombreArea(producto.ProductoInterno, model?.Area);
            // Si existe, se actualiza la cantidad disponible.
            material.CantidadDisponible -= (newQty - oldQty);
            GlobalConfig.Connection.Material_Update(material);
        }

        void AddDelivery(OrdenVentaLíneaModel model)
        {
            var quantity = double.Parse(_newQtyString);
            //TODO - Delivery_Create("V", _orden.NumOrden, model, quantity);
            // Reset para que el diálogo siempre aparezca vacío.
            _newQtyString = "";
        }

        #endregion
    }
}
