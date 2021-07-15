﻿
namespace CZS_LaVictoria.DatosPage
{
    partial class KitVerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CantidadesListBox = new System.Windows.Forms.ListBox();
            this.MaterialesListBox = new System.Windows.Forms.ListBox();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NombreCombo = new System.Windows.Forms.ComboBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CantidadesListBox
            // 
            this.CantidadesListBox.FormattingEnabled = true;
            this.CantidadesListBox.ItemHeight = 21;
            this.CantidadesListBox.Location = new System.Drawing.Point(726, 147);
            this.CantidadesListBox.Name = "CantidadesListBox";
            this.CantidadesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CantidadesListBox.Size = new System.Drawing.Size(200, 193);
            this.CantidadesListBox.TabIndex = 60;
            // 
            // MaterialesListBox
            // 
            this.MaterialesListBox.FormattingEnabled = true;
            this.MaterialesListBox.ItemHeight = 21;
            this.MaterialesListBox.Location = new System.Drawing.Point(520, 147);
            this.MaterialesListBox.Name = "MaterialesListBox";
            this.MaterialesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.MaterialesListBox.Size = new System.Drawing.Size(200, 193);
            this.MaterialesListBox.TabIndex = 61;
            // 
            // MsgBox
            // 
            this.MsgBox.FlatAppearance.BorderSize = 0;
            this.MsgBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsgBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBox.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.MsgBox.IconColor = System.Drawing.Color.DarkRed;
            this.MsgBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MsgBox.IconSize = 32;
            this.MsgBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.Location = new System.Drawing.Point(506, 400);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 157);
            this.MsgBox.TabIndex = 59;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // EliminarButton
            // 
            this.EliminarButton.AutoSize = true;
            this.EliminarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(392, 200);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(78, 33);
            this.EliminarButton.TabIndex = 58;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NombreCombo
            // 
            this.NombreCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NombreCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NombreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NombreCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCombo.FormattingEnabled = true;
            this.NombreCombo.Location = new System.Drawing.Point(220, 147);
            this.NombreCombo.Name = "NombreCombo";
            this.NombreCombo.Size = new System.Drawing.Size(250, 29);
            this.NombreCombo.TabIndex = 57;
            this.NombreCombo.SelectedIndexChanged += new System.EventHandler(this.NombreCombo_SelectedIndexChanged);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(50, 150);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(68, 21);
            this.NombreLabel.TabIndex = 56;
            this.NombreLabel.Text = "Nombre";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(109, 37);
            this.SubtitleLabel.TabIndex = 54;
            this.SubtitleLabel.Text = "Ver Kits";
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // KitVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.CantidadesListBox);
            this.Controls.Add(this.MaterialesListBox);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NombreCombo);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KitVerForm";
            this.Text = "KitVerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CantidadesListBox;
        private System.Windows.Forms.ListBox MaterialesListBox;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ComboBox NombreCombo;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Timer MsgBoxTimer;
    }
}