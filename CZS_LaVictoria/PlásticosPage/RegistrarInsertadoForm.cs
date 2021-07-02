using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.PlásticosPage
{
    public partial class RegistrarInsertadoForm : Form
    {
        MaterialModel _baseSeleccionada = new MaterialModel();
        MaterialModel _fibraSeleccionada = new MaterialModel();
        MaterialModel _productoSeleccionado = new MaterialModel();
        double _numBases;
        double _cantidadFibra;
        double _numRollos;
        double _piezasBuenas;
        double _piezasMalas;
        double _basesMalas;
        double _viruta;
        double _rebaba;

        public RegistrarInsertadoForm()
        {
            InitializeComponent();
            GetBasesProductosFibras();
        }

        #region Events

        void BaseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _baseSeleccionada = (MaterialModel)BaseCombo.SelectedItem;
        }

        void FibraCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _fibraSeleccionada = (MaterialModel)FibraCombo.SelectedItem;
        }

        void SalidaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _productoSeleccionado = (MaterialModel)SalidaCombo.SelectedItem;
        }

        void InputOutputChanged(object sender, EventArgs e)
        {
            GuardarButton.Enabled = false;
            CalcularButton.Enabled = true;
        }

        void CalcularButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            if (_numBases > _baseSeleccionada.CantidadDisponible)
            {
                MsgBox.Text = $"No hay suficientes bases. Hay {_baseSeleccionada.CantidadDisponible}.";
                MsgBox.Visible = true;
                return;
            }

            if (_cantidadFibra > _fibraSeleccionada.CantidadDisponible)
            {
                MsgBox.Text = $"No hay suficiente fibra. Hay {_baseSeleccionada.CantidadDisponible} kg.";
                MsgBox.Visible = true;
                return;
            }

            if (_piezasBuenas + _piezasMalas + _basesMalas > _numBases)
            {
                MsgBox.Text = "No pueden salir más bases de las que entraron.";
                MsgBox.Visible = true;
                return;
            }


            MsgBox.Text = "Cantidades válidas.";
            MsgBox.IconColor = Color.DarkGreen;
            MsgBox.Visible = true;
            MsgBoxTimer.Start();
            GuardarButton.Enabled = true;
            CalcularButton.Enabled = false;
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            // TODO - Update cantidades de bases, fibra y rollos.
            // TODO - Update cantidad de piezas buenas.
            // TODO - Update cantidad de por moler.
            var saveSuccess = true;

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Insertado registrado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar insertado.";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void MsgBoxTimer_Tick(object sender, EventArgs e)
        {
            MsgBoxTimer.Stop();
            MsgBox.Visible = false;
        }

        #endregion

        #region Methods

        void GetBasesProductosFibras()
        {
            BaseCombo.Items.Clear();
            SalidaCombo.Items.Clear();

            // TODO - "SELECT * FROM Inventario WHERE Categoría = 'Bases'
            var bases = new List<MaterialModel>();
            // TODO - "SELECT * FROM Inventario WHERE Categoría = 'Producto Terminado'
            var productos = new List<MaterialModel>();
            // TODO - "SELECT * FROM Inventario WHERE Categoría = 'Fibra'
            var fibras = new List<MaterialModel>();

            foreach (var baseP in bases)
            {
                BaseCombo.Items.Add(baseP);
            }

            foreach (var fibra in fibras)
            {
                FibraCombo.Items.Add(fibra);
            }

            foreach (var producto in productos)
            {
                SalidaCombo.Items.Add(producto);
            }

            BaseCombo.DisplayMember = "Nombre";
            FibraCombo.DisplayMember = "Nombre";
            SalidaCombo.DisplayMember = "Nombre";
        }

        bool ValidateForm()
        {
            var output = true;
            MsgBox.Text = "";
            MsgBox.IconColor = Color.DarkRed;

            if (BaseCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una base.\n";
            }

            if (CantidadBaseText.Text == "" || CantidadBaseText.Text == "0" || !double.TryParse(CantidadBaseText.Text, out _numBases))
            {
                output = false;
                MsgBox.Text += "Ingresa el número de bases.\n";
            }

            if (FibraCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una fibra.\n";
            }

            if (CantidadFibraText.Text == "" || CantidadFibraText.Text == "0.00" || !double.TryParse(CantidadFibraText.Text, out _cantidadFibra))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de fibra.\n";
            }

            if (CantidadRollosText.Text != "" || CantidadRollosText.Text != "0")
            {
                double.TryParse(CantidadRollosText.Text, out _numRollos);
            }

            if (SalidaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una producto.\n";
            }

            if (PiezasBuenasText.Text == "" || PiezasBuenasText.Text == "0" || !double.TryParse(PiezasBuenasText.Text, out _piezasBuenas))
            {
                output = false;
                MsgBox.Text += "Ingresa el número de piezas buenas.\n";
            }

            if (PiezasMalasText.Text == "" || !double.TryParse(PiezasMalasText.Text, out _piezasMalas))
            {
                output = false;
                MsgBox.Text += "Ingresa el número de piezas malas.\n";
            }

            if (BasesMalasText.Text == "" ||  !double.TryParse(BasesMalasText.Text, out _basesMalas))
            {
                output = false;
                MsgBox.Text += "Ingresa el número de bases malas.\n";
            }

            if (VirutaText.Text == "" || !double.TryParse(VirutaText.Text, out _viruta))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de viruta.\n";
            }

            if (RebabaText.Text == "" || !double.TryParse(RebabaText.Text, out _rebaba))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de rebaba.\n";
            }

            return output;
        }

        void ClearForm()
        {
            CantidadBaseText.Text = "0";
            CantidadFibraText.Text = "0.00";
            CantidadRollosText.Text = "0";
            PiezasBuenasText.Text = "0";
            PiezasMalasText.Text = "0";
            BasesMalasText.Text = "0";
            VirutaText.Text = "0.00";
            RebabaText.Text = "0.00";

            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox box)
                        box.Clear();
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.Text = "";
                        comboBox.SelectedItem = null;
                    }
                    else
                        Func(control.Controls);
            }

            Func(Controls);
        }

        #endregion
    }
}
