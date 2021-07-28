
namespace CZS_LaVictoria.CuentasPage
{
    partial class PorPagarAgregarForm
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
            this.GuardarButton = new System.Windows.Forms.Button();
            this.PagadoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MontoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PagadoLabel = new System.Windows.Forms.Label();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.FechaLimitePicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaFacturaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaLimiteLabel = new System.Windows.Forms.Label();
            this.FechaFacturaLabel = new System.Windows.Forms.Label();
            this.NotasText = new System.Windows.Forms.TextBox();
            this.FacturaText = new System.Windows.Forms.TextBox();
            this.NotasLabel = new System.Windows.Forms.Label();
            this.FacturaLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.ProveedorLabel = new System.Windows.Forms.Label();
            this.ProveedorText = new System.Windows.Forms.TextBox();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.CondicionesLabel = new System.Windows.Forms.Label();
            this.CondicionesCombo = new System.Windows.Forms.ComboBox();
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
            this.MsgBox.Location = new System.Drawing.Point(50, 647);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 165);
            this.MsgBox.TabIndex = 18;
            this.MsgBox.TabStop = false;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(392, 597);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 37);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // PagadoText
            // 
            this.PagadoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PagadoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagadoText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PagadoText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.PagadoText.Location = new System.Drawing.Point(220, 347);
            this.PagadoText.MinValue = 0D;
            this.PagadoText.Name = "PagadoText";
            this.PagadoText.Size = new System.Drawing.Size(250, 29);
            this.PagadoText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PagadoText.TabIndex = 10;
            this.PagadoText.Text = "$0.00";
            this.PagadoText.WatermarkText = "Calculado automáticamente";
            // 
            // MontoText
            // 
            this.MontoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MontoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MontoText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.MontoText.Location = new System.Drawing.Point(220, 297);
            this.MontoText.MinValue = 0D;
            this.MontoText.Name = "MontoText";
            this.MontoText.Size = new System.Drawing.Size(250, 29);
            this.MontoText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MontoText.TabIndex = 8;
            this.MontoText.Text = "$0.00";
            this.MontoText.WatermarkText = "Calculado automáticamente";
            // 
            // PagadoLabel
            // 
            this.PagadoLabel.AutoSize = true;
            this.PagadoLabel.Location = new System.Drawing.Point(50, 350);
            this.PagadoLabel.Name = "PagadoLabel";
            this.PagadoLabel.Size = new System.Drawing.Size(111, 21);
            this.PagadoLabel.TabIndex = 9;
            this.PagadoLabel.Text = "Monto Pagado";
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.Location = new System.Drawing.Point(50, 300);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(118, 21);
            this.MontoLabel.TabIndex = 7;
            this.MontoLabel.Text = "Monto a Pagar*";
            // 
            // FechaLimitePicker
            // 
            this.FechaLimitePicker.AllowValueChangeOnMouseWheel = true;
            this.FechaLimitePicker.Location = new System.Drawing.Point(220, 444);
            this.FechaLimitePicker.Name = "FechaLimitePicker";
            this.FechaLimitePicker.Size = new System.Drawing.Size(250, 33);
            this.FechaLimitePicker.TabIndex = 14;
            // 
            // FechaFacturaPicker
            // 
            this.FechaFacturaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaFacturaPicker.Location = new System.Drawing.Point(220, 197);
            this.FechaFacturaPicker.Name = "FechaFacturaPicker";
            this.FechaFacturaPicker.Size = new System.Drawing.Size(250, 33);
            this.FechaFacturaPicker.TabIndex = 4;
            // 
            // FechaLimiteLabel
            // 
            this.FechaLimiteLabel.AutoSize = true;
            this.FechaLimiteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLimiteLabel.Location = new System.Drawing.Point(50, 450);
            this.FechaLimiteLabel.Name = "FechaLimiteLabel";
            this.FechaLimiteLabel.Size = new System.Drawing.Size(163, 21);
            this.FechaLimiteLabel.TabIndex = 13;
            this.FechaLimiteLabel.Text = "Fecha Límite de Pago*";
            // 
            // FechaFacturaLabel
            // 
            this.FechaFacturaLabel.AutoSize = true;
            this.FechaFacturaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFacturaLabel.Location = new System.Drawing.Point(50, 200);
            this.FechaFacturaLabel.Name = "FechaFacturaLabel";
            this.FechaFacturaLabel.Size = new System.Drawing.Size(125, 21);
            this.FechaFacturaLabel.TabIndex = 3;
            this.FechaFacturaLabel.Text = "Fecha de Factura";
            // 
            // NotasText
            // 
            this.NotasText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasText.Location = new System.Drawing.Point(220, 494);
            this.NotasText.Multiline = true;
            this.NotasText.Name = "NotasText";
            this.NotasText.Size = new System.Drawing.Size(250, 76);
            this.NotasText.TabIndex = 16;
            // 
            // FacturaText
            // 
            this.FacturaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaText.Location = new System.Drawing.Point(220, 147);
            this.FacturaText.Name = "FacturaText";
            this.FacturaText.Size = new System.Drawing.Size(250, 29);
            this.FacturaText.TabIndex = 2;
            // 
            // NotasLabel
            // 
            this.NotasLabel.AutoSize = true;
            this.NotasLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasLabel.Location = new System.Drawing.Point(50, 497);
            this.NotasLabel.Name = "NotasLabel";
            this.NotasLabel.Size = new System.Drawing.Size(51, 21);
            this.NotasLabel.TabIndex = 15;
            this.NotasLabel.Text = "Notas";
            // 
            // FacturaLabel
            // 
            this.FacturaLabel.AutoSize = true;
            this.FacturaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaLabel.Location = new System.Drawing.Point(50, 150);
            this.FacturaLabel.Name = "FacturaLabel";
            this.FacturaLabel.Size = new System.Drawing.Size(60, 21);
            this.FacturaLabel.TabIndex = 1;
            this.FacturaLabel.Text = "Factura";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(360, 37);
            this.SubtitleLabel.TabIndex = 0;
            this.SubtitleLabel.Text = "Agregar Pago Manualmente";
            // 
            // ProveedorLabel
            // 
            this.ProveedorLabel.AutoSize = true;
            this.ProveedorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorLabel.Location = new System.Drawing.Point(50, 250);
            this.ProveedorLabel.Name = "ProveedorLabel";
            this.ProveedorLabel.Size = new System.Drawing.Size(89, 21);
            this.ProveedorLabel.TabIndex = 5;
            this.ProveedorLabel.Text = "Proveedor*";
            // 
            // ProveedorText
            // 
            this.ProveedorText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorText.Location = new System.Drawing.Point(220, 247);
            this.ProveedorText.Name = "ProveedorText";
            this.ProveedorText.Size = new System.Drawing.Size(250, 29);
            this.ProveedorText.TabIndex = 6;
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // CondicionesLabel
            // 
            this.CondicionesLabel.AutoSize = true;
            this.CondicionesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CondicionesLabel.Location = new System.Drawing.Point(50, 400);
            this.CondicionesLabel.Name = "CondicionesLabel";
            this.CondicionesLabel.Size = new System.Drawing.Size(95, 21);
            this.CondicionesLabel.TabIndex = 11;
            this.CondicionesLabel.Text = "Condiciones";
            // 
            // CondicionesCombo
            // 
            this.CondicionesCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CondicionesCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CondicionesCombo.FormattingEnabled = true;
            this.CondicionesCombo.Location = new System.Drawing.Point(220, 397);
            this.CondicionesCombo.Name = "CondicionesCombo";
            this.CondicionesCombo.Size = new System.Drawing.Size(250, 29);
            this.CondicionesCombo.TabIndex = 12;
            // 
            // PorPagarAgregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 839);
            this.Controls.Add(this.CondicionesCombo);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.PagadoText);
            this.Controls.Add(this.MontoText);
            this.Controls.Add(this.PagadoLabel);
            this.Controls.Add(this.MontoLabel);
            this.Controls.Add(this.FechaLimitePicker);
            this.Controls.Add(this.FechaFacturaPicker);
            this.Controls.Add(this.FechaLimiteLabel);
            this.Controls.Add(this.FechaFacturaLabel);
            this.Controls.Add(this.NotasText);
            this.Controls.Add(this.ProveedorText);
            this.Controls.Add(this.FacturaText);
            this.Controls.Add(this.NotasLabel);
            this.Controls.Add(this.CondicionesLabel);
            this.Controls.Add(this.ProveedorLabel);
            this.Controls.Add(this.FacturaLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PorPagarAgregarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Pago Manualmente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfNumericTextBox PagadoText;
        private Syncfusion.WinForms.Input.SfNumericTextBox MontoText;
        private System.Windows.Forms.Label PagadoLabel;
        private System.Windows.Forms.Label MontoLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaLimitePicker;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaFacturaPicker;
        private System.Windows.Forms.Label FechaLimiteLabel;
        private System.Windows.Forms.Label FechaFacturaLabel;
        private System.Windows.Forms.TextBox NotasText;
        private System.Windows.Forms.TextBox FacturaText;
        private System.Windows.Forms.Label NotasLabel;
        private System.Windows.Forms.Label FacturaLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label ProveedorLabel;
        private System.Windows.Forms.TextBox ProveedorText;
        private System.Windows.Forms.Timer MsgBoxTimer;
        private System.Windows.Forms.Label CondicionesLabel;
        private System.Windows.Forms.ComboBox CondicionesCombo;
    }
}