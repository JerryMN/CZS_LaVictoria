
namespace CZS_LaVictoria.CuentasPage
{
    partial class CalculadoraForm
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
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.HastaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdePicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.IngresosLabel = new System.Windows.Forms.Label();
            this.IngresosText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.EgresosLabel = new System.Windows.Forms.Label();
            this.EgresosText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PiezasLabel = new System.Windows.Forms.Label();
            this.PiezasText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.ArrowButton = new FontAwesome.Sharp.IconButton();
            this.ProductividadLabel = new System.Windows.Forms.Label();
            this.ProductividadText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CostoLabel = new System.Windows.Forms.Label();
            this.CostoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.GananciaLabel = new System.Windows.Forms.Label();
            this.GananciaText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(288, 37);
            this.SubtitleLabel.TabIndex = 89;
            this.SubtitleLabel.Text = "Calculadora de Costos";
            // 
            // HastaPicker
            // 
            this.HastaPicker.AllowValueChangeOnMouseWheel = true;
            this.HastaPicker.Location = new System.Drawing.Point(200, 197);
            this.HastaPicker.Name = "HastaPicker";
            this.HastaPicker.Size = new System.Drawing.Size(250, 33);
            this.HastaPicker.TabIndex = 93;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaLabel.Location = new System.Drawing.Point(50, 200);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(49, 21);
            this.HastaLabel.TabIndex = 92;
            this.HastaLabel.Text = "Hasta";
            // 
            // DesdePicker
            // 
            this.DesdePicker.AllowValueChangeOnMouseWheel = true;
            this.DesdePicker.Location = new System.Drawing.Point(200, 147);
            this.DesdePicker.Name = "DesdePicker";
            this.DesdePicker.Size = new System.Drawing.Size(250, 33);
            this.DesdePicker.TabIndex = 91;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeLabel.Location = new System.Drawing.Point(50, 150);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(53, 21);
            this.DesdeLabel.TabIndex = 90;
            this.DesdeLabel.Text = "Desde";
            // 
            // IngresosLabel
            // 
            this.IngresosLabel.AutoSize = true;
            this.IngresosLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresosLabel.Location = new System.Drawing.Point(50, 253);
            this.IngresosLabel.Name = "IngresosLabel";
            this.IngresosLabel.Size = new System.Drawing.Size(69, 21);
            this.IngresosLabel.TabIndex = 90;
            this.IngresosLabel.Text = "Ingresos";
            // 
            // IngresosText
            // 
            this.IngresosText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IngresosText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IngresosText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.IngresosText.Location = new System.Drawing.Point(200, 247);
            this.IngresosText.MinValue = 0D;
            this.IngresosText.Name = "IngresosText";
            this.IngresosText.Size = new System.Drawing.Size(250, 29);
            this.IngresosText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IngresosText.TabIndex = 94;
            this.IngresosText.Text = "$0.00";
            // 
            // EgresosLabel
            // 
            this.EgresosLabel.AutoSize = true;
            this.EgresosLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EgresosLabel.Location = new System.Drawing.Point(50, 300);
            this.EgresosLabel.Name = "EgresosLabel";
            this.EgresosLabel.Size = new System.Drawing.Size(64, 21);
            this.EgresosLabel.TabIndex = 90;
            this.EgresosLabel.Text = "Egresos";
            // 
            // EgresosText
            // 
            this.EgresosText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EgresosText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EgresosText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.EgresosText.Location = new System.Drawing.Point(200, 294);
            this.EgresosText.MinValue = 0D;
            this.EgresosText.Name = "EgresosText";
            this.EgresosText.Size = new System.Drawing.Size(250, 29);
            this.EgresosText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.EgresosText.TabIndex = 94;
            this.EgresosText.Text = "$0.00";
            // 
            // PiezasLabel
            // 
            this.PiezasLabel.AutoSize = true;
            this.PiezasLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiezasLabel.Location = new System.Drawing.Point(50, 350);
            this.PiezasLabel.Name = "PiezasLabel";
            this.PiezasLabel.Size = new System.Drawing.Size(53, 21);
            this.PiezasLabel.TabIndex = 90;
            this.PiezasLabel.Text = "Piezas";
            // 
            // PiezasText
            // 
            this.PiezasText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PiezasText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PiezasText.HideTrailingZeros = true;
            this.PiezasText.Location = new System.Drawing.Point(200, 344);
            this.PiezasText.MinValue = 0D;
            this.PiezasText.Name = "PiezasText";
            this.PiezasText.Size = new System.Drawing.Size(250, 29);
            this.PiezasText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PiezasText.TabIndex = 94;
            this.PiezasText.Text = "0";
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
            this.ArrowButton.TabStop = false;
            this.ArrowButton.UseVisualStyleBackColor = true;
            // 
            // ProductividadLabel
            // 
            this.ProductividadLabel.AutoSize = true;
            this.ProductividadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductividadLabel.Location = new System.Drawing.Point(600, 150);
            this.ProductividadLabel.Name = "ProductividadLabel";
            this.ProductividadLabel.Size = new System.Drawing.Size(106, 21);
            this.ProductividadLabel.TabIndex = 90;
            this.ProductividadLabel.Text = "Productividad";
            // 
            // ProductividadText
            // 
            this.ProductividadText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductividadText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProductividadText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.ProductividadText.Location = new System.Drawing.Point(750, 144);
            this.ProductividadText.MinValue = 0D;
            this.ProductividadText.Name = "ProductividadText";
            this.ProductividadText.Size = new System.Drawing.Size(250, 29);
            this.ProductividadText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ProductividadText.TabIndex = 94;
            this.ProductividadText.Text = "$0.00";
            // 
            // CostoLabel
            // 
            this.CostoLabel.AutoSize = true;
            this.CostoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoLabel.Location = new System.Drawing.Point(600, 200);
            this.CostoLabel.Name = "CostoLabel";
            this.CostoLabel.Size = new System.Drawing.Size(100, 21);
            this.CostoLabel.TabIndex = 90;
            this.CostoLabel.Text = "Costo / Pieza";
            // 
            // CostoText
            // 
            this.CostoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostoText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CostoText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.CostoText.Location = new System.Drawing.Point(750, 194);
            this.CostoText.MinValue = 0D;
            this.CostoText.Name = "CostoText";
            this.CostoText.Size = new System.Drawing.Size(250, 29);
            this.CostoText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CostoText.TabIndex = 94;
            this.CostoText.Text = "$0.00";
            // 
            // GananciaLabel
            // 
            this.GananciaLabel.AutoSize = true;
            this.GananciaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GananciaLabel.Location = new System.Drawing.Point(600, 247);
            this.GananciaLabel.Name = "GananciaLabel";
            this.GananciaLabel.Size = new System.Drawing.Size(124, 21);
            this.GananciaLabel.TabIndex = 90;
            this.GananciaLabel.Text = "Ganancia / Pieza";
            // 
            // GananciaText
            // 
            this.GananciaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GananciaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GananciaText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.GananciaText.Location = new System.Drawing.Point(750, 241);
            this.GananciaText.MinValue = 0D;
            this.GananciaText.Name = "GananciaText";
            this.GananciaText.Size = new System.Drawing.Size(250, 29);
            this.GananciaText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GananciaText.TabIndex = 94;
            this.GananciaText.Text = "$0.00";
            // 
            // CalcularButton
            // 
            this.CalcularButton.AutoSize = true;
            this.CalcularButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(922, 300);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(78, 35);
            this.CalcularButton.TabIndex = 96;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 839);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.ArrowButton);
            this.Controls.Add(this.GananciaText);
            this.Controls.Add(this.CostoText);
            this.Controls.Add(this.ProductividadText);
            this.Controls.Add(this.PiezasText);
            this.Controls.Add(this.EgresosText);
            this.Controls.Add(this.IngresosText);
            this.Controls.Add(this.HastaPicker);
            this.Controls.Add(this.HastaLabel);
            this.Controls.Add(this.DesdePicker);
            this.Controls.Add(this.GananciaLabel);
            this.Controls.Add(this.CostoLabel);
            this.Controls.Add(this.ProductividadLabel);
            this.Controls.Add(this.PiezasLabel);
            this.Controls.Add(this.EgresosLabel);
            this.Controls.Add(this.IngresosLabel);
            this.Controls.Add(this.DesdeLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalculadoraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculadoraForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit HastaPicker;
        private System.Windows.Forms.Label HastaLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit DesdePicker;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.Label IngresosLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox IngresosText;
        private System.Windows.Forms.Label EgresosLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox EgresosText;
        private System.Windows.Forms.Label PiezasLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox PiezasText;
        private FontAwesome.Sharp.IconButton ArrowButton;
        private System.Windows.Forms.Label ProductividadLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox ProductividadText;
        private System.Windows.Forms.Label CostoLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox CostoText;
        private System.Windows.Forms.Label GananciaLabel;
        private Syncfusion.WinForms.Input.SfNumericTextBox GananciaText;
        private System.Windows.Forms.Button CalcularButton;
    }
}