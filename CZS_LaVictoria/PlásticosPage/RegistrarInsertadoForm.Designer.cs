
namespace CZS_ERP_UI.PlásticosPage
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
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 50);
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
            this.MsgBox.Size = new System.Drawing.Size(420, 250);
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
            this.GuardarButton.Size = new System.Drawing.Size(78, 33);
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
            this.SalidaCombo.Size = new System.Drawing.Size(250, 28);
            this.SalidaCombo.TabIndex = 63;
            this.SalidaCombo.SelectedIndexChanged += new System.EventHandler(this.SalidaCombo_SelectedIndexChanged);
            this.SalidaCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // BasesMalasLabel
            // 
            this.BasesMalasLabel.AutoSize = true;
            this.BasesMalasLabel.Location = new System.Drawing.Point(600, 300);
            this.BasesMalasLabel.Name = "BasesMalasLabel";
            this.BasesMalasLabel.Size = new System.Drawing.Size(100, 20);
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
            this.ArrowButton.Size = new System.Drawing.Size(44, 34);
            this.ArrowButton.TabIndex = 62;
            this.ArrowButton.UseVisualStyleBackColor = true;
            // 
            // VirutaLabel
            // 
            this.VirutaLabel.AutoSize = true;
            this.VirutaLabel.Location = new System.Drawing.Point(600, 350);
            this.VirutaLabel.Name = "VirutaLabel";
            this.VirutaLabel.Size = new System.Drawing.Size(51, 20);
            this.VirutaLabel.TabIndex = 54;
            this.VirutaLabel.Text = "Viruta";
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
            // PiezasMalasLabel
            // 
            this.PiezasMalasLabel.AutoSize = true;
            this.PiezasMalasLabel.Location = new System.Drawing.Point(600, 250);
            this.PiezasMalasLabel.Name = "PiezasMalasLabel";
            this.PiezasMalasLabel.Size = new System.Drawing.Size(102, 20);
            this.PiezasMalasLabel.TabIndex = 56;
            this.PiezasMalasLabel.Text = "Piezas Malas";
            // 
            // PiezasBuenasLabel
            // 
            this.PiezasBuenasLabel.AutoSize = true;
            this.PiezasBuenasLabel.Location = new System.Drawing.Point(600, 200);
            this.PiezasBuenasLabel.Name = "PiezasBuenasLabel";
            this.PiezasBuenasLabel.Size = new System.Drawing.Size(115, 20);
            this.PiezasBuenasLabel.TabIndex = 55;
            this.PiezasBuenasLabel.Text = "Piezas Buenas";
            // 
            // SalidaLabel
            // 
            this.SalidaLabel.AutoSize = true;
            this.SalidaLabel.Location = new System.Drawing.Point(600, 150);
            this.SalidaLabel.Name = "SalidaLabel";
            this.SalidaLabel.Size = new System.Drawing.Size(73, 20);
            this.SalidaLabel.TabIndex = 61;
            this.SalidaLabel.Text = "Producto";
            // 
            // CantidadBaseText
            // 
            this.CantidadBaseText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadBaseText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadBaseText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadBaseText.HideTrailingZeros = true;
            this.CantidadBaseText.Location = new System.Drawing.Point(200, 197);
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
            this.BaseCombo.FormattingEnabled = true;
            this.BaseCombo.Location = new System.Drawing.Point(200, 147);
            this.BaseCombo.Name = "BaseCombo";
            this.BaseCombo.Size = new System.Drawing.Size(250, 28);
            this.BaseCombo.TabIndex = 51;
            this.BaseCombo.SelectedIndexChanged += new System.EventHandler(this.BaseCombo_SelectedIndexChanged);
            this.BaseCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CantidadBaseLabel
            // 
            this.CantidadBaseLabel.AutoSize = true;
            this.CantidadBaseLabel.Location = new System.Drawing.Point(50, 200);
            this.CantidadBaseLabel.Name = "CantidadBaseLabel";
            this.CantidadBaseLabel.Size = new System.Drawing.Size(117, 20);
            this.CantidadBaseLabel.TabIndex = 49;
            this.CantidadBaseLabel.Text = "Núm. de Bases";
            // 
            // BaseLabel
            // 
            this.BaseLabel.AutoSize = true;
            this.BaseLabel.Location = new System.Drawing.Point(50, 150);
            this.BaseLabel.Name = "BaseLabel";
            this.BaseLabel.Size = new System.Drawing.Size(46, 20);
            this.BaseLabel.TabIndex = 50;
            this.BaseLabel.Text = "Base";
            // 
            // CantidadEntradaUnidad
            // 
            this.CantidadEntradaUnidad.AutoSize = true;
            this.CantidadEntradaUnidad.Location = new System.Drawing.Point(456, 300);
            this.CantidadEntradaUnidad.Name = "CantidadEntradaUnidad";
            this.CantidadEntradaUnidad.Size = new System.Drawing.Size(26, 20);
            this.CantidadEntradaUnidad.TabIndex = 74;
            this.CantidadEntradaUnidad.Text = "kg";
            // 
            // CantidadFibraText
            // 
            this.CantidadFibraText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadFibraText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadFibraText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadFibraText.Location = new System.Drawing.Point(200, 297);
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
            this.FibraCombo.FormattingEnabled = true;
            this.FibraCombo.Location = new System.Drawing.Point(200, 247);
            this.FibraCombo.Name = "FibraCombo";
            this.FibraCombo.Size = new System.Drawing.Size(250, 28);
            this.FibraCombo.TabIndex = 72;
            this.FibraCombo.SelectedIndexChanged += new System.EventHandler(this.FibraCombo_SelectedIndexChanged);
            this.FibraCombo.TextChanged += new System.EventHandler(this.InputOutputChanged);
            // 
            // CantidadFibraLabel
            // 
            this.CantidadFibraLabel.AutoSize = true;
            this.CantidadFibraLabel.Location = new System.Drawing.Point(50, 300);
            this.CantidadFibraLabel.Name = "CantidadFibraLabel";
            this.CantidadFibraLabel.Size = new System.Drawing.Size(73, 20);
            this.CantidadFibraLabel.TabIndex = 70;
            this.CantidadFibraLabel.Text = "Cantidad";
            // 
            // FibraLabel
            // 
            this.FibraLabel.AutoSize = true;
            this.FibraLabel.Location = new System.Drawing.Point(50, 250);
            this.FibraLabel.Name = "FibraLabel";
            this.FibraLabel.Size = new System.Drawing.Size(45, 20);
            this.FibraLabel.TabIndex = 71;
            this.FibraLabel.Text = "Fibra";
            // 
            // CantidadRollosLabel
            // 
            this.CantidadRollosLabel.AutoSize = true;
            this.CantidadRollosLabel.Location = new System.Drawing.Point(50, 350);
            this.CantidadRollosLabel.Name = "CantidadRollosLabel";
            this.CantidadRollosLabel.Size = new System.Drawing.Size(138, 20);
            this.CantidadRollosLabel.TabIndex = 70;
            this.CantidadRollosLabel.Text = "Rollos de Alambre";
            // 
            // CantidadRollosText
            // 
            this.CantidadRollosText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadRollosText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadRollosText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CantidadRollosText.HideTrailingZeros = true;
            this.CantidadRollosText.Location = new System.Drawing.Point(200, 347);
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
            this.RebabaUnidad.Size = new System.Drawing.Size(26, 20);
            this.RebabaUnidad.TabIndex = 59;
            this.RebabaUnidad.Text = "kg";
            // 
            // RebabaLabel
            // 
            this.RebabaLabel.AutoSize = true;
            this.RebabaLabel.Location = new System.Drawing.Point(600, 400);
            this.RebabaLabel.Name = "RebabaLabel";
            this.RebabaLabel.Size = new System.Drawing.Size(66, 20);
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
            this.CalcularButton.Size = new System.Drawing.Size(78, 33);
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
            // RegistrarInsertadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.CantidadEntradaUnidad);
            this.Controls.Add(this.CantidadRollosText);
            this.Controls.Add(this.CantidadFibraText);
            this.Controls.Add(this.CantidadRollosLabel);
            this.Controls.Add(this.FibraCombo);
            this.Controls.Add(this.CantidadFibraLabel);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarInsertadoForm";
            this.Text = "RegistrarInsertadoForm";
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
    }
}