using Syncfusion.WinForms.DataGrid.Enums;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Styles;
using CZS_LaVictoria_Library.Models;
using CZS_LaVictoria_Library;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.Input.Enums;
using System;

namespace CZS_LaVictoria.CuentasPage
{
    public partial class PorCobrarVerForm : Form
    {
        public PorCobrarVerForm()
        {
            InitializeComponent();
            DataGrid.DataSource = LoadTable();
            DataGrid.Style.CellStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.Style.HeaderStyle.Font = new GridFontInfo(new Font("Segoe UI", 12));
            DataGrid.AutoSizeColumnsMode = AutoSizeColumnsMode.AllCells;
        }

        static List<PorCobrarModel> LoadTable()
        {
            return GlobalConfig.Connection.Receivable_GetAll();
        }

        void DataGrid_AutoGeneratingColumn(object sender, AutoGeneratingColumnArgs e)
        {
            switch (e.Column.MappingName)
            {
                case "Id":
                    e.Cancel = true;
                    break;
                case "NumOrden":
                    e.Column.HeaderText = "Núm. Orden";
                    break;
                case "FechaFactura":
                    e.Column = new GridDateTimeColumn
                        { MappingName = "FechaFactura", HeaderText = "Fecha Factura", NullValue = null };
                    break;
                case "Monto":
                    e.Column = new GridNumericColumn
                        { MappingName = "Monto", HeaderText = "Monto", FormatMode = FormatMode.Currency };
                    break;
                case "Pagado":
                    e.Column = new GridNumericColumn
                        { MappingName = "Pagado", HeaderText = "Pagado", FormatMode = FormatMode.Currency };
                    break;
                case "Pendiente":
                    e.Column = new GridNumericColumn
                        { MappingName = "Pendiente", HeaderText = "Pendiente", FormatMode = FormatMode.Currency };
                    break;
                case "FechaLiquidación":
                    e.Column = new GridDateTimeColumn
                        { MappingName = "FechaLiquidación", HeaderText = "Fecha Liquidación", NullValue = null };
                    break;
            }
        }

        void RegistrarButton_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona una línea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var línea = (PorCobrarModel)DataGrid.SelectedItem;

            if (línea.Estatus == "Pagado")
            {
                MessageBox.Show("Esta línea ya está cobrada, selecciona otra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var registro = new PorCobrarCobrarForm(línea);
            registro.Show();
        }

        void AgregarButton_Click(object sender, EventArgs e)
        {
            var agregar = new PorCobrarAgregarForm();
            agregar.Show();
            agregar.Disposed += (o, args) => DataGrid.DataSource = LoadTable();
        }
    }
}
