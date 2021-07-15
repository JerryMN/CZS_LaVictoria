﻿
namespace CZS_LaVictoria.TrapeadoresPage
{
    partial class RegistrarTrapeadoresForm
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
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.TurnoText = new System.Windows.Forms.NumericUpDown();
            this.MaquinaText = new System.Windows.Forms.NumericUpDown();
            this.FechaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.OperadorCombo = new System.Windows.Forms.ComboBox();
            this.MaquinaLabel = new System.Windows.Forms.Label();
            this.OperadorLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.CantidadBastónText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.BastónCombo = new System.Windows.Forms.ComboBox();
            this.CantidadBastónLabel = new System.Windows.Forms.Label();
            this.BastónLabel = new System.Windows.Forms.Label();
            this.AlambreLabel = new System.Windows.Forms.Label();
            this.CantidadAlambreLabel = new System.Windows.Forms.Label();
            this.AlambreCombo = new System.Windows.Forms.ComboBox();
            this.CantidadAlambreText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.BolsaLabel = new System.Windows.Forms.Label();
            this.MechaLabel = new System.Windows.Forms.Label();
            this.CantidadBolsaLabel = new System.Windows.Forms.Label();
            this.CantidadMechaLabel = new System.Windows.Forms.Label();
            this.BolsaCombo = new System.Windows.Forms.ComboBox();
            this.MechaCombo = new System.Windows.Forms.ComboBox();
            this.CantidadBolsaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CantidadMechaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.EtiquetaLabel = new System.Windows.Forms.Label();
            this.CantidadEtiquetaLabel = new System.Windows.Forms.Label();
            this.EtiquetaCombo = new System.Windows.Forms.ComboBox();
            this.CantidadEtiquetaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.ArrowButton = new FontAwesome.Sharp.IconButton();
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CantidadSalidaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.SalidaCombo = new System.Windows.Forms.ComboBox();
            this.CantidadSalidaLabel = new System.Windows.Forms.Label();
            this.SalidaLabel = new System.Windows.Forms.Label();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TurnoText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaquinaText)).BeginInit();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(311, 37);
            this.SubtitleLabel.TabIndex = 33;
            this.SubtitleLabel.Text = "Registro de Trapeadores";
            // 
            // TurnoText
            // 
            this.TurnoText.Location = new System.Drawing.Point(330, 247);
            this.TurnoText.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.TurnoText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TurnoText.Name = "TurnoText";
            this.TurnoText.Size = new System.Drawing.Size(120, 29);
            this.TurnoText.TabIndex = 89;
            this.TurnoText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaquinaText
            // 
            this.MaquinaText.Location = new System.Drawing.Point(200, 247);
            this.MaquinaText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaquinaText.Name = "MaquinaText";
            this.MaquinaText.Size = new System.Drawing.Size(120, 29);
            this.MaquinaText.TabIndex = 90;
            this.MaquinaText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FechaPicker
            // 
            this.FechaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaPicker.Location = new System.Drawing.Point(200, 147);
            this.FechaPicker.Name = "FechaPicker";
            this.FechaPicker.Size = new System.Drawing.Size(250, 33);
            this.FechaPicker.TabIndex = 88;
            // 
            // OperadorCombo
            // 
            this.OperadorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperadorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorCombo.FormattingEnabled = true;
            this.OperadorCombo.Location = new System.Drawing.Point(200, 197);
            this.OperadorCombo.Name = "OperadorCombo";
            this.OperadorCombo.Size = new System.Drawing.Size(250, 29);
            this.OperadorCombo.TabIndex = 87;
            // 
            // MaquinaLabel
            // 
            this.MaquinaLabel.AutoSize = true;
            this.MaquinaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaquinaLabel.Location = new System.Drawing.Point(50, 250);
            this.MaquinaLabel.Name = "MaquinaLabel";
            this.MaquinaLabel.Size = new System.Drawing.Size(126, 21);
            this.MaquinaLabel.TabIndex = 84;
            this.MaquinaLabel.Text = "Máquina / Turno";
            // 
            // OperadorLabel
            // 
            this.OperadorLabel.AutoSize = true;
            this.OperadorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorLabel.Location = new System.Drawing.Point(50, 200);
            this.OperadorLabel.Name = "OperadorLabel";
            this.OperadorLabel.Size = new System.Drawing.Size(77, 21);
            this.OperadorLabel.TabIndex = 85;
            this.OperadorLabel.Text = "Operador";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(50, 150);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(144, 21);
            this.FechaLabel.TabIndex = 86;
            this.FechaLabel.Text = "Fecha de operación";
            // 
            // CantidadBastónText
            // 
            this.CantidadBastónText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadBastónText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadBastónText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadBastónText.HideTrailingZeros = true;
            this.CantidadBastónText.Location = new System.Drawing.Point(200, 347);
            this.CantidadBastónText.MinValue = 0D;
            this.CantidadBastónText.Name = "CantidadBastónText";
            this.CantidadBastónText.Size = new System.Drawing.Size(250, 29);
            this.CantidadBastónText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadBastónText.TabIndex = 94;
            this.CantidadBastónText.Text = "0";
            this.CantidadBastónText.WatermarkText = "Ingresa la cantidad";
            // 
            // BastónCombo
            // 
            this.BastónCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BastónCombo.FormattingEnabled = true;
            this.BastónCombo.Location = new System.Drawing.Point(200, 297);
            this.BastónCombo.Name = "BastónCombo";
            this.BastónCombo.Size = new System.Drawing.Size(250, 29);
            this.BastónCombo.TabIndex = 93;
            // 
            // CantidadBastónLabel
            // 
            this.CantidadBastónLabel.AutoSize = true;
            this.CantidadBastónLabel.Location = new System.Drawing.Point(50, 350);
            this.CantidadBastónLabel.Name = "CantidadBastónLabel";
            this.CantidadBastónLabel.Size = new System.Drawing.Size(72, 21);
            this.CantidadBastónLabel.TabIndex = 91;
            this.CantidadBastónLabel.Text = "Cantidad";
            // 
            // BastónLabel
            // 
            this.BastónLabel.AutoSize = true;
            this.BastónLabel.Location = new System.Drawing.Point(50, 300);
            this.BastónLabel.Name = "BastónLabel";
            this.BastónLabel.Size = new System.Drawing.Size(57, 21);
            this.BastónLabel.TabIndex = 92;
            this.BastónLabel.Text = "Bastón";
            // 
            // AlambreLabel
            // 
            this.AlambreLabel.AutoSize = true;
            this.AlambreLabel.Location = new System.Drawing.Point(50, 400);
            this.AlambreLabel.Name = "AlambreLabel";
            this.AlambreLabel.Size = new System.Drawing.Size(130, 21);
            this.AlambreLabel.TabIndex = 92;
            this.AlambreLabel.Text = "Rollo de Alambre";
            // 
            // CantidadAlambreLabel
            // 
            this.CantidadAlambreLabel.AutoSize = true;
            this.CantidadAlambreLabel.Location = new System.Drawing.Point(50, 450);
            this.CantidadAlambreLabel.Name = "CantidadAlambreLabel";
            this.CantidadAlambreLabel.Size = new System.Drawing.Size(72, 21);
            this.CantidadAlambreLabel.TabIndex = 91;
            this.CantidadAlambreLabel.Text = "Cantidad";
            // 
            // AlambreCombo
            // 
            this.AlambreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlambreCombo.FormattingEnabled = true;
            this.AlambreCombo.Location = new System.Drawing.Point(200, 397);
            this.AlambreCombo.Name = "AlambreCombo";
            this.AlambreCombo.Size = new System.Drawing.Size(250, 29);
            this.AlambreCombo.TabIndex = 93;
            // 
            // CantidadAlambreText
            // 
            this.CantidadAlambreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadAlambreText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadAlambreText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadAlambreText.HideTrailingZeros = true;
            this.CantidadAlambreText.Location = new System.Drawing.Point(200, 447);
            this.CantidadAlambreText.MinValue = 0D;
            this.CantidadAlambreText.Name = "CantidadAlambreText";
            this.CantidadAlambreText.Size = new System.Drawing.Size(250, 29);
            this.CantidadAlambreText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadAlambreText.TabIndex = 94;
            this.CantidadAlambreText.Text = "0";
            this.CantidadAlambreText.WatermarkText = "Ingresa la cantidad";
            // 
            // BolsaLabel
            // 
            this.BolsaLabel.AutoSize = true;
            this.BolsaLabel.Location = new System.Drawing.Point(50, 500);
            this.BolsaLabel.Name = "BolsaLabel";
            this.BolsaLabel.Size = new System.Drawing.Size(47, 21);
            this.BolsaLabel.TabIndex = 92;
            this.BolsaLabel.Text = "Bolsa";
            // 
            // MechaLabel
            // 
            this.MechaLabel.AutoSize = true;
            this.MechaLabel.Location = new System.Drawing.Point(50, 600);
            this.MechaLabel.Name = "MechaLabel";
            this.MechaLabel.Size = new System.Drawing.Size(56, 21);
            this.MechaLabel.TabIndex = 92;
            this.MechaLabel.Text = "Mecha";
            // 
            // CantidadBolsaLabel
            // 
            this.CantidadBolsaLabel.AutoSize = true;
            this.CantidadBolsaLabel.Location = new System.Drawing.Point(50, 550);
            this.CantidadBolsaLabel.Name = "CantidadBolsaLabel";
            this.CantidadBolsaLabel.Size = new System.Drawing.Size(72, 21);
            this.CantidadBolsaLabel.TabIndex = 91;
            this.CantidadBolsaLabel.Text = "Cantidad";
            // 
            // CantidadMechaLabel
            // 
            this.CantidadMechaLabel.AutoSize = true;
            this.CantidadMechaLabel.Location = new System.Drawing.Point(50, 650);
            this.CantidadMechaLabel.Name = "CantidadMechaLabel";
            this.CantidadMechaLabel.Size = new System.Drawing.Size(72, 21);
            this.CantidadMechaLabel.TabIndex = 91;
            this.CantidadMechaLabel.Text = "Cantidad";
            // 
            // BolsaCombo
            // 
            this.BolsaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BolsaCombo.FormattingEnabled = true;
            this.BolsaCombo.Location = new System.Drawing.Point(200, 497);
            this.BolsaCombo.Name = "BolsaCombo";
            this.BolsaCombo.Size = new System.Drawing.Size(250, 29);
            this.BolsaCombo.TabIndex = 93;
            // 
            // MechaCombo
            // 
            this.MechaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MechaCombo.FormattingEnabled = true;
            this.MechaCombo.Location = new System.Drawing.Point(200, 597);
            this.MechaCombo.Name = "MechaCombo";
            this.MechaCombo.Size = new System.Drawing.Size(250, 29);
            this.MechaCombo.TabIndex = 93;
            // 
            // CantidadBolsaText
            // 
            this.CantidadBolsaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadBolsaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadBolsaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadBolsaText.HideTrailingZeros = true;
            this.CantidadBolsaText.Location = new System.Drawing.Point(200, 547);
            this.CantidadBolsaText.MinValue = 0D;
            this.CantidadBolsaText.Name = "CantidadBolsaText";
            this.CantidadBolsaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadBolsaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadBolsaText.TabIndex = 94;
            this.CantidadBolsaText.Text = "0";
            this.CantidadBolsaText.WatermarkText = "Ingresa la cantidad";
            // 
            // CantidadMechaText
            // 
            this.CantidadMechaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadMechaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadMechaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadMechaText.HideTrailingZeros = true;
            this.CantidadMechaText.Location = new System.Drawing.Point(200, 647);
            this.CantidadMechaText.MinValue = 0D;
            this.CantidadMechaText.Name = "CantidadMechaText";
            this.CantidadMechaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadMechaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadMechaText.TabIndex = 94;
            this.CantidadMechaText.Text = "0";
            this.CantidadMechaText.WatermarkText = "Ingresa la cantidad";
            // 
            // EtiquetaLabel
            // 
            this.EtiquetaLabel.AutoSize = true;
            this.EtiquetaLabel.Location = new System.Drawing.Point(50, 700);
            this.EtiquetaLabel.Name = "EtiquetaLabel";
            this.EtiquetaLabel.Size = new System.Drawing.Size(66, 21);
            this.EtiquetaLabel.TabIndex = 92;
            this.EtiquetaLabel.Text = "Etiqueta";
            // 
            // CantidadEtiquetaLabel
            // 
            this.CantidadEtiquetaLabel.AutoSize = true;
            this.CantidadEtiquetaLabel.Location = new System.Drawing.Point(50, 750);
            this.CantidadEtiquetaLabel.Name = "CantidadEtiquetaLabel";
            this.CantidadEtiquetaLabel.Size = new System.Drawing.Size(72, 21);
            this.CantidadEtiquetaLabel.TabIndex = 91;
            this.CantidadEtiquetaLabel.Text = "Cantidad";
            // 
            // EtiquetaCombo
            // 
            this.EtiquetaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EtiquetaCombo.FormattingEnabled = true;
            this.EtiquetaCombo.Location = new System.Drawing.Point(200, 697);
            this.EtiquetaCombo.Name = "EtiquetaCombo";
            this.EtiquetaCombo.Size = new System.Drawing.Size(250, 29);
            this.EtiquetaCombo.TabIndex = 93;
            // 
            // CantidadEtiquetaText
            // 
            this.CantidadEtiquetaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadEtiquetaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadEtiquetaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadEtiquetaText.HideTrailingZeros = true;
            this.CantidadEtiquetaText.Location = new System.Drawing.Point(200, 747);
            this.CantidadEtiquetaText.MinValue = 0D;
            this.CantidadEtiquetaText.Name = "CantidadEtiquetaText";
            this.CantidadEtiquetaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadEtiquetaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadEtiquetaText.TabIndex = 94;
            this.CantidadEtiquetaText.Text = "0";
            this.CantidadEtiquetaText.WatermarkText = "Ingresa la cantidad";
            // 
            // ArrowButton
            // 
            this.ArrowButton.FlatAppearance.BorderSize = 0;
            this.ArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArrowButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowButton.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight;
            this.ArrowButton.IconColor = System.Drawing.Color.Black;
            this.ArrowButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ArrowButton.Location = new System.Drawing.Point(500, 200);
            this.ArrowButton.Name = "ArrowButton";
            this.ArrowButton.Size = new System.Drawing.Size(44, 36);
            this.ArrowButton.TabIndex = 95;
            this.ArrowButton.UseVisualStyleBackColor = true;
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
            this.MsgBox.Location = new System.Drawing.Point(550, 300);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 165);
            this.MsgBox.TabIndex = 108;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(892, 250);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 37);
            this.GuardarButton.TabIndex = 107;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
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
            this.CantidadSalidaText.TabIndex = 106;
            this.CantidadSalidaText.Text = "0";
            this.CantidadSalidaText.WatermarkText = "Ingresa la cantidad";
            // 
            // SalidaCombo
            // 
            this.SalidaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SalidaCombo.FormattingEnabled = true;
            this.SalidaCombo.Location = new System.Drawing.Point(720, 147);
            this.SalidaCombo.Name = "SalidaCombo";
            this.SalidaCombo.Size = new System.Drawing.Size(250, 29);
            this.SalidaCombo.TabIndex = 103;
            // 
            // CantidadSalidaLabel
            // 
            this.CantidadSalidaLabel.AutoSize = true;
            this.CantidadSalidaLabel.Location = new System.Drawing.Point(600, 200);
            this.CantidadSalidaLabel.Name = "CantidadSalidaLabel";
            this.CantidadSalidaLabel.Size = new System.Drawing.Size(72, 21);
            this.CantidadSalidaLabel.TabIndex = 98;
            this.CantidadSalidaLabel.Text = "Cantidad";
            // 
            // SalidaLabel
            // 
            this.SalidaLabel.AutoSize = true;
            this.SalidaLabel.Location = new System.Drawing.Point(600, 150);
            this.SalidaLabel.Name = "SalidaLabel";
            this.SalidaLabel.Size = new System.Drawing.Size(28, 21);
            this.SalidaLabel.TabIndex = 102;
            this.SalidaLabel.Text = "Kit";
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // RegistrarTrapeadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CantidadSalidaText);
            this.Controls.Add(this.SalidaCombo);
            this.Controls.Add(this.CantidadSalidaLabel);
            this.Controls.Add(this.SalidaLabel);
            this.Controls.Add(this.ArrowButton);
            this.Controls.Add(this.CantidadEtiquetaText);
            this.Controls.Add(this.CantidadMechaText);
            this.Controls.Add(this.CantidadAlambreText);
            this.Controls.Add(this.CantidadBolsaText);
            this.Controls.Add(this.CantidadBastónText);
            this.Controls.Add(this.EtiquetaCombo);
            this.Controls.Add(this.MechaCombo);
            this.Controls.Add(this.AlambreCombo);
            this.Controls.Add(this.BolsaCombo);
            this.Controls.Add(this.BastónCombo);
            this.Controls.Add(this.CantidadEtiquetaLabel);
            this.Controls.Add(this.CantidadMechaLabel);
            this.Controls.Add(this.CantidadAlambreLabel);
            this.Controls.Add(this.CantidadBolsaLabel);
            this.Controls.Add(this.CantidadBastónLabel);
            this.Controls.Add(this.EtiquetaLabel);
            this.Controls.Add(this.MechaLabel);
            this.Controls.Add(this.AlambreLabel);
            this.Controls.Add(this.BolsaLabel);
            this.Controls.Add(this.BastónLabel);
            this.Controls.Add(this.TurnoText);
            this.Controls.Add(this.MaquinaText);
            this.Controls.Add(this.FechaPicker);
            this.Controls.Add(this.OperadorCombo);
            this.Controls.Add(this.MaquinaLabel);
            this.Controls.Add(this.OperadorLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarTrapeadoresForm";
            this.Text = "RegistrarTrapeadoresForm";
            ((System.ComponentModel.ISupportInitialize)(this.TurnoText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaquinaText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.NumericUpDown TurnoText;
        private System.Windows.Forms.NumericUpDown MaquinaText;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaPicker;
        private System.Windows.Forms.ComboBox OperadorCombo;
        private System.Windows.Forms.Label MaquinaLabel;
        private System.Windows.Forms.Label OperadorLabel;
        private System.Windows.Forms.Label FechaLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadBastónText;
        private System.Windows.Forms.ComboBox BastónCombo;
        private System.Windows.Forms.Label CantidadBastónLabel;
        private System.Windows.Forms.Label BastónLabel;
        private System.Windows.Forms.Label AlambreLabel;
        private System.Windows.Forms.Label CantidadAlambreLabel;
        private System.Windows.Forms.ComboBox AlambreCombo;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadAlambreText;
        private System.Windows.Forms.Label BolsaLabel;
        private System.Windows.Forms.Label MechaLabel;
        private System.Windows.Forms.Label CantidadBolsaLabel;
        private System.Windows.Forms.Label CantidadMechaLabel;
        private System.Windows.Forms.ComboBox BolsaCombo;
        private System.Windows.Forms.ComboBox MechaCombo;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadBolsaText;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadMechaText;
        private System.Windows.Forms.Label EtiquetaLabel;
        private System.Windows.Forms.Label CantidadEtiquetaLabel;
        private System.Windows.Forms.ComboBox EtiquetaCombo;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadEtiquetaText;
        private FontAwesome.Sharp.IconButton ArrowButton;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadSalidaText;
        private System.Windows.Forms.ComboBox SalidaCombo;
        private System.Windows.Forms.Label CantidadSalidaLabel;
        private System.Windows.Forms.Label SalidaLabel;
        private System.Windows.Forms.Timer MsgBoxTimer;
    }
}