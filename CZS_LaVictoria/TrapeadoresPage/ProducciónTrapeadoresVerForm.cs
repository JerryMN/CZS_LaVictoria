using System.Collections.Generic;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.Input.Enums;

namespace CZS_LaVictoria.TrapeadoresPage
{
    public partial class ProducciónTrapeadoresVerForm : Form
    {
        public ProducciónTrapeadoresVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = LoadTable();
        }

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "CantidadBastón":
                    e.Column = new GridNumericColumn
                    { MappingName = "CantidadBastón", HeaderText = "Cantidad Bastón", FormatMode = FormatMode.Numeric };
                    break;
                case "CantidadAlambre":
                    e.Column = new GridNumericColumn
                    { MappingName = "CantidadAlambre", HeaderText = "Cantidad Alambre", FormatMode = FormatMode.Numeric };
                    break;
                case "CantidadBolsa":
                    e.Column = new GridNumericColumn
                    { MappingName = "CantidadBolsa", HeaderText = "Cantidad Bolsa", FormatMode = FormatMode.Numeric };
                    break;
                case "CantidadMecha":
                    e.Column = new GridNumericColumn
                        { MappingName = "CantidadMecha", HeaderText = "Cantidad Mecha", FormatMode = FormatMode.Numeric };
                    break;
                case "CantidadEtiqueta":
                    e.Column = new GridNumericColumn
                        { MappingName = "CantidadEtiqueta", HeaderText = "Cantidad Etiqueta", FormatMode = FormatMode.Numeric };
                    break;
                case "CantidadKit":
                    e.Column = new GridNumericColumn
                        { MappingName = "CantidadKit", HeaderText = "Cantidad Kits", FormatMode = FormatMode.Numeric };
                    break;
            }
        }

        static List<ProducciónTrapeadoresModel> LoadTable()
        {
            return GlobalConfig.Connection.MopProduction_GetAll();
        }
    }
}
