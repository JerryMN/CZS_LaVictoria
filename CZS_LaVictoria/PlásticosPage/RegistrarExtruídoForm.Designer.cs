
namespace CZS_LaVictoria.PlásticosPage
{
    partial class RegistrarExtruídoForm
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
            this.MsgBox = new FontAwesome.Sharp.IconButton();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MermaMolerText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MermaRealText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PesoPromText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CantidadSalidaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.SalidaCombo = new System.Windows.Forms.ComboBox();
            this.MermaMolerLabel = new System.Windows.Forms.Label();
            this.ArrowButton = new FontAwesome.Sharp.IconButton();
            this.MermaRealLabel = new System.Windows.Forms.Label();
            this.CantidadEntradaUnidad = new System.Windows.Forms.Label();
            this.MermaRealUnidad = new System.Windows.Forms.Label();
            this.MermaMolerUnidad = new System.Windows.Forms.Label();
            this.PesoPromUnidad = new System.Windows.Forms.Label();
            this.PesoPromLabel = new System.Windows.Forms.Label();
            this.CantidadSalidaLabel = new System.Windows.Forms.Label();
            this.SalidaLabel = new System.Windows.Forms.Label();
            this.CantidadEntradaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.EntradaCombo = new System.Windows.Forms.ComboBox();
            this.CantidadEntradaLabel = new System.Windows.Forms.Label();
            this.EntradaLabel = new System.Windows.Forms.Label();
            this.TurnoText = new System.Windows.Forms.NumericUpDown();
            this.MaquinaText = new System.Windows.Forms.NumericUpDown();
            this.FechaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.OperadorCombo = new System.Windows.Forms.ComboBox();
            this.MaquinaLabel = new System.Windows.Forms.Label();
            this.OperadorLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.MezclaRadio = new System.Windows.Forms.RadioButton();
            this.MaterialRadio = new System.Windows.Forms.RadioButton();
            this.CalcularButton = new System.Windows.Forms.Button();
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
            this.SubtitleLabel.Size = new System.Drawing.Size(265, 37);
            this.SubtitleLabel.TabIndex = 31;
            this.SubtitleLabel.Text = "Registro de Extruído";
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
            this.MsgBox.Size = new System.Drawing.Size(420, 157);
            this.MsgBox.TabIndex = 69;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(892, 400);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 35);
            this.GuardarButton.TabIndex = 68;
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
            this.MermaMolerText.TabIndex = 65;
            this.MermaMolerText.WatermarkText = "Calculado automáticamente";
            this.MermaMolerText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // MermaRealText
            // 
            this.MermaRealText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MermaRealText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MermaRealText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MermaRealText.Location = new System.Drawing.Point(720, 347);
            this.MermaRealText.MinValue = 0D;
            this.MermaRealText.Name = "MermaRealText";
            this.MermaRealText.ReadOnly = true;
            this.MermaRealText.Size = new System.Drawing.Size(250, 29);
            this.MermaRealText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MermaRealText.TabIndex = 64;
            this.MermaRealText.WatermarkText = "Calculado automáticamente";
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
            this.PesoPromText.TabIndex = 67;
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
            this.CantidadSalidaText.TabIndex = 66;
            this.CantidadSalidaText.Text = "0";
            this.CantidadSalidaText.WatermarkText = "Ingresa la cantidad";
            this.CantidadSalidaText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // SalidaCombo
            // 
            this.SalidaCombo.FormattingEnabled = true;
            this.SalidaCombo.Location = new System.Drawing.Point(720, 147);
            this.SalidaCombo.Name = "SalidaCombo";
            this.SalidaCombo.Size = new System.Drawing.Size(250, 28);
            this.SalidaCombo.TabIndex = 63;
            this.SalidaCombo.SelectedIndexChanged += new System.EventHandler(this.SalidaCombo_SelectedIndexChanged);
            this.SalidaCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // MermaMolerLabel
            // 
            this.MermaMolerLabel.AutoSize = true;
            this.MermaMolerLabel.Location = new System.Drawing.Point(600, 300);
            this.MermaMolerLabel.Name = "MermaMolerLabel";
            this.MermaMolerLabel.Size = new System.Drawing.Size(114, 20);
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
            this.ArrowButton.Location = new System.Drawing.Point(500, 200);
            this.ArrowButton.Name = "ArrowButton";
            this.ArrowButton.Size = new System.Drawing.Size(44, 34);
            this.ArrowButton.TabIndex = 62;
            this.ArrowButton.UseVisualStyleBackColor = true;
            // 
            // MermaRealLabel
            // 
            this.MermaRealLabel.AutoSize = true;
            this.MermaRealLabel.Location = new System.Drawing.Point(600, 350);
            this.MermaRealLabel.Name = "MermaRealLabel";
            this.MermaRealLabel.Size = new System.Drawing.Size(95, 20);
            this.MermaRealLabel.TabIndex = 54;
            this.MermaRealLabel.Text = "Merma Real";
            // 
            // CantidadEntradaUnidad
            // 
            this.CantidadEntradaUnidad.AutoSize = true;
            this.CantidadEntradaUnidad.Location = new System.Drawing.Point(456, 400);
            this.CantidadEntradaUnidad.Name = "CantidadEntradaUnidad";
            this.CantidadEntradaUnidad.Size = new System.Drawing.Size(26, 20);
            this.CantidadEntradaUnidad.TabIndex = 60;
            this.CantidadEntradaUnidad.Text = "kg";
            // 
            // MermaRealUnidad
            // 
            this.MermaRealUnidad.AutoSize = true;
            this.MermaRealUnidad.Location = new System.Drawing.Point(976, 350);
            this.MermaRealUnidad.Name = "MermaRealUnidad";
            this.MermaRealUnidad.Size = new System.Drawing.Size(26, 20);
            this.MermaRealUnidad.TabIndex = 59;
            this.MermaRealUnidad.Text = "kg";
            // 
            // MermaMolerUnidad
            // 
            this.MermaMolerUnidad.AutoSize = true;
            this.MermaMolerUnidad.Location = new System.Drawing.Point(976, 300);
            this.MermaMolerUnidad.Name = "MermaMolerUnidad";
            this.MermaMolerUnidad.Size = new System.Drawing.Size(26, 20);
            this.MermaMolerUnidad.TabIndex = 58;
            this.MermaMolerUnidad.Text = "kg";
            // 
            // PesoPromUnidad
            // 
            this.PesoPromUnidad.AutoSize = true;
            this.PesoPromUnidad.Location = new System.Drawing.Point(976, 250);
            this.PesoPromUnidad.Name = "PesoPromUnidad";
            this.PesoPromUnidad.Size = new System.Drawing.Size(26, 20);
            this.PesoPromUnidad.TabIndex = 57;
            this.PesoPromUnidad.Text = "kg";
            // 
            // PesoPromLabel
            // 
            this.PesoPromLabel.AutoSize = true;
            this.PesoPromLabel.Location = new System.Drawing.Point(600, 250);
            this.PesoPromLabel.Name = "PesoPromLabel";
            this.PesoPromLabel.Size = new System.Drawing.Size(90, 20);
            this.PesoPromLabel.TabIndex = 56;
            this.PesoPromLabel.Text = "Peso Prom.";
            // 
            // CantidadSalidaLabel
            // 
            this.CantidadSalidaLabel.AutoSize = true;
            this.CantidadSalidaLabel.Location = new System.Drawing.Point(600, 200);
            this.CantidadSalidaLabel.Name = "CantidadSalidaLabel";
            this.CantidadSalidaLabel.Size = new System.Drawing.Size(115, 20);
            this.CantidadSalidaLabel.TabIndex = 55;
            this.CantidadSalidaLabel.Text = "Mazos Buenos";
            // 
            // SalidaLabel
            // 
            this.SalidaLabel.AutoSize = true;
            this.SalidaLabel.Location = new System.Drawing.Point(600, 150);
            this.SalidaLabel.Name = "SalidaLabel";
            this.SalidaLabel.Size = new System.Drawing.Size(48, 20);
            this.SalidaLabel.TabIndex = 61;
            this.SalidaLabel.Text = "Mazo";
            // 
            // CantidadEntradaText
            // 
            this.CantidadEntradaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadEntradaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadEntradaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadEntradaText.Location = new System.Drawing.Point(200, 397);
            this.CantidadEntradaText.MinValue = 0D;
            this.CantidadEntradaText.Name = "CantidadEntradaText";
            this.CantidadEntradaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadEntradaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadEntradaText.TabIndex = 52;
            this.CantidadEntradaText.WatermarkText = "Ingresa la cantidad";
            this.CantidadEntradaText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // EntradaCombo
            // 
            this.EntradaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntradaCombo.FormattingEnabled = true;
            this.EntradaCombo.Location = new System.Drawing.Point(200, 347);
            this.EntradaCombo.Name = "EntradaCombo";
            this.EntradaCombo.Size = new System.Drawing.Size(250, 28);
            this.EntradaCombo.TabIndex = 51;
            this.EntradaCombo.SelectedIndexChanged += new System.EventHandler(this.EntradaCombo_SelectedIndexChanged);
            this.EntradaCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CantidadEntradaLabel
            // 
            this.CantidadEntradaLabel.AutoSize = true;
            this.CantidadEntradaLabel.Location = new System.Drawing.Point(50, 400);
            this.CantidadEntradaLabel.Name = "CantidadEntradaLabel";
            this.CantidadEntradaLabel.Size = new System.Drawing.Size(73, 20);
            this.CantidadEntradaLabel.TabIndex = 49;
            this.CantidadEntradaLabel.Text = "Cantidad";
            // 
            // EntradaLabel
            // 
            this.EntradaLabel.AutoSize = true;
            this.EntradaLabel.Location = new System.Drawing.Point(50, 350);
            this.EntradaLabel.Name = "EntradaLabel";
            this.EntradaLabel.Size = new System.Drawing.Size(132, 20);
            this.EntradaLabel.TabIndex = 50;
            this.EntradaLabel.Text = "Mezcla o Material";
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
            this.TurnoText.Size = new System.Drawing.Size(120, 26);
            this.TurnoText.TabIndex = 75;
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
            this.MaquinaText.Size = new System.Drawing.Size(120, 26);
            this.MaquinaText.TabIndex = 76;
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
            this.FechaPicker.Size = new System.Drawing.Size(250, 31);
            this.FechaPicker.TabIndex = 74;
            // 
            // OperadorCombo
            // 
            this.OperadorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperadorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorCombo.FormattingEnabled = true;
            this.OperadorCombo.Location = new System.Drawing.Point(200, 197);
            this.OperadorCombo.Name = "OperadorCombo";
            this.OperadorCombo.Size = new System.Drawing.Size(250, 29);
            this.OperadorCombo.TabIndex = 73;
            // 
            // MaquinaLabel
            // 
            this.MaquinaLabel.AutoSize = true;
            this.MaquinaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaquinaLabel.Location = new System.Drawing.Point(50, 250);
            this.MaquinaLabel.Name = "MaquinaLabel";
            this.MaquinaLabel.Size = new System.Drawing.Size(126, 21);
            this.MaquinaLabel.TabIndex = 70;
            this.MaquinaLabel.Text = "Máquina / Turno";
            // 
            // OperadorLabel
            // 
            this.OperadorLabel.AutoSize = true;
            this.OperadorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorLabel.Location = new System.Drawing.Point(50, 200);
            this.OperadorLabel.Name = "OperadorLabel";
            this.OperadorLabel.Size = new System.Drawing.Size(77, 21);
            this.OperadorLabel.TabIndex = 71;
            this.OperadorLabel.Text = "Operador";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(50, 150);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(144, 21);
            this.FechaLabel.TabIndex = 72;
            this.FechaLabel.Text = "Fecha de operación";
            // 
            // MezclaRadio
            // 
            this.MezclaRadio.AutoSize = true;
            this.MezclaRadio.Location = new System.Drawing.Point(200, 300);
            this.MezclaRadio.Name = "MezclaRadio";
            this.MezclaRadio.Size = new System.Drawing.Size(77, 24);
            this.MezclaRadio.TabIndex = 77;
            this.MezclaRadio.TabStop = true;
            this.MezclaRadio.Text = "Mezcla";
            this.MezclaRadio.UseVisualStyleBackColor = true;
            this.MezclaRadio.CheckedChanged += new System.EventHandler(this.RadioButton_Changed);
            // 
            // MaterialRadio
            // 
            this.MaterialRadio.AutoSize = true;
            this.MaterialRadio.Location = new System.Drawing.Point(308, 300);
            this.MaterialRadio.Name = "MaterialRadio";
            this.MaterialRadio.Size = new System.Drawing.Size(142, 24);
            this.MaterialRadio.TabIndex = 77;
            this.MaterialRadio.TabStop = true;
            this.MaterialRadio.Text = "Material Sencillo";
            this.MaterialRadio.UseVisualStyleBackColor = true;
            this.MaterialRadio.CheckedChanged += new System.EventHandler(this.RadioButton_Changed);
            // 
            // CalcularButton
            // 
            this.CalcularButton.AutoSize = true;
            this.CalcularButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(808, 400);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(78, 35);
            this.CalcularButton.TabIndex = 78;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            // 
            // RegistrarExtruídoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.MaterialRadio);
            this.Controls.Add(this.MezclaRadio);
            this.Controls.Add(this.TurnoText);
            this.Controls.Add(this.MaquinaText);
            this.Controls.Add(this.FechaPicker);
            this.Controls.Add(this.OperadorCombo);
            this.Controls.Add(this.MaquinaLabel);
            this.Controls.Add(this.OperadorLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.MermaMolerText);
            this.Controls.Add(this.MermaRealText);
            this.Controls.Add(this.PesoPromText);
            this.Controls.Add(this.CantidadSalidaText);
            this.Controls.Add(this.SalidaCombo);
            this.Controls.Add(this.MermaMolerLabel);
            this.Controls.Add(this.ArrowButton);
            this.Controls.Add(this.MermaRealLabel);
            this.Controls.Add(this.CantidadEntradaUnidad);
            this.Controls.Add(this.MermaRealUnidad);
            this.Controls.Add(this.MermaMolerUnidad);
            this.Controls.Add(this.PesoPromUnidad);
            this.Controls.Add(this.PesoPromLabel);
            this.Controls.Add(this.CantidadSalidaLabel);
            this.Controls.Add(this.SalidaLabel);
            this.Controls.Add(this.CantidadEntradaText);
            this.Controls.Add(this.EntradaCombo);
            this.Controls.Add(this.CantidadEntradaLabel);
            this.Controls.Add(this.EntradaLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarExtruídoForm";
            this.Text = "RegistrarExtrusiónForm";
            ((System.ComponentModel.ISupportInitialize)(this.TurnoText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaquinaText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfNumericTextBox MermaMolerText;
        private Syncfusion.WinForms.Input.SfNumericTextBox MermaRealText;
        private Syncfusion.WinForms.Input.SfNumericTextBox PesoPromText;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadSalidaText;
        private System.Windows.Forms.ComboBox SalidaCombo;
        private System.Windows.Forms.Label MermaMolerLabel;
        private FontAwesome.Sharp.IconButton ArrowButton;
        private System.Windows.Forms.Label MermaRealLabel;
        private System.Windows.Forms.Label CantidadEntradaUnidad;
        private System.Windows.Forms.Label MermaRealUnidad;
        private System.Windows.Forms.Label MermaMolerUnidad;
        private System.Windows.Forms.Label PesoPromUnidad;
        private System.Windows.Forms.Label PesoPromLabel;
        private System.Windows.Forms.Label CantidadSalidaLabel;
        private System.Windows.Forms.Label SalidaLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadEntradaText;
        private System.Windows.Forms.ComboBox EntradaCombo;
        private System.Windows.Forms.Label CantidadEntradaLabel;
        private System.Windows.Forms.Label EntradaLabel;
        private System.Windows.Forms.NumericUpDown TurnoText;
        private System.Windows.Forms.NumericUpDown MaquinaText;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaPicker;
        private System.Windows.Forms.ComboBox OperadorCombo;
        private System.Windows.Forms.Label MaquinaLabel;
        private System.Windows.Forms.Label OperadorLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.RadioButton MezclaRadio;
        private System.Windows.Forms.RadioButton MaterialRadio;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Timer MsgBoxTimer;
    }
}