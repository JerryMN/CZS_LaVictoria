using System;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.Input.Enums;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class HistorialVerForm : Form
    {
        public HistorialVerForm()
        {
            InitializeComponent();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
        }

        #region Events

        /// <summary>
        /// Genera las columnas de la tabla.
        /// </summary>
        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "TipoOrden")
            {
                e.Cancel = true;
            }

            if (e.Column.MappingName == "NumOrden")
            {
                e.Column.HeaderText = "Núm. Orden";
            }

            if (e.Column.MappingName == "NumLinea")
            {
                e.Column.HeaderText = "Núm. Línea";
            }

            if (e.Column.MappingName == "Producto")
            {
                e.Column.AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
            }

            if (e.Column.MappingName == "Cantidad")
            {
                e.Column = new GridNumericColumn
                    {MappingName = "Cantidad", HeaderText = "Cantidad", FormatMode = FormatMode.Numeric};
            }

            if (e.Column.MappingName == "Precio")
            {
                e.Column = new GridNumericColumn
                    { MappingName = "Precio", HeaderText = "Precio", FormatMode = FormatMode.Numeric };
            }
        }

        /// <summary>
        /// Cambia el contenido de la tabla dependiendo del botón seleccionado.
        /// </summary>
        void RadioChanged(object sender, EventArgs e)
        {
            DataGrid.DataSource = CompraButton.Checked ? GlobalConfig.Connection.Delivery_GetCompra() : GlobalConfig.Connection.Delivery_GetVenta();
        }

        #endregion
    }
}
