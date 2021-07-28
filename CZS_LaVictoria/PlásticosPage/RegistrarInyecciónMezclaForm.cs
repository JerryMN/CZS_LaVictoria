using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.PlásticosPage
{
    public partial class RegistrarInyecciónMezclaForm : Form
    {
        double _kgEntrada;
        double _kgSalida;
        MaterialModel _materialEntrada = new MaterialModel();
        MaterialModel _materialSalida = new MaterialModel();
        double _mermaMoler;
        MezclaModel _mezclaEntrada = new MezclaModel();
        double _pesoProm;
        int _piezasBuenas;

        public RegistrarInyecciónMezclaForm()
        {
            InitializeComponent();
            GetOperadores();
            GetMáquinas();
            GetBases();
            FechaPicker.Culture = new CultureInfo("es-MX");
            if (GlobalConfig.Connection.CZS_GetLicencia()) return;
            MessageBox.Show(
                "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        #region Events

        void RadioButton_Changed(object sender, EventArgs e)
        {
            if (MezclaRadio.Checked)
            {
                GetMezclas();
                EntradaLabel.Text = "Mezcla*";
            }
            else
            {
                GetMateriales();
                EntradaLabel.Text = "Material*";
            }
        }

        void EntradaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MezclaRadio.Checked)
                _mezclaEntrada = (MezclaModel) EntradaCombo.SelectedItem;
            else
                _materialEntrada = (MaterialModel) EntradaCombo.SelectedItem;
        }

        void SalidaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _materialSalida = (MaterialModel) SalidaCombo.SelectedItem;
        }

        void InputOutputChanged(object sender, EventArgs e)
        {
            GuardarButton.Enabled = false;
            CalcularButton.Enabled = true;
        }

        void CalcularButton_Click(object sender, EventArgs e)
        {
            MsgBox.IconColor = Color.DarkRed;
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            if (MezclaRadio.Checked)
            {
                for (var i = 0; i < _mezclaEntrada.Materiales.Count; i++)
                {
                    var material = _mezclaEntrada.Materiales[i];
                    var cantidadRequerida = _kgEntrada * _mezclaEntrada.Cantidades[i] / _mezclaEntrada.CantidadMezcla;
                    if (cantidadRequerida > material.CantidadDisponible)
                    {
                        MsgBox.Text =
                            $"La mezcla \"{EntradaCombo.Text}\" no se puede seleccionar. " +
                            $"Necesita más material \"{material.Nombre}\".";
                        MsgBox.Visible = true;
                        GuardarButton.Enabled = false;
                        return;
                    }
                }
            }
            else
            {
                if (_kgEntrada > _materialEntrada.CantidadDisponible)
                {
                    MsgBox.Text =
                        $"El material \"{EntradaCombo.Text}\" no se puede seleccionar. " +
                        $"Cantidad disponible: {_materialEntrada.CantidadDisponible:N} kg.";
                    MsgBox.Visible = true;
                    GuardarButton.Enabled = false;
                    return;
                }
            }

            _kgSalida = _piezasBuenas * _pesoProm / 1000;
            var mermaFinal = _kgEntrada - _kgSalida - _mermaMoler;
            if (mermaFinal < 0)
            {
                MsgBox.Text = "Revisa los valores de entrada o de salida.";
                MsgBox.Visible = true;
                MermaRealText.Text = "0.00";
                GuardarButton.Enabled = false;
                return;
            }

            MermaRealText.Text = mermaFinal.ToString(CultureInfo.InvariantCulture);
            MsgBox.Text = "Cantidades válidas.";
            MsgBox.IconColor = Color.DarkGreen;
            MsgBox.Visible = true;
            MsgBoxTimer.Start();
            GuardarButton.Enabled = true;
            CalcularButton.Enabled = false;
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            if (SalidaCombo.Text != _materialSalida.Nombre) _materialSalida = new MaterialModel();

            bool saveSuccess;
            var orden = new ProducciónPlásticosModel();
            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            orden.Fecha = (DateTime) FechaPicker.Value;
            orden.Proceso = "Inyección";
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = MáquinaCombo.Text;
            orden.Operador = OperadorCombo.Text;
            orden.CantidadEntra = _kgEntrada;
            orden.MaterialSale = SalidaCombo.Text;
            orden.CantidadSale = _piezasBuenas;
            orden.PesoPromedio = _pesoProm;
            orden.MermaMoler = _mermaMoler;
            orden.MermaFinal = double.Parse(MermaRealText.Text);

            if (MezclaRadio.Checked)
            {
                orden.MaterialEntra = _mezclaEntrada.Nombre;
                saveSuccess =
                    GlobalConfig.Connection.PlasticProduction_CreateInyección(orden, _mezclaEntrada, _materialSalida);
            }
            else
            {
                orden.MaterialEntra = _materialEntrada.Nombre;
                saveSuccess =
                    GlobalConfig.Connection.PlasticProduction_CreateInyección(orden, _materialEntrada, _materialSalida);
            }

            if (saveSuccess)
            {
                ClearForm();
                GetMáquinas();
                GetMezclas();
                GetMateriales();
                GetBases();
                MsgBox.Text = "Inyección registrada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar inyección.";
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
            foreach (var operador in operadores) OperadorCombo.Items.Add(operador);

            OperadorCombo.DisplayMember = "Nombre";
        }

        void GetMáquinas()
        {
            MáquinaCombo.Items.Clear();

            var máquinas = GlobalConfig.Connection.PlasticProduction_GetMáquinas();
            foreach (var máquina in máquinas) MáquinaCombo.Items.Add(máquina);
        }

        void GetMezclas()
        {
            EntradaCombo.Items.Clear();

            var mezclas = GlobalConfig.Connection.Mezcla_GetAll();
            foreach (var mezcla in mezclas) EntradaCombo.Items.Add(mezcla);

            EntradaCombo.DisplayMember = "Nombre";
        }

        void GetMateriales()
        {
            EntradaCombo.Items.Clear();

            var materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Molido");
            foreach (var material in materiales) EntradaCombo.Items.Add(material);

            EntradaCombo.DisplayMember = "Nombre";
        }

        void GetBases()
        {
            SalidaCombo.Items.Clear();

            var materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Bases");
            foreach (var material in materiales) SalidaCombo.Items.Add(material);

            SalidaCombo.DisplayMember = "Nombre";
        }

        bool ValidateForm()
        {
            var output = true;

            if (OperadorCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un operador.\n";
            }

            if (MáquinaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una máquina.\n";
            }

            if (TurnoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un turno.\n";
            }

            if (EntradaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un material o mezcla.\n";
            }

            if (CantidadEntradaText.Text == "" || CantidadEntradaText.Text == "0.00" ||
                !double.TryParse(CantidadEntradaText.Text.Replace(",", ""), out _kgEntrada))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de material o mezcla.\n";
            }

            if (SalidaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un material de salida.\n";
            }

            if (CantidadSalidaText.Text == "" || CantidadSalidaText.Text == "0" ||
                !int.TryParse(CantidadSalidaText.Text.Replace(",", ""), out _piezasBuenas))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de bases.\n";
            }

            if (PesoPromText.Text == "" || PesoPromText.Text == "0.00" ||
                !double.TryParse(PesoPromText.Text.Replace(",", ""), out _pesoProm))
            {
                output = false;
                MsgBox.Text += "Ingresa el peso promedio de una base.\n";
            }

            if (MermaMolerText.Text == "" || !double.TryParse(MermaMolerText.Text.Replace(",", ""), out _mermaMoler))
            {
                output = false;
                MsgBox.Text += "Ingresa la merma que se puede moler.\n";
            }

            return output;
        }

        void ClearForm()
        {
            Tools.ClearForm(this);

            TurnoText.Text = "1";
            CantidadEntradaText.Text = "0";
            CantidadSalidaText.Text = "0";
            PesoPromText.Text = "0.00";
            MermaMolerText.Text = "0.00";
            MermaRealText.Text = "0.00";
        }

        #endregion
    }
}