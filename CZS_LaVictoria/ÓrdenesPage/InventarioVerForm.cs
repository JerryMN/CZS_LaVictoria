using System;
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

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class InventarioVerForm : Form
    {
        public InventarioVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = GetStock();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
        }

        #region Events

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

        void NuevoButton_Click(object sender, System.EventArgs e)
        {
            var newForm = new InventarioCrearForm();
            newForm.Show();
            DataGrid.DataSource = GetStock();
            newForm.Disposed += NewFormOnDisposed;
        }

        void NewFormOnDisposed(object sender, EventArgs e)
        {
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
