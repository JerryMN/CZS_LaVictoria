using System.Collections;
using System.Windows.Forms;

namespace CZS_LaVictoria_Library
{
    public static class Tools
    {
        public static void ClearForm(Control form)
        {
            void Func(IEnumerable controls)
            {
                foreach (Control control in controls)
                    switch (control)
                    {
                        case TextBox box:
                            box.Clear();
                            box.Enabled = true;
                            break;
                        case ComboBox comboBox:
                            comboBox.Text = "";
                            comboBox.SelectedItem = null;
                            break;
                        case ListBox listBox:
                            listBox.Items.Clear();
                            break;
                        default:
                            Func(control.Controls);
                            break;
                    }
            }

            Func(form.Controls);
        }
    }
}