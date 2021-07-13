﻿using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.PlásticosPage
{
    public partial class RegistrarInsertadoForm : Form
    {
        MaterialModel _baseSeleccionada = new MaterialModel();
        double _numBases;
        MaterialModel _fibraSeleccionada = new MaterialModel();
        double _cantidadFibra;
        MaterialModel _alambreSeleccionado = new MaterialModel();
        int _numRollos;
        MaterialModel _productoSeleccionado = new MaterialModel();
        int _piezasBuenas;
        int _piezasMalas;
        int _basesMalas;
        double _viruta;
        double _rebaba;

        public RegistrarInsertadoForm()
        {
            InitializeComponent();
            GetOperadores();
            GetBasesFibrasAlambres();
            GetProductos();
            FechaPicker.Culture = new CultureInfo("es-MX");
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

        void TipoAlambreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _alambreSeleccionado = (MaterialModel) TipoAlambreCombo.SelectedItem;
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

            if (_numRollos > _alambreSeleccionado.CantidadDisponible)
            {
                MsgBox.Text = $"No hay suficientes rollos de alambre. Hay {_baseSeleccionada.CantidadDisponible}.";
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
            var orden = new ProducciónPlásticosModel();
            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            orden.Fecha = (DateTime)FechaPicker.Value;
            orden.Proceso = "Insertado";
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = int.Parse(MaquinaText.Text);
            orden.Operador = OperadorCombo.Text;
            orden.MaterialEntra = _baseSeleccionada.Nombre;
            orden.CantidadEntra = double.Parse(CantidadBaseText.Text);
            orden.FibraEntra = _fibraSeleccionada.Nombre;
            orden.CantidadFibraEntra = double.Parse(CantidadFibraText.Text);
            orden.PiezasBuenas = _piezasBuenas;
            orden.PiezasMalas = _piezasMalas;
            orden.BasesMalas = _basesMalas;
            orden.Viruta = _viruta;
            orden.Rebaba = _rebaba;
            orden.TipoAlambre = _alambreSeleccionado.Nombre;
            orden.RollosAlambre = _numRollos;

            if (_productoSeleccionado == null || _productoSeleccionado.Id == 0)
            {
                _productoSeleccionado = new MaterialModel(SalidaCombo.Text, "Plásticos", "Producto Terminado", _piezasBuenas);
            }
            else
            {
                _productoSeleccionado.CantidadDisponible += _piezasBuenas;
            }

            var saveSuccess = GlobalConfig.Connection.PlasticProduction_CreateInsertado(orden, _baseSeleccionada,
                _fibraSeleccionada, _alambreSeleccionado, _productoSeleccionado);

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

        void GetOperadores()
        {
            var operadores = GlobalConfig.Connection.Operador_GetByArea("Plásticos");
            foreach (var operador in operadores)
            {
                OperadorCombo.Items.Add(operador);
            }

            OperadorCombo.DisplayMember = "Nombre";
        }

        void GetBasesFibrasAlambres()
        {
            BaseCombo.Items.Clear();
            FibraCombo.Items.Clear();
            TipoAlambreCombo.Items.Clear();

            var bases = GlobalConfig.Connection.Material_GetByCat("Bases");
            foreach (var @base in bases)
            {
                BaseCombo.Items.Add(@base);
            }

            var fibras = GlobalConfig.Connection.Material_GetByCat("Extruído");
            foreach (var fibra in fibras)
            {
                FibraCombo.Items.Add(fibra);
            }

            var alambres = GlobalConfig.Connection.Material_GetByCat("Alambre");
            foreach (var alambre in alambres)
            {
                TipoAlambreCombo.Items.Add(alambre);
            }

            BaseCombo.DisplayMember = "Nombre";
            FibraCombo.DisplayMember = "Nombre";
            TipoAlambreCombo.DisplayMember = "Nombre";
        }

        void GetProductos()
        {
            SalidaCombo.Items.Clear();

            var productos = GlobalConfig.Connection.Material_GetByCat("Producto Terminado");

            foreach (var producto in productos)
            {
                SalidaCombo.Items.Add(producto);
            }

            SalidaCombo.DisplayMember = "Nombre";
        }

        bool ValidateForm()
        {
            var output = true;
            MsgBox.Text = "";
            MsgBox.IconColor = Color.DarkRed;

            if (OperadorCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un operador.\n";
            }

            if (MaquinaText.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una máquina.\n";
            }

            if (TurnoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un turno.\n";
            }

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

            if (TipoAlambreCombo.Text != "")
            {
                if (CantidadRollosText.Text == "" || CantidadRollosText.Text == "0" || !int.TryParse(CantidadRollosText.Text, out _numRollos))
                {
                    output = false;
                    MsgBox.Text += "Ingresa la cantidad de rollos.\n";
                }
            }

            if (SalidaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una producto.\n";
            }

            if (PiezasBuenasText.Text == "" || PiezasBuenasText.Text == "0" || !int.TryParse(PiezasBuenasText.Text, out _piezasBuenas))
            {
                output = false;
                MsgBox.Text += "Ingresa el número de piezas buenas.\n";
            }

            if (PiezasMalasText.Text == "" || !int.TryParse(PiezasMalasText.Text, out _piezasMalas))
            {
                output = false;
                MsgBox.Text += "Ingresa el número de piezas malas.\n";
            }

            if (BasesMalasText.Text == "" ||  !int.TryParse(BasesMalasText.Text, out _basesMalas))
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
