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

namespace CZS_LaVictoria.PlásticosPage
{
    public partial class PiezasMalasVerForm : Form
    {
        public PiezasMalasVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = LoadPiezas();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
        }

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Id")
            {
                e.Cancel = true;
            }

            if (e.Column.MappingName == "Nombre")
            {
                e.Column.AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
            }

            if (e.Column.MappingName == "CantidadDisponible")
            {
                e.Column = new GridNumericColumn
                {
                    MappingName = "CantidadDisponible",
                    HeaderText = "Cantidad Disponible",
                    FormatMode = FormatMode.Numeric
                };
            }
        }

        static List<MaterialModel> LoadPiezas()
        {
            return GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Piezas Malas");
        }
    }
}
