using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.WinForms.DataGrid;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class OrdenCompraCrearForm : Form
    {
        ProveedorModel _selectedProveedor;
        List<ProveedorProductoModel> _productos;
        List<PurchaseOrderLineModel> _orderLines = new List<PurchaseOrderLineModel>();
        int _count;

        public OrdenCompraCrearForm()
        {
            InitializeComponent();
            GetProveedores();
            GetAreas();
        }

        #region Events

        void ProveedorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProveedor = (ProveedorModel)ProveedorCombo.SelectedItem;
            GetCondiciones();
            TeléfonoText.Text = _selectedProveedor.Teléfono;
            CorreoText.Text = _selectedProveedor.Correo;
            AtencionText.Text = _selectedProveedor.Responsable;
            CondicionesCombo.Text = _selectedProveedor.Condiciones;
            GetProducts();
        }

        void AreaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProducts();
        }

        #endregion

        #region Methods

        void GetProveedores()
        {
            ProveedorCombo.Items.Clear();
            var proveedores = GlobalConfig.Connection.Proveedor_GetAll();

            foreach (var proveedor in proveedores)
            {
                ProveedorCombo.Items.Add(proveedor);
            }

            ProveedorCombo.DisplayMember = "Nombre";
        }

        void GetAreas()
        {
            AreaCombo.Items.Clear();
            var areas = GlobalConfig.Connection.Area_GetAll();

            foreach (var area in areas)
            {
                AreaCombo.Items.Add(area);
            }

            AreaCombo.DisplayMember = "Area";
        }

        void GetCondiciones()
        {
            CondicionesCombo.Items.Clear();
            var condiciones = GlobalConfig.Connection.ProveedorCondiciones_GetDistinct();

            foreach (var condición in condiciones)
            {
                CondicionesCombo.Items.Add(condición);
            }

            CondicionesCombo.DisplayMember = "Condiciones";
        }

        void GetProducts()
        {
            _productos = GlobalConfig.Connection.ProveedorProducto_GetByProveedorArea(_selectedProveedor.IdProvider, AreaCombo.Text);

            var riComboBox = new RepositoryItemComboBox();
            foreach (var item in _productos)
            {
                riComboBox.Items.Add(item.MaterialExterno);
            }
            GridControl.RepositoryItems.Add(riComboBox);
            GridView.Columns["Producto"].ColumnEdit = riComboBox;
        }

        #endregion

        void GridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            var selectedProducto = new ProveedorProductoModel();
            if (e.RowHandle < 0) return;

            foreach (var producto in _productos)
            {
                if (producto.MaterialExterno != GridView.GetRowCellValue(e.RowHandle, "Producto").ToString() && ProveedorCombo.Text != producto.Proveedor) continue;
                selectedProducto = producto;
            }

            GridView.SetRowCellValue(e.RowHandle, "PrecioUnitario", selectedProducto.PrecioUnitario);

            double.TryParse(e.Value.ToString(), out var cantidad);
            double.TryParse(GridView.GetRowCellValue(e.RowHandle, "PrecioUnitario").ToString(), out var precio);

            if (cantidad == 0) return;
            
            if (GridView.GetRowCellValue(e.RowHandle, "Iva").ToString() == "True")
            {
                GridView.SetRowCellValue(e.RowHandle, "Subtotal", cantidad * precio * 1.16);
            }
            else
            {
                GridView.SetRowCellValue(e.RowHandle, "Subtotal", cantidad * precio);
            }
        }

        void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as GridView;
            view?.SetRowCellValue(e.RowHandle, view.Columns["CantidadOrden"], 0);
            view?.SetRowCellValue(e.RowHandle, view.Columns["Iva"], 0);
            view?.SetRowCellValue(e.RowHandle, view.Columns["Subtotal"], 0);

            var newRowId = GridView.RowCount;
            view?.SetRowCellValue(e.RowHandle, view.Columns["NumLinea"], newRowId);
        }

        BaseEdit _edit;

        void GridView_ShownEditor(object sender, EventArgs e)
        {
            var view = sender as GridView;
            _edit = view?.ActiveEditor;
            if (_edit != null) _edit.EditValueChanged += edit_EditValueChanged;
        }

        void GridView_HiddenEditor(object sender, EventArgs e)
        {
            _edit.EditValueChanged -= edit_EditValueChanged;
            _edit = null;
        }

        void edit_EditValueChanged(object sender, EventArgs e)
        {
            GridView.PostEditor();
        }
    }
}

