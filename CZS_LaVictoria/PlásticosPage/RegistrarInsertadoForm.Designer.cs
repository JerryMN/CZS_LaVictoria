
namespace CZS_LaVictoria.PlásticosPage
{
    partial class RegistrarInsertadoForm
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
            this.MermaBasesText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PiezasMalasText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PiezasBuenasText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.SalidaCombo = new System.Windows.Forms.ComboBox();
            this.ArrowButton = new FontAwesome.Sharp.IconButton();
            this.MermaBasesLabel = new System.Windows.Forms.Label();
            this.MermaRealUnidad = new System.Windows.Forms.Label();
            this.PiezasMalasLabel = new System.Windows.Forms.Label();
            this.PiezasBuenasLabel = new System.Windows.Forms.Label();
            this.SalidaLabel = new System.Windows.Forms.Label();
            this.CantidadBaseText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.BaseCombo = new System.Windows.Forms.ComboBox();
            this.CantidadBaseLabel = new System.Windows.Forms.Label();
            this.BaseLabel = new System.Windows.Forms.Label();
            this.CantidadFibraUnidad = new System.Windows.Forms.Label();
            this.CantidadFibraText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.FibraCombo = new System.Windows.Forms.ComboBox();
            this.CantidadFibraLabel = new System.Windows.Forms.Label();
            this.FibraLabel = new System.Windows.Forms.Label();
            this.CantidadAlambreLabel = new System.Windows.Forms.Label();
            this.CantidadAlambreText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.RebabaUnidad = new System.Windows.Forms.Label();
            this.MermaFibraLabel = new System.Windows.Forms.Label();
            this.MermaFibraText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.TurnoText = new System.Windows.Forms.NumericUpDown();
            this.FechaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.OperadorCombo = new System.Windows.Forms.ComboBox();
            this.MaquinaLabel = new System.Windows.Forms.Label();
            this.OperadorLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.TipoAlambreLabel = new System.Windows.Forms.Label();
            this.TipoAlambreCombo = new System.Windows.Forms.ComboBox();
            this.TipoCajaLabel = new System.Windows.Forms.Label();
            this.TipoCajaCombo = new System.Windows.Forms.ComboBox();
            this.CantidadCajasLabel = new System.Windows.Forms.Label();
            this.CantidadCajasText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MáquinaCombo = new System.Windows.Forms.ComboBox();
            this.CantidadAlambreUnidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TurnoText)).BeginInit();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(279, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Registro de Insertado";
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
            this.MsgBox.Size = new System.Drawing.Size(420, 262);
            this.MsgBox.TabIndex = 40;
            this.MsgBox.TabStop = false;
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
            this.GuardarButton.TabIndex = 39;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MermaBasesText
            // 
            this.MermaBasesText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MermaBasesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MermaBasesText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MermaBasesText.Location = new System.Drawing.Point(720, 297);
            this.MermaBasesText.MinValue = 0D;
            this.MermaBasesText.Name = "MermaBasesText";
            this.MermaBasesText.Size = new System.Drawing.Size(250, 29);
            this.MermaBasesText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MermaBasesText.TabIndex = 33;
            this.MermaBasesText.WatermarkText = "Calculado automáticamente";
            this.MermaBasesText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // PiezasMalasText
            // 
            this.PiezasMalasText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PiezasMalasText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiezasMalasText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PiezasMalasText.HideTrailingZeros = true;
            this.PiezasMalasText.Location = new System.Drawing.Point(720, 247);
            this.PiezasMalasText.MinValue = 0D;
            this.PiezasMalasText.Name = "PiezasMalasText";
            this.PiezasMalasText.Size = new System.Drawing.Size(250, 29);
            this.PiezasMalasText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PiezasMalasText.TabIndex = 31;
            this.PiezasMalasText.Text = "0";
            this.PiezasMalasText.WatermarkText = "Ingresa la cantidad";
            this.PiezasMalasText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // PiezasBuenasText
            // 
            this.PiezasBuenasText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PiezasBuenasText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiezasBuenasText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PiezasBuenasText.HideTrailingZeros = true;
            this.PiezasBuenasText.Location = new System.Drawing.Point(720, 197);
            this.PiezasBuenasText.MinValue = 0D;
            this.PiezasBuenasText.Name = "PiezasBuenasText";
            this.PiezasBuenasText.Size = new System.Drawing.Size(250, 29);
            this.PiezasBuenasText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PiezasBuenasText.TabIndex = 29;
            this.PiezasBuenasText.Text = "0";
            this.PiezasBuenasText.WatermarkText = "Ingresa la cantidad";
            this.PiezasBuenasText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // SalidaCombo
            // 
            this.SalidaCombo.FormattingEnabled = true;
            this.SalidaCombo.Location = new System.Drawing.Point(720, 147);
            this.SalidaCombo.Name = "SalidaCombo";
            this.SalidaCombo.Size = new System.Drawing.Size(250, 29);
            this.SalidaCombo.TabIndex = 26;
            this.SalidaCombo.SelectedIndexChanged += new System.EventHandler(this.SalidaCombo_SelectedIndexChanged);
            this.SalidaCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
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
            this.ArrowButton.TabIndex = 27;
            this.ArrowButton.TabStop = false;
            this.ArrowButton.UseVisualStyleBackColor = true;
            // 
            // MermaBasesLabel
            // 
            this.MermaBasesLabel.AutoSize = true;
            this.MermaBasesLabel.Location = new System.Drawing.Point(600, 300);
            this.MermaBasesLabel.Name = "MermaBasesLabel";
            this.MermaBasesLabel.Size = new System.Drawing.Size(103, 21);
            this.MermaBasesLabel.TabIndex = 32;
            this.MermaBasesLabel.Text = "Merma Bases";
            // 
            // MermaRealUnidad
            // 
            this.MermaRealUnidad.AutoSize = true;
            this.MermaRealUnidad.Location = new System.Drawing.Point(976, 300);
            this.MermaRealUnidad.Name = "MermaRealUnidad";
            this.MermaRealUnidad.Size = new System.Drawing.Size(27, 21);
            this.MermaRealUnidad.TabIndex = 34;
            this.MermaRealUnidad.Text = "kg";
            // 
            // PiezasMalasLabel
            // 
            this.PiezasMalasLabel.AutoSize = true;
            this.PiezasMalasLabel.Location = new System.Drawing.Point(600, 250);
            this.PiezasMalasLabel.Name = "PiezasMalasLabel";
            this.PiezasMalasLabel.Size = new System.Drawing.Size(98, 21);
            this.PiezasMalasLabel.TabIndex = 30;
            this.PiezasMalasLabel.Text = "Piezas Malas";
            // 
            // PiezasBuenasLabel
            // 
            this.PiezasBuenasLabel.AutoSize = true;
            this.PiezasBuenasLabel.Location = new System.Drawing.Point(600, 200);
            this.PiezasBuenasLabel.Name = "PiezasBuenasLabel";
            this.PiezasBuenasLabel.Size = new System.Drawing.Size(114, 21);
            this.PiezasBuenasLabel.TabIndex = 28;
            this.PiezasBuenasLabel.Text = "Piezas Buenas*";
            // 
            // SalidaLabel
            // 
            this.SalidaLabel.AutoSize = true;
            this.SalidaLabel.Location = new System.Drawing.Point(600, 150);
            this.SalidaLabel.Name = "SalidaLabel";
            this.SalidaLabel.Size = new System.Drawing.Size(80, 21);
            this.SalidaLabel.TabIndex = 25;
            this.SalidaLabel.Text = "Producto*";
            // 
            // CantidadBaseText
            // 
            this.CantidadBaseText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadBaseText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadBaseText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadBaseText.HideTrailingZeros = true;
            this.CantidadBaseText.Location = new System.Drawing.Point(200, 347);
            this.CantidadBaseText.MinValue = 0D;
            this.CantidadBaseText.Name = "CantidadBaseText";
            this.CantidadBaseText.Size = new System.Drawing.Size(250, 29);
            this.CantidadBaseText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadBaseText.TabIndex = 11;
            this.CantidadBaseText.Text = "0";
            this.CantidadBaseText.WatermarkText = "Ingresa la cantidad";
            this.CantidadBaseText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // BaseCombo
            // 
            this.BaseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaseCombo.FormattingEnabled = true;
            this.BaseCombo.Location = new System.Drawing.Point(200, 297);
            this.BaseCombo.Name = "BaseCombo";
            this.BaseCombo.Size = new System.Drawing.Size(250, 29);
            this.BaseCombo.TabIndex = 9;
            this.BaseCombo.SelectedIndexChanged += new System.EventHandler(this.BaseCombo_SelectedIndexChanged);
            this.BaseCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CantidadBaseLabel
            // 
            this.CantidadBaseLabel.AutoSize = true;
            this.CantidadBaseLabel.Location = new System.Drawing.Point(50, 350);
            this.CantidadBaseLabel.Name = "CantidadBaseLabel";
            this.CantidadBaseLabel.Size = new System.Drawing.Size(119, 21);
            this.CantidadBaseLabel.TabIndex = 10;
            this.CantidadBaseLabel.Text = "Núm. de Bases*";
            // 
            // BaseLabel
            // 
            this.BaseLabel.AutoSize = true;
            this.BaseLabel.Location = new System.Drawing.Point(50, 300);
            this.BaseLabel.Name = "BaseLabel";
            this.BaseLabel.Size = new System.Drawing.Size(49, 21);
            this.BaseLabel.TabIndex = 8;
            this.BaseLabel.Text = "Base*";
            // 
            // CantidadFibraUnidad
            // 
            this.CantidadFibraUnidad.AutoSize = true;
            this.CantidadFibraUnidad.Location = new System.Drawing.Point(456, 450);
            this.CantidadFibraUnidad.Name = "CantidadFibraUnidad";
            this.CantidadFibraUnidad.Size = new System.Drawing.Size(27, 21);
            this.CantidadFibraUnidad.TabIndex = 16;
            this.CantidadFibraUnidad.Text = "kg";
            // 
            // CantidadFibraText
            // 
            this.CantidadFibraText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadFibraText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadFibraText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadFibraText.Location = new System.Drawing.Point(200, 447);
            this.CantidadFibraText.MinValue = 0D;
            this.CantidadFibraText.Name = "CantidadFibraText";
            this.CantidadFibraText.Size = new System.Drawing.Size(250, 29);
            this.CantidadFibraText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadFibraText.TabIndex = 15;
            this.CantidadFibraText.WatermarkText = "Ingresa la cantidad";
            this.CantidadFibraText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // FibraCombo
            // 
            this.FibraCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FibraCombo.FormattingEnabled = true;
            this.FibraCombo.Location = new System.Drawing.Point(200, 397);
            this.FibraCombo.Name = "FibraCombo";
            this.FibraCombo.Size = new System.Drawing.Size(250, 29);
            this.FibraCombo.TabIndex = 13;
            this.FibraCombo.SelectedIndexChanged += new System.EventHandler(this.FibraCombo_SelectedIndexChanged);
            this.FibraCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CantidadFibraLabel
            // 
            this.CantidadFibraLabel.AutoSize = true;
            this.CantidadFibraLabel.Location = new System.Drawing.Point(50, 450);
            this.CantidadFibraLabel.Name = "CantidadFibraLabel";
            this.CantidadFibraLabel.Size = new System.Drawing.Size(118, 21);
            this.CantidadFibraLabel.TabIndex = 14;
            this.CantidadFibraLabel.Text = "Cantidad Fibra*";
            // 
            // FibraLabel
            // 
            this.FibraLabel.AutoSize = true;
            this.FibraLabel.Location = new System.Drawing.Point(50, 400);
            this.FibraLabel.Name = "FibraLabel";
            this.FibraLabel.Size = new System.Drawing.Size(52, 21);
            this.FibraLabel.TabIndex = 12;
            this.FibraLabel.Text = "Fibra*";
            // 
            // CantidadAlambreLabel
            // 
            this.CantidadAlambreLabel.AutoSize = true;
            this.CantidadAlambreLabel.Location = new System.Drawing.Point(50, 550);
            this.CantidadAlambreLabel.Name = "CantidadAlambreLabel";
            this.CantidadAlambreLabel.Size = new System.Drawing.Size(135, 21);
            this.CantidadAlambreLabel.TabIndex = 19;
            this.CantidadAlambreLabel.Text = "Cantidad Alambre";
            // 
            // CantidadAlambreText
            // 
            this.CantidadAlambreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadAlambreText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadAlambreText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadAlambreText.Location = new System.Drawing.Point(200, 547);
            this.CantidadAlambreText.MinValue = 0D;
            this.CantidadAlambreText.Name = "CantidadAlambreText";
            this.CantidadAlambreText.Size = new System.Drawing.Size(250, 29);
            this.CantidadAlambreText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadAlambreText.TabIndex = 20;
            this.CantidadAlambreText.WatermarkText = "Ingresa la cantidad";
            this.CantidadAlambreText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // RebabaUnidad
            // 
            this.RebabaUnidad.AutoSize = true;
            this.RebabaUnidad.Location = new System.Drawing.Point(976, 350);
            this.RebabaUnidad.Name = "RebabaUnidad";
            this.RebabaUnidad.Size = new System.Drawing.Size(27, 21);
            this.RebabaUnidad.TabIndex = 37;
            this.RebabaUnidad.Text = "kg";
            // 
            // MermaFibraLabel
            // 
            this.MermaFibraLabel.AutoSize = true;
            this.MermaFibraLabel.Location = new System.Drawing.Point(600, 350);
            this.MermaFibraLabel.Name = "MermaFibraLabel";
            this.MermaFibraLabel.Size = new System.Drawing.Size(99, 21);
            this.MermaFibraLabel.TabIndex = 35;
            this.MermaFibraLabel.Text = "Merma Fibra";
            // 
            // MermaFibraText
            // 
            this.MermaFibraText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MermaFibraText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MermaFibraText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MermaFibraText.Location = new System.Drawing.Point(720, 347);
            this.MermaFibraText.MinValue = 0D;
            this.MermaFibraText.Name = "MermaFibraText";
            this.MermaFibraText.Size = new System.Drawing.Size(250, 29);
            this.MermaFibraText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MermaFibraText.TabIndex = 36;
            this.MermaFibraText.WatermarkText = "Calculado automáticamente";
            this.MermaFibraText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CalcularButton
            // 
            this.CalcularButton.AutoSize = true;
            this.CalcularButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(808, 400);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(78, 35);
            this.CalcularButton.TabIndex = 38;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 5000;
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
            // TipoAlambreLabel
            // 
            this.TipoAlambreLabel.AutoSize = true;
            this.TipoAlambreLabel.Location = new System.Drawing.Point(50, 500);
            this.TipoAlambreLabel.Name = "TipoAlambreLabel";
            this.TipoAlambreLabel.Size = new System.Drawing.Size(69, 21);
            this.TipoAlambreLabel.TabIndex = 17;
            this.TipoAlambreLabel.Text = "Alambre";
            // 
            // TipoAlambreCombo
            // 
            this.TipoAlambreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoAlambreCombo.FormattingEnabled = true;
            this.TipoAlambreCombo.Location = new System.Drawing.Point(200, 497);
            this.TipoAlambreCombo.Name = "TipoAlambreCombo";
            this.TipoAlambreCombo.Size = new System.Drawing.Size(250, 29);
            this.TipoAlambreCombo.TabIndex = 18;
            this.TipoAlambreCombo.SelectedIndexChanged += new System.EventHandler(this.TipoAlambreCombo_SelectedIndexChanged);
            this.TipoAlambreCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // TipoCajaLabel
            // 
            this.TipoCajaLabel.AutoSize = true;
            this.TipoCajaLabel.Location = new System.Drawing.Point(53, 600);
            this.TipoCajaLabel.Name = "TipoCajaLabel";
            this.TipoCajaLabel.Size = new System.Drawing.Size(40, 21);
            this.TipoCajaLabel.TabIndex = 21;
            this.TipoCajaLabel.Text = "Caja";
            // 
            // TipoCajaCombo
            // 
            this.TipoCajaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoCajaCombo.FormattingEnabled = true;
            this.TipoCajaCombo.Location = new System.Drawing.Point(203, 597);
            this.TipoCajaCombo.Name = "TipoCajaCombo";
            this.TipoCajaCombo.Size = new System.Drawing.Size(250, 29);
            this.TipoCajaCombo.TabIndex = 22;
            this.TipoCajaCombo.SelectedIndexChanged += new System.EventHandler(this.TipoCajaCombo_SelectedIndexChanged);
            this.TipoCajaCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CantidadCajasLabel
            // 
            this.CantidadCajasLabel.AutoSize = true;
            this.CantidadCajasLabel.Location = new System.Drawing.Point(53, 650);
            this.CantidadCajasLabel.Name = "CantidadCajasLabel";
            this.CantidadCajasLabel.Size = new System.Drawing.Size(134, 21);
            this.CantidadCajasLabel.TabIndex = 23;
            this.CantidadCajasLabel.Text = "Cantidad de Cajas";
            // 
            // CantidadCajasText
            // 
            this.CantidadCajasText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadCajasText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadCajasText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadCajasText.HideTrailingZeros = true;
            this.CantidadCajasText.Location = new System.Drawing.Point(203, 647);
            this.CantidadCajasText.MinValue = 0D;
            this.CantidadCajasText.Name = "CantidadCajasText";
            this.CantidadCajasText.Size = new System.Drawing.Size(250, 29);
            this.CantidadCajasText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadCajasText.TabIndex = 24;
            this.CantidadCajasText.Text = "0";
            this.CantidadCajasText.WatermarkText = "Ingresa la cantidad";
            this.CantidadCajasText.TextChanged += new System.EventHandler(this.InputOutputChanged);
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
            this.MáquinaCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CantidadAlambreUnidad
            // 
            this.CantidadAlambreUnidad.AutoSize = true;
            this.CantidadAlambreUnidad.Location = new System.Drawing.Point(456, 550);
            this.CantidadAlambreUnidad.Name = "CantidadAlambreUnidad";
            this.CantidadAlambreUnidad.Size = new System.Drawing.Size(27, 21);
            this.CantidadAlambreUnidad.TabIndex = 16;
            this.CantidadAlambreUnidad.Text = "kg";
            // 
            // RegistrarInsertadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.TurnoText);
            this.Controls.Add(this.FechaPicker);
            this.Controls.Add(this.OperadorCombo);
            this.Controls.Add(this.MaquinaLabel);
            this.Controls.Add(this.OperadorLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.CantidadAlambreUnidad);
            this.Controls.Add(this.CantidadFibraUnidad);
            this.Controls.Add(this.CantidadCajasText);
            this.Controls.Add(this.CantidadAlambreText);
            this.Controls.Add(this.CantidadFibraText);
            this.Controls.Add(this.CantidadCajasLabel);
            this.Controls.Add(this.CantidadAlambreLabel);
            this.Controls.Add(this.TipoCajaCombo);
            this.Controls.Add(this.TipoAlambreCombo);
            this.Controls.Add(this.FibraCombo);
            this.Controls.Add(this.CantidadFibraLabel);
            this.Controls.Add(this.TipoCajaLabel);
            this.Controls.Add(this.TipoAlambreLabel);
            this.Controls.Add(this.FibraLabel);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.MermaFibraText);
            this.Controls.Add(this.MermaBasesText);
            this.Controls.Add(this.PiezasMalasText);
            this.Controls.Add(this.PiezasBuenasText);
            this.Controls.Add(this.MáquinaCombo);
            this.Controls.Add(this.SalidaCombo);
            this.Controls.Add(this.ArrowButton);
            this.Controls.Add(this.MermaFibraLabel);
            this.Controls.Add(this.RebabaUnidad);
            this.Controls.Add(this.MermaBasesLabel);
            this.Controls.Add(this.MermaRealUnidad);
            this.Controls.Add(this.PiezasMalasLabel);
            this.Controls.Add(this.PiezasBuenasLabel);
            this.Controls.Add(this.SalidaLabel);
            this.Controls.Add(this.CantidadBaseText);
            this.Controls.Add(this.BaseCombo);
            this.Controls.Add(this.CantidadBaseLabel);
            this.Controls.Add(this.BaseLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarInsertadoForm";
            this.Text = "RegistrarInsertadoForm";
            this.TextChanged += new System.EventHandler(this.InputOutputChanged);
            ((System.ComponentModel.ISupportInitialize)(this.TurnoText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfNumericTextBox MermaBasesText;
        private Syncfusion.WinForms.Input.SfNumericTextBox PiezasMalasText;
        private Syncfusion.WinForms.Input.SfNumericTextBox PiezasBuenasText;
        private System.Windows.Forms.ComboBox SalidaCombo;
        private FontAwesome.Sharp.IconButton ArrowButton;
        private System.Windows.Forms.Label MermaBasesLabel;
        private System.Windows.Forms.Label MermaRealUnidad;
        private System.Windows.Forms.Label PiezasMalasLabel;
        private System.Windows.Forms.Label PiezasBuenasLabel;
        private System.Windows.Forms.Label SalidaLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadBaseText;
        private System.Windows.Forms.ComboBox BaseCombo;
        private System.Windows.Forms.Label CantidadBaseLabel;
        private System.Windows.Forms.Label BaseLabel;
        private System.Windows.Forms.Label CantidadFibraUnidad;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadFibraText;
        private System.Windows.Forms.ComboBox FibraCombo;
        private System.Windows.Forms.Label CantidadFibraLabel;
        private System.Windows.Forms.Label FibraLabel;
        private System.Windows.Forms.Label CantidadAlambreLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadAlambreText;
        private System.Windows.Forms.Label RebabaUnidad;
        private System.Windows.Forms.Label MermaFibraLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox MermaFibraText;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.NumericUpDown TurnoText;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaPicker;
        private System.Windows.Forms.ComboBox OperadorCombo;
        private System.Windows.Forms.Label MaquinaLabel;
        private System.Windows.Forms.Label OperadorLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label TipoAlambreLabel;
        private System.Windows.Forms.ComboBox TipoAlambreCombo;
        private System.Windows.Forms.Label TipoCajaLabel;
        private System.Windows.Forms.ComboBox TipoCajaCombo;
        private System.Windows.Forms.Label CantidadCajasLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadCajasText;
        private System.Windows.Forms.ComboBox MáquinaCombo;
        private System.Windows.Forms.Label CantidadAlambreUnidad;
    }
}