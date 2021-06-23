using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CZS_ERP_Library;
using CZS_ERP_Library.Models;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Mask;

namespace CZS_ERP_UI.DatosPage
{
    public partial class ViewProvidersForm : XtraForm
    {
        public ViewProvidersForm()
        {
            InitializeComponent();

            GridControl.DataSource = GetProveedores();
            GridView.Columns[0].Width = 50;
            GridView.Columns["Telefono"].Caption = "Teléfono";
            GridView.Columns["Direccion"].Caption = "Dirección";
            GridView.OptionsBehavior.Editable = false;
        }

        #region Methods

        static List<ProveedorModel> GetProveedores()
        {
            return GlobalConfig.Connection.ProveedorGetAll();
        }

        #endregion

        void EditButton_Click(object sender, System.EventArgs e)
        {
            if (EditButton.Text == "Editar")
            {
                GridView.OptionsBehavior.Editable = true;
                GridView.Columns[0].OptionsColumn.ReadOnly = true;
                EditButton.Text = "Guardar";
                GridView.Appearance.FocusedRow.BackColor = Color.Yellow;
            }
            else if (EditButton.Text == "Guardar")
            {
                var model = (ProveedorModel) GridView.GetFocusedRow();
                var updateSuccess = GlobalConfig.Connection.ProveedorUpdate(model);

                if (updateSuccess)
                {
                    GridView.OptionsBehavior.Editable = false;
                    EditButton.Text = "Editar";
                    MessageBox.Show($"Proveedor {model.Nombre} actualizado con éxito.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al actualizar proveedor {model.Nombre}.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                GridView.OptionsBehavior.Editable = false;
                EditButton.Text = "Editar";
                GridView.Appearance.FocusedRow.BackColor = Color.LightBlue;
            }
        }

        void DeleteButton_Click(object sender, System.EventArgs e)
        {
            var model = (ProveedorModel) GridView.GetFocusedRow();

            if (MessageBox.Show($"Estás seguro de eliminar al proveedor {model.Nombre}? Esta acción es irreversible.", null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            var deleteSuccess = GlobalConfig.Connection.ProveedorDelete(model);

            if (deleteSuccess)
            {
                GridControl.DataSource = GetProveedores();
                MessageBox.Show($"Proveedor {model.Nombre} eliminado con éxito.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al eliminar proveedor {model.Nombre}.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}