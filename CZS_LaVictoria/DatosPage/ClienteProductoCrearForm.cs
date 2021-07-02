using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.DatosPage
{
    public partial class ClienteProductoCrearForm : Form
    {
        public ClienteProductoCrearForm()
        {
            InitializeComponent();
            GetClientes();
            GetAreas();
        }

        #region Events

        void GuardarButton_Click(object sender, EventArgs e)
        {
            ClienteModel cliente;
            bool saveClient = false;
            bool saveNoClient = false;
            MsgBox.Visible = false;

            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var model = new ClienteProductoModel(ProductoInternoText.Text, PrecioUnitarioText.Text, AreaCombo.Text);

            try
            {
                cliente = (ClienteModel)ClienteCombo.SelectedItem;
            }
            catch (Exception)
            {
                cliente = null;
            }

            if (cliente != null)
            {
                saveClient = GlobalConfig.Connection.ClienteProducto_Create(model, cliente);
            }
            else
            {
                saveNoClient = GlobalConfig.Connection.ClienteProducto_Create(model);
            }

            if (saveClient)
            {
                ClearForm();
                MsgBox.Text = $"Producto {model.ProductoInterno} para cliente {cliente.Nombre} guardado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else if (saveNoClient)
            {
                ClearForm();
                MsgBox.Text = $"Producto {model.ProductoInterno} guardado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = $"Error al crear producto {model.ProductoInterno}.";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void MsgBoxTimer_Tick(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBoxTimer.Stop();
        }

        #endregion

        #region Methods

        void GetClientes()
        {
            var clientes = GlobalConfig.Connection.Cliente_GetAll();

            foreach (var cliente in clientes)
            {
                ClienteCombo.Items.Add(cliente);
            }

            ClienteCombo.DisplayMember = "Nombre";
        }

        void GetAreas()
        {
            var areas = GlobalConfig.Connection.Area_GetAll();

            foreach (var area in areas)
            {
                AreaCombo.Items.Add(area);
            }

            AreaCombo.DisplayMember = "Area";
        }

        bool ValidateForm()
        {
            var output = true;

            if (ProductoInternoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del material.\n";
            }

            if (PrecioUnitarioText.Text == "$0.00")
            {
                output = false;
                MsgBox.Text += "El precio no puede ser $0.00.\n";
            }

            if (AreaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un área.\n";
            }

            return output;
        }

        void ClearForm()
        {
            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox box)
                        box.Clear();
                    else if (control is ComboBox cbox)
                    {
                        cbox.SelectedItem = null;
                    }
                    else
                        Func(control.Controls);
            }

            Func(Controls);
        }

        #endregion
    }
}
