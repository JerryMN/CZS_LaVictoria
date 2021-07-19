﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.Input.Enums;

namespace CZS_LaVictoria.CuentasPage
{
    public partial class PorPagarVerForm : Form
    {
        public PorPagarVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = LoadTable();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
        }

        static List<PorPagarModel> LoadTable()
        {
            return GlobalConfig.Connection.Payable_GetAll();
        }

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "NumOrden":
                    e.Column.HeaderText = "Núm. Orden";
                    break;
                case "FechaFactura":
                    e.Column = new GridDateTimeColumn
                        { MappingName = "FechaFactura", HeaderText = "Fecha Factura", NullValue = null };
                    break;
                case "Monto":
                    e.Column = new GridNumericColumn
                        {MappingName = "Monto", HeaderText = "Monto", FormatMode = FormatMode.Currency};
                    break;
                case "Pagado":
                    e.Column = new GridNumericColumn
                        { MappingName = "Pagado", HeaderText = "Pagado", FormatMode = FormatMode.Currency };
                    break;
                case "Pendiente":
                    e.Column = new GridNumericColumn
                        { MappingName = "Pendiente", HeaderText = "Pendiente", FormatMode = FormatMode.Currency };
                    break;
                case "FechaLímite":
                    e.Column = new GridDateTimeColumn
                        { MappingName = "FechaLímite", HeaderText = "Fecha Límite de Pago", NullValue = null };
                    break;
                case "FechaLiquidación":
                    e.Column = new GridDateTimeColumn
                        { MappingName = "FechaLiquidación", HeaderText = "Fecha Liquidación", NullValue = null };
                    break;
            }
        }
    }
}
