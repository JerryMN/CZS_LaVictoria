
namespace CZS_LaVictoria.CuentasPage
{
    partial class PorCobrarCobrarForm
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
            this.NuevoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.PendienteText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.CobradoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.MontoText = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.NuevoLabel = new System.Windows.Forms.Label();
            this.PendienteLabel = new System.Windows.Forms.Label();
            this.CobradoLabel = new System.Windows.Forms.Label();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.FechaCobroPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaFacturaPicker = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.FechaCobroLabel = new System.Windows.Forms.Label();
            this.FechaFacturaLabel = new System.Windows.Forms.Label();
            this.NotasText = new System.Windows.Forms.TextBox();
            this.FacturaText = new System.Windows.Forms.TextBox();
            this.NumOrdenText = new System.Windows.Forms.TextBox();
            this.NotasLabel = new System.Windows.Forms.Label();
            this.FacturaLabel = new System.Windows.Forms.Label();
            this.NumOrdenLabel = new System.Windows.Forms.Label();
            this.MsgBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(50, 25);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(208, 37);
            this.SubtitleLabel.TabIndex = 17;
            this.SubtitleLabel.Text = "Registrar Cobro";
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
            this.MsgBox.Location = new System.Drawing.Point(50, 550);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(420, 165);
            this.MsgBox.TabIndex = 107;
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MsgBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MsgBox.UseVisualStyleBackColor = true;
            this.MsgBox.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AutoSize = true;
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(392, 500);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(78, 37);
            this.GuardarButton.TabIndex = 106;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoText
            // 
            this.NuevoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NuevoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NuevoText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.NuevoText.Location = new System.Drawing.Point(220, 447);
            this.NuevoText.MinValue = 0D;
            this.NuevoText.Name = "NuevoText";
            this.NuevoText.Size = new System.Drawing.Size(250, 29);
            this.NuevoText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NuevoText.TabIndex = 105;
            this.NuevoText.Text = "$0.00";
            this.NuevoText.WatermarkText = "Calculado automáticamente";
            // 
            // PendienteText
            // 
            this.PendienteText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PendienteText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendienteText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PendienteText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.PendienteText.Location = new System.Drawing.Point(220, 397);
            this.PendienteText.MinValue = 0D;
            this.PendienteText.Name = "PendienteText";
            this.PendienteText.ReadOnly = true;
            this.PendienteText.Size = new System.Drawing.Size(250, 29);
            this.PendienteText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PendienteText.TabIndex = 104;
            this.PendienteText.Text = "$0.00";
            this.PendienteText.WatermarkText = "Calculado automáticamente";
            // 
            // CobradoText
            // 
            this.CobradoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CobradoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CobradoText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CobradoText.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.CobradoText.Location = new System.Drawing.Point(220, 347);
            this.CobradoText.MinValue = 0D;
            this.CobradoText.Name = "CobradoText";
            this.CobradoText.Size = new System.Drawing.Size(250, 29);
            this.CobradoText.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CobradoText.TabIndex = 103;
            this.CobradoText.Text = "$0.00";
            this.CobradoText.WatermarkText = "Calculado automáticamente";
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
            this.MontoText.TabIndex = 102;
            this.MontoText.Text = "$0.00";
            this.MontoText.WatermarkText = "Calculado automáticamente";
            // 
            // NuevoLabel
            // 
            this.NuevoLabel.AutoSize = true;
            this.NuevoLabel.Location = new System.Drawing.Point(50, 450);
            this.NuevoLabel.Name = "NuevoLabel";
            this.NuevoLabel.Size = new System.Drawing.Size(110, 21);
            this.NuevoLabel.TabIndex = 100;
            this.NuevoLabel.Text = "Nuevo Cobro*";
            // 
            // PendienteLabel
            // 
            this.PendienteLabel.AutoSize = true;
            this.PendienteLabel.Location = new System.Drawing.Point(50, 400);
            this.PendienteLabel.Name = "PendienteLabel";
            this.PendienteLabel.Size = new System.Drawing.Size(128, 21);
            this.PendienteLabel.TabIndex = 99;
            this.PendienteLabel.Text = "Monto Pendiente";
            // 
            // CobradoLabel
            // 
            this.CobradoLabel.AutoSize = true;
            this.CobradoLabel.Location = new System.Drawing.Point(50, 350);
            this.CobradoLabel.Name = "CobradoLabel";
            this.CobradoLabel.Size = new System.Drawing.Size(120, 21);
            this.CobradoLabel.TabIndex = 101;
            this.CobradoLabel.Text = "Monto Cobrado";
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.Location = new System.Drawing.Point(50, 300);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(120, 21);
            this.MontoLabel.TabIndex = 98;
            this.MontoLabel.Text = "Monto a Cobrar";
            // 
            // FechaCobroPicker
            // 
            this.FechaCobroPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaCobroPicker.Location = new System.Drawing.Point(700, 247);
            this.FechaCobroPicker.Name = "FechaCobroPicker";
            this.FechaCobroPicker.Size = new System.Drawing.Size(250, 33);
            this.FechaCobroPicker.TabIndex = 97;
            // 
            // FechaFacturaPicker
            // 
            this.FechaFacturaPicker.AllowValueChangeOnMouseWheel = true;
            this.FechaFacturaPicker.Location = new System.Drawing.Point(220, 247);
            this.FechaFacturaPicker.Name = "FechaFacturaPicker";
            this.FechaFacturaPicker.Size = new System.Drawing.Size(250, 33);
            this.FechaFacturaPicker.TabIndex = 96;
            // 
            // FechaCobroLabel
            // 
            this.FechaCobroLabel.AutoSize = true;
            this.FechaCobroLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCobroLabel.Location = new System.Drawing.Point(550, 250);
            this.FechaCobroLabel.Name = "FechaCobroLabel";
            this.FechaCobroLabel.Size = new System.Drawing.Size(125, 21);
            this.FechaCobroLabel.TabIndex = 95;
            this.FechaCobroLabel.Text = "Fecha de Cobro*";
            // 
            // FechaFacturaLabel
            // 
            this.FechaFacturaLabel.AutoSize = true;
            this.FechaFacturaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFacturaLabel.Location = new System.Drawing.Point(50, 250);
            this.FechaFacturaLabel.Name = "FechaFacturaLabel";
            this.FechaFacturaLabel.Size = new System.Drawing.Size(125, 21);
            this.FechaFacturaLabel.TabIndex = 94;
            this.FechaFacturaLabel.Text = "Fecha de Factura";
            // 
            // NotasText
            // 
            this.NotasText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasText.Location = new System.Drawing.Point(700, 400);
            this.NotasText.Multiline = true;
            this.NotasText.Name = "NotasText";
            this.NotasText.Size = new System.Drawing.Size(250, 76);
            this.NotasText.TabIndex = 93;
            // 
            // FacturaText
            // 
            this.FacturaText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaText.Location = new System.Drawing.Point(220, 197);
            this.FacturaText.Name = "FacturaText";
            this.FacturaText.Size = new System.Drawing.Size(250, 29);
            this.FacturaText.TabIndex = 92;
            // 
            // NumOrdenText
            // 
            this.NumOrdenText.Enabled = false;
            this.NumOrdenText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOrdenText.Location = new System.Drawing.Point(220, 147);
            this.NumOrdenText.Name = "NumOrdenText";
            this.NumOrdenText.ReadOnly = true;
            this.NumOrdenText.Size = new System.Drawing.Size(250, 29);
            this.NumOrdenText.TabIndex = 91;
            // 
            // NotasLabel
            // 
            this.NotasLabel.AutoSize = true;
            this.NotasLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasLabel.Location = new System.Drawing.Point(550, 400);
            this.NotasLabel.Name = "NotasLabel";
            this.NotasLabel.Size = new System.Drawing.Size(51, 21);
            this.NotasLabel.TabIndex = 89;
            this.NotasLabel.Text = "Notas";
            // 
            // FacturaLabel
            // 
            this.FacturaLabel.AutoSize = true;
            this.FacturaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaLabel.Location = new System.Drawing.Point(50, 200);
            this.FacturaLabel.Name = "FacturaLabel";
            this.FacturaLabel.Size = new System.Drawing.Size(60, 21);
            this.FacturaLabel.TabIndex = 90;
            this.FacturaLabel.Text = "Factura";
            // 
            // NumOrdenLabel
            // 
            this.NumOrdenLabel.AutoSize = true;
            this.NumOrdenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOrdenLabel.Location = new System.Drawing.Point(50, 150);
            this.NumOrdenLabel.Name = "NumOrdenLabel";
            this.NumOrdenLabel.Size = new System.Drawing.Size(96, 21);
            this.NumOrdenLabel.TabIndex = 88;
            this.NumOrdenLabel.Text = "Núm. Orden";
            // 
            // MsgBoxTimer
            // 
            this.MsgBoxTimer.Interval = 3000;
            this.MsgBoxTimer.Tick += new System.EventHandler(this.MsgBoxTimer_Tick);
            // 
            // PorCobrarCobrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoText);
            this.Controls.Add(this.PendienteText);
            this.Controls.Add(this.CobradoText);
            this.Controls.Add(this.MontoText);
            this.Controls.Add(this.NuevoLabel);
            this.Controls.Add(this.PendienteLabel);
            this.Controls.Add(this.CobradoLabel);
            this.Controls.Add(this.MontoLabel);
            this.Controls.Add(this.FechaCobroPicker);
            this.Controls.Add(this.FechaFacturaPicker);
            this.Controls.Add(this.FechaCobroLabel);
            this.Controls.Add(this.FechaFacturaLabel);
            this.Controls.Add(this.NotasText);
            this.Controls.Add(this.FacturaText);
            this.Controls.Add(this.NumOrdenText);
            this.Controls.Add(this.NotasLabel);
            this.Controls.Add(this.FacturaLabel);
            this.Controls.Add(this.NumOrdenLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PorCobrarCobrarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Cobro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtitleLabel;
        private FontAwesome.Sharp.IconButton MsgBox;
        private System.Windows.Forms.Button GuardarButton;
        private Syncfusion.WinForms.Input.SfNumericTextBox NuevoText;
        private Syncfusion.WinForms.Input.SfNumericTextBox PendienteText;
        private Syncfusion.WinForms.Input.SfNumericTextBox CobradoText;
        private Syncfusion.WinForms.Input.SfNumericTextBox MontoText;
        private System.Windows.Forms.Label NuevoLabel;
        private System.Windows.Forms.Label PendienteLabel;
        private System.Windows.Forms.Label CobradoLabel;
        private System.Windows.Forms.Label MontoLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaCobroPicker;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FechaFacturaPicker;
        private System.Windows.Forms.Label FechaCobroLabel;
        private System.Windows.Forms.Label FechaFacturaLabel;
        private System.Windows.Forms.TextBox NotasText;
        private System.Windows.Forms.TextBox FacturaText;
        private System.Windows.Forms.TextBox NumOrdenText;
        private System.Windows.Forms.Label NotasLabel;
        private System.Windows.Forms.Label FacturaLabel;
        private System.Windows.Forms.Label NumOrdenLabel;
        private System.Windows.Forms.Timer MsgBoxTimer;
    }
}