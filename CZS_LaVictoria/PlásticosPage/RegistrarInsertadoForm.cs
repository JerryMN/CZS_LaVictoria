using System;
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
        MaterialModel _alambreSeleccionado = new MaterialModel();
        MaterialModel _baseSeleccionada = new MaterialModel();
        MaterialModel _cajaSeleccionada = new MaterialModel();
        double _cantidadFibra;
        MaterialModel _fibraSeleccionada = new MaterialModel();
        MaterialModel _materialSalida = new MaterialModel();
        double _mermaBases;
        double _mermaFibra;
        double _numBases;
        int _numCajas;
        int _numRollos;
        int _piezasBuenas;
        int _piezasMalas;

        public RegistrarInsertadoForm()
        {
            InitializeComponent();
            GetOperadores();
            FillComboBoxes();
            GetProductos();
            FechaPicker.Culture = new CultureInfo("es-MX");
            if (GlobalConfig.Connection.CZS_GetLicencia()) return;
            MessageBox.Show(
                "No se puede verificar la licencia. Verifica el estatus de la misma y verifica tu conexión a internet.",
                "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        #region Events

        void BaseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _baseSeleccionada = (MaterialModel) BaseCombo.SelectedItem;
        }

        void FibraCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _fibraSeleccionada = (MaterialModel) FibraCombo.SelectedItem;
        }

        void TipoAlambreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _alambreSeleccionado = (MaterialModel) TipoAlambreCombo.SelectedItem;
        }

        void TipoCajaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cajaSeleccionada = (MaterialModel) TipoCajaCombo.SelectedItem;
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

            if (_numBases > _baseSeleccionada.CantidadDisponible)
            {
                MsgBox.Text = $"La base \"{_baseSeleccionada.Nombre}\" no se puede seleccionar. " +
                              $"Cantidad disponible: {_baseSeleccionada.CantidadDisponible:N}.\n";
                MsgBox.Visible = true;
                return;
            }

            if (_cantidadFibra > _fibraSeleccionada.CantidadDisponible)
            {
                MsgBox.Text = $"La fibra \"{_fibraSeleccionada.Nombre}\" no se puede seleccionar. " +
                              $"Cantidad disponible: {_fibraSeleccionada.CantidadDisponible:N} kg.\n";
                MsgBox.Visible = true;
                return;
            }

            if (_numRollos > _alambreSeleccionado.CantidadDisponible)
            {
                MsgBox.Text = $"El alambre \"{_alambreSeleccionado.Nombre}\" no se puede seleccionar. " +
                              $"Cantidad disponible: {_alambreSeleccionado.CantidadDisponible:##,###} rollo(s).\n";
                MsgBox.Visible = true;
                return;
            }

            if (_numCajas > _cajaSeleccionada.CantidadDisponible)
            {
                MsgBox.Text = $"La caja \"{_cajaSeleccionada.Nombre}\" no se puede seleccionar. " +
                              $"Cantidad disponible: {_cajaSeleccionada.CantidadDisponible:##,###}.\n";
                MsgBox.Visible = true;
                return;
            }

            if (_piezasBuenas + _piezasMalas > _numBases)
            {
                MsgBox.Text = "Las bases que salen no pueden ser más que las bases que entran.\n";
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
            if (SalidaCombo.Text != _materialSalida.Nombre) _materialSalida = new MaterialModel();

            var orden = new ProducciónPlásticosModel();
            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            orden.Fecha = (DateTime) FechaPicker.Value;
            orden.Proceso = "Insertado";
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = MáquinaCombo.Text;
            orden.Operador = OperadorCombo.Text;
            orden.MaterialEntra = _baseSeleccionada.Nombre;
            orden.CantidadEntra = _numBases;
            orden.MaterialSale = SalidaCombo.Text;
            orden.FibraEntra = _fibraSeleccionada.Nombre;
            orden.CantidadFibraEntra = _cantidadFibra;
            orden.PiezasBuenas = _piezasBuenas;
            orden.PiezasMalas = _piezasMalas;
            orden.MermaBases = _mermaBases;
            orden.MermaFibra = _mermaFibra;
            orden.TipoAlambre = _alambreSeleccionado.Nombre;
            orden.RollosAlambre = _numRollos;
            orden.TipoCaja = _cajaSeleccionada.Nombre;
            orden.CantidadCajas = _numCajas;

            var saveSuccess = GlobalConfig.Connection.PlasticProduction_CreateInsertado(orden, _baseSeleccionada,
                _fibraSeleccionada, _alambreSeleccionado, _cajaSeleccionada, _materialSalida);

            if (saveSuccess)
            {
                ClearForm();
                FillComboBoxes();
                GetProductos();
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
            foreach (var operador in operadores) OperadorCombo.Items.Add(operador);

            OperadorCombo.DisplayMember = "Nombre";
        }

        void FillComboBoxes()
        {
            MáquinaCombo.Items.Clear();
            BaseCombo.Items.Clear();
            FibraCombo.Items.Clear();
            TipoAlambreCombo.Items.Clear();
            TipoCajaCombo.Items.Clear();

            var máquinas = GlobalConfig.Connection.PlasticProduction_GetMáquinas();
            foreach (var máquina in máquinas) MáquinaCombo.Items.Add(máquina);

            var bases = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Bases");
            foreach (var @base in bases) BaseCombo.Items.Add(@base);

            var fibras = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Cortado");
            foreach (var fibra in fibras) FibraCombo.Items.Add(fibra);

            var alambres = GlobalConfig.Connection.Material_GetByCat("Alambre");
            foreach (var alambre in alambres) TipoAlambreCombo.Items.Add(alambre);

            var cajas = GlobalConfig.Connection.Material_GetByCat("Caja");
            foreach (var caja in cajas) TipoCajaCombo.Items.Add(caja);

            BaseCombo.DisplayMember = "Nombre";
            FibraCombo.DisplayMember = "Nombre";
            TipoAlambreCombo.DisplayMember = "Nombre";
            TipoCajaCombo.DisplayMember = "Nombre";
        }

        void GetProductos()
        {
            SalidaCombo.Items.Clear();

            var productos = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Producto Terminado");

            foreach (var producto in productos) SalidaCombo.Items.Add(producto);

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

            if (BaseCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una base.\n";
            }

            if (CantidadBaseText.Text == "" || CantidadBaseText.Text == "0" ||
                !double.TryParse(CantidadBaseText.Text.Replace(",", ""), out _numBases))
            {
                output = false;
                MsgBox.Text += "Ingresa el número de bases.\n";
            }

            if (FibraCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una fibra.\n";
            }

            if (CantidadFibraText.Text == "" || CantidadFibraText.Text == "0.00" ||
                !double.TryParse(CantidadFibraText.Text.Replace(",", ""), out _cantidadFibra))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de fibra.\n";
            }

            if (TipoAlambreCombo.Text != "")
                if (CantidadRollosText.Text == "" || CantidadRollosText.Text == "0" ||
                    !int.TryParse(CantidadRollosText.Text.Replace(",", ""), out _numRollos))
                {
                    output = false;
                    MsgBox.Text += "Ingresa la cantidad de rollos.\n";
                }

            if (TipoCajaCombo.Text != "")
                if (CantidadCajasText.Text == "" || CantidadCajasText.Text == "0" ||
                    !int.TryParse(CantidadCajasText.Text.Replace(",", ""), out _numCajas))
                {
                    output = false;
                    MsgBox.Text += "Ingresa la cantidad de cajas.\n";
                }

            if (SalidaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una producto.\n";
            }

            if (PiezasBuenasText.Text == "" || PiezasBuenasText.Text == "0" ||
                !int.TryParse(PiezasBuenasText.Text.Replace(",", ""), out _piezasBuenas))
            {
                output = false;
                MsgBox.Text += "Ingresa el número de piezas buenas.\n";
            }

            if (PiezasMalasText.Text == "" || !int.TryParse(PiezasMalasText.Text.Replace(",", ""), out _piezasMalas))
            {
                output = false;
                MsgBox.Text += "Ingresa el número de piezas malas.\n";
            }

            if (MermaBasesText.Text == "" || !double.TryParse(MermaBasesText.Text.Replace(",", ""), out _mermaBases))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de merma de bases.\n";
            }

            if (MermaFibraText.Text == "" || !double.TryParse(MermaFibraText.Text.Replace(",", ""), out _mermaFibra))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de merma de fibra.\n";
            }

            return output;
        }

        void ClearForm()
        {
            Tools.ClearForm(this);

            CantidadBaseText.Text = "0";
            CantidadFibraText.Text = "0.00";
            CantidadRollosText.Text = "0";
            CantidadCajasText.Text = "0";
            PiezasBuenasText.Text = "0";
            PiezasMalasText.Text = "0";
            MermaBasesText.Text = "0.00";
            MermaFibraText.Text = "0.00";
        }

        #endregion
    }
}