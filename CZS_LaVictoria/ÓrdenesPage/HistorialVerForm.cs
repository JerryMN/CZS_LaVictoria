using System;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class HistorialVerForm : Form
    {
        public HistorialVerForm()
        {
            InitializeComponent();
        }

        void RadioChanged(object sender, EventArgs e)
        {
            DataGrid.DataSource = CompraButton.Checked ? GlobalConfig.Connection.Delivery_GetCompra() : GlobalConfig.Connection.Delivery_GetVenta();
        }

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
        }
    }
}
