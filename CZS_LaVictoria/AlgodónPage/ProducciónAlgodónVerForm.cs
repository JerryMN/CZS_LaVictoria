using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.Input.Enums;

namespace CZS_LaVictoria.AlgodónPage
{
    public partial class ProducciónAlgodónVerForm : Form
    {
        public ProducciónAlgodónVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = LoadTable();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
        }

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "MaterialEntra":
                    e.Column.HeaderText = "Material Entra";
                    break;
                case "CantidadEntra":
                    e.Column = new GridNumericColumn
                    { MappingName = "CantidadEntra", HeaderText = "Cantidad Entra", FormatMode = FormatMode.Numeric };
                    break;
                case "MaterialSale":
                    e.Column.HeaderText = "Material Sale";
                    break;
                case "CantidadSale":
                    e.Column = new GridNumericColumn
                    { MappingName = "CantidadSale", HeaderText = "Cantidad Sale", FormatMode = FormatMode.Numeric };
                    break;
            }
        }

        static List<ProducciónAlgodónModel> LoadTable()
        {
            return GlobalConfig.Connection.WoolProduction_GetAll();
        }
    }
}
