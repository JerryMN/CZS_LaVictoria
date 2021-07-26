using System;
using System.Windows.Forms;

namespace CZS_LaVictoria.ÓrdenesPage
{
    public partial class AgregarNotasForm : Form
    {
        public AgregarNotasForm()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        public string Notas { get; set; }

        void GuardarButton_Click(object sender, EventArgs e)
        {
            Notas = NotasText.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        void CerrarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}