using CZS_LaVictoria_Library;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CZS_LaVictoria_Library.Models;
using System.Diagnostics;
using System.Collections;

namespace CZS_LaVictoria.TrapeadoresPage
{
    public partial class RegistrarTrapeadoresForm : Form
    {
        MaterialModel _selectedBastón = new MaterialModel();
        MaterialModel _selectedAlambre = new MaterialModel();
        MaterialModel _selectedBolsa = new MaterialModel();
        MaterialModel _selectedMecha = new MaterialModel();
        MaterialModel _selectedEtiqueta = new MaterialModel();
        KitModel _selectedKit = new KitModel();
        double _cantidadBastón;
        double _cantidadAlambre;
        double _cantidadBolsa;
        double _cantidadMecha;
        double _cantidadEtiqueta;
        int _cantidadKit;


        public RegistrarTrapeadoresForm()
        {
            InitializeComponent();
            GetOperadores();
            FillComboBoxes();
            FechaPicker.Culture = new CultureInfo("es-MX");
        }

        #region Events

        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.IconColor = Color.DarkRed;
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            _selectedBastón = (MaterialModel) BastónCombo.SelectedItem;
            _selectedAlambre = (MaterialModel) AlambreCombo.SelectedItem;
            _selectedBolsa = (MaterialModel) BolsaCombo.SelectedItem;
            _selectedMecha = (MaterialModel) MechaCombo.SelectedItem;
            _selectedEtiqueta = (MaterialModel) EtiquetaCombo.SelectedItem;
            _selectedKit = (KitModel) SalidaCombo.SelectedItem;

            var orden = new ProducciónTrapeadoresModel();
            Debug.Assert(FechaPicker.Value != null, "FechaPicker.Value != null");
            orden.Fecha = (DateTime)FechaPicker.Value;
            orden.Turno = int.Parse(TurnoText.Text);
            orden.Máquina = int.Parse(MaquinaText.Text);
            orden.Operador = OperadorCombo.Text;
            orden.Bastón = _selectedBastón.Nombre;
            orden.CantidadBastón = _cantidadBastón;
            orden.Alambre = _selectedAlambre.Nombre;
            orden.CantidadAlambre = _cantidadAlambre;
            orden.Bolsa = _selectedBolsa.Nombre;
            orden.CantidadBolsa = _cantidadBolsa;
            orden.Mecha = _selectedMecha.Nombre;
            orden.CantidadMecha = _cantidadMecha;
            orden.Etiqueta = _selectedEtiqueta.Nombre;
            orden.CantidadEtiqueta = _cantidadEtiqueta;
            orden.Kit = _selectedKit.Nombre;
            orden.CantidadKit = _cantidadKit;

            var saveSuccess = GlobalConfig.Connection.MopProduction_Create(orden, _selectedBastón, _selectedAlambre,
                _selectedBolsa, _selectedMecha, _selectedEtiqueta, _selectedKit);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Cortado registrado con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar cortado.";
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

        void GetOperadores()
        {
            var operadores = GlobalConfig.Connection.Operador_GetByArea("Trapeadores");
            foreach (var operador in operadores)
            {
                OperadorCombo.Items.Add(operador);
            }

            OperadorCombo.DisplayMember = "Nombre";
        }

        void FillComboBoxes()
        {
            BastónCombo.Items.Clear(); 
            AlambreCombo.Items.Clear();
            BolsaCombo.Items.Clear();
            MechaCombo.Items.Clear();
            EtiquetaCombo.Items.Clear();

            BastónCombo.DisplayMember = "Nombre";
            AlambreCombo.DisplayMember = "Nombre";
            BolsaCombo.DisplayMember = "Nombre";
            MechaCombo.DisplayMember = "Nombre";
            EtiquetaCombo.DisplayMember = "Nombre";

            var bastones = GlobalConfig.Connection.Material_GetByAreaCat("Trapeadores", "Bastón");
            foreach (var bastón in bastones)
            {
                BastónCombo.Items.Add(bastón);
            }


            var alambres = GlobalConfig.Connection.Material_GetByCat("Alambre");
            foreach (var alambre in alambres)
            {
                BastónCombo.Items.Add(alambre);
            }

            var bolsas = GlobalConfig.Connection.Material_GetByAreaCat("Trapeadores", "Bolsa");
            foreach (var bolsa in bolsas)
            {
                BastónCombo.Items.Add(bolsa);
            }

            var mechas = GlobalConfig.Connection.Material_GetByAreaCat("Trapeadores", "Enrollado");
            foreach (var mecha in mechas)
            {
                BastónCombo.Items.Add(mecha);
            }

            var etiquetas = GlobalConfig.Connection.Material_GetByAreaCat("Trapeadores", "Etiqueta");
            foreach (var etiqueta in etiquetas)
            {
                BastónCombo.Items.Add(etiqueta);
            }
        }

        bool ValidateForm()
        {
            var output = true;
            MsgBox.Text = "";

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

            if (BastónCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un bastón.\n";
            }

            if (CantidadBastónText.Text == "0" || !double.TryParse(CantidadBastónText.Text, out _cantidadBastón))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de bastones.\n";
            }

            if (AlambreCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un alambre.\n";
            }

            if (CantidadAlambreText.Text == "0" || !double.TryParse(CantidadAlambreText.Text, out _cantidadAlambre))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de rollos de alambre.\n";
            }

            if (BolsaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una bolsa.\n";
            }

            if (CantidadBolsaText.Text == "0" || !double.TryParse(CantidadBolsaText.Text, out _cantidadBolsa))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de bolsas.\n";
            }

            if (MechaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una mecha.\n";
            }

            if (CantidadMechaText.Text == "0" || !double.TryParse(CantidadMechaText.Text, out _cantidadMecha))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de mecha.\n";
            }

            if (EtiquetaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una etiqueta.\n";
            }

            if (CantidadEtiquetaText.Text == "0" || !double.TryParse(CantidadEtiquetaText.Text, out _cantidadEtiqueta))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de etiquetas.\n";
            }

            if (SalidaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un kit.\n";
            }

            if (CantidadSalidaText.Text == "0" || !int.TryParse(CantidadSalidaText.Text, out _cantidadKit))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad de kits.\n";
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
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.Text = "";
                        comboBox.SelectedItem = null;
                    }
                    else
                        Func(control.Controls);
            }

            Func(Controls);

            CantidadBastónText.Text = "0";
            CantidadAlambreText.Text = "0";
            CantidadBolsaText.Text = "0";
            CantidadMechaText.Text = "0";
            CantidadEtiquetaText.Text = "0";
            CantidadSalidaText.Text = "0";
        }

        #endregion
    }
}
