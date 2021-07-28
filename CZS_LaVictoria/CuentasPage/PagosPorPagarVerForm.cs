using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library.Models;
using CZS_LaVictoria_Library;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.Input.Enums;

namespace CZS_LaVictoria.CuentasPage
{
    public partial class PagosPorPagarVerForm : Form
    {
        public PagosPorPagarVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = LoadTable();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCellsWithLastColumnFill;
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "Factura":
                    e.Column.HeaderText = "Factura u Orden";
                    break;
                case "Pago":
                    e.Column = new GridNumericColumn
                        {MappingName = "Pago", HeaderText = "Pago", FormatMode = FormatMode.Currency};
                    break;
                case "FechaPago":
                    e.Column = new GridDateTimeColumn {MappingName = "FechaPago", HeaderText = "Fecha Pago"};
                    break;
            }
        }

        #endregion

        #region Methods

        static List<PorPagarPagosModel> LoadTable()
        {
            return GlobalConfig.Connection.Payable_GetPagos();
        }

        #endregion
    }
}