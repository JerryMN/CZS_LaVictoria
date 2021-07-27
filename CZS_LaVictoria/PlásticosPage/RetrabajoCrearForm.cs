using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.PlásticosPage
{
    public partial class RetrabajoCrearForm : Form
    {
        double _cantidadDisponible;
        double _cantidadSalida;
        double _pesoSalida;
        MaterialModel _piezaMala = new MaterialModel();

        public RetrabajoCrearForm()
        {
            InitializeComponent();
            GetPiezasMalas();
        }

        #region Events

        void PiezaMalaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PiezaMalaCombo.SelectedIndex < 0) return;

            _piezaMala = (MaterialModel) PiezaMalaCombo.SelectedItem;
            CantidadEntradaText.Text = _piezaMala.CantidadDisponible.ToString(CultureInfo.CurrentUICulture);
        }

        void Radio_CheckedChanged(object sender, EventArgs e)
        {
            PesoText.Enabled = MolerRadio.Checked;
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            var retrabajo = new RetrabajoPlásticosModel
            {
                Fecha = (DateTime) FechaPicker.Value,
                PiezaMala = _piezaMala.Nombre,
                Piezas = _cantidadSalida
            };

            var model = new MaterialModel();
            if (CorregirRadio.Checked)
            {
                var index = _piezaMala.Nombre.IndexOf(" Malas", StringComparison.Ordinal);
                var name = _piezaMala.Nombre.Substring(0, index);
                model = new MaterialModel
                {
                    Nombre = name,
                    Área = "Plásticos",
                    Categoría = "Producto Terminado",
                    CantidadDisponible = _cantidadSalida
                };

                retrabajo.Proceso = "Corrección";
            }
            else if (MolerRadio.Checked)
            {
                model = new MaterialModel
                {
                    Nombre = "Merma Por Moler",
                    Área = "Plásticos",
                    Categoría = "Por Moler",
                    CantidadDisponible = _pesoSalida
                };

                retrabajo.Proceso = "Merma Por Moler";
                retrabajo.Peso = _pesoSalida;
            }
            else if (MermaRadio.Checked)
            {
                retrabajo.Proceso = "Merma";
            }

            var saveSuccess =
                GlobalConfig.Connection.PlasticProduction_ProcesarPiezasMalas(retrabajo, _piezaMala, model,
                    _cantidadSalida);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Proceso registrado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar proceso.";
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

        void GetPiezasMalas()
        {
            var piezas = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Piezas Malas");
            foreach (var pieza in piezas) PiezaMalaCombo.Items.Add(pieza);

            PiezaMalaCombo.DisplayMember = "Nombre";
        }

        bool ValidateForm()
        {
            var output = true;

            if (PiezaMalaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un producto malo.\n";
            }

            if (CantidadEntradaText.Text == "0" || !double.TryParse(CantidadEntradaText.Text, out _cantidadDisponible))
            {
                output = false;
                MsgBox.Text += "No hay piezas malas del producto seleccionado.\n";
            }

            if (!CorregirRadio.Checked && !MolerRadio.Checked && !MermaRadio.Checked)
            {
                output = false;
                MsgBox.Text += "Selecciona un proceso.\n";
            }

            if (CantidadSalidaText.Text == "0" || !double.TryParse(CantidadSalidaText.Text, out _cantidadSalida))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de piezas a procesar.\n";
            }

            if (_cantidadSalida > _cantidadDisponible)
            {
                output = false;
                MsgBox.Text += "La cantidad de salida no puede ser mayor a la cantidad de entrada.\n";
            }

            if (MolerRadio.Checked)
                if (PesoText.Text == "0.00" || !double.TryParse(PesoText.Text, out _pesoSalida))
                {
                    output = false;
                    MsgBox.Text += "Ingresa el peso de las bases.\n";
                }

            return output;
        }

        void ClearForm()
        {
            Tools.ClearForm(this);

            CantidadEntradaText.Text = "0";
            CantidadSalidaText.Text = "0";
        }

        #endregion
    }
}