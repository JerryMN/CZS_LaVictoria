using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;
using DevExpress.CodeParser;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Syncfusion.WinForms.DataGrid;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class OrdenCompraCrearForm : Form
    {
        BaseEdit _edit;
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

        /// <summary>
        /// Llena el formulario con los datos del proveedor seleccionado.
        /// </summary>
        void ProveedorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProveedor = (ProveedorModel)ProveedorCombo.SelectedItem;
            GetCondiciones();
            TeléfonoText.Text = _selectedProveedor.Teléfono;
            CorreoText.Text = _selectedProveedor.Correo;
            AtencionText.Text = _selectedProveedor.Responsable;
            CondicionesCombo.Text = _selectedProveedor.Condiciones;
            if (AreaCombo.Text == "") return;
            GetProducts();
        }

        /// <summary>
        /// Obtiene los productos para el proveedor y área seleccionadas.
        /// </summary>
        void AreaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProveedorCombo.Text == "") return;
            GetProducts();
        }

        /// <summary>
        /// Genera el número de línea correspondiente.
        /// </summary>
        void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as GridView;
            var newRowId = GridView.RowCount;
            view?.SetRowCellValue(e.RowHandle, view.Columns["NumLinea"], newRowId);
        }

        /// <summary>
        /// Obtiene el precio unitario del producto seleccionado y calcula el subtotal.
        /// </summary>
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
            GridView.SetRowCellValue(e.RowHandle, "Subtotal", cantidad * precio);
        }

        /// <summary>
        /// Agrega el IVA y ordena las filas.
        /// </summary>
        void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Producto")
            {
                GridView.BeginSort();
                try
                {
                    GridView.ClearSorting();
                    GridView.Columns[0].SortOrder = ColumnSortOrder.Ascending;
                }
                finally
                {
                    GridView.EndSort();
                }
            }

            if (e.Column.FieldName != "Iva") return;
            double.TryParse(GridView.GetRowCellValue(e.RowHandle, "CantidadOrden").ToString(), out var cantidad);
            double.TryParse(GridView.GetRowCellValue(e.RowHandle, "PrecioUnitario").ToString(), out var precio);
            if ((bool)e.Value)
            {
                GridView.SetRowCellValue(e.RowHandle, "Subtotal", cantidad * precio * 1.16);
            }
            else
            {
                GridView.SetRowCellValue(e.RowHandle, "Subtotal", cantidad * precio);
            }
        }

        void GridView_ShownEditor(object sender, EventArgs e)
        {
            var view = sender as GridView;
            _edit = view?.ActiveEditor;
            if (_edit != null) _edit.EditValueChanged += Edit_EditValueChanged;
        }

        void GridView_HiddenEditor(object sender, EventArgs e)
        {
            _edit.EditValueChanged -= Edit_EditValueChanged;
            _edit = null;
        }

        void Edit_EditValueChanged(object sender, EventArgs e)
        {
            GridView.PostEditor();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Obtiene todos los proveedores en SQL.
        /// </summary>
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

        /// <summary>
        /// Obtiene todas las áreas en SQL.
        /// </summary>
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

        /// <summary>
        /// Obtiene todas las diferentes condiciones en SQL.
        /// </summary>
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

        /// <summary>
        /// Obtiene los productos para el proveedor y área seleccionadas.
        /// </summary>
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
    }
}

