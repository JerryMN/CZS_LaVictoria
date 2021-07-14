﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.Input.Enums;
using System.Globalization;
using CZS_LaVictoria_Library.Models;
// ReSharper disable UseObjectOrCollectionInitializer

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class OrdenCompraVerForm : Form
    {
        OrdenCompraModel _orden;
        double _oldQty;
        double _newQty;
        string _newQtyString;

        public OrdenCompraVerForm()
        {
            InitializeComponent();
        }

        #region Events

        /// <summary>
        /// Busca las líneas de una orden de compra.
        /// </summary>
        void BuscarButton_Click(object sender, EventArgs e)
        {
            // Si no hay alguna orden seleccionada, muestra todas las líneas de todas las órdenes.
            if (NumOrdenText.Text == "" && PendientesCheck.CheckState == CheckState.Unchecked)
            {
                DataGrid.DataSource = GlobalConfig.Connection.OrdenCompra_GetAllLineas();
            }
            else if (NumOrdenText.Text == "" && PendientesCheck.CheckState == CheckState.Checked)
            {
                DataGrid.DataSource = GlobalConfig.Connection.OrdenCompra_GetLineasPendientes();
            }
            // Al seleccionar una orden, muestra todas las líneas de esa orden.
            else
            {
                _orden = GlobalConfig.Connection.OrdenCompra_GetByNumOrden(NumOrdenText.Text);
                DataGrid.DataSource = _orden;
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

            if (e.Column.MappingName == "CantidadRecibida")
            {
                e.Column.HeaderText = "Cantidad Recibida";
            }

            if (e.Column.MappingName == "CantidadPendiente")
            {
                e.Column.HeaderText = "Cantidad Pendiente";
            }

            if (e.Column.MappingName == "PrecioUnitario")
            {
                e.Column = new GridNumericColumn
                { MappingName = "PrecioUnitario", HeaderText = "Precio Unitario", FormatMode = FormatMode.Currency};
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

            if (e.Column.MappingName == "FechaUltRecepción")
            {
                e.Column = new GridDateTimeColumn
                {
                    MappingName = "FechaUltRecepción",
                    HeaderText = "Fecha Últ. Recepción",
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
            var línea = e.RemovedItems[0] as OrdenCompraLíneaModel;
            _orden = GlobalConfig.Connection.OrdenCompra_GetByNumOrden(línea?.NumOrden.ToString());
            Debug.Assert(línea != null, nameof(línea) + " != null");
            línea.Estatus = línea.CantidadPendiente == 0 ? "Entregada" : "Parcial";
            var saveSuccess = GlobalConfig.Connection.OrdenCompra_UpdateLinea(_orden.Id, línea, _oldQty, _newQty);
            MessageBox.Show(saveSuccess ? "Línea actualizada." : "Error al actualizar línea.");

            // Unhook para que este método sólo se ejecute después de Recibir Button.
            DataGrid.SelectionChanging -= DataGridOnSelectionChanging;
        }

        /// <summary>
        /// Pregunta al usuario la cantidad recibida de alguna línea seleccionada.
        /// </summary>
        void RecibirButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona una línea.");
                return;
            }

            var línea = DataGrid.SelectedItem as OrdenCompraLíneaModel;
            Debug.Assert(línea != null, nameof(línea) + " != null");
            if (línea.Estatus == "Entregada" || línea.Estatus == "Cancelada" || línea.Estatus == "Cerrada")
            {
                MessageBox.Show("Esta línea no se puede recibir.");
                return;
            }

            // Obtener la cantidad recibida hasta el momento.
            _oldQty = línea.CantidadRecibida;
            // Preguntar la cantidad que se entregó. (No es cantidad acumulada).
            // De esta manera, la nueva cantidad es la recibida hasta el momento
            // más la ingresada por el usuario.
            ShowInputDialog(ref _newQtyString);
            if (string.IsNullOrEmpty(_newQtyString)) return;
            _newQty = _oldQty + double.Parse(_newQtyString);
            // Guardar las cantidades en la tabla.
            línea.CantidadRecibida = _newQty;
            var pendiente = línea.CantidadOrden - _newQty;
            línea.CantidadPendiente = pendiente < 0 ? 0 : pendiente;

            // Guardar la fecha de última recepción.
            línea.FechaUltRecepción = DateTime.Today;

            _orden = GlobalConfig.Connection.OrdenCompra_GetByNumOrden(línea.NumOrden.ToString());
            Debug.Assert(línea != null, nameof(línea) + " != null");
            línea.Estatus = línea.CantidadPendiente == 0 ? "Entregada" : "Parcial";
            var saveSuccess = GlobalConfig.Connection.OrdenCompra_UpdateLinea(_orden.Id, línea, _oldQty, _newQty);
            MessageBox.Show(saveSuccess ? "Línea actualizada." : "Error al actualizar línea.");
        }

        /// <summary>
        /// Marca una línea como cancelada.
        /// </summary>
        void CancelarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona una línea.");
                return;
            }

            var línea = DataGrid.SelectedItem as OrdenCompraLíneaModel;
            Debug.Assert(línea != null, nameof(línea) + " != null");
            if (línea.Estatus == "Entregada" || línea.Estatus == "Cancelada" || línea.Estatus == "Cerrada")
            {
                MessageBox.Show("Esta línea ya no se puede cerrar o cancelar.");
                return;
            }

            _orden = GlobalConfig.Connection.OrdenCompra_GetByNumOrden(línea.NumOrden.ToString());
            línea.CantidadPendiente = 0;
            línea.FechaCancelación = DateTime.Today;
            línea.Estatus = línea.CantidadRecibida == 0 ? "Cancelada" : "Cerrada";
            var deleteSuccess = GlobalConfig.Connection.OrdenCompra_UpdateLinea(_orden.Id, línea, 0, 0);
            MessageBox.Show(deleteSuccess ? "Línea cancelada." : "Error al cancelar línea.");
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

        #endregion
    }
}
