using System;
using System.Collections.Generic;
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

namespace CZS_LaVictoria.PlásticosPage
{
    public partial class RetrabajoVerForm : Form
    {
        public RetrabajoVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = LoadTable();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCellsWithLastColumnFill;
            DesdePicker.Culture = new CultureInfo("es-MX");
            HastaPicker.Culture = new CultureInfo("es-MX");
            DesdePicker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            HastaPicker.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month,
                DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "PiezaMala":
                    e.Column.HeaderText = "Pieza Mala";
                    e.Column.AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
                    break;
                case "Piezas":
                    e.Column = new GridNumericColumn
                        {MappingName = "Piezas", HeaderText = "Cantidad", FormatMode = FormatMode.Numeric};
                    break;
                case "Peso":
                    e.Column = new GridNumericColumn
                        {MappingName = "Peso", HeaderText = "Peso", FormatMode = FormatMode.Numeric};
                    break;
            }
        }

        void TodosCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (TodosCheck.Checked)
            {
                DataGrid.DataSource = LoadTable();
                DesdePicker.Enabled = false;
                HastaPicker.Enabled = false;
                BuscarButton.Enabled = false;
            }
            else
            {
                DesdePicker.Enabled = true;
                HastaPicker.Enabled = true;
                BuscarButton.Enabled = true;
            }
        }

        void BuscarButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(DesdePicker.Value != null, "DesdePicker.Value != null");
            Debug.Assert(HastaPicker.Value != null, "HastaPicker.Value != null");
            DataGrid.DataSource =
                GlobalConfig.Connection.PlasticProduction_RetrabajoGetByDate((DateTime) DesdePicker.Value,
                    (DateTime) HastaPicker.Value);
        }

        #endregion

        #region Methods

        static List<RetrabajoPlásticosModel> LoadTable()
        {
            return GlobalConfig.Connection.PlasticProduction_RetrabajoGetAll();
        }

        #endregion
    }
}