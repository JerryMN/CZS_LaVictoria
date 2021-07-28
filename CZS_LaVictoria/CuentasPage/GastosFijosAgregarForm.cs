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

namespace CZS_LaVictoria.CuentasPage
{
    public partial class GastosFijosAgregarForm : Form
    {
        public GastosFijosAgregarForm()
        {
            InitializeComponent();
            DataGrid.DataSource = LoadTable();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Columns.Add(new GridCheckBoxSelectorColumn
            {
                MappingName = "Selector", HeaderText = string.Empty, AllowCheckBoxOnHeader = true, Width = 50,
                CheckBoxSize = new Size(14, 14)
            });
            DataGrid.Columns.Move(2, 0);
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCellsWithLastColumnFill;
            FechaFacturaPicker.Culture = new CultureInfo("es-MX");
        }

        #region Events

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "Concepto":
                    e.Column.AutoSizeColumnsMode = AutoSizeColumnsMode.LastColumnFill;
                    break;
                case "Monto":
                    e.Column = new GridNumericColumn
                        {MappingName = "Monto", HeaderText = "Monto", FormatMode = FormatMode.Currency};
                    break;
            }
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            var saveSuccess = false;
            var gasto = new GastoFijoModel();

            if (DataGrid.SelectedItems.Count <= 0)
                MessageBox.Show("Selecciona al menos un gasto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            try
            {
                foreach (var record in DataGrid.SelectedItems)
                {
                    gasto = (GastoFijoModel) record;
                    var línea = new PorPagarModel
                    {
                        FechaFactura = FechaFacturaPicker.Value,
                        Proveedor = gasto.Concepto,
                        Monto = gasto.Monto,
                        Pagado = 0,
                        Pendiente = gasto.Monto,
                        Estatus = "Pendiente",
                        Notas = "Gasto Fijo"
                    };
                    saveSuccess = GlobalConfig.Connection.Payable_Create(línea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar gasto {gasto.Concepto}.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Debug.WriteLine(ex.ToString());
                Debug.Assert(false);
            }
            finally
            {
                if (saveSuccess) Dispose();
            }
        }

        #endregion

        #region Methods

        static List<GastoFijoModel> LoadTable()
        {
            return GlobalConfig.Connection.GastoFijo_GetAll();
        }

        #endregion
    }
}