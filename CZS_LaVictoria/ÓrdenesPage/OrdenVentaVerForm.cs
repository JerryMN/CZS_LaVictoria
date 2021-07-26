using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.Input.Enums;

// ReSharper disable UseObjectOrCollectionInitializer

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class OrdenVentaVerForm : Form
    {
        static string _newQtyString;
        double _newQty;
        double _oldQty;
        OrdenVentaModel _orden;

        public OrdenVentaVerForm()
        {
            InitializeComponent();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
            DataGrid.DataSource = GlobalConfig.Connection.OrdenVenta_GetAllLineas();
        }

        #region Events

        /// <summary>
        ///     Busca las líneas de una orden de venta.
        /// </summary>
        void BuscarButton_Click(object sender, EventArgs e)
        {
            // Si no hay alguna orden seleccionada, muestra todas las líneas de todas las órdenes.
            if (NumOrdenText.Text == "" && PendientesCheck.CheckState == CheckState.Unchecked)
                DataGrid.DataSource = GlobalConfig.Connection.OrdenVenta_GetAllLineas();
            else if (NumOrdenText.Text == "" && PendientesCheck.CheckState == CheckState.Checked)
                DataGrid.DataSource = GlobalConfig.Connection.OrdenVenta_GetLineasPendientes();
            // Al seleccionar una orden, muestra todas las líneas de esa orden.
            else
                DataGrid.DataSource = GlobalConfig.Connection.OrdenVenta_GetLineasByNumOrden(NumOrdenText.Text);

            // Ordenar tabla por Número de Orden.
            if (DataGrid.SortColumnDescriptions.Count != 0) DataGrid.SortColumnDescriptions.RemoveAt(0);

            DataGrid.SortColumnDescriptions.Add(new SortColumnDescription
                {ColumnName = "NumOrden", SortDirection = ListSortDirection.Ascending});
        }

        /// <summary>
        ///     Genera las columnas de la tabla.
        /// </summary>
        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "NumOrden":
                    var nfi = new NumberFormatInfo { NumberDecimalDigits = 0, NumberGroupSizes = new int[] { } };
                    e.Column = new GridNumericColumn
                        { MappingName = "NumOrden", HeaderText = "Orden", NumberFormatInfo = nfi };
                    break;
                case "NumLinea":
                    e.Column.HeaderText = "Línea";
                    e.Column.AllowFiltering = false;
                    break;
                case "CantidadOrden":
                    e.Column.HeaderText = "Cantidad Orden";
                    break;
                case "CantidadEntregada":
                    e.Column.HeaderText = "Cantidad Entregada";
                    break;
                case "CantidadPendiente":
                    e.Column.HeaderText = "Cantidad Pendiente";
                    break;
                case "PrecioUnitario":
                    e.Column = new GridNumericColumn
                    {
                        MappingName = "PrecioUnitario", HeaderText = "Precio Unitario", FormatMode = FormatMode.Currency
                    };
                    break;
                case "Iva":
                    e.Column = new GridCheckBoxColumn { MappingName = "Iva", HeaderText = "IVA" };
                    break;
                case "Subtotal":
                    e.Column = new GridNumericColumn
                        { MappingName = "Subtotal", HeaderText = "Subtotal", FormatMode = FormatMode.Currency };
                    break;
                case "FechaEntrega":
                    e.Column = new GridDateTimeColumn
                        { MappingName = "FechaEntrega", HeaderText = "Fecha Entrega", NullValue = null };
                    break;
                case "FechaUltEntrega":
                    e.Column = new GridDateTimeColumn
                        { MappingName = "FechaUltEntrega", HeaderText = "Fecha Últ. Entrega", NullValue = null };
                    break;
                case "FechaCancelación":
                    e.Column = new GridDateTimeColumn
                        { MappingName = "FechaCancelación", HeaderText = "Fecha Cancelación", NullValue = null };
                    break;
            }
        }

        /// <summary>
        ///     Pregunta al usuario la cantidad entregada de alguna línea seleccionada.
        /// </summary>
        void EntregarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona una línea a entregar.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            var línea = (OrdenVentaLíneaModel) DataGrid.SelectedItem;
            Debug.Assert(línea != null, nameof(línea) + " != null");
            if (línea.Estatus == "Entregada" || línea.Estatus == "Cancelada" || línea.Estatus == "Cerrada")
            {
                MessageBox.Show("Esta línea no se puede entregar, ya está cerrada o cancelada.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la cantidad entregada hasta el momento.
            _oldQty = línea.CantidadEntregada;
            // Preguntar la cantidad que se entregó. (No es cantidad acumulada).
            // De esta manera, la nueva cantidad es la recibida hasta el momento
            // más la ingresada por el usuario.
            _newQtyString = "";
            ShowInputDialog(ref _newQtyString);
            if (string.IsNullOrEmpty(_newQtyString)) return;
            if (!double.TryParse(_newQtyString, out var dialogResult)) return;
            _newQty = _oldQty + dialogResult;
            // Guardar las cantidades en la tabla.
            línea.CantidadEntregada = _newQty;
            var pendiente = línea.CantidadOrden - _newQty;
            línea.CantidadPendiente = pendiente < 0 ? 0 : pendiente;
            línea.FechaUltEntrega = DateTime.Today;
            línea.Estatus = línea.CantidadPendiente == 0 ? "Entregada" : "Parcial";

            _orden = GlobalConfig.Connection.OrdenVenta_GetByNumOrden(línea.NumOrden.ToString());
            var saveSuccess = GlobalConfig.Connection.OrdenVenta_UpdateLinea(_orden.Id, línea, _oldQty, _newQty);
            MessageBox.Show(saveSuccess ? "Línea actualizada." : "Error al actualizar línea.", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        ///     Marca una línea como cerrada o cancelada.
        /// </summary>
        void CancelarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona una línea a cerrar o cancelar.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Estás seguro de cerrar o cancelar esta línea? Esta acción es irreversible,",
                "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var línea = (OrdenVentaLíneaModel) DataGrid.SelectedItem;
            Debug.Assert(línea != null, nameof(línea) + " != null");
            if (línea.Estatus == "Entregada" || línea.Estatus == "Cancelada" || línea.Estatus == "Cerrada")
            {
                MessageBox.Show("Esta línea no se puede cerrar o cancelar, ya está previamente cerrada o cancelada.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _orden = GlobalConfig.Connection.OrdenVenta_GetByNumOrden(línea.NumOrden.ToString());
            línea.CantidadPendiente = 0;
            línea.FechaCancelación = DateTime.Today;
            línea.Estatus = línea.CantidadEntregada == 0 ? "Cancelada" : "Cerrada";
            var deleteSuccess = GlobalConfig.Connection.OrdenVenta_UpdateLinea(_orden.Id, línea, 0, 0);
            MessageBox.Show(deleteSuccess ? $"Línea {línea.Estatus.ToLower()}." : "Error al cerrar o cancelar línea.",
                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Muestra el diálogo para que el usuario ingrese una cantidad.
        ///     Checa si el input es válido (un número).
        /// </summary>
        /// <param name="input">La variable donde se guarda el input.</param>
        static void ShowInputDialog(ref string input)
        {
            var size = new Size(300, 70);
            var inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Cantidad entregada:";
            inputBox.MinimizeBox = false;
            inputBox.MaximizeBox = false;

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
                MessageBox.Show("Ingresa un número!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowInputDialog(ref _newQtyString);
                return;
            }

            input = textBox.Text;
        }

        #endregion
    }
}