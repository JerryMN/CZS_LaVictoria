
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
            this.MermaRealText = new Syncfusion.WinForms.Input.SfNumericTextBox();
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
            this.CantidadUnidad = new System.Windows.Forms.Label();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.TurnoText = new System.Windows.Forms.NumericUpDown();
            this.FechaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.OperadorCombo = new System.Windows.Forms.ComboBox();
            this.MaquinaLabel = new System.Windows.Forms.Label();
            this.OperadorLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.CantidadEntradaUnidad = new System.Windows.Forms.Label();
            this.CantidadEntradaLabel = new System.Windows.Forms.Label();
            this.CantidadEntradaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MáquinaCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TurnoText)).BeginInit();
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
            this.MsgBox.TabIndex = 34;
            this.MsgBox.TabStop = false;
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
            this.CalcularButton.TabIndex = 32;
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
            this.GuardarButton.TabIndex = 33;
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
            this.MermaMolerText.TabIndex = 27;
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
            this.MermaRealText.TabIndex = 30;
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
            this.PesoPromText.TabIndex = 23;
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
            this.CantidadSalidaText.TabIndex = 21;
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
            this.SalidaCombo.TabIndex = 19;
            this.SalidaCombo.SelectedIndexChanged += new System.EventHandler(this.SalidaCombo_SelectedIndexChanged);
            this.SalidaCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // MermaMolerLabel
            // 
            this.MermaMolerLabel.AutoSize = true;
            this.MermaMolerLabel.Location = new System.Drawing.Point(600, 300);
            this.MermaMolerLabel.Name = "MermaMolerLabel";
            this.MermaMolerLabel.Size = new System.Drawing.Size(117, 21);
            this.MermaMolerLabel.TabIndex = 26;
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
            this.ArrowButton.TabIndex = 25;
            this.ArrowButton.TabStop = false;
            this.ArrowButton.UseVisualStyleBackColor = true;
            // 
            // MermaRealLabel
            // 
            this.MermaRealLabel.AutoSize = true;
            this.MermaRealLabel.Location = new System.Drawing.Point(600, 350);
            this.MermaRealLabel.Name = "MermaRealLabel";
            this.MermaRealLabel.Size = new System.Drawing.Size(94, 21);
            this.MermaRealLabel.TabIndex = 29;
            this.MermaRealLabel.Text = "Merma Real";
            // 
            // MermaRealUnidad
            // 
            this.MermaRealUnidad.AutoSize = true;
            this.MermaRealUnidad.Location = new System.Drawing.Point(976, 350);
            this.MermaRealUnidad.Name = "MermaRealUnidad";
            this.MermaRealUnidad.Size = new System.Drawing.Size(27, 21);
            this.MermaRealUnidad.TabIndex = 31;
            this.MermaRealUnidad.Text = "kg";
            // 
            // MermaMolerUnidad
            // 
            this.MermaMolerUnidad.AutoSize = true;
            this.MermaMolerUnidad.Location = new System.Drawing.Point(976, 300);
            this.MermaMolerUnidad.Name = "MermaMolerUnidad";
            this.MermaMolerUnidad.Size = new System.Drawing.Size(27, 21);
            this.MermaMolerUnidad.TabIndex = 28;
            this.MermaMolerUnidad.Text = "kg";
            // 
            // PesoPromUnidad
            // 
            this.PesoPromUnidad.AutoSize = true;
            this.PesoPromUnidad.Location = new System.Drawing.Point(976, 250);
            this.PesoPromUnidad.Name = "PesoPromUnidad";
            this.PesoPromUnidad.Size = new System.Drawing.Size(63, 21);
            this.PesoPromUnidad.TabIndex = 24;
            this.PesoPromUnidad.Text = "gramos";
            // 
            // PesoPromLabel
            // 
            this.PesoPromLabel.AutoSize = true;
            this.PesoPromLabel.Location = new System.Drawing.Point(600, 250);
            this.PesoPromLabel.Name = "PesoPromLabel";
            this.PesoPromLabel.Size = new System.Drawing.Size(94, 21);
            this.PesoPromLabel.TabIndex = 22;
            this.PesoPromLabel.Text = "Peso Prom.*";
            // 
            // CantidadSalidaLabel
            // 
            this.CantidadSalidaLabel.AutoSize = true;
            this.CantidadSalidaLabel.Location = new System.Drawing.Point(600, 200);
            this.CantidadSalidaLabel.Name = "CantidadSalidaLabel";
            this.CantidadSalidaLabel.Size = new System.Drawing.Size(114, 21);
            this.CantidadSalidaLabel.TabIndex = 20;
            this.CantidadSalidaLabel.Text = "Piezas Buenas*";
            // 
            // SalidaLabel
            // 
            this.SalidaLabel.AutoSize = true;
            this.SalidaLabel.Location = new System.Drawing.Point(600, 150);
            this.SalidaLabel.Name = "SalidaLabel";
            this.SalidaLabel.Size = new System.Drawing.Size(80, 21);
            this.SalidaLabel.TabIndex = 18;
            this.SalidaLabel.Text = "Producto*";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(279, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Registro de Inyección";
            // 
            // EliminarButton
            // 
            this.EliminarButton.AutoSize = true;
            this.EliminarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(366, 700);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(84, 33);
            this.EliminarButton.TabIndex = 17;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.AutoSize = true;
            this.AgregarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Location = new System.Drawing.Point(366, 450);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(84, 33);
            this.AgregarButton.TabIndex = 16;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // CantidadesListBox
            // 
            this.CantidadesListBox.FormattingEnabled = true;
            this.CantidadesListBox.ItemHeight = 21;
            this.CantidadesListBox.Location = new System.Drawing.Point(366, 500);
            this.CantidadesListBox.Name = "CantidadesListBox";
            this.CantidadesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CantidadesListBox.Size = new System.Drawing.Size(84, 193);
            this.CantidadesListBox.TabIndex = 36;
            this.CantidadesListBox.TabStop = false;
            // 
            // MaterialesListBox
            // 
            this.MaterialesListBox.FormattingEnabled = true;
            this.MaterialesListBox.ItemHeight = 21;
            this.MaterialesListBox.Location = new System.Drawing.Point(56, 500);
            this.MaterialesListBox.Name = "MaterialesListBox";
            this.MaterialesListBox.Size = new System.Drawing.Size(304, 193);
            this.MaterialesListBox.TabIndex = 35;
            this.MaterialesListBox.TabStop = false;
            // 
            // CantidadText
            // 
            this.CantidadText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadText.Location = new System.Drawing.Point(200, 397);
            this.CantidadText.MinValue = 0D;
            this.CantidadText.Name = "CantidadText";
            this.CantidadText.Size = new System.Drawing.Size(250, 29);
            this.CantidadText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadText.TabIndex = 14;
            this.CantidadText.WatermarkText = "Ingresa la cantidad";
            this.CantidadText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(50, 400);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(79, 21);
            this.Cantidad.TabIndex = 13;
            this.Cantidad.Text = "Cantidad*";
            // 
            // MaterialCombo
            // 
            this.MaterialCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MaterialCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MaterialCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialCombo.FormattingEnabled = true;
            this.MaterialCombo.Location = new System.Drawing.Point(200, 347);
            this.MaterialCombo.Name = "MaterialCombo";
            this.MaterialCombo.Size = new System.Drawing.Size(250, 29);
            this.MaterialCombo.TabIndex = 12;
            this.MaterialCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLabel.Location = new System.Drawing.Point(50, 350);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(74, 21);
            this.MaterialLabel.TabIndex = 11;
            this.MaterialLabel.Text = "Material*";
            // 
            // CantidadUnidad
            // 
            this.CantidadUnidad.AutoSize = true;
            this.CantidadUnidad.Location = new System.Drawing.Point(455, 400);
            this.CantidadUnidad.Name = "CantidadUnidad";
            this.CantidadUnidad.Size = new System.Drawing.Size(27, 21);
            this.CantidadUnidad.TabIndex = 15;
            this.CantidadUnidad.Text = "kg";
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
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
            this.TurnoText.TabIndex = 7;
            this.TurnoText.Value = new decimal(new int[] {
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
            this.FechaPicker.TabIndex = 1;
            // 
            // OperadorCombo
            // 
            this.OperadorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperadorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorCombo.FormattingEnabled = true;
            this.OperadorCombo.Location = new System.Drawing.Point(200, 197);
            this.OperadorCombo.Name = "OperadorCombo";
            this.OperadorCombo.Size = new System.Drawing.Size(250, 29);
            this.OperadorCombo.TabIndex = 4;
            // 
            // MaquinaLabel
            // 
            this.MaquinaLabel.AutoSize = true;
            this.MaquinaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaquinaLabel.Location = new System.Drawing.Point(50, 250);
            this.MaquinaLabel.Name = "MaquinaLabel";
            this.MaquinaLabel.Size = new System.Drawing.Size(140, 21);
            this.MaquinaLabel.TabIndex = 5;
            this.MaquinaLabel.Text = "Máquina* / Turno*";
            // 
            // OperadorLabel
            // 
            this.OperadorLabel.AutoSize = true;
            this.OperadorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorLabel.Location = new System.Drawing.Point(50, 200);
            this.OperadorLabel.Name = "OperadorLabel";
            this.OperadorLabel.Size = new System.Drawing.Size(84, 21);
            this.OperadorLabel.TabIndex = 3;
            this.OperadorLabel.Text = "Operador*";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(50, 150);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(151, 21);
            this.FechaLabel.TabIndex = 2;
            this.FechaLabel.Text = "Fecha de operación*";
            // 
            // CantidadEntradaUnidad
            // 
            this.CantidadEntradaUnidad.AutoSize = true;
            this.CantidadEntradaUnidad.Location = new System.Drawing.Point(455, 300);
            this.CantidadEntradaUnidad.Name = "CantidadEntradaUnidad";
            this.CantidadEntradaUnidad.Size = new System.Drawing.Size(27, 21);
            this.CantidadEntradaUnidad.TabIndex = 10;
            this.CantidadEntradaUnidad.Text = "kg";
            // 
            // CantidadEntradaLabel
            // 
            this.CantidadEntradaLabel.AutoSize = true;
            this.CantidadEntradaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadEntradaLabel.Location = new System.Drawing.Point(50, 300);
            this.CantidadEntradaLabel.Name = "CantidadEntradaLabel";
            this.CantidadEntradaLabel.Size = new System.Drawing.Size(122, 21);
            this.CantidadEntradaLabel.TabIndex = 8;
            this.CantidadEntradaLabel.Text = "Total de Mezcla*";
            // 
            // CantidadEntradaText
            // 
            this.CantidadEntradaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadEntradaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadEntradaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadEntradaText.Location = new System.Drawing.Point(200, 297);
            this.CantidadEntradaText.MinValue = 0D;
            this.CantidadEntradaText.Name = "CantidadEntradaText";
            this.CantidadEntradaText.Size = new System.Drawing.Size(250, 29);
            this.CantidadEntradaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadEntradaText.TabIndex = 9;
            this.CantidadEntradaText.WatermarkText = "Ingresa la cantidad";
            this.CantidadEntradaText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // MáquinaCombo
            // 
            this.MáquinaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MáquinaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MáquinaCombo.FormattingEnabled = true;
            this.MáquinaCombo.Location = new System.Drawing.Point(200, 247);
            this.MáquinaCombo.Name = "MáquinaCombo";
            this.MáquinaCombo.Size = new System.Drawing.Size(124, 29);
            this.MáquinaCombo.TabIndex = 6;
            // 
            // RegistrarInyecciónForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.MáquinaCombo);
            this.Controls.Add(this.TurnoText);
            this.Controls.Add(this.FechaPicker);
            this.Controls.Add(this.OperadorCombo);
            this.Controls.Add(this.MaquinaLabel);
            this.Controls.Add(this.OperadorLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.CantidadesListBox);
            this.Controls.Add(this.MaterialesListBox);
            this.Controls.Add(this.CantidadEntradaText);
            this.Controls.Add(this.CantidadText);
            this.Controls.Add(this.CantidadEntradaLabel);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.MaterialCombo);
            this.Controls.Add(this.CantidadEntradaUnidad);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.CantidadUnidad);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.MermaMolerText);
            this.Controls.Add(this.MermaRealText);
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
            ((System.ComponentModel.ISupportInitialize)(this.TurnoText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfNumericTextBox MermaMolerText;
        private Syncfusion.WinForms.Input.SfNumericTextBox MermaRealText;
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
        private System.Windows.Forms.Label CantidadUnidad;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.NumericUpDown TurnoText;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaPicker;
        private System.Windows.Forms.ComboBox OperadorCombo;
        private System.Windows.Forms.Label MaquinaLabel;
        private System.Windows.Forms.Label OperadorLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label CantidadEntradaUnidad;
        private System.Windows.Forms.Label CantidadEntradaLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadEntradaText;
        private System.Windows.Forms.ComboBox MáquinaCombo;
    }
}