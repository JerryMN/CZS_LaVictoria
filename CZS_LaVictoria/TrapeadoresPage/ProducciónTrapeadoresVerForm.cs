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

namespace CZS_LaVictoria.TrapeadoresPage
{
    public partial class ProducciónTrapeadoresVerForm : Form
    {
        public ProducciónTrapeadoresVerForm()
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
                case "CantidadBastón":
                    e.Column = new GridNumericColumn
                    {
                        MappingName = "CantidadBastón", HeaderText = "Cantidad Bastón", 
                        FormatMode = FormatMode.Numeric
                    };
                    break;
                case "CantidadAlambre":
                    e.Column = new GridNumericColumn
                    {
                        MappingName = "CantidadAlambre", HeaderText = "Cantidad Alambre",
                        FormatMode = FormatMode.Numeric
                    };
                    break;
                case "CantidadBolsa":
                    e.Column = new GridNumericColumn
                    {
                        MappingName = "CantidadBolsa", HeaderText = "Cantidad Bolsa", 
                        FormatMode = FormatMode.Numeric
                    };
                    break;
                case "CantidadMecha":
                    e.Column = new GridNumericColumn
                    {
                        MappingName = "CantidadMecha", HeaderText = "Cantidad Mecha", 
                        FormatMode = FormatMode.Numeric
                    };
                    break;
                case "CantidadEtiqueta":
                    e.Column = new GridNumericColumn
                    {
                        MappingName = "CantidadEtiqueta", HeaderText = "Cantidad Etiqueta",
                        FormatMode = FormatMode.Numeric
                    };
                    break;
                case "CantidadKit":
                    e.Column = new GridNumericColumn
                    {
                        MappingName = "CantidadKit", HeaderText = "Cantidad Kits", 
                        FormatMode = FormatMode.Numeric, AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill
                    };
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
                GlobalConfig.Connection.MopProduction_GetByDate((DateTime) DesdePicker.Value,
                    (DateTime) HastaPicker.Value);
        }

        #endregion

        #region Methods

        static List<ProducciónTrapeadoresModel> LoadTable()
        {
            return GlobalConfig.Connection.MopProduction_GetAll();
        }

        #endregion
    }
}