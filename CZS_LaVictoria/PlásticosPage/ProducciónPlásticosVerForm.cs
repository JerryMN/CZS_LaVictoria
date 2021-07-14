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
    public partial class ProducciónPlásticosVerForm : Form
    {
        public ProducciónPlásticosVerForm()
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
                        {MappingName = "CantidadEntra", HeaderText = "Cantidad Entra", FormatMode = FormatMode.Numeric };
                    break;
                case "FibraEntra":
                    e.Column.HeaderText = "Fibra Entra";
                    break;
                case "CantidadFibraEntra":
                    e.Column = new GridNumericColumn
                        { MappingName = "CantidadFibraEntra", HeaderText = "Cantidad Fibra Entra", FormatMode = FormatMode.Numeric};
                    break;
                case "MaterialSale":
                    e.Column.HeaderText = "Material Sale";
                    break;
                case "CantidadSale":
                    e.Column = new GridNumericColumn
                        { MappingName = "CantidadSale", HeaderText = "Cantidad Sale", FormatMode = FormatMode.Numeric };
                    break;
                case "PesoPromedio":
                    e.Column = new GridNumericColumn
                        { MappingName = "PesoPromedio", HeaderText = "Peso Promedio", FormatMode = FormatMode.Numeric };
                    break;
                case "PiezasBuenas":
                    e.Column.HeaderText = "Piezas Buenas";
                    break;
                case "PiezasMalas":
                    e.Column.HeaderText = "Piezas Malas";
                    break;
                case "BasesMalas":
                    e.Column.HeaderText = "Bases Malas";
                    break;
                case "Viruta":
                    e.Column = new GridNumericColumn
                        { MappingName = "Viruta", HeaderText = "Viruta", FormatMode = FormatMode.Numeric };
                    break;
                case "Rebaba":
                    e.Column = new GridNumericColumn
                        { MappingName = "Rebaba", HeaderText = "Rebaba", FormatMode = FormatMode.Numeric };
                    break;
                case "TipoAlambre":
                    e.Column.HeaderText = "Alambre";
                    break;
                case "RollosAlambre":
                    e.Column.HeaderText = "Rollos";
                    break;
                case "MermaMoler":
                    e.Column = new GridNumericColumn
                        { MappingName = "MermaMoler", HeaderText = "Merma a Moler", FormatMode = FormatMode.Numeric};
                    break;
                case "MermaFinal":
                    e.Column = new GridNumericColumn
                        { MappingName = "MermaFinal", HeaderText = "Merma Final", FormatMode = FormatMode.Numeric};
                    break;
            }
        }

        static List<ProducciónPlásticosModel> LoadTable()
        {
            return GlobalConfig.Connection.PlasticProduction_GetAll();
        }
    }
}
