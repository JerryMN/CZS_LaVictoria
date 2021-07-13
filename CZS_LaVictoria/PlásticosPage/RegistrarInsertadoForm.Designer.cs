
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
            this.BasesMalasText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.VirutaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PiezasMalasText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PiezasBuenasText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.SalidaCombo = new System.Windows.Forms.ComboBox();
            this.BasesMalasLabel = new System.Windows.Forms.Label();
            this.ArrowButton = new FontAwesome.Sharp.IconButton();
            this.VirutaLabel = new System.Windows.Forms.Label();
            this.MermaRealUnidad = new System.Windows.Forms.Label();
            this.PiezasMalasLabel = new System.Windows.Forms.Label();
            this.PiezasBuenasLabel = new System.Windows.Forms.Label();
            this.SalidaLabel = new System.Windows.Forms.Label();
            this.CantidadBaseText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.BaseCombo = new System.Windows.Forms.ComboBox();
            this.CantidadBaseLabel = new System.Windows.Forms.Label();
            this.BaseLabel = new System.Windows.Forms.Label();
            this.CantidadEntradaUnidad = new System.Windows.Forms.Label();
            this.CantidadFibraText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.FibraCombo = new System.Windows.Forms.ComboBox();
            this.CantidadFibraLabel = new System.Windows.Forms.Label();
            this.FibraLabel = new System.Windows.Forms.Label();
            this.CantidadRollosLabel = new System.Windows.Forms.Label();
            this.CantidadRollosText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.RebabaUnidad = new System.Windows.Forms.Label();
            this.RebabaLabel = new System.Windows.Forms.Label();
            this.RebabaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.TurnoText = new System.Windows.Forms.NumericUpDown();
            this.MaquinaText = new System.Windows.Forms.NumericUpDown();
            this.FechaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.OperadorCombo = new System.Windows.Forms.ComboBox();
            this.MaquinaLabel = new System.Windows.Forms.Label();
            this.OperadorLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.TipoAlambreLabel = new System.Windows.Forms.Label();
            this.TipoAlambreCombo = new System.Windows.Forms.ComboBox();
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
            this.SubtitleLabel.Size = new System.Drawing.Size(279, 37);
            this.SubtitleLabel.TabIndex = 31;
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
            this.MsgBox.Location = new System.Drawing.Point(550, 500);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 262);
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
            this.GuardarButton.Location = new System.Drawing.Point(892, 450);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 35);
            this.GuardarButton.TabIndex = 68;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // BasesMalasText
            // 
            this.BasesMalasText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BasesMalasText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasesMalasText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BasesMalasText.HideTrailingZeros = true;
            this.BasesMalasText.Location = new System.Drawing.Point(720, 297);
            this.BasesMalasText.MinValue = 0D;
            this.BasesMalasText.Name = "BasesMalasText";
            this.BasesMalasText.Size = new System.Drawing.Size(250, 29);
            this.BasesMalasText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BasesMalasText.TabIndex = 65;
            this.BasesMalasText.Text = "0";
            this.BasesMalasText.WatermarkText = "Calculado automáticamente";
            this.BasesMalasText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // VirutaText
            // 
            this.VirutaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VirutaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirutaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VirutaText.Location = new System.Drawing.Point(720, 347);
            this.VirutaText.MinValue = 0D;
            this.VirutaText.Name = "VirutaText";
            this.VirutaText.Size = new System.Drawing.Size(250, 29);
            this.VirutaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VirutaText.TabIndex = 64;
            this.VirutaText.WatermarkText = "Calculado automáticamente";
            this.VirutaText.TextChanged += new System.EventHandler(this.InputOutputChanged);
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
            this.PiezasMalasText.TabIndex = 67;
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
            this.PiezasBuenasText.TabIndex = 66;
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
            this.SalidaCombo.TabIndex = 63;
            this.SalidaCombo.SelectedIndexChanged += new System.EventHandler(this.SalidaCombo_SelectedIndexChanged);
            this.SalidaCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // BasesMalasLabel
            // 
            this.BasesMalasLabel.AutoSize = true;
            this.BasesMalasLabel.Location = new System.Drawing.Point(600, 300);
            this.BasesMalasLabel.Name = "BasesMalasLabel";
            this.BasesMalasLabel.Size = new System.Drawing.Size(94, 21);
            this.BasesMalasLabel.TabIndex = 53;
            this.BasesMalasLabel.Text = "Bases Malas";
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
            this.ArrowButton.TabIndex = 62;
            this.ArrowButton.UseVisualStyleBackColor = true;
            // 
            // VirutaLabel
            // 
            this.VirutaLabel.AutoSize = true;
            this.VirutaLabel.Location = new System.Drawing.Point(600, 350);
            this.VirutaLabel.Name = "VirutaLabel";
            this.VirutaLabel.Size = new System.Drawing.Size(52, 21);
            this.VirutaLabel.TabIndex = 54;
            this.VirutaLabel.Text = "Viruta";
            // 
            // MermaRealUnidad
            // 
            this.MermaRealUnidad.AutoSize = true;
            this.MermaRealUnidad.Location = new System.Drawing.Point(976, 350);
            this.MermaRealUnidad.Name = "MermaRealUnidad";
            this.MermaRealUnidad.Size = new System.Drawing.Size(27, 21);
            this.MermaRealUnidad.TabIndex = 59;
            this.MermaRealUnidad.Text = "kg";
            // 
            // PiezasMalasLabel
            // 
            this.PiezasMalasLabel.AutoSize = true;
            this.PiezasMalasLabel.Location = new System.Drawing.Point(600, 250);
            this.PiezasMalasLabel.Name = "PiezasMalasLabel";
            this.PiezasMalasLabel.Size = new System.Drawing.Size(98, 21);
            this.PiezasMalasLabel.TabIndex = 56;
            this.PiezasMalasLabel.Text = "Piezas Malas";
            // 
            // PiezasBuenasLabel
            // 
            this.PiezasBuenasLabel.AutoSize = true;
            this.PiezasBuenasLabel.Location = new System.Drawing.Point(600, 200);
            this.PiezasBuenasLabel.Name = "PiezasBuenasLabel";
            this.PiezasBuenasLabel.Size = new System.Drawing.Size(107, 21);
            this.PiezasBuenasLabel.TabIndex = 55;
            this.PiezasBuenasLabel.Text = "Piezas Buenas";
            // 
            // SalidaLabel
            // 
            this.SalidaLabel.AutoSize = true;
            this.SalidaLabel.Location = new System.Drawing.Point(600, 150);
            this.SalidaLabel.Name = "SalidaLabel";
            this.SalidaLabel.Size = new System.Drawing.Size(73, 21);
            this.SalidaLabel.TabIndex = 61;
            this.SalidaLabel.Text = "Producto";
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
            this.CantidadBaseText.TabIndex = 52;
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
            this.BaseCombo.TabIndex = 51;
            this.BaseCombo.SelectedIndexChanged += new System.EventHandler(this.BaseCombo_SelectedIndexChanged);
            this.BaseCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CantidadBaseLabel
            // 
            this.CantidadBaseLabel.AutoSize = true;
            this.CantidadBaseLabel.Location = new System.Drawing.Point(50, 350);
            this.CantidadBaseLabel.Name = "CantidadBaseLabel";
            this.CantidadBaseLabel.Size = new System.Drawing.Size(112, 21);
            this.CantidadBaseLabel.TabIndex = 49;
            this.CantidadBaseLabel.Text = "Núm. de Bases";
            // 
            // BaseLabel
            // 
            this.BaseLabel.AutoSize = true;
            this.BaseLabel.Location = new System.Drawing.Point(50, 300);
            this.BaseLabel.Name = "BaseLabel";
            this.BaseLabel.Size = new System.Drawing.Size(42, 21);
            this.BaseLabel.TabIndex = 50;
            this.BaseLabel.Text = "Base";
            // 
            // CantidadEntradaUnidad
            // 
            this.CantidadEntradaUnidad.AutoSize = true;
            this.CantidadEntradaUnidad.Location = new System.Drawing.Point(456, 450);
            this.CantidadEntradaUnidad.Name = "CantidadEntradaUnidad";
            this.CantidadEntradaUnidad.Size = new System.Drawing.Size(27, 21);
            this.CantidadEntradaUnidad.TabIndex = 74;
            this.CantidadEntradaUnidad.Text = "kg";
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
            this.CantidadFibraText.TabIndex = 73;
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
            this.FibraCombo.TabIndex = 72;
            this.FibraCombo.SelectedIndexChanged += new System.EventHandler(this.FibraCombo_SelectedIndexChanged);
            this.FibraCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CantidadFibraLabel
            // 
            this.CantidadFibraLabel.AutoSize = true;
            this.CantidadFibraLabel.Location = new System.Drawing.Point(50, 450);
            this.CantidadFibraLabel.Name = "CantidadFibraLabel";
            this.CantidadFibraLabel.Size = new System.Drawing.Size(72, 21);
            this.CantidadFibraLabel.TabIndex = 70;
            this.CantidadFibraLabel.Text = "Cantidad";
            // 
            // FibraLabel
            // 
            this.FibraLabel.AutoSize = true;
            this.FibraLabel.Location = new System.Drawing.Point(50, 400);
            this.FibraLabel.Name = "FibraLabel";
            this.FibraLabel.Size = new System.Drawing.Size(45, 21);
            this.FibraLabel.TabIndex = 71;
            this.FibraLabel.Text = "Fibra";
            // 
            // CantidadRollosLabel
            // 
            this.CantidadRollosLabel.AutoSize = true;
            this.CantidadRollosLabel.Location = new System.Drawing.Point(50, 550);
            this.CantidadRollosLabel.Name = "CantidadRollosLabel";
            this.CantidadRollosLabel.Size = new System.Drawing.Size(137, 21);
            this.CantidadRollosLabel.TabIndex = 70;
            this.CantidadRollosLabel.Text = "Rollos de Alambre";
            // 
            // CantidadRollosText
            // 
            this.CantidadRollosText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadRollosText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadRollosText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadRollosText.HideTrailingZeros = true;
            this.CantidadRollosText.Location = new System.Drawing.Point(200, 547);
            this.CantidadRollosText.MinValue = 0D;
            this.CantidadRollosText.Name = "CantidadRollosText";
            this.CantidadRollosText.Size = new System.Drawing.Size(250, 29);
            this.CantidadRollosText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CantidadRollosText.TabIndex = 73;
            this.CantidadRollosText.Text = "0";
            this.CantidadRollosText.WatermarkText = "Ingresa la cantidad";
            this.CantidadRollosText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // RebabaUnidad
            // 
            this.RebabaUnidad.AutoSize = true;
            this.RebabaUnidad.Location = new System.Drawing.Point(976, 400);
            this.RebabaUnidad.Name = "RebabaUnidad";
            this.RebabaUnidad.Size = new System.Drawing.Size(27, 21);
            this.RebabaUnidad.TabIndex = 59;
            this.RebabaUnidad.Text = "kg";
            // 
            // RebabaLabel
            // 
            this.RebabaLabel.AutoSize = true;
            this.RebabaLabel.Location = new System.Drawing.Point(600, 400);
            this.RebabaLabel.Name = "RebabaLabel";
            this.RebabaLabel.Size = new System.Drawing.Size(62, 21);
            this.RebabaLabel.TabIndex = 54;
            this.RebabaLabel.Text = "Rebaba";
            // 
            // RebabaText
            // 
            this.RebabaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RebabaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RebabaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RebabaText.Location = new System.Drawing.Point(720, 397);
            this.RebabaText.MinValue = 0D;
            this.RebabaText.Name = "RebabaText";
            this.RebabaText.Size = new System.Drawing.Size(250, 29);
            this.RebabaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RebabaText.TabIndex = 64;
            this.RebabaText.WatermarkText = "Calculado automáticamente";
            this.RebabaText.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CalcularButton
            // 
            this.CalcularButton.AutoSize = true;
            this.CalcularButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(808, 450);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(78, 35);
            this.CalcularButton.TabIndex = 75;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
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
            this.TurnoText.TabIndex = 99;
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
            this.MaquinaText.TabIndex = 100;
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
            this.FechaPicker.TabIndex = 98;
            // 
            // OperadorCombo
            // 
            this.OperadorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperadorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorCombo.FormattingEnabled = true;
            this.OperadorCombo.Location = new System.Drawing.Point(200, 197);
            this.OperadorCombo.Name = "OperadorCombo";
            this.OperadorCombo.Size = new System.Drawing.Size(250, 29);
            this.OperadorCombo.TabIndex = 97;
            // 
            // MaquinaLabel
            // 
            this.MaquinaLabel.AutoSize = true;
            this.MaquinaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaquinaLabel.Location = new System.Drawing.Point(50, 250);
            this.MaquinaLabel.Name = "MaquinaLabel";
            this.MaquinaLabel.Size = new System.Drawing.Size(126, 21);
            this.MaquinaLabel.TabIndex = 94;
            this.MaquinaLabel.Text = "Máquina / Turno";
            // 
            // OperadorLabel
            // 
            this.OperadorLabel.AutoSize = true;
            this.OperadorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperadorLabel.Location = new System.Drawing.Point(50, 200);
            this.OperadorLabel.Name = "OperadorLabel";
            this.OperadorLabel.Size = new System.Drawing.Size(77, 21);
            this.OperadorLabel.TabIndex = 95;
            this.OperadorLabel.Text = "Operador";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(50, 150);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(144, 21);
            this.FechaLabel.TabIndex = 96;
            this.FechaLabel.Text = "Fecha de operación";
            // 
            // TipoAlambreLabel
            // 
            this.TipoAlambreLabel.AutoSize = true;
            this.TipoAlambreLabel.Location = new System.Drawing.Point(50, 500);
            this.TipoAlambreLabel.Name = "TipoAlambreLabel";
            this.TipoAlambreLabel.Size = new System.Drawing.Size(69, 21);
            this.TipoAlambreLabel.TabIndex = 71;
            this.TipoAlambreLabel.Text = "Alambre";
            // 
            // TipoAlambreCombo
            // 
            this.TipoAlambreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoAlambreCombo.FormattingEnabled = true;
            this.TipoAlambreCombo.Location = new System.Drawing.Point(200, 497);
            this.TipoAlambreCombo.Name = "TipoAlambreCombo";
            this.TipoAlambreCombo.Size = new System.Drawing.Size(250, 29);
            this.TipoAlambreCombo.TabIndex = 72;
            this.TipoAlambreCombo.SelectedIndexChanged += new System.EventHandler(this.TipoAlambreCombo_SelectedIndexChanged);
            this.TipoAlambreCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // RegistrarInsertadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.TurnoText);
            this.Controls.Add(this.MaquinaText);
            this.Controls.Add(this.FechaPicker);
            this.Controls.Add(this.OperadorCombo);
            this.Controls.Add(this.MaquinaLabel);
            this.Controls.Add(this.OperadorLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.CantidadEntradaUnidad);
            this.Controls.Add(this.CantidadRollosText);
            this.Controls.Add(this.CantidadFibraText);
            this.Controls.Add(this.CantidadRollosLabel);
            this.Controls.Add(this.TipoAlambreCombo);
            this.Controls.Add(this.FibraCombo);
            this.Controls.Add(this.CantidadFibraLabel);
            this.Controls.Add(this.TipoAlambreLabel);
            this.Controls.Add(this.FibraLabel);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.BasesMalasText);
            this.Controls.Add(this.RebabaText);
            this.Controls.Add(this.VirutaText);
            this.Controls.Add(this.PiezasMalasText);
            this.Controls.Add(this.PiezasBuenasText);
            this.Controls.Add(this.SalidaCombo);
            this.Controls.Add(this.BasesMalasLabel);
            this.Controls.Add(this.ArrowButton);
            this.Controls.Add(this.RebabaLabel);
            this.Controls.Add(this.RebabaUnidad);
            this.Controls.Add(this.VirutaLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.MaquinaText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfNumericTextBox BasesMalasText;
        private Syncfusion.WinForms.Input.SfNumericTextBox VirutaText;
        private Syncfusion.WinForms.Input.SfNumericTextBox PiezasMalasText;
        private Syncfusion.WinForms.Input.SfNumericTextBox PiezasBuenasText;
        private System.Windows.Forms.ComboBox SalidaCombo;
        private System.Windows.Forms.Label BasesMalasLabel;
        private FontAwesome.Sharp.IconButton ArrowButton;
        private System.Windows.Forms.Label VirutaLabel;
        private System.Windows.Forms.Label MermaRealUnidad;
        private System.Windows.Forms.Label PiezasMalasLabel;
        private System.Windows.Forms.Label PiezasBuenasLabel;
        private System.Windows.Forms.Label SalidaLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadBaseText;
        private System.Windows.Forms.ComboBox BaseCombo;
        private System.Windows.Forms.Label CantidadBaseLabel;
        private System.Windows.Forms.Label BaseLabel;
        private System.Windows.Forms.Label CantidadEntradaUnidad;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadFibraText;
        private System.Windows.Forms.ComboBox FibraCombo;
        private System.Windows.Forms.Label CantidadFibraLabel;
        private System.Windows.Forms.Label FibraLabel;
        private System.Windows.Forms.Label CantidadRollosLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CantidadRollosText;
        private System.Windows.Forms.Label RebabaUnidad;
        private System.Windows.Forms.Label RebabaLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox RebabaText;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.NumericUpDown TurnoText;
        private System.Windows.Forms.NumericUpDown MaquinaText;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaPicker;
        private System.Windows.Forms.ComboBox OperadorCombo;
        private System.Windows.Forms.Label MaquinaLabel;
        private System.Windows.Forms.Label OperadorLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label TipoAlambreLabel;
        private System.Windows.Forms.ComboBox TipoAlambreCombo;
    }
}