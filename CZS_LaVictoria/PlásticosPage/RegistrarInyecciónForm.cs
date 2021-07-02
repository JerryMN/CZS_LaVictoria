using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CZS_ERP_Library;
using CZS_ERP_Library.Models;

namespace CZS_ERP_UI.PlásticosPage
{
    public partial class RegistrarInyecciónForm : Form
    {
        MaterialModel _materialSalida = new MaterialModel();
        double _kgEntrada;
        double _kgSalida;
        double _piezasBuenas;
        double _pesoProm;
        double _mermaMoler;
        string _mezclaNombre;

        public RegistrarInyecciónForm()
        {
            InitializeComponent();
            GetMateriales();
            GetBases();
            MaterialesListBox.DisplayMember = "Nombre";
        }

        #region Events

        void AgregarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            if (!ValidateMix())
            {
                MsgBox.Visible = true;
                return;
            }

            var material = (MaterialModel)MaterialCombo.SelectedItem;
            double.TryParse(CantidadText.Text, out var cantidad);

            if (cantidad > material.CantidadDisponible)
            {
                MsgBox.Text =
                    $"El material no se puede seleccionar. La cantidad máxima permitida es de {material.CantidadDisponible:N} kg.";
                MsgBox.Visible = true;
                GuardarButton.Enabled = false;
                return;
            }

            MaterialCombo.Items.Remove(material);
            MaterialesListBox.Items.Add(material);
            MaterialesListBox.SelectedItem = null;
            CantidadesListBox.Items.Add(cantidad);
            CantidadText.Text = "0.00";
            _kgEntrada += cantidad;

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
            double.TryParse(CantidadesListBox.Items[index].ToString(), out var cantidad);
            _kgEntrada -= cantidad;
            MaterialesListBox.Items.RemoveAt(index);
            CantidadesListBox.Items.RemoveAt(index);

            InputOutputChanged(sender, e);
        }

        void SalidaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _materialSalida = (MaterialModel)SalidaCombo.SelectedItem;
            PesoPromText.Text = _materialSalida.Peso.ToString(CultureInfo.InvariantCulture);
        }

        void CalcularButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;
            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }
            
            _kgSalida = _piezasBuenas * _pesoProm / 1000;
            var mermaFinal = _kgEntrada - _kgSalida - _mermaMoler;
            if (mermaFinal < 0)
            {
                MsgBox.Text = "Revisa los valores de entrada o de salida.";
                MsgBox.Visible = true;
                MermaFinalText.Text = "0.00";
                GuardarButton.Enabled = false;
                return;
            }

            MermaFinalText.Text = mermaFinal.ToString(CultureInfo.InvariantCulture);
            MsgBox.Text = "Cantidades válidas.";
            MsgBox.IconColor = Color.DarkGreen;
            MsgBox.Visible = true;
            MsgBoxTimer.Start();
            GuardarButton.Enabled = true;
            CalcularButton.Enabled = false;
        }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            // TODO - Update cantidad de por moler.
            // TODO - Fill Productions table.
            bool saveSuccess;

            // Dar opción de guardar la lista y cantidades de materiales seleccionados como una nueva mezcla.
            if (MessageBox.Show("Deseas guardar esta mezcla para futuros registros?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ShowInputDialog(ref _mezclaNombre);
                if (_mezclaNombre == "")
                {
                    MsgBox.Text = "Ingresa un nombre válido. Vuelve a dar click en Guardar.";
                    MsgBox.Visible = true;
                    return;
                }
                var model = CreateModel();
                saveSuccess = GlobalConfig.Connection.Mezcla_Create(model);
            }

            // Actualizar las cantidades de cada material en el ListBox.
            var index = 0;
            foreach (var item in MaterialesListBox.Items)
            {
                var material = (MaterialModel) item;
                material.CantidadDisponible -= (double) CantidadesListBox.Items[index];
                GlobalConfig.Connection.Material_Update(material);
                index += 1;
                saveSuccess = true;
            }

            // Si no se seleccionó una base del ComboBox, guardarla como una base nueva.
            // Si sí se seleccionó una, actualizar cantidades y, de ser necesario, el peso.
            if (_materialSalida.Nombre == null)
            {
                _materialSalida.Nombre = SalidaCombo.Text;
                _materialSalida.Area = "Plásticos";
                _materialSalida.Categoría = "Bases";
                _materialSalida.CantidadDisponible = _piezasBuenas;
                _materialSalida.Peso = double.Parse(PesoPromText.Text);
                saveSuccess = GlobalConfig.Connection.Material_Create(_materialSalida);
            }
            else
            {
                _materialSalida.CantidadDisponible = _piezasBuenas;
                _materialSalida.Peso = double.Parse(PesoPromText.Text);
                saveSuccess = GlobalConfig.Connection.Material_Update(_materialSalida);
            }

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = "Inyección y mezcla registradas con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al registrar inyección o mezcla.";
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

        void GetMateriales()
        {
            var materiales = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Molido");

            foreach (var material in materiales)
            {
                MaterialCombo.Items.Add(material);
            }

            MaterialCombo.DisplayMember = "Nombre";
            MaterialCombo.Sorted = true;
        }

        void GetBases()
        {
            var bases = GlobalConfig.Connection.Material_GetByAreaCat("Plásticos", "Bases");

            foreach (var material in bases)
            {
                SalidaCombo.Items.Add(material);
            }

            SalidaCombo.DisplayMember = "Nombre";
            SalidaCombo.Sorted = true;
        }

        bool ValidateMix()
        {
            var output = true;
            MsgBox.Text = "";

            if (MaterialCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona un material.\n";
            }

            if (CantidadText.Text == "" || CantidadText.Text == "0.00" || !double.TryParse(CantidadText.Text, out _))
            {
                output = false;
                MsgBox.Text += "Ingresa la cantidad.\n";
            }

            return output;
        }

        bool ValidateForm()
        {
            var output = true;
            MsgBox.Text = "";

            if (SalidaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Selecciona una producto de salida.\n";
            }

            if (CantidadSalidaText.Text == "" || CantidadSalidaText.Text == "0" || !double.TryParse(CantidadSalidaText.Text, out _piezasBuenas))
            {
                output = false;
                MsgBox.Text += "Ingresa las piezas buenas.\n";
            }

            if (PesoPromText.Text == "" || PesoPromText.Text == "0.00" || !double.TryParse(PesoPromText.Text, out _pesoProm))
            {
                output = false;
                MsgBox.Text += "Ingresa el peso promedio de una pieza.\n";
            }

            if (MermaMolerText.Text == "" || MermaMolerText.Text == "0.00" || !double.TryParse(MermaMolerText.Text, out _mermaMoler))
            {
                output = false;
                MsgBox.Text += "Ingresa la merma que se puede moler.\n";
            }

            if (MaterialesListBox.Items.Count != CantidadesListBox.Items.Count)
            {
                output = false;
                MsgBox.Text = "Las listas no son del mismo largo. Vuelve a iniciar.";
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
            input = textBox.Text;
        }

        MezclaModel CreateModel()
        {
            var model = new MezclaModel();
            var materiales = MaterialesListBox.Items.Cast<MaterialModel>().ToList();
            var cantidades = CantidadesListBox.Items.Cast<double>().ToList();
            var cantidad = CantidadesListBox.Items.Cast<object>().Sum(item => double.Parse(item.ToString()));

            model.Nombre = _mezclaNombre;
            model.Materiales = materiales;
            model.Cantidades = cantidades;
            model.CantidadMezcla = cantidad;

            return model;
        }

        void ClearForm()
        {
            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox box)
                    {
                        box.Clear();
                        box.Enabled = true;
                    }
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.Text = "";
                        comboBox.SelectedItem = null;
                    }
                    else if (control is ListBox listBox)
                    {
                        listBox.Items.Clear();
                    }
                    else
                        Func(control.Controls);
            }

            Func(Controls);
        }

        #endregion
    }
}
