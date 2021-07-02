﻿
namespace CZS_LaVictoria.PlásticosPage
{
    partial class RegistrarInyecciónForm
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
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MermaMolerText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MermaFinalText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PesoPromText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CantidadSalidaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.SalidaCombo = new System.Windows.Forms.ComboBox();
            this.MermaMolerLabel = new System.Windows.Forms.Label();
            this.ArrowButton = new FontAwesome.Sharp.IconButton();
            this.MermaRealLabel = new System.Windows.Forms.Label();
            this.MermaRealUnidad = new System.Windows.Forms.Label();
            this.MermaMolerUnidad = new System.Windows.Forms.Label();
            this.PesoPromUnidad = new System.Windows.Forms.Label();
            this.PesoPromLabel = new System.Windows.Forms.Label();
            this.CantidadSalidaLabel = new System.Windows.Forms.Label();
            this.SalidaLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.CantidadesListBox = new System.Windows.Forms.ListBox();
            this.MaterialesListBox = new System.Windows.Forms.ListBox();
            this.CantidadText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.MaterialCombo = new System.Windows.Forms.ComboBox();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.MsgBox.Location = new System.Drawing.Point(550, 450);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 165);
            this.MsgBox.TabIndex = 68;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // CalcularButton
            // 
            this.CalcularButton.AutoSize = true;
            this.CalcularButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(808, 400);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(78, 35);
            this.CalcularButton.TabIndex = 67;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(892, 400);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 35);
            this.GuardarButton.TabIndex = 66;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MermaMolerText
            // 
            this.MermaMolerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MermaMolerText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MermaMolerText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MermaMolerText.Location = new System.Drawing.Point(720, 297);
            this.MermaMolerText.MinValue = 0D;
            this.MermaMolerText.Name = "MermaMolerText";
            this.MermaMolerText.Size = new System.Drawing.Size(250, 29);
            this.MermaMolerText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MermaMolerText.TabIndex = 63;
            this.MermaMolerText.WatermarkText = "Calculado automáticamente";
            this.MermaMolerText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // MermaFinalText
            // 
            this.MermaFinalText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MermaFinalText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MermaFinalText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MermaFinalText.Location = new System.Drawing.Point(720, 347);
            this.MermaFinalText.MinValue = 0D;
            this.MermaFinalText.Name = "MermaFinalText";
            this.MermaFinalText.ReadOnly = true;
            this.MermaFinalText.Size = new System.Drawing.Size(250, 29);
            this.MermaFinalText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MermaFinalText.TabIndex = 62;
            this.MermaFinalText.WatermarkText = "Calculado automáticamente";
            // 
            // PesoPromText
            // 
            this.PesoPromText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PesoPromText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoPromText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PesoPromText.Location = new System.Drawing.Point(720, 247);
            this.PesoPromText.MinValue = 0D;
            this.PesoPromText.Name = "PesoPromText";
            this.PesoPromText.Size = new System.Drawing.Size(250, 29);
            this.PesoPromText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PesoPromText.TabIndex = 64;
            this.PesoPromText.WatermarkText = "Ingresa la cantidad";
            this.PesoPromText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CantidadSalidaText
            // 
            this.CantidadSalidaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadSalidaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadSalidaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadSalidaText.HideTrailingZeros = true;
            this.CantidadSalidaText.Location = new System.Drawing.Point(720, 197);
            this.CantidadSalidaText.MinValue = 0D;
            this.CantidadSalidaText.Name = "CantidadSalidaText";
            this.CantidadSalidaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadSalidaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadSalidaText.TabIndex = 65;
            this.CantidadSalidaText.Text = "0";
            this.CantidadSalidaText.WatermarkText = "Ingresa la cantidad";
            this.CantidadSalidaText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // SalidaCombo
            // 
            this.SalidaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SalidaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SalidaCombo.FormattingEnabled = true;
            this.SalidaCombo.Location = new System.Drawing.Point(720, 147);
            this.SalidaCombo.Name = "SalidaCombo";
            this.SalidaCombo.Size = new System.Drawing.Size(250, 29);
            this.SalidaCombo.TabIndex = 61;
            this.SalidaCombo.SelectedIndexChanged += new System.EventHandler(this.SalidaCombo_SelectedIndexChanged);
            this.SalidaCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // MermaMolerLabel
            // 
            this.MermaMolerLabel.AutoSize = true;
            this.MermaMolerLabel.Location = new System.Drawing.Point(600, 300);
            this.MermaMolerLabel.Name = "MermaMolerLabel";
            this.MermaMolerLabel.Size = new System.Drawing.Size(117, 21);
            this.MermaMolerLabel.TabIndex = 53;
            this.MermaMolerLabel.Text = "Merma a Moler";
            // 
            // ArrowButton
            // 
            this.ArrowButton.FlatAppearance.BorderSize = 0;
            this.ArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArrowButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowButton.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight;
            this.ArrowButton.IconColor = System.Drawing.Color.Black;
            this.ArrowButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ArrowButton.Location = new System.Drawing.Point(500, 265);
            this.ArrowButton.Name = "ArrowButton";
            this.ArrowButton.Size = new System.Drawing.Size(44, 36);
            this.ArrowButton.TabIndex = 60;
            this.ArrowButton.UseVisualStyleBackColor = true;
            // 
            // MermaRealLabel
            // 
            this.MermaRealLabel.AutoSize = true;
            this.MermaRealLabel.Location = new System.Drawing.Point(600, 350);
            this.MermaRealLabel.Name = "MermaRealLabel";
            this.MermaRealLabel.Size = new System.Drawing.Size(94, 21);
            this.MermaRealLabel.TabIndex = 52;
            this.MermaRealLabel.Text = "Merma Real";
            // 
            // MermaRealUnidad
            // 
            this.MermaRealUnidad.AutoSize = true;
            this.MermaRealUnidad.Location = new System.Drawing.Point(976, 350);
            this.MermaRealUnidad.Name = "MermaRealUnidad";
            this.MermaRealUnidad.Size = new System.Drawing.Size(27, 21);
            this.MermaRealUnidad.TabIndex = 58;
            this.MermaRealUnidad.Text = "kg";
            // 
            // MermaMolerUnidad
            // 
            this.MermaMolerUnidad.AutoSize = true;
            this.MermaMolerUnidad.Location = new System.Drawing.Point(976, 300);
            this.MermaMolerUnidad.Name = "MermaMolerUnidad";
            this.MermaMolerUnidad.Size = new System.Drawing.Size(27, 21);
            this.MermaMolerUnidad.TabIndex = 57;
            this.MermaMolerUnidad.Text = "kg";
            // 
            // PesoPromUnidad
            // 
            this.PesoPromUnidad.AutoSize = true;
            this.PesoPromUnidad.Location = new System.Drawing.Point(976, 250);
            this.PesoPromUnidad.Name = "PesoPromUnidad";
            this.PesoPromUnidad.Size = new System.Drawing.Size(63, 21);
            this.PesoPromUnidad.TabIndex = 56;
            this.PesoPromUnidad.Text = "gramos";
            // 
            // PesoPromLabel
            // 
            this.PesoPromLabel.AutoSize = true;
            this.PesoPromLabel.Location = new System.Drawing.Point(600, 250);
            this.PesoPromLabel.Name = "PesoPromLabel";
            this.PesoPromLabel.Size = new System.Drawing.Size(87, 21);
            this.PesoPromLabel.TabIndex = 55;
            this.PesoPromLabel.Text = "Peso Prom.";
            // 
            // CantidadSalidaLabel
            // 
            this.CantidadSalidaLabel.AutoSize = true;
            this.CantidadSalidaLabel.Location = new System.Drawing.Point(600, 200);
            this.CantidadSalidaLabel.Name = "CantidadSalidaLabel";
            this.CantidadSalidaLabel.Size = new System.Drawing.Size(107, 21);
            this.CantidadSalidaLabel.TabIndex = 54;
            this.CantidadSalidaLabel.Text = "Piezas Buenas";
            // 
            // SalidaLabel
            // 
            this.SalidaLabel.AutoSize = true;
            this.SalidaLabel.Location = new System.Drawing.Point(600, 150);
            this.SalidaLabel.Name = "SalidaLabel";
            this.SalidaLabel.Size = new System.Drawing.Size(73, 21);
            this.SalidaLabel.TabIndex = 59;
            this.SalidaLabel.Text = "Producto";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(279, 37);
            this.SubtitleLabel.TabIndex = 51;
            this.SubtitleLabel.Text = "Registro de Inyección";
            // 
            // EliminarButton
            // 
            this.EliminarButton.AutoSize = true;
            this.EliminarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(360, 500);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(84, 33);
            this.EliminarButton.TabIndex = 79;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.AutoSize = true;
            this.AgregarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Location = new System.Drawing.Point(360, 250);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(84, 33);
            this.AgregarButton.TabIndex = 78;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // CantidadesListBox
            // 
            this.CantidadesListBox.FormattingEnabled = true;
            this.CantidadesListBox.ItemHeight = 21;
            this.CantidadesListBox.Location = new System.Drawing.Point(360, 300);
            this.CantidadesListBox.Name = "CantidadesListBox";
            this.CantidadesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CantidadesListBox.Size = new System.Drawing.Size(84, 193);
            this.CantidadesListBox.TabIndex = 76;
            // 
            // MaterialesListBox
            // 
            this.MaterialesListBox.FormattingEnabled = true;
            this.MaterialesListBox.ItemHeight = 21;
            this.MaterialesListBox.Location = new System.Drawing.Point(50, 300);
            this.MaterialesListBox.Name = "MaterialesListBox";
            this.MaterialesListBox.Size = new System.Drawing.Size(304, 193);
            this.MaterialesListBox.TabIndex = 77;
            // 
            // CantidadText
            // 
            this.CantidadText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadText.Location = new System.Drawing.Point(194, 197);
            this.CantidadText.MinValue = 0D;
            this.CantidadText.Name = "CantidadText";
            this.CantidadText.Size = new System.Drawing.Size(250, 29);
            this.CantidadText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadText.TabIndex = 75;
            this.CantidadText.WatermarkText = "Ingresa la cantidad";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(50, 200);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(72, 21);
            this.Cantidad.TabIndex = 74;
            this.Cantidad.Text = "Cantidad";
            // 
            // MaterialCombo
            // 
            this.MaterialCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MaterialCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MaterialCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialCombo.FormattingEnabled = true;
            this.MaterialCombo.Location = new System.Drawing.Point(194, 147);
            this.MaterialCombo.Name = "MaterialCombo";
            this.MaterialCombo.Size = new System.Drawing.Size(250, 29);
            this.MaterialCombo.TabIndex = 73;
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLabel.Location = new System.Drawing.Point(50, 150);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(67, 21);
            this.MaterialLabel.TabIndex = 72;
            this.MaterialLabel.Text = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "kg";
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // RegistrarInyecciónForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.CantidadesListBox);
            this.Controls.Add(this.MaterialesListBox);
            this.Controls.Add(this.CantidadText);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.MaterialCombo);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.MermaMolerText);
            this.Controls.Add(this.MermaFinalText);
            this.Controls.Add(this.PesoPromText);
            this.Controls.Add(this.CantidadSalidaText);
            this.Controls.Add(this.SalidaCombo);
            this.Controls.Add(this.MermaMolerLabel);
            this.Controls.Add(this.ArrowButton);
            this.Controls.Add(this.MermaRealLabel);
            this.Controls.Add(this.MermaRealUnidad);
            this.Controls.Add(this.MermaMolerUnidad);
            this.Controls.Add(this.PesoPromUnidad);
            this.Controls.Add(this.PesoPromLabel);
            this.Controls.Add(this.CantidadSalidaLabel);
            this.Controls.Add(this.SalidaLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarInyecciónForm";
            this.Text = "RegistrarInyecciónForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfNumericTextBox MermaMolerText;
        private Syncfusion.WinForms.Input.SfNumericTextBox MermaFinalText;
        private Syncfusion.WinForms.Input.SfNumericTextBox PesoPromText;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadSalidaText;
        private System.Windows.Forms.ComboBox SalidaCombo;
        private System.Windows.Forms.Label MermaMolerLabel;
        private FontAwesome.Sharp.IconButton ArrowButton;
        private System.Windows.Forms.Label MermaRealLabel;
        private System.Windows.Forms.Label MermaRealUnidad;
        private System.Windows.Forms.Label MermaMolerUnidad;
        private System.Windows.Forms.Label PesoPromUnidad;
        private System.Windows.Forms.Label PesoPromLabel;
        private System.Windows.Forms.Label CantidadSalidaLabel;
        private System.Windows.Forms.Label SalidaLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.ListBox CantidadesListBox;
        private System.Windows.Forms.ListBox MaterialesListBox;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadText;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.ComboBox MaterialCombo;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer MsgBoxTimer;
    }
}