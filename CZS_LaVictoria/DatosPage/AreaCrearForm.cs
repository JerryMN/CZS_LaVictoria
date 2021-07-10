﻿using System;
using System.Collections;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using CZS_LaVictoria_Library;
using CZS_LaVictoria_Library.Models;

namespace CZS_LaVictoria.DatosPage
{
    public partial class AreaCrearForm : Form
    {
        public AreaCrearForm()
        {
            InitializeComponent();
            GetAreas();
        }

        #region Events

        void GuardarButton_Click(object sender, EventArgs e)
        {
            MsgBox.Visible = false;

            if (!ValidateForm())
            {
                MsgBox.Visible = true;
                return;
            }

            var model = new AreaModel { Área = AreaCombo.Text, Responsable = ResponsableText.Text, Correo = CorreoText.Text };

            var saveSuccess = GlobalConfig.Connection.Area_Create(model);

            if (saveSuccess)
            {
                ClearForm();
                MsgBox.Text = $"Área {model.Área} guardada con éxito.";
                MsgBox.IconColor = Color.DarkGreen;
            }
            else
            {
                MsgBox.Text = "Error al crear área.";
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

        void GetAreas()
        {
            var areas = GlobalConfig.Connection.Area_GetAll();

            foreach (var area in areas)
            {
                AreaCombo.Items.Add(area);
            }

            AreaCombo.DisplayMember = "Área";
        }

        bool ValidateForm()
        {
            var output = true;

            if (AreaCombo.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del área.\n";
            }

            if (ResponsableText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el nombre del responsable.\n";
            }

            if (CorreoText.Text == "")
            {
                output = false;
                MsgBox.Text += "Ingresa el correo del responsable.\n";
            }
            else
            {
                try
                {
                    var unused = new MailAddress(CorreoText.Text);
                }
                catch (Exception)
                {
                    output = false;
                    MsgBox.Text += "Ingresa un correo válido.\n";
                }
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
        }

        #endregion
    }
}
