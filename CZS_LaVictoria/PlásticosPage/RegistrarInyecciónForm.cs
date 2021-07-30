using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

// ReSharper disable UseObjectOrCollectionInitializer

namespace CZS_LaVictoria.PlásticosPage
{
    public partial class RegistrarInyecciónForm : Form
    {
        readonly MezclaModel _mezclaEntrada = new MezclaModel();
        double _kgEntrada;
        double _kgSalida;
        MaterialModel _materialSalida = new MaterialModel();
        double _mermaMoler;
        static string _mezclaNombre;
        double _pesoProm;
        int _piezasBuenas;

        public RegistrarInyecciónForm()
        {
            InitializeComponent();
            GetOperadores();
            GetMáquinas();
            GetMateriales();
            GetBases();
            FechaPicker.Culture = new CultureInfo("es-MX");
            MaterialesListBox.DisplayMember = "Nombre";
            if (GlobalConfig.Connection.CZS_GetLicencia()) return;
            MessageBox.Show(
                "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        #region Events

        void AgregarButton_Click(object sender, EventArgs e)
        {
            MsgBox.IconColor = Color.DarkRed;
            MsgBox.Visible = false;
            MsgBox.Text = "";

            if (!ValidateMix())
            {
                MsgBox.Visible = true;
                return;
            }

            var material = (MaterialModel) MaterialCombo.SelectedItem;
            double.TryParse(CantidadText.Text.Replace(",", ""), out var cantidad);

            if (cantidad > material.CantidadDisponible)
            {
                MsgBox.Text =
                    $"El material \"{MaterialCombo.Text}\" no se puede seleccionar. " +
                    $"Cantidad disponible: {material.CantidadDisponible:N} kg.";
                MsgBox.Visible = true;
                GuardarButton.Enabled = false;
                return;
            }

            MaterialCombo.Items.Remove(material);
            MaterialesListBox.Items.Add(material);
            MaterialesListBox.SelectedItem = null;
            CantidadesListBox.Items.Add(cantidad);
            CantidadText.Text = "0.00";

            InputOutputChanged(sender, e);
        }

        void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MaterialesListBox.SelectedItem == null)
            {
                MsgBox.Text = "Selecciona un material a borrar.";
                MsgBox.Visible = true;
                return;
            }

            MaterialCombo.Items.Add(MaterialesListBox.SelectedItem);
            MaterialCombo.Sorted = true;
            var index = MaterialesListBox.SelectedIndex;
            MaterialesListBox.Items.RemoveAt(index);
            CantidadesListBox.Items.RemoveAt(index);

            InputOutputChanged(sender, e);
        }

        void SalidaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _materialSalida = (MaterialModel) SalidaCombo.SelectedItem;
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

            _mezclaEntrada.Materiales = MaterialesListBox.Items.Cast<MaterialModel>().ToList();
            _mezclaEntrada.Cantidades = CantidadesListBox.Items.Cast<double>().ToList();
            _mezclaEntrada.CantidadMezcla =
                CantidadesListBox.Items.Cast<object>().Sum(item => double.Parse(item.ToString()));
            for (var i = 0; i < _mezclaEntrada.Materiales.Count; i++)
            {
                var material = _mezclaEntrada.Materiales[i];
                var cantidadRequerida = _kgEntrada * _mezclaEntrada.Cantidades[i] / _mezclaEntrada.CantidadMezcla;
                if (cantidadRequerida > material.CantidadDisponible)
                {
                    MsgBox.Text =
                        "La mezcla no se puede seleccionar. " +
                        $"Necesita más material \"{material.Nombre}\".";
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

            MermaRealText.Text = mermaFinal.ToString(CultureInfo.CurrentUICulture);
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
            _mezclaNombre = "";
            
            var orden = new ProducciónPlásticosModel();
            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            orden.Fecha = (DateTime) FechaPicker.Value;
            orden.Proceso = "Inyección";
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = MáquinaCombo.Text;
            orden.Operador = OperadorCombo.Text;
            orden.MaterialEntra = "Mezcla sin guardar";
            orden.CantidadEntra = _kgEntrada;
            orden.MaterialSale = SalidaCombo.Text;
            orden.CantidadSale = _piezasBuenas;
            orden.PesoPromedio = _pesoProm;
            orden.MermaMoler = _mermaMoler;
            orden.MermaFinal = double.Parse(MermaRealText.Text);

            // Dar opción de guardar la lista y cantidades de materiales seleccionados como una nueva mezcla.
            if (MessageBox.Show("Deseas guardar esta mezcla para futuros registros?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ShowInputDialog(ref _mezclaNombre);
                if (_mezclaNombre == "") return;
                _mezclaEntrada.Nombre = _mezclaNombre;
                orden.MaterialEntra = _mezclaNombre;
                var saveMezclaSuccess = GlobalConfig.Connection.Mezcla_Create(_mezclaEntrada);
                if (saveMezclaSuccess)
                {
                    MsgBox.Text = "Mezcla registrada con éxito.\n";
                    MsgBox.IconColor = Color.DarkGreen;
                }
                else
                {
                    MsgBox.Text = "Error al registrar mezcla.\n";
                    MsgBox.IconColor = Color.DarkRed;
                }

                MsgBox.Visible = true;
            }

            var saveSuccess =
                GlobalConfig.Connection.PlasticProduction_CreateInyección(orden, _mezclaEntrada, _materialSalida);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text += "Inyección registrada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text += "Error al registrar inyección o mezcla.";
                MsgBox.IconColor = Color.DarkRed;
            }

            MsgBox.Visible = true;
            MsgBoxTimer.Start();
        }

        void InputOutputChanged(object sender, EventArgs e)
        {
            GuardarButton.Enabled = false;
            CalcularButton.Enabled = true;
        }

        void MsgBoxTimer_Tick(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            MsgBoxTimer.Stop();
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

        void GetMateriales()
        {
            MaterialCombo.Items.Clear();

            var materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Molido");
            foreach (var material in materiales) MaterialCombo.Items.Add(material);

            MaterialCombo.DisplayMember = "Nombre";
        }

        void GetBases()
        {
            SalidaCombo.Items.Clear();

            var materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Bases");
            foreach (var material in materiales) SalidaCombo.Items.Add(material);

            SalidaCombo.DisplayMember = "Nombre";
        }

        bool ValidateMix()
        {
            var output = true;

            if (MaterialCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un material.\n";
            }

            if (CantidadText.Text == "" || CantidadText.Text == "0.00" ||
                !double.TryParse(CantidadText.Text.Replace(",", ""), out _))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad.\n";
            }

            return output;
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

            if (MaterialesListBox.Items.Count <= 1)
            {
                output = false;
                MsgBox.Text += "Ingresa al menos dos materiales a la mezcla. \n";
            }

            if (CantidadEntradaText.Text == "" || CantidadEntradaText.Text == "0.00" ||
                !double.TryParse(CantidadEntradaText.Text.Replace(",", ""), out _kgEntrada))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad total de mezcla.\n";
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

        static void ShowInputDialog(ref string input)
        {
            var size = new Size(300, 70);
            var inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Nombre de la mezcla";
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;

            var textBox = new TextBox();
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Location = new Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            var okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            var cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancelar";
            cancelButton.Location = new Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;
            inputBox.StartPosition = FormStartPosition.CenterScreen;

            var result = inputBox.ShowDialog();
            if (result == DialogResult.Cancel) return;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Ingresa un nombre!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowInputDialog(ref _mezclaNombre);
                return;
            }
            input = textBox.Text;
        }

        void ClearForm()
        {
            Tools.ClearForm(this);

            TurnoText.Text = "1";
            CantidadEntradaText.Text = "0.00";
            CantidadSalidaText.Text = "0.00";
            PesoPromText.Text = "0.00";
            MermaMolerText.Text = "0";
            MermaRealText.Text = "0";
        }

        #endregion
    }
}