using System.Collections.Generic;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.Input.Enums;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class InventarioVerForm : Form
    {
        public InventarioVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = GetStock();
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "IdMaterial")
            {
                e.Cancel = true;
            }

            if (e.Column.MappingName == "Nombre")
            {
                e.Column.AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
            }

            if (e.Column.MappingName == "Area")
            {
                e.Column.HeaderText = "Área";
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

            if (e.Column.MappingName == "Peso")
            {
                e.Column = new GridNumericColumn
                {
                    MappingName = "Peso",
                    HeaderText = "Peso",
                    FormatMode = FormatMode.Numeric
                };
            }
        }

        void NuevoButton_Click(object sender, System.EventArgs e)
        {
            var newForm = new InventarioCrearForm();
            newForm.Show();
            DataGrid.DataSource = GetStock();
        }

        #endregion

        #region Methods

        static List<MaterialModel> GetStock()
        {
            return GlobalConfig.Connection.Material_GetAll();
        }

        #endregion
    }
}
